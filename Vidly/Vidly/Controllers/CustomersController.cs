﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;
using System.Data.Entity;

namespace Vidly.Controllers
{
    public class CustomersController : Controller
    {
        private ApplicationDbContext _Context;

        public CustomersController()
        {
            _Context = new ApplicationDbContext();
        }
        protected override void Dispose(bool disposing)
        {
            _Context.Dispose();
        }


        // GET: Customers
        public ActionResult Index()
        {
            var ListaCustomers = _Context.Customers.Include(c => c.MemberShipType).ToList();
           

            return View(ListaCustomers);
        }
        public ActionResult Details(int id)
        {

            var customer = _Context.Customers.Include(c => c.MemberShipType).Where(c => c.Id==id);

            if (customer == null)
                return HttpNotFound();

            return View(customer);
        }

      
    }
}