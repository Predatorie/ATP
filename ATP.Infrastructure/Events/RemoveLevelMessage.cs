// --------------------------------------------------------------------------------------------------------------------
// <copyright file="RemoveLevelMessage.cs" company="Mick George @Osoy">
//   Copyright (c) 2015 Mick George aphextwin@seidr.net
// </copyright>
// <summary>
//   Defines the RemoveLevelMessage type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace ATP.Infrastructure.Events
{
    using System;
    using System.Windows.Forms;

    /// <summary>The remove level message.</summary>
    public class RemoveLevelMessage : EventArgs
    {
        /// <summary>Gets or sets the level.</summary>
        public TreeNode Level { get; set; }
    }
}