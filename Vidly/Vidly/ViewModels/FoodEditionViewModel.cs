﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Vidly.Models;

namespace Vidly.ViewModels
{
    public class FoodEditionViewModel
    {
        public Food Food { get; set; }
        public List<MembershipType> MembershipType { get; set; }
    }
}