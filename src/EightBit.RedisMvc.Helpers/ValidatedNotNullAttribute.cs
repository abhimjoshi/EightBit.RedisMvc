// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ValidatedNotNullAttribute.cs" company="Abhi Joshi">
//   Copyright By Abhi Joshi
// </copyright>
// <summary>
//   The validated not null attribute.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace EightBit.RedisMvc.Helpers
{
    using System;

    /// <summary>
    /// The validated not null attribute.
    /// </summary>
    [AttributeUsage(AttributeTargets.Parameter)]
    internal sealed class ValidatedNotNullAttribute : Attribute
    {
    }
}