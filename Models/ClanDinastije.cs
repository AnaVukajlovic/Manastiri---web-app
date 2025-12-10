namespace NemanjiciWebApp.Models
{
    public class ClanDinastije
    {
        public int Id { get; set; }
        public string Ime { get; set; }              // npr. "Stefan Nemanja"
        public string Uloga { get; set; }           // npr. "vladar", "član porodice"
        public int? RoditeljId { get; set; }        // Id roditelja (null za koren)
        public string? Period { get; set; }         // npr. "1166–1196" ako je vladar
        public string? Napomena { get; set; }       // dodatne info (npr. "osnivač dinastije")
    }
}
