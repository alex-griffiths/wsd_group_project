using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Three_Sisters_Hotel.Data;
using Three_Sisters_Hotel.Models;
using Microsoft.AspNetCore.Authorization;
using System.Security.Claims;
using Microsoft.Data.Sqlite;

namespace Three_Sisters_Hotel.Pages.Bookings
{
    [Authorize(Roles = "administrators, customer")]
    public class CreateModel : PageModel
    {
        private readonly Three_Sisters_Hotel.Data.ApplicationDbContext _context;

        public CreateModel(Three_Sisters_Hotel.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
        ViewData["CustomerEmail"] = new SelectList(_context.Customer, "Email", "Email");
        ViewData["RoomID"] = new SelectList(_context.Room, "ID", "ID");
            return Page();
        }

        [BindProperty]
        public Booking Booking { get; set; }
        public IList<Room> Vacancy { get; set; }

        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            ViewData["RoomID"] = new SelectList(_context.Room, "ID", "ID");

            string query = "SELECT * From Room Where ID = @RID AND ID NOT IN (SELECT RoomID FROM Booking WHERE (CheckIn <= @ChckIn AND CheckOut >= @ChckOut) OR (CheckIn < @ChckOut AND CheckOut >=@ChckOut) OR (@ChckIn <= CheckIn AND @ChckOut >= CheckIn))";
            var par1 = new SqliteParameter("@RID", Booking.RoomID);
            var par2 = new SqliteParameter("@ChckIn", Booking.CheckIn);
            var par3 = new SqliteParameter("@ChckOut", Booking.CheckOut);
            Vacancy = await _context.Room.FromSqlRaw(query, par1, par2, par3).ToListAsync();

            if(Vacancy.Count() == 1)
            {
                Booking NewBooking = new Booking();
                NewBooking.RoomID = Booking.RoomID;
                NewBooking.CustomerEmail = User.FindFirst(ClaimTypes.Name).Value;
                NewBooking.CheckIn = Booking.CheckIn;
                NewBooking.CheckOut = Booking.CheckOut;
                var theRoom = await _context.Room.FindAsync(Booking.RoomID);
                var nights = ((Booking.CheckOut - Booking.CheckIn).Days);
                NewBooking.Cost = nights * theRoom.Price;
                _context.Booking.Add(NewBooking);
                await _context.SaveChangesAsync();
                ViewData["Room"] = theRoom.ID;
                ViewData["BedCount"] = theRoom.BedCount;
                ViewData["Nights"] = nights;
                ViewData["total"] = String.Format("{0:C}", NewBooking.Cost);
                ViewData["NewBooking"] = "true";
            }
            else
            {
                ViewData["NewBooking"] = "false";
            }

            
            return Page();
        }
    }
}
