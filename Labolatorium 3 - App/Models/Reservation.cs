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
        public DateTime data { get;set; }
        [Display(Name = "Miasto")]
        public string miasto { get;set; }
        [Display(Name = "Adres")]
        public string adres { get; set; }
        [Display(Name = "Nr pokoju")]
        public int pokoj { get;set; }
        [Display(Name = "Właściciel")]
        public string wlasciciel { get;set; }
        [Display(Name = "Cena")]
        public decimal cena { get; set; }
        [HiddenInput]
        public DateTime Created { get; set; }
    }
}
