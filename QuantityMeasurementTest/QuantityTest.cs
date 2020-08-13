using NUnit.Framework;
using QuantityMeasurementSln;

namespace Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void GivenZeroFeet_WhenComparedWithAnotherZeroFeet_ShouldReturnTrue()
        {
            Feet feetOne = new Feet(0);
            Feet feetTwo = new Feet(0);
            bool result = feetOne.Equals(feetTwo);
            Assert.IsTrue(result);
        }
    }
}