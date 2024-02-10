using Microsoft.EntityFrameworkCore;
using Sofra.DAL.EntityFramework.Context.Mapping;
using Sofra.Data.Domain;

namespace Sofra.DAL.EntityFramework.Context
{
    public class SofraContext : DbContext
    {
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Table> Tables { get; set; }
        public DbSet<Reservation> Reservations { get; set; }
        public SofraContext(DbContextOptions<SofraContext> options) : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new CustomerMapping());
            modelBuilder.ApplyConfiguration(new TableMapping());
            modelBuilder.ApplyConfiguration(new ReservationMapping());
        }
    }

}
