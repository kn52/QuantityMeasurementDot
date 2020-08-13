using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuantityMeasurementSln
{
    public class Inch
    {
        private int value;

        public Inch()
        {
        }

        public Inch(int value)
        {
            this.value = value;
        }

        public override bool Equals(object obj)
        {
            var inch = obj as Inch;
            if (obj == this)
                return true;

            if (obj == null || obj.GetType() != this.GetType())
                return true;

            if (inch != null && value == inch.value)
                return true;

            if (obj != this)
                return false;

            return false;
        }
    }
}
