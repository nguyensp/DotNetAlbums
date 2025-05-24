using MostPlayedAlbums.Services;
using MostPlayedAlbums.ViewModels;

namespace MostPlayedAlbums
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
                });

            // Register HttpClient
            builder.Services.AddHttpClient<IRequestDispatcher, HttpClientDispatcher>();
            
            // Register services
            builder.Services.AddSingleton<AlbumNetworkService>();
            builder.Services.AddTransient<AlbumViewModel>();
            builder.Services.AddTransient<MainPage>();

            return builder.Build();
        }
    }
}