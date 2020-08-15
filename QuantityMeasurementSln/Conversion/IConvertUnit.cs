// <copyright file="IConvertUnit.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace QuantityMeasurementSln.Conversion
{
    /// <summary>
    /// Convert Unit Interface.
    /// </summary>
    public interface IConvertUnit
    {
        /// <summary>
        /// Converting one unit to another.
        /// </summary>
        /// <param name="quanity">Object whose value is to be converted.</param>
        /// <returns>Quantity Object</returns>
        double ConvertUnit(Quantity quanity);

        /// <summary>
        /// Add function to add two units.
        /// </summary>
        /// <param name="quanityOne">Quantity One.</param>
        /// <param name="quantityTwo">Quantity Two.</param>
        /// <returns>Addition of two  quantity.</returns>
        Quantity AddUnit(Quantity quanityOne, Quantity quantityTwo);
    }
}
