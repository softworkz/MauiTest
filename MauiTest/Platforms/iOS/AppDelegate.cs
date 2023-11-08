// <copyright file="AppDelegate.cs" company="none">
// Copyright none
// </copyright>

namespace MauiTest
{
    // ReSharper disable RedundantUsingDirective
    using Foundation;

    using Microsoft.Maui;
    using Microsoft.Maui.Hosting;

    [Register("AppDelegate")]
    public class AppDelegate : MauiUIApplicationDelegate
    {
        protected override MauiApp CreateMauiApp() => MauiProgram.CreateMauiApp();
    }
}