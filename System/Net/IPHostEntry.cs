// Namespace: System.Net
public class IPHostEntry // TypeDefIndex: 2462
{
	// Fields
	private string hostName; // 0x10
	private string[] aliases; // 0x18
	private IPAddress[] addressList; // 0x20
	internal bool isTrustedHost; // 0x28

	// Properties
	public string HostName { get; set; }
	public string[] Aliases { set; }
	public IPAddress[] AddressList { get; set; }

	// Methods

	// RVA: 0x1ABEB90 Offset: 0x1ABEC91 VA: 0x1ABEB90
	public string get_HostName() { }

	// RVA: 0x1ABEBA0 Offset: 0x1ABECA1 VA: 0x1ABEBA0
	public void set_HostName(string value) { }

	// RVA: 0x1ABEBB0 Offset: 0x1ABECB1 VA: 0x1ABEBB0
	public void set_Aliases(string[] value) { }

	// RVA: 0x1ABEBC0 Offset: 0x1ABECC1 VA: 0x1ABEBC0
	public IPAddress[] get_AddressList() { }

	// RVA: 0x1ABEBD0 Offset: 0x1ABECD1 VA: 0x1ABEBD0
	public void set_AddressList(IPAddress[] value) { }

	// RVA: 0x1ABEBE0 Offset: 0x1ABECE1 VA: 0x1ABEBE0
	public void .ctor() { }
}

