// Namespace: UnityEngine.Rendering.Universal
[VolumeComponentMenu] // RVA: 0x47F7D0 Offset: 0x47F8D1 VA: 0x47F7D0
[Serializable]
public sealed class Tonemapping : VolumeComponent, IPostProcessComponent // TypeDefIndex: 5308
{
	// Fields
	[TooltipAttribute] // RVA: 0x482730 Offset: 0x482831 VA: 0x482730
	public TonemappingModeParameter mode; // 0x38
	[TooltipAttribute] // RVA: 0x482770 Offset: 0x482871 VA: 0x482770
	public ClampedFloatParameter toeStrength; // 0x40
	[TooltipAttribute] // RVA: 0x4827B0 Offset: 0x4828B1 VA: 0x4827B0
	public ClampedFloatParameter toeLength; // 0x48
	[TooltipAttribute] // RVA: 0x4827F0 Offset: 0x4828F1 VA: 0x4827F0
	public ClampedFloatParameter shoulderStrength; // 0x50
	[TooltipAttribute] // RVA: 0x482830 Offset: 0x482931 VA: 0x482830
	public MinFloatParameter shoulderLength; // 0x58
	[TooltipAttribute] // RVA: 0x482870 Offset: 0x482971 VA: 0x482870
	public ClampedFloatParameter shoulderAngle; // 0x60
	[TooltipAttribute] // RVA: 0x4828B0 Offset: 0x4829B1 VA: 0x4828B0
	public MinFloatParameter gamma; // 0x68

	// Methods

	// RVA: 0x2F902F0 Offset: 0x2F903F1 VA: 0x2F902F0 Slot: 8
	public bool IsActive() { }

	// RVA: 0x2F90320 Offset: 0x2F90421 VA: 0x2F90320 Slot: 9
	public bool IsTileCompatible() { }

	// RVA: 0x2F90330 Offset: 0x2F90431 VA: 0x2F90330
	public void .ctor() { }
}

