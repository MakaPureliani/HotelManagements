using Microsoft.EntityFrameworkCore;

namespace HotelManagements.Entities
{
    public class HotelDbContext:DbContext
    {
        public HotelDbContext(DbContextOptions<HotelDbContext> options) : base(options)
        { }

        public DbSet<RoomTypes> RoomTypes { get; set; }
        public DbSet<Rooms> Rooms { get; set; }
        public DbSet<Guests>  Guests { get; set; }
        public DbSet<Reservations>  Reservations { get; set; }
    }
}
