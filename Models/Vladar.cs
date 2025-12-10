namespace NemanjiciWebApp.Models
{
    public class Vladar
    {
        public int Id { get; set; }
        public string Ime { get; set; }              // npr. "Stefan Nemanja"
        public string PeriodVladavine { get; set; }  // npr. "1166–1196"
        public string KratakOpis { get; set; }       // par rečenica
        public string PutanjaSlike { get; set; }     // npr. "/slike/vladari/stefan-nemanja.jpg"
    }
}
