using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace Labolatorium_3___App.Models
{
    public class Reservation
    {
        [HiddenInput]
        public int Id { get; set; }
        [DataType(DataType.Date)]
        [Display(Name = "Data")]
        [Required]
        public DateTime data { get;set; }
        [Display(Name = "Miasto")]
        [StringLength(maximumLength: 60, ErrorMessage = "Zbyt długa nazwa miasta, wpisz maksymalnie 60 znaków!")]
        [Required]
        public string miasto { get;set; }
        [Display(Name = "Adres")]
        [MaxLength(100)]
        public string adres { get; set; }
        [Display(Name = "Nr pokoju")]
        [Range(1, 500,
            ErrorMessage = "Numer pokoju musi być liczbą od 1 do 500!")]
        [Required]
        public int pokoj { get;set; }
        [Display(Name = "Właściciel")]
        [MaxLength(50)]
        public string wlasciciel { get;set; }
        [Display(Name = "Cena")]
        [Required]
        public decimal cena { get; set; }
    }
}
