using enkeltnettbutikk_backend.Database_klasser;

namespace enkeltnettbutikk_backend
{
    public class Bestillingsforespørsel
    {
        public DateTime OrdreDato { get; set; }
        public string Bestillingsstatus { get; set; }
        public string Navn { get; set; }
        public string Epost { get; set; }
        public string Adresse { get; set; }
        public int Postnr { get; set; }
        public string Poststed { get; set; }
        public int Telefon { get; set; }
        public string Betalingsmetode { get; set; }
        public string Betalingsstatus { get; set; }
        public List<Produktforespørsel> Produkter { get; set; }
        public int Totalt { get; set; }

        public Bestillingsforespørsel()
        {
            Bestillingsstatus = "motatt";
            Navn = "";
            Epost = "";
            Adresse = "";
            Poststed = "";
            Betalingsmetode = "";
            Betalingsstatus = "ikke betalt";
            Produkter = new List<Produktforespørsel>();
        }
    }
    public class Produktforespørsel
    {
        public string Produktnavn { get; set; }
        public string KategoriNavn { get; set; }
        public string Farge { get; set; }
        public string? Farge2 { get; set; }
        public int Lengde { get; set; }
        public int Bredde { get; set; }
        public string Detaljefarger { get; set; }
        public string? Klips { get; set; }
        public string? Vinyltekst { get; set; }
        public string? Fontfarge { get; set; }
        public string? Font { get; set; }
        public int Pris { get; set; }

        public Produktforespørsel()
        {
            KategoriNavn = "";
            Produktnavn = "";
            Farge = "";
            Detaljefarger = "";
        }
    }
}
