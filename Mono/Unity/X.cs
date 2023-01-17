// Namespace: Mono.Unity
internal class X509ChainImplUnityTls : X509ChainImpl // TypeDefIndex: 2160
{
	// Fields
	private X509ChainElementCollection elements; // 0x10
	private UnityTls.unitytls_x509list_ref nativeCertificateChain; // 0x18
	private X509ChainPolicy policy; // 0x20
	private List<X509ChainStatus> chainStatusList; // 0x28

	// Properties
	public override bool IsValid { get; }
	internal UnityTls.unitytls_x509list_ref NativeCertificateChain { get; }
	public override X509ChainElementCollection ChainElements { get; }
	public override X509ChainPolicy ChainPolicy { set; }

	// Methods

	// RVA: 0x195BBB0 Offset: 0x195BCB1 VA: 0x195BBB0
	internal void .ctor(UnityTls.unitytls_x509list_ref nativeCertificateChain) { }

	// RVA: 0x195BC50 Offset: 0x195BD51 VA: 0x195BC50 Slot: 5
	public override bool get_IsValid() { }

	// RVA: 0x195BC80 Offset: 0x195BD81 VA: 0x195BC80
	internal UnityTls.unitytls_x509list_ref get_NativeCertificateChain() { }

	// RVA: 0x195BC90 Offset: 0x195BD91 VA: 0x195BC90 Slot: 6
	public override X509ChainElementCollection get_ChainElements() { }

	// RVA: 0x195BFB0 Offset: 0x195C0B1 VA: 0x195BFB0 Slot: 7
	public override void set_ChainPolicy(X509ChainPolicy value) { }

	// RVA: 0x195BFC0 Offset: 0x195C0C1 VA: 0x195BFC0
	public void AddStatus(X509ChainStatusFlags errorCode) { }

	// RVA: 0x195C0F0 Offset: 0x195C1F1 VA: 0x195C0F0 Slot: 8
	public override void Reset() { }

	// RVA: 0x195C160 Offset: 0x195C261 VA: 0x195C160 Slot: 9
	protected override void Dispose(bool disposing) { }
}

