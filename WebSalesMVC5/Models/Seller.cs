using System;
using System.Collections.Generic;

namespace WebSalesMVC5.Models
{
    public class Seller
    {
        public int Id { get; set; }
        public string Name  { get; set; }
        public string Email { get; set; }
        public DateTime BirthDate { get; set; }
        public double Salary { get; set; }
        public Department Department { get; set; }
        public ICollection<SalesRecord> Sales { get; set; } = new List<SalesRecord>();

    }
}
