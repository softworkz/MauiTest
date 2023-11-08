// <copyright file="App.xaml.cs" company="none">
// Copyright none
// </copyright>

namespace MauiTest
{
    using Microsoft.Maui;

    public partial class App
    {
        public App()
        {
            this.InitializeComponent();

            this.MainPage = new AppShell();
        }
    }
}