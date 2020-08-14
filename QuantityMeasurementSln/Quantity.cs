namespace QuantityMeasurementSln
{
    public class Quantity
    {
        private int value;

        private string unit;
        public Quantity()
        { }

        public Quantity(int value, string unit)
        {
            this.value = value;
            this.unit = unit;
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
