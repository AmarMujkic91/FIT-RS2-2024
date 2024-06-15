using eProdaja.Model;
using eProdaja.Model.Requests;
using eProdaja.Model.SearchObject;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eProdajaServices
{
    public interface IKorisniciService
    {
        List<Korisnici> GetList(KorisniciSearchObject searchObject);
        Korisnici Insert(KorisniciInsertRequest item);
        Korisnici Update(int id, KorisniciUpdateRequest item);
    }
}
