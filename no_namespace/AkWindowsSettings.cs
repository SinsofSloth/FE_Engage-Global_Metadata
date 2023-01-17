// Namespace: 
public enum AkWindowsSettings.PlatformAdvancedSettings.AudioAPI // TypeDefIndex: 7998
{
	// Fields
	public int value__; // 0x0
	public const AkWindowsSettings.PlatformAdvancedSettings.AudioAPI None = 0;
	public const AkWindowsSettings.PlatformAdvancedSettings.AudioAPI Wasapi = 1;
	public const AkWindowsSettings.PlatformAdvancedSettings.AudioAPI XAudio2 = 2;
	public const AkWindowsSettings.PlatformAdvancedSettings.AudioAPI DirectSound = 4;
	public const AkWindowsSettings.PlatformAdvancedSettings.AudioAPI Default = -1;
}

// Namespace: 
[Serializable]
public class AkWindowsSettings.PlatformAdvancedSettings : AkCommonAdvancedSettings // TypeDefIndex: 7999
{
	// Fields
	[TooltipAttribute] // RVA: 0x27E740 Offset: 0x27E841 VA: 0x27E740
	[AkEnumFlagAttribute] // RVA: 0x27E740 Offset: 0x27E841 VA: 0x27E740
	public AkWindowsSettings.PlatformAdvancedSettings.AudioAPI m_AudioAPI; // 0x54
	[TooltipAttribute] // RVA: 0x27E7D0 Offset: 0x27E8D1 VA: 0x27E7D0
	public bool m_GlobalFocus; // 0x58

	// Methods

	// RVA: 0x1F5BE70 Offset: 0x1F5BF71 VA: 0x1F5BE70 Slot: 6
	public override void CopyTo(AkPlatformInitSettings settings) { }

	// RVA: 0x1F5BE80 Offset: 0x1F5BF81 VA: 0x1F5BE80
	public void .ctor() { }
}

// Namespace: 
public class AkWindowsSettings : AkWwiseInitializationSettings.PlatformSettings // TypeDefIndex: 8000
{
	// Fields
	[HideInInspector] // RVA: 0x27E710 Offset: 0x27E811 VA: 0x27E710
	public AkCommonUserSettings UserSettings; // 0x30
	[HideInInspector] // RVA: 0x27E720 Offset: 0x27E821 VA: 0x27E720
	public AkWindowsSettings.PlatformAdvancedSettings AdvancedSettings; // 0x38
	[HideInInspector] // RVA: 0x27E730 Offset: 0x27E831 VA: 0x27E730
	public AkCommonCommSettings CommsSettings; // 0x40

	// Methods

	// RVA: 0x20E0490 Offset: 0x20E0591 VA: 0x20E0490 Slot: 13
	protected override AkCommonUserSettings GetUserSettings() { }

	// RVA: 0x20E04A0 Offset: 0x20E05A1 VA: 0x20E04A0 Slot: 14
	protected override AkCommonAdvancedSettings GetAdvancedSettings() { }

	// RVA: 0x20E04B0 Offset: 0x20E05B1 VA: 0x20E04B0 Slot: 15
	protected override AkCommonCommSettings GetCommsSettings() { }

	// RVA: 0x20E04C0 Offset: 0x20E05C1 VA: 0x20E04C0
	public void .ctor() { }
}

