namespace SampleContextCanNotBeNull;

public class ContextNullException : Microsoft.Maui.Controls.Compatibility.Layout<View>
{
    public ContextNullException()
    {
        // In nested Controls :
        // Set `InputTransparent = true;`
        InputTransparent = true;
    }

    protected override void LayoutChildren(double x, double y, double width, double height)
    {
    }
}