using Microsoft.AspNetCore.Mvc;

namespace FirstWebApplication.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index() //actions
        {
            return View();
    

        }
    
        public IActionResult Skills() //actions
        {
            return View();
        }
        public IActionResult Projects() //actions
        {
            return View();
        }
        public IActionResult Contact() //actions
        {
            return View();
        }
    }
}
