namespace NemanjiciWebApp.Models
{
    public class Proizvod
    {
        public int Id { get; set; }
        public string Naziv { get; set; }           // npr. "Knjiga: Dinastija Nemanjića"
        public string Opis { get; set; }            // kratak opis proizvoda
        public decimal Cena { get; set; }           // npr. 1999.99m
        public string Kategorija { get; set; }      // "Knjige", "Suveniri", "Posteri"
        public string PutanjaSlike { get; set; }    // "/slike/proizvodi/knjiga-nemanjici.jpg"
    }
}
