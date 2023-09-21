using System.ComponentModel.DataAnnotations;

namespace enkeltnettbutikk_backend.Database_klasser
{
    public class Kategori
    {
        [Key] // Bruk [Key] for å angi primærnøkkelen
        public int KategoriID {get; set; }
        public string KategoriNavn { get; set; }

        public Kategori()
        {
            KategoriNavn = "";
        }
    }
}
