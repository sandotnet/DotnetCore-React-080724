using HandsOnModel.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace HandsOnModel.Pages
{
    public class GetAllModel : PageModel
    {
        static List<Product> products = new List<Product>()
        {
            new Product(){Id=1,Price=300,Name="Mouse",Stock=10},
              new Product(){Id=2,Price=543,Name="Keyboard",Stock=10},
                new Product(){Id=3,Price=675,Name="Pendrive",Stock=10},
        };
        [BindProperty]
        public Product Product { get; set; }
        public List<Product> List
        {
            get { return products; }
        }
        public void OnGet()
        {
        }
        public IActionResult OnPost()
        {
           
            products.Add(Product);
            return RedirectToPage("GetAll");
            
        }
    }
}
