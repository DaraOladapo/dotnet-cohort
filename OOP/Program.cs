using OOP.Utilties;
using System;
using System.Collections;

namespace OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            //Car myToyota = new Car();
            //myToyota.Make = "Toyota";
            //myToyota.Model = "Prius";
            ////myToyota.ID = Guid.NewGuid();
            //myToyota.Year = 2019;
            //myToyota.Start();
            //myToyota.Accelerate();
            //myToyota.Deccelerate();
            //myToyota.Stop();

            Car myFord = new Car
            {
                Make = "Ford",
                Model = "EcoSport",
                Year = 2020
            };
            //myFord.Start();
            //myFord.Accelerate();
            //myFord.Deccelerate();
            //myFord.Stop();
            myFord.Service();
            myFord.Service(DateTime.Now);

            //Car myNissan = new Car("Nissan", "Qashqai", 2018);
            //myNissan.Start();
            //var motStatus = myNissan.DoMOT(myNissan.GetEngineHeath());
            //Console.WriteLine($"MOT Status: {motStatus}");
            //myNissan.Accelerate();
            //myNissan.Accelerate();
            //myNissan.Accelerate();
            //motStatus = myNissan.DoMOT(myNissan.GetEngineHeath());
            //Console.WriteLine($"MOT Status: {motStatus}");
            //myNissan.Deccelerate();
            //myNissan.Stop();
            //myNissan.FillUp(20.0);

            //ArrayList myCarList = new ArrayList();
            //myCarList.Add(myToyota);
            //myCarList.Add(myFord);
            //myCarList.Add(myNissan);
            //Console.WriteLine("\n\n\n\n\n\n\n");

            //ElectricCar myTesla = new ElectricCar() { Make = "Tesla", Model = "Model S", Year = 2017 };
            //myTesla.Start();
            //var TeslaMotStatus = myTesla.DoMOT(myTesla.GetEngineHeath());
            //Console.WriteLine($"MOT Status: {TeslaMotStatus}");
            //myTesla.Accelerate();
            //myTesla.Accelerate();
            //myTesla.Accelerate();
            //TeslaMotStatus = myTesla.DoMOT(myTesla.GetEngineHeath());
            //Console.WriteLine($"MOT Status: {TeslaMotStatus}");
            //myTesla.Accelerate();
            //TeslaMotStatus = myTesla.DoMOT(myTesla.GetEngineHeath());
            //Console.WriteLine($"MOT Status: {TeslaMotStatus}");
            //myTesla.Accelerate();
            //TeslaMotStatus = myTesla.DoMOT(myTesla.GetEngineHeath());
            //Console.WriteLine($"MOT Status: {TeslaMotStatus}");


            //myTesla.EngineHealth = CarUtilities.ServiceCar();
            //TeslaMotStatus = myTesla.DoMOT(myTesla.GetEngineHeath());
            //Console.WriteLine($"MOT Status: {TeslaMotStatus}");

            //myTesla.Deccelerate();
            //myTesla.Stop();
            //myTesla.FillUp(5M);
            //CarUtilities.EngineHealthPercentage = -25;
            //var engineHealthStatus = CarUtilities.EngineHealthPercentage;
            //var serviceCharge = CarUtilities.GetServiceCharge();
            //Console.WriteLine($"Service charge is {serviceCharge:c}");
        }
    }
}
