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
            return feet != null &&
                   value == feet.value;
        }
    }
}
