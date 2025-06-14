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
            else //Ha túl hosszú email címet adunk meg, akkor az fut le.
            {
                throw new Exception("Gáz van. Túl hosszú email címet adtál meg.");
            }

        }
    }
}
