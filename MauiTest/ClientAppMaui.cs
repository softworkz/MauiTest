// <copyright file="ClientAppMaui.cs" company="none">
// Copyright none
// </copyright>

namespace MauiTest
{
    using System;

    using CommunityToolkit.Maui.Views;

    using Microsoft.Maui.Controls;
    using Microsoft.Maui.Hosting;

    /// <summary>
    /// Generic MAUI application class.
    /// </summary>
    public abstract class ClientAppMaui 
    {
        private MainView mainView;
#if WINDOWS
        protected Func<Microsoft.UI.Xaml.Controls.MediaPlayerElement, object> pluginFn;
        protected Action<Microsoft.UI.Xaml.Controls.MediaPlayerElement> setPlayerFn;
#endif

        /// <summary>Initializes a new instance of the <see cref="ClientAppMaui" /> class.</summary>
        protected ClientAppMaui()
        {
        }

        /// <summary>Creates the service factory.</summary>
        /// <param name="handlers">The handlers.</param>
        public abstract void AddMauiHandlers(IMauiHandlersCollection handlers);

#if WINDOWS
        public void SetPluginCreator(Func<Microsoft.UI.Xaml.Controls.MediaPlayerElement, object> fn)
        {
            this.pluginFn = fn;
        }

        public void SetMediaElementSetter(Action<Microsoft.UI.Xaml.Controls.MediaPlayerElement> fn)
        {
            this.setPlayerFn = fn;
        }
#endif
        public View CreateMainView()
        {
            this.mainView = new MainView();
            return this.mainView;
        }

        /// <summary>Application initialization sequence.</summary>
        public  void Initialize()
        {

            ////base.Initialize();
        }

        public abstract void SetMediaElement(MediaElement mediaElement);


        public virtual void SetÁppWindow(Window window)
        {
        }
    }
}