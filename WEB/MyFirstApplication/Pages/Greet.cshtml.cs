using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace MyFirstApplication.Pages
{
    public class GreetModel : PageModel
    {
        [BindProperty]
        public string Name { get; set; } 
            = "Sachin";
        public void OnGet()
        {
        }
    }
}
