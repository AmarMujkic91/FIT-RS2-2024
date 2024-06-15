using eProdaja.Model.SearchObject;
using eProdaja.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eProdajaServices
{
    public interface IVrsteProizvodumService
    {
        List<VrsteProizvodum> GetList(VrsteProizvodumSearchObject searchObject);
    }
}
