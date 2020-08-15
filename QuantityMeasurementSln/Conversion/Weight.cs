// <copyright file="Weight.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace QuantityMeasurementSln.Conversion
{
    using System;

    /// <summary>
    /// Temperature conversion class.
    /// </summary>
    public class Weight : IConvertUnit
    {
        /// <summary>
        /// Convert Units into lowest unit.
        /// </summary>
        /// <param name="quantity">Quantity is going to be converted.</param>
        /// <returns>Converted value.</returns>
        public double ConvertUnit(Quantity quantity)
        {
            return Math.Round(quantity.Value * this.ConversionFactor(quantity.Unit));
        }

        /// <summary>
        /// Add function to add two units.
        /// </summary>
        /// <param name="quanityOne">Quantity One.</param>
        /// <param name="quantityTwo">Quantity Two.</param>
        /// <returns>Addition of two  quantity.</returns>
        public Quantity AddUnit(Quantity quanityOne, Quantity quantityTwo)
        {
            quanityOne.Value = Math.Round(this.ConvertUnit(quanityOne) + this.ConvertUnit(quantityTwo));
            quanityOne.Unit = "KILOGRAM";
            return quanityOne;
        }

        /// <summary>
        /// Converversion Factor.
        /// </summary>
        /// <param name="unit">Unit of variable to be converted.</param>
        /// <returns>Conversion value to convert the unit.</returns>
        private double ConversionFactor(string unit)
        {
            switch (unit)
            {
                case "TONNE":
                    return 1000.0;
                case "KILOGRAM":
                    return 1.0;
                case "GRAM":
                    return 1 / 1000.0;
                default:
                    return 0.0;
            }
        }
    }
}
