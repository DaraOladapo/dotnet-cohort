using Microsoft.VisualStudio.TestTools.UnitTesting;
using Car.Library;

namespace Car.MSTest
{
    [TestClass]
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

        [TestMethod]
        public void Start()
        {
            Assert.IsNotNull(myGoodCar);
            Assert.AreEqual(myGoodCar.Start(), $"{myGoodCar.Make} {myGoodCar.Model} {myGoodCar.Year} is started with Range {myGoodCar.Range}.");

            //Assert.IsNull(myBadCar.Start());

            Assert.IsNull(myReallyBadCar);

        }
        [TestMethod]
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
