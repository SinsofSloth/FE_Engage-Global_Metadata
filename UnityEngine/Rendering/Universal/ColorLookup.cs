// Namespace: UnityEngine.Rendering.Universal
[VolumeComponentMenu] // RVA: 0x47F590 Offset: 0x47F691 VA: 0x47F590
[Serializable]
public sealed class ColorLookup : VolumeComponent, IPostProcessComponent // TypeDefIndex: 5290
{
	// Fields
	[TooltipAttribute] // RVA: 0x481CF0 Offset: 0x481DF1 VA: 0x481CF0
	public TextureParameter texture; // 0x38
	[TooltipAttribute] // RVA: 0x481D30 Offset: 0x481E31 VA: 0x481D30
	public ClampedFloatParameter contribution; // 0x40

	// Methods

	// RVA: 0x2D2C420 Offset: 0x2D2C521 VA: 0x2D2C420 Slot: 8
	public bool IsActive() { }

	// RVA: 0x2D2C690 Offset: 0x2D2C791 VA: 0x2D2C690 Slot: 9
	public bool IsTileCompatible() { }

	// RVA: 0x2D2C470 Offset: 0x2D2C571 VA: 0x2D2C470
	public bool ValidateLUT() { }

	// RVA: 0x2D2C6A0 Offset: 0x2D2C7A1 VA: 0x2D2C6A0
	public void .ctor() { }
}

