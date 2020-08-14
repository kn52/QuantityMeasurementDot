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
            Quantity feetOne = new Quantity(0, Quantity.UnitType.FEET);
            Quantity feetTwo = new Quantity(0, Quantity.UnitType.FEET);
            bool result = feetOne.Equals(feetTwo);
            Assert.IsTrue(result);
        }

        [Test]
        public void GivenZeroFeet_WhenComparedWithNull_ShouldReturnTrue()
        {
            Quantity feetOne = new Quantity(0, Quantity.UnitType.FEET);
            Quantity feetTwo = null;
            bool result = feetOne.Equals(feetTwo);
            Assert.IsTrue(result);
        }

        [Test]
        public void GivenZeroFeet_WhenComparedByReference_ShouldReturnFalse()
        {
            Quantity feetOne = new Quantity(0, Quantity.UnitType.FEET);
            Quantity feetTwo = new Quantity(12, Quantity.UnitType.FEET);
            bool result = feetOne.Equals(feetTwo);
            Assert.IsFalse(result);
        }

        [Test]
        public void GivenZeroFeet_WhenComparedBySameReference_ShouldReturnTrue()
        {
            Quantity feetOne = new Quantity(0, Quantity.UnitType.FEET);
            Quantity feetTwo = feetOne;
            bool result = feetOne.Equals(feetTwo);
            Assert.IsTrue(result);
        }

        [Test]
        public void GivenZeroFeet_WhenComparedByType_ShouldReturnTrue()
        {
            Quantity feetOne = new Quantity(0, Quantity.UnitType.FEET);
            Quantity feetTwo = new Quantity();
            bool result = feetOne.Equals(feetTwo);
            Assert.IsTrue(result);
        }

        [Test]
        public void GivenZeroFeet_WhenComparedByValue_ShouldReturnTrue()
        {
            Quantity feetOne = new Quantity(12, Quantity.UnitType.FEET);
            Quantity feetTwo = new Quantity(12, Quantity.UnitType.FEET);
            bool result = feetOne.Equals(feetTwo);
            Assert.IsTrue(result);
        }

        [Test]
        public void GivenZeroFeet_WhenComparedByNegativeValue_ShouldReturnFalse()
        {
            Quantity feetOne = new Quantity(-5, Quantity.UnitType.FEET);
            Quantity feetTwo = new Quantity(12, Quantity.UnitType.FEET);
            bool result = feetOne.Equals(feetTwo);
            Assert.IsFalse(result);
        }

        [Test]
        public void givenZeroInch_WhenComparedWithAnotherZeroInch_ShouldReturnTrue()
        {
            Quantity inchOne = new Quantity(0, Quantity.UnitType.INCH);
            Quantity inchTwo = new Quantity(0, Quantity.UnitType.INCH);
            bool result = inchOne.Equals(inchTwo);
            Assert.IsTrue(result);
        }

        [Test]
        public void givenZeroInch_WhenComparedWithNullValue_ShouldReturnTrue()
        {
            Quantity inchOne = new Quantity(0, Quantity.UnitType.INCH);
            Quantity inchTwo = null;
            bool result = inchOne.Equals(inchTwo);
            Assert.IsTrue(result);
        }

        [Test]
        public void givenZeroInch_WhenComparedByReference_ShouldReturnFalse()
        {
            Quantity inchOne = new Quantity(0, Quantity.UnitType.INCH);
            Quantity inchTwo = new Quantity(12, Quantity.UnitType.INCH);
            bool result = inchOne.Equals(inchTwo);
            Assert.IsFalse(result);
        }

        [Test]
        public void givenZeroInch_WhenComparedBySameReference_ShouldReturnTrue()
        {
            Quantity inchOne = new Quantity(0, Quantity.UnitType.INCH);
            Quantity inchTwo = inchOne;
            bool result = inchOne.Equals(inchTwo);
            Assert.IsTrue(result);
        }

        [Test]
        public void givenZeroInch_WhenComparedByType_ShouldReturnTrue()
        {
            Quantity inchOne = new Quantity(0, Quantity.UnitType.INCH);
            Quantity inchTwo = new Quantity();
            bool result = inchOne.Equals(inchTwo);
            Assert.IsTrue(result);
        }

        [Test]
        public void givenZeroInch_WhenComparedByValue_ShouldReturnTrue()
        {
            Quantity inchOne = new Quantity(12, Quantity.UnitType.INCH);
            Quantity inchTwo = new Quantity(12, Quantity.UnitType.INCH);
            bool result = inchOne.Equals(inchTwo);
            Assert.IsTrue(result);
        }

        [Test]
        public void givenZeroInch_WhenComparedByNegativeValue_ShouldReturnFalse()
        {
            Quantity inchOne = new Quantity(-12, Quantity.UnitType.INCH);
            Quantity inchTwo = new Quantity(12, Quantity.UnitType.INCH);
            bool result = inchOne.Equals(inchTwo);
            Assert.IsFalse(result);
        }
    }
}