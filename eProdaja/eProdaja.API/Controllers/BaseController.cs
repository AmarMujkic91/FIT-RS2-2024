using eProdaja.Model;
using eProdaja.Model.SearchObject;
using eProdajaServices;
using Microsoft.AspNetCore.Mvc;

namespace eProdaja.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class BaseController<TModel, TSearch> : ControllerBase where TSearch : BaseSearchObject
    {
        protected IService<TModel, TSearch> _dbService;

        public BaseController(IService<TModel, TSearch> dbService)
        { 
            _dbService = dbService;
        }

        [HttpGet]
        public PagedResult<TModel> GetList([FromQuery] TSearch searchObject)
        {
            return _dbService.GetList(searchObject);
        }
    }
}
