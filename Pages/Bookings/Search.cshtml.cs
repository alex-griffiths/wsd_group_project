using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Data.Sqlite;
using Microsoft.EntityFrameworkCore;
using Three_Sisters_Hotel.Models;

namespace Three_Sisters_Hotel.Pages.Bookings
{
    [Authorize(Roles = "administrators, customer")]
    public class SearchModel : PageModel
    {
        private readonly Three_Sisters_Hotel.Data.ApplicationDbContext _context;

        public SearchModel(Three_Sisters_Hotel.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public SearchViewModel Myself { get; set; }
        public IList<Room> Rooms { get; set; }

        public async Task<IActionResult> OnPostAsync()
        {
            string query = "SELECT * From Room Where BedCount = @BCount AND ID NOT IN (SELECT RoomID FROM Booking WHERE (CheckIn <= @ChckIn AND CheckOut >= @ChckOut) OR (CheckIn < @ChckOut AND CheckOut >=@ChckOut) OR (@ChckIn <= CheckIn AND @ChckOut >= CheckIn))";
            var par1 = new SqliteParameter("@BCount", Myself.BedCount);
            var par2 = new SqliteParameter("@ChckIn", Myself.CheckIn);
            var par3 = new SqliteParameter("@ChckOut", Myself.CheckOut);
            Rooms = await _context.Room.FromSqlRaw(query, par1, par2, par3).ToListAsync();
            ViewData["SuccessDB"] = "true";
            return Page();
        }
    }
}