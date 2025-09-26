using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MyFirstRazorWebApp.Data;

namespace MyFirstRazorWebApp.Pages
{
    public class NieuweKlantModel : PageModel
    {
        public void OnGet()
        {

        }

        public IActionResult OnPost()
        {
            string naam = Request.Form["Naam"];
            string locatieId = Request.Form["SelectLocatie"];
            int locatieIdint = int.Parse(locatieId);
            Databank.AddClient(naam, locatieIdint);
            return RedirectToPage("Klant");
        }
    }
}
