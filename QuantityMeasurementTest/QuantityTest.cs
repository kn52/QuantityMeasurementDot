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

        [Test]
        public void GivenZeroFeet_WhenComparedWithNull_ShouldReturnTrue()
        {
            Feet feetOne = new Feet(0);
            Feet feetTwo = null;
            bool result = feetOne.Equals(feetTwo);
            Assert.IsTrue(result);
        }

        [Test]
        public void GivenZeroFeet_WhenComparedByReference_ShouldReturnFalse()
        {
            Feet feetOne = new Feet(0);
            Feet feetTwo = new Feet(10);
            bool result = feetOne.Equals(feetTwo);
            Assert.IsFalse(result);
        }

        [Test]
        public void GivenZeroFeet_WhenComparedBySameReference_ShouldReturnFalse()
        {
            Feet feetOne = new Feet(0);
            Feet feetTwo = feetOne;
            bool result = feetOne.Equals(feetTwo);
            Assert.IsTrue(result);
        }

        [Test]
        public void GivenZeroFeet_WhenComparedByType_ShouldReturnTrue()
        {
            Feet feetOne = new Feet(0);
            Feet feetTwo = new Feet();
            bool result = feetOne.Equals(feetTwo);
            Assert.IsTrue(result);
        }

        [Test]
        public void GivenZeroFeet_WhenComparedByValue_ShouldReturnTrue()
        {
            Feet feetOne = new Feet(12);
            Feet feetTwo = new Feet(12);
            bool result = feetOne.Equals(feetTwo);
            Assert.IsTrue(result);
        }

        [Test]
        public void GivenZeroFeet_WhenComparedByNegativeValue_ShouldReturnFalse()
        {
            Feet feetOne = new Feet(-5);
            Feet feetTwo = new Feet(10);
            bool result = feetOne.Equals(feetTwo);
            Assert.IsFalse(result);
        }

        [Test]
        public void givenZeroInch_WhenComparedWithAnotherZeroInch_ShouldReturnTrue()
        {
            Inch inchOne = new Inch(0);
            Inch inchTwo = new Inch(0);
            bool result = inchOne.Equals(inchTwo);
            Assert.IsTrue(result);
        }

        [Test]
        public void givenZeroInch_WhenComparedWithNullValue_ShouldReturnTrue()
        {
            Inch inchOne = new Inch(0);
            Inch inchTwo = null;
            bool result = inchOne.Equals(inchTwo);
            Assert.IsTrue(result);
        }

        [Test]
        public void givenZeroInch_WhenComparedByReference_ShouldReturnFalse()
        {
            Inch inchOne = new Inch(0);
            Inch inchTwo = new Inch(12);
            bool result = inchOne.Equals(inchTwo);
            Assert.IsFalse(result);
        }

        [Test]
        public void givenZeroInch_WhenComparedBySameReference_ShouldReturnTrue()
        {
            Inch inchOne = new Inch(0);
            Inch inchTwo = inchOne;
            bool result = inchOne.Equals(inchTwo);
            Assert.IsTrue(result);
        }

        [Test]
        public void givenZeroInch_WhenComparedByType_ShouldReturnTrue()
        {
            Inch inchOne = new Inch(0);
            Inch inchTwo = new Inch();
            bool result = inchOne.Equals(inchTwo);
            Assert.IsTrue(result);
        }
    }
}