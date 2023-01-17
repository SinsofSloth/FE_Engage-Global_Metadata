// Namespace: Mono.Security.Interface
public sealed class MonoTlsSettings // TypeDefIndex: 1565
{
	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x85A00 Offset: 0x85B01 VA: 0x85A00
	private MonoRemoteCertificateValidationCallback <RemoteCertificateValidationCallback>k__BackingField; // 0x10
	[CompilerGeneratedAttribute] // RVA: 0x85A10 Offset: 0x85B11 VA: 0x85A10
	private MonoLocalCertificateSelectionCallback <ClientCertificateSelectionCallback>k__BackingField; // 0x18
	[CompilerGeneratedAttribute] // RVA: 0x85A20 Offset: 0x85B21 VA: 0x85A20
	private Nullable<DateTime> <CertificateValidationTime>k__BackingField; // 0x20
	[CompilerGeneratedAttribute] // RVA: 0x85A30 Offset: 0x85B31 VA: 0x85A30
	private X509CertificateCollection <TrustAnchors>k__BackingField; // 0x30
	[CompilerGeneratedAttribute] // RVA: 0x85A40 Offset: 0x85B41 VA: 0x85A40
	private object <UserSettings>k__BackingField; // 0x38
	[CompilerGeneratedAttribute] // RVA: 0x85A50 Offset: 0x85B51 VA: 0x85A50
	private string[] <CertificateSearchPaths>k__BackingField; // 0x40
	[CompilerGeneratedAttribute] // RVA: 0x85A60 Offset: 0x85B61 VA: 0x85A60
	private bool <SendCloseNotify>k__BackingField; // 0x48
	[CompilerGeneratedAttribute] // RVA: 0x85A70 Offset: 0x85B71 VA: 0x85A70
	private Nullable<TlsProtocols> <EnabledProtocols>k__BackingField; // 0x4C
	[CompilerGeneratedAttribute] // RVA: 0x85A80 Offset: 0x85B81 VA: 0x85A80
	private CipherSuiteCode[] <EnabledCiphers>k__BackingField; // 0x58
	private bool cloned; // 0x60
	private bool checkCertName; // 0x61
	private bool checkCertRevocationStatus; // 0x62
	private Nullable<bool> useServicePointManagerCallback; // 0x63
	private bool skipSystemValidators; // 0x65
	private bool callbackNeedsChain; // 0x66
	private ICertificateValidator certificateValidator; // 0x68
	private static MonoTlsSettings defaultSettings; // 0x0

	// Properties
	public MonoRemoteCertificateValidationCallback RemoteCertificateValidationCallback { get; set; }
	public MonoLocalCertificateSelectionCallback ClientCertificateSelectionCallback { get; set; }
	public Nullable<bool> UseServicePointManagerCallback { get; set; }
	public bool CallbackNeedsCertificateChain { get; }
	public Nullable<DateTime> CertificateValidationTime { get; set; }
	public X509CertificateCollection TrustAnchors { get; set; }
	public object UserSettings { get; set; }
	internal string[] CertificateSearchPaths { get; set; }
	internal bool SendCloseNotify { get; set; }
	public Nullable<TlsProtocols> EnabledProtocols { get; set; }
	[CLSCompliantAttribute] // RVA: 0x85DF0 Offset: 0x85EF1 VA: 0x85DF0
	public CipherSuiteCode[] EnabledCiphers { get; set; }
	public static MonoTlsSettings DefaultSettings { get; }
	[ObsoleteAttribute] // RVA: 0x85E10 Offset: 0x85F11 VA: 0x85E10
	public ICertificateValidator CertificateValidator { get; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x85AF0 Offset: 0x85BF1 VA: 0x85AF0
	// RVA: 0x1BCCAA0 Offset: 0x1BCCBA1 VA: 0x1BCCAA0
	public MonoRemoteCertificateValidationCallback get_RemoteCertificateValidationCallback() { }

	[CompilerGeneratedAttribute] // RVA: 0x85B00 Offset: 0x85C01 VA: 0x85B00
	// RVA: 0x1BCCAB0 Offset: 0x1BCCBB1 VA: 0x1BCCAB0
	public void set_RemoteCertificateValidationCallback(MonoRemoteCertificateValidationCallback value) { }

	[CompilerGeneratedAttribute] // RVA: 0x85B10 Offset: 0x85C11 VA: 0x85B10
	// RVA: 0x1BCCAC0 Offset: 0x1BCCBC1 VA: 0x1BCCAC0
	public MonoLocalCertificateSelectionCallback get_ClientCertificateSelectionCallback() { }

	[CompilerGeneratedAttribute] // RVA: 0x85B20 Offset: 0x85C21 VA: 0x85B20
	// RVA: 0x1BCCAD0 Offset: 0x1BCCBD1 VA: 0x1BCCAD0
	public void set_ClientCertificateSelectionCallback(MonoLocalCertificateSelectionCallback value) { }

	// RVA: 0x1BCCAE0 Offset: 0x1BCCBE1 VA: 0x1BCCAE0
	public Nullable<bool> get_UseServicePointManagerCallback() { }

	// RVA: 0x1BCCAF0 Offset: 0x1BCCBF1 VA: 0x1BCCAF0
	public void set_UseServicePointManagerCallback(Nullable<bool> value) { }

	// RVA: 0x1BCCB00 Offset: 0x1BCCC01 VA: 0x1BCCB00
	public bool get_CallbackNeedsCertificateChain() { }

	[CompilerGeneratedAttribute] // RVA: 0x85B30 Offset: 0x85C31 VA: 0x85B30
	// RVA: 0x1BCCB10 Offset: 0x1BCCC11 VA: 0x1BCCB10
	public Nullable<DateTime> get_CertificateValidationTime() { }

	[CompilerGeneratedAttribute] // RVA: 0x85B40 Offset: 0x85C41 VA: 0x85B40
	// RVA: 0x1BCCB20 Offset: 0x1BCCC21 VA: 0x1BCCB20
	public void set_CertificateValidationTime(Nullable<DateTime> value) { }

	[CompilerGeneratedAttribute] // RVA: 0x85B50 Offset: 0x85C51 VA: 0x85B50
	// RVA: 0x1BCCB30 Offset: 0x1BCCC31 VA: 0x1BCCB30
	public X509CertificateCollection get_TrustAnchors() { }

	[CompilerGeneratedAttribute] // RVA: 0x85B60 Offset: 0x85C61 VA: 0x85B60
	// RVA: 0x1BCCB40 Offset: 0x1BCCC41 VA: 0x1BCCB40
	public void set_TrustAnchors(X509CertificateCollection value) { }

	[CompilerGeneratedAttribute] // RVA: 0x85B70 Offset: 0x85C71 VA: 0x85B70
	// RVA: 0x1BCCB50 Offset: 0x1BCCC51 VA: 0x1BCCB50
	public object get_UserSettings() { }

	[CompilerGeneratedAttribute] // RVA: 0x85B80 Offset: 0x85C81 VA: 0x85B80
	// RVA: 0x1BCCB60 Offset: 0x1BCCC61 VA: 0x1BCCB60
	public void set_UserSettings(object value) { }

	[CompilerGeneratedAttribute] // RVA: 0x85B90 Offset: 0x85C91 VA: 0x85B90
	// RVA: 0x1BCCB70 Offset: 0x1BCCC71 VA: 0x1BCCB70
	internal string[] get_CertificateSearchPaths() { }

	[CompilerGeneratedAttribute] // RVA: 0x85BA0 Offset: 0x85CA1 VA: 0x85BA0
	// RVA: 0x1BCCB80 Offset: 0x1BCCC81 VA: 0x1BCCB80
	internal void set_CertificateSearchPaths(string[] value) { }

	[CompilerGeneratedAttribute] // RVA: 0x85BB0 Offset: 0x85CB1 VA: 0x85BB0
	// RVA: 0x1BCCB90 Offset: 0x1BCCC91 VA: 0x1BCCB90
	internal bool get_SendCloseNotify() { }

	[CompilerGeneratedAttribute] // RVA: 0x85BC0 Offset: 0x85CC1 VA: 0x85BC0
	// RVA: 0x1BCCBA0 Offset: 0x1BCCCA1 VA: 0x1BCCBA0
	internal void set_SendCloseNotify(bool value) { }

	[CompilerGeneratedAttribute] // RVA: 0x85BD0 Offset: 0x85CD1 VA: 0x85BD0
	// RVA: 0x1BCCBB0 Offset: 0x1BCCCB1 VA: 0x1BCCBB0
	public Nullable<TlsProtocols> get_EnabledProtocols() { }

	[CompilerGeneratedAttribute] // RVA: 0x85BE0 Offset: 0x85CE1 VA: 0x85BE0
	// RVA: 0x1BCCBC0 Offset: 0x1BCCCC1 VA: 0x1BCCBC0
	public void set_EnabledProtocols(Nullable<TlsProtocols> value) { }

	[CompilerGeneratedAttribute] // RVA: 0x85BF0 Offset: 0x85CF1 VA: 0x85BF0
	// RVA: 0x1BCCBD0 Offset: 0x1BCCCD1 VA: 0x1BCCBD0
	public CipherSuiteCode[] get_EnabledCiphers() { }

	[CompilerGeneratedAttribute] // RVA: 0x85C00 Offset: 0x85D01 VA: 0x85C00
	// RVA: 0x1BCCBE0 Offset: 0x1BCCCE1 VA: 0x1BCCBE0
	public void set_EnabledCiphers(CipherSuiteCode[] value) { }

	// RVA: 0x1BCCBF0 Offset: 0x1BCCCF1 VA: 0x1BCCBF0
	public void .ctor() { }

	// RVA: 0x1BCCC10 Offset: 0x1BCCD11 VA: 0x1BCCC10
	public static MonoTlsSettings get_DefaultSettings() { }

	// RVA: 0x1BCCCC0 Offset: 0x1BCCDC1 VA: 0x1BCCCC0
	public static MonoTlsSettings CopyDefaultSettings() { }

	// RVA: 0x1BCCE20 Offset: 0x1BCCF21 VA: 0x1BCCE20
	public ICertificateValidator get_CertificateValidator() { }

	[ObsoleteAttribute] // RVA: 0x85C10 Offset: 0x85D11 VA: 0x85C10
	// RVA: 0x1BCCE30 Offset: 0x1BCCF31 VA: 0x1BCCE30
	public MonoTlsSettings CloneWithValidator(ICertificateValidator validator) { }

	// RVA: 0x1BCCDB0 Offset: 0x1BCCEB1 VA: 0x1BCCDB0
	public MonoTlsSettings Clone() { }

	// RVA: 0x1BCCEC0 Offset: 0x1BCCFC1 VA: 0x1BCCEC0
	private void .ctor(MonoTlsSettings other) { }
}

