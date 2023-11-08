// <copyright file="Program.cs" company="none">
// Copyright none
// </copyright>

namespace MauiTest
{
    // ReSharper disable once RedundantUsingDirective
    using UIKit;

    public class Program
    {
        // This is the main entry point of the application.
        public static void Main(string[] args)
        {
            // if you want to use a different Application Delegate class from "AppDelegate"
            // you can specify it here.
            UIApplication.Main(args, null, typeof(AppDelegate));
        }
    }
}