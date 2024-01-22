using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Entities
{
    [Table("reservations")]
    public class ReservationEntity
    {
        [Key]
        public int Id { get; set; }
        [Column("Data")]
        [DataType(DataType.Date)]
        [Required]
        public DateTime data { get; set; }
        [Column("Miasto")]
        [MaxLength(60)]
        [Required]
        public string miasto { get; set; }
        [Column("Adres")]
        [MaxLength(100)]
        public string adres { get; set; }
        [Column("Pokój")]
        [Range(0, 500)]
        [Required]
        public int pokoj { get; set; }
        [Column("Właściciel")]
        [MaxLength(50)]
        public string wlasciciel { get; set; }
        [Column("Cena")]
        [Required]
        public decimal cena { get; set; }
    }
}
