using Microsoft.Extensions.DependencyInjection;
using Plugin.Maui.Handlers;

namespace Plugin.Maui.Handlers.Sample;

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

		builder.Services.AddTransient<MainPage>();

		EntryHandler.RemoveBorders();
		EntryHandler.AddDone(Color.FromArgb("#000000"));

        EditorHandler.RemoveBorders();
		EditorHandler.EnableScrolling();
		EditorHandler.AddDone(null);

        PickerHandler.RemoveBorders();
        
        DatePickerHandler.RemoveBorders();

		return builder.Build();
	}
}