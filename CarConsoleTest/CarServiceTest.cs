using CarConsole;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace CarConsoleTest
{
    public class CarServiceTest
    {
        private CarService mainCarService;
        private AddCar _addCar;
        private UpdateCar _updateCar;
        private List<ICar> cars;
        private readonly Mock<ICar> car;
        private readonly Mock<IAddCar> addCar;
        private readonly Mock<IUpdateCar> updateCar;
        private readonly Mock<ICarService> carService;
        public CarServiceTest()
        {
            addCar = new Mock<IAddCar>();
            _addCar = new AddCar() { Make = "Toyota", Model = "CH-R", Year = 2020 };

            car = new Mock<ICar>();
            cars = new List<ICar> { car.Object };

            updateCar = new Mock<IUpdateCar>();
            _updateCar = new UpdateCar() { Make = "Toyota", Model = "CH-R", Year = 2020 };

            carService = new Mock<ICarService>();

            mainCarService = new CarService(carService.Object);
        }
        [Fact]
        public void AddCar()
        {
            //Arrange
            carService.Setup(c => c.AddCar(addCar.Object)).Returns(car.Object);
            //Act
            var addCarResult = mainCarService.AddCar(_addCar);
            //Assert
            Assert.IsType<Car>(addCarResult);
        }
        [Fact]
        public void GetCars()
        {
            //Arrange
            carService.Setup(c => c.GetCars()).Returns(cars.AsEnumerable());
            //Act
            var getCarsResult = mainCarService.GetCars();
            //Assert
            Assert.IsType<List<Car>>(getCarsResult);
        }
        [Fact]
        public void GetCar()
        {
            //Arrange
            carService.Setup(c => c.GetCar(It.IsAny<Guid>())).Returns(car.Object);
            //Act
            var getCarResult = mainCarService.GetCar(Guid.NewGuid());
            //Assert
            Assert.IsType<Car>(getCarResult);
        }

        [Fact]
        public void UpdateCar()
        {
            //Arrange
            carService.Setup(c => c.UpdateCar(updateCar.Object, It.IsAny<Guid>())).Returns(car.Object);
            //Act
            var updateCarResult = mainCarService.UpdateCar(_updateCar, Guid.NewGuid());
            //Assert
            Assert.IsType<Car>(updateCarResult);
        }
        [Fact]
        public void DeleteCar()
        {
            //Arrange
            carService.Setup(c => c.DeleteCar(It.IsAny<Guid>()));
            //Act
            mainCarService.DeleteCar(Guid.NewGuid());
            //Assert

        }

    }
}
