// --------------------------------------------------------------------------------------------------------------------
// <copyright file="SaveLevelsCommand.cs" company="Mick George @Osoy">
//   Copyright (c) 2015 Mick George aphextwin@seidr.net
// </copyright>
// <summary>
//   Defines the SaveLevelsCommand type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace ATP.Infrastructure.Commands
{
    using Events;

    using Localization;

    using Reactive.EventAggregator;

    using Services;

    /// <summary>The save levels command.</summary>
    public class SaveLevelsCommand : CommandBase
    {
        /// <summary>The event aggregator.</summary>
        private readonly IEventAggregator eventAggregator;

        /// <summary>The file browser service.</summary>
        private readonly IFileBrowserService fileBrowserService;

        /// <summary>Initializes a new instance of the <see cref="SaveLevelsCommand"/> class.</summary>
        /// <param name="eventAggregator">The event aggregator.</param>
        /// <param name="fileBrowserService">The file Browser Service.</param>
        public SaveLevelsCommand(IEventAggregator eventAggregator, IFileBrowserService fileBrowserService)
        {
            this.eventAggregator = eventAggregator;
            this.fileBrowserService = fileBrowserService;

            ////this.Icon = Resource.Save;
            this.ToolTip = ApplicationStrings.SaveLevels;
            this.CanExecute = true;
        }

        /// <summary>The execute.</summary>
        public override void Execute()
        {
            var filepath = this.fileBrowserService.SaveFile(this.Parent, ApplicationStrings.Title, Globals.FileFilterXml, Globals.LevelsFolder);
            if (string.IsNullOrWhiteSpace(filepath))
            {
                return;
            }

            this.eventAggregator.Publish(new SaveLevelsMessage { FilePath = filepath });
        }
    }
}