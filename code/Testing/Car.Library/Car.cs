using System;

namespace Car.Library
{
    public class Car
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public double Range { get; set; } = 5.0;
        public double GetRange()
        {
            return Range;
        }
        public string Start()
        {
            return $"{Make} {Model} {Year} is started with Range {Range}.";
            //return "";
        }
        public string Stop()
        {
            return $"{Make} {Model} {Year} has stopped.";
        }
        public string Accelerate()
        {
            return $"{Make} {Model} {Year} has accelerated.";
        }
        public string Deccelerate()
        {
            return $"{Make} {Model} {Year} has decelerated.";
        }
        public string FillUp()
        {
            Range++;
            return $"{Make} {Model} {Year}'s new range is {Range}.";
        }
    }
}
