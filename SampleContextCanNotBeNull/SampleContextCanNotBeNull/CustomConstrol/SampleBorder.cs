using SkiaSharp.Views.Maui.Controls;

namespace SampleContextCanNotBeNull;

public class SampleBorder : Microsoft.Maui.Controls.Compatibility.Layout<View>
{
    // Events
    // Properties
    private readonly SKCanvasView _canvas;
    // Constructors
    public SampleBorder()
    {
        InputTransparent = true;
        _canvas = new SKCanvasView
        {
            EnableTouchEvents = false,
        };
        Children.Add(_canvas);
    }

    protected override void LayoutChildren(double x, double y, double width, double height)
    {
        LayoutChildIntoBoundingRegion(_canvas, new Rect(x, y, width, height));
    }
}

