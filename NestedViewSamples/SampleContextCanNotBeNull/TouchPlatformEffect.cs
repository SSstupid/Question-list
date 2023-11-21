[assembly: ResolutionGroupName("Sample")]
[assembly: ExportEffect(typeof(SampleContextCanNotBeNull.TouchPlatformEffect), nameof(SampleContextCanNotBeNull.TouchPlatformEffect))]
namespace SampleContextCanNotBeNull;

public class TouchPlatformEffect : Microsoft.Maui.Controls.Platform.PlatformEffect
{
    private readonly Dictionary<int, TouchPlatformEffect> idToEffectDictionary = new Dictionary<int, TouchPlatformEffect>();

    protected override void OnAttached()
    {
    }

    protected override void OnDetached()
    {
    }
}
