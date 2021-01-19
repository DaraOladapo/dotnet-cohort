using CarsWebLibrary.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CarsWebLibrary
{
    public class CarService
    {
        //C
        public static Car AddCar(AddCar addCar, ApplicationDbContext dbContext)
        {
            var carToAdd = new Car() { Make = addCar.Make, Model = addCar.Model, Year = addCar.Year };
            var addedCar = dbContext.Cars.Add(carToAdd).Entity;
            dbContext.SaveChanges();
            return addedCar;
        }
        //R
        public static List<Car> GetCars( ApplicationDbContext dbContext)
        {
            var cars = dbContext.Cars.ToList();
            return cars;
        }
        public static Car GetCar(Guid guid, ApplicationDbContext dbContext)
        {
            var carFound = dbContext.Cars.FirstOrDefault(c => c.ID == guid);
            return carFound;
        }
        //U
        public static Car UpdateCar(UpdateCar updateCar, Guid guid, ApplicationDbContext dbContext)
        {
            var carToUpdate = dbContext.Cars.FirstOrDefault(c => c.ID == guid);
            carToUpdate.Make = updateCar.Make;
            carToUpdate.Model = updateCar.Model;
            carToUpdate.Year = updateCar.Year;
            dbContext.SaveChanges();
            return carToUpdate;
        }
        //D
        public static void DeleteCar(Guid guid, ApplicationDbContext dbContext)
        {
            var carToDelete = dbContext.Cars.FirstOrDefault(c => c.ID == guid);
            dbContext.Cars.Remove(carToDelete);
            dbContext.SaveChanges();
            //return ($"Item with ID: {guid} deleted.");
        }
    }
}
