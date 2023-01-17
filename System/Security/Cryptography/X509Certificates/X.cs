// Namespace: System.Security.Cryptography.X509Certificates
[MonoTODOAttribute] // RVA: 0x4743F0 Offset: 0x4744F1 VA: 0x4743F0
[ComVisibleAttribute] // RVA: 0x4743F0 Offset: 0x4744F1 VA: 0x4743F0
[Serializable]
public class X509Certificate : IDeserializationCallback, ISerializable, IDisposable // TypeDefIndex: 980
{
	// Fields
	private X509CertificateImpl impl; // 0x10
	private bool hideDates; // 0x18
	private string issuer_name; // 0x20
	private string subject_name; // 0x28

	// Properties
	internal X509CertificateImpl Impl { get; }
	internal bool IsValid { get; }
	public string Issuer { get; }
	public string Subject { get; }

	// Methods

	// RVA: 0x34D7F90 Offset: 0x34D8091 VA: 0x34D7F90
	internal void .ctor(X509CertificateImpl impl) { }

	// RVA: 0x34D8130 Offset: 0x34D8231 VA: 0x34D8130
	internal void ImportHandle(X509CertificateImpl impl) { }

	// RVA: 0x34D8170 Offset: 0x34D8271 VA: 0x34D8170
	internal X509CertificateImpl get_Impl() { }

	// RVA: 0x34D8220 Offset: 0x34D8321 VA: 0x34D8220
	internal bool get_IsValid() { }

	// RVA: 0x34D8260 Offset: 0x34D8361 VA: 0x34D8260 Slot: 7
	public virtual bool Equals(X509Certificate other) { }

	// RVA: 0x34D8330 Offset: 0x34D8431 VA: 0x34D8330 Slot: 8
	public virtual byte[] GetCertHash() { }

	// RVA: 0x34D8480 Offset: 0x34D8581 VA: 0x34D8480 Slot: 9
	public virtual string GetCertHashString() { }

	// RVA: 0x34D85A0 Offset: 0x34D86A1 VA: 0x34D85A0 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x34D85F0 Offset: 0x34D86F1 VA: 0x34D85F0 Slot: 10
	public virtual byte[] GetRawCertData() { }

	// RVA: 0x34D8650 Offset: 0x34D8751 VA: 0x34D8650 Slot: 11
	public virtual byte[] GetSerialNumber() { }

	// RVA: 0x34D86C0 Offset: 0x34D87C1 VA: 0x34D86C0 Slot: 12
	public virtual string GetSerialNumberString() { }

	// RVA: 0x34D8730 Offset: 0x34D8831 VA: 0x34D8730 Slot: 3
	public override string ToString() { }

	// RVA: 0x34D8740 Offset: 0x34D8841 VA: 0x34D8740 Slot: 13
	public virtual string ToString(bool fVerbose) { }

	// RVA: 0x34D87A0 Offset: 0x34D88A1 VA: 0x34D87A0
	public void .ctor() { }

	// RVA: 0x34D87B0 Offset: 0x34D88B1 VA: 0x34D87B0
	public void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x34D88D0 Offset: 0x34D89D1 VA: 0x34D88D0
	public string get_Issuer() { }

	// RVA: 0x34D8970 Offset: 0x34D8A71 VA: 0x34D8970
	public string get_Subject() { }

	[ComVisibleAttribute] // RVA: 0x47D080 Offset: 0x47D181 VA: 0x47D080
	// RVA: 0x34D8A10 Offset: 0x34D8B11 VA: 0x34D8A10 Slot: 0
	public override bool Equals(object obj) { }

	[MonoTODOAttribute] // RVA: 0x47D0A0 Offset: 0x47D1A1 VA: 0x47D0A0
	[ComVisibleAttribute] // RVA: 0x47D0A0 Offset: 0x47D1A1 VA: 0x47D0A0
	// RVA: 0x34D8AC0 Offset: 0x34D8BC1 VA: 0x34D8AC0 Slot: 14
	public virtual void Import(byte[] rawData, string password, X509KeyStorageFlags keyStorageFlags) { }

	// RVA: 0x34D8C50 Offset: 0x34D8D51 VA: 0x34D8C50 Slot: 4
	private void System.Runtime.Serialization.IDeserializationCallback.OnDeserialization(object sender) { }

	// RVA: 0x34D8C60 Offset: 0x34D8D61 VA: 0x34D8C60 Slot: 5
	private void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x34D8D20 Offset: 0x34D8E21 VA: 0x34D8D20 Slot: 6
	public void Dispose() { }

	// RVA: 0x34D8D40 Offset: 0x34D8E41 VA: 0x34D8D40 Slot: 15
	protected virtual void Dispose(bool disposing) { }

	[ComVisibleAttribute] // RVA: 0x47D0F0 Offset: 0x47D1F1 VA: 0x47D0F0
	// RVA: 0x34D8D60 Offset: 0x34D8E61 VA: 0x34D8D60 Slot: 16
	public virtual void Reset() { }
}

// Namespace: System.Security.Cryptography.X509Certificates
internal sealed class X509CertificateImplMono : X509CertificateImpl // TypeDefIndex: 982
{
	// Fields
	private X509Certificate x509; // 0x18

	// Properties
	public override bool IsValid { get; }

	// Methods

	// RVA: 0x34D9460 Offset: 0x34D9561 VA: 0x34D9460
	public void .ctor(X509Certificate x509) { }

	// RVA: 0x34D94A0 Offset: 0x34D95A1 VA: 0x34D94A0 Slot: 5
	public override bool get_IsValid() { }

	// RVA: 0x34D94B0 Offset: 0x34D95B1 VA: 0x34D94B0 Slot: 6
	public override X509CertificateImpl Clone() { }

	// RVA: 0x34D9560 Offset: 0x34D9661 VA: 0x34D9560 Slot: 7
	public override string GetIssuerName(bool legacyV1Mode) { }

	// RVA: 0x34D9650 Offset: 0x34D9751 VA: 0x34D9650 Slot: 8
	public override string GetSubjectName(bool legacyV1Mode) { }

	// RVA: 0x34D9740 Offset: 0x34D9841 VA: 0x34D9740 Slot: 9
	public override byte[] GetRawCertData() { }

	// RVA: 0x34D97A0 Offset: 0x34D98A1 VA: 0x34D97A0 Slot: 12
	protected override byte[] GetCertHash(bool lazy) { }

	// RVA: 0x34D9820 Offset: 0x34D9921 VA: 0x34D9820 Slot: 10
	public override DateTime GetValidFrom() { }

	// RVA: 0x34D9880 Offset: 0x34D9981 VA: 0x34D9880 Slot: 11
	public override DateTime GetValidUntil() { }

	// RVA: 0x34D98E0 Offset: 0x34D99E1 VA: 0x34D98E0 Slot: 13
	public override bool Equals(X509CertificateImpl other, out bool result) { }

	// RVA: 0x34D98F0 Offset: 0x34D99F1 VA: 0x34D98F0 Slot: 14
	public override byte[] GetSerialNumber() { }

	// RVA: 0x34D9950 Offset: 0x34D9A51 VA: 0x34D9950 Slot: 15
	public override string ToString(bool full) { }

	// RVA: 0x34D9BF0 Offset: 0x34D9CF1 VA: 0x34D9BF0 Slot: 16
	protected override void Dispose(bool disposing) { }
}

// Namespace: System.Security.Cryptography.X509Certificates
[FlagsAttribute] // RVA: 0x30580 Offset: 0x30681 VA: 0x30580
public enum X509ChainStatusFlags // TypeDefIndex: 2348
{
	// Fields
	public int value__; // 0x0
	public const X509ChainStatusFlags NoError = 0;
	public const X509ChainStatusFlags NotTimeValid = 1;
	public const X509ChainStatusFlags NotTimeNested = 2;
	public const X509ChainStatusFlags Revoked = 4;
	public const X509ChainStatusFlags NotSignatureValid = 8;
	public const X509ChainStatusFlags NotValidForUsage = 16;
	public const X509ChainStatusFlags UntrustedRoot = 32;
	public const X509ChainStatusFlags RevocationStatusUnknown = 64;
	public const X509ChainStatusFlags Cyclic = 128;
	public const X509ChainStatusFlags InvalidExtension = 256;
	public const X509ChainStatusFlags InvalidPolicyConstraints = 512;
	public const X509ChainStatusFlags InvalidBasicConstraints = 1024;
	public const X509ChainStatusFlags InvalidNameConstraints = 2048;
	public const X509ChainStatusFlags HasNotSupportedNameConstraint = 4096;
	public const X509ChainStatusFlags HasNotDefinedNameConstraint = 8192;
	public const X509ChainStatusFlags HasNotPermittedNameConstraint = 16384;
	public const X509ChainStatusFlags HasExcludedNameConstraint = 32768;
	public const X509ChainStatusFlags PartialChain = 65536;
	public const X509ChainStatusFlags CtlNotTimeValid = 131072;
	public const X509ChainStatusFlags CtlNotSignatureValid = 262144;
	public const X509ChainStatusFlags CtlNotValidForUsage = 524288;
	public const X509ChainStatusFlags OfflineRevocation = 16777216;
	public const X509ChainStatusFlags NoIssuanceChainPolicy = 33554432;
	public const X509ChainStatusFlags ExplicitDistrust = 67108864;
	public const X509ChainStatusFlags HasNotSupportedCriticalExtension = 134217728;
	public const X509ChainStatusFlags HasWeakSignature = 1048576;
}

// Namespace: System.Security.Cryptography.X509Certificates
public enum X509RevocationFlag // TypeDefIndex: 2350
{
	// Fields
	public int value__; // 0x0
	public const X509RevocationFlag EndCertificateOnly = 0;
	public const X509RevocationFlag EntireChain = 1;
	public const X509RevocationFlag ExcludeRoot = 2;
}

// Namespace: System.Security.Cryptography.X509Certificates
public enum X509SubjectKeyIdentifierHashAlgorithm // TypeDefIndex: 2352
{
	// Fields
	public int value__; // 0x0
	public const X509SubjectKeyIdentifierHashAlgorithm Sha1 = 0;
	public const X509SubjectKeyIdentifierHashAlgorithm ShortSha1 = 1;
	public const X509SubjectKeyIdentifierHashAlgorithm CapiSha1 = 2;
}

// Namespace: System.Security.Cryptography.X509Certificates
internal class X509Utils // TypeDefIndex: 2354
{
	// Methods

	// RVA: 0x1915360 Offset: 0x1915461 VA: 0x1915360
	internal static string FindOidInfo(uint keyType, string keyValue, OidGroup oidGroup) { }

	// RVA: 0x1915470 Offset: 0x1915571 VA: 0x1915470
	internal static string FindOidInfoWithFallback(uint key, string value, OidGroup group) { }
}

// Namespace: System.Security.Cryptography.X509Certificates
[MonoTODOAttribute] // RVA: 0x305B0 Offset: 0x306B1 VA: 0x305B0
public sealed class X500DistinguishedName : AsnEncodedData // TypeDefIndex: 2356
{}

// Namespace: System.Security.Cryptography.X509Certificates
[Serializable]
public class X509Certificate2 : X509Certificate // TypeDefIndex: 2358
{
	// Fields
	private string friendlyName; // 0x30
	private static byte[] signedData; // 0x0

	// Properties
	internal X509Certificate2Impl Impl { get; }
	public DateTime NotAfter { get; }
	public DateTime NotBefore { get; }
	public AsymmetricAlgorithm PrivateKey { get; }
	public PublicKey PublicKey { get; }
	public string SerialNumber { get; }
	public Oid SignatureAlgorithm { get; }
	public string Thumbprint { get; }
	public int Version { get; }

	// Methods

	// RVA: 0x1956BF0 Offset: 0x1956CF1 VA: 0x1956BF0
	internal X509Certificate2Impl get_Impl() { }

	// RVA: 0x1956CA0 Offset: 0x1956DA1 VA: 0x1956CA0
	public void .ctor() { }

	// RVA: 0x1956D10 Offset: 0x1956E11 VA: 0x1956D10
	public void .ctor(byte[] rawData) { }

	// RVA: 0x1956DA0 Offset: 0x1956EA1 VA: 0x1956DA0
	protected void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x1956E30 Offset: 0x1956F31 VA: 0x1956E30
	public DateTime get_NotAfter() { }

	// RVA: 0x1956EF0 Offset: 0x1956FF1 VA: 0x1956EF0
	public DateTime get_NotBefore() { }

	// RVA: 0x1956FB0 Offset: 0x19570B1 VA: 0x1956FB0
	public AsymmetricAlgorithm get_PrivateKey() { }

	// RVA: 0x1957060 Offset: 0x1957161 VA: 0x1957060
	public PublicKey get_PublicKey() { }

	// RVA: 0x1957110 Offset: 0x1957211 VA: 0x1957110
	public string get_SerialNumber() { }

	// RVA: 0x1957120 Offset: 0x1957221 VA: 0x1957120
	public Oid get_SignatureAlgorithm() { }

	// RVA: 0x19571D0 Offset: 0x19572D1 VA: 0x19571D0
	public string get_Thumbprint() { }

	// RVA: 0x19571E0 Offset: 0x19572E1 VA: 0x19571E0
	public int get_Version() { }

	[MonoTODOAttribute] // RVA: 0x321D0 Offset: 0x322D1 VA: 0x321D0
	// RVA: 0x1957290 Offset: 0x1957391 VA: 0x1957290 Slot: 14
	public override void Import(byte[] rawData, string password, X509KeyStorageFlags keyStorageFlags) { }

	// RVA: 0x19573F0 Offset: 0x19574F1 VA: 0x19573F0 Slot: 16
	public override void Reset() { }

	// RVA: 0x1957460 Offset: 0x1957561 VA: 0x1957460 Slot: 3
	public override string ToString() { }

	// RVA: 0x19574D0 Offset: 0x19575D1 VA: 0x19574D0 Slot: 13
	public override string ToString(bool verbose) { }

	// RVA: 0x1957DD0 Offset: 0x1957ED1 VA: 0x1957DD0
	private static void AppendBuffer(StringBuilder sb, byte[] buffer) { }

	// RVA: 0x1957ED0 Offset: 0x1957FD1 VA: 0x1957ED0
	private static void .cctor() { }
}

// Namespace: System.Security.Cryptography.X509Certificates
internal abstract class X509Certificate2Impl : X509CertificateImpl // TypeDefIndex: 2360
{
	// Properties
	public abstract AsymmetricAlgorithm PrivateKey { get; }
	public abstract PublicKey PublicKey { get; }
	public abstract Oid SignatureAlgorithm { get; }
	public abstract int Version { get; }
	internal abstract X509CertificateImplCollection IntermediateCertificates { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 17
	public abstract AsymmetricAlgorithm get_PrivateKey();

	// RVA: -1 Offset: -1 Slot: 18
	public abstract PublicKey get_PublicKey();

	// RVA: -1 Offset: -1 Slot: 19
	public abstract Oid get_SignatureAlgorithm();

	// RVA: -1 Offset: -1 Slot: 20
	public abstract int get_Version();

	// RVA: -1 Offset: -1 Slot: 21
	internal abstract X509CertificateImplCollection get_IntermediateCertificates();

	// RVA: -1 Offset: -1 Slot: 22
	public abstract void Import(byte[] rawData, string password, X509KeyStorageFlags keyStorageFlags);

	// RVA: -1 Offset: -1 Slot: 23
	public abstract void Reset();

	// RVA: 0x1958040 Offset: 0x1958141 VA: 0x1958040
	protected void .ctor() { }
}

// Namespace: System.Security.Cryptography.X509Certificates
[DefaultMemberAttribute] // RVA: 0x30670 Offset: 0x30771 VA: 0x30670
internal class X509CertificateImplCollection : IDisposable // TypeDefIndex: 2364
{
	// Fields
	private List<X509CertificateImpl> list; // 0x10

	// Properties
	public int Count { get; }
	public X509CertificateImpl Item { get; }

	// Methods

	// RVA: 0x19593B0 Offset: 0x19594B1 VA: 0x19593B0
	public void .ctor() { }

	// RVA: 0x195A570 Offset: 0x195A671 VA: 0x195A570
	private void .ctor(X509CertificateImplCollection other) { }

	// RVA: 0x195A710 Offset: 0x195A811 VA: 0x195A710
	public int get_Count() { }

	// RVA: 0x195A760 Offset: 0x195A861 VA: 0x195A760
	public X509CertificateImpl get_Item(int index) { }

	// RVA: 0x1959440 Offset: 0x1959541 VA: 0x1959440
	public void Add(X509CertificateImpl impl, bool takeOwnership) { }

	// RVA: 0x1958140 Offset: 0x1958241 VA: 0x1958140
	public X509CertificateImplCollection Clone() { }

	// RVA: 0x1959850 Offset: 0x1959951 VA: 0x1959850 Slot: 4
	public void Dispose() { }

	// RVA: 0x195A7D0 Offset: 0x195A8D1 VA: 0x195A7D0 Slot: 5
	protected virtual void Dispose(bool disposing) { }

	// RVA: 0x195A9D0 Offset: 0x195AAD1 VA: 0x195A9D0 Slot: 1
	protected override void Finalize() { }
}

// Namespace: System.Security.Cryptography.X509Certificates
public class X509ChainElement // TypeDefIndex: 2366
{
	// Fields
	private X509Certificate2 certificate; // 0x10
	private string info; // 0x18

	// Properties
	public X509Certificate2 Certificate { get; }

	// Methods

	// RVA: 0x195AFE0 Offset: 0x195B0E1 VA: 0x195AFE0
	internal void .ctor(X509Certificate2 certificate) { }

	// RVA: 0x195B060 Offset: 0x195B161 VA: 0x195B060
	public X509Certificate2 get_Certificate() { }
}

// Namespace: System.Security.Cryptography.X509Certificates
public sealed class X509ChainElementEnumerator : IEnumerator // TypeDefIndex: 2368
{
	// Fields
	private IEnumerator enumerator; // 0x10

	// Properties
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	// RVA: 0x195B310 Offset: 0x195B411 VA: 0x195B310
	internal void .ctor(IEnumerable enumerable) { }

	// RVA: 0x195B4D0 Offset: 0x195B5D1 VA: 0x195B4D0 Slot: 5
	private object System.Collections.IEnumerator.get_Current() { }

	// RVA: 0x195B580 Offset: 0x195B681 VA: 0x195B580 Slot: 4
	public bool MoveNext() { }

	// RVA: 0x195B630 Offset: 0x195B731 VA: 0x195B630 Slot: 6
	public void Reset() { }
}

// Namespace: System.Security.Cryptography.X509Certificates
internal class X509ChainImplMono : X509ChainImpl // TypeDefIndex: 2370
{
	// Fields
	private StoreLocation location; // 0x10
	private X509ChainElementCollection elements; // 0x18
	private X509ChainPolicy policy; // 0x20
	private X509ChainStatus[] status; // 0x28
	private static X509ChainStatus[] Empty; // 0x0
	private AsymmetricAlgorithm working_public_key; // 0x30
	private X509ChainElement bce_restriction; // 0x38
	private X509Certificate2Collection roots; // 0x40
	private X509Certificate2Collection cas; // 0x48
	private X509Store root_store; // 0x50
	private X509Store ca_store; // 0x58
	private X509Store user_root_store; // 0x60
	private X509Store user_ca_store; // 0x68
	private X509Certificate2Collection collection; // 0x70

	// Properties
	public override bool IsValid { get; }
	public override X509ChainElementCollection ChainElements { get; }
	public override X509ChainPolicy ChainPolicy { set; }

	// Methods

	// RVA: 0x195B860 Offset: 0x195B961 VA: 0x195B860
	public void .ctor(bool useMachineContext) { }

	// RVA: 0x195B9B0 Offset: 0x195BAB1 VA: 0x195B9B0 Slot: 5
	public override bool get_IsValid() { }

	// RVA: 0x195B9C0 Offset: 0x195BAC1 VA: 0x195B9C0 Slot: 6
	public override X509ChainElementCollection get_ChainElements() { }

	// RVA: 0x195B9D0 Offset: 0x195BAD1 VA: 0x195B9D0 Slot: 7
	public override void set_ChainPolicy(X509ChainPolicy value) { }

	// RVA: 0x195B9E0 Offset: 0x195BAE1 VA: 0x195B9E0 Slot: 8
	public override void Reset() { }

	// RVA: 0x195BB30 Offset: 0x195BC31 VA: 0x195BB30
	private static void .cctor() { }
}

// Namespace: System.Security.Cryptography.X509Certificates
public struct X509ChainStatus // TypeDefIndex: 2372
{
	// Fields
	private X509ChainStatusFlags status; // 0x0
	private string info; // 0x8

	// Methods

	// RVA: 0x195C0B0 Offset: 0x195C1B1 VA: 0x195C0B0
	internal void .ctor(X509ChainStatusFlags flag) { }

	// RVA: 0x195C2F0 Offset: 0x195C3F1 VA: 0x195C2F0
	internal static string GetInformation(X509ChainStatusFlags flags) { }
}

// Namespace: System.Security.Cryptography.X509Certificates
public class X509Extension : AsnEncodedData // TypeDefIndex: 2374
{
	// Fields
	private bool _critical; // 0x20

	// Properties
	public bool Critical { get; set; }

	// Methods

	// RVA: 0x1955F40 Offset: 0x1956041 VA: 0x1955F40
	protected void .ctor() { }

	// RVA: 0x195CD60 Offset: 0x195CE61 VA: 0x195CD60
	public bool get_Critical() { }

	// RVA: 0x195CD70 Offset: 0x195CE71 VA: 0x195CD70
	public void set_Critical(bool value) { }

	// RVA: 0x195CD80 Offset: 0x195CE81 VA: 0x195CD80 Slot: 4
	public override void CopyFrom(AsnEncodedData asnEncodedData) { }

	// RVA: 0x1956AC0 Offset: 0x1956BC1 VA: 0x1956AC0
	internal string FormatUnkownData(byte[] data) { }
}

// Namespace: System.Security.Cryptography.X509Certificates
public sealed class X509KeyUsageExtension : X509Extension // TypeDefIndex: 2378
{
	// Fields
	internal const string oid = "2.5.29.15";
	internal const string friendlyName = "Key Usage";
	internal const X509KeyUsageFlags all = 33023;
	private X509KeyUsageFlags _keyUsages; // 0x24
	private AsnDecodeStatus _status; // 0x28

	// Properties
	public X509KeyUsageFlags KeyUsages { get; }

	// Methods

	// RVA: 0x195CFB0 Offset: 0x195D0B1 VA: 0x195CFB0
	public void .ctor() { }

	// RVA: 0x195D060 Offset: 0x195D161 VA: 0x195D060
	public void .ctor(AsnEncodedData encodedKeyUsage, bool critical) { }

	// RVA: 0x195D310 Offset: 0x195D411 VA: 0x195D310
	public void .ctor(X509KeyUsageFlags keyUsages, bool critical) { }

	// RVA: 0x195D5A0 Offset: 0x195D6A1 VA: 0x195D5A0
	public X509KeyUsageFlags get_KeyUsages() { }

	// RVA: 0x195D620 Offset: 0x195D721 VA: 0x195D620 Slot: 4
	public override void CopyFrom(AsnEncodedData asnEncodedData) { }

	// RVA: 0x195D400 Offset: 0x195D501 VA: 0x195D400
	internal X509KeyUsageFlags GetValidFlags(X509KeyUsageFlags flags) { }

	// RVA: 0x195D150 Offset: 0x195D251 VA: 0x195D150
	internal AsnDecodeStatus Decode(byte[] extension) { }

	// RVA: 0x195D410 Offset: 0x195D511 VA: 0x195D410
	internal byte[] Encode() { }

	// RVA: 0x195D800 Offset: 0x195D901 VA: 0x195D800 Slot: 5
	internal override string ToString(bool multiLine) { }
}

// Namespace: System.Security.Cryptography.X509Certificates
public sealed class X509SubjectKeyIdentifierExtension : X509Extension // TypeDefIndex: 2380
{
	// Fields
	internal const string oid = "2.5.29.14";
	internal const string friendlyName = "Subject Key Identifier";
	private byte[] _subjectKeyIdentifier; // 0x28
	private string _ski; // 0x30
	private AsnDecodeStatus _status; // 0x38

	// Properties
	public string SubjectKeyIdentifier { get; }

	// Methods

	// RVA: 0x1914040 Offset: 0x1914141 VA: 0x1914040
	public void .ctor() { }

	// RVA: 0x19140F0 Offset: 0x19141F1 VA: 0x19140F0
	public void .ctor(AsnEncodedData encodedSubjectKeyIdentifier, bool critical) { }

	// RVA: 0x1914390 Offset: 0x1914491 VA: 0x1914390
	public void .ctor(byte[] subjectKeyIdentifier, bool critical) { }

	// RVA: 0x1914620 Offset: 0x1914721 VA: 0x1914620
	public void .ctor(string subjectKeyIdentifier, bool critical) { }

	// RVA: 0x19149B0 Offset: 0x1914AB1 VA: 0x19149B0
	public void .ctor(PublicKey key, bool critical) { }

	// RVA: 0x19149C0 Offset: 0x1914AC1 VA: 0x19149C0
	public void .ctor(PublicKey key, X509SubjectKeyIdentifierHashAlgorithm algorithm, bool critical) { }

	// RVA: 0x1914DA0 Offset: 0x1914EA1 VA: 0x1914DA0
	public string get_SubjectKeyIdentifier() { }

	// RVA: 0x1914E40 Offset: 0x1914F41 VA: 0x1914E40 Slot: 4
	public override void CopyFrom(AsnEncodedData asnEncodedData) { }

	// RVA: 0x1915020 Offset: 0x1915121 VA: 0x1915020
	internal static byte FromHexChar(char c) { }

	// RVA: 0x1915060 Offset: 0x1915161 VA: 0x1915060
	internal static byte FromHexChars(char c1, char c2) { }

	// RVA: 0x19147F0 Offset: 0x19148F1 VA: 0x19147F0
	internal static byte[] FromHex(string hex) { }

	// RVA: 0x19141E0 Offset: 0x19142E1 VA: 0x19141E0
	internal AsnDecodeStatus Decode(byte[] extension) { }

	// RVA: 0x19145A0 Offset: 0x19146A1 VA: 0x19145A0
	internal byte[] Encode() { }

	// RVA: 0x1915100 Offset: 0x1915201 VA: 0x1915100 Slot: 5
	internal override string ToString(bool multiLine) { }
}

