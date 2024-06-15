using eProdaja.Model.SearchObject;
using eProdajaServices.Database;
using MapsterMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using eProdaja.Model;

namespace eProdajaServices
{
    public class VrsteProizvodumService : IVrsteProizvodumService
    {
        public EProdajaContext _dbContext { get; set; }
        public IMapper _mapper { get; set; }

        public VrsteProizvodumService(EProdajaContext dbContext, IMapper mapper)
        {
            _dbContext = dbContext;
            _mapper = mapper;
        }

        public List<eProdaja.Model.VrsteProizvodum> GetList(VrsteProizvodumSearchObject searchObject)
        {
            List<eProdaja.Model.VrsteProizvodum> result = new List<eProdaja.Model.VrsteProizvodum> ();

            var query = _dbContext.VrsteProizvodum.AsQueryable();

            if (!string.IsNullOrEmpty(searchObject?.Naziv))
            {
                query = query.Where(x => x.Naziv == searchObject.Naziv);
            }

            var list = query.ToList();

            result = _mapper.Map(list, result);

            return result;
        }
    }
}
