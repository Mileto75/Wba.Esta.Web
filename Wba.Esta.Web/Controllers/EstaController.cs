using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Wba.Esta.Web.ViewModels;

namespace Wba.Esta.Web.Controllers
{
    public class EstaController : Controller
    {
        [HttpGet]
        public IActionResult Apply()
        {
            //init the form
            var estaApplyViewModel = new EstaApplyViewModel();
            estaApplyViewModel.Arrival = DateTime.Now.Date;
            //countries
            estaApplyViewModel.Countries
                = new List<SelectListItem>
                {
                    new SelectListItem{Text = "België", Value ="1"},
                    new SelectListItem{Text = "Nederland", Value ="2"},
                };

            return View(estaApplyViewModel);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Process(EstaApplyViewModel estaApplyViewModel)
        {
            //check for errors
            if (!ModelState.IsValid)
            {
                estaApplyViewModel.Countries
                = new List<SelectListItem>
                {
                    new SelectListItem{Text = "België", Value ="1"},
                    new SelectListItem{Text = "Nederland", Value ="2"},
                };
                return View("Apply",estaApplyViewModel);
            }
            //custom errors
            //date cannot be in the past
            if(estaApplyViewModel.Arrival.Date < DateTime.Now.Date)
            {
                ModelState.AddModelError("Arrival", "Date must be in the future");
                estaApplyViewModel.Countries
                = new List<SelectListItem>
                {
                    new SelectListItem{Text = "België", Value ="1"},
                    new SelectListItem{Text = "Nederland", Value ="2"},
                };
                return View("Apply",estaApplyViewModel);
            }
            //no more errors
            // post redirect get principe
            return RedirectToAction("Registered");
        }
        public IActionResult Registered()
        {
            return View();
        }
    }
}
