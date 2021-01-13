using Xunit;
using FluentAssertions;

namespace Car.XUnit
{
    public class CarTest
    {
        Library.Car myGoodCar = new Library.Car()
        {
            Make = "Toyota",
            Model = "CH-R",
            Year = 2020,
            Range = 50
        };
        Library.Car myReallyBadCar = null;
        [Fact]
        public void Start()
        {
            //Assert.NotNull(myGoodCar);
            myGoodCar.Should().NotBeNull();
            //Assert.Equal(myGoodCar.Start(), $"{myGoodCar.Make} {myGoodCar.Model} {myGoodCar.Year} is started with Range {myGoodCar.Range}.");
            myGoodCar.Start().Should().NotBeEmpty();
            myGoodCar.Start().Should().Equals($"{myGoodCar.Make} {myGoodCar.Model} {myGoodCar.Year} is started with Range {myGoodCar.Range}.");
            //Assert.Null(myReallyBadCar);
            myReallyBadCar.Should().BeNull();
        }
        [Fact]
        public void FillUp()
        {
            var originalRange = myGoodCar.Range;
            var fillUpResult = myGoodCar.FillUp();
            var newRange = myGoodCar.Range;

            //Assert.NotNull(fillUpResult);
            fillUpResult.Should().NotBeNull();
            //Assert.NotEqual(originalRange, newRange);
            originalRange.Should().BeLessThan(newRange);
            //Assert.Equal(fillUpResult, $"{myGoodCar.Make} {myGoodCar.Model} {myGoodCar.Year}'s new range is {myGoodCar.Range}.");
            fillUpResult.Should().Equals($"{myGoodCar.Make} {myGoodCar.Model} {myGoodCar.Year}'s new range is {myGoodCar.Range}.");
        }
        [Fact]
        public void Stop()
        {
            Assert.Equal(myGoodCar.Stop(), $"{myGoodCar.Make} {myGoodCar.Model} {myGoodCar.Year} has stopped.");
        }
        [Fact]
        public void GetRange()
        {
            //Assert.Equal(450, myGoodCar.Range);
            Assert.IsType<double>(myGoodCar.GetRange());
        }
    }
}
