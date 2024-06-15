using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eProdajaServices.Database
{
    public partial class Kupci
    {
        [Key]
        public int KupacId { get; set; }

        public string Ime { get; set; } = null!;

        public string Prezime { get; set; } = null!;

        public DateTime DatumRegistracije { get; set; }

        public string Email { get; set; } = null!;

        public string KorisnickoIme { get; set; } = null!;

        public string LozinkaHash { get; set; } = null!;

        public string LozinkaSalt { get; set; } = null!;

        public bool Status { get; set; }

        public virtual ICollection<Narudzbe> Narudzbes { get; } = new List<Narudzbe>();

        public virtual ICollection<Ocjene> Ocjenes { get; } = new List<Ocjene>();
    }
}
