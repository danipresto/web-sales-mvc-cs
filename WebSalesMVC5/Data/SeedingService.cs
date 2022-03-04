using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebSalesMVC5.Models;
using WebSalesMVC5.Models.Enums;

namespace WebSalesMVC5.Data
{
    public class SeedingService
    {
        private WebSalesMVC5Context _context;
        public SeedingService(WebSalesMVC5Context context)
        {
            _context = context;
        }
        public void Seed()
        {
            if (_context.Department.Any() || _context.Seller.Any() || _context.SalesRecord.Any())
            {
                return;
            }
            Department d1 = new Department(1, "Sound");
            Department d2 = new Department(2, "Displays");
            Department d3 = new Department(3, "Fashion");
            Department d4 = new Department(4, "Furniture");
            Department d5 = new Department(5, "Software");

            Seller s1 = new Seller(1,"Juniper Lee", "juni@bol.com", new DateTime(1997, 3, 29), 1400.0, d1);
            Seller s2 = new Seller(2, "Michel Leys", "micheleys@bol.com", new DateTime(1999, 7, 14), 1300.0, d2);
            Seller s3 = new Seller(3, "John Whatsapp", "jonwpp@bol.com", new DateTime(1992, 4, 20), 1800.0, d4);
            Seller s4 = new Seller(4, "Poil Manero", "pomel@bol.com", new DateTime(1996, 2, 15), 1700.0, d4);
            Seller s5 = new Seller(5, "Kawan Leth", "kawanlety@bol.com", new DateTime(1989, 12, 25), 1000.0, d3);
            Seller s6 = new Seller(6, "Based Lewis", "basiliws@bol.com", new DateTime(1997, 10, 31), 1600.0, d5);

            SalesRecord r1 = new SalesRecord(1, new DateTime(2015,02,12),4000.0, SaleStatus.Billed, s1);
            SalesRecord r2 = new SalesRecord(2, new DateTime(2015, 05, 12), 10000.0, SaleStatus.Canceled, s2);
            SalesRecord r3 = new SalesRecord(3, new DateTime(2015, 12, 12), 700.0, SaleStatus.Billed, s4);
            SalesRecord r4 = new SalesRecord(4, new DateTime(2016, 12, 04), 20.0, SaleStatus.Pending, s3);

            _context.Department.AddRange(d1,d2,d3,d4);
            _context.Seller.AddRange(s1,s2,s3,s4,s5,s6);
            _context.SalesRecord.AddRange(r1,r2,r3,r4);

            _context.SaveChanges();
        }
    }
}
