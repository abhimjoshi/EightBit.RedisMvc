// --------------------------------------------------------------------------------------------------------------------
// <copyright file="FilterConfig.cs" company="Abhi Joshi">
//   Copyright By Abhi Joshi
// </copyright>
// <summary>
//   The filter config.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

// ReSharper disable once CheckNamespace
namespace EightBit.RedisMvc.Web
{
    using System.Web.Mvc;

    /// <summary>
    /// The filter config.
    /// </summary>
    public static class FilterConfig
    {
        /// <summary>
        /// The register global filters.
        /// </summary>
        /// <param name="filters">
        /// The filters.
        /// </param>
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
