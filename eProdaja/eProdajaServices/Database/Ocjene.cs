using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eProdajaServices.Database
{
    public partial class Ocjene
    {
        [Key]
        public int OcjenaId { get; set; }

        public int ProizvodId { get; set; }

        public int KupacId { get; set; }

        public DateTime Datum { get; set; }

        public int Ocjena { get; set; }

        public virtual Kupci Kupac { get; set; } = null!;

        public virtual Proizvodi Proizvod { get; set; } = null!;
    }
}
