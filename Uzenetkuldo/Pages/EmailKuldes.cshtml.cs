using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Uzenetkuldo.Pages
{
    public class EmailKuldesModel : PageModel
    {
        [BindProperty]
        public string email { get; set; } //Ez itt a fogad� email c�me, amti megadunk.

        [BindProperty]
        public string Szoveg { get; set; }

        public void OnPost()
        {
            email ujEmail = new email();

            ujEmail.Fogado = email;

            ujEmail.Szoveg = Szoveg;

            ujEmail.KuldesDatuma = DateTime.Now;

            ujEmail.Kuldo = Tarhely.EmailCim; //Be�ll�tjuk azt az email c�met, amivel bel�pt�nk

            Tarhely.ElkuldottUzenetek.Add(ujEmail);
        }
    }
}
