using CommunityToolkit.Maui;
using CommunityToolkit.Maui.Markup;
using Microsoft.Extensions.Logging;
using Microsoft.Maui.LifecycleEvents;
using ViewModels;
using Views.Pages;
#if WINDOWS
using Views.WinUI;
#endif
namespace Views
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder
                .UseMauiApp<App>()
                .UseMauiCommunityToolkitMarkup()
                .UseMauiCommunityToolkit()
                .ConfigureLifecycleEvents(events =>
                {
                    //events.AddWindows(windowsLifecycleBuilder =>
                    //{
                    
                    //});
                })
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                    fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                });

            builder.Services.AddSingleton<FromScratchView>();
            builder.Services.AddSingleton<FromScratchViewModel>();

            builder.Services.AddSingleton<CodeBehindApproachView>();
            builder.Services.AddSingleton<CodeBehindApproachViewModel>();
#if DEBUG
            builder.Logging.AddDebug();
#endif

            return builder.Build();
        }
    }
}
