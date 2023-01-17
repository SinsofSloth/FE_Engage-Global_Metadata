// Namespace: Mono.Net.Security
internal class MonoTlsStream // TypeDefIndex: 2202
{
	// Fields
	private readonly MonoTlsProvider provider; // 0x10
	private readonly NetworkStream networkStream; // 0x18
	private readonly HttpWebRequest request; // 0x20
	private readonly MonoTlsSettings settings; // 0x28
	private IMonoSslStream sslStream; // 0x30
	private WebExceptionStatus status; // 0x38
	[CompilerGeneratedAttribute] // RVA: 0x31530 Offset: 0x31631 VA: 0x31530
	private bool <CertificateValidationFailed>k__BackingField; // 0x3C

	// Properties
	internal HttpWebRequest Request { get; }
	internal WebExceptionStatus ExceptionStatus { get; }
	internal bool CertificateValidationFailed { get; set; }

	// Methods

	// RVA: 0x1ACB0D0 Offset: 0x1ACB1D1 VA: 0x1ACB0D0
	internal HttpWebRequest get_Request() { }

	// RVA: 0x1ACB0E0 Offset: 0x1ACB1E1 VA: 0x1ACB0E0
	internal WebExceptionStatus get_ExceptionStatus() { }

	[CompilerGeneratedAttribute] // RVA: 0x32130 Offset: 0x32231 VA: 0x32130
	// RVA: 0x1ACB0F0 Offset: 0x1ACB1F1 VA: 0x1ACB0F0
	internal bool get_CertificateValidationFailed() { }

	[CompilerGeneratedAttribute] // RVA: 0x32140 Offset: 0x32241 VA: 0x32140
	// RVA: 0x1ACB100 Offset: 0x1ACB201 VA: 0x1ACB100
	internal void set_CertificateValidationFailed(bool value) { }

	// RVA: 0x1ACB110 Offset: 0x1ACB211 VA: 0x1ACB110
	public void .ctor(HttpWebRequest request, NetworkStream networkStream) { }

	[AsyncStateMachineAttribute] // RVA: 0x32150 Offset: 0x32251 VA: 0x32150
	// RVA: 0x1ACB200 Offset: 0x1ACB301 VA: 0x1ACB200
	internal Task<Stream> CreateStream(WebConnectionTunnel tunnel, CancellationToken cancellationToken) { }
}

