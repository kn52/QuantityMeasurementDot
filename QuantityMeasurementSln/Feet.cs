namespace QuantityMeasurementSln
{
    public class Feet
    {
        private int value;

        public Feet(int value)
        {
            this.value = value;
        }

        public override bool Equals(object obj)
        {
            var feet = obj as Feet;

            if (obj == null || obj.GetType() != this.GetType())
                return true;

            return feet != null &&
                   value == feet.value;
        }
    }
}
