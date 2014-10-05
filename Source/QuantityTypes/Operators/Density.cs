﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Density.cs" company="QuantityTypes">
//   Copyright (c) 2014 QuantityTypes contributors
// </copyright>
// <summary>
//   Provides operators related to volume.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace QuantityTypes
{
    /// <summary>
    ///     Provides operators related to volume.
    /// </summary>
    public partial struct Density
    {
        /// <summary>
        ///     Implements the operator *.
        /// </summary>
        /// <param name="x"> The density. </param>
        /// <param name="y"> The volume. </param>
        /// <returns> The result of the operator. </returns>
        public static Mass operator *(Density x, Volume y)
        {
            return new Mass(x.Value * y.Value);
        }
    }
}