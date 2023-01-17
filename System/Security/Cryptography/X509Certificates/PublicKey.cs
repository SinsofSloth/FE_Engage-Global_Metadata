// Namespace: System.Security.Cryptography.X509Certificates
public sealed class PublicKey // TypeDefIndex: 2355
{
	// Fields
	private AsymmetricAlgorithm _key; // 0x10
	private AsnEncodedData _keyValue; // 0x18
	private AsnEncodedData _params; // 0x20
	private Oid _oid; // 0x28
	private static byte[] Empty; // 0x0

	// Properties
	public AsnEncodedData EncodedKeyValue { get; }
	public AsnEncodedData EncodedParameters { get; }
	public AsymmetricAlgorithm Key { get; }
	public Oid Oid { get; }

	// Methods

	// RVA: 0x3BFD3C0 Offset: 0x3BFD4C1 VA: 0x3BFD3C0
	internal void .ctor(X509Certificate certificate) { }

	// RVA: 0x3BFD860 Offset: 0x3BFD961 VA: 0x3BFD860
	public AsnEncodedData get_EncodedKeyValue() { }

	// RVA: 0x3BFD870 Offset: 0x3BFD971 VA: 0x3BFD870
	public AsnEncodedData get_EncodedParameters() { }

	// RVA: 0x3BFD880 Offset: 0x3BFD981 VA: 0x3BFD880
	public AsymmetricAlgorithm get_Key() { }

	// RVA: 0x3BFE500 Offset: 0x3BFE601 VA: 0x3BFE500
	public Oid get_Oid() { }

	// RVA: 0x3BFE510 Offset: 0x3BFE611 VA: 0x3BFE510
	private static byte[] GetUnsignedBigInteger(byte[] integer) { }

	// RVA: 0x3BFDE70 Offset: 0x3BFDF71 VA: 0x3BFDE70
	internal static DSA DecodeDSA(byte[] rawPublicKey, byte[] rawParameters) { }

	// RVA: 0x3BFDA40 Offset: 0x3BFDB41 VA: 0x3BFDA40
	internal static RSA DecodeRSA(byte[] rawPublicKey) { }

	// RVA: 0x3BFE5B0 Offset: 0x3BFE6B1 VA: 0x3BFE5B0
	private static void .cctor() { }
}

