// <copyright file="Volume.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace QuantityMeasurementSln.Conversion
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// Volume conversion class.
    /// </summary>
    public class Volume : IConvertUnit
    {
        /// <summary>
        /// Unit.
        /// </summary>
        private readonly Dictionary<string, double> unit = new Dictionary<string, double>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Volume"/> class.
        /// </summary>
        public Volume()
        {
            this.unit.Add("GALLON", 3.78);
            this.unit.Add("LITRE", 1.0);
            this.unit.Add("MILLILITRE", 1 / 1000.0);
        }

        /// <summary>
        /// Convert Units into lowest unit.
        /// </summary>
        /// <param name="quantity">Quantity is going to be converted.</param>
        /// <returns>Converted value.</returns>
        public double ConvertUnit(Quantity quantity)
        {
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
            quanityOne.Unit = "LITRE";
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
