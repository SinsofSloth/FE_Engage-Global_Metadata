// Namespace: UnityEngine.Rendering.Universal
[VolumeComponentMenu] // RVA: 0x47F750 Offset: 0x47F851 VA: 0x47F750
[Serializable]
public sealed class ShadowsMidtonesHighlights : VolumeComponent, IPostProcessComponent // TypeDefIndex: 5305
{
	// Fields
	[TooltipAttribute] // RVA: 0x4824B0 Offset: 0x4825B1 VA: 0x4824B0
	public Vector4Parameter shadows; // 0x38
	[TooltipAttribute] // RVA: 0x4824F0 Offset: 0x4825F1 VA: 0x4824F0
	public Vector4Parameter midtones; // 0x40
	[TooltipAttribute] // RVA: 0x482530 Offset: 0x482631 VA: 0x482530
	public Vector4Parameter highlights; // 0x48
	[TooltipAttribute] // RVA: 0x482570 Offset: 0x482671 VA: 0x482570
	public MinFloatParameter shadowsStart; // 0x50
	[TooltipAttribute] // RVA: 0x4825B0 Offset: 0x4826B1 VA: 0x4825B0
	public MinFloatParameter shadowsEnd; // 0x58
	[TooltipAttribute] // RVA: 0x4825F0 Offset: 0x4826F1 VA: 0x4825F0
	public MinFloatParameter highlightsStart; // 0x60
	[TooltipAttribute] // RVA: 0x482630 Offset: 0x482731 VA: 0x482630
	public MinFloatParameter highlightsEnd; // 0x68

	// Methods

	// RVA: 0x3135590 Offset: 0x3135691 VA: 0x3135590 Slot: 8
	public bool IsActive() { }

	// RVA: 0x3135660 Offset: 0x3135761 VA: 0x3135660 Slot: 9
	public bool IsTileCompatible() { }

	// RVA: 0x3135670 Offset: 0x3135771 VA: 0x3135670
	public void .ctor() { }
}

