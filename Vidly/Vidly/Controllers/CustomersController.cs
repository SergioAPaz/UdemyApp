﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;
using System.Data.Entity;
using Vidly.ViewModels;

namespace Vidly.Controllers
{
    public class CustomersController : Controller
    {
        private EntitydataModel1 _Context;

        public CustomersController()
        {
            _Context = new EntitydataModel1();
        }
        protected override void Dispose(bool disposing)
        {
            _Context.Dispose();
        }


        // GET: Customers
        public ActionResult Index()
        {
            var ListaCustomers = _Context.Customers.Include(c => c.MembershipType).ToList();


            return View(ListaCustomers);
        }
        public ActionResult NewCustomer()
        {
            var MemberShiptypes = _Context.MemberShiptype.ToList();
            var viewModel = new NewCustomerViewModel
            {
                MemberShipType = MemberShiptypes
            };


            return View(viewModel);
        }

        [HttpPost]
        public ActionResult EditSave(NewCustomerViewModel VM)
        {
            if (VM.Customer.Id != null)
            {
                if (VM.Customer.Birthday.HasValue && VM.Customer.MembershipTypeId != 0 && VM.Customer.Name != null)
                {
                    var customeridToUpdate = _Context.Customers.Single(c => c.Id == VM.Customer.Id);

                    customeridToUpdate.Name = VM.Customer.Name;
                    customeridToUpdate.Birthday = VM.Customer.Birthday;
                    customeridToUpdate.MembershipTypeId = VM.Customer.MembershipTypeId;
                    customeridToUpdate.IsSubscribedToNewsletter = VM.Customer.IsSubscribedToNewsletter;

                    _Context.SaveChanges();
                    return RedirectToAction("Index");
                }
                else
                {
                    return Content("Please fill all the fields..");

                }
            }
            else
            {
                return Content("Please fill all the fields.");
            }


        }


        public ActionResult SaveNewCustomer(int? id)
        {
            if (id==null)
            {
                HttpNotFound();
            }
            else
            {
                var data = _Context.Customers.SingleOrDefault(c => c.Id == id);
                if (data != null)
                {
                    var nc = new NewCustomerViewModel()
                    {
                        Customer = data,
                        MemberShipType = _Context.MemberShiptype.ToList()
                    };
                    return View(nc);
                }
                else
                {
                    HttpNotFound();
                }
            }

            return View();
        }

        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult SaveNewCustomer()
        //{


        //    return RedirectToAction("Index");
        //}

        public ActionResult Edit(int id)
        {

            var data = _Context.Customers.SingleOrDefault(c => c.Id == id);
            if (data != null)
            {
                //PARA INCLUIR UN MODELO DE MODELOS
                var viewModel = new NewCustomerViewModel
                {
                    Customer = data,
                    MemberShipType = _Context.MemberShiptype.ToList()
                };
                return View("NewCustomer", viewModel);
            }
            else
            {
                return HttpNotFound();
            }

        }

   

    }
}