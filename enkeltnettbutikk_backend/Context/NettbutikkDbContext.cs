using enkeltnettbutikk_backend.Database_klasser;
using Microsoft.EntityFrameworkCore;

namespace enkeltnettbutikk_backend.Context
{
    public class NettbutikkDbContext :DbContext
    {
        public NettbutikkDbContext(DbContextOptions<NettbutikkDbContext> options) : base(options)
        {
        }

        // Legg til DbSet-egenskaper for hver modell som skal kartlegges til en database tabell
        public DbSet<Bestillingsdetalj> Bestillingsdetalj { get; set; }
        public DbSet<Bestillling> Bestilling { get; set; }
        public DbSet<Kunde> Kunde {  get; set; }
        public DbSet<Produkt> Produkt { get; set; }
        public DbSet<Transaksjon> Transaksjon { get; set;}
        public DbSet<NettsideOrdre> NettsideOrdrer { get; set; }
    }
}
