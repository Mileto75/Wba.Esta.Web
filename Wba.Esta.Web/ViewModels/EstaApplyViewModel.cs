using Microsoft.AspNetCore.Mvc.Rendering;
using System.ComponentModel.DataAnnotations;

namespace Wba.Esta.Web.ViewModels
{
    public class EstaApplyViewModel
    {
        [DataType(DataType.Date)]
        [Required(ErrorMessage = "Aankomstdatum verplicht!")]
        [Display(Name = "Aankomstdatum")]
        public DateTime Arrival { get; set; }
        [DataType(DataType.EmailAddress, ErrorMessage = "Geef een correct emailadres in!")]
        [Required(ErrorMessage = "Email verplicht!")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Telefoon verplicht!")]
        [DataType(DataType.PhoneNumber,ErrorMessage = "Graag correct formaat!")]
        [Display(Name = "Tel")]
        public string Phone { get; set; }
        [Required(ErrorMessage = "Postcode verplicht!")]
        [Display(Name = "Postcode")]
        public string PostalCode { get; set; }
        [Display(Name = "Straat en huisnummer")]
        
        [Required(ErrorMessage = "Straat en huisnummer verplicht!")]
        public string StreetAndNumber { get; set; }
        
        [Display(Name = "Stad")]

        [Required(ErrorMessage = "Woonplaats verplicht!")]
        public string Municipality { get; set; }
        [Display(Name = "Provincie")]

        [Required(ErrorMessage = "Provincie verplicht!")]
        
        public string Province { get; set; }
        //list of countries
        [Display(Name = "Land")]
        public int SelectedCountryId { get; set; }
        public IEnumerable<SelectListItem> Countries { get; set; }

        [Display(Name = "Ook post?")]
        public bool ByMail { get; set; }
    }
}
