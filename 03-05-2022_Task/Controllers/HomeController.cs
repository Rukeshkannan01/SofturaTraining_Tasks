using AdoMVC_03.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using AdoMVC_03.DAL;


namespace AdoMVC_03.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            CustomerDAL custDAL = new CustomerDAL();
            List<Customer> CustomerList = new List<Customer>();
            CustomerList = custDAL.GetAllCustomers();
            return View(CustomerList);          
        }
        public IActionResult Insert()
        {
            return View();
        }
        public IActionResult DataInsert(Customer cust)
        {
            CustomerDAL obj = new CustomerDAL();
            int inst = obj.InsertData(cust);
            if (inst == 1)
                return RedirectToAction("Index", cust);
            else
                return View("Insert");

        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
