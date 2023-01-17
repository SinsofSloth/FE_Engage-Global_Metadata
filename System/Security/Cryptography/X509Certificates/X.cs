// Namespace: System.Security.Cryptography.X509Certificates
[FlagsAttribute] // RVA: 0x4743E0 Offset: 0x4744E1 VA: 0x4743E0
public enum X509KeyStorageFlags // TypeDefIndex: 977
{
	// Fields
	public int value__; // 0x0
	public const X509KeyStorageFlags DefaultKeySet = 0;
	public const X509KeyStorageFlags UserKeySet = 1;
	public const X509KeyStorageFlags MachineKeySet = 2;
	public const X509KeyStorageFlags Exportable = 4;
	public const X509KeyStorageFlags UserProtected = 8;
	public const X509KeyStorageFlags PersistKeySet = 16;
	public const X509KeyStorageFlags EphemeralKeySet = 32;
}

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
internal abstract class X509CertificateImpl : IDisposable // TypeDefIndex: 981
{
	// Fields
	private byte[] cachedCertificateHash; // 0x10

	// Properties
	public abstract bool IsValid { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 5
	public abstract bool get_IsValid();

	// RVA: 0x34D90C0 Offset: 0x34D91C1 VA: 0x34D90C0
	protected void ThrowIfContextInvalid() { }

	// RVA: -1 Offset: -1 Slot: 6
	public abstract X509CertificateImpl Clone();

	// RVA: -1 Offset: -1 Slot: 7
	public abstract string GetIssuerName(bool legacyV1Mode);

	// RVA: -1 Offset: -1 Slot: 8
	public abstract string GetSubjectName(bool legacyV1Mode);

	// RVA: -1 Offset: -1 Slot: 9
	public abstract byte[] GetRawCertData();

	// RVA: -1 Offset: -1 Slot: 10
	public abstract DateTime GetValidFrom();

	// RVA: -1 Offset: -1 Slot: 11
	public abstract DateTime GetValidUntil();

	// RVA: 0x34D83F0 Offset: 0x34D84F1 VA: 0x34D83F0
	public byte[] GetCertHash() { }

	// RVA: -1 Offset: -1 Slot: 12
	protected abstract byte[] GetCertHash(bool lazy);

	// RVA: 0x34D91A0 Offset: 0x34D92A1 VA: 0x34D91A0 Slot: 2
	public override int GetHashCode() { }

	// RVA: -1 Offset: -1 Slot: 13
	public abstract bool Equals(X509CertificateImpl other, out bool result);

	// RVA: -1 Offset: -1 Slot: 14
	public abstract byte[] GetSerialNumber();

	// RVA: -1 Offset: -1 Slot: 15
	public abstract string ToString(bool full);

	// RVA: 0x34D9230 Offset: 0x34D9331 VA: 0x34D9230 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x34D8E30 Offset: 0x34D8F31 VA: 0x34D8E30 Slot: 4
	public void Dispose() { }

	// RVA: 0x34D93C0 Offset: 0x34D94C1 VA: 0x34D93C0 Slot: 16
	protected virtual void Dispose(bool disposing) { }

	// RVA: 0x34D93D0 Offset: 0x34D94D1 VA: 0x34D93D0 Slot: 1
	protected override void Finalize() { }

	// RVA: 0x34D9450 Offset: 0x34D9551 VA: 0x34D9450
	protected void .ctor() { }
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
internal static class X509Helper // TypeDefIndex: 983
{
	// Fields
	private static INativeCertificateHelper nativeHelper; // 0x0

	// Methods

	// RVA: 0x34DA3B0 Offset: 0x34DA4B1 VA: 0x34DA3B0
	internal static void InstallNativeHelper(INativeCertificateHelper helper) { }

	// RVA: 0x34DA430 Offset: 0x34DA531 VA: 0x34DA430
	private static X509CertificateImpl Import(byte[] rawData) { }

	// RVA: 0x34D8020 Offset: 0x34D8121 VA: 0x34D8020
	public static X509CertificateImpl InitFromCertificate(X509CertificateImpl impl) { }

	// RVA: 0x34D8240 Offset: 0x34D8341 VA: 0x34D8240
	public static bool IsValid(X509CertificateImpl impl) { }

	// RVA: 0x34D81D0 Offset: 0x34D82D1 VA: 0x34D81D0
	internal static void ThrowIfContextInvalid(X509CertificateImpl impl) { }

	// RVA: 0x34D9110 Offset: 0x34D9211 VA: 0x34D9110
	internal static Exception GetInvalidContextException() { }

	// RVA: 0x34DA620 Offset: 0x34DA721 VA: 0x34DA620
	internal static X509Certificate ImportPkcs12(byte[] rawData, string password) { }

	// RVA: 0x34DAA20 Offset: 0x34DAB21 VA: 0x34DAA20
	private static byte[] PEM(string type, byte[] data) { }

	// RVA: 0x34DAB50 Offset: 0x34DAC51 VA: 0x34DAB50
	private static byte[] ConvertData(byte[] data) { }

	// RVA: 0x34DA440 Offset: 0x34DA541 VA: 0x34DA440
	private static X509CertificateImpl ImportCore(byte[] rawData) { }

	// RVA: 0x34D8B20 Offset: 0x34D8C21 VA: 0x34D8B20
	public static X509CertificateImpl Import(byte[] rawData, string password, X509KeyStorageFlags keyStorageFlags) { }

	// RVA: 0x34D84A0 Offset: 0x34D85A1 VA: 0x34D84A0
	public static string ToHexString(byte[] data) { }
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
[FlagsAttribute] // RVA: 0x30590 Offset: 0x30691 VA: 0x30590
public enum X509KeyUsageFlags // TypeDefIndex: 2349
{
	// Fields
	public int value__; // 0x0
	public const X509KeyUsageFlags None = 0;
	public const X509KeyUsageFlags EncipherOnly = 1;
	public const X509KeyUsageFlags CrlSign = 2;
	public const X509KeyUsageFlags KeyCertSign = 4;
	public const X509KeyUsageFlags KeyAgreement = 8;
	public const X509KeyUsageFlags DataEncipherment = 16;
	public const X509KeyUsageFlags KeyEncipherment = 32;
	public const X509KeyUsageFlags NonRepudiation = 64;
	public const X509KeyUsageFlags DigitalSignature = 128;
	public const X509KeyUsageFlags DecipherOnly = 32768;
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
public enum X509RevocationMode // TypeDefIndex: 2351
{
	// Fields
	public int value__; // 0x0
	public const X509RevocationMode NoCheck = 0;
	public const X509RevocationMode Online = 1;
	public const X509RevocationMode Offline = 2;
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
[FlagsAttribute] // RVA: 0x305A0 Offset: 0x306A1 VA: 0x305A0
public enum X509VerificationFlags // TypeDefIndex: 2353
{
	// Fields
	public int value__; // 0x0
	public const X509VerificationFlags NoFlag = 0;
	public const X509VerificationFlags IgnoreNotTimeValid = 1;
	public const X509VerificationFlags IgnoreCtlNotTimeValid = 2;
	public const X509VerificationFlags IgnoreNotTimeNested = 4;
	public const X509VerificationFlags IgnoreInvalidBasicConstraints = 8;
	public const X509VerificationFlags AllowUnknownCertificateAuthority = 16;
	public const X509VerificationFlags IgnoreWrongUsage = 32;
	public const X509VerificationFlags IgnoreInvalidName = 64;
	public const X509VerificationFlags IgnoreInvalidPolicy = 128;
	public const X509VerificationFlags IgnoreEndRevocationUnknown = 256;
	public const X509VerificationFlags IgnoreCtlSignerRevocationUnknown = 512;
	public const X509VerificationFlags IgnoreCertificateAuthorityRevocationUnknown = 1024;
	public const X509VerificationFlags IgnoreRootRevocationUnknown = 2048;
	public const X509VerificationFlags AllFlags = 4095;
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
public sealed class X509BasicConstraintsExtension : X509Extension // TypeDefIndex: 2357
{
	// Fields
	internal const string oid = "2.5.29.19";
	internal const string friendlyName = "Basic Constraints";
	private bool _certificateAuthority; // 0x21
	private bool _hasPathLengthConstraint; // 0x22
	private int _pathLengthConstraint; // 0x24
	private AsnDecodeStatus _status; // 0x28

	// Properties
	public bool CertificateAuthority { get; }
	public bool HasPathLengthConstraint { get; }
	public int PathLengthConstraint { get; }

	// Methods

	// RVA: 0x1955E90 Offset: 0x1955F91 VA: 0x1955E90
	public void .ctor() { }

	// RVA: 0x1955F50 Offset: 0x1956051 VA: 0x1955F50
	public void .ctor(AsnEncodedData encodedBasicConstraints, bool critical) { }

	// RVA: 0x1956250 Offset: 0x1956351 VA: 0x1956250
	public void .ctor(bool certificateAuthority, bool hasPathLengthConstraint, int pathLengthConstraint, bool critical) { }

	// RVA: 0x19564F0 Offset: 0x19565F1 VA: 0x19564F0
	public bool get_CertificateAuthority() { }

	// RVA: 0x1956570 Offset: 0x1956671 VA: 0x1956570
	public bool get_HasPathLengthConstraint() { }

	// RVA: 0x19565F0 Offset: 0x19566F1 VA: 0x19565F0
	public int get_PathLengthConstraint() { }

	// RVA: 0x1956670 Offset: 0x1956771 VA: 0x1956670 Slot: 4
	public override void CopyFrom(AsnEncodedData asnEncodedData) { }

	// RVA: 0x1956040 Offset: 0x1956141 VA: 0x1956040
	internal AsnDecodeStatus Decode(byte[] extension) { }

	// RVA: 0x19563A0 Offset: 0x19564A1 VA: 0x19563A0
	internal byte[] Encode() { }

	// RVA: 0x1956850 Offset: 0x1956951 VA: 0x1956850 Slot: 5
	internal override string ToString(bool multiLine) { }
}

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
[DefaultMemberAttribute] // RVA: 0x305F0 Offset: 0x306F1 VA: 0x305F0
public class X509Certificate2Collection : X509CertificateCollection // TypeDefIndex: 2359
{
	// Fields
	private static string[] newline_split; // 0x0

	// Methods

	// RVA: 0x1957F70 Offset: 0x1958071 VA: 0x1957F70
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
internal class X509Certificate2ImplMono : X509Certificate2Impl // TypeDefIndex: 2361
{
	// Fields
	private bool _archived; // 0x18
	private X509ExtensionCollection _extensions; // 0x20
	private PublicKey _publicKey; // 0x28
	private X500DistinguishedName issuer_name; // 0x30
	private X500DistinguishedName subject_name; // 0x38
	private Oid signature_algorithm; // 0x40
	private X509CertificateImplCollection intermediateCerts; // 0x48
	private X509Certificate _cert; // 0x50
	private static string empty_error; // 0x0
	private static byte[] commonName; // 0x8
	private static byte[] email; // 0x10
	private static byte[] signedData; // 0x18

	// Properties
	public override bool IsValid { get; }
	public override AsymmetricAlgorithm PrivateKey { get; }
	public override PublicKey PublicKey { get; }
	public override Oid SignatureAlgorithm { get; }
	public override int Version { get; }
	internal override X509CertificateImplCollection IntermediateCertificates { get; }

	// Methods

	// RVA: 0x1958050 Offset: 0x1958151 VA: 0x1958050 Slot: 5
	public override bool get_IsValid() { }

	// RVA: 0x1958060 Offset: 0x1958161 VA: 0x1958060
	private void .ctor(X509Certificate cert) { }

	// RVA: 0x19580A0 Offset: 0x19581A1 VA: 0x19580A0
	private void .ctor(X509Certificate2ImplMono other) { }

	// RVA: 0x19581B0 Offset: 0x19582B1 VA: 0x19581B0 Slot: 6
	public override X509CertificateImpl Clone() { }

	// RVA: 0x1958290 Offset: 0x1958391 VA: 0x1958290 Slot: 7
	public override string GetIssuerName(bool legacyV1Mode) { }

	// RVA: 0x1958350 Offset: 0x1958451 VA: 0x1958350 Slot: 8
	public override string GetSubjectName(bool legacyV1Mode) { }

	// RVA: 0x1958420 Offset: 0x1958521 VA: 0x1958420 Slot: 9
	public override byte[] GetRawCertData() { }

	// RVA: 0x1958450 Offset: 0x1958551 VA: 0x1958450 Slot: 12
	protected override byte[] GetCertHash(bool lazy) { }

	// RVA: 0x19584A0 Offset: 0x19585A1 VA: 0x19584A0 Slot: 10
	public override DateTime GetValidFrom() { }

	// RVA: 0x19584E0 Offset: 0x19585E1 VA: 0x19584E0 Slot: 11
	public override DateTime GetValidUntil() { }

	// RVA: 0x1958520 Offset: 0x1958621 VA: 0x1958520 Slot: 13
	public override bool Equals(X509CertificateImpl other, out bool result) { }

	// RVA: 0x1958530 Offset: 0x1958631 VA: 0x1958530 Slot: 14
	public override byte[] GetSerialNumber() { }

	// RVA: 0x1958560 Offset: 0x1958661 VA: 0x1958560
	public void .ctor() { }

	// RVA: 0x1958590 Offset: 0x1958691 VA: 0x1958590 Slot: 17
	public override AsymmetricAlgorithm get_PrivateKey() { }

	// RVA: 0x19588A0 Offset: 0x19589A1 VA: 0x19588A0 Slot: 18
	public override PublicKey get_PublicKey() { }

	// RVA: 0x1958A80 Offset: 0x1958B81 VA: 0x1958A80 Slot: 19
	public override Oid get_SignatureAlgorithm() { }

	// RVA: 0x1958BB0 Offset: 0x1958CB1 VA: 0x1958BB0 Slot: 20
	public override int get_Version() { }

	// RVA: 0x1958C60 Offset: 0x1958D61 VA: 0x1958C60
	private X509Certificate ImportPkcs12(byte[] rawData, string password) { }

	[MonoTODOAttribute] // RVA: 0x32210 Offset: 0x32311 VA: 0x32210
	// RVA: 0x19594C0 Offset: 0x19595C1 VA: 0x19594C0 Slot: 22
	public override void Import(byte[] rawData, string password, X509KeyStorageFlags keyStorageFlags) { }

	// RVA: 0x1959740 Offset: 0x1959841 VA: 0x1959740 Slot: 23
	public override void Reset() { }

	// RVA: 0x19598D0 Offset: 0x19599D1 VA: 0x19598D0 Slot: 3
	public override string ToString() { }

	// RVA: 0x1959940 Offset: 0x1959A41 VA: 0x1959940 Slot: 15
	public override string ToString(bool verbose) { }

	// RVA: 0x1959FF0 Offset: 0x195A0F1 VA: 0x1959FF0
	private static void AppendBuffer(StringBuilder sb, byte[] buffer) { }

	// RVA: 0x195A0F0 Offset: 0x195A1F1 VA: 0x195A0F0 Slot: 21
	internal override X509CertificateImplCollection get_IntermediateCertificates() { }

	// RVA: 0x195A100 Offset: 0x195A201 VA: 0x195A100
	private static void .cctor() { }
}

// Namespace: System.Security.Cryptography.X509Certificates
[DefaultMemberAttribute] // RVA: 0x30630 Offset: 0x30731 VA: 0x30630
[Serializable]
public class X509CertificateCollection : CollectionBase // TypeDefIndex: 2363
{
	// Properties
	public X509Certificate Item { get; }

	// Methods

	// RVA: 0x195A270 Offset: 0x195A371 VA: 0x195A270
	public void .ctor() { }

	// RVA: 0x195A280 Offset: 0x195A381 VA: 0x195A280
	public void .ctor(X509CertificateCollection value) { }

	// RVA: 0x195A430 Offset: 0x195A531 VA: 0x195A430
	public X509Certificate get_Item(int index) { }

	// RVA: 0x195A2B0 Offset: 0x195A3B1 VA: 0x195A2B0
	public void AddRange(X509CertificateCollection value) { }

	// RVA: 0x195A4E0 Offset: 0x195A5E1 VA: 0x195A4E0
	public X509CertificateCollection.X509CertificateEnumerator GetEnumerator() { }

	// RVA: 0x195A550 Offset: 0x195A651 VA: 0x195A550 Slot: 2
	public override int GetHashCode() { }
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
public class X509Chain : IDisposable // TypeDefIndex: 2365
{
	// Fields
	private X509ChainImpl impl; // 0x10

	// Properties
	internal X509ChainImpl Impl { get; }
	public X509ChainElementCollection ChainElements { get; }
	public X509ChainPolicy ChainPolicy { set; }

	// Methods

	// RVA: 0x195AA50 Offset: 0x195AB51 VA: 0x195AA50
	internal X509ChainImpl get_Impl() { }

	// RVA: 0x195AB00 Offset: 0x195AC01 VA: 0x195AB00
	public void .ctor() { }

	// RVA: 0x195AB80 Offset: 0x195AC81 VA: 0x195AB80
	public void .ctor(bool useMachineContext) { }

	// RVA: 0x195AC70 Offset: 0x195AD71 VA: 0x195AC70
	internal void .ctor(X509ChainImpl impl) { }

	// RVA: 0x195ACE0 Offset: 0x195ADE1 VA: 0x195ACE0
	public X509ChainElementCollection get_ChainElements() { }

	// RVA: 0x195AD40 Offset: 0x195AE41 VA: 0x195AD40
	public void set_ChainPolicy(X509ChainPolicy value) { }

	// RVA: 0x195ADB0 Offset: 0x195AEB1 VA: 0x195ADB0 Slot: 4
	public void Dispose() { }

	// RVA: 0x195AE30 Offset: 0x195AF31 VA: 0x195AE30 Slot: 5
	protected virtual void Dispose(bool disposing) { }

	// RVA: 0x195AF60 Offset: 0x195B061 VA: 0x195AF60 Slot: 1
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
[DefaultMemberAttribute] // RVA: 0x306B0 Offset: 0x307B1 VA: 0x306B0
public sealed class X509ChainElementCollection : ICollection, IEnumerable // TypeDefIndex: 2367
{
	// Fields
	private ArrayList _list; // 0x10

	// Properties
	public int Count { get; }
	public bool IsSynchronized { get; }
	public X509ChainElement Item { get; }
	public object SyncRoot { get; }

	// Methods

	// RVA: 0x195B070 Offset: 0x195B171 VA: 0x195B070
	internal void .ctor() { }

	// RVA: 0x195B0F0 Offset: 0x195B1F1 VA: 0x195B0F0 Slot: 5
	public int get_Count() { }

	// RVA: 0x195B110 Offset: 0x195B211 VA: 0x195B110 Slot: 7
	public bool get_IsSynchronized() { }

	// RVA: 0x195B130 Offset: 0x195B231 VA: 0x195B130
	public X509ChainElement get_Item(int index) { }

	// RVA: 0x195B1D0 Offset: 0x195B2D1 VA: 0x195B1D0 Slot: 6
	public object get_SyncRoot() { }

	// RVA: 0x195B1F0 Offset: 0x195B2F1 VA: 0x195B1F0 Slot: 4
	private void System.Collections.ICollection.CopyTo(Array array, int index) { }

	// RVA: 0x195B210 Offset: 0x195B311 VA: 0x195B210 Slot: 8
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	// RVA: 0x195B3D0 Offset: 0x195B4D1 VA: 0x195B3D0
	internal void Add(X509Certificate2 certificate) { }

	// RVA: 0x195B4B0 Offset: 0x195B5B1 VA: 0x195B4B0
	internal void Clear() { }
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
internal abstract class X509ChainImpl : IDisposable // TypeDefIndex: 2369
{
	// Properties
	public abstract bool IsValid { get; }
	public abstract X509ChainElementCollection ChainElements { get; }
	public abstract X509ChainPolicy ChainPolicy { set; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 5
	public abstract bool get_IsValid();

	// RVA: 0x195B6E0 Offset: 0x195B7E1 VA: 0x195B6E0
	protected void ThrowIfContextInvalid() { }

	// RVA: -1 Offset: -1 Slot: 6
	public abstract X509ChainElementCollection get_ChainElements();

	// RVA: -1 Offset: -1 Slot: 7
	public abstract void set_ChainPolicy(X509ChainPolicy value);

	// RVA: -1 Offset: -1 Slot: 8
	public abstract void Reset();

	// RVA: 0x195AEE0 Offset: 0x195AFE1 VA: 0x195AEE0 Slot: 4
	public void Dispose() { }

	// RVA: 0x195B7C0 Offset: 0x195B8C1 VA: 0x195B7C0 Slot: 9
	protected virtual void Dispose(bool disposing) { }

	// RVA: 0x195B7D0 Offset: 0x195B8D1 VA: 0x195B7D0 Slot: 1
	protected override void Finalize() { }

	// RVA: 0x195B850 Offset: 0x195B951 VA: 0x195B850
	protected void .ctor() { }
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
public sealed class X509ChainPolicy // TypeDefIndex: 2371
{
	// Fields
	private OidCollection apps; // 0x10
	private OidCollection cert; // 0x18
	private X509CertificateCollection store; // 0x20
	private X509Certificate2Collection store2; // 0x28
	private X509RevocationFlag rflag; // 0x30
	private X509RevocationMode mode; // 0x34
	private TimeSpan timeout; // 0x38
	private X509VerificationFlags vflags; // 0x40
	private DateTime vtime; // 0x48

	// Methods

	// RVA: 0x195B980 Offset: 0x195BA81 VA: 0x195B980
	public void .ctor() { }

	// RVA: 0x195C2B0 Offset: 0x195C3B1 VA: 0x195C2B0
	internal void .ctor(X509CertificateCollection store) { }

	// RVA: 0x195C170 Offset: 0x195C271 VA: 0x195C170
	public void Reset() { }
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
public sealed class X509EnhancedKeyUsageExtension : X509Extension // TypeDefIndex: 2373
{
	// Fields
	private OidCollection _enhKeyUsage; // 0x28
	private AsnDecodeStatus _status; // 0x30

	// Methods

	// RVA: 0x195C4C0 Offset: 0x195C5C1 VA: 0x195C4C0
	public void .ctor(AsnEncodedData encodedEnhancedKeyUsages, bool critical) { }

	// RVA: 0x195C810 Offset: 0x195C911 VA: 0x195C810 Slot: 4
	public override void CopyFrom(AsnEncodedData asnEncodedData) { }

	// RVA: 0x195C5B0 Offset: 0x195C6B1 VA: 0x195C5B0
	internal AsnDecodeStatus Decode(byte[] extension) { }

	// RVA: 0x195C9F0 Offset: 0x195CAF1 VA: 0x195C9F0 Slot: 5
	internal override string ToString(bool multiLine) { }
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
[DefaultMemberAttribute] // RVA: 0x306F0 Offset: 0x307F1 VA: 0x306F0
public sealed class X509ExtensionCollection // TypeDefIndex: 2375
{
	// Fields
	private static byte[] Empty; // 0x0

	// Methods

	// RVA: 0x195CEB0 Offset: 0x195CFB1 VA: 0x195CEB0
	private static void .cctor() { }
}

// Namespace: System.Security.Cryptography.X509Certificates
internal static class X509Helper2 // TypeDefIndex: 2377
{
	// Methods

	// RVA: 0x195CF30 Offset: 0x195D031 VA: 0x195CF30
	internal static void Initialize() { }

	// RVA: 0x1956C90 Offset: 0x1956D91 VA: 0x1956C90
	internal static void ThrowIfContextInvalid(X509CertificateImpl impl) { }

	// RVA: 0x1957340 Offset: 0x1957441 VA: 0x1957340
	internal static X509Certificate2Impl Import(byte[] rawData, string password, X509KeyStorageFlags keyStorageFlags, bool disableProvider = False) { }

	// RVA: 0x195AC00 Offset: 0x195AD01 VA: 0x195AC00
	internal static X509ChainImpl CreateChainImpl(bool useMachineContext) { }

	// RVA: 0x195CF90 Offset: 0x195D091 VA: 0x195CF90
	public static bool IsValid(X509ChainImpl impl) { }

	// RVA: 0x195AAB0 Offset: 0x195ABB1 VA: 0x195AAB0
	internal static void ThrowIfContextInvalid(X509ChainImpl impl) { }

	// RVA: 0x195B730 Offset: 0x195B831 VA: 0x195B730
	internal static Exception GetInvalidChainContextException() { }
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
public sealed class X509Store // TypeDefIndex: 2379
{
	// Fields
	private X509Certificate2Collection list; // 0x10
	private X509Store store; // 0x18

	// Methods

	// RVA: 0x1913FF0 Offset: 0x19140F1 VA: 0x1913FF0
	public void Close() { }
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

