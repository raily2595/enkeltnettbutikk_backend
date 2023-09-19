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
        public DbSet<Bestillingsdetalj> Bestillingsdetaljer { get; set; }
        public DbSet<Bestillling> Bestillinger { get; set; }
        public DbSet<Kategori> Kategorier { get; set; }
        public DbSet<Kunde> Kunder {  get; set; }
        public DbSet<Produkt> Produkter { get; set; }
        public DbSet<Transaksjon> Transaksjoner { get; set;}
        public DbSet<NettsideOrdre> NettsideOrdrer { get; set; }
    }
}
