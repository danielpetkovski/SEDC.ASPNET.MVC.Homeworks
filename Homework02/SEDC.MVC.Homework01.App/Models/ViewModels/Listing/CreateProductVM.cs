using SEDC.MVC.Homework01.App.Models.Domain;
using SEDC.MVC.Homework01.App.Models.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SEDC.MVC.Homework01.App.Models.ViewModels.Listing
{
    public class CreateProductVM
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Name is required")]
        public string Name { get; set; }
        [Range(1, 100, ErrorMessage = "Range must be betwen 1 and 100")]
        public double Price { get; set; }
        [Required(ErrorMessage = "Description is required")]
        public string Description { get; set; }
        public Category Category { get; set; }
    }
}
