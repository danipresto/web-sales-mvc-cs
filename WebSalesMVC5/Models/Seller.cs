﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace WebSalesMVC5.Models
{
    public class Seller
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public DateTime BirthDate { get; set; }
        public double Salary { get; set; }
        public Department Department { get; set; }
        public ICollection<SalesRecord> Sales { get; set; } = new List<SalesRecord>();
        public int DepartmentId { get; set; }

        public Seller()
        {

        }
        public Seller(int id, string name, string email, DateTime birthDate, double salary, Department department)
        {
            Id = id;
            Name = name;
            Email = email;
            BirthDate = birthDate;
            Salary = salary;
            Department = department;
        }

        public void AddSale(SalesRecord salesrecord)
        {
            Sales.Add(salesrecord);
        }
        public void RemoveSales(SalesRecord salesrecord)
        {
            Sales.Remove(salesrecord);
        }
        public double TotalSales(DateTime initial, DateTime final)
        {
            return Sales.Where(salesrecord => salesrecord.Date >= initial && salesrecord.Date <= final).Sum(salesrecord => salesrecord.Amount);
        }
        
}
}
