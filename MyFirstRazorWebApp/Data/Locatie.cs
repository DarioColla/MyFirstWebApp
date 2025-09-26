namespace MyFirstRazorWebApp.Data
{
    public class Locatie
    {
        public int LocatieID { get; set; }
        public string PostCode { get; set; }
        public string Gemeente { get; set; }

        public Locatie(int locatieId, string postcode, string gemeente)
        {
            this.LocatieID = locatieId;
            this.PostCode = postcode;
            this.Gemeente = gemeente;
            
        }

        public Locatie()
        {
            
        }

    }
}
