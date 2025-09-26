namespace MyFirstRazorWebApp.Data
{
    public class KlantLocatie
    {
        public string naam { get; set; }
        public string locatie { get; set; }

        public KlantLocatie(string naam, string locatie)
        {
            this.naam = naam;
            this.locatie = locatie;
            
        }

    }

    
}
