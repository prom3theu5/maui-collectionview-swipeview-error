namespace CollectionViewSwipeViewError.Services.Navigation;

public class NavigationService : INavigationService
{
    private const string GoBackUri = "..";
    
    public Task GoToPage(string page, Dictionary<string, object>? parameters = default, Func<Task>? afterCompletion = default, bool animated = true)
    {
        if (parameters is null)
        {
            return Shell.Current.GoToAsync(page, animated).ContinueWith(async _ =>
            {
                await ProcessContinuation(afterCompletion);
            }).Unwrap();
        }

        return Shell.Current.GoToAsync(page, animated, parameters).ContinueWith(async _ =>
        {
            await ProcessContinuation(afterCompletion);
        }).Unwrap();
    }

    public Task GoBack(Dictionary<string, object>? parameters = default, Func<Task>? afterCompletion = default, bool animated = true)
    {
        return GoToPage(GoBackUri, parameters, afterCompletion, animated);
    }
    
    private static Task ProcessContinuation(Func<Task>? continuation)
    {
        return continuation is null ? Task.CompletedTask : continuation();
    }
}