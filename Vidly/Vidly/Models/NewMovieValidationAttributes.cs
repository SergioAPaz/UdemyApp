using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Vidly.Models
{
    public class NewMovieValidationAttribute : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            var movie = (Movie)validationContext.ObjectInstance;

           

            if (movie.Name == null)
            {
                return new ValidationResult("plese add a name");
            }
           

            return ValidationResult.Success;
        }
       


    }
}