using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuantityMeasurementSln
{
    public class Quantity
    {
        public int value;

        public enum UnitType { FEET, INCH };

        private UnitType type;
        public Quantity()
        { }

        public Quantity(int value, UnitType type)
        {
            this.value = value;
            this.type = type;
        }

        public bool Compare(Quantity q1, Quantity q2)
        {
            if (!q1.type.Equals(q2.type))
                return false;
            return q1.value == q2.value;
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
