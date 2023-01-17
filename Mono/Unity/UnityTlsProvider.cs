// Namespace: Mono.Unity
internal class UnityTlsProvider : MonoTlsProvider // TypeDefIndex: 2158
{
	// Properties
	public override string Name { get; }
	public override Guid ID { get; }
	public override bool SupportsSslStream { get; }
	public override bool SupportsMonoExtensions { get; }
	public override bool SupportsConnectionInfo { get; }
	internal override bool SupportsCleanShutdown { get; }
	public override SslProtocols SupportedProtocols { get; }

	// Methods

	// RVA: 0x2D177A0 Offset: 0x2D178A1 VA: 0x2D177A0 Slot: 5
	public override string get_Name() { }

	// RVA: 0x2D177F0 Offset: 0x2D178F1 VA: 0x2D177F0 Slot: 4
	public override Guid get_ID() { }

	// RVA: 0x2D17860 Offset: 0x2D17961 VA: 0x2D17860 Slot: 6
	public override bool get_SupportsSslStream() { }

	// RVA: 0x2D17870 Offset: 0x2D17971 VA: 0x2D17870 Slot: 8
	public override bool get_SupportsMonoExtensions() { }

	// RVA: 0x2D17880 Offset: 0x2D17981 VA: 0x2D17880 Slot: 7
	public override bool get_SupportsConnectionInfo() { }

	// RVA: 0x2D17890 Offset: 0x2D17991 VA: 0x2D17890 Slot: 13
	internal override bool get_SupportsCleanShutdown() { }

	// RVA: 0x2D178A0 Offset: 0x2D179A1 VA: 0x2D178A0 Slot: 9
	public override SslProtocols get_SupportedProtocols() { }

	// RVA: 0x2D178B0 Offset: 0x2D179B1 VA: 0x2D178B0 Slot: 10
	public override IMonoSslStream CreateSslStream(Stream innerStream, bool leaveInnerStreamOpen, MonoTlsSettings settings) { }

	// RVA: 0x2D178D0 Offset: 0x2D179D1 VA: 0x2D178D0 Slot: 11
	internal override IMonoSslStream CreateSslStreamInternal(SslStream sslStream, Stream innerStream, bool leaveInnerStreamOpen, MonoTlsSettings settings) { }

	// RVA: 0x2D17A60 Offset: 0x2D17B61 VA: 0x2D17A60 Slot: 12
	internal override bool ValidateCertificate(ICertificateValidator2 validator, string targetHost, bool serverMode, X509CertificateCollection certificates, bool wantsChain, ref X509Chain chain, ref MonoSslPolicyErrors errors, ref int status11) { }

	// RVA: 0x2D18140 Offset: 0x2D18241 VA: 0x2D18140
	public void .ctor() { }
}

