using Microsoft.EntityFrameworkCore;


namespace MimeBooking.Domain
{
        class MimeBookingDBContext : DbContext
        {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=(local);Database=MimeBooking;Trusted_Connection=True;");
            // connects to a local Server; called DENTALCARE ;using this computers user or whatever the last part was
        }

        public DbSet<Client> Clients { get; set; }
        public DbSet<Booking> Bookings { get; set; }
        }
    
}
