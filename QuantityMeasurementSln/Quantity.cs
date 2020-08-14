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

        public bool compare(Quantity quantityOne, Quantity quantityTwo)
        {
            if (!q1.unit.Equals(q2.unit))
                return false;
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
