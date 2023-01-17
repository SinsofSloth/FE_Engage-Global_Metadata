// Namespace: UnityEngine.Rendering.Universal.Custom
[VolumeComponentMenu] // RVA: 0x47FF80 Offset: 0x480081 VA: 0x47FF80
[Serializable]
public sealed class CustomGradationFilter : VolumeComponent, IPostProcessComponent // TypeDefIndex: 5431
{
	// Fields
	[TooltipAttribute] // RVA: 0x4833B0 Offset: 0x4834B1 VA: 0x4833B0
	public ColorParameter color; // 0x38
	[TooltipAttribute] // RVA: 0x4833F0 Offset: 0x4834F1 VA: 0x4833F0
	public ClampedFloatParameter alpha; // 0x40
	[TooltipAttribute] // RVA: 0x483430 Offset: 0x483531 VA: 0x483430
	public Vector2Parameter vignetteCenter; // 0x48
	[TooltipAttribute] // RVA: 0x483470 Offset: 0x483571 VA: 0x483470
	public ClampedFloatParameter vignetteIntensity; // 0x50
	[TooltipAttribute] // RVA: 0x4834B0 Offset: 0x4835B1 VA: 0x4834B0
	public ClampedFloatParameter vignetteSmoothness; // 0x58

	// Methods

	// RVA: 0x2D373E0 Offset: 0x2D374E1 VA: 0x2D373E0 Slot: 8
	public bool IsActive() { }

	// RVA: 0x2D37440 Offset: 0x2D37541 VA: 0x2D37440 Slot: 9
	public bool IsTileCompatible() { }

	// RVA: 0x2D37450 Offset: 0x2D37551 VA: 0x2D37450
	public void .ctor() { }
}

