using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eProdajaServices.Database
{
    public partial class Skladistum
    {
        [Key]
        public int SkladisteId { get; set; }

        public string Naziv { get; set; } = null!;

        public string? Adresa { get; set; }

        public string? Opis { get; set; }

        public virtual ICollection<Izlazi> Izlazis { get; } = new List<Izlazi>();

        public virtual ICollection<Ulazi> Ulazis { get; } = new List<Ulazi>();
    }
}
