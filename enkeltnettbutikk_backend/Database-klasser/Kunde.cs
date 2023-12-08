using System.ComponentModel.DataAnnotations;

namespace enkeltnettbutikk_backend.Database_klasser
{
    public class Kunde
    {
        private string kundeID = "";
        private string navn = "";
        private string epost = "";
        private string adresse = "";
        private string postnr = "";
        private string poststed = "";
        private string telefon = "";

        [Key] // Bruk [Key] for å angi primærnøkkelen
        public string KundeID { get => kundeID; set => kundeID = value; }
        public string Navn { get => navn; set => navn = value; }
        public string Epost { get => epost; set => epost = value; }
        public string Adresse { get => adresse; set => adresse = value; }
        public string Postnr { get => postnr; set => postnr = value; }
        public string Poststed { get => poststed; set => poststed = value; }
        public string Telefon { get => telefon; set => telefon = value; }
    }
}
