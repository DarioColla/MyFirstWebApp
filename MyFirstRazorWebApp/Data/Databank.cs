namespace MyFirstRazorWebApp.Data
{
    public class Databank
    {
        public static List<Klant> Klanten { get; set; }
        public static List<Locatie> locaties { get; set; }
        public static List<KlantLocatie> klantLocatieOverzicht { get; set; }

        public static void StartDatabank()
        {
            Klanten = new List<Klant>();
            Klanten.Add(new Klant(1, "Klant A", 1));
            Klanten.Add(new Klant(2, "Klant B",2));

            locaties = new List<Locatie>();
            locaties.Add(new Locatie(1, "3500", "Hasselt"));
            locaties.Add(new Locatie(2, "3600", "Genk"));

            klantLocatieOverzicht = new List<KlantLocatie>();

            foreach (var Klant in Klanten)
            {
                int locatieId = Klant.LocatieId;
                string naam = Klant.KlantNaam;
                string locatie = locaties.Where(x => x.LocatieID == locatieId).Select(x => x.Gemeente).First();
                klantLocatieOverzicht.Add(new KlantLocatie(naam, locatie));
            }
        }

        public static void AddLocation(string postcode, string city)
        {
            int id = locaties.Max(x => x.LocatieID) + 1;
            locaties.Add(new Locatie(id, postcode, city));
        }

        public static void AddClient(string naam, int locatieID)
        {
            int id = Klanten.Max(x => x.KlantId) + 1;
            Klanten.Add(new Klant(id, naam, locatieID));


            string locatie = locaties.Where(x => x.LocatieID == locatieID).Select(x => x.Gemeente).First();
            klantLocatieOverzicht.Add(new KlantLocatie(naam, locatie));
        }
    }
}
