using CommunityToolkit.Maui;
using Microsoft.Extensions.Logging;
using PanCardView;
using SkiaSharp.Views.Maui.Controls.Hosting;

namespace Dalui;

public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
	{
		var builder = MauiApp.CreateBuilder();
		builder
			.UseMauiApp<App>()
			.UseCardsView()
			.UseSkiaSharp()
			.UseMauiCommunityToolkit()
			.ConfigureFonts(fonts =>
			{
				fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
				fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
				fonts.AddFont(filename: "Nexa-ExtraLight.ttf", "NexaLight");
				fonts.AddFont(filename: "Nexa-Heavy.ttf", "NexaHeavy");
			});

#if DEBUG
		builder.Logging.AddDebug();
#endif

		return builder.Build();
	}
}
