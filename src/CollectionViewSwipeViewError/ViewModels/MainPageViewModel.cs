namespace CollectionViewSwipeViewError.ViewModels;

public partial class MainPageViewModel : ViewModelBase
{
    private readonly IDataSource _dataSource;
    public ObservableCollection<LocalFile> LocalFileCollection { get; set; } = new();

    public MainPageViewModel(
        INavigationService navigationService,
        IDialogService dialogService,
        IDataSource dataSource)
        : base(navigationService, dialogService)
    {
        _dataSource = dataSource;
    }

    public override async Task Initialise()
    {
        LocalFileCollection.Clear();

        var files = await _dataSource.GetLocalFiles();
        foreach (var file in files)
        {
            LocalFileCollection.Add(file);
        }
    }

    [RelayCommand]
    private async Task ViewFile(LocalFile? file)
    {
        if (file is null)
        {
            return;
        }

        await DialogService.ShowAlertAsync($"Viewing File: '{file.FileName}'", "View File", "Ok");
    }

    [RelayCommand]
    private async Task DeleteFile(LocalFile? file)
    {
        if (file is null)
        {
            return;
        }

        await DialogService.ShowQueryAsync($"Are You Sure You Wish To Delete File: '{file.FileName}'", "Delete File");
    }

    [RelayCommand]
    private async Task GotoPageTwo()
    {
        await NavigationService.GoToPage(nameof(SecondPage));
    }
}