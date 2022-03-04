
using System.Collections.Generic;
using System.Linq;
using WebSalesMVC5.Data;
using WebSalesMVC5.Models;

namespace WebSalesMVC5.Services
{
    public class DepartmentService
    {
        private readonly WebSalesMVC5Context _context;
        public DepartmentService(WebSalesMVC5Context context)
        {
            _context = context;
        }

        public List<Department> FindAll()
        {
            return _context.Department.OrderBy(x => x.Name).ToList();
        }
    }
}

