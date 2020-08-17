// <copyright file="Temperature.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace QuantityMeasurementSln.Conversion
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// Temperature conversion class.
    /// </summary>
    public class Temperature : IConvertUnit
    {
        /// <summary>
        /// Unit.
        /// </summary>
        private readonly Dictionary<string, double> unit = new Dictionary<string, double>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Temperature"/> class.
        /// </summary>
        public Temperature()
        {
            this.unit.Add("FAHRENHEIT", 1 / 1.8);
            this.unit.Add("CELSIUS", 1.0);
        }

        /// <summary>
        /// Convert Units into lowest unit.
        /// </summary>
        /// <param name="quantity">Quantity is going to be converted.</param>
        /// <returns>Converted value.</returns>
        public double ConvertUnit(Quantity quantity)
        {
            if (quantity.Unit.Equals("FAHRENHEIT"))
            {
                return Math.Round((quantity.Value - 32) * this.unit[quantity.Unit]);
            }

            return Math.Round(quantity.Value * this.unit[quantity.Unit]);
        }

        /// <summary>
        /// Add function to add two units.
        /// </summary>
        /// <param name="quanityOne">Quantity One.</param>
        /// <param name="quantityTwo">Quantity Two.</param>
        /// <returns>Addition of two  quantity.</returns>
        public Quantity AddUnit(Quantity quanityOne, Quantity quantityTwo)
        {
            quanityOne.Value = this.ConvertUnit(quanityOne) + this.ConvertUnit(quantityTwo);
            quanityOne.Unit = "CELSIUS";
            return quanityOne;
        }

        /// <summary>
        /// Get Unit.
        /// </summary>
        /// <returns>Dictionary.</returns>
        public dynamic GetUnit()
        {
            return this.unit;
        }
    }
}
