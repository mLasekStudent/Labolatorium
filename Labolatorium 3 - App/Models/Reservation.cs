using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace Labolatorium_3___App.Models
{
    public class Reservation
    {
        [HiddenInput]
        public int Id { get; set; }
        [DataType(DataType.Date)]
        public DateTime data { get;set; }

        public string miasto { get;set; }

        public string adres { get; set; }

        public int pokoj { get;set; }
        public string wlasciciel { get;set; }

        public decimal cena { get; set; } 

    }
}
