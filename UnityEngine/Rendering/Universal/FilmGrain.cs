// Namespace: UnityEngine.Rendering.Universal
[VolumeComponentMenu] // RVA: 0x47F610 Offset: 0x47F711 VA: 0x47F610
[Serializable]
public sealed class FilmGrain : VolumeComponent, IPostProcessComponent // TypeDefIndex: 5295
{
	// Fields
	[TooltipAttribute] // RVA: 0x482030 Offset: 0x482131 VA: 0x482030
	public FilmGrainLookupParameter type; // 0x38
	[TooltipAttribute] // RVA: 0x482070 Offset: 0x482171 VA: 0x482070
	public ClampedFloatParameter intensity; // 0x40
	[TooltipAttribute] // RVA: 0x4820B0 Offset: 0x4821B1 VA: 0x4820B0
	public ClampedFloatParameter response; // 0x48
	[TooltipAttribute] // RVA: 0x4820F0 Offset: 0x4821F1 VA: 0x4820F0
	public NoInterpTextureParameter texture; // 0x50

	// Methods

	// RVA: 0x31414C0 Offset: 0x31415C1 VA: 0x31414C0 Slot: 8
	public bool IsActive() { }

	// RVA: 0x3141590 Offset: 0x3141691 VA: 0x3141590 Slot: 9
	public bool IsTileCompatible() { }

	// RVA: 0x31415A0 Offset: 0x31416A1 VA: 0x31415A0
	public void .ctor() { }
}

