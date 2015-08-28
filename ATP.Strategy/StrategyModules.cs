// --------------------------------------------------------------------------------------------------------------------
// <copyright file="StrategyModules.cs" company="Mick George @Osoy">
//   Copyright (c) 2015 Mick George aphextwin@seidr.net
// </copyright>
// <summary>
//   Defines the StrategyModules type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace ATP.Strategy
{
    using Models;

    using Ninject.Modules;

    using Services;

    /// <summary>The strategy modules.</summary>
    public class StrategyModules : NinjectModule
    {
        /// <summary>The load.</summary>
        public override void Load()
        {
            this.Kernel.Bind<IStrategyService>().To<StrategyService>().InSingletonScope();
            this.Kernel.Bind<IMastercamOperation>().To<MastercamOperation>();
            this.Kernel.Bind<ILevels>().To<Levels>();
            this.Kernel.Bind<Mapping>().ToSelf();
            this.Kernel.Bind<Strategy>().ToSelf();
        }
    }
}