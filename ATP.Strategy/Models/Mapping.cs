// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Mapping.cs" company="Mick George @Osoy">
//   Copyright (c) 2015 Mick George aphextwin@seidr.net
// </copyright>
// <summary>
//   Defines the Mapping type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace ATP.Strategy.Models
{
    using System.Runtime.Serialization;

    /// <summary>The mapping.</summary>
    [DataContract(Name = "Mapping", Namespace = "")]
    public class Mapping
    {
        /// <summary>Gets or sets the map. Level Name, Operation Library</summary>
        [DataMember(Name = "Level")]
        public string Level { get; set; }

        /// <summary>Gets or sets the comment.</summary>
        [DataMember(Name = "Comment")]
        public string Comment { get; set; }

        /// <summary>Gets or sets the library.</summary>
        [DataMember(Name = "Library")]
        public string Library { get; set; }
    }
}