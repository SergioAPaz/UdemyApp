using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;
using Vidly.ViewModels;

namespace Vidly.Controllers
{
    public class MoviesController : Controller
    {
        private ApplicationDbContext _Cogntext;

        public MoviesController()
        {
            _Cogntext = new ApplicationDbContext();
        }
        protected override void Dispose(bool disposing)
        {
            _Cogntext.Dispose();
        }



        public ActionResult Index()
        {
          
                var details = _Cogntext.Movie.ToList();
                return View(details);
            
          
            
           

            //    if (!pageIndex.HasValue)
            //    {
            //        pageIndex = 1;
            //    }
            //    if (string.IsNullOrWhiteSpace(sortBy))
            //    {
            //        sortBy = "Name";
            //    }
            //    return Content(string.Format("pageIndex={0}&sortBy={1}", pageIndex, sortBy));


        }



        public ActionResult Details(int? id)
        {
            if (id.HasValue)
            {
                var details = _Cogntext.Movie.Where(x => x.Id == id).ToList();
                return View(details);
            }
            else
            {
                return Content("Falta indice");
            }


        }





        






    
    }

}