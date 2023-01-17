// Namespace: UnityEngine.Rendering.Universal
[VolumeComponentMenu] // RVA: 0x47F5D0 Offset: 0x47F6D1 VA: 0x47F5D0
[Serializable]
public sealed class DepthOfField : VolumeComponent, IPostProcessComponent // TypeDefIndex: 5292
{
	// Fields
	[TooltipAttribute] // RVA: 0x481D70 Offset: 0x481E71 VA: 0x481D70
	public DepthOfFieldModeParameter mode; // 0x38
	[TooltipAttribute] // RVA: 0x481DB0 Offset: 0x481EB1 VA: 0x481DB0
	public MinFloatParameter gaussianStart; // 0x40
	[TooltipAttribute] // RVA: 0x481DF0 Offset: 0x481EF1 VA: 0x481DF0
	public MinFloatParameter gaussianEnd; // 0x48
	[TooltipAttribute] // RVA: 0x481E30 Offset: 0x481F31 VA: 0x481E30
	public ClampedFloatParameter gaussianMaxRadius; // 0x50
	[TooltipAttribute] // RVA: 0x481E70 Offset: 0x481F71 VA: 0x481E70
	public BoolParameter highQualitySampling; // 0x58
	[TooltipAttribute] // RVA: 0x481EB0 Offset: 0x481FB1 VA: 0x481EB0
	public MinFloatParameter focusDistance; // 0x60
	[TooltipAttribute] // RVA: 0x481EF0 Offset: 0x481FF1 VA: 0x481EF0
	public ClampedFloatParameter aperture; // 0x68
	[TooltipAttribute] // RVA: 0x481F30 Offset: 0x482031 VA: 0x481F30
	public ClampedFloatParameter focalLength; // 0x70
	[TooltipAttribute] // RVA: 0x481F70 Offset: 0x482071 VA: 0x481F70
	public ClampedIntParameter bladeCount; // 0x78
	[TooltipAttribute] // RVA: 0x481FB0 Offset: 0x4820B1 VA: 0x481FB0
	public ClampedFloatParameter bladeCurvature; // 0x80
	[TooltipAttribute] // RVA: 0x481FF0 Offset: 0x4820F1 VA: 0x481FF0
	public ClampedFloatParameter bladeRotation; // 0x88

	// Methods

	// RVA: 0x313F790 Offset: 0x313F891 VA: 0x313F790 Slot: 8
	public bool IsActive() { }

	// RVA: 0x313F820 Offset: 0x313F921 VA: 0x313F820 Slot: 9
	public bool IsTileCompatible() { }

	// RVA: 0x313F830 Offset: 0x313F931 VA: 0x313F830
	public void .ctor() { }
}

