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
            Quantity feetOne = new Quantity(0, "FEET", "LENGTH");
            Quantity feetTwo = new Quantity(0, "FEET", "LENGTH");
            bool result = feetOne.Equals(feetTwo);
            Assert.IsTrue(result);
        }

        [Test]
        public void GivenZeroFeet_WhenComparedWithNull_ShouldReturnTrue()
        {
            Quantity feetOne = new Quantity(0, "FEET", "LENGTH");
            Quantity feetTwo = null;
            bool result = feetOne.Equals(feetTwo);
            Assert.IsTrue(result);
        }

        [Test]
        public void GivenZeroFeet_WhenComparedByReference_ShouldReturnFalse()
        {
            Quantity feetOne = new Quantity(0, "FEET", "LENGTH");
            Quantity feetTwo = new Quantity(12, "FEET", "LENGTH");
            bool result = feetOne.Equals(feetTwo);
            Assert.IsFalse(result);
        }

        [Test]
        public void GivenZeroFeet_WhenComparedBySameReference_ShouldReturnTrue()
        {
            Quantity feetOne = new Quantity(0, "FEET", "LENGTH");
            Quantity feetTwo = feetOne;
            bool result = feetOne.Equals(feetTwo);
            Assert.IsTrue(result);
        }

        [Test]
        public void GivenZeroFeet_WhenComparedByType_ShouldReturnTrue()
        {
            Quantity feetOne = new Quantity(0, "FEET", "LENGTH");
            Quantity feetTwo = new Quantity();
            bool result = feetOne.Equals(feetTwo);
            Assert.IsTrue(result);
        }

        [Test]
        public void GivenZeroFeet_WhenComparedByValue_ShouldReturnTrue()
        {
            Quantity feetOne = new Quantity(12, "FEET", "LENGTH");
            Quantity feetTwo = new Quantity(12, "FEET", "LENGTH");
            bool result = feetOne.Equals(feetTwo);
            Assert.IsTrue(result);
        }

        [Test]
        public void GivenZeroFeet_WhenComparedByNegativeValue_ShouldReturnFalse()
        {
            Quantity quantityOne = new Quantity(-5, "FEET", "LENGTH");
            Quantity quantityTwo = new Quantity(12, "FEET", "LENGTH");
            bool result = quantityOne.Equals(quantityTwo);
            Assert.IsFalse(result);
        }

        [Test]
        public void givenZeroInch_WhenComparedWithAnotherZeroInch_ShouldReturnTrue()
        {
            Quantity inchOne = new Quantity(0, "INCH", "LENGTH");
            Quantity inchTwo = new Quantity(0, "INCH", "LENGTH");
            bool result = inchOne.Equals(inchTwo);
            Assert.IsTrue(result);
        }

        [Test]
        public void givenZeroInch_WhenComparedWithNullValue_ShouldReturnTrue()
        {
            Quantity inchOne = new Quantity(0, "INCH", "LENGTH");
            Quantity inchTwo = null;
            bool result = inchOne.Equals(inchTwo);
            Assert.IsTrue(result);
        }

        [Test]
        public void givenZeroInch_WhenComparedByReference_ShouldReturnFalse()
        {
            Quantity inchOne = new Quantity(0, "INCH", "LENGTH");
            Quantity inchTwo = new Quantity(12, "INCH", "LENGTH");
            bool result = inchOne.Equals(inchTwo);
            Assert.IsFalse(result);
        }

        [Test]
        public void givenZeroInch_WhenComparedBySameReference_ShouldReturnTrue()
        {
            Quantity inchOne = new Quantity(0, "INCH", "LENGTH");
            Quantity inchTwo = inchOne;
            bool result = inchOne.Equals(inchTwo);
            Assert.IsTrue(result);
        }

        [Test]
        public void givenZeroInch_WhenComparedByType_ShouldReturnTrue()
        {
            Quantity inchOne = new Quantity(0, "INCH", "LENGTH");
            Quantity inchTwo = new Quantity();
            bool result = inchOne.Equals(inchTwo);
            Assert.IsTrue(result);
        }

        [Test]
        public void givenZeroInch_WhenComparedByValue_ShouldReturnTrue()
        {
            Quantity inchOne = new Quantity(12, "INCH", "LENGTH");
            Quantity inchTwo = new Quantity(12, "INCH", "LENGTH");
            bool result = inchOne.Equals(inchTwo);
            Assert.IsTrue(result);
        }

        [Test]
        public void givenZeroInch_WhenComparedByNegativeValue_ShouldReturnFalse()
        {
            Quantity quantityOne = new Quantity(-12, "INCH", "LENGTH");
            Quantity quantityTwo = new Quantity(12, "INCH", "LENGTH");
            bool result = quantityOne.Equals(quantityTwo);
            Assert.IsFalse(result);
        }

        [Test]
        public void givenZeroFeet_WhenComparedByZeroInch_ShouldReturnTrue()
        {
            Quantity quantityOne= new Quantity(0, "FEET", "LENGTH");
            Quantity quantityTwo = new Quantity(0, "INCH", "LENGTH");
            bool result = quantity.Compare(quantityOne,quantityTwo);
            Assert.IsTrue(result);
        }

        [Test]
        public void givenOneFeet_WhenComparedByOneInch_ShouldReturnFalse()
        {
            Quantity quantityOne = new Quantity(1, "FEET", "LENGTH");
            Quantity quantityTwo = new Quantity(1, "INCH", "LENGTH");
            bool result = quantity.Compare(quantityOne, quantityTwo);
            Assert.IsFalse(result);
        }

        [Test]
        public void givenOneInch_WhenComparedByOneFeet_ShouldReturnFalse()
        {
            Quantity quantityOne = new Quantity(1, "INCH", "LENGTH");
            Quantity quantityTwo = new Quantity(1, "FEET", "LENGTH");
            bool result = quantity.Compare(quantityOne, quantityTwo);
            Assert.IsFalse(result);
        }

        [Test]
        public void givenOneFeet_WhenComparedByTwelveInch_ShouldReturnTrue()
        {
            Quantity quantityOne = new Quantity(1, "FEET", "LENGTH");
            Quantity quantityTwo = new Quantity(12, "INCH", "LENGTH");
            bool result = quantity.Compare(quantityOne, quantityTwo);
            Assert.IsTrue(result);
        }

        [Test]
        public void givenTwelveInch_WhenComparedByOneFeet_ShouldReturnTrue()
        {
            Quantity quantityOne = new Quantity(12, "INCH", "LENGTH");
            Quantity quantityTwo = new Quantity(1, "FEET", "LENGTH");
            bool result = quantity.Compare(quantityOne, quantityTwo);
            Assert.IsTrue(result);
        }

        [Test]
        public void givenThreeFeet_WhenComparedByOneYard_ShouldReturnTrue()
        {
            Quantity quantityOne = new Quantity(3, "FEET", "LENGTH");
            Quantity quantityTwo = new Quantity(1, "YARD", "LENGTH");
            bool result = quantity.Compare(quantityOne, quantityTwo);
            Assert.IsTrue(result);
        }

        [Test]
        public void givenOneFeet_WhenComparedByOneYard_ShouldReturnFalse()
        {
            Quantity quantityOne = new Quantity(1, "FEET", "LENGTH");
            Quantity quantityTwo = new Quantity(1, "YARD", "LENGTH");
            bool result = quantity.Compare(quantityOne, quantityTwo);
            Assert.IsFalse(result);
        }

        [Test]
        public void givenOneInch_WhenComparedByOneYard_ShouldReturnFalse()
        {
            Quantity quantityOne = new Quantity(1, "INCH", "LENGTH");
            Quantity quantityTwo = new Quantity(1, "YARD", "LENGTH");
            bool result = quantity.Compare(quantityOne, quantityTwo);
            Assert.IsFalse(result);
        }

        [Test]
        public void givenOneYard_WhenComparedByThirtySixInch_ShouldReturnTrue()
        {
            Quantity quantityOne = new Quantity(1, "YARD", "LENGTH");
            Quantity quantityTwo = new Quantity(36, "INCH", "LENGTH");
            bool result = quantity.Compare(quantityOne, quantityTwo);
            Assert.IsTrue(result);
        }

        [Test]
        public void givenThirtySixInch_WhenComparedByOneYard_ShouldReturnTrue()
        {
            Quantity quantityOne = new Quantity(36, "INCH", "LENGTH");
            Quantity quantityTwo = new Quantity(1, "YARD", "LENGTH");
            bool result = quantity.Compare(quantityOne, quantityTwo);
            Assert.IsTrue(result);
        }

        [Test]
        public void givenOneYard_WhenComparedByThreeFeet_ShouldReturnTrue()
        {
            Quantity quantityOne = new Quantity(1, "YARD", "LENGTH");
            Quantity quantityTwo = new Quantity(3, "FEET", "LENGTH");
            bool result = quantity.Compare(quantityOne, quantityTwo);
            Assert.IsTrue(result);
        }

        [Test]
        public void givenTwoInch_WhenComparedByFiveCentimetre_ShouldReturnTrue()
        {
            Quantity quantityOne = new Quantity(2, "INCH", "LENGTH");
            Quantity quantityTwo = new Quantity(5, "CENTIMETRE", "LENGTH");
            bool result = quantity.Compare(quantityOne, quantityTwo);
            Assert.IsTrue(result);
        }

        [Test]
        public void givenTwoInchPlusTwoInch_WhenComparedByFourInch_ShouldReturnTrue()
        {
            Quantity quantityOne = new Quantity(2, "INCH", "LENGTH");
            Quantity quantityTwo = new Quantity(2, "INCH", "LENGTH");
            Quantity quantityThree = new Quantity(4, "INCH", "LENGTH");
            bool result = quantity.Compare(quantityOne, quantityTwo,quantityThree);
            Assert.IsTrue(result);
        }

        [Test]
        public void givenOneFeetPlusTwoInch_WhenComparedByFourteenInch_ShouldReturnTrue()
        {
            Quantity quantityOne = new Quantity(1, "FEET", "LENGTH");
            Quantity quantityTwo = new Quantity(2, "INCH", "LENGTH");
            Quantity quantityThree = new Quantity(14, "INCH", "LENGTH");
            bool result = quantity.Compare(quantityOne, quantityTwo, quantityThree);
            Assert.IsTrue(result);
        }

        [Test]
        public void givenOneFeetPlusOneFeet_WhenComparedByTwentyFourInch_ShouldReturnTrue()
        {
            Quantity quantityOne = new Quantity(1, "FEET", "LENGTH");
            Quantity quantityTwo = new Quantity(1, "FEET", "LENGTH");
            Quantity quantityThree = new Quantity(24, "INCH", "LENGTH");
            bool result = quantity.Compare(quantityOne, quantityTwo, quantityThree);
            Assert.IsTrue(result);
        }

        [Test]
        public void givenOneInchPlusTwopointFive_WhenComparedByThreeInch_ShouldReturnTrue()
        {
            Quantity quantityOne = new Quantity(2, "INCH", "LENGTH");
            Quantity quantityTwo = new Quantity(2.5, "CENTIMETRE", "LENGTH");
            Quantity quantityThree = new Quantity(3, "INCH", "LENGTH");
            bool result = quantity.Compare(quantityOne, quantityTwo, quantityThree);
            Assert.IsTrue(result);
        }

        [Test]
        public void givenOneGallon_WhenComparedByFourLitre_ShouldReturnTrue()
        {
            Quantity quantityOne = new Quantity(1, "GALLON", "VOLUME");
            Quantity quantityTwo = new Quantity(3.78, "LITRE", "VOLUME");
            bool result = quantity.Compare(quantityOne, quantityTwo);
            Assert.IsTrue(result);
        }
    }
}