using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Three_Sisters_Hotel.Models
{
    public class SearchViewModel
    {
        [RegularExpression(@"[123]{1}")]
        [Display(Name = "Bed Count")]
        public int BedCount { get; set; }
        [Display(Name = "Check In Date")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime CheckIn { get; set; }

        [Display(Name = "Check Out Date")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime CheckOut { get; set; }
    }
}
