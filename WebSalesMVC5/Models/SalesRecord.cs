using System;
using WebSalesMVC5.Models.Enums;

namespace WebSalesMVC5.Models
{
    public class SalesRecord
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public double Amount { get; set; }
        public SaleStatus Status { get; set; }
        public Seller Seller { get; set; }


    }
}
