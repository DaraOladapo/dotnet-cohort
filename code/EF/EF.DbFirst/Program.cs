using EF.DbFirst.Helpers;
using EF.DbFirst.Models;
using EF.DbFirst.Models.Binding;
using EF.DbFirst.Services;
using System;

namespace EF.DbFirst
{
    class Program
    {
        static void Main(string[] args)
        {
            Welcome();
        }
        static void Welcome()
        {
            int carId;
            Console.WriteLine("Welcome to our cars garage. What would you like to do today?\n1 to add a car\n2 to see all cars\n3 to find a car\n4 to update  car's details\n5 to remove a car");
            int userIput = int.Parse(Console.ReadLine());
            switch (userIput)
            {
                case 1:
                    var carDetailsToAdd = GetCarInput();
                    AddCar(carDetailsToAdd);
                    break;
                case 2:
                    GetAllCars();
                    break;
                case 3:
                    carId = GetCarID();
                    GetCar(carId);
                    Welcome();
                    break;
                case 4:
                    carId = GetCarID();
                    var detailsToUpdate = GetCarInput();
                    UpdateCar(detailsToUpdate, carId);
                    break;
                case 5:
                    carId = GetCarID();
                    DeleteCar(carId);
                    break;
                default:
                    Console.WriteLine("Input was not recognized. Try again.");
                    Welcome();
                    break;
            }
        }

        private static void DeleteCar(int carId)
        {
            var deletedCarResponse = CarServices.DeleteCar(carId);
            Console.WriteLine(deletedCarResponse);
            Welcome();
        }

        private static void UpdateCar(CarDetails detailsToUpdate, int carId)
        {
            var updateCar = new UpdateCar
            {
                Make = detailsToUpdate.Make,
                Model = detailsToUpdate.Model,
                Year = detailsToUpdate.Year,
                RegistrationNumber = detailsToUpdate.RegistrationNumber
            };
            var updatedCar = CarServices.UpdateCar(updateCar, carId);
            updatedCar.Print();
            Welcome();
        }

        private static int GetCarID()
        {
            Console.WriteLine("What is the car's id?");
            int carIdInput = int.Parse(Console.ReadLine());
            return carIdInput;
        }

        private static Car GetCar(int carIdInput)
        {
            var carFound = CarServices.GetCar(carIdInput);
            carFound.Print();
            return carFound;
        }

        private static void GetAllCars()
        {
            var allCars = CarServices.GetCars();
            allCars.Print();
            Welcome();
        }

        private static CarDetails GetCarInput()
        {
            Console.WriteLine("Car make:");
            var carMakeInput = Console.ReadLine();
            Console.WriteLine("Car model:");
            var carModelInput = Console.ReadLine();
            Console.WriteLine("Car year:");
            var carYearInput = int.Parse(Console.ReadLine());
            Console.WriteLine("Car registration number:");
            var carRegistrationNumberInput = Console.ReadLine();
            var carDetails = new CarDetails
            {
                Make = carMakeInput,
                Model = carModelInput,
                Year = carYearInput,
                RegistrationNumber = carRegistrationNumberInput
            };
            return carDetails;
        }

        private static void AddCar(CarDetails carDetails)
        {
            var carToAdd = new AddCar()
            {
                Make = carDetails.Make,
                Model = carDetails.Model,
                Year = carDetails.Year,
                RegistrationNumber = carDetails.RegistrationNumber
            };
            var addedCar = CarServices.AddCar(carToAdd);
            addedCar.Print();
            Welcome();
        }
    }
}
