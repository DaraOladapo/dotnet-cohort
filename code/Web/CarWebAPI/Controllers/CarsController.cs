using CarsWebLibrary;
using CarsWebLibrary.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarsController : ControllerBase
    {
        private readonly ApplicationDbContext dbContext;
        public CarsController(ApplicationDbContext _dbContext)
        {
            dbContext = _dbContext;
        }
        [HttpGet("all")]
        public ActionResult<IEnumerable<Car>> AllCars()
        {
            var allCars = CarService.GetCars(dbContext);
            return Ok(allCars);
        }
        [HttpGet("{id}")]
        public ActionResult<Car> GetCar(Guid id)
        {
            var carFound = CarService.GetCar(id, dbContext);

            return carFound == null ? NotFound($"Car with id {id} was not found.") : Ok(carFound);
        }
        [HttpPost("add")]
        public ActionResult<Car> AddCar([FromBody] AddCar addCar)
        {
            if (string.IsNullOrEmpty(addCar.Make))
                return BadRequest("Car make is needed");
            if (string.IsNullOrEmpty(addCar.Model))
                return BadRequest("Car model is needed");
            if (addCar.Year < 1900 || addCar.Year > DateTime.Now.Year)
                return BadRequest("Year input is not acceptable");
            var createdCar = CarService.AddCar(addCar, dbContext);
            return Ok(createdCar);
        }
        [HttpPut("{id}")]
        public ActionResult<Car> UpdateCar(Guid id, UpdateCar updateCar)
        {
            var carToUpdate = CarService.GetCar(id, dbContext);
            if (carToUpdate == null)
                return NotFound("Sorry, we could not find the car to update");
            if (string.IsNullOrEmpty(updateCar.Make))
                return BadRequest("Car make is needed");
            if (string.IsNullOrEmpty(updateCar.Model))
                return BadRequest("Car model is needed");
            if (updateCar.Year < 1900 || updateCar.Year > DateTime.Now.Year)
                return BadRequest("Year input is not acceptable");
            var updatedCar = CarService.UpdateCar(updateCar, id, dbContext);
            return Ok(updatedCar);
        }
        [HttpDelete("{id}")]
        public ActionResult<string> DeleteCar(Guid id)
        {
            var carToDelete = CarService.GetCar(id, dbContext);
            if (carToDelete == null)
                return NotFound("Sorry, we could not find the car to delete");
            var deletedCarResponse = CarService.DeleteCar(id, dbContext);
            return deletedCarResponse;
        }
    }
}
