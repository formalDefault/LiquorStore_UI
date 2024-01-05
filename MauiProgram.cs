using CommunityToolkit.Maui;
using Microsoft.Extensions.Logging;
using Xe.AcrylicView;

namespace MauiAndroidApp
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder
                .UseMauiApp<App>()
                .UseAcrylicView()
                .UseMauiCommunityToolkit() 
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                    fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold"); 
                    fonts.AddFont("AbhayaLibre-Regular.ttf","FontAbhayaLibreRegular");
                    fonts.AddFont("AbhayaLibre-Bold.ttf",   "FontAbhayaLibreBold");
                    fonts.AddFont("Barlow-Regular.ttf", "FontBarlowRegular");
                    fonts.AddFont("Barlow-Bold.ttf", "FontBarlowBold");
                    fonts.AddFont("Barlow-SemiBold.ttf", "FontBarlowSemiBold");
                    fonts.AddFont("Roboto-Regular.ttf", "FontRobotoRegular");
                    fonts.AddFont("fontello.ttf", "FontFontello");
                });


#if DEBUG
            builder.Logging.AddDebug();
#endif

            return builder.Build();
        }
    }
}
