using eProdaja.Model.SearchObject;
using eProdajaServices;
using Microsoft.AspNetCore.Mvc;


namespace eProdaja.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class VrsteProizvodumController : ControllerBase
    {
        protected IVrsteProizvodumService _dbService;

        public VrsteProizvodumController(IVrsteProizvodumService dbService)
        {
            _dbService = dbService;
        }

        [HttpGet]
        public virtual List<Model.VrsteProizvodum> GetList([FromQuery] VrsteProizvodumSearchObject searchObject)
        {
            return _dbService.GetList(searchObject);
        }
    }
}
