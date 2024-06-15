using eProdaja.Model;
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
    public abstract class BaseService<TModel, TSearch, TDbEntity> : IService<TModel, TSearch> where TSearch : BaseSearchObject where TDbEntity : class where TModel : class
    {
        public EProdajaContext _dbService { get; set; }   //Entity Framework  -- baza 
        public IMapper _mapper { get; set; }               // automaper 

        public BaseService(EProdajaContext dbService, IMapper mapper)
        {
            _dbService = dbService;
            _mapper = mapper;
        }

        public TModel GetById(int id)
        {
            var entity = _dbService.Set<TDbEntity>().Find(id);

            if(entity != null)
            {
                return _mapper.Map<TModel>(entity);
            }
            else
            {
                return null;
            }
        }

        public PagedResult<TModel> GetList(TSearch search)
        {
            List<TModel>result=new List<TModel>();

            var query = _dbService.Set<TDbEntity>().AsQueryable();
            query = AddFilter(search,query);

            int count = query.Count();

            if(search?.Page.HasValue == true && search?.PageSize.HasValue == true)
            {
                query = query.Skip(search.Page.Value * search.PageSize.Value).Take(search.PageSize.Value);
            }

            var list = query.ToList();
            result = _mapper.Map(list, result); 

            PagedResult<TModel> pagedResult = new PagedResult<TModel>();
            pagedResult.ResultList = result;
            pagedResult.Count = count;

            return pagedResult ;
        }

        public virtual IQueryable<TDbEntity> AddFilter(TSearch search,IQueryable<TDbEntity>query)
        {
            return query;
        }

    }
}
