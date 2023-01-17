// Namespace: 
public class AkOutputSettings : IDisposable // TypeDefIndex: 7883
{
	// Fields
	private IntPtr swigCPtr; // 0x10
	protected bool swigCMemOwn; // 0x18

	// Properties
	public uint audioDeviceShareset { get; set; }
	public uint idDevice { get; set; }
	public AkPanningRule ePanningRule { get; set; }
	public AkChannelConfig channelConfig { get; set; }

	// Methods

	// RVA: 0x3178CE0 Offset: 0x3178DE1 VA: 0x3178CE0
	internal void .ctor(IntPtr cPtr, bool cMemoryOwn) { }

	// RVA: 0x3178C80 Offset: 0x3178D81 VA: 0x3178C80
	internal static IntPtr getCPtr(AkOutputSettings obj) { }

	// RVA: 0x3182830 Offset: 0x3182931 VA: 0x3182830 Slot: 5
	internal virtual void setCPtr(IntPtr cPtr) { }

	// RVA: 0x3182860 Offset: 0x3182961 VA: 0x3182860 Slot: 1
	protected override void Finalize() { }

	// RVA: 0x31828D0 Offset: 0x31829D1 VA: 0x31828D0 Slot: 6
	public virtual void Dispose() { }

	// RVA: 0x3182A60 Offset: 0x3182B61 VA: 0x3182A60
	public void .ctor() { }

	// RVA: 0x3182AF0 Offset: 0x3182BF1 VA: 0x3182AF0
	public void .ctor(string in_szDeviceShareSet, uint in_idDevice, AkChannelConfig in_channelConfig, AkPanningRule in_ePanning) { }

	// RVA: 0x3182BF0 Offset: 0x3182CF1 VA: 0x3182BF0
	public void .ctor(string in_szDeviceShareSet, uint in_idDevice, AkChannelConfig in_channelConfig) { }

	// RVA: 0x3182CE0 Offset: 0x3182DE1 VA: 0x3182CE0
	public void .ctor(string in_szDeviceShareSet, uint in_idDevice) { }

	// RVA: 0x3182D80 Offset: 0x3182E81 VA: 0x3182D80
	public void .ctor(string in_szDeviceShareSet) { }

	// RVA: 0x316A950 Offset: 0x316AA51 VA: 0x316A950
	public void set_audioDeviceShareset(uint value) { }

	// RVA: 0x3182E10 Offset: 0x3182F11 VA: 0x3182E10
	public uint get_audioDeviceShareset() { }

	// RVA: 0x316A9D0 Offset: 0x316AAD1 VA: 0x316A9D0
	public void set_idDevice(uint value) { }

	// RVA: 0x3182E80 Offset: 0x3182F81 VA: 0x3182E80
	public uint get_idDevice() { }

	// RVA: 0x316AA50 Offset: 0x316AB51 VA: 0x316AA50
	public void set_ePanningRule(AkPanningRule value) { }

	// RVA: 0x3182EF0 Offset: 0x3182FF1 VA: 0x3182EF0
	public AkPanningRule get_ePanningRule() { }

	// RVA: 0x3182F60 Offset: 0x3183061 VA: 0x3182F60
	public void set_channelConfig(AkChannelConfig value) { }

	// RVA: 0x316AAD0 Offset: 0x316ABD1 VA: 0x316AAD0
	public AkChannelConfig get_channelConfig() { }
}

