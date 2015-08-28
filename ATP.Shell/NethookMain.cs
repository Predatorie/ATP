// --------------------------------------------------------------------------------------------------------------------
// <copyright file="NethookMain.cs" company="Mick George @Osoy">
//   Copyright (c) 2015 Mick George aphextwin@seidr.net
// </copyright>
// <summary>
//   
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace ATP.Shell
{
    using Infrastructure;

    using Mastercam.App;
    using Mastercam.App.Types;
    using Mastercam.IO;
    using Mastercam.IO.Types;

    using Ninject;

    using Properties;

    using Strategy;

    /// <summary>
    /// Defines the NethookMain type
    /// </summary>
    public class NethookMain : NetHook3App
    {
        /// <summary>The standard kernel.</summary>
        private StandardKernel standardKernel;

        #region Public Override Methods

        /// <summary>
        /// The main entry point for your NETHook.
        /// </summary>
        /// <param name="param">System parameter.</param>
        /// <returns>A <c>MCamReturn</c> return type representing the outcome of your NetHook application.</returns>
        public override MCamReturn Run(int param)
        {
            // Register all our modules
            this.standardKernel = new StandardKernel();

            this.standardKernel.Load(new Modules());
            this.standardKernel.Load(new StrategyModules());

            EventManager.LogEvent(MessageSeverityType.InformationalMessage, "ATP.Shell.dll", "** Modules Loaded ** ");

            // First time user has run the app
            if (Settings.Default.FirstRun)
            {
                //// TODO: Do something first time running
                Settings.Default.FirstRun = false;
                Settings.Default.Save();
            }

            return MCamReturn.NoErrors;
        }

        /// <summary>
        /// This is the method called when your application has ended it's execution loop and is getting ready to
        /// close. This method is where you would want to put any cleanup code or special closing functionality.
        /// Just like the Init method, this is also optional and can be omitted if you don't need to do anything on
        /// </summary>
        /// <param name="param">System parameter.</param>
        /// <returns>A <c>MCamReturn</c> return type representing the outcome of this method.</returns>
        public override MCamReturn Close(int param)
        {
            // Clean up
            if (!this.standardKernel.IsDisposed)
            {
                this.standardKernel.Dispose();

                EventManager.LogEvent(MessageSeverityType.InformationalMessage, "ATP.Shell.dll", "** Modules UnLoaded ** ");
            }

            return MCamReturn.NoErrors;
        }

        #endregion
    }
}
