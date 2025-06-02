using MenaDanielProgreso2.Services;
using MenaDanielProgreso2.Views;
using Microsoft.Extensions.Logging;

namespace MenaDanielProgreso2;

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
		builder.Services.AddSingleton<JokeService>(sp => 
		{
            var httpClient = new HttpClient
            {
                BaseAddress = new Uri("https://official-joke-api.appspot.com/")
            };
            return new JokeService(httpClient);
        });
		builder.Services.AddSingleton<Joke>();
#if DEBUG
        builder.Logging.AddDebug();
#endif

		return builder.Build();
	}
}
