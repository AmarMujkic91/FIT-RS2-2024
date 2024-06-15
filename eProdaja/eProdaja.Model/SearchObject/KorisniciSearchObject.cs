using System;
using System.Collections.Generic;
using System.Text;

namespace eProdaja.Model.SearchObject
{
    public class KorisniciSearchObject
    {
        public string? Ime { get; set; } 

        public string? Prezime { get; set; }

        public string? Email { get; set; } 

        public string? KorisnickoIme { get; set; }

        public bool? IsKorisniciUlogeIncluded { get; set; }
    }
}
