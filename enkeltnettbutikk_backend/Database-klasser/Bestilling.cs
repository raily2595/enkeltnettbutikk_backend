using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace enkeltnettbutikk_backend.Database_klasser
{
    public class Bestilling
    {
        private string ordreID = "";
        private string kundeID = "";
        private DateTime ordreDato;
        private string bestillingsstatus = "";

        [Key] // Bruk [Key] for å angi primærnøkkelen
        public string OrdreID { get => ordreID; set => ordreID = value; }

        public string KundeID { get => kundeID; set => kundeID = value; }
        [ForeignKey("KundeID")]

        public DateTime OrdreDato { get => ordreDato; set => ordreDato = value; }
        public string Bestillingsstatus { get => bestillingsstatus; set => bestillingsstatus = value; }
    }
}
