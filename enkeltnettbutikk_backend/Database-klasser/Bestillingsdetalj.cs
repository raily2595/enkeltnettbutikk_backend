using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace enkeltnettbutikk_backend.Database_klasser
{
    public class Bestillingsdetalj
    {
        private string bestillingsdetaljeID = "";
        private string ordreID = "";
        private string produktID = "";
        private int delsum;

        [Key] // Bruk [Key] for å angi primærnøkkelen
        public string BestillingsdetaljeID { get => bestillingsdetaljeID; set => bestillingsdetaljeID = value; }

        public string OrdreID { get => ordreID; set => ordreID = value; }
        [ForeignKey("OrdreID")]

        public string ProduktID { get => produktID; set => produktID = value; }
        [ForeignKey("ProduktID")]

        public int Delsum { get => delsum; set => delsum = value; }
    }
}
