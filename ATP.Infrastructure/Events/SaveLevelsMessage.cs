// --------------------------------------------------------------------------------------------------------------------
// <copyright file="SaveLevelsMessage.cs" company="Mick George @Osoy">
//   Copyright (c) 2015 Mick George aphextwin@seidr.net
// </copyright>
// <summary>
//   Defines the SaveLevelsMessage type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace ATP.Infrastructure.Events
{
    using System;

    /// <summary>The save levels message.</summary>
    public class SaveLevelsMessage : EventArgs
    {
        /// <summary>Gets or sets the file path.</summary>
        public string FilePath { get; set; }
    }
}