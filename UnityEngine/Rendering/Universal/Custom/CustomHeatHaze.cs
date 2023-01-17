// Namespace: UnityEngine.Rendering.Universal.Custom
[VolumeComponentMenu] // RVA: 0x47FFC0 Offset: 0x4800C1 VA: 0x47FFC0
[Serializable]
public sealed class CustomHeatHaze : VolumeComponent, IPostProcessComponent // TypeDefIndex: 5432
{
	// Fields
	[TooltipAttribute] // RVA: 0x4834F0 Offset: 0x4835F1 VA: 0x4834F0
	public ClampedFloatParameter intensity; // 0x38
	[TooltipAttribute] // RVA: 0x483530 Offset: 0x483631 VA: 0x483530
	public ClampedFloatParameter cycle; // 0x40
	[TooltipAttribute] // RVA: 0x483570 Offset: 0x483671 VA: 0x483570
	public ClampedFloatParameter cycleU; // 0x48
	[TooltipAttribute] // RVA: 0x4835B0 Offset: 0x4836B1 VA: 0x4835B0
	public ClampedFloatParameter cycleV; // 0x50
	[TooltipAttribute] // RVA: 0x4835F0 Offset: 0x4836F1 VA: 0x4835F0
	public MinFloatParameter beginToApply; // 0x58
	[TooltipAttribute] // RVA: 0x483630 Offset: 0x483731 VA: 0x483630
	public MinFloatParameter beginFadeWidth; // 0x60

	// Methods

	// RVA: 0x2D37630 Offset: 0x2D37731 VA: 0x2D37630 Slot: 8
	public bool IsActive() { }

	// RVA: 0x2D37660 Offset: 0x2D37761 VA: 0x2D37660 Slot: 9
	public bool IsTileCompatible() { }

	// RVA: 0x2D37670 Offset: 0x2D37771 VA: 0x2D37670
	public void .ctor() { }
}

