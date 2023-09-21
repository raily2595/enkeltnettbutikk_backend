using System.ComponentModel.DataAnnotations;

namespace enkeltnettbutikk_backend.Database_klasser
{
    public class Bestillingsdetalj
    {
        [Key] // Bruk [Key] for å angi primærnøkkelen
        public int BestillingsdetaljerID {  get; set; }
        public int OrdreID { get; set; }
        public int ProduktID { get; set; }
        public int Delsum {  get; set; }
    }
}
