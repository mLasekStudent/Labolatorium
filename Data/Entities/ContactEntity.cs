using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Entities
{
    [Table("contacts")]
    public class ContactEntity
    {
        [Key]
        public int ContactId { get; set; }
        [Column("Imie")]
        [MaxLength(50)]
        [Required]
        public string Name { get; set; }
        [MaxLength(50)]
        [Required]
        public string Email { get; set; }
        [MaxLength(12)]
        [MinLength(9)]
        [Column("Nr_tel")]
        public string Phone { get; set; }
        [DataType(DataType.Date)]
        [Column("Data_ur")]
        public DateTime? Birth {  get; set; }
        public int Priority { get; set; }
    }
}
