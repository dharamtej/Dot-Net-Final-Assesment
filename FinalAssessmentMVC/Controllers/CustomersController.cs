using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using FinalAssessmentMVC.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace FinalAssessmentMVC.Controllers
{
    public class CustomersController : Controller
    {
        public async Task<IActionResult> Index()
        {
            IList<Customer> employees = new List<Customer>();
            var response = await GetCustomers();
            employees = (List<Customer>)JsonConvert.DeserializeObject<List<Customer>>(response);
            return View(employees);
        }
        public async Task<string> GetCustomers()
        {
            using (var d = new HttpClient())
            {
                var path = "https://localhost:44334/api/Customers";
                using (var response = await d.GetAsync(path))
                {
                    string apiresponse = await response.Content.ReadAsStringAsync();
                    return apiresponse;
                }
            }
        }
        

        public IActionResult CustomersListUsingJQuery()
        {
            return View();
        }
    }
}
