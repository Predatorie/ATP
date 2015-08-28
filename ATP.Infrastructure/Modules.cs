// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Modules.cs" company="Mick George @Osoy">
//   Copyright (c) 2015 Mick George aphextwin@seidr.net
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace ATP.Infrastructure
{
    using Commands;

    using Ninject.Modules;

    using Reactive.EventAggregator;

    using Services;

    /// <summary>The modules.</summary>
    public class Modules : NinjectModule
    {
        /// <summary>The load.</summary>
        public override void Load()
        {
            this.Kernel.Bind<IEventAggregator>().To<EventAggregator>().InSingletonScope();
            this.Kernel.Bind<IFileBrowserService>().To<FileBrowserService>().InSingletonScope();
            this.Kernel.Bind<ISerializerService>().To<SerializerService>().InSingletonScope();
            this.Kernel.Bind<IMessageBoxService>().To<MessageBoxService>().InSingletonScope();
            this.Kernel.Bind<ISystemInformationService>().To<SystemInformationService>().InSingletonScope();

            // Operation specific commands
            this.Kernel.Bind<IToolbarCommand>().To<OpenOperationsCommand>().InSingletonScope();
            this.Kernel.Bind<IToolbarCommand>().To<SaveStrategyCommand>().InSingletonScope();
            this.Kernel.Bind<IToolbarCommand>().To<OpenStrategyCommand>().InSingletonScope();

            // Levels specific commands
            this.Kernel.Bind<IToolbarCommand>().To<ScanLevelCommand>().InSingletonScope();
            this.Kernel.Bind<IToolbarCommand>().To<OpenPartLevelsCommand>().InSingletonScope();
            this.Kernel.Bind<IToolbarCommand>().To<AddLevelCommand>().InSingletonScope();
            this.Kernel.Bind<IToolbarCommand>().To<RemoveLevelCommand>().InSingletonScope();
            this.Kernel.Bind<IToolbarCommand>().To<SaveLevelsCommand>().InSingletonScope();
            this.Kernel.Bind<IToolbarCommand>().To<OpenLevelsCommand>().InSingletonScope();

            // Bottom buttons
            this.Kernel.Bind<IButtonsCommand>().To<CloseShellCommand>().InSingletonScope();
        }
    }
}
