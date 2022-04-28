using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ProductEntityFw.Models;

namespace ProductEntityFw.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Insert(Customer Cust)
        {
            if (ModelState.IsValid)
            {
                CustDBContext dBContext = new CustDBContext();
                dBContext.Add(Cust);
                dBContext.SaveChanges();
                return Content("Registered");
            }
            return View("Index");
        }
    }
}
