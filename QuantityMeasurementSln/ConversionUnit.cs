// <copyright file="ConversionUnit.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace QuantityMeasurementSln
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// Conversion Unit class.
    /// </summary>
    public class ConversionUnit
    {
        private readonly Dictionary<string, string> unit = new Dictionary<string, string>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ConversionUnit"/> class.
        /// Constructor to initialise dictionary.
        /// </summary>
        public ConversionUnit()
        {
            this.unit.Add("LENGTH", "INCH");
            this.unit.Add("VOLUME", "LITRE");
            this.unit.Add("WEIGHT", "KILOGRAM");
        }

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
            quanityOne.Unit = this.unit[quanityOne.BaseUnit];
            return quanityOne;
        }

        /// <summary>
        /// Converversion Factor.
        /// </summary>
        /// <param name="unit">Unit of variable to be converted.</param>
        /// <returns>Conversion value to convert the unit.</returns>
        public double ConversionFactor(string unit)
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
                case "GALLON":
                    return 3.78;
                case "LITRE":
                    return 1.0;
                case "MILLILITRE":
                    return 1 / 1000.0;
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
