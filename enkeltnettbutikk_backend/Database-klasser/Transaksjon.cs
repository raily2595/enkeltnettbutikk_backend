using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace enkeltnettbutikk_backend.Database_klasser
{
    public class Transaksjon
    {
        private string transaksjonsID = "";
        private string ordreID = "";
        private string betalingsmetode = "";
        private string betalingsstatus = "" ;
        private int totalt;

        [Key] // Bruk [Key] for å angi primærnøkkelen
        public string TransaksjonsID { get => transaksjonsID; set => transaksjonsID = value; }

        public string OrdreID { get => ordreID; set => ordreID = value; }
        [ForeignKey("OrdreID")]

        public string Betalingsmetode { get => betalingsmetode; set => betalingsmetode = value; }
        public string Betalingsstatus { get => betalingsstatus; set => betalingsstatus = value; }
        public int Totalt { get => totalt; set => totalt = value; }
    }
}
