namespace SamplePageOpenAfterGetItem;

public partial class AddItemPage : ContentPage
{
	public AddItemPage(AddItemPageViewModel addItemPageViewModel)
	{
		InitializeComponent();
		BindingContext = addItemPageViewModel;
    }
}