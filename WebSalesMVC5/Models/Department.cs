using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebSalesMVC5.Models
{
    public class Department
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<Seller> Sellers { get; set; } = new List<Seller>();
    }
}
