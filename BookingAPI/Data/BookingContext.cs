using BookingAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace BookingAPI.Data
{
    public class BookingContext : DbContext
    {
        public BookingContext(DbContextOptions<BookingContext> options)
            : base(options)
        {
        }

        public DbSet<Tenant> Tenants { get; set; }
        public DbSet<Booking> Bookings { get; set; }
        public DbSet<Room> Rooms { get; set; }
        public DbSet<RoomType> RoomTypes { get; set; }

    }
}
