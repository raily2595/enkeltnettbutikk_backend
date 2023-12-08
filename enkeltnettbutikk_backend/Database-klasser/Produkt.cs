using System.ComponentModel.DataAnnotations;

namespace enkeltnettbutikk_backend.Database_klasser
{
    public class Produkt
    {
        private string produktID = "";
        private string produktnavn = "";
        private string farge = "";
        private string? farge2;
        private int lengde;
        private int bredde;
        private string detaljefarger = "";
        private string? klips;
        private string? vinyltekst;
        private string? fontfarge;
        private string? font;
        private int pris;
        private string? kommentar;
        private string? valgtleke;

        [Key] // Bruk [Key] for å angi primærnøkkelen
        public string ProduktID { get => produktID; set => produktID = value; }
        public string Produktnavn { get => produktnavn; set => produktnavn = value; }
        public string Farge { get => farge; set => farge = value; }
        public string? Farge2 { get => farge2; set => farge2 = value; }
        public int Lengde { get => lengde; set => lengde = value; }
        public int Bredde { get => bredde; set => bredde = value; }
        public string Detaljefarger { get => detaljefarger; set => detaljefarger = value; }
        public string? Klips { get => klips; set => klips = value; }
        public string? Vinyltekst { get => vinyltekst; set => vinyltekst = value; }
        public string? Fontfarge { get => fontfarge; set => fontfarge = value; }
        public string? Font { get => font; set => font = value; }
        public int Pris { get => pris; set => pris = value; }
        public string? Kommentar { get => kommentar; set => kommentar = value; }
        public string? Valgtleke { get => valgtleke; set => valgtleke = value; }
    }
}
