// Namespace: 
public class PKCS7.EncryptedData // TypeDefIndex: 48
{
	// Fields
	private byte _version; // 0x10
	private PKCS7.ContentInfo _content; // 0x18
	private PKCS7.ContentInfo _encryptionAlgorithm; // 0x20
	private byte[] _encrypted; // 0x28

	// Properties
	public PKCS7.ContentInfo EncryptionAlgorithm { get; }
	public byte[] EncryptedContent { get; }

	// Methods

	// RVA: 0x35F1090 Offset: 0x35F1191 VA: 0x35F1090
	public void .ctor() { }

	// RVA: 0x35F10C0 Offset: 0x35F11C1 VA: 0x35F10C0
	public void .ctor(ASN1 asn1) { }

	// RVA: 0x35F1470 Offset: 0x35F1571 VA: 0x35F1470
	public PKCS7.ContentInfo get_EncryptionAlgorithm() { }

	// RVA: 0x35F1480 Offset: 0x35F1581 VA: 0x35F1480
	public byte[] get_EncryptedContent() { }
}

// Namespace: 
public class PKCS8.EncryptedPrivateKeyInfo // TypeDefIndex: 68
{
	// Fields
	private string _algorithm; // 0x10
	private byte[] _salt; // 0x18
	private int _iterations; // 0x20
	private byte[] _data; // 0x28

	// Properties
	public string Algorithm { get; }
	public byte[] EncryptedData { get; }
	public byte[] Salt { get; }
	public int IterationCount { get; }

	// Methods

	// RVA: 0x35F1500 Offset: 0x35F1601 VA: 0x35F1500
	public void .ctor() { }

	// RVA: 0x35F1510 Offset: 0x35F1611 VA: 0x35F1510
	public void .ctor(byte[] data) { }

	// RVA: 0x35F17E0 Offset: 0x35F18E1 VA: 0x35F17E0
	public string get_Algorithm() { }

	// RVA: 0x35F17F0 Offset: 0x35F18F1 VA: 0x35F17F0
	public byte[] get_EncryptedData() { }

	// RVA: 0x35F1870 Offset: 0x35F1971 VA: 0x35F1870
	public byte[] get_Salt() { }

	// RVA: 0x35F1950 Offset: 0x35F1A51 VA: 0x35F1950
	public int get_IterationCount() { }

	// RVA: 0x35F1540 Offset: 0x35F1641 VA: 0x35F1540
	private void Decode(byte[] data) { }
}

// Namespace: 
public class PKCS7.EncryptedData // TypeDefIndex: 1530
{
	// Fields
	private byte _version; // 0x10
	private PKCS7.ContentInfo _content; // 0x18
	private PKCS7.ContentInfo _encryptionAlgorithm; // 0x20
	private byte[] _encrypted; // 0x28

	// Properties
	public PKCS7.ContentInfo EncryptionAlgorithm { get; }
	public byte[] EncryptedContent { get; }

	// Methods

	// RVA: 0x1C56250 Offset: 0x1C56351 VA: 0x1C56250
	public void .ctor() { }

	// RVA: 0x1C56280 Offset: 0x1C56381 VA: 0x1C56280
	public void .ctor(ASN1 asn1) { }

	// RVA: 0x1C56630 Offset: 0x1C56731 VA: 0x1C56630
	public PKCS7.ContentInfo get_EncryptionAlgorithm() { }

	// RVA: 0x1C56640 Offset: 0x1C56741 VA: 0x1C56640
	public byte[] get_EncryptedContent() { }
}

// Namespace: 
public class PKCS8.PrivateKeyInfo // TypeDefIndex: 1574
{
	// Fields
	private int _version; // 0x10
	private string _algorithm; // 0x18
	private byte[] _key; // 0x20
	private ArrayList _list; // 0x28

	// Properties
	public byte[] PrivateKey { get; }

	// Methods

	// RVA: 0x1C56B20 Offset: 0x1C56C21 VA: 0x1C56B20
	public void .ctor() { }

	// RVA: 0x1C56BA0 Offset: 0x1C56CA1 VA: 0x1C56BA0
	public void .ctor(byte[] data) { }

	// RVA: 0x1C56E80 Offset: 0x1C56F81 VA: 0x1C56E80
	public byte[] get_PrivateKey() { }

	// RVA: 0x1C56C30 Offset: 0x1C56D31 VA: 0x1C56C30
	private void Decode(byte[] data) { }

	// RVA: 0x1C56F00 Offset: 0x1C57001 VA: 0x1C56F00
	private static byte[] RemoveLeadingZero(byte[] bigInt) { }

	// RVA: 0x1C56FA0 Offset: 0x1C570A1 VA: 0x1C56FA0
	private static byte[] Normalize(byte[] bigInt, int length) { }

	// RVA: 0x1C570C0 Offset: 0x1C571C1 VA: 0x1C570C0
	public static RSA DecodeRSA(byte[] keypair) { }

	// RVA: 0x1C57610 Offset: 0x1C57711 VA: 0x1C57610
	public static byte[] Encode(RSA rsa) { }

	// RVA: 0x1C57800 Offset: 0x1C57901 VA: 0x1C57800
	public static DSA DecodeDSA(byte[] privateKey, DSAParameters dsaParameters) { }

	// RVA: 0x1C57960 Offset: 0x1C57A61 VA: 0x1C57960
	public static byte[] Encode(DSA dsa) { }

	// RVA: 0x1C579B0 Offset: 0x1C57AB1 VA: 0x1C579B0
	public static byte[] Encode(AsymmetricAlgorithm aa) { }
}

