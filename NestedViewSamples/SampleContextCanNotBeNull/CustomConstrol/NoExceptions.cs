namespace SampleContextCanNotBeNull;

public class NoExceptions : Microsoft.Maui.Controls.Compatibility.Layout<View>
{
    // if it is a single View???, there is no problem
    public NoExceptions()
    {
        // `InputTransparent = true` will be error => Context can not be null
        InputTransparent = true;

        // `Effects.Add(tapGestureEffect)` will be error => Null Reference..
        var tapGestureEffect = new TapGestureEffect();
        Effects.Add(tapGestureEffect);

        // if it is a single View???, there is no problem
    }

    protected override void LayoutChildren(double x, double y, double width, double height)
    {
    }
}