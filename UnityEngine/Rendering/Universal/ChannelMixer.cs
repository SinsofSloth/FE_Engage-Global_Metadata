// Namespace: UnityEngine.Rendering.Universal
[VolumeComponentMenu] // RVA: 0x47F490 Offset: 0x47F591 VA: 0x47F490
[Serializable]
public sealed class ChannelMixer : VolumeComponent, IPostProcessComponent // TypeDefIndex: 5286
{
	// Fields
	[TooltipAttribute] // RVA: 0x481930 Offset: 0x481A31 VA: 0x481930
	public ClampedFloatParameter redOutRedIn; // 0x38
	[TooltipAttribute] // RVA: 0x481970 Offset: 0x481A71 VA: 0x481970
	public ClampedFloatParameter redOutGreenIn; // 0x40
	[TooltipAttribute] // RVA: 0x4819B0 Offset: 0x481AB1 VA: 0x4819B0
	public ClampedFloatParameter redOutBlueIn; // 0x48
	[TooltipAttribute] // RVA: 0x4819F0 Offset: 0x481AF1 VA: 0x4819F0
	public ClampedFloatParameter greenOutRedIn; // 0x50
	[TooltipAttribute] // RVA: 0x481A30 Offset: 0x481B31 VA: 0x481A30
	public ClampedFloatParameter greenOutGreenIn; // 0x58
	[TooltipAttribute] // RVA: 0x481A70 Offset: 0x481B71 VA: 0x481A70
	public ClampedFloatParameter greenOutBlueIn; // 0x60
	[TooltipAttribute] // RVA: 0x481AB0 Offset: 0x481BB1 VA: 0x481AB0
	public ClampedFloatParameter blueOutRedIn; // 0x68
	[TooltipAttribute] // RVA: 0x481AF0 Offset: 0x481BF1 VA: 0x481AF0
	public ClampedFloatParameter blueOutGreenIn; // 0x70
	[TooltipAttribute] // RVA: 0x481B30 Offset: 0x481C31 VA: 0x481B30
	public ClampedFloatParameter blueOutBlueIn; // 0x78

	// Methods

	// RVA: 0x2D29F50 Offset: 0x2D2A051 VA: 0x2D29F50 Slot: 8
	public bool IsActive() { }

	// RVA: 0x2D2A070 Offset: 0x2D2A171 VA: 0x2D2A070 Slot: 9
	public bool IsTileCompatible() { }

	// RVA: 0x2D2A080 Offset: 0x2D2A181 VA: 0x2D2A080
	public void .ctor() { }
}

