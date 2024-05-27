using eProdaja.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eProdajaServices
{
    public class ProizvodiService : IProizvodiServices
    {
        List<Proizvodi> list = new List<Proizvodi>()
        {
            new Proizvodi()
            {
                ProizvodId = 1,
                Naziv = "Laptop",
                Cijena = 1099
            },
            new Proizvodi()
            {
                ProizvodId = 2,
                Naziv = "Tablet",
                Cijena = 56
            }
        };

        public List<Proizvodi> GetList()
        {
            return list;
        }
    }
}
