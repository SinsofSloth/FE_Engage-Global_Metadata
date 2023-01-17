// Namespace: UnityEngine.Rendering.Universal.Custom
[VolumeComponentMenu] // RVA: 0x47FED0 Offset: 0x47FFD1 VA: 0x47FED0
[Serializable]
public sealed class CustomColorGrading : VolumeComponent, IPostProcessComponent // TypeDefIndex: 5420
{
	// Fields
	[TooltipAttribute] // RVA: 0x483290 Offset: 0x483391 VA: 0x483290
	public MinFloatParameter begin; // 0x38
	[TooltipAttribute] // RVA: 0x4832D0 Offset: 0x4833D1 VA: 0x4832D0
	public MinFloatParameter end; // 0x40
	[TooltipAttribute] // RVA: 0x483310 Offset: 0x483411 VA: 0x483310
	public ClampedFloatParameter expLevel; // 0x48
	[TooltipAttribute] // RVA: 0x483350 Offset: 0x483451 VA: 0x483350
	public BoolParameter debugFlag; // 0x50

	// Methods

	// RVA: 0x2D30F60 Offset: 0x2D31061 VA: 0x2D30F60 Slot: 8
	public bool IsActive() { }

	// RVA: 0x2D30FE0 Offset: 0x2D310E1 VA: 0x2D30FE0 Slot: 9
	public bool IsTileCompatible() { }

	// RVA: 0x2D30FF0 Offset: 0x2D310F1 VA: 0x2D30FF0
	public void .ctor() { }
}

