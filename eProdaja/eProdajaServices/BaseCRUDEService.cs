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
    public abstract class BaseCRUDEService<TModel, TSearch, TDbEntity, TInsert, TUpdate> : 
                          BaseService<TModel, TSearch, TDbEntity> where TModel : class where TDbEntity : class where TSearch : BaseSearchObject,
                          ICRUDEService<TModel, TSearch, TInsert, TUpdate>
    {
        public BaseCRUDEService(EProdajaContext dbService,IMapper mapper) :base(dbService,mapper) { }
    }
}
