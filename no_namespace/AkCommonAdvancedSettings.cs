// Namespace: 
[Serializable]
public class AkCommonAdvancedSettings // TypeDefIndex: 7944
{
	// Fields
	[TooltipAttribute] // RVA: 0x27DE00 Offset: 0x27DF01 VA: 0x27DE00
	public uint m_IOMemorySize; // 0x10
	[TooltipAttribute] // RVA: 0x27DE40 Offset: 0x27DF41 VA: 0x27DE40
	public float m_TargetAutoStreamBufferLengthMs; // 0x14
	[TooltipAttribute] // RVA: 0x27DE80 Offset: 0x27DF81 VA: 0x27DE80
	public bool m_UseStreamCache; // 0x18
	[TooltipAttribute] // RVA: 0x27DEC0 Offset: 0x27DFC1 VA: 0x27DEC0
	public uint m_MaximumPinnedBytesInCache; // 0x1C
	[TooltipAttribute] // RVA: 0x27DF00 Offset: 0x27E001 VA: 0x27DF00
	public bool m_EnableGameSyncPreparation; // 0x20
	[TooltipAttribute] // RVA: 0x27DF40 Offset: 0x27E041 VA: 0x27DF40
	public uint m_ContinuousPlaybackLookAhead; // 0x24
	[TooltipAttribute] // RVA: 0x27DF80 Offset: 0x27E081 VA: 0x27DF80
	public uint m_MonitorQueuePoolSize; // 0x28
	[TooltipAttribute] // RVA: 0x27DFC0 Offset: 0x27E0C1 VA: 0x27DFC0
	public uint m_MaximumHardwareTimeoutMs; // 0x2C
	[TooltipAttribute] // RVA: 0x27E000 Offset: 0x27E101 VA: 0x27E000
	public bool m_DebugOutOfRangeCheckEnabled; // 0x30
	[TooltipAttribute] // RVA: 0x27E040 Offset: 0x27E141 VA: 0x27E040
	public float m_DebugOutOfRangeLimit; // 0x34
	[TooltipAttribute] // RVA: 0x27E080 Offset: 0x27E181 VA: 0x27E080
	public AkCommonAdvancedSettings.SpatialAudioSettings m_SpatialAudioSettings; // 0x38
	[TooltipAttribute] // RVA: 0x27E0C0 Offset: 0x27E1C1 VA: 0x27E0C0
	public bool m_RenderDuringFocusLoss; // 0x40
	[TooltipAttribute] // RVA: 0x27E100 Offset: 0x27E201 VA: 0x27E100
	public string m_SoundBankPersistentDataPath; // 0x48
	[TooltipAttribute] // RVA: 0x27E140 Offset: 0x27E241 VA: 0x27E140
	public bool m_UseAsyncOpen; // 0x50

	// Methods

	// RVA: 0x3169600 Offset: 0x3169701 VA: 0x3169600 Slot: 4
	public virtual void CopyTo(AkDeviceSettings settings) { }

	// RVA: 0x3169980 Offset: 0x3169A81 VA: 0x3169980 Slot: 5
	public virtual void CopyTo(AkInitSettings settings) { }

	// RVA: 0x3169EB0 Offset: 0x3169FB1 VA: 0x3169EB0 Slot: 6
	public virtual void CopyTo(AkPlatformInitSettings settings) { }

	// RVA: 0x3169EC0 Offset: 0x3169FC1 VA: 0x3169EC0 Slot: 7
	public virtual void CopyTo(AkSpatialAudioInitSettings settings) { }

	// RVA: 0x3169F10 Offset: 0x316A011 VA: 0x3169F10 Slot: 8
	public virtual void CopyTo(AkUnityPlatformSpecificSettings settings) { }

	// RVA: 0x3169F20 Offset: 0x316A021 VA: 0x3169F20 Slot: 9
	public virtual void Validate() { }

	// RVA: 0x316A040 Offset: 0x316A141 VA: 0x316A040
	public void .ctor() { }
}

