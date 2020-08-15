// <copyright file="Quantity.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace QuantityMeasurementSln
{
    /// <summary>
    /// Quantity Class.
    /// </summary>
    public class Quantity
    {
        /// <summary>
        /// Object value.
        /// </summary>
        public double Value;

        /// <summary>
        /// Object unit like feet gram.
        /// </summary>
        public string Unit;

        /// <summary>
        /// Object basic unit like length weight.
        /// </summary>
        public string BaseUnit;

        private readonly ConversionUnit conversionUnit;

        /// <summary>
        /// Initializes a new instance of the <see cref="Quantity"/> class.
        /// </summary>
        public Quantity()
        {
            this.conversionUnit = new ConversionUnit();
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Quantity"/> class.
        /// Constructor to create object.
        /// </summary>
        /// <param name="value">Value of the object.</param>
        /// <param name="unit">unit of the object.</param>
        /// <param name="baseUnit">Basic unit object belongs to.</param>
        public Quantity(double value, string unit, string baseUnit)
        {
            this.Value = value;
            this.Unit = unit;
            this.BaseUnit = baseUnit;
        }

        /// <summary>
        /// Compare two units.
        /// </summary>
        /// <param name="quantity">Quantities to be compared.</param>
        /// <returns>boolean true or false.</returns>
        public bool Compare(params Quantity[] quantity)
        {
            if (quantity.Length == 3)
            {
                return this.AddCompare(quantity);
            }

            if (!quantity[0].BaseUnit.Equals(quantity[1].BaseUnit))
            {
                return false;
            }

            return this.conversionUnit.ConvertUnit(quantity[0]).Equals(this.conversionUnit.ConvertUnit(quantity[1]));
        }

        /// <summary>
        /// Equals method.
        /// </summary>
        /// <param name="obj">Object of Quantity.</param>
        /// <returns>boolean true or false.</returns>
        public override bool Equals(object obj)
        {
            Quantity measurement = obj as Quantity;

            if (obj == this)
            {
                return true;
            }

            if (obj == null || obj.GetType() != this.GetType())
            {
                return true;
            }

            if (obj as Quantity != null && this.Value == measurement.Value)
            {
                return true;
            }

            if (obj != this)
            {
                return false;
            }

            return false;
        }

        /// <summary>
        /// Get Hash Code.
        /// </summary>
        /// <returns>Hash code.</returns>
        public override int GetHashCode()
        {
            return 0;
        }

        /// <summary>
        /// Add Compare method add two units and compare with third unit.
        /// </summary>
        /// <param name="quantity">Quantities which are compared.</param>
        /// <returns>boolean true or false.</returns>
        private bool AddCompare(params Quantity[] quantity)
        {
            if (!quantity[0].BaseUnit.Equals(quantity[1].BaseUnit) && !quantity[0].BaseUnit.Equals(quantity[2].BaseUnit))
            {
                return false;
            }

            Quantity quantityOne = this.conversionUnit.AddUnit(quantity[0], quantity[1]);
            Quantity quantityTwo = quantity[2];
            return this.conversionUnit.ConvertUnit(quantityOne).Equals(this.conversionUnit.ConvertUnit(quantityTwo));
        }
    }
}
