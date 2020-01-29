using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Vidly.Models;

namespace Vidly.ViewModels
{
    public class ViewmodelMovie
    {
        public List<MembershipType> MembershipType { get; set; }
        public Movie Movies { get; set; }
      


       
    }
}