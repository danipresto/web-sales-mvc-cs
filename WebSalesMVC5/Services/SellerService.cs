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

        public Seller FindByID(int Id){
            return _context.Seller.FirstOrDefault(obj => obj.Id == Id);
        }

        public void Remove(int Id) {
            var obj = _context.Seller.Find(Id);
            _context.Seller.Remove(obj);
            _context.SaveChanges();

        }
    }

}
