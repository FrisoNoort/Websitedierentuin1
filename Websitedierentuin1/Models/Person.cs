using System.ComponentModel.DataAnnotations;

namespace Websitedierentuin1.Models
{
    public class Person
    {
        [Required(ErrorMessage = "Gelieve uw voornaam in te vullen")]
        [Display(Name = "Voornaam")]
        public string voornaam { get; set; }

        [Required(ErrorMessage = "Achternaam is een verplicht veld")]
        [Display(Name = "Achternaam")]
        public string achternaam { get; set; }

        [Required(ErrorMessage = "Emailadres is verplicht")]
        [EmailAddress(ErrorMessage = "Geen geldig email adres")]
        [Display(Name = "Email")]
        public string email { get; set; }

        public string telefoonnummer { get; set; }

        public string adres { get; set; }

        [Required(ErrorMessage = "Bericht is verplicht")]
        [Display(Name = "Onderwerp")]
        public string onderwerp { get; set; }
    }
}