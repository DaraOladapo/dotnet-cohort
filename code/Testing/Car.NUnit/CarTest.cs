using NUnit.Framework;

namespace Car.NUnit
{
    public class Tests
    {
        Library.Car myGoodCar, myReallyBadCar;
        [SetUp]
        public void Setup()
        {
            myGoodCar = new Library.Car()
            {
                Make = "Toyota",
                Model = "CH-R",
                Year = 2020,
                Range = 50
            };
            myReallyBadCar = null;
        }

        [Test]
        public void Start()
        {
            Assert.NotNull(myGoodCar);
            Assert.AreEqual(myGoodCar.Start(), $"{myGoodCar.Make} {myGoodCar.Model} {myGoodCar.Year} is started with Range {myGoodCar.Range}.");
            Assert.IsInstanceOf<Library.Car>(myGoodCar);
            Assert.Null(myReallyBadCar);
        }
        [Test]
        public void FillUp()
        {
            var originalRange = myGoodCar.Range;
            var fillUpResult = myGoodCar.FillUp();
            var newRange = myGoodCar.Range;

            Assert.IsNotNull(fillUpResult);
            Assert.AreNotEqual(originalRange, newRange);

            Assert.AreEqual(fillUpResult, $"{myGoodCar.Make} {myGoodCar.Model} {myGoodCar.Year}'s new range is {myGoodCar.Range}.");
        }
    }
}