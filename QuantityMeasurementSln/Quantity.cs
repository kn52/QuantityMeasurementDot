// <copyright file="Quantity.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace QuantityMeasurementSln
{
    using QuantityMeasurementSln.Conversion;
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// Quantity Class.
    /// </summary>
    public class Quantity
    {
        private const string V = "LENGTH";

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

        private IConvertUnit convertUnit;

        /// <summary>
        /// Initializes a new instance of the <see cref="Quantity"/> class.
        /// </summary>
        public Quantity()
        {
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

            this.SetConversionUnitClassObject(quantity[0].BaseUnit);
            return this.convertUnit.ConvertUnit(quantity[0]).Equals(this.convertUnit.ConvertUnit(quantity[1]));
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
                return this.CompareSubUnit(measurement);
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

            this.SetConversionUnitClassObject(quantity[0].BaseUnit);
            Quantity quantityOne = this.convertUnit.AddUnit(quantity[0], quantity[1]);
            Quantity quantityTwo = quantity[2];
            return this.convertUnit.ConvertUnit(quantityOne).Equals(this.convertUnit.ConvertUnit(quantityTwo));
        }

        /// <summary>
        /// Set Class Object.
        /// </summary>
        /// <param name="baseUnit">Base Unit.</param>
        private void SetConversionUnitClassObject(string baseUnit)
        {
            switch (baseUnit)
            {
                case "LENGTH":
                    this.SetConvertUnit(new Length());
                    break;

                case "VOLUME":
                    this.SetConvertUnit(new Volume());
                    break;

                case "WEIGHT":
                    this.SetConvertUnit(new Weight());
                    break;

                case "TEMPERATURE":
                    this.SetConvertUnit(new Temperature());
                    break;
            }
        }

        /// <summary>
        /// Set Convert Unit Class Object.
        /// </summary>
        /// <param name="convertUnit">Class Object.</param>
        private void SetConvertUnit(IConvertUnit convertUnit)
        {
            this.convertUnit = convertUnit;
        }

        /// <summary>
        /// Check sub unit conversion value.
        /// </summary>
        /// <param name="quantity">Quantity Object.</param>
        /// <returns>Boolean true or false.</returns>
        private bool CompareSubUnit(Quantity quantity)
        {
            this.SetConversionUnitClassObject(quantity.BaseUnit);
            double valueOne = this.convertUnit.GetUnit()[quantity.Unit];
            this.SetConversionUnitClassObject(this.BaseUnit);
            double valueTwo = this.convertUnit.GetUnit()[this.Unit];
            if (valueOne > 0 && valueTwo > 0)
            {
                return true;
            }

            return false;
        }
    }
}
