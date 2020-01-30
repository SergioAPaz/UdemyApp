using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Vidly.Models;

namespace Vidly.Models
{
    public class Movie
    {
        public int Id { get; set; }

        [NewMovieValidationAttribute]
        public string Name { get; set; }
       
        public DateTime? ReleaseDate { get; set; }

        
        public DateTime? DateAdded { get; set; }

       
        public int? Stock { get; set; }

        public Genre Genre { get; set; }
        public int GenreId { get; set; }
    }
}