// Namespace: 
public class PKCS7.ContentInfo // TypeDefIndex: 47
{
	// Fields
	private string contentType; // 0x10
	private ASN1 content; // 0x18

	// Properties
	public ASN1 ASN1 { get; }
	public ASN1 Content { get; set; }
	public string ContentType { get; set; }

	// Methods

	// RVA: 0x35F0C90 Offset: 0x35F0D91 VA: 0x35F0C90
	public void .ctor() { }

	// RVA: 0x35F0D10 Offset: 0x35F0E11 VA: 0x35F0D10
	public void .ctor(string oid) { }

	// RVA: 0x35F0DA0 Offset: 0x35F0EA1 VA: 0x35F0DA0
	public void .ctor(byte[] data) { }

	// RVA: 0x35F0E10 Offset: 0x35F0F11 VA: 0x35F0E10
	public void .ctor(ASN1 asn1) { }

	// RVA: 0x35F0F90 Offset: 0x35F1091 VA: 0x35F0F90
	public ASN1 get_ASN1() { }

	// RVA: 0x35F1050 Offset: 0x35F1151 VA: 0x35F1050
	public ASN1 get_Content() { }

	// RVA: 0x35F1060 Offset: 0x35F1161 VA: 0x35F1060
	public void set_Content(ASN1 value) { }

	// RVA: 0x35F1070 Offset: 0x35F1171 VA: 0x35F1070
	public string get_ContentType() { }

	// RVA: 0x35F1080 Offset: 0x35F1181 VA: 0x35F1080
	public void set_ContentType(string value) { }

	// RVA: 0x35F0FA0 Offset: 0x35F10A1 VA: 0x35F0FA0
	internal ASN1 GetASN1() { }
}

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
public class PKCS12.DeriveBytes // TypeDefIndex: 51
{
	// Fields
	private static byte[] keyDiversifier; // 0x0
	private static byte[] ivDiversifier; // 0x8
	private static byte[] macDiversifier; // 0x10
	private string _hashName; // 0x10
	private int _iterations; // 0x18
	private byte[] _password; // 0x20
	private byte[] _salt; // 0x28

	// Properties
	public string HashName { set; }
	public int IterationCount { set; }
	public byte[] Password { set; }
	public byte[] Salt { set; }

	// Methods

	// RVA: 0x35F0370 Offset: 0x35F0471 VA: 0x35F0370
	public void .ctor() { }

	// RVA: 0x35F0380 Offset: 0x35F0481 VA: 0x35F0380
	public void set_HashName(string value) { }

	// RVA: 0x35F0390 Offset: 0x35F0491 VA: 0x35F0390
	public void set_IterationCount(int value) { }

	// RVA: 0x35F03A0 Offset: 0x35F04A1 VA: 0x35F03A0
	public void set_Password(byte[] value) { }

	// RVA: 0x35F0450 Offset: 0x35F0551 VA: 0x35F0450
	public void set_Salt(byte[] value) { }

	// RVA: 0x35F0500 Offset: 0x35F0601 VA: 0x35F0500
	private void Adjust(byte[] a, int aOff, byte[] b) { }

	// RVA: 0x35F05D0 Offset: 0x35F06D1 VA: 0x35F05D0
	private byte[] Derive(byte[] diversifier, int n) { }

	// RVA: 0x35F09E0 Offset: 0x35F0AE1 VA: 0x35F09E0
	public byte[] DeriveKey(int size) { }

	// RVA: 0x35F0A60 Offset: 0x35F0B61 VA: 0x35F0A60
	public byte[] DeriveIV(int size) { }

	// RVA: 0x35F0AE0 Offset: 0x35F0BE1 VA: 0x35F0AE0
	public byte[] DeriveMAC(int size) { }

	// RVA: 0x35F0B60 Offset: 0x35F0C61 VA: 0x35F0B60
	private static void .cctor() { }
}

// Namespace: 
public class PKCS8.PrivateKeyInfo // TypeDefIndex: 67
{
	// Fields
	private int _version; // 0x10
	private string _algorithm; // 0x18
	private byte[] _key; // 0x20
	private ArrayList _list; // 0x28

	// Properties
	public byte[] PrivateKey { get; }

	// Methods

	// RVA: 0x35F1960 Offset: 0x35F1A61 VA: 0x35F1960
	public void .ctor() { }

	// RVA: 0x35F19E0 Offset: 0x35F1AE1 VA: 0x35F19E0
	public void .ctor(byte[] data) { }

	// RVA: 0x35F1CC0 Offset: 0x35F1DC1 VA: 0x35F1CC0
	public byte[] get_PrivateKey() { }

	// RVA: 0x35F1A70 Offset: 0x35F1B71 VA: 0x35F1A70
	private void Decode(byte[] data) { }

	// RVA: 0x35F1D40 Offset: 0x35F1E41 VA: 0x35F1D40
	private static byte[] RemoveLeadingZero(byte[] bigInt) { }

	// RVA: 0x35F1DE0 Offset: 0x35F1EE1 VA: 0x35F1DE0
	private static byte[] Normalize(byte[] bigInt, int length) { }

	// RVA: 0x35F1F00 Offset: 0x35F2001 VA: 0x35F1F00
	public static RSA DecodeRSA(byte[] keypair) { }

	// RVA: 0x35F2450 Offset: 0x35F2551 VA: 0x35F2450
	public static DSA DecodeDSA(byte[] privateKey, DSAParameters dsaParameters) { }
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
public class PKCS7.ContentInfo // TypeDefIndex: 1529
{
	// Fields
	private string contentType; // 0x10
	private ASN1 content; // 0x18

	// Properties
	public ASN1 ASN1 { get; }
	public ASN1 Content { get; set; }
	public string ContentType { get; set; }

	// Methods

	// RVA: 0x1C55E50 Offset: 0x1C55F51 VA: 0x1C55E50
	public void .ctor() { }

	// RVA: 0x1C55ED0 Offset: 0x1C55FD1 VA: 0x1C55ED0
	public void .ctor(string oid) { }

	// RVA: 0x1C55F60 Offset: 0x1C56061 VA: 0x1C55F60
	public void .ctor(byte[] data) { }

	// RVA: 0x1C55FD0 Offset: 0x1C560D1 VA: 0x1C55FD0
	public void .ctor(ASN1 asn1) { }

	// RVA: 0x1C56150 Offset: 0x1C56251 VA: 0x1C56150
	public ASN1 get_ASN1() { }

	// RVA: 0x1C56210 Offset: 0x1C56311 VA: 0x1C56210
	public ASN1 get_Content() { }

	// RVA: 0x1C56220 Offset: 0x1C56321 VA: 0x1C56220
	public void set_Content(ASN1 value) { }

	// RVA: 0x1C56230 Offset: 0x1C56331 VA: 0x1C56230
	public string get_ContentType() { }

	// RVA: 0x1C56240 Offset: 0x1C56341 VA: 0x1C56240
	public void set_ContentType(string value) { }

	// RVA: 0x1C56160 Offset: 0x1C56261 VA: 0x1C56160
	internal ASN1 GetASN1() { }
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
public class PKCS12.DeriveBytes // TypeDefIndex: 1533
{
	// Fields
	private static byte[] keyDiversifier; // 0x0
	private static byte[] ivDiversifier; // 0x8
	private static byte[] macDiversifier; // 0x10
	private string _hashName; // 0x10
	private int _iterations; // 0x18
	private byte[] _password; // 0x20
	private byte[] _salt; // 0x28

	// Properties
	public string HashName { set; }
	public int IterationCount { set; }
	public byte[] Password { set; }
	public byte[] Salt { set; }

	// Methods

	// RVA: 0x1C55530 Offset: 0x1C55631 VA: 0x1C55530
	public void .ctor() { }

	// RVA: 0x1C55540 Offset: 0x1C55641 VA: 0x1C55540
	public void set_HashName(string value) { }

	// RVA: 0x1C55550 Offset: 0x1C55651 VA: 0x1C55550
	public void set_IterationCount(int value) { }

	// RVA: 0x1C55560 Offset: 0x1C55661 VA: 0x1C55560
	public void set_Password(byte[] value) { }

	// RVA: 0x1C55610 Offset: 0x1C55711 VA: 0x1C55610
	public void set_Salt(byte[] value) { }

	// RVA: 0x1C556C0 Offset: 0x1C557C1 VA: 0x1C556C0
	private void Adjust(byte[] a, int aOff, byte[] b) { }

	// RVA: 0x1C55790 Offset: 0x1C55891 VA: 0x1C55790
	private byte[] Derive(byte[] diversifier, int n) { }

	// RVA: 0x1C55BA0 Offset: 0x1C55CA1 VA: 0x1C55BA0
	public byte[] DeriveKey(int size) { }

	// RVA: 0x1C55C20 Offset: 0x1C55D21 VA: 0x1C55C20
	public byte[] DeriveIV(int size) { }

	// RVA: 0x1C55CA0 Offset: 0x1C55DA1 VA: 0x1C55CA0
	public byte[] DeriveMAC(int size) { }

	// RVA: 0x1C55D20 Offset: 0x1C55E21 VA: 0x1C55D20
	private static void .cctor() { }
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

// Namespace: 
public class PKCS8.EncryptedPrivateKeyInfo // TypeDefIndex: 1575
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

	// RVA: 0x1C566C0 Offset: 0x1C567C1 VA: 0x1C566C0
	public void .ctor() { }

	// RVA: 0x1C566D0 Offset: 0x1C567D1 VA: 0x1C566D0
	public void .ctor(byte[] data) { }

	// RVA: 0x1C569A0 Offset: 0x1C56AA1 VA: 0x1C569A0
	public string get_Algorithm() { }

	// RVA: 0x1C569B0 Offset: 0x1C56AB1 VA: 0x1C569B0
	public byte[] get_EncryptedData() { }

	// RVA: 0x1C56A30 Offset: 0x1C56B31 VA: 0x1C56A30
	public byte[] get_Salt() { }

	// RVA: 0x1C56B10 Offset: 0x1C56C11 VA: 0x1C56B10
	public int get_IterationCount() { }

	// RVA: 0x1C56700 Offset: 0x1C56801 VA: 0x1C56700
	private void Decode(byte[] data) { }
}

