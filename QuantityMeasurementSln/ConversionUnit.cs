using System;
using System.Collections.Generic;

namespace QuantityMeasurementSln
{
    public class ConversionUnit
    {
        Dictionary<string,string> unit = new Dictionary<string,string>();
        
        public ConversionUnit()
        {
            unit.Add("LENGTH", "INCH");
        }

        public double ConvertUnit(Quantity quantity)
        {
            return Math.Round(quantity.value * this.ConversionFactor(quantity.unit));
        }

        public Quantity AddUnit(Quantity quanityOne,Quantity quantityTwo)
        {
            quanityOne.value = Math.Round(this.ConvertUnit(quanityOne) + this.ConvertUnit(quantityTwo));
            quanityOne.unit = unit[quanityOne.baseUnit];
            return quanityOne;
        }

        public double ConversionFactor (string unit)
        {
            switch (unit)
            {
                case "YARD":
                    return 36.0;
                case "FEET":
                    return 12.0;
                case "INCH":
                    return 1.0;
                case "CENTIMETRE":
                    return 1 / 2.54;
                default:
                    return 0.0;
            }
        }
    }
}
