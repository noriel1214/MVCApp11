﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MVCApp11.Models;

namespace MVCApp11.ViewModels
{
    public class RandomMovieViewModel
    {
        public Movie Movie { get; set; }
        public List<Customer> Customers { get; set; }
    }
}