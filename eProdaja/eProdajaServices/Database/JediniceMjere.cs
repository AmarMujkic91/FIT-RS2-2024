using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eProdajaServices.Database
{
    public partial class JediniceMjere
    {
        [Key]
        public int JedinicaMjereId { get; set; }

        public string Naziv { get; set; } = null!;

        public virtual ICollection<Proizvodi> Proizvodis { get; } = new List<Proizvodi>();
    }
}
