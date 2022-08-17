namespace CollectionViewSwipeViewError.ViewModels;

public partial class SecondPageViewModel : ViewModelBase
{
    public SecondPageViewModel(
        INavigationService navigationService,
        IDialogService dialogService)
        : base(navigationService, dialogService)
    {
    }
}