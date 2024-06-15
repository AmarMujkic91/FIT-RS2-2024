using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eProdajaServices.Database
{
    public partial class Izlazi
    {
        [Key]
        public int IzlazId { get; set; }

        public string BrojRacuna { get; set; } = null!;

        public DateTime Datum { get; set; }

        public int KorisnikId { get; set; }

        public bool Zakljucen { get; set; }

        public decimal IznosBezPdv { get; set; }

        public decimal IznosSaPdv { get; set; }

        public int? NarudzbaId { get; set; }

        public int SkladisteId { get; set; }

        public virtual ICollection<IzlazStavke> IzlazStavkes { get; } = new List<IzlazStavke>();

        public virtual Korisnici Korisnik { get; set; } = null!;

        public virtual Narudzbe? Narudzba { get; set; }

        public virtual Skladistum Skladiste { get; set; } = null!;
    }
}
