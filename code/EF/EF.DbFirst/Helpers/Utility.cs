using EF.DbFirst.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace EF.DbFirst.Helpers
{
    public static class Utilities
    {
        public static void Print(this List<Car> cars)
        {
            if (cars.Count < 1)
                Console.WriteLine("No cars were found");
            else
            {
                foreach (var car in cars)
                {
                    Console.WriteLine($"{cars.IndexOf(car) + 1}. ID: {car.Id} {car.Make} {car.Model} {car.Year} with registration number {car.RegistrationNumber} was added on {car.DateAdded:d} at {car.DateAdded:t}");
                }
            }
        }
        public static void Print(this Car car)
        {
            Console.WriteLine($"{car.Id}: {car.Make} {car.Model} {car.Year} with registration number {car.RegistrationNumber} was added on {car.DateAdded:d}");
        }
    }
}
