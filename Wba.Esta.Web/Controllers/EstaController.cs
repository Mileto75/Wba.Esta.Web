using Microsoft.AspNetCore.Mvc;

namespace Wba.Esta.Web.Controllers
{
    public class EstaController : Controller
    {
        [HttpGet]
        public IActionResult Apply()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Process()
        {
            return View("Apply");
        }
        [HttpGet]
        public IActionResult Succes()
        {
            return View(); 
        }
    }
}
