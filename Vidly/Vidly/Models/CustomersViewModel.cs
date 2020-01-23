using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using static Vidly.Models.Customer;

namespace Vidly.Models
{
    public class CustomersViewModel
    {
        public List<Customer> Clientes { get; set; }
    }
}