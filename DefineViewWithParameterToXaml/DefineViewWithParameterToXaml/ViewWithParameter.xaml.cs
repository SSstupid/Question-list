namespace DefineViewWithParameterToXaml;

public partial class ViewWithParameter : ContentView
{
	public ViewWithParameter(ViewModel viewModel)
	{
		InitializeComponent();
		BindingContext = viewModel;
	}
}