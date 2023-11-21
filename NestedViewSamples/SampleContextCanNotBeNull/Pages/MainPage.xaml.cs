namespace SampleContextCanNotBeNull
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void GoToContextNullExceptionPage(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync(nameof(ContextNullException)).ConfigureAwait(false);
        }

        private async void GoToNullReferenceExceptionPage(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync(nameof(NullReferenceException)).ConfigureAwait(false);

        }
    }
}
