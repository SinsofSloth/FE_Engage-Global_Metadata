// Namespace: UnityEngine.Rendering.Universal
[VolumeComponentMenu] // RVA: 0x47F710 Offset: 0x47F811 VA: 0x47F710
[Serializable]
public sealed class PaniniProjection : VolumeComponent, IPostProcessComponent // TypeDefIndex: 5304
{
	// Fields
	[TooltipAttribute] // RVA: 0x482430 Offset: 0x482531 VA: 0x482430
	public ClampedFloatParameter distance; // 0x38
	[TooltipAttribute] // RVA: 0x482470 Offset: 0x482571 VA: 0x482470
	public ClampedFloatParameter cropToFit; // 0x40

	// Methods

	// RVA: 0x3362390 Offset: 0x3362491 VA: 0x3362390 Slot: 8
	public bool IsActive() { }

	// RVA: 0x33623C0 Offset: 0x33624C1 VA: 0x33623C0 Slot: 9
	public bool IsTileCompatible() { }

	// RVA: 0x33623D0 Offset: 0x33624D1 VA: 0x33623D0
	public void .ctor() { }
}

