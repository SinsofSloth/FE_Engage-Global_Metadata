// Namespace: Mono.Unity
internal class UnityTlsContext : MobileTlsContext // TypeDefIndex: 2156
{
	// Fields
	private UnityTls.unitytls_tlsctx* tlsContext; // 0x58
	private UnityTls.unitytls_x509list* requestedClientCertChain; // 0x60
	private UnityTls.unitytls_key* requestedClientKey; // 0x68
	private UnityTls.unitytls_tlsctx_read_callback readCallback; // 0x70
	private UnityTls.unitytls_tlsctx_write_callback writeCallback; // 0x78
	private UnityTls.unitytls_tlsctx_certificate_callback certificateCallback; // 0x80
	private UnityTls.unitytls_tlsctx_x509verify_callback verifyCallback; // 0x88
	private X509Certificate localClientCertificate; // 0x90
	private X509Certificate remoteCertificate; // 0x98
	private MonoTlsConnectionInfo connectioninfo; // 0xA0
	private bool isAuthenticated; // 0xA8
	private bool hasContext; // 0xA9
	private bool closedGraceful; // 0xAA
	private byte[] writeBuffer; // 0xB0
	private byte[] readBuffer; // 0xB8
	private GCHandle handle; // 0xC0
	private Exception lastException; // 0xC8

	// Properties
	public override bool IsAuthenticated { get; }
	internal override X509Certificate LocalClientCertificate { get; }

	// Methods

	// RVA: 0x2D151B0 Offset: 0x2D152B1 VA: 0x2D151B0
	public void .ctor(MobileAuthenticatedStream parent, bool serverMode, string targetHost, SslProtocols enabledProtocols, X509Certificate serverCertificate, X509CertificateCollection clientCertificates, bool askForClientCert) { }

	// RVA: 0x2D15A50 Offset: 0x2D15B51 VA: 0x2D15A50
	private static void ExtractNativeKeyAndChainFromManagedCertificate(X509Certificate cert, UnityTls.unitytls_errorstate* errorState, out UnityTls.unitytls_x509list* nativeCertChain, out UnityTls.unitytls_key* nativeKey) { }

	// RVA: 0x2D15D30 Offset: 0x2D15E31 VA: 0x2D15D30 Slot: 5
	public override bool get_IsAuthenticated() { }

	// RVA: 0x2D15D40 Offset: 0x2D15E41 VA: 0x2D15D40 Slot: 9
	internal override X509Certificate get_LocalClientCertificate() { }

	// RVA: 0x2D15D50 Offset: 0x2D15E51 VA: 0x2D15D50 Slot: 10
	public override ValueTuple<int, bool> Read(byte[] buffer, int offset, int count) { }

	// RVA: 0x2D15F00 Offset: 0x2D16001 VA: 0x2D15F00 Slot: 11
	public override ValueTuple<int, bool> Write(byte[] buffer, int offset, int count) { }

	// RVA: 0x2D160B0 Offset: 0x2D161B1 VA: 0x2D160B0 Slot: 12
	public override void Shutdown() { }

	// RVA: 0x2D16170 Offset: 0x2D16271 VA: 0x2D16170 Slot: 13
	protected override void Dispose(bool disposing) { }

	// RVA: 0x2D162A0 Offset: 0x2D163A1 VA: 0x2D162A0 Slot: 6
	public override void StartHandshake() { }

	// RVA: 0x2D16420 Offset: 0x2D16521 VA: 0x2D16420 Slot: 7
	public override bool ProcessHandshake() { }

	// RVA: 0x2D165A0 Offset: 0x2D166A1 VA: 0x2D165A0 Slot: 8
	public override void FinishHandshake() { }

	[MonoPInvokeCallbackAttribute] // RVA: 0x31B10 Offset: 0x31C11 VA: 0x31B10
	// RVA: 0x2D14E90 Offset: 0x2D14F91 VA: 0x2D14E90
	private static IntPtr WriteCallback(void* userData, byte* data, IntPtr bufferLen, UnityTls.unitytls_errorstate* errorState) { }

	// RVA: 0x2D166C0 Offset: 0x2D167C1 VA: 0x2D166C0
	private IntPtr WriteCallback(byte* data, IntPtr bufferLen, UnityTls.unitytls_errorstate* errorState) { }

	[MonoPInvokeCallbackAttribute] // RVA: 0x31B80 Offset: 0x31C81 VA: 0x31B80
	// RVA: 0x2D14F60 Offset: 0x2D15061 VA: 0x2D14F60
	private static IntPtr ReadCallback(void* userData, byte* buffer, IntPtr bufferLen, UnityTls.unitytls_errorstate* errorState) { }

	// RVA: 0x2D16920 Offset: 0x2D16A21 VA: 0x2D16920
	private IntPtr ReadCallback(byte* buffer, IntPtr bufferLen, UnityTls.unitytls_errorstate* errorState) { }

	[MonoPInvokeCallbackAttribute] // RVA: 0x31BF0 Offset: 0x31CF1 VA: 0x31BF0
	// RVA: 0x2D15030 Offset: 0x2D15131 VA: 0x2D15030
	private static UnityTls.unitytls_x509verify_result VerifyCallback(void* userData, UnityTls.unitytls_x509list_ref chain, UnityTls.unitytls_errorstate* errorState) { }

	// RVA: 0x2D16BE0 Offset: 0x2D16CE1 VA: 0x2D16BE0
	private UnityTls.unitytls_x509verify_result VerifyCallback(UnityTls.unitytls_x509list_ref chain, UnityTls.unitytls_errorstate* errorState) { }

	[MonoPInvokeCallbackAttribute] // RVA: 0x31C60 Offset: 0x31D61 VA: 0x31C60
	// RVA: 0x2D150E0 Offset: 0x2D151E1 VA: 0x2D150E0
	private static void CertificateCallback(void* userData, UnityTls.unitytls_tlsctx* ctx, byte* cn, IntPtr cnLen, UnityTls.unitytls_x509name* caList, IntPtr caListLen, UnityTls.unitytls_x509list_ref* chain, UnityTls.unitytls_key_ref* key, UnityTls.unitytls_errorstate* errorState) { }

	// RVA: 0x2D16F40 Offset: 0x2D17041 VA: 0x2D16F40
	private void CertificateCallback(UnityTls.unitytls_tlsctx* ctx, byte* cn, IntPtr cnLen, UnityTls.unitytls_x509name* caList, IntPtr caListLen, UnityTls.unitytls_x509list_ref* chain, UnityTls.unitytls_key_ref* key, UnityTls.unitytls_errorstate* errorState) { }
}

