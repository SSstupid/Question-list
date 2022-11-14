namespace SamplePageOpenAfterGetItem;

public partial class AppShell : Shell
{
	public AppShell()
	{
		InitializeComponent();

        Routing.RegisterRoute("AddItemPage", typeof(AddItemPage));
    }
}
