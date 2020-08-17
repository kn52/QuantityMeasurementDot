// <copyright file="Length.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace QuantityMeasurementSln.Conversion
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// Lenght conversion class.
    /// </summary>
    public class Length : IConvertUnit
    {
        /// <summary>
        /// Unit.
        /// </summary>
        private readonly Dictionary<string, double> unit = new Dictionary<string, double>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Length"/> class.
        /// </summary>
        public Length()
        {
            this.unit.Add("YARD", 36.0);
            this.unit.Add("FEET", 12.0);
            this.unit.Add("INCH", 1.0);
            this.unit.Add("CENTIMETRE", 1 / 2.54);
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
            quanityOne.Unit = "INCH";
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
