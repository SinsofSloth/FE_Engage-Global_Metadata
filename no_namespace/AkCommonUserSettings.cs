// Namespace: 
public enum AkCommonUserSettings.SpatialAudioSettings.DiffractionFlags // TypeDefIndex: 7940
{
	// Fields
	public int value__; // 0x0
	public const AkCommonUserSettings.SpatialAudioSettings.DiffractionFlags UseBuiltInParam = 1;
	public const AkCommonUserSettings.SpatialAudioSettings.DiffractionFlags UseObstruction = 2;
	public const AkCommonUserSettings.SpatialAudioSettings.DiffractionFlags CalcEmitterVirtualPosition = 8;
}

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

// Namespace: 
[Serializable]
public class AkCommonUserSettings // TypeDefIndex: 7942
{
	// Fields
	[TooltipAttribute] // RVA: 0x27D810 Offset: 0x27D911 VA: 0x27D810
	public string m_BasePath; // 0x10
	[TooltipAttribute] // RVA: 0x27D850 Offset: 0x27D951 VA: 0x27D850
	public string m_StartupLanguage; // 0x18
	[TooltipAttribute] // RVA: 0x27D890 Offset: 0x27D991 VA: 0x27D890
	public bool m_EngineLogging; // 0x20
	[TooltipAttribute] // RVA: 0x27D8D0 Offset: 0x27D9D1 VA: 0x27D8D0
	public uint m_MaximumNumberOfPositioningPaths; // 0x24
	[TooltipAttribute] // RVA: 0x27D910 Offset: 0x27DA11 VA: 0x27D910
	public uint m_CommandQueueSize; // 0x28
	[TooltipAttribute] // RVA: 0x27D950 Offset: 0x27DA51 VA: 0x27D950
	public uint m_SamplesPerFrame; // 0x2C
	[TooltipAttribute] // RVA: 0x27D990 Offset: 0x27DA91 VA: 0x27D990
	public AkCommonOutputSettings m_MainOutputSettings; // 0x30
	[RangeAttribute] // RVA: 0x27D9D0 Offset: 0x27DAD1 VA: 0x27D9D0
	[TooltipAttribute] // RVA: 0x27D9D0 Offset: 0x27DAD1 VA: 0x27D9D0
	public float m_StreamingLookAheadRatio; // 0x38
	[TooltipAttribute] // RVA: 0x27DA30 Offset: 0x27DB31 VA: 0x27DA30
	public uint m_SampleRate; // 0x3C
	[TooltipAttribute] // RVA: 0x27DA70 Offset: 0x27DB71 VA: 0x27DA70
	public ushort m_NumberOfRefillsInVoice; // 0x40
	[TooltipAttribute] // RVA: 0x27DAB0 Offset: 0x27DBB1 VA: 0x27DAB0
	public AkCommonUserSettings.SpatialAudioSettings m_SpatialAudioSettings; // 0x48

	// Methods

	// RVA: 0x316CCA0 Offset: 0x316CDA1 VA: 0x316CCA0
	protected static string GetPluginPath() { }

	// RVA: 0x316CD60 Offset: 0x316CE61 VA: 0x316CD60 Slot: 4
	public virtual void CopyTo(AkInitSettings settings) { }

	// RVA: 0x316C870 Offset: 0x316C971 VA: 0x316C870
	public void CopyTo(AkMusicSettings settings) { }

	// RVA: 0x316C6C0 Offset: 0x316C7C1 VA: 0x316C6C0
	public void CopyTo(AkStreamMgrSettings settings) { }

	// RVA: 0x316D3A0 Offset: 0x316D4A1 VA: 0x316D3A0 Slot: 5
	public virtual void CopyTo(AkDeviceSettings settings) { }

	// RVA: 0x316D3B0 Offset: 0x316D4B1 VA: 0x316D3B0
	private void SetSampleRate(AkPlatformInitSettings settings) { }

	// RVA: 0x316D4B0 Offset: 0x316D5B1 VA: 0x316D4B0 Slot: 6
	public virtual void CopyTo(AkPlatformInitSettings settings) { }

	// RVA: 0x316D610 Offset: 0x316D711 VA: 0x316D610 Slot: 7
	public virtual void CopyTo(AkSpatialAudioInitSettings settings) { }

	// RVA: 0x316D6E0 Offset: 0x316D7E1 VA: 0x316D6E0 Slot: 8
	public virtual void CopyTo(AkUnityPlatformSpecificSettings settings) { }

	// RVA: 0x316D6F0 Offset: 0x316D7F1 VA: 0x316D6F0 Slot: 9
	public virtual void Validate() { }

	// RVA: 0x316D730 Offset: 0x316D831 VA: 0x316D730
	public void .ctor() { }
}

