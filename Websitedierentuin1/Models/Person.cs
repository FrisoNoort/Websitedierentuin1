using System.ComponentModel.DataAnnotations;

namespace Websitedierentuin1.Models
{
    public class Person
    {
        [Required(ErrorMessage = "Gelieve uw voornaam in te vullen")]
        public string voornaam { get; set; }
        [Required(ErrorMessage = "Gelieve uw achternaam in te vullen")]
        public string achternaam { get; set; }
        [EmailAddress(ErrorMessage = "Emailadres is verplicht")]
        public string email { get; set; }
        public string telefoonnummer { get; set; }
        public string adres { get; set; }
        public string beschrijving { get; set; }
    }
}