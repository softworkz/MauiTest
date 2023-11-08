// <copyright file="MainPage.xaml.cs" company="none">
// Copyright none
// </copyright>

namespace MauiTest
{
    using System;

    public partial class MainPage
    {
        public MainPage()
        {
            this.InitializeComponent();
            this.Loaded += this.MainPage_Loaded;

            try
            {
                this.Content = new MainView();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

        private void MainPage_Loaded(object sender, EventArgs e)
        {
#if WINDOWS
            ////try
            ////{
            ////    var x = CharacterEncoding.GetSystemDefault();
            ////    Debug.Print(x?.ToString());

            ////    if (DateTime.Now.Ticks != 1)
            ////    {
            ////        var FfmpegMss = await FFmpegMediaSource.CreateFromUriAsync("https://commondatastorage.googleapis.com/gtv-videos-bucket/sample/BigBuckBunny.mp4");
            ////        ////FfmpegMss.Configuration.Video.VideoDecoderMode = VideoDecoderMode.ForceSystemDecoder;
            ////        ////var PlaybackItem = FfmpegMss.CreateMediaPlaybackItem();
            ////        Debug.Print("a");
            ////    }
            ////}
            ////catch (Exception exception)
            ////{
            ////    Console.WriteLine(exception);
            ////    throw;
            ////}
#endif
        }
    }
}