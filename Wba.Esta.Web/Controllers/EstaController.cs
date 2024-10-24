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
            //create the viewmodel
            //fill the countries List
            var estaApplyViewModel = new EstaApplyViewModel();
            estaApplyViewModel.Countries
                = new List<SelectListItem> 
                { 
                    new SelectListItem{Value="0",Text="Choose a country",Selected=true,Disabled=true},
                    new SelectListItem{Value="1",Text="België" },
                    new SelectListItem{Value="2",Text="Nederland" },
                    new SelectListItem{Value="3",Text="Luxemburg" },
                };
            estaApplyViewModel.Arrivaldate = DateTime.Now;
            return View(estaApplyViewModel);
        }
        [HttpPost]
        public IActionResult Process(EstaApplyViewModel estaApplyViewModel)
        {
            //test the date
            if(estaApplyViewModel.Arrivaldate <= DateTime.Now)
            {
                //add model error
                ModelState.AddModelError("ArrivalDate", "Must be in the future!");
            }
            if(!ModelState.IsValid)
            {
                estaApplyViewModel.Countries
                = new List<SelectListItem>
                {
                    new SelectListItem{Value="0",Text="Choose a country",Selected=true,Disabled=true},
                    new SelectListItem{Value="1",Text="België" },
                    new SelectListItem{Value="2",Text="Nederland" },
                    new SelectListItem{Value="3",Text="Luxemburg" },
                };
                return View("Apply",estaApplyViewModel);
            }
            return RedirectToAction("Succes","Esta");
        }
        [HttpGet]
        public IActionResult Succes()
        {
            return View(); 
        }
    }
}
