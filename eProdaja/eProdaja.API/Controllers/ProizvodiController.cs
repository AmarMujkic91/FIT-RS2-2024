using eProdaja.Model;
using eProdajaServices;
using Microsoft.AspNetCore.Mvc;

namespace eProdaja.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProizvodiController : ControllerBase
    {
        protected IProizvodiServices _dbService;

        public ProizvodiController(IProizvodiServices dbService)
        {
            _dbService = dbService;
        }

        [HttpGet]
        public List<Proizvodi> GetList()
        {
            return _dbService.GetList();
        }
    }
}
