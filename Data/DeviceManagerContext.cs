using MVC5_mockup.Models;
using Microsoft.EntityFrameworkCore;

namespace MVC5_mockup.Data
{
    public class DeviceManagerContext : DbContext
    {
        public DeviceManagerContext(DbContextOptions<DeviceManagerContext> options) : base(options) 
        {
        }

        public DbSet<Device> Devices { get; set; }
        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Device>().ToTable("Device");
            modelBuilder.Entity<User>().ToTable("User");
        }
    }
}
