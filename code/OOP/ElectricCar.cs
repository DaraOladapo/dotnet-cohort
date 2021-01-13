using System;

namespace OOP
{
    public class ElectricCar : Car
    {
        public ElectricCar()
        {
            this.ID = Guid.NewGuid();
            Console.WriteLine($"{this.ID} initialized");
        }
        new public void FillUp()
        {
            Console.WriteLine($"{Make} {Model} {Year}'s before charging is {Range}.");
            Range++;
            Console.WriteLine($"{Make} {Model} {Year}'s new range is {Range}.");
        }
    }

}
