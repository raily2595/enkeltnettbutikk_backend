namespace enkeltnettbutikk_backend.Database_klasser
{
    public class Produkt
    {
        public int ProduktID { get; set; }
        public int KategoriID { get; set; }
        public string KategoriNavn { get; set; }
        public string Produktnavn { get; set; }
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

        public Produkt()
        {
            KategoriNavn = "";
            Produktnavn = "";
            Farge = "";
            Detaljefarger = "";
        }
    }
}
