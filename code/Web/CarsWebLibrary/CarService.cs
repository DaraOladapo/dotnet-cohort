using CarsWebLibrary.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CarsWebLibrary
{
    public class CarService
    {
        //ctor
        private static ApplicationDbContext dbContext;
        public CarService(ApplicationDbContext applicationDb)
        {
            dbContext = applicationDb;
        }
        //C
        public static Car AddCar(AddCar addCar)
        {
            var carToAdd = new Car() { ID = Guid.NewGuid(), Make = addCar.Make, Model = addCar.Model, Year = addCar.Year };
            var addedCar = dbContext.Cars.Add(carToAdd).Entity;
            dbContext.SaveChanges();
            return addedCar;
        }
        //R
        public static List<Car> GetCars()
        {
            var cars = dbContext.Cars.ToList();
            return cars;
        }
        public static Car GetCar(Guid guid)
        {
            var carFound = dbContext.Cars.FirstOrDefault(c => c.ID == guid);
            return carFound;
        }
        //U
        public static Car UpdateCar(UpdateCar updateCar, Guid guid)
        {
            var carToUpdate = dbContext.Cars.FirstOrDefault(c => c.ID == guid);
            carToUpdate.Make = updateCar.Make;
            carToUpdate.Model = updateCar.Model;
            carToUpdate.Year = updateCar.Year;
            dbContext.SaveChanges();
            return carToUpdate;
        }
        //D
        public static string DeleteCar(Guid guid)
        {
            var carToDelete = dbContext.Cars.FirstOrDefault(c => c.ID == guid);
            dbContext.Cars.Remove(carToDelete);
            dbContext.SaveChanges();
            return ($"Item with ID: {guid} deleted.");
        }
    }
}
