
using eProdaja.Model.SearchObject;
using eProdajaServices.Database;
using MapsterMapper;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eProdajaServices
{
    public class ProizvodiService : BaseService<eProdaja.Model.Proizvodi,ProizvodiSearchObject,Proizvodi>, IProizvodiServices
    {
    //    public EProdajaContext _dbContext { get; set; }
    //    public IMapper _mapper { get; set; }

        public ProizvodiService(EProdajaContext dbContext,IMapper mapper):base(dbContext,mapper) 
        { 
            //_dbContext = dbContext;
            //_mapper = mapper;
        }

        public override IQueryable<Proizvodi> AddFilter(ProizvodiSearchObject search, IQueryable<Proizvodi> query)
        {
            var filteredQuery = base.AddFilter(search, query);

            if (!string.IsNullOrEmpty(search?.FTS))
            {
                filteredQuery = filteredQuery.Where(x => x.Naziv == search.FTS || x.Sifra == search.FTS);
            }

            return filteredQuery;
        }



        //public virtual List<eProdaja.Model.Proizvodi> GetList(ProizvodiSearchObject searchObject)
        //{
        //    //var list = _dbContext.Proizvodi.ToList();
        //    //var listM = new List<eProdaja.Model.Proizvodi>();

        //    //list.ForEach(item =>
        //    //{
        //    //    listM.Add(new eProdaja.Model.Proizvodi()
        //    //    {
        //    //        ProizvodId = item.ProizvodId,
        //    //        Cijena = item.Cijena,
        //    //        Naziv = item.Naziv
        //    //    });
        //    //});

        //    //return listM;

        //    List<eProdaja.Model.Proizvodi> result = new List<eProdaja.Model.Proizvodi>();

        //    var query = _dbContext.Proizvodi.AsQueryable();

        //    if (!string.IsNullOrEmpty(searchObject?.FTS))
        //    {
        //        query = query.Where(x=>x.Naziv == searchObject.FTS || x.Sifra == searchObject.FTS);
        //    }

        //    var list = query.ToList();
        //    result = _mapper.Map(list,result);
        //    return result;
        //}
    }
}
