using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using FinalAssessmentMVC.Models;
using CustomerBAL;
using System.Data;

namespace FinalAssessmentMVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }


        public IActionResult CustomersList()
        {
            DataTable data = new DataTable();
            data = new GetCustomersBAL().CustomersList();
            IList<Customer> list = new List<Customer>();
            foreach(DataRow row in data.Rows)
            {
                list.Add(new Customer()
                {
                    CustomerId = int.Parse( row["CustomerId"].ToString()),
                    CustomerName = row["CustomerName"].ToString(),
                    CustomerAddress = row["CustomerAddress"].ToString()

                });
            }
            return View(list);

        }

        public IActionResult Question4()
        {
            DataTable data = new DataTable();
            data = new GetCustomersBAL().Question4();
            IList<CustomerBanks> list = new List<CustomerBanks>();
            foreach (DataRow row in data.Rows)
            {
                list.Add(new CustomerBanks()
                {
                    CustomerId = int.Parse(row["CustomerId"].ToString()),
                    CustomerName = row["CustomerName"].ToString(),
                    BankName = row["BankName"].ToString(),
                    TagId = int.Parse(row["TagId"].ToString())

                }) ;
            }
            return View(list);

        }

        public IActionResult Index()
        {
            return View();
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
