namespace TestRecordStruct;

public partial class MainPage : ContentPage
{
	int count = 0;

	public MainPage(MainPageViewModel mainPageViewModel)
	{
		InitializeComponent();
		BindingContext = mainPageViewModel;
    }

    private void CollectionView_SelectionChanged(object sender, SelectionChangedEventArgs e)
    {
        Console.WriteLine("Why does this event raise when page appearing?");
    }
}

