using System.ComponentModel.DataAnnotations;

namespace enkeltnettbutikk_backend.Database_klasser
{
    public class Bestillling
    {
        [Key] // Bruk [Key] for å angi primærnøkkelen
        public int OrdreID { get; set; }
        public int KundeID { get; set; }
        public DateTime OrdreDato { get; set; }
        public string Bestillingsstatus { get; set; }

        public Bestillling() 
        {
            Bestillingsstatus = "";
        }
    }
}
