using CommunityToolkit.Maui;

namespace CollectionViewSwipeViewError;

internal static class MauiAppBuilderExtensions
{
    public static MauiAppBuilder RegisterViewsAndViewModels(this MauiAppBuilder builder)
    {
        builder.Services.AddTransientWithShellRoute<MainPage, MainPageViewModel>(nameof(MainPage));
        builder.Services.AddTransientWithShellRoute<SecondPage, SecondPageViewModel>(nameof(SecondPage));

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