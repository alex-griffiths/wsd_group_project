using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Three_Sisters_Hotel.Models
{
    public class Booking
    {
        [Key, Required]
        public int ID { get; set; }

        public int RoomID { get; set; }

        [DataType(DataType.EmailAddress)]
        // [EmailAddress], the one above implies this one
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public String CustomerEmail { get; set; }

        [Display(Name = "Check In Date")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime CheckIn { get; set; }

        [Display(Name = "Check Out Date")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime CheckOut { get; set; }

        public decimal Cost { get; set; }

        //Navigational Properties
        public Room TheRoom { get; set; }

        public Customer TheCustomer { get; set;}
    }
}
