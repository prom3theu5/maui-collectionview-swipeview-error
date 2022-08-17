namespace CollectionViewSwipeViewError;

internal static class MauiAppBuilderExtensions
{
    public static MauiAppBuilder RegisterViewsAndViewModels(this MauiAppBuilder builder)
    {
        builder.Services.AddTransient<MainPage, MainPageViewModel>();
        builder.Services.AddTransient<SecondPage, SecondPageViewModel>();

        return builder;
    }

    public static MauiAppBuilder RegisterEssentialServices(this MauiAppBuilder builder)
    {
        builder.Services.AddSingleton<INavigationService, NavigationService>();
        builder.Services.AddSingleton<IDialogService, DialogService>();
        builder.Services.AddTransient<IDataSource, DebugData>();

        return builder;
    }
}