using System.ComponentModel.DataAnnotations;

namespace enkeltnettbutikk_backend.Database_klasser
{
    public class Transaksjon
    {
        [Key] // Bruk [Key] for å angi primærnøkkelen
        public int TransaksjonsID { get; set; }
        public int OrdreID { get; set; }
        public string Betalingsmetode { get; set; }
        public string Betalingsstatus { get; set; }
        public int Totalt { get; set; }

        public Transaksjon ()
        {
            Betalingsmetode = "";
            Betalingsstatus = "";
        }
    }
}
