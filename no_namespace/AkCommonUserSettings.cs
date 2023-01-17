// Namespace: 
[Serializable]
public class AkCommonUserSettings.SpatialAudioSettings // TypeDefIndex: 7941
{
	// Fields
	[RangeAttribute] // RVA: 0x27DAF0 Offset: 0x27DBF1 VA: 0x27DAF0
	[TooltipAttribute] // RVA: 0x27DAF0 Offset: 0x27DBF1 VA: 0x27DAF0
	public uint m_MaxSoundPropagationDepth; // 0x10
	[TooltipAttribute] // RVA: 0x27DB50 Offset: 0x27DC51 VA: 0x27DB50
	[AkEnumFlagAttribute] // RVA: 0x27DB50 Offset: 0x27DC51 VA: 0x27DB50
	public AkCommonUserSettings.SpatialAudioSettings.DiffractionFlags m_DiffractionFlags; // 0x14
	[TooltipAttribute] // RVA: 0x27DBE0 Offset: 0x27DCE1 VA: 0x27DBE0
	public float m_MovementThreshold; // 0x18
	[TooltipAttribute] // RVA: 0x27DC20 Offset: 0x27DD21 VA: 0x27DC20
	public uint m_NumberOfPrimaryRays; // 0x1C
	[FormerlySerializedAsAttribute] // RVA: 0x27DC60 Offset: 0x27DD61 VA: 0x27DC60
	[RangeAttribute] // RVA: 0x27DC60 Offset: 0x27DD61 VA: 0x27DC60
	[TooltipAttribute] // RVA: 0x27DC60 Offset: 0x27DD61 VA: 0x27DC60
	public uint m_MaxReflectionOrder; // 0x20
	[TooltipAttribute] // RVA: 0x27DCE0 Offset: 0x27DDE1 VA: 0x27DCE0
	public float m_MaxPathLength; // 0x24
	[TooltipAttribute] // RVA: 0x27DD20 Offset: 0x27DE21 VA: 0x27DD20
	[FormerlySerializedAsAttribute] // RVA: 0x27DD20 Offset: 0x27DE21 VA: 0x27DD20
	public bool m_EnableDiffractionOnReflections; // 0x28
	[TooltipAttribute] // RVA: 0x27DD80 Offset: 0x27DE81 VA: 0x27DD80
	public bool m_EnableDirectPathDiffraction; // 0x29
	[TooltipAttribute] // RVA: 0x27DDC0 Offset: 0x27DEC1 VA: 0x27DDC0
	public bool m_EnableTransmission; // 0x2A

	// Methods

	// RVA: 0x24B33F0 Offset: 0x24B34F1 VA: 0x24B33F0
	public void .ctor() { }
}

