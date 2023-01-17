// Namespace: System.Runtime.Remoting
internal class ChannelData // TypeDefIndex: 1101
{
	// Fields
	internal string Ref; // 0x10
	internal string Type; // 0x18
	internal string Id; // 0x20
	internal string DelayLoadAsClientChannel; // 0x28
	private ArrayList _serverProviders; // 0x30
	private ArrayList _clientProviders; // 0x38
	private Hashtable _customProperties; // 0x40

	// Properties
	internal ArrayList ServerProviders { get; }
	public ArrayList ClientProviders { get; }
	public Hashtable CustomProperties { get; }

	// Methods

	// RVA: 0x3519540 Offset: 0x3519641 VA: 0x3519540
	internal ArrayList get_ServerProviders() { }

	// RVA: 0x35195D0 Offset: 0x35196D1 VA: 0x35195D0
	public ArrayList get_ClientProviders() { }

	// RVA: 0x3519660 Offset: 0x3519761 VA: 0x3519660
	public Hashtable get_CustomProperties() { }

	// RVA: 0x35196F0 Offset: 0x35197F1 VA: 0x35196F0
	public void CopyFrom(ChannelData other) { }

	// RVA: 0x351A0A0 Offset: 0x351A1A1 VA: 0x351A0A0
	public void .ctor() { }
}

