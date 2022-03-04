using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WebSalesMVC5.Models;

namespace WebSalesMVC5.Data
{
    public class WebSalesMVC5Context : DbContext
    {
        public WebSalesMVC5Context (DbContextOptions<WebSalesMVC5Context> options)
            : base(options)
        {
        }
       
        public DbSet<Department> Department { get; set; }
        public DbSet<Seller> Seller { get; set; }
        public DbSet<SalesRecord> SalesRecord { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)=> modelBuilder.Entity<Seller>().Property(b => b.Id).HasIdentityOptions(startValue: 7); // Seeding Service inseriu até o ID 6


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            => optionsBuilder.UseNpgsql("Server=localhost;Database=websalesmvcdb;Username=developer;Password=root");
    }
}
