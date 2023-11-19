namespace DefineViewWithParameterToXaml;

public partial class ViewWithParameter : ContentView
{
	public ViewWithParameter(ViewModel viewModel)
	{
		InitializeComponent();
		BindingContext = viewModel;
	}

    /*
    // 2023.11.19 [재환] 솔루션 2
    // 종속성 주입을 자동?이 아닌 직접 주입 방식으로 변경한다.
    public ViewWithParameter()
    {
        InitializeComponent();
        BindingContext = Ioc.Default.GetRequiredServer<ViewModel>();
    }
    */
}