using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eProdajaServices.Database
{
    public partial class NarudzbaStavke
    {
        [Key]
        public int NarudzbaStavkaId { get; set; }

        public int NarudzbaId { get; set; }

        public int ProizvodId { get; set; }

        public int Kolicina { get; set; }

        public virtual Narudzbe Narudzba { get; set; } = null!;

        public virtual Proizvodi Proizvod { get; set; } = null!;
    }
}
