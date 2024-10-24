using Microsoft.AspNetCore.Mvc.Rendering;
using System.ComponentModel.DataAnnotations;

namespace Wba.Esta.Web.ViewModels
{
    public class EstaApplyViewModel
    {
        [Required(ErrorMessage = "Date of arrival is required!")]
        [Display(Name = "Date of Arrival")]
        [DataType(DataType.Date)]
        public DateTime Arrivaldate { get; set; }
        [Required(ErrorMessage = "Email is required!")]
        [Display(Name = "Email")]
        [DataType(DataType.EmailAddress)]
        public string EmailAddress { get; set; }
        [Required(ErrorMessage = "Phone is required!")]
        [Display(Name = "Phone")]
        [DataType(DataType.PhoneNumber)]
        public string Phone { get; set; }
        [Display(Name = "Postal Code")]
        [Required(ErrorMessage = "Postal code is required!")]
        public string  PostalCode { get; set; }
        [Required(ErrorMessage = "Street and number are required!")]
        [Display(Name = "Street and number")]
        public string StreetNumber { get; set; }
        [Required(ErrorMessage = "Municipality is required!")]
        [Display(Name = "Municipality")]
        public string Municipality { get; set; }
        [Required(ErrorMessage = "Province is required!")]
        [Display(Name = "Province")]
        public string Province { get; set; }
        [Display(Name = "Country")]
        [Required]
        public int CountryId { get; set; }
        public IEnumerable<SelectListItem> Countries { get; set; }
        [Display(Name = "Also by mail?")]
        public bool ByMail { get; set; }
    }
}
