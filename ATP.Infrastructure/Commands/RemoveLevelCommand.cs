﻿namespace ATP.Infrastructure.Commands
{
    using System;
    using System.Windows.Forms;

    using Events;
    using Localization;

    using Reactive.EventAggregator;

    public class RemoveLevelCommand : CommandBase
    {
        /// <summary>The event aggregator.</summary>
        private readonly IEventAggregator eventAggregator;

        /// <summary>The level.</summary>
        private TreeNode level;

        /// <summary>Initializes a new instance of the <see cref="RemoveLevelCommand"/> class.</summary>
        /// <param name="eventAggregator">The event aggregator.</param>
        public RemoveLevelCommand(IEventAggregator eventAggregator)
        {
            this.eventAggregator = eventAggregator;

            ////this.Icon = Resource.Tree_View_Remove;
            this.ToolTip = ApplicationStrings.RemoveLevel;
            this.CanExecute = false;

            // Only allow remove level button to be enabled when the selected level
            // is valid and not the top (main) level
            this.eventAggregator.GetEvent<LevelSelectedMessage>().Subscribe(
                (e) =>
                {
                    this.CanExecute = e.Level?.Level != 0;
                });

            this.eventAggregator.GetEvent<OperationSelectedMessage>().Subscribe(e => this.CanExecute = false);
            this.eventAggregator.GetEvent<LevelSelectedMessage>().Subscribe(this.OnLevelToRemove);
        }

        /// <summary>The execute.</summary>
        public override void Execute()
        {
            this.eventAggregator.Publish(new RemoveLevelMessage { Level = this.level });
        }

        /// <summary>The on level to remove.</summary>
        /// <param name="e">The e.</param>
        private void OnLevelToRemove(LevelSelectedMessage e)
        {
            this.level = e.Level;
        }
    }
}