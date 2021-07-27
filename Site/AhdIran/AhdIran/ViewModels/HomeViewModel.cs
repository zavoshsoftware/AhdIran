﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Models;

namespace ViewModels
{
    public class HomeViewModel : _BaseViewModel
    {
        public List<Customer> Customers { get; set; }
        public List<Slider> Sliders { get; set; }

    }
}