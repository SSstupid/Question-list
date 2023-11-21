namespace SampleContextCanNotBeNull;

public partial class AppShell : Shell
{
    public AppShell()
    {
        InitializeComponent();

        Routing.RegisterRoute(nameof(ContextNullException), typeof(ContextNullExceptionPage));
        Routing.RegisterRoute(nameof(NullReferenceException), typeof(NullReferenceExceptionPage));
    }
}
