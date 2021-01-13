using CarConsole;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;
using FluentAssertions;

namespace CarSpecFlow.Steps
{
    [Binding]
    public sealed class CarStepsDefinition
    {
        // For additional details on SpecFlow step definitions see https://go.specflow.org/doc-stepdef

        private readonly ScenarioContext _scenarioContext;
        private readonly ICarService _iCarService;
        private readonly CarService _carService;
        private List<Car> cars;
        private Car car;

        public CarStepsDefinition(ScenarioContext scenarioContext, ICarService iCarService)
        {
            _scenarioContext = scenarioContext;
            _iCarService = iCarService;
            _carService = new CarService(_iCarService);
        }

        [When(@"I request for list of cars")]
        public void WhenIRequestForListOfCars()
        {
            cars = _carService.GetCars();
        }

        [Then(@"the response has a list of cars")]
        public void ThenTheResponseHasAListOfCars()
        {
            cars.Should().BeOfType<List<Car>>();
        }

        [Given(@"an ID of Guid Type")]
        public void GivenAnIDOfGuidType()
        {
            car = _carService.GetCar(Guid.NewGuid());
        }

        [When(@"I request for a car")]
        public void WhenIRequestForACar()
        {
            car.Should().BeOfType<Car>();
        }

    }
}
