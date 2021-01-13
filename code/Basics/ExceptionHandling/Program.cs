using System;

namespace ExceptionHandling
{
    class Program
    {
        static void Main(string[] args)
        {
            //Car myCar = new Car() { Make = "Toyota", Model = "CH-R", Year = 2020 };
            //Console.WriteLine(myCar.ToString());
            Console.WriteLine("Enter car make: ");
            string carMake = Console.ReadLine();
            Console.WriteLine("Enter car model: ");
            string carModel = Console.ReadLine();
            Console.WriteLine("Enter car year: ");
            int carYear = int.Parse(Console.ReadLine());
            Car myCar = new Car()
            {
                Make = carMake,
                Model = carModel,
                Year = carYear
            };
            Console.WriteLine(myCar.ToString());
            //try
            //{
            //    int carYear = int.Parse(Console.ReadLine());
            //    Car myCar = new Car()
            //    {
            //        Make = carMake,
            //        Model = carModel,
            //        Year = carYear
            //    };
            //    Console.WriteLine(myCar.ToString());
            //}
            //catch
            //{
            //    Console.WriteLine("Year input was invalid, we cannot continue this process. Please try again.");
            //}
            //finally
            //{
            //    Console.WriteLine("This will run anyway");
            //}
            //int carYear;
            //string carYearInput = Console.ReadLine();
            //var isValidCarYearInput = int.TryParse(carYearInput, out carYear);
            //if (!isValidCarYearInput)
            //    Console.WriteLine("Year input was invalid, please try again");

        }
    }
    class Car
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public override string ToString()
        {
            if (Year < 1990)
                throw new Exception("Car is too old");
            return $"{Make} {Model} {Year}";
        }
    }
}
