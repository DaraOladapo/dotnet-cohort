using System;

namespace OOP
{
    public class Car : ICar, ISomeInterace, ISomeOtherInterface
    {
        //public string Make;
        //public string Model;
        //public int Year;
        protected internal Guid ID { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public double Range { get; set; } = 5.0;
        public double EngineHealth { get; private set; } = 5;
        public static int EngineHealthPercentage { get; set; }

        public Car()
        {
            ID = Guid.NewGuid();
            Console.WriteLine("This runs before everything else.");
        }
        public Car(string make, string model, int year)
        {
            ID = Guid.NewGuid();
            Make = make;
            Model = model;
            Year = year;
            Console.WriteLine($"ID: {ID}\n{Make} {Model} {Year} has been initialized with values from the constructor.");
        }
        public void Start()
        {
            Console.WriteLine($"{Make} {Model} {Year} is started.");
        }
        public void Stop()
        {
            Console.WriteLine($"{Make} {Model} {Year} has stopped.");
        }
        public void Accelerate()
        {
            EngineHealth--;
            Console.WriteLine($"{Make} {Model} {Year} has accelerated. Engine health is now {GetEngineHeath()}%");
        }

        public double GetEngineHeath()
        {
            var EngineHealthPercentage = EngineHealth / 5 * 100;
            return EngineHealthPercentage;
        }

        public void Deccelerate()
        {
            Console.WriteLine($"{Make} {Model} {Year} has decelerated.");
        }
        public void FillUp()
        {
            Console.WriteLine($"{Make} {Model} {Year}'s before fillup is {Range}.");
            Range++;
            Console.WriteLine($"{Make} {Model} {Year}'s new range is {Range}.");
        }
        public void FillUp(double Fuel)
        {
            Console.WriteLine($"{Make} {Model} {Year}'s before fillup is {Range}.");
            var rangeIncrease = Fuel / 2.5;
            Range += rangeIncrease;
            Console.WriteLine($"{Make} {Model} {Year}'s new range is {Range}.");
        }
        public void FillUp(decimal Charge)
        {
            Console.WriteLine($"{Make} {Model} {Year}'s before fillup is {Range}.");
            var rangeIncrease = (double)Charge * 2.0;
            Range += rangeIncrease;
            Console.WriteLine($"{Make} {Model} {Year}'s new range is {Range}.");
        }

        public MOTStatus DoMOT(double EngineHealthPercentage)
        {
            var motStatus = MOTStatus.Good;
            switch (EngineHealthPercentage)
            {
                case var val when (val >= 0 && val <= 20.0):
                    motStatus = MOTStatus.Bad;
                    break;
                case var val when (val > 20.0 && val <= 60.0):
                    motStatus = MOTStatus.Managable;
                    break;
                case var val when (val > 60.0):
                    motStatus = MOTStatus.Good;
                    break;
                default:
                    motStatus = MOTStatus.Inderterminate;
                    break;
            }
            return motStatus;
        }

        public void Service()
        {
            Console.WriteLine("My car is now serviced");
        }

        public void Service(DateTime dateTime)
        {
            Console.WriteLine($"My car was serviced on {dateTime:d}");
        }
    }

}
