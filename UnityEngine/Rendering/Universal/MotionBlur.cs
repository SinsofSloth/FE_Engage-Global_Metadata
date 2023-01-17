// Namespace: UnityEngine.Rendering.Universal
[VolumeComponentMenu] // RVA: 0x47F6D0 Offset: 0x47F7D1 VA: 0x47F6D0
[Serializable]
public sealed class MotionBlur : VolumeComponent, IPostProcessComponent // TypeDefIndex: 5301
{
	// Fields
	[TooltipAttribute] // RVA: 0x482330 Offset: 0x482431 VA: 0x482330
	public MotionBlurModeParameter mode; // 0x38
	[TooltipAttribute] // RVA: 0x482370 Offset: 0x482471 VA: 0x482370
	public MotionBlurQualityParameter quality; // 0x40
	[TooltipAttribute] // RVA: 0x4823B0 Offset: 0x4824B1 VA: 0x4823B0
	public ClampedFloatParameter intensity; // 0x48
	[TooltipAttribute] // RVA: 0x4823F0 Offset: 0x4824F1 VA: 0x4823F0
	public ClampedFloatParameter clamp; // 0x50

	// Methods

	// RVA: 0x3362010 Offset: 0x3362111 VA: 0x3362010 Slot: 8
	public bool IsActive() { }

	// RVA: 0x3362090 Offset: 0x3362191 VA: 0x3362090 Slot: 9
	public bool IsTileCompatible() { }

	// RVA: 0x33620A0 Offset: 0x33621A1 VA: 0x33620A0
	public void .ctor() { }
}

