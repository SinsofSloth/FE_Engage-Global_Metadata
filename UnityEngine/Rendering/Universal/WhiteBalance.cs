// Namespace: UnityEngine.Rendering.Universal
[VolumeComponentMenu] // RVA: 0x47F850 Offset: 0x47F951 VA: 0x47F850
[Serializable]
public sealed class WhiteBalance : VolumeComponent, IPostProcessComponent // TypeDefIndex: 5311
{
	// Fields
	[TooltipAttribute] // RVA: 0x482A30 Offset: 0x482B31 VA: 0x482A30
	public ClampedFloatParameter temperature; // 0x38
	[TooltipAttribute] // RVA: 0x482A70 Offset: 0x482B71 VA: 0x482A70
	public ClampedFloatParameter tint; // 0x40

	// Methods

	// RVA: 0x2F9D800 Offset: 0x2F9D901 VA: 0x2F9D800 Slot: 8
	public bool IsActive() { }

	// RVA: 0x2F9D860 Offset: 0x2F9D961 VA: 0x2F9D860 Slot: 9
	public bool IsTileCompatible() { }

	// RVA: 0x2F9D870 Offset: 0x2F9D971 VA: 0x2F9D870
	public void .ctor() { }
}

