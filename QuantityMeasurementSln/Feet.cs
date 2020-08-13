namespace QuantityMeasurementSln
{
    public class Feet
    {
        private int value;

        public Feet()
        {
        }

        public Feet(int value)
        {
            this.value = value;
        }

        public override bool Equals(object obj)
        {
            var feet = obj as Feet;

            if (obj == this)
                return true;

            if (obj == null || obj.GetType() != this.GetType())
                return true;

            if (feet != null && value == feet.value)
                return true;

            if (obj != this)
                return false;

            return false;
        }
    }
}
