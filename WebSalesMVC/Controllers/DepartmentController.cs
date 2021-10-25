﻿using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebSalesMVC.Models;

namespace WebSalesMVC.Controllers
{
    public class DepartmentsController : Controller
    {
        public IActionResult Index()
        {
            List<Department> list = new List<Department>();
            list.Add(new Department {Id = 1 , Name = "Mobile" });
            list.Add(new Department { Id = 2, Name = "Sound" });
            list.Add(new Department { Id = 3, Name = "Video" });

            return View(list);
        }
    }
}
