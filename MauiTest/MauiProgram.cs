// <copyright file="MauiProgram.cs" company="none">
// Copyright none
// </copyright>

namespace MauiTest
{
    using CommunityToolkit.Maui;

    using Microsoft.Maui.Controls.Hosting;
    using Microsoft.Maui.Hosting;

    public static partial class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {

            var builder = MauiApp.CreateBuilder();
            builder.UseMauiApp<App>()
                .UseMauiCommunityToolkitMediaElement()
                .ConfigureFonts(fonts =>
            {
                fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
            });

////#if WINDOWS
////            var x = FFmpegInteropX.CharacterEncoding.GetSystemDefault();
////            Debug.Print(x?.ToString());

////            if (DateTime.Now.Ticks != 1)
////            {
////                var FfmpegMss = FFmpegMediaSource.CreateFromUriAsync("https://commondatastorage.googleapis.com/gtv-videos-bucket/sample/BigBuckBunny.mp4").GetResults();
////                ////FfmpegMss.Configuration.Video.VideoDecoderMode = VideoDecoderMode.ForceSystemDecoder;
////                ////var PlaybackItem = FfmpegMss.CreateMediaPlaybackItem();
////                Debug.Print("a");
////            }

////#endif

            return builder.Build();
        }
    }
}