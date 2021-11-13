using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Configuration;

namespace OdeToFood.Pages.Restaurants
{
    public class ListModel : PageModel
    {
        private readonly IConfiguration config;

        public string message { get; set; }

        public ListModel(IConfiguration config)
        {
            this.config = config;
        }
        public void OnGet()
        {
            message = config["Message"]; //"Hello World!";
        }
    }
}
