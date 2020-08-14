using System;
namespace QuantityMeasurementSln
{
    public class ConversionUnit
    {
        public double ConvertUnit(double value,string unit)
        {
            return value * this.ConversionFactor(unit);
        }

        public double ConversionFactor (string unit)
        {
            switch (unit)
            {
                case "FEET":
                    return 12.0;
                case "INCH":
                    return 1.0;
                default:
                    return 0.0;
                    break;
            }
            return 0.0;
        }
    }
}
