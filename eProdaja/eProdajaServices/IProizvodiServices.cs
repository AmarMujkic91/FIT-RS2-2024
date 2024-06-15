using eProdaja.Model;
using eProdaja.Model.SearchObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eProdajaServices
{
    public interface IProizvodiServices : IService<Proizvodi,ProizvodiSearchObject>
    {
       // List<Proizvodi> GetList(ProizvodiSearchObject searchObject); 
    }
}
