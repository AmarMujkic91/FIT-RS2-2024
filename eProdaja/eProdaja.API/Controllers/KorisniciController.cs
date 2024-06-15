using eProdaja.Model.Requests;
using eProdaja.Model.SearchObject;
using eProdajaServices;
using Microsoft.AspNetCore.Mvc;

namespace eProdaja.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class KorisniciController : ControllerBase
    {
        protected IKorisniciService _services;

        public KorisniciController (IKorisniciService services)
        {
            _services = services;
        }

        [HttpGet]
        public List<Model.Korisnici> GetList([FromQuery]KorisniciSearchObject searchObject)
        {
            return _services.GetList(searchObject);
        }

        [HttpPost]
        public Model.Korisnici Insert(KorisniciInsertRequest item)
        {
            return _services.Insert(item);
        }

        [HttpPut("{id}")]
        public Model.Korisnici Update(int id, KorisniciUpdateRequest item)
        {
            return _services.Update(id, item); 
        }
    }
}
