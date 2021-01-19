using CarsWebLibrary;
using CarsWebLibrary.Data;
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
        private readonly ApplicationDbContext dbContext;
        public CarsController(ApplicationDbContext applicationDb)
        {
            dbContext = applicationDb;
        }
        //C
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(AddCar addCar)
        {
            var addedCar = CarService.AddCar(addCar, dbContext);
            return RedirectToAction("Index");
        }
        //R
        public IActionResult Index()
        {
            var cars = CarService.GetCars(dbContext);
            return View(cars);
        }
        [Route("{guid}")]
        public IActionResult Details([FromRoute] Guid guid)
        {
            var car = CarService.GetCar(guid, dbContext);
            return View(car);
        }
        //U
        [Route("{guid}")]
        public IActionResult Edit(Guid guid)
        {
            var car = CarService.GetCar(guid, dbContext);
            return View(car);
        }
        [HttpPost("{guid}")]
        public IActionResult Edit(Guid guid, [FromForm] UpdateCar updateCar)
        {
            var updatedCar = CarService.UpdateCar(updateCar, guid, dbContext);
            return RedirectToAction("Details", updatedCar);
        }
        //D
        [Route("{guid}")]
        public IActionResult Delete(Guid guid)
        {
            CarService.DeleteCar(guid, dbContext);
            return RedirectToAction("Index");
        }
    }
}
