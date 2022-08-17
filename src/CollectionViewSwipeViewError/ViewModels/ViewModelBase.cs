namespace CollectionViewSwipeViewError.ViewModels;

public abstract partial class ViewModelBase : ObservableRecipient
{
    protected readonly INavigationService NavigationService;
    protected readonly IDialogService DialogService;

    protected ViewModelBase(INavigationService navigationService, IDialogService dialogService)
    {
        NavigationService = navigationService;
        DialogService = dialogService;
    }
    
    [ObservableProperty]
    [NotifyPropertyChangedFor(nameof(IsNotBusy))]
    public bool isBusy;

    [ObservableProperty]
    public string? title;

    [ObservableProperty]
    public string? content;

    [ObservableProperty]
    [NotifyPropertyChangedFor(nameof(NotHasFiles))]
    public bool hasFiles;

    public bool IsNotBusy => !IsBusy;

    public bool NotHasFiles => !HasFiles;

    public virtual async Task Initialise()
    {
        await Task.CompletedTask;
    }

    public virtual async Task UnInitialise()
    {
        await Task.CompletedTask;
    }

    protected virtual Task<bool> Validate() => Task.FromResult(true);
    
    [RelayCommand]
    private async Task ClosePage()
    {
        await NavigationService.GoBack();
    }
}