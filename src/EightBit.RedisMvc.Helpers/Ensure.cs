// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Ensure.cs" company="Abhi Joshi">
//   Copyright By Abhi Joshi
// </copyright>
// <summary>
//   Defines the Ensure type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace EightBit.RedisMvc.Helpers
{
    using System;

    /// <summary>
    /// The ensure.
    /// </summary>
    public static class Ensure
    {
        /// <summary>
        /// The argument not null.
        /// </summary>
        /// <param name="value">
        /// The value.
        /// </param>
        /// <param name="name">
        /// The name.
        /// </param>
        /// <exception cref="ArgumentNullException">
        /// The value is null.
        /// </exception>
        public static void ArgumentNotNull([ValidatedNotNull]object value, string name)
        {
            if (value != null)
            {
                return;
            }

            throw new ArgumentNullException(name);
        }

        /// <summary>
        /// The argument not null or empty string.
        /// </summary>
        /// <param name="value">
        /// The value.
        /// </param>
        /// <param name="name">
        /// The name.
        /// </param>
        /// <exception cref="ArgumentException">
        /// The value is null or empty.
        /// </exception>
        public static void ArgumentNotNullOrEmptyString([ValidatedNotNull]string value, string name)
        {
            if (!string.IsNullOrWhiteSpace(value))
            {
                return;
            }

            throw new ArgumentException("String cannot be null or empty.", name);
        }
    }
}
