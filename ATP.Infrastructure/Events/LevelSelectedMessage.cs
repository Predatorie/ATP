﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="LevelSelectedMessage.cs" company="Mick George @Osoy">
//   Copyright (c) 2015 Mick George aphextwin@seidr.net
// </copyright>
// <summary>
//   Defines the LevelSelectedMessage type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace ATP.Infrastructure.Events
{
    using System;
    using System.Windows.Forms;

    /// <summary>The level selected message.</summary>
    public class LevelSelectedMessage : EventArgs
    {
        /// <summary>Initializes a new instance of the <see cref="LevelSelectedMessage"/> class.</summary>
        /// <param name="level">The level.</param>
        public LevelSelectedMessage(TreeNode level)
        {
            this.Level = level;
        }

        /// <summary>Gets the level.</summary>
        public TreeNode Level { get; private set; }
    }
}