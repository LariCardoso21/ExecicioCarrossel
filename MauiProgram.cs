using ExecicioCarrossel.ViewModels;
using Microsoft.Extensions.Logging;
using ExecicioCarrossel.Views;

namespace ExecicioCarrossel
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
                });

#if DEBUG
    		builder.Logging.AddDebug();
#endif
            builder.Services.AddTransient<ViagemViewModel>();
            builder.Services.AddTransient<ViagemPage>();

            return builder.Build();
        }
    }
}
