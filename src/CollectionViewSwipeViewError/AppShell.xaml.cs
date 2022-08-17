namespace CollectionViewSwipeViewError;

public partial class AppShell : Shell
{
	public AppShell()
	{
		InitializeComponent();
        InitRouting();
    }

    private void InitRouting()
    {
        Routing.RegisterRoute(nameof(SecondPage), typeof(SecondPage));
    }
}
