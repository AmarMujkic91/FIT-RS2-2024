using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace eProdajaServices.Migrations
{
    /// <inheritdoc />
    public partial class kreiranjeBaze : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Dobavljaci",
                columns: table => new
                {
                    DobavljacId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Naziv = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    KontaktOsoba = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Adresa = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Telefon = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Fax = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Web = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ZiroRacuni = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Napomena = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Status = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Dobavljaci", x => x.DobavljacId);
                });

            migrationBuilder.CreateTable(
                name: "JediniceMjere",
                columns: table => new
                {
                    JedinicaMjereId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Naziv = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_JediniceMjere", x => x.JedinicaMjereId);
                });

            migrationBuilder.CreateTable(
                name: "Korisnici",
                columns: table => new
                {
                    KorisnikId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ime = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Prezime = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Telefon = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    KorisnickoIme = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LozinkaHash = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LozinkaSalt = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Status = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Korisnici", x => x.KorisnikId);
                });

            migrationBuilder.CreateTable(
                name: "Kupci",
                columns: table => new
                {
                    KupacId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ime = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Prezime = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DatumRegistracije = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    KorisnickoIme = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LozinkaHash = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LozinkaSalt = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Status = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Kupci", x => x.KupacId);
                });

            migrationBuilder.CreateTable(
                name: "Skladistum",
                columns: table => new
                {
                    SkladisteId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Naziv = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Adresa = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Opis = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Skladistum", x => x.SkladisteId);
                });

            migrationBuilder.CreateTable(
                name: "Uloge",
                columns: table => new
                {
                    UlogaId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Naziv = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Opis = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Uloge", x => x.UlogaId);
                });

            migrationBuilder.CreateTable(
                name: "VrsteProizvodum",
                columns: table => new
                {
                    VrstaId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Naziv = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VrsteProizvodum", x => x.VrstaId);
                });

            migrationBuilder.CreateTable(
                name: "Narudzbe",
                columns: table => new
                {
                    NarudzbaId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BrojNarudzbe = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    KupacId = table.Column<int>(type: "int", nullable: false),
                    Datum = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Status = table.Column<bool>(type: "bit", nullable: false),
                    Otkazano = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Narudzbe", x => x.NarudzbaId);
                    table.ForeignKey(
                        name: "FK_Narudzbe_Kupci_KupacId",
                        column: x => x.KupacId,
                        principalTable: "Kupci",
                        principalColumn: "KupacId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Ulazi",
                columns: table => new
                {
                    UlazId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BrojFakture = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Datum = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IznosRacuna = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Pdv = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Napomena = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SkladisteId = table.Column<int>(type: "int", nullable: false),
                    KorisnikId = table.Column<int>(type: "int", nullable: false),
                    DobavljacId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ulazi", x => x.UlazId);
                    table.ForeignKey(
                        name: "FK_Ulazi_Dobavljaci_DobavljacId",
                        column: x => x.DobavljacId,
                        principalTable: "Dobavljaci",
                        principalColumn: "DobavljacId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Ulazi_Korisnici_KorisnikId",
                        column: x => x.KorisnikId,
                        principalTable: "Korisnici",
                        principalColumn: "KorisnikId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Ulazi_Skladistum_SkladisteId",
                        column: x => x.SkladisteId,
                        principalTable: "Skladistum",
                        principalColumn: "SkladisteId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "KorisniciUloge",
                columns: table => new
                {
                    KorisnikUlogaId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    KorisnikId = table.Column<int>(type: "int", nullable: false),
                    UlogaId = table.Column<int>(type: "int", nullable: false),
                    DatumIzmjene = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KorisniciUloge", x => x.KorisnikUlogaId);
                    table.ForeignKey(
                        name: "FK_KorisniciUloge_Korisnici_KorisnikId",
                        column: x => x.KorisnikId,
                        principalTable: "Korisnici",
                        principalColumn: "KorisnikId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_KorisniciUloge_Uloge_UlogaId",
                        column: x => x.UlogaId,
                        principalTable: "Uloge",
                        principalColumn: "UlogaId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Proizvodi",
                columns: table => new
                {
                    ProizvodId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Naziv = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Sifra = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Cijena = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    VrstaId = table.Column<int>(type: "int", nullable: false),
                    JedinicaMjereId = table.Column<int>(type: "int", nullable: false),
                    Slika = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    SlikaThumb = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    Status = table.Column<bool>(type: "bit", nullable: true),
                    StateMachine = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Proizvodi", x => x.ProizvodId);
                    table.ForeignKey(
                        name: "FK_Proizvodi_JediniceMjere_JedinicaMjereId",
                        column: x => x.JedinicaMjereId,
                        principalTable: "JediniceMjere",
                        principalColumn: "JedinicaMjereId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Proizvodi_VrsteProizvodum_VrstaId",
                        column: x => x.VrstaId,
                        principalTable: "VrsteProizvodum",
                        principalColumn: "VrstaId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Izlazi",
                columns: table => new
                {
                    IzlazId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BrojRacuna = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Datum = table.Column<DateTime>(type: "datetime2", nullable: false),
                    KorisnikId = table.Column<int>(type: "int", nullable: false),
                    Zakljucen = table.Column<bool>(type: "bit", nullable: false),
                    IznosBezPdv = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    IznosSaPdv = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    NarudzbaId = table.Column<int>(type: "int", nullable: true),
                    SkladisteId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Izlazi", x => x.IzlazId);
                    table.ForeignKey(
                        name: "FK_Izlazi_Korisnici_KorisnikId",
                        column: x => x.KorisnikId,
                        principalTable: "Korisnici",
                        principalColumn: "KorisnikId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Izlazi_Narudzbe_NarudzbaId",
                        column: x => x.NarudzbaId,
                        principalTable: "Narudzbe",
                        principalColumn: "NarudzbaId");
                    table.ForeignKey(
                        name: "FK_Izlazi_Skladistum_SkladisteId",
                        column: x => x.SkladisteId,
                        principalTable: "Skladistum",
                        principalColumn: "SkladisteId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "NarudzbaStavke",
                columns: table => new
                {
                    NarudzbaStavkaId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NarudzbaId = table.Column<int>(type: "int", nullable: false),
                    ProizvodId = table.Column<int>(type: "int", nullable: false),
                    Kolicina = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NarudzbaStavke", x => x.NarudzbaStavkaId);
                    table.ForeignKey(
                        name: "FK_NarudzbaStavke_Narudzbe_NarudzbaId",
                        column: x => x.NarudzbaId,
                        principalTable: "Narudzbe",
                        principalColumn: "NarudzbaId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_NarudzbaStavke_Proizvodi_ProizvodId",
                        column: x => x.ProizvodId,
                        principalTable: "Proizvodi",
                        principalColumn: "ProizvodId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Ocjene",
                columns: table => new
                {
                    OcjenaId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProizvodId = table.Column<int>(type: "int", nullable: false),
                    KupacId = table.Column<int>(type: "int", nullable: false),
                    Datum = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Ocjena = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ocjene", x => x.OcjenaId);
                    table.ForeignKey(
                        name: "FK_Ocjene_Kupci_KupacId",
                        column: x => x.KupacId,
                        principalTable: "Kupci",
                        principalColumn: "KupacId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Ocjene_Proizvodi_ProizvodId",
                        column: x => x.ProizvodId,
                        principalTable: "Proizvodi",
                        principalColumn: "ProizvodId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UlazStavke",
                columns: table => new
                {
                    UlazStavkaId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UlazId = table.Column<int>(type: "int", nullable: false),
                    ProizvodId = table.Column<int>(type: "int", nullable: false),
                    Kolicina = table.Column<int>(type: "int", nullable: false),
                    Cijena = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UlazStavke", x => x.UlazStavkaId);
                    table.ForeignKey(
                        name: "FK_UlazStavke_Proizvodi_ProizvodId",
                        column: x => x.ProizvodId,
                        principalTable: "Proizvodi",
                        principalColumn: "ProizvodId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UlazStavke_Ulazi_UlazId",
                        column: x => x.UlazId,
                        principalTable: "Ulazi",
                        principalColumn: "UlazId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "IzlazStavke",
                columns: table => new
                {
                    IzlazStavkaId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IzlazId = table.Column<int>(type: "int", nullable: false),
                    ProizvodId = table.Column<int>(type: "int", nullable: false),
                    Kolicina = table.Column<int>(type: "int", nullable: false),
                    Cijena = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Popust = table.Column<decimal>(type: "decimal(18,2)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IzlazStavke", x => x.IzlazStavkaId);
                    table.ForeignKey(
                        name: "FK_IzlazStavke_Izlazi_IzlazId",
                        column: x => x.IzlazId,
                        principalTable: "Izlazi",
                        principalColumn: "IzlazId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_IzlazStavke_Proizvodi_ProizvodId",
                        column: x => x.ProizvodId,
                        principalTable: "Proizvodi",
                        principalColumn: "ProizvodId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Izlazi_KorisnikId",
                table: "Izlazi",
                column: "KorisnikId");

            migrationBuilder.CreateIndex(
                name: "IX_Izlazi_NarudzbaId",
                table: "Izlazi",
                column: "NarudzbaId");

            migrationBuilder.CreateIndex(
                name: "IX_Izlazi_SkladisteId",
                table: "Izlazi",
                column: "SkladisteId");

            migrationBuilder.CreateIndex(
                name: "IX_IzlazStavke_IzlazId",
                table: "IzlazStavke",
                column: "IzlazId");

            migrationBuilder.CreateIndex(
                name: "IX_IzlazStavke_ProizvodId",
                table: "IzlazStavke",
                column: "ProizvodId");

            migrationBuilder.CreateIndex(
                name: "IX_KorisniciUloge_KorisnikId",
                table: "KorisniciUloge",
                column: "KorisnikId");

            migrationBuilder.CreateIndex(
                name: "IX_KorisniciUloge_UlogaId",
                table: "KorisniciUloge",
                column: "UlogaId");

            migrationBuilder.CreateIndex(
                name: "IX_NarudzbaStavke_NarudzbaId",
                table: "NarudzbaStavke",
                column: "NarudzbaId");

            migrationBuilder.CreateIndex(
                name: "IX_NarudzbaStavke_ProizvodId",
                table: "NarudzbaStavke",
                column: "ProizvodId");

            migrationBuilder.CreateIndex(
                name: "IX_Narudzbe_KupacId",
                table: "Narudzbe",
                column: "KupacId");

            migrationBuilder.CreateIndex(
                name: "IX_Ocjene_KupacId",
                table: "Ocjene",
                column: "KupacId");

            migrationBuilder.CreateIndex(
                name: "IX_Ocjene_ProizvodId",
                table: "Ocjene",
                column: "ProizvodId");

            migrationBuilder.CreateIndex(
                name: "IX_Proizvodi_JedinicaMjereId",
                table: "Proizvodi",
                column: "JedinicaMjereId");

            migrationBuilder.CreateIndex(
                name: "IX_Proizvodi_VrstaId",
                table: "Proizvodi",
                column: "VrstaId");

            migrationBuilder.CreateIndex(
                name: "IX_Ulazi_DobavljacId",
                table: "Ulazi",
                column: "DobavljacId");

            migrationBuilder.CreateIndex(
                name: "IX_Ulazi_KorisnikId",
                table: "Ulazi",
                column: "KorisnikId");

            migrationBuilder.CreateIndex(
                name: "IX_Ulazi_SkladisteId",
                table: "Ulazi",
                column: "SkladisteId");

            migrationBuilder.CreateIndex(
                name: "IX_UlazStavke_ProizvodId",
                table: "UlazStavke",
                column: "ProizvodId");

            migrationBuilder.CreateIndex(
                name: "IX_UlazStavke_UlazId",
                table: "UlazStavke",
                column: "UlazId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "IzlazStavke");

            migrationBuilder.DropTable(
                name: "KorisniciUloge");

            migrationBuilder.DropTable(
                name: "NarudzbaStavke");

            migrationBuilder.DropTable(
                name: "Ocjene");

            migrationBuilder.DropTable(
                name: "UlazStavke");

            migrationBuilder.DropTable(
                name: "Izlazi");

            migrationBuilder.DropTable(
                name: "Uloge");

            migrationBuilder.DropTable(
                name: "Proizvodi");

            migrationBuilder.DropTable(
                name: "Ulazi");

            migrationBuilder.DropTable(
                name: "Narudzbe");

            migrationBuilder.DropTable(
                name: "JediniceMjere");

            migrationBuilder.DropTable(
                name: "VrsteProizvodum");

            migrationBuilder.DropTable(
                name: "Dobavljaci");

            migrationBuilder.DropTable(
                name: "Korisnici");

            migrationBuilder.DropTable(
                name: "Skladistum");

            migrationBuilder.DropTable(
                name: "Kupci");
        }
    }
}
