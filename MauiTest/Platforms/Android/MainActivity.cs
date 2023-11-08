﻿// <copyright file="MainActivity.cs" company="none">
// Copyright none
// </copyright>

namespace MauiTest
{
    // ReSharper disable RedundantUsingDirective
    using Android.App;
    using Android.Content.PM;

    using Microsoft.Maui;

    [Activity(Theme = "@style/Maui.SplashTheme", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation | ConfigChanges.UiMode | ConfigChanges.ScreenLayout | ConfigChanges.SmallestScreenSize | ConfigChanges.Density)]
    public class MainActivity : MauiAppCompatActivity
    {
    }
}