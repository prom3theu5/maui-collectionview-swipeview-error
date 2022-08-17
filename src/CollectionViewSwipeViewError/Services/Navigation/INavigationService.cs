namespace CollectionViewSwipeViewError.Services.Navigation;

public interface INavigationService
{
    Task GoToPage(string page, Dictionary<string, object>? parameters = default, Func<Task>? afterCompletion = default, bool animated = true);
    Task GoBack(Dictionary<string, object>? parameters = default, Func<Task>? afterCompletion = default, bool animated = true);
}