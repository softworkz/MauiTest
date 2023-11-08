#if TIZEN
namespace MauiTest
{
    // ReSharper disable once RedundantUsingDirective
    using Microsoft.Maui;
    using Microsoft.Maui.Hosting;

    internal class Program : MauiApplication
    {
        protected override MauiApp CreateMauiApp() => MauiProgram.CreateMauiApp();

        // ReSharper disable once UnusedMember.Local
        static void Main(string[] args)
        {
            var app = new Program();
            app.Run(args);
        }
    }
}
#endif
