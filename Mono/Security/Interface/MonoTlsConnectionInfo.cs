// Namespace: Mono.Security.Interface
public class MonoTlsConnectionInfo // TypeDefIndex: 1560
{
	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x859D0 Offset: 0x85AD1 VA: 0x859D0
	private CipherSuiteCode <CipherSuiteCode>k__BackingField; // 0x10
	[CompilerGeneratedAttribute] // RVA: 0x859E0 Offset: 0x85AE1 VA: 0x859E0
	private TlsProtocols <ProtocolVersion>k__BackingField; // 0x14
	[CompilerGeneratedAttribute] // RVA: 0x859F0 Offset: 0x85AF1 VA: 0x859F0
	private string <PeerDomainName>k__BackingField; // 0x18

	// Properties
	[CLSCompliantAttribute] // RVA: 0x85DD0 Offset: 0x85ED1 VA: 0x85DD0
	public CipherSuiteCode CipherSuiteCode { get; set; }
	public TlsProtocols ProtocolVersion { get; set; }
	public string PeerDomainName { set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x85AA0 Offset: 0x85BA1 VA: 0x85AA0
	// RVA: 0x1BCC970 Offset: 0x1BCCA71 VA: 0x1BCC970
	public CipherSuiteCode get_CipherSuiteCode() { }

	[CompilerGeneratedAttribute] // RVA: 0x85AB0 Offset: 0x85BB1 VA: 0x85AB0
	// RVA: 0x1BCC980 Offset: 0x1BCCA81 VA: 0x1BCC980
	public void set_CipherSuiteCode(CipherSuiteCode value) { }

	[CompilerGeneratedAttribute] // RVA: 0x85AC0 Offset: 0x85BC1 VA: 0x85AC0
	// RVA: 0x1BCC990 Offset: 0x1BCCA91 VA: 0x1BCC990
	public TlsProtocols get_ProtocolVersion() { }

	[CompilerGeneratedAttribute] // RVA: 0x85AD0 Offset: 0x85BD1 VA: 0x85AD0
	// RVA: 0x1BCC9A0 Offset: 0x1BCCAA1 VA: 0x1BCC9A0
	public void set_ProtocolVersion(TlsProtocols value) { }

	[CompilerGeneratedAttribute] // RVA: 0x85AE0 Offset: 0x85BE1 VA: 0x85AE0
	// RVA: 0x1BCC9B0 Offset: 0x1BCCAB1 VA: 0x1BCC9B0
	public void set_PeerDomainName(string value) { }

	// RVA: 0x1BCC9C0 Offset: 0x1BCCAC1 VA: 0x1BCC9C0 Slot: 3
	public override string ToString() { }

	// RVA: 0x1BCCA80 Offset: 0x1BCCB81 VA: 0x1BCCA80
	public void .ctor() { }
}

