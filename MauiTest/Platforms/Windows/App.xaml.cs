// <copyright file="App.xaml.cs" company="none">
// Copyright none
// </copyright>

// ReSharper disable once CheckNamespace
namespace MauiTest.WinUI
{
    // ReSharper disable RedundantUsingDirective
    using MauiTest;

    using Microsoft.Maui;
    using Microsoft.Maui.Hosting;

    /// <summary>
    /// Provides application-specific behavior to supplement the default Application class.
    /// </summary>
    // ReSharper disable once RedundantExtendsListEntry
    public partial class App : MauiWinUIApplication
    {
        /// <summary>Initializes a new instance of the <see cref="App"/> class.</summary>
        /// <remarks>
        /// Initializes the singleton application object.  This is the first line of authored code
        /// executed, and as such is the logical equivalent of main() or WinMain().
        /// </remarks>
        ////public App()
        ////{
        ////    this.InitializeComponent();
        ////}

        protected override MauiApp CreateMauiApp() => MauiProgram.CreateMauiApp();
    }
}