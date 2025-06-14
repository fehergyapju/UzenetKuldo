using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Uzenetkuldo.Pages
{
    public class EmailKuldesModel : PageModel
    {
        [BindProperty]
        public string email { get; set; } //Ez itt a fogadó email címe, amti megadunk.

        [BindProperty]
        public string Szoveg { get; set; }

        public void OnPost()
        {
            email ujEmail = new email();

            ujEmail.Fogado = email;

            ujEmail.Szoveg = Szoveg;

            ujEmail.KuldesDatuma = DateTime.Now;

            ujEmail.Kuldo = Tarhely.EmailCim; //Beállítjuk azt az email címet, amivel beléptünk

            Tarhely.ElkuldottUzenetek.Add(ujEmail);
        }
    }
}
