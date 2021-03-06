﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="OpenOperationsCommand.cs" company="Mick George @Osoy">
//   Copyright (c) 2015 Mick George aphextwin@seidr.net
// </copyright>
// <summary>
//   Defines the OpenOperationsCommand type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace ATP.Infrastructure.Commands
{
    using System.IO;
    using System.Linq;

    using Events;

    using Localization;

    using Mastercam.IO;
    using Mastercam.Support;

    using Reactive.EventAggregator;

    using Services;

    /// <summary>The open operations command.</summary>
    public class OpenOperationsCommand : CommandBase
    {
        /// <summary>The event aggregator.</summary>
        private readonly IEventAggregator eventAggregator;

        /// <summary>The file browser service.</summary>
        private readonly IFileBrowserService fileBrowserService;


        /// <summary>Initializes a new instance of the <see cref="OpenOperationsCommand"/> class.</summary>
        /// <param name="eventAggregator">The event aggregator.</param>
        /// <param name="fileBrowserService">The file Browser Service.</param>
        public OpenOperationsCommand(IEventAggregator eventAggregator, IFileBrowserService fileBrowserService)
        {
            this.eventAggregator = eventAggregator;
            this.fileBrowserService = fileBrowserService;

            ////this.Icon = Resource.Operations;
            this.ToolTip = ApplicationStrings.OpenOperationsLib;
            this.CanExecute = true;
        }

        /// <summary>The execute.</summary>
        public override void Execute()
        {
            // Determine what operations library folder we will open too.
            var libraryLocation = Path.Combine(SettingsManager.SharedDirectory, MachineDefManager.IsCurrentMachineGroupRouter() ? "router\\OPS" : "mill\\Ops");

            // Prompr user to select an operations library(s)
            var operationsLib = this.fileBrowserService.BrowseForFile(this.Parent, ApplicationStrings.PromptForOperationsLibrary, Globals.FileFilterOperations, libraryLocation, true);

            if (!operationsLib.Any())
            {
                return;
            }

            // Notify our subscribers
            var payload = new OperationsLibraryLoadMessage { Libraries = operationsLib };
            this.eventAggregator.Publish(payload);
        }
    }
}