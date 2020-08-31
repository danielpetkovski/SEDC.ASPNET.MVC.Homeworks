using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SEDC.Homework.AspNet.Homework1.App.Models;

namespace SEDC.Homework.AspNet.Homework1.App.Controllers
{
    [Route("pizza/order")]
    public class OrderController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult CreateOrder()
        {
            return View();
        }

        [HttpPost("pizza/order/create-order")]
        public IActionResult CreateOrder(OrderModel request)
        {
            RedirectToAction("Index", "Home");
            return Json(request);
        }

    }
}
