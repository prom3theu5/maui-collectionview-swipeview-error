namespace CollectionViewSwipeViewError.Services.Dialogs;

public class DialogService : IDialogService
{
    public async Task ShowQueryAsync(string message, string title)
    {
        if (Application.Current is { MainPage: { } })
        {
            await Application.Current.MainPage.DisplayAlert (title, message, "Yes", "No");
        }
    }

    public async Task ShowAlertAsync(string message, string title, string cancelButton)
    {
        if (Application.Current is { MainPage: { } })
        {
            await Application.Current.MainPage.DisplayAlert (title, message, "Confirm");
        }
    }
}