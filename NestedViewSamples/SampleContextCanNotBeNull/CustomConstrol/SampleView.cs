namespace SampleContextCanNotBeNull;

public class SampleView : Microsoft.Maui.Controls.Compatibility.Layout<View>
{
    // Events
    // Properties
    private View _content;
    public View Content
    {
        get => _content;
        set
        {
            if (_content != null)
                Children.Remove(_content);

            _content = value;

            if (_content != null)
                Children.Insert(0, _content);
        }
    }

    // Constructors
    public SampleView()
    {
    }

    protected override void LayoutChildren(double x, double y, double width, double height)
    {
    }
}