using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Uzenetkuldo.Pages
{
    public class BelepesModel : PageModel
    {
        [BindProperty]
        public string Email { get; set; }
        public void OnPost()
        {
            if (Email.Length <=200)
            {
                Tarhely.EmailCim = Email;
            }
            else //Ha t�l hossz� email c�met adunk meg, akkor az fut le.
            {
                throw new Exception("G�z van. T�l hossz� email c�met adt�l meg.");
            }

        }
    }
}
