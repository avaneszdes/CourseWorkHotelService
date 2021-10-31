using ApplicationContext.Entities;
using Microsoft.EntityFrameworkCore;

namespace ApplicationContext
{
    public sealed class HotelContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Order>? Orders { get; set; }
        public DbSet<Hotel>? Hotels { get; set; }
        public DbSet<Room>? Rooms { get; set; }
        public DbSet<Facility>? Facilities { get; set; }
        public DbSet<Role>? Roles { get; set; }
        public DbSet<Comment>? Comments { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Hotel>()
            .HasMany(p => p.Rooms)
            .WithOne(c => c.Hotel);

            modelBuilder.Entity<Hotel>()
            .HasMany(p => p.Facilities)
            .WithOne(c => c.Hotel);

            modelBuilder.Entity<Hotel>()
            .HasMany(p => p.Comments)
            .WithOne(c => c.Hotel);

            modelBuilder.Entity<Role>()
           .HasMany(p => p.Users)
           .WithOne(c => c.Role);

            modelBuilder.Entity<Room>()
           .HasMany(p => p.AdditionalServices)
           .WithOne(c => c.Room);

            modelBuilder.Entity<User>()
            .HasMany(p => p.Orders)
            .WithOne(c => c.User);

            base.OnModelCreating(modelBuilder);
        }

        public HotelContext(DbContextOptions options) : base(options) {}

        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    OracleConnection con = new OracleConnection();

        //    //using connection string attributes to connect to Oracle Database
        //    con.ConnectionString = "User Id=C##VLADISLAV_AVANESOV;Password=VLADISLAV_AVANESOV;Data Source=localhost";
        //    //var conStr = "(DESCRIPTION =(ADDRESS = (PROTOCOL = TCP)(HOST = localhost)(PORT = 1521))(CONNECT_DATA =(SERVER = DEDICATED)(SERVICE_NAME = XE))); User Id=C##VLADISLAV_AVANESOV;Password=VLADISLAV_AVANESOV;";
        //    //optionsBuilder.UseOracle(conStr, x => x.MigrationsAssembly("CourseWorkHotelService"));
        //}
    }
}