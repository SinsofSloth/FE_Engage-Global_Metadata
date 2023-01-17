// Namespace: UnityEngine.Rendering.Universal.Custom
[VolumeComponentMenu] // RVA: 0x480000 Offset: 0x480101 VA: 0x480000
[Serializable]
public sealed class CustomRadialBlur : VolumeComponent, IPostProcessComponent // TypeDefIndex: 5434
{
	// Fields
	[TooltipAttribute] // RVA: 0x483680 Offset: 0x483781 VA: 0x483680
	public ClampedFloatParameter intensity; // 0x38
	[TooltipAttribute] // RVA: 0x4836C0 Offset: 0x4837C1 VA: 0x4836C0
	public ClampedFloatParameter centerU; // 0x40
	[TooltipAttribute] // RVA: 0x483700 Offset: 0x483801 VA: 0x483700
	public ClampedFloatParameter centerV; // 0x48
	[TooltipAttribute] // RVA: 0x483740 Offset: 0x483841 VA: 0x483740
	public ClampedFloatParameter beginAlpha; // 0x50
	[TooltipAttribute] // RVA: 0x483780 Offset: 0x483881 VA: 0x483780
	public ClampedFloatParameter endAlpha; // 0x58
	[TooltipAttribute] // RVA: 0x4837C0 Offset: 0x4838C1 VA: 0x4837C0
	public ClampedIntParameter sampleCount; // 0x60

	// Methods

	// RVA: 0x2D39430 Offset: 0x2D39531 VA: 0x2D39430 Slot: 8
	public bool IsActive() { }

	// RVA: 0x2D39460 Offset: 0x2D39561 VA: 0x2D39460 Slot: 9
	public bool IsTileCompatible() { }

	// RVA: 0x2D39470 Offset: 0x2D39571 VA: 0x2D39470
	public void .ctor() { }
}

