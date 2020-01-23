using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;

namespace Vidly.Controllers
{
    public class CustomersController : Controller
    {
        // GET: Customers
        public ActionResult Index()
        {
            var ListaCustomers = GetCustomers();
           

            return View(ListaCustomers);
        }
        public ActionResult Details(int id)
        {

            var customer = GetCustomers().Where(c => c.id == 23 || c.id == 22);

            if (customer == null)
                return HttpNotFound();

            return View(customer);
        }

        private IEnumerable<Customer> GetCustomers()
        {
            return new List<Customer>
            {
                new Customer { id = 22, Name = "John Smith" },
                new Customer { id = 23, Name = "Mary Williams" }
            };
        }
    }
}