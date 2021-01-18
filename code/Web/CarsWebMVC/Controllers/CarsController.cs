using CarsWebLibrary;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarsWebMVC.Controllers
{
    public class CarsController : Controller
    {
        public IActionResult Index()
        {
            var cars = CarService.GetCars();
            return View(cars);
        }
        [Route("details/{guid}")]
        public IActionResult Details(Guid guid)
        {
            var car = CarService.GetCar(guid);
            return View(car);
        }
    }
}
