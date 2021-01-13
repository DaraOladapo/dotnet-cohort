using EF.CodeFirst.Models.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace EF.CodeFirst.Helpers
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
                    Console.WriteLine($"{car.Id}: {car.Make} {car.Model} {car.Year} with registration number {car.RegistrationNumber} was added on {car.DateAdded:d}");
                }
            }
        }
        public static void Print(this Car car)
        {
            Console.WriteLine($"{car.Id}: {car.Make} {car.Model} {car.Year} with registration number {car.RegistrationNumber} was added on {car.DateAdded:d}");
        }
    }
}
