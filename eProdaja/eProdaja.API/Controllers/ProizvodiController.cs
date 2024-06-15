using eProdaja.Model;
using eProdaja.Model.SearchObject;
using eProdajaServices;
using Microsoft.AspNetCore.Mvc;

namespace eProdaja.API.Controllers
{
    //[ApiController]
    //[Route("[controller]")]
    //public class ProizvodiController : ControllerBase
    //{
    //    protected IProizvodiServices _dbService;

    //    public ProizvodiController(IProizvodiServices dbService)
    //    {
    //        _dbService = dbService;
    //    }

    //    [HttpGet]
    //    public PagedResult<Proizvodi> GetList([FromQuery]ProizvodiSearchObject searchObject)
    //    {
    //        return _dbService.GetList(searchObject);
    //    }
    //}

    [ApiController]
    [Route("[controller]")]
    public class ProizvodiController : BaseController<Proizvodi,ProizvodiSearchObject>
    {
        public ProizvodiController(IProizvodiServices dbService):base(dbService) 
        {

        }
    }
}
