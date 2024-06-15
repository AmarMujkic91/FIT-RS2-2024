using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eProdajaServices.Database
{
    public partial class Ulazi
    {
        [Key]
        public int UlazId { get; set; }

        public string BrojFakture { get; set; } = null!;

        public DateTime Datum { get; set; }

        public decimal IznosRacuna { get; set; }

        public decimal Pdv { get; set; }

        public string? Napomena { get; set; }

        public int SkladisteId { get; set; }

        public int KorisnikId { get; set; }

        public int DobavljacId { get; set; }

        public virtual Dobavljaci Dobavljac { get; set; } = null!;

        public virtual Korisnici Korisnik { get; set; } = null!;

        public virtual Skladistum Skladiste { get; set; } = null!;

        public virtual ICollection<UlazStavke> UlazStavkes { get; } = new List<UlazStavke>();
    }
}
