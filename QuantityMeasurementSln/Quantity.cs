using System;

namespace QuantityMeasurementSln
{
    public class Quantity
    {
        public double value;

        public string unit;

        private ConversionUnit conversionUnit;
        public Quantity()
        {
            conversionUnit = new ConversionUnit();
        }

        public Quantity(int value, string unit)
        {
            this.value = value;
            this.unit = unit;
        }

        public bool Compare(params Quantity[] quantity)
        {
            Quantity quantityOne = null;
            Quantity quantityTwo = null;
            if (quantity.Length == 3)
            {
                quantityOne = conversionUnit.AddUnit(quantity[0], quantity[1]);
                quantityTwo = quantity[2];
            }

            if (quantity.Length == 2)
            {
                quantityOne = quantity[0];
                quantityTwo = quantity[1];
            }

            return conversionUnit.ConvertUnit(quantityOne).Equals(conversionUnit.ConvertUnit(quantityTwo));
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
