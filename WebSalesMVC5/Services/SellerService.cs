using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebSalesMVC5.Data;
using WebSalesMVC5.Models;

namespace WebSalesMVC5.Services
{
    public class SellerService
    {
        private readonly WebSalesMVC5Context _context;
        public SellerService(WebSalesMVC5Context context)
        {
            _context = context;
        }

        public List<Seller> FindAll()
        {
            return _context.Seller.ToList();
        }

        public void Insert(Seller seller)
        {
            _context.Add(seller);
            _context.SaveChanges();
        }
    }
}
