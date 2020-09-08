using Microsoft.AspNetCore.Mvc;
using SEDC.MVC.Homework01.App.InMemoryDatabase;
using SEDC.MVC.Homework01.App.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SEDC.MVC.Homework01.App.Controllers
{
    public class ProductController : Controller
    {
        [HttpGet("products")]
        public IActionResult Index()
        {
            var products = Database.Products;

            var listOfProductsVM = new List<ProductVM>();

            foreach (var product in products)
            {
                var productVm = new ProductVM
                {
                    Id = product.Id,
                    Name = product.Name,
                    Price = product.Price,
                    Description = product.Description,
                    Category = product.Category
                };

                listOfProductsVM.Add(productVm);
            }
            return View("Index", listOfProductsVM);
        }

        
    }
}
