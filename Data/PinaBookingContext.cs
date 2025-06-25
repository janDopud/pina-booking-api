using Microsoft.EntityFrameworkCore;
using PinaBookingApi.Models;

namespace PinaBookingApi.Data
{
    public class PinaBookingContext : DbContext
    {
        public PinaBookingContext(DbContextOptions<PinaBookingContext> options) : base(options) { }
       
            public DbSet<Service> Services { get; set; }
            public DbSet<Booking> Bookings { get; set; }
    }
}