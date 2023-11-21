namespace SampleContextCanNotBeNull;

public class NullReferenceException : Microsoft.Maui.Controls.Compatibility.Layout<View>
{
    public NullReferenceException()
    {
        // In nested Controls :
        // Adding an effect causes a null refence.
        var tapGestureEffect = new TapGestureEffect();
        Effects.Add(tapGestureEffect);
    }

    protected override void LayoutChildren(double x, double y, double width, double height)
    {
    }
}