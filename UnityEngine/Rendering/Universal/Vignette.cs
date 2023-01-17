// Namespace: UnityEngine.Rendering.Universal
[VolumeComponentMenu] // RVA: 0x47F810 Offset: 0x47F911 VA: 0x47F810
[Serializable]
public sealed class Vignette : VolumeComponent, IPostProcessComponent // TypeDefIndex: 5310
{
	// Fields
	[TooltipAttribute] // RVA: 0x4828F0 Offset: 0x4829F1 VA: 0x4828F0
	public ColorParameter color; // 0x38
	[TooltipAttribute] // RVA: 0x482930 Offset: 0x482A31 VA: 0x482930
	public Vector2Parameter center; // 0x40
	[TooltipAttribute] // RVA: 0x482970 Offset: 0x482A71 VA: 0x482970
	public ClampedFloatParameter intensity; // 0x48
	[TooltipAttribute] // RVA: 0x4829B0 Offset: 0x482AB1 VA: 0x4829B0
	public ClampedFloatParameter smoothness; // 0x50
	[TooltipAttribute] // RVA: 0x4829F0 Offset: 0x482AF1 VA: 0x4829F0
	public BoolParameter rounded; // 0x58

	// Methods

	// RVA: 0x2F9D5E0 Offset: 0x2F9D6E1 VA: 0x2F9D5E0 Slot: 8
	public bool IsActive() { }

	// RVA: 0x2F9D610 Offset: 0x2F9D711 VA: 0x2F9D610 Slot: 9
	public bool IsTileCompatible() { }

	// RVA: 0x2F9D620 Offset: 0x2F9D721 VA: 0x2F9D620
	public void .ctor() { }
}

