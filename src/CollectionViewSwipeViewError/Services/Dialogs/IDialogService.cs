namespace CollectionViewSwipeViewError.Services.Dialogs;

public interface IDialogService
{
    Task ShowQueryAsync(string message, string title);
    Task ShowAlertAsync(string message, string title, string cancelButton);
}