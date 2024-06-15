using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eProdajaServices.Database
{

    public partial class EProdajaContext : DbContext
    {

        public EProdajaContext()
        {
        }

        public EProdajaContext(DbContextOptions<EProdajaContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Dobavljaci> Dobavljaci { get; set; }
        public virtual DbSet<Izlazi> Izlazi { get; set; }
        public virtual DbSet<IzlazStavke> IzlazStavke { get; set; }
        public virtual DbSet<JediniceMjere> JediniceMjere { get; set; }
        public virtual DbSet<Korisnici> Korisnici { get; set; }

        public virtual DbSet<KorisniciUloge> KorisniciUloge { get; set; }
        public virtual DbSet<Kupci> Kupci { get; set; }
        public virtual DbSet<NarudzbaStavke> NarudzbaStavke { get; set; }
        public virtual DbSet<Narudzbe> Narudzbe { get; set; }
        public virtual DbSet<Ocjene> Ocjene { get; set; }

        public virtual DbSet<Proizvodi> Proizvodi { get; set; }
        public virtual DbSet<Skladistum> Skladistum { get; set; }
        public virtual DbSet<Ulazi> Ulazi { get; set; }
        public virtual DbSet<UlazStavke> UlazStavke { get; set; }
        public virtual DbSet<Uloge> Uloge { get; set; }

        public virtual DbSet<VrsteProizvodum> VrsteProizvodum { get; set; }

    }
}