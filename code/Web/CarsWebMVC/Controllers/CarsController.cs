using CarsWebLibrary;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarsWebMVC.Controllers
{
    [Route("[Controller]/[Action]")]
    public class CarsController : Controller
    {
        public IActionResult Index()
        {
            var cars = CarService.GetCars();
            return View(cars);
        }
        [Route("{guid}")]
        public IActionResult Details([FromRoute] Guid guid)
        {
            var car = CarService.GetCar(guid);
            return View(car);
        }
        [Route("{guid}")]
        public IActionResult Edit(Guid guid)
        {
            var car = CarService.GetCar(guid);
            return View(car);
        }
        [HttpPost("{guid}")]
        public IActionResult Edit(Guid guid, [FromForm] UpdateCar updateCar)
        {
            return RedirectToAction("Index");
        }
        [Route("{guid}")]
        public IActionResult Delete(Guid guid)
        {
            var car = CarService.GetCar(guid);
            return View(car);
        }
    }
}
