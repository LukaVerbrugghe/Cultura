using Microsoft.Extensions.Logging;

namespace prjCultura
{
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
                    fonts.AddFont("DMMono-Italic.ttf", "DMMonoItalic");
                    fonts.AddFont("DMMono-Light.ttf", "DMMonoLight");
                    fonts.AddFont("DMMono-LightItalic.ttf", "DMMonoLightItalic");
                    fonts.AddFont("DMMono-Medium.ttf", "DMMonoMedium");
                    fonts.AddFont("DMMono-MediumItalic.ttf", "DMMonoMediumItalic");
                    fonts.AddFont("DMMono-Regular.ttf", "DMMonoRegular");
                });

#if DEBUG
    		builder.Logging.AddDebug();
#endif

            return builder.Build();
        }
    }
}
