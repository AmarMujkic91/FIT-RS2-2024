using eProdaja.Model.SearchObject;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eProdajaServices
{
    public interface ICRUDEService<TModel, TSearch, TInsert, TUpdate> : IService<TModel,TSearch> where TModel : class where TSearch : BaseSearchObject
    {
        TModel Insert(TModel model);
        TModel Update(int id,TUpdate model);
    }
}
