// --------------------------------------------------------------------------------------------------------------------
// <copyright file="OperationsLibraryLoadMessage.cs" company="Mick George @Osoy">
//   Copyright (c) 2015 Mick George aphextwin@seidr.net
// </copyright>
// <summary>
//   Defines the OperationsLibraryLoadMessage type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace ATP.Infrastructure.Events
{
    using System;
    using System.Collections.Generic;

    /// <summary>The operations library load message.</summary>
    public class OperationsLibraryLoadMessage : EventArgs
    {
        /// <summary>Gets or sets the library.</summary>
        public List<string> Libraries { get; set; }
    }
}
