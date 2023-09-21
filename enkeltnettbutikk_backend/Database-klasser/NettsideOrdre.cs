using System.ComponentModel.DataAnnotations;

namespace enkeltnettbutikk_backend.Database_klasser
{
    public class NettsideOrdre
    {
        [Key] // Bruk [Key] for å angi primærnøkkelen
        public int NettsideOrdreID { get; set; }
        public int OrdreID { get; set; }
        public DateTime OrdreDato { get; set; }
        public string Bestillingsstatus { get; set; }
        public string Navn { get; set; }
        public string Epost { get; set; }
        public string Adresse { get; set; }
        public int Postnr { get; set; }
        public string Poststed { get; set; }
        public string Telefon { get; set; }
        public string Betalingsmetode { get; set; }
        public string Betalingsstatus { get; set; }
        public List<Produkt> Produkter { get; set; }
        public int Totalt { get; set; }

        public NettsideOrdre() 
        {
            Bestillingsstatus = "";
            Navn = "";
            Epost = "";
            Adresse = "";
            Poststed = "";
            Betalingsmetode = "";
            Betalingsstatus = "";
            Produkter = new List<Produkt>();
            Telefon = "";
        }
    }
}
