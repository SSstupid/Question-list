namespace SampleContextCanNotBeNull;

public class TouchEffect : RoutingEffect
{
    public TouchEffect() : base($"SampleContextCanNotBeNull.{nameof(TouchEffect)}")
    {
    }

    public virtual void RaiseTouch(Element element, TouchEventArgs e)
    {
    }
}
