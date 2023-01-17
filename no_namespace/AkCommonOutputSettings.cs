// Namespace: 
[Serializable]
public class AkCommonOutputSettings // TypeDefIndex: 7939
{
	// Fields
	[TooltipAttribute] // RVA: 0x27D600 Offset: 0x27D701 VA: 0x27D600
	public string m_AudioDeviceShareset; // 0x10
	[TooltipAttribute] // RVA: 0x27D640 Offset: 0x27D741 VA: 0x27D640
	public uint m_DeviceID; // 0x18
	[TooltipAttribute] // RVA: 0x27D680 Offset: 0x27D781 VA: 0x27D680
	public AkCommonOutputSettings.PanningRule m_PanningRule; // 0x1C
	[TooltipAttribute] // RVA: 0x27D6C0 Offset: 0x27D7C1 VA: 0x27D6C0
	public AkCommonOutputSettings.ChannelConfiguration m_ChannelConfig; // 0x20

	// Methods

	// RVA: 0x316A7A0 Offset: 0x316A8A1 VA: 0x316A7A0
	public void CopyTo(AkOutputSettings settings) { }

	// RVA: 0x316ABA0 Offset: 0x316ACA1 VA: 0x316ABA0
	public void .ctor() { }
}

