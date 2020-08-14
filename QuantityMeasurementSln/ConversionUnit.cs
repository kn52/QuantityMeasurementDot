using System;
namespace QuantityMeasurementSln
{
    public class ConversionUnit
    {
        //public ConversionUnit() { }
        public double ConvertUnit(Quantity quantity)
        {
            return quantity.value * this.ConversionFactor(quantity.unit);
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
            }
        }
    }
}
