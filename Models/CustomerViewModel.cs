using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Three_Sisters_Hotel.Models
{
    public class CustomerViewModel
    {
        [Required]
        [Display(Name = "First Name")]
        [RegularExpression(@"[A-Z][a-z'-]{2,20}")]
        public string GivenName { get; set; }

        [Required, Display(Name = "Last Name")]
        [RegularExpression(@"[A-Z][a-z'-]{2,20}")]
        public string Surname { get; set; }

        [NotMapped] // not mapping this property to database, but exist in memory
        [Display(Name = "Full Name")]
        public string FullName => $"{GivenName} {Surname}";

        [Required]
        [DataType(DataType.PhoneNumber)]
        [RegularExpression(@"^04[0-9]{8}$")]
        public string Mobile { get; set; }

        [Required]
        [RegularExpression(@"^[0-9]{4}$")]
        public string Postcode { get; set; }
    }
}
