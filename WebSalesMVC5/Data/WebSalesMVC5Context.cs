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

        public DbSet<WebSalesMVC5.Models.Department> Department { get; set; }
        public DbSet<Seller> Seller { get; set; }
        public DbSet<SalesRecord> SalesRecord { get; set; }
    }
}
