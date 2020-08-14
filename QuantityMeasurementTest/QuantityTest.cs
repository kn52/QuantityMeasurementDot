using NUnit.Framework;
using QuantityMeasurementSln;

namespace Tests
{
    public class Tests
    {
        Quantity quantity;

        [SetUp]
        public void Setup()
        {
            quantity = new Quantity();
        }

        [Test]
        public void GivenZeroFeet_WhenComparedWithAnotherZeroFeet_ShouldReturnTrue()
        {
            Quantity feetOne = new Quantity(0, "FEET");
            Quantity feetTwo = new Quantity(0, "FEET");
            bool result = feetOne.Equals(feetTwo);
            Assert.IsTrue(result);
        }

        [Test]
        public void GivenZeroFeet_WhenComparedWithNull_ShouldReturnTrue()
        {
            Quantity feetOne = new Quantity(0, "FEET");
            Quantity feetTwo = null;
            bool result = feetOne.Equals(feetTwo);
            Assert.IsTrue(result);
        }

        [Test]
        public void GivenZeroFeet_WhenComparedByReference_ShouldReturnFalse()
        {
            Quantity feetOne = new Quantity(0, "FEET");
            Quantity feetTwo = new Quantity(12, "FEET");
            bool result = feetOne.Equals(feetTwo);
            Assert.IsFalse(result);
        }

        [Test]
        public void GivenZeroFeet_WhenComparedBySameReference_ShouldReturnTrue()
        {
            Quantity feetOne = new Quantity(0, "FEET");
            Quantity feetTwo = feetOne;
            bool result = feetOne.Equals(feetTwo);
            Assert.IsTrue(result);
        }

        [Test]
        public void GivenZeroFeet_WhenComparedByType_ShouldReturnTrue()
        {
            Quantity feetOne = new Quantity(0, "FEET");
            Quantity feetTwo = new Quantity();
            bool result = feetOne.Equals(feetTwo);
            Assert.IsTrue(result);
        }

        [Test]
        public void GivenZeroFeet_WhenComparedByValue_ShouldReturnTrue()
        {
            Quantity feetOne = new Quantity(12, "FEET");
            Quantity feetTwo = new Quantity(12, "FEET");
            bool result = feetOne.Equals(feetTwo);
            Assert.IsTrue(result);
        }

        [Test]
        public void GivenZeroFeet_WhenComparedByNegativeValue_ShouldReturnFalse()
        {
            Quantity quantityOne = new Quantity(-5, "FEET");
            Quantity quantityTwo = new Quantity(12, "FEET");
            bool result = quantityOne.Equals(quantityTwo);
            Assert.IsFalse(result);
        }

        [Test]
        public void givenZeroInch_WhenComparedWithAnotherZeroInch_ShouldReturnTrue()
        {
            Quantity inchOne = new Quantity(0, "INCH");
            Quantity inchTwo = new Quantity(0, "INCH");
            bool result = inchOne.Equals(inchTwo);
            Assert.IsTrue(result);
        }

        [Test]
        public void givenZeroInch_WhenComparedWithNullValue_ShouldReturnTrue()
        {
            Quantity inchOne = new Quantity(0, "INCH");
            Quantity inchTwo = null;
            bool result = inchOne.Equals(inchTwo);
            Assert.IsTrue(result);
        }

        [Test]
        public void givenZeroInch_WhenComparedByReference_ShouldReturnFalse()
        {
            Quantity inchOne = new Quantity(0, "INCH");
            Quantity inchTwo = new Quantity(12, "INCH");
            bool result = inchOne.Equals(inchTwo);
            Assert.IsFalse(result);
        }

        [Test]
        public void givenZeroInch_WhenComparedBySameReference_ShouldReturnTrue()
        {
            Quantity inchOne = new Quantity(0, "INCH");
            Quantity inchTwo = inchOne;
            bool result = inchOne.Equals(inchTwo);
            Assert.IsTrue(result);
        }

        [Test]
        public void givenZeroInch_WhenComparedByType_ShouldReturnTrue()
        {
            Quantity inchOne = new Quantity(0, "INCH");
            Quantity inchTwo = new Quantity();
            bool result = inchOne.Equals(inchTwo);
            Assert.IsTrue(result);
        }

        [Test]
        public void givenZeroInch_WhenComparedByValue_ShouldReturnTrue()
        {
            Quantity inchOne = new Quantity(12, "INCH");
            Quantity inchTwo = new Quantity(12, "INCH");
            bool result = inchOne.Equals(inchTwo);
            Assert.IsTrue(result);
        }

        [Test]
        public void givenZeroInch_WhenComparedByNegativeValue_ShouldReturnFalse()
        {
            Quantity quantityOne = new Quantity(-12, "INCH");
            Quantity quantityTwo = new Quantity(12, "INCH");
            bool result = quantityOne.Equals(quantityTwo);
            Assert.IsFalse(result);
        }

        [Test]
        public void givenZeroFeet_WhenComparedByZeroInch_ShouldReturnTrue()
        {
            Quantity quantityOne= new Quantity(0, "FEET");
            Quantity quantityTwo = new Quantity(0, "INCH");
            bool result = quantity.Compare(quantityOne,quantityTwo);
            Assert.IsTrue(result);
        }

        [Test]
        public void givenOneFeet_WhenComparedByOneInch_ShouldReturnFalse()
        {
            Quantity quantityOne = new Quantity(1, "FEET");
            Quantity quantityTwo = new Quantity(1, "INCH");
            bool result = quantity.Compare(quantityOne, quantityTwo);
            Assert.IsFalse(result);
        }

        [Test]
        public void givenOneInch_WhenComparedByOneFeet_ShouldReturnFalse()
        {
            Quantity quantityOne = new Quantity(1, "INCH");
            Quantity quantityTwo = new Quantity(1, "FEET");
            bool result = quantity.Compare(quantityOne, quantityTwo);
            Assert.IsFalse(result);
        }

        [Test]
        public void givenOneFeet_WhenComparedByTwelveInch_ShouldReturnTrue()
        {
            Quantity quantityOne = new Quantity(1, "FEET");
            Quantity quantityTwo = new Quantity(12, "INCH");
            bool result = quantity.Compare(quantityOne, quantityTwo);
            Assert.IsTrue(result);
        }

        [Test]
        public void givenTwelveInch_WhenComparedByOneFeet_ShouldReturnTrue()
        {
            Quantity quantityOne = new Quantity(12, "INCH");
            Quantity quantityTwo = new Quantity(1, "FEET");
            bool result = quantity.Compare(quantityOne, quantityTwo);
            Assert.IsTrue(result);
        }

        [Test]
        public void givenThreeFeet_WhenComparedByOneYard_ShouldReturnTrue()
        {
            Quantity quantityOne = new Quantity(3, "FEET");
            Quantity quantityTwo = new Quantity(1, "YARD");
            bool result = quantity.Compare(quantityOne, quantityTwo);
            Assert.IsTrue(result);
        }

        [Test]
        public void givenOneFeet_WhenComparedByOneYard_ShouldReturnFalse()
        {
            Quantity quantityOne = new Quantity(1, "FEET");
            Quantity quantityTwo = new Quantity(1, "YARD");
            bool result = quantity.Compare(quantityOne, quantityTwo);
            Assert.IsFalse(result);
        }

        [Test]
        public void givenOneInch_WhenComparedByOneYard_ShouldReturnFalse()
        {
            Quantity quantityOne = new Quantity(1, "INCH");
            Quantity quantityTwo = new Quantity(1, "YARD");
            bool result = quantity.Compare(quantityOne, quantityTwo);
            Assert.IsFalse(result);
        }
    }
}