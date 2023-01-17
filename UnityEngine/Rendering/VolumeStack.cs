// Namespace: UnityEngine.Rendering
public sealed class VolumeStack : IDisposable // TypeDefIndex: 4690
{
	// Fields
	internal Dictionary<Type, VolumeComponent> components; // 0x10

	// Methods

	// RVA: 0x354C410 Offset: 0x354C511 VA: 0x354C410
	internal void .ctor() { }

	// RVA: 0x354C420 Offset: 0x354C521 VA: 0x354C420
	internal void Reload(IEnumerable<Type> baseTypes) { }

	// RVA: -1 Offset: -1
	public T GetComponent<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x386EFA0 Offset: 0x386F0A1 VA: 0x386EFA0
	|-VolumeStack.GetComponent<Bloom>
	|-VolumeStack.GetComponent<ChannelMixer>
	|-VolumeStack.GetComponent<ChromaticAberration>
	|-VolumeStack.GetComponent<ColorAdjustments>
	|-VolumeStack.GetComponent<ColorCurves>
	|-VolumeStack.GetComponent<ColorLookup>
	|-VolumeStack.GetComponent<CustomColorGrading>
	|-VolumeStack.GetComponent<CustomGradationFilter>
	|-VolumeStack.GetComponent<CustomHeatHaze>
	|-VolumeStack.GetComponent<CustomRadialBlur>
	|-VolumeStack.GetComponent<DepthOfField>
	|-VolumeStack.GetComponent<FilmGrain>
	|-VolumeStack.GetComponent<LensDistortion>
	|-VolumeStack.GetComponent<LiftGammaGain>
	|-VolumeStack.GetComponent<MotionBlur>
	|-VolumeStack.GetComponent<object>
	|-VolumeStack.GetComponent<PaniniProjection>
	|-VolumeStack.GetComponent<ShadowsMidtonesHighlights>
	|-VolumeStack.GetComponent<SplitToning>
	|-VolumeStack.GetComponent<Tonemapping>
	|-VolumeStack.GetComponent<Vignette>
	|-VolumeStack.GetComponent<WhiteBalance>
	*/

	// RVA: 0x354CAC0 Offset: 0x354CBC1 VA: 0x354CAC0
	public VolumeComponent GetComponent(Type type) { }

	// RVA: 0x354C7C0 Offset: 0x354C8C1 VA: 0x354C7C0 Slot: 4
	public void Dispose() { }
}

