// <copyright file="MainView.xaml.cs" company="none">
// Copyright none
// </copyright>

namespace MauiTest;

using System;
using System.Reflection;

using Microsoft.Maui.Controls;
using Microsoft.Maui.Platform;

public partial class MainView
{
    private bool hasNavigatedFirst;

    public MainView()
    {
        this.InitializeComponent();

        this.WebView1.Navigated += this.WebView1_Navigated;
        this.WebView1.PropertyChanged += this.WebView1_PropertyChanged;

        ////this.MediaElement1.ShouldAutoPlay = true;
        ////this.MediaElement1.Source = MediaSource.FromUri("https://commondatastorage.googleapis.com/gtv-videos-bucket/sample/BigBuckBunny.mp4");

        this.Loaded += this.MainView_Loaded;
        ////this.Loaded += this.MainView_Loaded;
    }

    private void MainView_Loaded(object sender, EventArgs e)
    {
        this.WebView1.Source = new Uri("https://github.com/ffmpeginteropx/FFmpegInteropX/pull/379#issuecomment-1802559586");
    }

    ////    private void MainView_Loaded(object sender, EventArgs e)
    ////    {
    ////        var handler = this.MediaElement1.Handler;
    ////#if WINDOWS
    ////        var platformView = handler?.PlatformView as CommunityToolkit.Maui.Core.Views.MauiMediaElement;
    ////        if (platformView != null)
    ////        {
    ////            Debug.Print("platformView type: " + platformView.GetType().FullName);
    ////        }
    ////#endif
    ////    }

    private void WebView1_PropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e)
    {
    }

    private void WebView1_Navigated(object sender, WebNavigatedEventArgs e)
    {
        if (this.hasNavigatedFirst)
        {
            return;
        }

        try
        {
            this.hasNavigatedFirst = true;

            ////this.clientApp.ConnectWebView(this.webViewAdapter).FireAndForget(this.clientApp.ServiceRoot.LogManager.GetLogger(nameof(MainView)));
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex);  
        }
    }

    private async void Button_OnClicked(object sender, EventArgs e)
    {
#if WINDOWS
        var mpe = this.GetMediaPlayerElement();

        var test = new PlayerProject.PlayerTestClass();
        var player = test.CreatePlayer();

        mpe.SetMediaPlayer(player);

        await test.TestSetVideoToPlayer(player);
#endif
    }

#if WINDOWS
    public Microsoft.UI.Xaml.Controls.MediaPlayerElement GetMediaPlayerElement()
    {
        var context = Application.Current?.Handler?.MauiContext;

        if (context != null)
        {
            var elem = this.MediaElement1.ToPlatform(context);

            Type type = elem.GetType();
            FieldInfo fieldInfo = null;

            while (type != null)
            {
                fieldInfo = type.GetField("mediaElement", BindingFlags.NonPublic | BindingFlags.Instance);
                if (fieldInfo != null)
                {
                    break;
                }

                type = type.BaseType;
            }

            Microsoft.UI.Xaml.Controls.MediaPlayerElement mpe = fieldInfo?.GetValue(elem) as Microsoft.UI.Xaml.Controls.MediaPlayerElement;
            return mpe;
        }

        return null;
    }
#endif
}