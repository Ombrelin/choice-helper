using ChoiceHelper.UI.ViewModels;

namespace ChoiceHelper.UI
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
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
                builder.Services.AddSingleton<ChoicesListPage>();
                builder.Services.AddSingleton<ChoiceListViewModel>();

            return builder.Build();
        }
    }
}