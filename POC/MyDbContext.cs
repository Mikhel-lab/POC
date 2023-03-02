using Microsoft.EntityFrameworkCore;
using POC.Models.LGAEntity;
using POC.Models.StateEntity;
using POC.Models.PocEntity;
using POC.Models.FactoryEntity;

namespace POC
{
    public class MyDbContext : DbContext
    {
        public MyDbContext(DbContextOptions<MyDbContext> options) : base(options) { }

        public DbSet<Poc> POCS { get; set; }
        public DbSet<State> States { get; set; }
        public DbSet<LGA> LocalGovernments { get; set; }
        //public DbSet<Car> Cars { get; set; }
        public DbSet<FactoryLocation> Factories { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<FactoryLocation>().HasKey(f => f.Id);
            modelBuilder.Entity<Poc>().HasKey(f => f.Id);
        }

    }
}

