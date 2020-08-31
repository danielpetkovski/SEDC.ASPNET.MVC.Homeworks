using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace SEDC.Homework.AspNet.Homework1.App.Controllers
{
    [Route("homework/movie")]
    public class MovieController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet("get-movies/{id:DateTime}")]
        public IActionResult GetMovieByDateTime(DateTime dateAdded)
        {
            var Movie = new
            {
                Name = "Gladiator",
                Date = dateAdded
            };
            return Json(Movie);
        }

        [HttpGet("get-available/{id:bool}")]
        public IActionResult GetMovieByBool(bool isAvailable)
        {
            var Movie = new
            {
                Name = "Godfather",
                IsAvailable = isAvailable
            };
            return Json(Movie);
        }

    }
}
