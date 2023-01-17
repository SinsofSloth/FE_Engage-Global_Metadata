// Namespace: UnityEngine.Rendering.Universal
[VolumeComponentMenu] // RVA: 0x47F510 Offset: 0x47F611 VA: 0x47F510
[Serializable]
public sealed class ColorAdjustments : VolumeComponent, IPostProcessComponent // TypeDefIndex: 5288
{
	// Fields
	[TooltipAttribute] // RVA: 0x481BB0 Offset: 0x481CB1 VA: 0x481BB0
	public FloatParameter postExposure; // 0x38
	[TooltipAttribute] // RVA: 0x481BF0 Offset: 0x481CF1 VA: 0x481BF0
	public ClampedFloatParameter contrast; // 0x40
	[TooltipAttribute] // RVA: 0x481C30 Offset: 0x481D31 VA: 0x481C30
	public ColorParameter colorFilter; // 0x48
	[TooltipAttribute] // RVA: 0x481C70 Offset: 0x481D71 VA: 0x481C70
	public ClampedFloatParameter hueShift; // 0x50
	[TooltipAttribute] // RVA: 0x481CB0 Offset: 0x481DB1 VA: 0x481CB0
	public ClampedFloatParameter saturation; // 0x58

	// Methods

	// RVA: 0x2D2A440 Offset: 0x2D2A541 VA: 0x2D2A440 Slot: 8
	public bool IsActive() { }

	// RVA: 0x2D2A520 Offset: 0x2D2A621 VA: 0x2D2A520 Slot: 9
	public bool IsTileCompatible() { }

	// RVA: 0x2D2A530 Offset: 0x2D2A631 VA: 0x2D2A530
	public void .ctor() { }
}

