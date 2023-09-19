namespace enkeltnettbutikk_backend.Database_klasser
{
    public class Kategori
    {
        public int KategoriID {get; set; }
        public string KategoriNavn { get; set; }

        public Kategori()
        {
            KategoriNavn = "";
        }
    }
}
