﻿namespace ATP.Infrastructure.Commands
{
    using System.ComponentModel;
    using System.Drawing;
    using System.Runtime.CompilerServices;
    using System.Windows.Forms;

    public abstract class CommandBase : IToolbarCommand
    {
        /// <summary>The can execute.</summary>
        private bool canExecute;

        /// <summary>The icon.</summary>
        private Image icon;

        /// <summary>The tool tip.</summary>
        private string toolTip;

        private IWin32Window window;

        /// <summary>Initializes a new instance of the <see cref="CommandBase"/> class.</summary>
        protected CommandBase()
        {
            this.canExecute = true;
        }

        /// <summary>The property changed.</summary>
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>Gets or sets a value indicating whether can execute.</summary>
        public bool CanExecute
        {
            get
            {
                return this.canExecute;
            }

            set
            {
                if (this.canExecute == value)
                {
                    return;
                }

                this.canExecute = value;
                this.OnPropertyChanged();
            }
        }

        /// <summary>Gets or sets the tool tip.</summary>
        public string ToolTip
        {
            get
            {
                return this.toolTip;
            }

            set
            {
                if (this.toolTip == value)
                {
                    return;
                }

                this.toolTip = value;
                this.OnPropertyChanged();
            }
        }

        /// <summary>Gets or sets the shortcut key.</summary>
        public Keys ShortcutKey { get; set; }

        /// <summary>Gets or sets the icon.</summary>
        public Image Icon
        {
            get
            {
                return this.icon;
            }

            set
            {
                if (this.icon == value)
                {
                    return;
                }

                this.icon = value;
                this.OnPropertyChanged();
            }
        }

        public IWin32Window Parent
        {
            get
            {
                return this.window;
            }

            set
            {
                if (this.window == value)
                {
                    return;
                }

                this.window = value;
                this.OnPropertyChanged();
            }
        }

        /// <summary>
        /// Whoever inherits this class will override this method
        /// </summary>
        public abstract void Execute();

        /// <summary>The on property changed.</summary>
        /// <param name="propertyName">The property name.</param>
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}