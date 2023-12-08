namespace enkeltnettbutikk_backend
{
    public class Bestillingsforespørsel
    {
        private string navn = "";
        private string adresse = "";
        private string epost = "";
        private string postnr = "";
        private string poststed = "";
        private string telefon = "";
        private string betalingsmetode = "";
        private int totalt;
        private List<Produktforespørsel> produkter = new();

        public string Navn { get => navn; set => navn = value; }
        public string Epost { get => epost; set => epost = value; }
        public string Adresse { get => adresse; set => adresse = value; }
        public string Postnr { get => postnr; set => postnr = value; }
        public string Poststed { get => poststed; set => poststed = value; }
        public string Telefon { get => telefon; set => telefon = value; }
        public string Betalingsmetode { get => betalingsmetode; set => betalingsmetode = value; }
        public List<Produktforespørsel> Produkter { get => produkter; set => produkter = value; }
        public int Totalt { get => totalt; set => totalt = value; }
    }
    public class Produktforespørsel
    {
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
