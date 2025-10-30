using LogisticsTracker.Services;
using LogisticsTracker.ViewModels;
using LogisticsTracker.Views;
using Microsoft.Extensions.Logging;
using CommunityToolkit.Maui;

namespace LogisticsTracker;

public static class MauiProgram
{
    public static MauiApp CreateMauiApp()
    {
        var builder = MauiApp.CreateBuilder();
        builder
            .UseMauiApp<App>()
            .ConfigureFonts(fonts =>
            {
                fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
            });

        builder.UseMauiCommunityToolkit();

#if DEBUG
        builder.Logging.AddDebug();
#endif

        builder.Services.AddSingleton<ITrackingService, MockTrackingService>();

        

        
        builder.Services.AddSingleton<MainPage>();
        builder.Services.AddSingleton<MainViewModel>();

       
        builder.Services.AddTransient<PackageDetailsPage>();
        builder.Services.AddTransient<PackageDetailsViewModel>();


        return builder.Build();
    }
}