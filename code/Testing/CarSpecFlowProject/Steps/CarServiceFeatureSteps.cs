using CarConsole;
using System;
using System.Collections.Generic;
using TechTalk.SpecFlow;
using FluentAssertions;

namespace CarSpecFlowProject.Steps
{
    [Binding]
    public class CarServiceFeatureSteps
    {
        private readonly CarService _carService = new CarService();
        private List<Car> cars;
        private Car car;
        Guid ID;
        [When(@"I request for all cars")]
        public void WhenIRequestForAllCars()
        {
            cars = _carService.GetCars();
        }

        [Then(@"the result has a list of cars")]
        public void ThenTheResultHasAListOfCars()
        {
            cars.Should().BeOfType<List<Car>>();
        }
        [Then(@"the result should be greater than (.*)")]
        public void ThenTheResultShouldBeGreaterThan(int count)
        {
            cars.Count.Should().BeGreaterThan(count);
        }

        [Given(@"an ID")]
        public void GivenAnID()
        {
           ID = Guid.NewGuid();
        }

        [When(@"I request for a car")]
        public void WhenIRequestForACar()
        {
            car = _carService.GetCar(ID);
        }

        [Then(@"the result has a car")]
        public void ThenTheResultHasACar()
        {
           car.Should().BeOfType<Car>();
        }
    }
}
