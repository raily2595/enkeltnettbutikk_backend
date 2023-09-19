namespace enkeltnettbutikk_backend.Database_klasser
{
    public class Bestillling
    {
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
