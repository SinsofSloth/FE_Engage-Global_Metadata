// Namespace: UnityEngine.Rendering.Universal
[VolumeComponentMenu] // RVA: 0x47F450 Offset: 0x47F551 VA: 0x47F450
[Serializable]
public sealed class Bloom : VolumeComponent, IPostProcessComponent // TypeDefIndex: 5285
{
	// Fields
	[TooltipAttribute] // RVA: 0x4816F0 Offset: 0x4817F1 VA: 0x4816F0
	public MinFloatParameter threshold; // 0x38
	[TooltipAttribute] // RVA: 0x481730 Offset: 0x481831 VA: 0x481730
	public MinFloatParameter intensity; // 0x40
	[TooltipAttribute] // RVA: 0x481770 Offset: 0x481871 VA: 0x481770
	public ClampedFloatParameter scatter; // 0x48
	[TooltipAttribute] // RVA: 0x4817B0 Offset: 0x4818B1 VA: 0x4817B0
	public MinFloatParameter clamp; // 0x50
	[TooltipAttribute] // RVA: 0x4817F0 Offset: 0x4818F1 VA: 0x4817F0
	public ColorParameter tint; // 0x58
	[TooltipAttribute] // RVA: 0x481830 Offset: 0x481931 VA: 0x481830
	public BoolParameter highQualityFiltering; // 0x60
	[TooltipAttribute] // RVA: 0x481870 Offset: 0x481971 VA: 0x481870
	public ClampedIntParameter skipIterations; // 0x68
	[TooltipAttribute] // RVA: 0x4818B0 Offset: 0x4819B1 VA: 0x4818B0
	public TextureParameter dirtTexture; // 0x70
	[TooltipAttribute] // RVA: 0x4818F0 Offset: 0x4819F1 VA: 0x4818F0
	public MinFloatParameter dirtIntensity; // 0x78

	// Methods

	// RVA: 0x2D28F80 Offset: 0x2D29081 VA: 0x2D28F80 Slot: 8
	public bool IsActive() { }

	// RVA: 0x2D28FB0 Offset: 0x2D290B1 VA: 0x2D28FB0 Slot: 9
	public bool IsTileCompatible() { }

	// RVA: 0x2D28FC0 Offset: 0x2D290C1 VA: 0x2D28FC0
	public void .ctor() { }
}

