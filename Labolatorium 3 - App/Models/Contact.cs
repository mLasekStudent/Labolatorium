using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace Labolatorium_3___App.Models
{
    public class Contact
    {
        [HiddenInput]
        public int Id { get; set; }
        [Required(ErrorMessage = "Musisz podać imię!")]
        [StringLength(maximumLength: 50, ErrorMessage = "Zbyt długie imię, wpisz max 50 znaków!")]
        [Display(Name = "Imię")]
        public string Name { get; set; }
        [MaxLength(50)]
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        [Phone]
        [Display(Name = "Numer telefonu")]
        public string Phone { get; set; }
        [DataType(DataType.Date)]
        [Display(Name = "Data urodzenia")]
        public DateTime? Birth { get; set; }
        [Display(Name = "Priorytet")]
        public Priority Priority { get; set; }
        [HiddenInput]
        public DateTime Created { get; set; }
    }
}
