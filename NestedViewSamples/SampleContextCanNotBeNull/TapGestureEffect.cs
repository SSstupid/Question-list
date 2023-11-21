namespace SampleContextCanNotBeNull;

public class TapGestureEffect : TouchEffect
{
    private readonly IDictionary<long, string> _touchPoints;

    public TapGestureEffect()
    {
        _touchPoints = new Dictionary<long, string>();
    }

    public override void RaiseTouch(Element element, TouchEventArgs e)
    {
        base.RaiseTouch(element, e);
    }
}
