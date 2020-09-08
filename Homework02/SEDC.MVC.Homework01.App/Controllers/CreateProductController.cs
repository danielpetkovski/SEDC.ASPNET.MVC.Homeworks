using Microsoft.AspNetCore.Mvc;
using SEDC.MVC.Homework01.App.InMemoryDatabase;
using SEDC.MVC.Homework01.App.Models.Domain;
using SEDC.MVC.Homework01.App.Models.ViewModels.Listing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Threading.Tasks.Dataflow;

namespace SEDC.MVC.Homework01.App.Controllers
{
    public class CreateProductController : Controller
    {
        [HttpGet("CreateProduct")]
        public IActionResult CreateProduct()
        {
            return View("CreateProduct");
        }

        [HttpPost("CreateProduct")]
        public IActionResult CreateProduct(CreateProductVM createProduct)
        {
            if (createProduct.Name == null )
            {
                ViewBag.Error = "Please fill in Name!";
                return RedirectToAction("CreateProduct");
            }

            if (createProduct.Description == null)
            {
                ViewBag.Error = "Please fill in Description!";
                return RedirectToAction("CreateProduct");
            }

            if (createProduct.Price == 0)
            {
                ViewBag.Error = "The price must be above 0!";
                return RedirectToAction("CreateProduct");
            }

            var product = new Product
            {
                Id = Database.Products.Count + 1,
                Name = createProduct.Name,
                Description = createProduct.Description,
                Price = createProduct.Price,
                Category = createProduct.Category
            };

            Database.Products.Add(product);

            ViewBag.Success = $"The product {product.Name} has been listed!";


            return RedirectToAction("Index", "Product");
        }





    }
}
