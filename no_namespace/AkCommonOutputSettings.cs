// Namespace: 
public enum AkCommonOutputSettings.ChannelConfiguration.ChannelConfigType // TypeDefIndex: 7936
{
	// Fields
	public int value__; // 0x0
	public const AkCommonOutputSettings.ChannelConfiguration.ChannelConfigType Anonymous = 0;
	public const AkCommonOutputSettings.ChannelConfiguration.ChannelConfigType Standard = 1;
	public const AkCommonOutputSettings.ChannelConfiguration.ChannelConfigType Ambisonic = 2;
}

// Namespace: 
[Serializable]
public class AkCommonOutputSettings.ChannelConfiguration // TypeDefIndex: 7938
{
	// Fields
	[TooltipAttribute] // RVA: 0x27D700 Offset: 0x27D801 VA: 0x27D700
	public AkCommonOutputSettings.ChannelConfiguration.ChannelConfigType m_ChannelConfigType; // 0x10
	[AkEnumFlagAttribute] // RVA: 0x27D740 Offset: 0x27D841 VA: 0x27D740
	[TooltipAttribute] // RVA: 0x27D740 Offset: 0x27D841 VA: 0x27D740
	public AkCommonOutputSettings.ChannelConfiguration.ChannelMask m_ChannelMask; // 0x14
	[TooltipAttribute] // RVA: 0x27D7D0 Offset: 0x27D8D1 VA: 0x27D7D0
	public uint m_NumberOfChannels; // 0x18

	// Methods

	// RVA: 0x24B3380 Offset: 0x24B3481 VA: 0x24B3380
	public void CopyTo(AkChannelConfig config) { }

	// RVA: 0x24B33E0 Offset: 0x24B34E1 VA: 0x24B33E0
	public void .ctor() { }
}

