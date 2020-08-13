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
            if (inch != null && value == inch.value)
                return true;

            return false;
        }
    }
}
