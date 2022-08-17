namespace CollectionViewSwipeViewError.Views;

public abstract class BasePage<TViewModel> : BasePage where TViewModel : ViewModelBase
{
    protected BasePage(TViewModel viewModel) : base(viewModel)
    {
    }

    public new TViewModel BindingContext => (TViewModel)base.BindingContext;
}

public abstract class BasePage : ContentPage
{
    protected BasePage(object? viewModel = null)
    {
        BindingContext = viewModel;

        SetDynamicResource(BackgroundColorProperty, "AppBackgroundColor");

        if (string.IsNullOrWhiteSpace(Title))
        {
            Title = GetType().Name;
        }
    }

    protected override async void OnAppearing()
    {
        base.OnAppearing();
        if (BindingContext is ViewModelBase baseVm)
        {
            await baseVm.Initialise();
        }

        Debug.WriteLine($"OnAppearing: {Title}");
    }

    protected override async void OnDisappearing()
    {
        base.OnDisappearing();

        if (BindingContext is ViewModelBase baseVm)
        {
            await baseVm.UnInitialise();
        }

        Debug.WriteLine($"OnDisappearing: {Title}");
    }
}