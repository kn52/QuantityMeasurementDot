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

        /// <summary>
        /// Zero feet compared with Zero feet. 
        /// </summary>
        [Test]
        public void GivenZeroFeet_WhenComparedWithAnotherZeroFeet_ShouldReturnTrue()
        {
            Quantity feetOne = new Quantity(0, "FEET", "LENGTH");
            Quantity feetTwo = new Quantity(0, "FEET", "LENGTH");
            bool result = feetOne.Equals(feetTwo);
            Assert.IsTrue(result);
        }

        /// <summary>
        /// Zero feet compared with null.
        /// </summary>
        [Test]
        public void GivenZeroFeet_WhenComparedWithNull_ShouldReturnTrue()
        {
            Quantity feetOne = new Quantity(0, "FEET", "LENGTH");
            Quantity feetTwo = null;
            bool result = feetOne.Equals(feetTwo);
            Assert.IsTrue(result);
        }

        /// <summary>
        /// Two feet variables compared by reference.
        /// </summary>
        [Test]
        public void GivenZeroFeet_WhenComparedByReference_ShouldReturnFalse()
        {
            Quantity feetOne = new Quantity(0, "FEET", "LENGTH");
            Quantity feetTwo = new Quantity(12, "FEET", "LENGTH");
            bool result = feetOne.Equals(feetTwo);
            Assert.IsFalse(result);
        }

        /// <summary>
        /// Two feet variables compared by same reference.
        /// </summary>
        [Test]
        public void GivenZeroFeet_WhenComparedBySameReference_ShouldReturnTrue()
        {
            Quantity feetOne = new Quantity(0, "FEET", "LENGTH");
            Quantity feetTwo = feetOne;
            bool result = feetOne.Equals(feetTwo);
            Assert.IsTrue(result);
        }

        /// <summary>
        /// Two feet variables compared by type.
        /// </summary>
        [Test]
        public void GivenZeroFeet_WhenComparedByType_ShouldReturnTrue()
        {
            Quantity feetOne = new Quantity(0, "FEET", "LENGTH");
            Quantity feetTwo = new Quantity();
            bool result = feetOne.Equals(feetTwo);
            Assert.IsTrue(result);
        }

        /// <summary>
        /// Two feet variables compared by value.
        /// </summary>
        [Test]
        public void GivenZeroFeet_WhenComparedByValue_ShouldReturnTrue()
        {
            Quantity feetOne = new Quantity(12, "FEET", "LENGTH");
            Quantity feetTwo = new Quantity(12, "FEET", "LENGTH");
            bool result = feetOne.Equals(feetTwo);
            Assert.IsTrue(result);
        }

        /// <summary>
        /// Zero feet compared with negative value.
        /// </summary>
        [Test]
        public void GivenZeroFeet_WhenComparedByNegativeValue_ShouldReturnFalse()
        {
            Quantity quantityOne = new Quantity(-5, "FEET", "LENGTH");
            Quantity quantityTwo = new Quantity(12, "FEET", "LENGTH");
            bool result = quantityOne.Equals(quantityTwo);
            Assert.IsFalse(result);
        }

        /// <summary>
        /// Zero Inch compared with Zero Inch. 
        /// </summary>
        [Test]
        public void GivenZeroInch_WhenComparedWithAnotherZeroInch_ShouldReturnTrue()
        {
            Quantity inchOne = new Quantity(0, "INCH", "LENGTH");
            Quantity inchTwo = new Quantity(0, "INCH", "LENGTH");
            bool result = inchOne.Equals(inchTwo);
            Assert.IsTrue(result);
        }

        /// <summary>
        /// Zero Inch compared with null.
        /// </summary>
        [Test]
        public void GivenZeroInch_WhenComparedWithNullValue_ShouldReturnTrue()
        {
            Quantity inchOne = new Quantity(0, "INCH", "LENGTH");
            Quantity inchTwo = null;
            bool result = inchOne.Equals(inchTwo);
            Assert.IsTrue(result);
        }

        /// <summary>
        /// Two Inch variables compared by reference.
        /// </summary>
        [Test]
        public void GivenZeroInch_WhenComparedByReference_ShouldReturnFalse()
        {
            Quantity inchOne = new Quantity(0, "INCH", "LENGTH");
            Quantity inchTwo = new Quantity(12, "INCH", "LENGTH");
            bool result = inchOne.Equals(inchTwo);
            Assert.IsFalse(result);
        }

        /// <summary>
        /// Two Inch variables compared by same reference.
        /// </summary>
        [Test]
        public void GivenZeroInch_WhenComparedBySameReference_ShouldReturnTrue()
        {
            Quantity inchOne = new Quantity(0, "INCH", "LENGTH");
            Quantity inchTwo = inchOne;
            bool result = inchOne.Equals(inchTwo);
            Assert.IsTrue(result);
        }

        /// <summary>
        /// Two Inch variables compared by type.
        /// </summary>
        [Test]
        public void GivenZeroInch_WhenComparedByType_ShouldReturnTrue()
        {
            Quantity inchOne = new Quantity(0, "INCH", "LENGTH");
            Quantity inchTwo = new Quantity();
            bool result = inchOne.Equals(inchTwo);
            Assert.IsTrue(result);
        }

        /// <summary>
        /// Two Inch variables compared by value.
        /// </summary>
        [Test]
        public void GivenZeroInch_WhenComparedByValue_ShouldReturnTrue()
        {
            Quantity inchOne = new Quantity(12, "INCH", "LENGTH");
            Quantity inchTwo = new Quantity(12, "INCH", "LENGTH");
            bool result = inchOne.Equals(inchTwo);
            Assert.IsTrue(result);
        }

        /// <summary>
        /// Zero Inch compared by negative.
        /// </summary>
        [Test]
        public void GivenZeroInch_WhenComparedByNegativeValue_ShouldReturnFalse()
        {
            Quantity quantityOne = new Quantity(-12, "INCH", "LENGTH");
            Quantity quantityTwo = new Quantity(12, "INCH", "LENGTH");
            bool result = quantityOne.Equals(quantityTwo);
            Assert.IsFalse(result);
        }

        /// <summary>
        /// Zero Feet compared with Zero Inch
        /// </summary>

        [Test]
        public void GivenZeroFeet_WhenComparedByZeroInch_ShouldReturnTrue()
        {
            Quantity quantityOne= new Quantity(0, "FEET", "LENGTH");
            Quantity quantityTwo = new Quantity(0, "INCH", "LENGTH");
            bool result = quantity.Compare(quantityOne,quantityTwo);
            Assert.IsTrue(result);
        }

        /// <summary>
        /// One Feet compared with One Inch
        /// </summary>
        [Test]
        public void GivenOneFeet_WhenComparedByOneInch_ShouldReturnFalse()
        {
            Quantity quantityOne = new Quantity(1, "FEET", "LENGTH");
            Quantity quantityTwo = new Quantity(1, "INCH", "LENGTH");
            bool result = quantity.Compare(quantityOne, quantityTwo);
            Assert.IsFalse(result);
        }

        /// <summary>
        /// One Inch compared with One Feet
        /// </summary>
        [Test]
        public void GivenOneInch_WhenComparedByOneFeet_ShouldReturnFalse()
        {
            Quantity quantityOne = new Quantity(1, "INCH", "LENGTH");
            Quantity quantityTwo = new Quantity(1, "FEET", "LENGTH");
            bool result = quantity.Compare(quantityOne, quantityTwo);
            Assert.IsFalse(result);
        }

        /// <summary>
        /// One Feet compared with Twelve Inch
        /// </summary>
        [Test]
        public void GivenOneFeet_WhenComparedByTwelveInch_ShouldReturnTrue()
        {
            Quantity quantityOne = new Quantity(1, "FEET", "LENGTH");
            Quantity quantityTwo = new Quantity(12, "INCH", "LENGTH");
            bool result = quantity.Compare(quantityOne, quantityTwo);
            Assert.IsTrue(result);
        }

        /// <summary>
        /// Twelve Inch compared with One Feet
        /// </summary>
        [Test]
        public void GivenTwelveInch_WhenComparedByOneFeet_ShouldReturnTrue()
        {
            Quantity quantityOne = new Quantity(12, "INCH", "LENGTH");
            Quantity quantityTwo = new Quantity(1, "FEET", "LENGTH");
            bool result = quantity.Compare(quantityOne, quantityTwo);
            Assert.IsTrue(result);
        }

        /// <summary>
        /// Three Feet compared with One Yard
        /// </summary>
        [Test]
        public void GivenThreeFeet_WhenComparedByOneYard_ShouldReturnTrue()
        {
            Quantity quantityOne = new Quantity(3, "FEET", "LENGTH");
            Quantity quantityTwo = new Quantity(1, "YARD", "LENGTH");
            bool result = quantity.Compare(quantityOne, quantityTwo);
            Assert.IsTrue(result);
        }

        /// <summary>
        /// One Feet compared with One Yard
        /// </summary>
        [Test]
        public void GivenOneFeet_WhenComparedByOneYard_ShouldReturnFalse()
        {
            Quantity quantityOne = new Quantity(1, "FEET", "LENGTH");
            Quantity quantityTwo = new Quantity(1, "YARD", "LENGTH");
            bool result = quantity.Compare(quantityOne, quantityTwo);
            Assert.IsFalse(result);
        }

        /// <summary>
        /// One Inch compared with One Yard
        /// </summary>
        [Test]
        public void GivenOneInch_WhenComparedByOneYard_ShouldReturnFalse()
        {
            Quantity quantityOne = new Quantity(1, "INCH", "LENGTH");
            Quantity quantityTwo = new Quantity(1, "YARD", "LENGTH");
            bool result = quantity.Compare(quantityOne, quantityTwo);
            Assert.IsFalse(result);
        }

        /// <summary>
        /// One Yard compared with Thirty Six Inch
        /// </summary>
        [Test]
        public void GivenOneYard_WhenComparedByThirtySixInch_ShouldReturnTrue()
        {
            Quantity quantityOne = new Quantity(1, "YARD", "LENGTH");
            Quantity quantityTwo = new Quantity(36, "INCH", "LENGTH");
            bool result = quantity.Compare(quantityOne, quantityTwo);
            Assert.IsTrue(result);
        }

        /// <summary>
        /// Thirty Six Inch compared with One Yard
        /// </summary>
        [Test]
        public void GivenThirtySixInch_WhenComparedByOneYard_ShouldReturnTrue()
        {
            Quantity quantityOne = new Quantity(36, "INCH", "LENGTH");
            Quantity quantityTwo = new Quantity(1, "YARD", "LENGTH");
            bool result = quantity.Compare(quantityOne, quantityTwo);
            Assert.IsTrue(result);
        }

        /// <summary>
        /// One Yard compared with Three Feet
        /// </summary>
        [Test]
        public void GivenOneYard_WhenComparedByThreeFeet_ShouldReturnTrue()
        {
            Quantity quantityOne = new Quantity(1, "YARD", "LENGTH");
            Quantity quantityTwo = new Quantity(3, "FEET", "LENGTH");
            bool result = quantity.Compare(quantityOne, quantityTwo);
            Assert.IsTrue(result);
        }

        /// <summary>
        /// Two Inch compared with Five Centimetre
        /// </summary>
        [Test]
        public void GivenTwoInch_WhenComparedByFiveCentimetre_ShouldReturnTrue()
        {
            Quantity quantityOne = new Quantity(2, "INCH", "LENGTH");
            Quantity quantityTwo = new Quantity(5, "CENTIMETRE", "LENGTH");
            bool result = quantity.Compare(quantityOne, quantityTwo);
            Assert.IsTrue(result);
        }

        /// <summary>
        /// Two Inch plus Two Inch compared with Four Inch
        /// </summary>
        [Test]
        public void GivenTwoInchPlusTwoInch_WhenComparedByFourInch_ShouldReturnTrue()
        {
            Quantity quantityOne = new Quantity(2, "INCH", "LENGTH");
            Quantity quantityTwo = new Quantity(2, "INCH", "LENGTH");
            Quantity quantityThree = new Quantity(4, "INCH", "LENGTH");
            bool result = quantity.Compare(quantityOne, quantityTwo,quantityThree);
            Assert.IsTrue(result);
        }

        /// <summary>
        /// One Feet plus Two Inch compared with Fourteen Inch
        /// </summary>
        [Test]
        public void GivenOneFeetPlusTwoInch_WhenComparedByFourteenInch_ShouldReturnTrue()
        {
            Quantity quantityOne = new Quantity(1, "FEET", "LENGTH");
            Quantity quantityTwo = new Quantity(2, "INCH", "LENGTH");
            Quantity quantityThree = new Quantity(14, "INCH", "LENGTH");
            bool result = quantity.Compare(quantityOne, quantityTwo, quantityThree);
            Assert.IsTrue(result);
        }

        /// <summary>
        /// One Feet plus One Feet compared with Twenty Four Inch
        /// </summary>
        [Test]
        public void GivenOneFeetPlusOneFeet_WhenComparedByTwentyFourInch_ShouldReturnTrue()
        {
            Quantity quantityOne = new Quantity(1, "FEET", "LENGTH");
            Quantity quantityTwo = new Quantity(1, "FEET", "LENGTH");
            Quantity quantityThree = new Quantity(24, "INCH", "LENGTH");
            bool result = quantity.Compare(quantityOne, quantityTwo, quantityThree);
            Assert.IsTrue(result);
        }

        /// <summary>
        /// One Inch plus Two point Five Centimetre compared with Three Inch
        /// </summary>
        [Test]
        public void GivenOneInchPlusTwopointFiveCentimetre_WhenComparedByThreeInch_ShouldReturnTrue()
        {
            Quantity quantityOne = new Quantity(2, "INCH", "LENGTH");
            Quantity quantityTwo = new Quantity(2.5, "CENTIMETRE", "LENGTH");
            Quantity quantityThree = new Quantity(3, "INCH", "LENGTH");
            bool result = quantity.Compare(quantityOne, quantityTwo, quantityThree);
            Assert.IsTrue(result);
        }

        /// <summary>
        /// One Gallon compared with Four Litre
        /// </summary>
        [Test]
        public void GivenOneGallon_WhenComparedByFourLitre_ShouldReturnTrue()
        {
            Quantity quantityOne = new Quantity(1, "GALLON", "VOLUME");
            Quantity quantityTwo = new Quantity(3.78, "LITRE", "VOLUME");
            bool result = quantity.Compare(quantityOne, quantityTwo);
            Assert.IsTrue(result);
        }

        /// <summary>
        /// One Litre compared with Thousand Millilitre
        /// </summary>
        [Test]
        public void GivenOneLitre_WhenComparedByThousandMilliLitre_ShouldReturnTrue()
        {
            Quantity quantityOne = new Quantity(1, "LITRE", "VOLUME");
            Quantity quantityTwo = new Quantity(1000, "MILLILITRE", "VOLUME");
            bool result = quantity.Compare(quantityOne, quantityTwo);
            Assert.IsTrue(result);
        }

        /// <summary>
        /// One Gallon plus Four Litre compared with Eight Litre
        /// </summary>
        [Test]
        public void GivenOneGallonPlusFourLitre_WhenComparedByEightLitre_ShouldReturnTrue()
        {
            Quantity quantityOne = new Quantity(1, "GALLON", "VOLUME");
            Quantity quantityTwo = new Quantity(3.78, "LITRE", "VOLUME");
            Quantity quantityThree = new Quantity(7.57, "LITRE", "VOLUME");
            bool result = quantity.Compare(quantityOne, quantityTwo, quantityThree);
            Assert.IsTrue(result);
        }

        /// <summary>
        /// One Litre plus Thousand Millilitre compared with Two Litre
        /// </summary>
        [Test]
        public void GivenOneLitrePlusThousandMilliLitre_WhenComparedByTwoLitre_ShouldReturnTrue()
        {
            Quantity quantityOne = new Quantity(1, "LITRE", "VOLUME");
            Quantity quantityTwo = new Quantity(1000, "MILLILITRE", "VOLUME");
            Quantity quantityThree = new Quantity(2, "LITRE", "VOLUME");
            bool result = quantity.Compare(quantityOne, quantityTwo, quantityThree);
            Assert.IsTrue(result);
        }

        /// <summary>
        /// One Kilogram compared with Thousand Gram
        /// </summary>
        [Test]
        public void givenOneKilogramWhenComparedByThousandGram_ShouldReturnTrue()
        {
            Quantity quantityOne = new Quantity(1, "KILOGRAM", "WEIGHT");
            Quantity quantityTwo = new Quantity(1000, "GRAM", "WEIGHT");
            bool result = quantity.Compare(quantityOne, quantityTwo);
            Assert.IsTrue(result);
        }

        /// <summary>
        /// One Tonne compared with Thousand Kilogram
        /// </summary>
        [Test]
        public void givenOneTonneWhenComparedByThousandKilogram_ShouldReturnTrue()
        {
            Quantity quantityOne = new Quantity(1, "TONNE", "WEIGHT");
            Quantity quantityTwo = new Quantity(1000, "KILOGRAM", "WEIGHT");
            bool result = quantity.Compare(quantityOne, quantityTwo);
            Assert.IsTrue(result);
        }
    }
}