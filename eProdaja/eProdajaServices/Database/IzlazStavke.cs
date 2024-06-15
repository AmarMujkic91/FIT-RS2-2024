using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eProdajaServices.Database
{
    public partial class IzlazStavke
    {
        [Key]
        public int IzlazStavkaId { get; set; }

        public int IzlazId { get; set; }

        public int ProizvodId { get; set; }

        public int Kolicina { get; set; }

        public decimal Cijena { get; set; }

        public decimal? Popust { get; set; }

        public virtual Izlazi Izlaz { get; set; } = null!;

        public virtual Proizvodi Proizvod { get; set; } = null!;
    }
}
