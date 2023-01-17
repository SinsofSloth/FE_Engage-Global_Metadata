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

