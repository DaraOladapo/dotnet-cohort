using System;
using System.Collections.Generic;
using System.Text;

namespace OOP.Utilties
{
    public static class CarUtilities
    {
        public static double ServiceCar()
        {
            Console.WriteLine("Car has been serviced.");
            return 100;
        }
        public static double ServiceCharge = GetServiceCharge();

        public static int EngineHealthPercentage { get;  set; }

        public static double GetServiceCharge()
        {
            double serviceCharge;
            switch (EngineHealthPercentage)
            {
                case var val when (val >= 0 && val <= 20.0):
                    serviceCharge = 500;
                    break;
                case var val when (val > 20.0 && val <= 60.0):
                    serviceCharge = 300;
                    break;
                case var val when (val > 60.0):
                    serviceCharge = 100;
                    break;
                default:
                    serviceCharge = 1500;
                    break;
            }
            return serviceCharge;
        }
    }
}
