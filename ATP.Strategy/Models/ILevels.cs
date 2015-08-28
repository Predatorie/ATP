// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ILevels.cs" company="Mick George @Osoy">
//   Copyright (c) 2015 Mick George aphextwin@seidr.net
// </copyright>
// <summary>
//   Defines the ILevels type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace ATP.Strategy.Models
{
    using System.Collections.Generic;

    /// <summary>The Levels interface.</summary>
    public interface ILevels
    {
        /// <summary>Gets or sets the levels.</summary>
        List<string> List { get; set; }

        /// <summary>Gets or sets the name.</summary>
        string Name { get; set; }
    }
}