using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Three_Sisters_Hotel.Models;

namespace Three_Sisters_Hotel.Pages.Admin
{
    [Authorize(Roles = "administrators")]
    public class StatisticsPageModel : PageModel
    {
        private readonly Three_Sisters_Hotel.Data.ApplicationDbContext _context;

        public StatisticsPageModel(Three_Sisters_Hotel.Data.ApplicationDbContext context)
        {
            _context = context;
        }

       
        public IList<Statistics> CustomerStats { get; set; }
        public IList<Statistics> RoomStats { get; set; }


        public async Task<IActionResult> OnGetAsync()
        {
            
            var customerGroups = _context.Customer.GroupBy(c => c.Postcode);

            
            CustomerStats = await customerGroups.Select(g => new Statistics { PostCode = g.Key, PostCount = g.Count() }).ToListAsync();

         
            var roomGroups = _context.Booking.GroupBy(r => r.TheRoom.ID);

            
            RoomStats = await roomGroups.Select(g => new Statistics { RoomID = g.Key, RoomBookCount = g.Count() }).ToListAsync();

            return Page();
        }

        /*
        public void OnGet()
        {

        }
        */
    }
}
