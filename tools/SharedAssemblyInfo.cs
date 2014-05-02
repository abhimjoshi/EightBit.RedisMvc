// --------------------------------------------------------------------------------------------------------------------
// <copyright file="SharedAssemblyInfo.cs" company="Abhi Joshi">
//   Copyright By Abhi Joshi
// </copyright>
// <summary>
//   SharedAssemblyInfo.cs
// </summary>
// --------------------------------------------------------------------------------------------------------------------

using System;
using System.Reflection;
using System.Runtime.InteropServices;

[assembly: AssemblyCompany("Abhi Inc")]
[assembly: AssemblyCopyright("Copyright © 2014 by Abhi Joshi")]
[assembly: AssemblyTrademark("Copyright © 2014 by Abhi Joshi")]
[assembly: AssemblyCulture("")]

#if DEBUG
[assembly: AssemblyConfiguration("Debug")]
#else
[assembly: AssemblyConfiguration("Release")]
#endif

[assembly: AssemblyVersion("1.0.*")]
[assembly: ComVisible(false)]
[assembly: CLSCompliant(false)]