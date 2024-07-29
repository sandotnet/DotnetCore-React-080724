using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace MyFirstApplication.Pages
{
    public class InfoModel : PageModel
    {
        public string Message { get; set; }
       
        public void OnGet() //Actio method 
        {
            Message = "Good Morning Users!!!";
            throw new Exception("Sample Check");
        }
       
        public void OnPost()
        {
            Message = "Good Evening Users!!!";
        }
    }
}
