using Microsoft.EntityFrameworkCore;
using SingleDB.Entity;
using SingleDB.EntityConfiguration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleDB.Context
{
    class SingleDBContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) =>
           optionsBuilder.UseSqlServer("Data Source=.;Initial Catalog=SingleDB; " +
                "integrated Security=true;");
        public virtual DbSet<FrontEnd> FrontEnds { get; set; }

        
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //Fluent API Style for FrontEnd Table 
            modelBuilder.Entity<FrontEnd>().HasKey(FE => FE.user_name);
            modelBuilder.Entity<FrontEnd>().Property(FE => FE.user_name).HasMaxLength(50);
            modelBuilder.Entity<FrontEnd>().Property(FE => FE.pass_word).HasMaxLength(50).IsRequired();

            //Kitchen Class Configuration
            modelBuilder.ApplyConfiguration(new KitchenConfiguration());
            //Reservation Class Configuration
            modelBuilder.ApplyConfiguration(new ReservationConfiguration());

            base.OnModelCreating(modelBuilder);

        }
        
    }
}
