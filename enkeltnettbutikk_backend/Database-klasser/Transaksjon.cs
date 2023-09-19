namespace enkeltnettbutikk_backend.Database_klasser
{
    public class Transaksjon
    {
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
