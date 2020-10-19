using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Three_Sisters_Hotel.Data;
using Three_Sisters_Hotel.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Security.Claims;

namespace Three_Sisters_Hotel.Pages.Bookings
{
    [Authorize(Roles = "administrators, customer")]
    public class IndexModel : PageModel
    {
        private readonly Three_Sisters_Hotel.Data.ApplicationDbContext _context;

        public IndexModel(Three_Sisters_Hotel.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IList<Booking> Booking { get;set; }
        public string DateSort { get; set; }
        public string PriceSort { get; set; }

        public async Task OnGetAsync(string SortOrder)
        {
            DateSort = String.IsNullOrEmpty(SortOrder) ? "Date_Desc" : "";
            PriceSort = SortOrder == "Price" ? "Price_Desc" : "Price";
            ViewData["userEmail"] = User.FindFirst(ClaimTypes.Name).Value;

            IQueryable<Booking> Bookings = from s in _context.Booking
                                                       select s;

            switch (SortOrder)
            {
                case "Date_Desc":
                    Bookings = Bookings.OrderByDescending(s => s.CheckIn);
                    break;
                case "Price":
                    Bookings = Bookings.OrderBy(s => s.Cost);
                    break;
                case "Price_Desc":
                    Bookings = Bookings.OrderByDescending(s => s.Cost);
                    break;
                default:
                    Bookings = Bookings.OrderBy(s => s.CheckIn);
                    break;
            }

            Booking = await Bookings.AsNoTracking()
                .Include(b => b.TheCustomer)
                .Include(b => b.TheRoom).ToListAsync();
        }
    }
}
