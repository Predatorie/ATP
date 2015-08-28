// --------------------------------------------------------------------------------------------------------------------
// <copyright file="SystemInformationService.cs" company="Mick George @Osoy">
//   Copyright (c) 2015 Mick George aphextwin@seidr.net
// </copyright>
// <summary>
//   Defines the SystemInformationService type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace ATP.Infrastructure.Services
{
    using System.Windows.Forms;

    public class SystemInformationService : ISystemInformationService
    {
        public bool IsHighContrastColourScheme => SystemInformation.HighContrast;
    }
}