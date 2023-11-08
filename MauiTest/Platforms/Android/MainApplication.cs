// <copyright file="MainApplication.cs" company="none">
// Copyright none
// </copyright>

namespace MauiTest
{
    using System;

    // ReSharper disable RedundantUsingDirective
    using Android.App;
    using Android.Runtime;

    using Microsoft.Maui;
    using Microsoft.Maui.Hosting;

    [Application]
    public class MainApplication : MauiApplication
    {
        public MainApplication(IntPtr handle, JniHandleOwnership ownership)
            : base(handle, ownership)
        {
        }

        protected override MauiApp CreateMauiApp() => MauiProgram.CreateMauiApp();
    }
}