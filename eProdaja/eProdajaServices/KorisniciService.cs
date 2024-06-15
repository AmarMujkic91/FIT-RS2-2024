using eProdaja.Model.Requests;
using eProdaja.Model.SearchObject;
using eProdajaServices.Database;
using MapsterMapper;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace eProdajaServices
{
    public class KorisniciService : IKorisniciService
    {
        public EProdajaContext _dbContext { get; set; } 
        public IMapper _mapper;

        public KorisniciService(EProdajaContext dbContext,IMapper mapper)
        {
            _dbContext = dbContext; 
            _mapper = mapper;
        }

        public List<eProdaja.Model.Korisnici> GetList(KorisniciSearchObject searchObject)
        {

            //V1 bez search

            // List<eProdaja.Model.Korisnici> listM = new List<eProdaja.Model.Korisnici>();
            //var lisit = _dbContext.Korisnici.ToList();
            //lisit.ForEach(item => listM.Add(new eProdaja.Model.Korisnici() 
            //{
            //    KorisnikId = item.KorisnikId,
            //    Ime = item.Ime,
            //    Prezime = item.Prezime,
            //    Email = item.Email,
            //    KorisnickoIme = item.KorisnickoIme,
            //    Status = item.Status,
            //    Telefon = item.Telefon
            //})
            //)

            List<eProdaja.Model.Korisnici> listM = new List<eProdaja.Model.Korisnici>();

            var query = _dbContext.Korisnici.AsQueryable();

            if (!string.IsNullOrEmpty(searchObject?.Ime))
            {
                query = query.Where(x => x.Ime == searchObject.Ime);
            }

            if (!string.IsNullOrEmpty(searchObject?.Prezime))
            {
                query = query.Where(x => x.Prezime == searchObject.Prezime);
            }

            if (!string.IsNullOrEmpty(searchObject?.Email))
            {
                query = query.Where(x => x.Email == searchObject.Email);
            }

            if (!string.IsNullOrEmpty(searchObject?.KorisnickoIme))
            {
                query = query.Where(x => x.KorisnickoIme == searchObject.KorisnickoIme);
            }

            if (searchObject.IsKorisniciUlogeIncluded == true)
            {
                query = query.Include(x => x.KorisniciUloges).ThenInclude(x => x.Uloga);
            }
            
            var lisit = query.ToList();

            listM = _mapper.Map(lisit,listM);

            return listM;
        }

        public eProdaja.Model.Korisnici Insert(KorisniciInsertRequest item)
        {
            if (item.Lozinka != item.LozinkaPotvrda)
            {
                throw new Exception("Lozinka i lozinka potvrda moraju bit iste!");
            }

            Korisnici entity= new Korisnici();

            _mapper.Map(item, entity);

            entity.LozinkaSalt = GenerateSalt();
            entity.LozinkaHash = GenerateHash(entity.LozinkaSalt, item.Lozinka);

            _dbContext.Add(entity);
            _dbContext.SaveChanges();

            return _mapper.Map<eProdaja.Model.Korisnici>(entity);
        }

        public eProdaja.Model.Korisnici Update(int id, KorisniciUpdateRequest item)
        {
            Korisnici entity = _dbContext.Korisnici.Find(id);

            _mapper.Map(item,entity);

            if (item.Lozinka != null)
            {
                if (item.Lozinka != item.Lozinka)
                {
                    throw new Exception("Lozinke moraju bit iste");
                }
                entity.LozinkaSalt = GenerateSalt();
                entity.LozinkaHash = GenerateHash(entity.LozinkaSalt, item.Lozinka); 
            }

            _dbContext.SaveChanges();
            return _mapper.Map<eProdaja.Model.Korisnici>(entity);   
        }

        public static string GenerateSalt()
        {
            RNGCryptoServiceProvider provider = new RNGCryptoServiceProvider();
            var byteArray = new byte[16];
            provider.GetBytes(byteArray);
            return Convert.ToBase64String(byteArray);
        }

        public static string GenerateHash(string salt, string password)
        {
            byte[] src = Convert.FromBase64String(salt);
            byte[] bytes = Encoding.Unicode.GetBytes(password);
            byte[] dst = new byte[src.Length + bytes.Length];

            System.Buffer.BlockCopy(src, 0, dst, 0, src.Length);
            System.Buffer.BlockCopy(bytes, 0, dst, src.Length, bytes.Length);

            HashAlgorithm algorithm = HashAlgorithm.Create("SHA1");
            byte[] inArray = algorithm.ComputeHash(dst);
            return Convert.ToBase64String(inArray);
        }
    }
}
