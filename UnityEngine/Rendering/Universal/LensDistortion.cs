// Namespace: UnityEngine.Rendering.Universal
[VolumeComponentMenu] // RVA: 0x47F650 Offset: 0x47F751 VA: 0x47F650
[Serializable]
public sealed class LensDistortion : VolumeComponent, IPostProcessComponent // TypeDefIndex: 5297
{
	// Fields
	[TooltipAttribute] // RVA: 0x482130 Offset: 0x482231 VA: 0x482130
	public ClampedFloatParameter intensity; // 0x38
	[TooltipAttribute] // RVA: 0x482170 Offset: 0x482271 VA: 0x482170
	public ClampedFloatParameter xMultiplier; // 0x40
	[TooltipAttribute] // RVA: 0x4821B0 Offset: 0x4822B1 VA: 0x4821B0
	public ClampedFloatParameter yMultiplier; // 0x48
	[TooltipAttribute] // RVA: 0x4821F0 Offset: 0x4822F1 VA: 0x4821F0
	public Vector2Parameter center; // 0x50
	[TooltipAttribute] // RVA: 0x482230 Offset: 0x482331 VA: 0x482230
	public ClampedFloatParameter scale; // 0x58

	// Methods

	// RVA: 0x3149650 Offset: 0x3149751 VA: 0x3149650 Slot: 8
	public bool IsActive() { }

	// RVA: 0x31496D0 Offset: 0x31497D1 VA: 0x31496D0 Slot: 9
	public bool IsTileCompatible() { }

	// RVA: 0x31496E0 Offset: 0x31497E1 VA: 0x31496E0
	public void .ctor() { }
}

