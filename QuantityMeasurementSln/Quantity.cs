using System;

namespace QuantityMeasurementSln
{
    public class Quantity
    {
        public double value;

        public string unit;

        public string baseUnit;

        private ConversionUnit conversionUnit;
        public Quantity()
        {
            conversionUnit = new ConversionUnit();
        }

        public Quantity(double value, string unit,string baseUnit)
        {
            this.value = value;
            this.unit = unit;
            this.baseUnit = baseUnit;
        }

        private bool AddCompare(params Quantity[] quantity)
        {
            if (!quantity[0].baseUnit.Equals(quantity[1].baseUnit) && !quantity[0].baseUnit.Equals(quantity[2].baseUnit))
                return false;
            Quantity quantityOne = conversionUnit.AddUnit(quantity[0],quantity[1]);
            Quantity quantityTwo = quantity[2];
            return conversionUnit.ConvertUnit(quantityOne).Equals(conversionUnit.ConvertUnit(quantityTwo));
        }

        public bool Compare(params Quantity[] quantity)
        {
            if (quantity.Length == 3)
                return this.AddCompare(quantity);

            if (!quantity[0].baseUnit.Equals(quantity[1].baseUnit))
                return false;

            return conversionUnit.ConvertUnit(quantity[0]).Equals(conversionUnit.ConvertUnit(quantity[1]));
        }

        public override bool Equals(object obj)
        {
            Quantity measurement = obj as Quantity;

            if (obj == this)
                return true;

            if (obj == null || obj.GetType() != this.GetType())
                return true;

            if (obj as Quantity != null && value == measurement.value)
                return true;

            if (obj != this)
                return false;

            return false;
        }
    }
}
