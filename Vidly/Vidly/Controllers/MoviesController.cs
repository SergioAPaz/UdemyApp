using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;
using Vidly.ViewModels;
using System.Data.Entity;

namespace Vidly.Controllers
{
    public class MoviesController : Controller
    {
        private EntitydataModel1 _Context = new EntitydataModel1();
        public MoviesController()
        {
            _Context = new EntitydataModel1();
        }
        protected override void Dispose(bool disposing)
        {
            _Context.Dispose();
        }



        public ActionResult Index()
        {
            //var movie = _Context.Movie.Include(c => c.Genre);
            //return View();

            var movie = _Context.Movie.Include(m => m.Genre);
            return View(movie.ToList());



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
        public ActionResult Create()
        {
            //var MemberShiptypes = _Context.MemberShiptype.ToList();
            //var viewModel = new ViewmodelMovie
            //{
            //    MembershipType = MemberShiptypes
            //};


            //return View(viewModel);
            ViewBag.GenreId = new SelectList(_Context.Genres, "Id", "Name");
            return View();

        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create( Movie VM)
        {
            if (ModelState.IsValid)
            {
                VM.DateAdded = DateTime.Now;
                _Context.Movie.Add(VM);
                _Context.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.GenreId = new SelectList(_Context.Genres, "Id", "Name", VM.GenreId);
            return View(VM);
        }

        public ActionResult SaveNewMovie(int? id)
        {
            if (id == null)
            {
                HttpNotFound();
            }
            else
            {
                var data = _Context.Movie.SingleOrDefault(c => c.Id == id);
                if (data != null)
                {
                    var nc = new ViewmodelMovie()
                    {
                        Movies = data,
                        Genres = _Context.Genres.ToList()
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
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult SaveNewMovie(ViewmodelMovie VMMovie)
        {
            if (VMMovie.Movies.Id != null)
            {
                if (VMMovie.Movies.Name != null && VMMovie.Movies.GenreId != 0 && VMMovie.Movies.Stock.HasValue)
                {
                    var customeridToUpdate = _Context.Movie.Single(c => c.Id == VMMovie.Movies.Id);

                    customeridToUpdate.Name = VMMovie.Movies.Name;
                    customeridToUpdate.ReleaseDate = VMMovie.Movies.ReleaseDate;
                    customeridToUpdate.GenreId = VMMovie.Movies.GenreId;
                    customeridToUpdate.Stock = VMMovie.Movies.Stock;

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



        public ActionResult Details(int? id)
        {
            if (id.HasValue)
            {
                var details = _Context.Movie.Where(x => x.Id == id).ToList();
                return View(details);
            }
            else
            {
                return Content("Falta indice");
            }


        }





        






    
    }

}