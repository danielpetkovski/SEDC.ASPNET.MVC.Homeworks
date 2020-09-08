﻿using SEDC.MVC.Homework01.App.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SEDC.MVC.Homework01.App.Models.Domain
{
    public class CreateProduct
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public string Description { get; set; }
        public Category Category { get; set; }
        public User User { get; set; }

    }
}
