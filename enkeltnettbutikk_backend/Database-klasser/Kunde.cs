namespace enkeltnettbutikk_backend.Database_klasser
{
    public class Kunde
    {
        public int KundeID { get; set; }
        public string Navn { get; set; }
        public string Epost { get; set; }
        public string Adresse { get; set; }
        public int Postnr { get; set; }
        public string Poststed { get; set; }
        public int Telefon { get; set; }

        public Kunde() 
        {
            Navn = "";
            Epost = "";
            Adresse = "";
            Poststed = "";
        }
    }
}
