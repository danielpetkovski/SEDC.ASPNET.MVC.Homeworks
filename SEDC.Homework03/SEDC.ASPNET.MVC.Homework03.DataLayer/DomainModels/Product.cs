using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.ASPNET.MVC.Homework03.DataLayer.DomainModels
{
   public class Product : BaseEntity
    {
        public double Price { get; set; }
        public string Description { get; set; }
        
    }
}
