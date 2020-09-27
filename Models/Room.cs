using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Three_Sisters_Hotel.Models
{
    public class Room
    {
        [Key, Required]
        public int ID { get; set; }

        [Required]
        [MinLength(1)]
        [MaxLength(1)]
        [RegularExpression(@"[G123]{1}")]
        public String Level { get; set; }

        [MinLength(1)]
        [MaxLength(1)]
        [RegularExpression(@"[123]{1}")]
        public int BedCount { get; set; }

        [Range(50,300)]
        public decimal Price { get; set; }

        public ICollection<Booking> TheBookings { get; set; }
    }
}
