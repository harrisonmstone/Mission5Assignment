using Microsoft.AspNetCore.Mvc;

// Defines the namespace that this controller is part of
namespace FirstASPWebApp.Controllers
{
    // Declares the HomeController class which inherits from Controller base class, making it an MVC controller
    public class HomeController : Controller
    {
        // Action method for handling requests to the root URL or home page of the site
        // When a request is made to the site's base URL, this method will be called
        public IActionResult Index()
        {
            // Returns the default view associated with the Index action
            // This typically renders the Index.cshtml view within the Views/Home directory
            return View();
        }

        // Action method for handling requests to the "/Home/Hobby" URL
        // This can be accessed by navigating to {site's base URL}/Home/Hobby in a web browser
        public IActionResult Hobby()
        {
            // Returns the default view associated with the Hobby action
            // This typically renders the Hobby.cshtml view within the Views/Home directory
            return View();
        }
    }
}
