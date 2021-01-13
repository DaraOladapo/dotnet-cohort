using EF.CodeFirst.Data;
using EF.CodeFirst.Models.Binding;
using EF.CodeFirst.Models.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EF.CodeFirst.Services
{
    public class CarServices
    {
        public static string connectionString = "Data Source=.;Initial Catalog=CarsDB;Integrated Security=True";
        private static ApplicationDbContext dbContext;
        public CarServices(ApplicationDbContext _dbContext)
        {
            dbContext = _dbContext;
        }
        //C
        public static Car AddCar(AddCar addCar)
        {
            var carToAdd = new Car()
            {
                DateAdded = DateTime.Now,
                DateModified = DateTime.Now,
                Make = addCar.Make,
                Model = addCar.Model,
                Year = addCar.Year,
                RegistrationNumber = addCar.RegistrationNumber
            };
            var addedCar = dbContext.Cars.Add(carToAdd).Entity;
            dbContext.SaveChanges();
            return addedCar;
        }
        //R
        public static List<Car> GetCars()
        {
            var allCars = dbContext.Cars.ToList();
            return allCars;
        }
        public static Car GetCar(int id)
        {
            var carFound = dbContext.Cars.FirstOrDefault(opt => opt.Id == id);
            return carFound;
        }
        //U
        public static Car UpdateCar(UpdateCar updateCar, int id)
        {
            var carToUpdate = dbContext.Cars.FirstOrDefault(opt => opt.Id == id);
            if (carToUpdate != null)
            {
                carToUpdate.DateModified = DateTime.Now;
                carToUpdate.Make = updateCar.Make;
                carToUpdate.Model = updateCar.Model;
                carToUpdate.Year = updateCar.Year;
                carToUpdate.RegistrationNumber = updateCar.RegistrationNumber;
            }
            dbContext.SaveChanges();
            return carToUpdate;
        }
        //D
        public static string DeleteCar(int id)
        {
            var carToDelete = dbContext.Cars.FirstOrDefault(opt => opt.Id == id);
            if (carToDelete != null)
            {
                dbContext.Remove(carToDelete);
            }
            return $"Car with ID {id} has been deleted.";
        }
    }
}
