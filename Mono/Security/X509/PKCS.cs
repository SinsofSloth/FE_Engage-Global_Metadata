// Namespace: Mono.Security.X509
internal class PKCS12 : ICloneable // TypeDefIndex: 52
{
	// Fields
	private byte[] _password; // 0x10
	private ArrayList _keyBags; // 0x18
	private ArrayList _secretBags; // 0x20
	private X509CertificateCollection _certs; // 0x28
	private bool _keyBagsChanged; // 0x30
	private bool _secretBagsChanged; // 0x31
	private bool _certsChanged; // 0x32
	private int _iterations; // 0x34
	private ArrayList _safeBags; // 0x38
	private RandomNumberGenerator _rng; // 0x40
	private static int password_max_length; // 0x0

	// Properties
	public string Password { set; }
	public int IterationCount { get; set; }
	public ArrayList Keys { get; }
	public X509CertificateCollection Certificates { get; }
	internal RandomNumberGenerator RNG { get; }
	public static int MaximumPasswordLength { get; }

	// Methods

	// RVA: 0x3811AF0 Offset: 0x3811BF1 VA: 0x3811AF0
	public void .ctor() { }

	// RVA: 0x3811C00 Offset: 0x3811D01 VA: 0x3811C00
	public void .ctor(byte[] data) { }

	// RVA: 0x3812660 Offset: 0x3812761 VA: 0x3812660
	public void .ctor(byte[] data, string password) { }

	// RVA: 0x3811ED0 Offset: 0x3811FD1 VA: 0x3811ED0
	private void Decode(byte[] data) { }

	// RVA: 0x3812FC0 Offset: 0x38130C1 VA: 0x3812FC0 Slot: 1
	protected override void Finalize() { }

	// RVA: 0x3811C90 Offset: 0x3811D91 VA: 0x3811C90
	public void set_Password(string value) { }

	// RVA: 0x3813060 Offset: 0x3813161 VA: 0x3813060
	public int get_IterationCount() { }

	// RVA: 0x3813070 Offset: 0x3813171 VA: 0x3813070
	public void set_IterationCount(int value) { }

	// RVA: 0x3813080 Offset: 0x3813181 VA: 0x3813080
	public ArrayList get_Keys() { }

	// RVA: 0x3813840 Offset: 0x3813941 VA: 0x3813840
	public X509CertificateCollection get_Certificates() { }

	// RVA: 0x3813BE0 Offset: 0x3813CE1 VA: 0x3813BE0
	internal RandomNumberGenerator get_RNG() { }

	// RVA: 0x3812810 Offset: 0x3812911 VA: 0x3812810
	private bool Compare(byte[] expected, byte[] actual) { }

	// RVA: 0x3813C30 Offset: 0x3813D31 VA: 0x3813C30
	private SymmetricAlgorithm GetSymmetricAlgorithm(string algorithmOid, byte[] salt, int iterationCount) { }

	// RVA: 0x38136A0 Offset: 0x38137A1 VA: 0x38136A0
	public byte[] Decrypt(string algorithmOid, byte[] salt, int iterationCount, byte[] encryptedData) { }

	// RVA: 0x3812F30 Offset: 0x3813031 VA: 0x3812F30
	public byte[] Decrypt(PKCS7.EncryptedData ed) { }

	// RVA: 0x3814340 Offset: 0x3814441 VA: 0x3814340
	public byte[] Encrypt(string algorithmOid, byte[] salt, int iterationCount, byte[] data) { }

	// RVA: 0x3814530 Offset: 0x3814631 VA: 0x3814530
	private DSAParameters GetExistingParameters(out bool found) { }

	// RVA: 0x3814780 Offset: 0x3814881 VA: 0x3814780
	private void AddPrivateKey(PKCS8.PrivateKeyInfo pki) { }

	// RVA: 0x3812890 Offset: 0x3812991 VA: 0x3812890
	private void ReadSafeBag(ASN1 safeBag) { }

	// RVA: 0x38148E0 Offset: 0x38149E1 VA: 0x38148E0
	private ASN1 CertificateSafeBag(X509Certificate x509, IDictionary attributes) { }

	// RVA: 0x38126B0 Offset: 0x38127B1 VA: 0x38126B0
	private byte[] MAC(byte[] password, byte[] salt, int iterations, byte[] data) { }

	// RVA: 0x38153E0 Offset: 0x38154E1 VA: 0x38153E0
	public byte[] GetBytes() { }

	// RVA: 0x3817000 Offset: 0x3817101 VA: 0x3817000
	private PKCS7.ContentInfo EncryptedContentInfo(ASN1 safeBags, string algorithmOid) { }

	// RVA: 0x3816FF0 Offset: 0x38170F1 VA: 0x3816FF0
	public void AddCertificate(X509Certificate cert) { }

	// RVA: 0x3817300 Offset: 0x3817401 VA: 0x3817300
	public void AddCertificate(X509Certificate cert, IDictionary attributes) { }

	// RVA: 0x3816FE0 Offset: 0x38170E1 VA: 0x3816FE0
	public void RemoveCertificate(X509Certificate cert) { }

	// RVA: 0x3817580 Offset: 0x3817681 VA: 0x3817580
	public void RemoveCertificate(X509Certificate cert, IDictionary attrs) { }

	// RVA: 0x3817AC0 Offset: 0x3817BC1 VA: 0x3817AC0 Slot: 4
	public object Clone() { }

	// RVA: 0x3817BE0 Offset: 0x3817CE1 VA: 0x3817BE0
	public static int get_MaximumPasswordLength() { }

	// RVA: 0x3817C50 Offset: 0x3817D51 VA: 0x3817C50
	private static void .cctor() { }
}

// Namespace: Mono.Security.X509
public class PKCS12 : ICloneable // TypeDefIndex: 1534
{
	// Fields
	private byte[] _password; // 0x10
	private ArrayList _keyBags; // 0x18
	private ArrayList _secretBags; // 0x20
	private X509CertificateCollection _certs; // 0x28
	private bool _keyBagsChanged; // 0x30
	private bool _secretBagsChanged; // 0x31
	private bool _certsChanged; // 0x32
	private int _iterations; // 0x34
	private ArrayList _safeBags; // 0x38
	private RandomNumberGenerator _rng; // 0x40
	private static int password_max_length; // 0x0

	// Properties
	public string Password { set; }
	public int IterationCount { get; set; }
	public ArrayList Keys { get; }
	public X509CertificateCollection Certificates { get; }
	internal RandomNumberGenerator RNG { get; }
	public static int MaximumPasswordLength { get; }

	// Methods

	// RVA: 0x1BCD760 Offset: 0x1BCD861 VA: 0x1BCD760
	public void .ctor() { }

	// RVA: 0x1BCD880 Offset: 0x1BCD981 VA: 0x1BCD880
	public void .ctor(byte[] data) { }

	// RVA: 0x1BCE570 Offset: 0x1BCE671 VA: 0x1BCE570
	public void .ctor(byte[] data, string password) { }

	// RVA: 0x1BCDB50 Offset: 0x1BCDC51 VA: 0x1BCDB50
	private void Decode(byte[] data) { }

	// RVA: 0x1BCF180 Offset: 0x1BCF281 VA: 0x1BCF180 Slot: 1
	protected override void Finalize() { }

	// RVA: 0x1BCD910 Offset: 0x1BCDA11 VA: 0x1BCD910
	public void set_Password(string value) { }

	// RVA: 0x1BCF220 Offset: 0x1BCF321 VA: 0x1BCF220
	public int get_IterationCount() { }

	// RVA: 0x1BCF230 Offset: 0x1BCF331 VA: 0x1BCF230
	public void set_IterationCount(int value) { }

	// RVA: 0x1BCF240 Offset: 0x1BCF341 VA: 0x1BCF240
	public ArrayList get_Keys() { }

	// RVA: 0x1BCFAE0 Offset: 0x1BCFBE1 VA: 0x1BCFAE0
	public X509CertificateCollection get_Certificates() { }

	// RVA: 0x1BD01B0 Offset: 0x1BD02B1 VA: 0x1BD01B0
	internal RandomNumberGenerator get_RNG() { }

	// RVA: 0x1BCE720 Offset: 0x1BCE821 VA: 0x1BCE720
	private bool Compare(byte[] expected, byte[] actual) { }

	// RVA: 0x1BD0200 Offset: 0x1BD0301 VA: 0x1BD0200
	private SymmetricAlgorithm GetSymmetricAlgorithm(string algorithmOid, byte[] salt, int iterationCount) { }

	// RVA: 0x1BCF940 Offset: 0x1BCFA41 VA: 0x1BCF940
	public byte[] Decrypt(string algorithmOid, byte[] salt, int iterationCount, byte[] encryptedData) { }

	// RVA: 0x1BCF070 Offset: 0x1BCF171 VA: 0x1BCF070
	public byte[] Decrypt(PKCS7.EncryptedData ed) { }

	// RVA: 0x1BD07D0 Offset: 0x1BD08D1 VA: 0x1BD07D0
	public byte[] Encrypt(string algorithmOid, byte[] salt, int iterationCount, byte[] data) { }

	// RVA: 0x1BD09C0 Offset: 0x1BD0AC1 VA: 0x1BD09C0
	private DSAParameters GetExistingParameters(out bool found) { }

	// RVA: 0x1BD1320 Offset: 0x1BD1421 VA: 0x1BD1320
	private void AddPrivateKey(PKCS8.PrivateKeyInfo pki) { }

	// RVA: 0x1BCE7A0 Offset: 0x1BCE8A1 VA: 0x1BCE7A0
	private void ReadSafeBag(ASN1 safeBag) { }

	// RVA: 0x1BD14D0 Offset: 0x1BD15D1 VA: 0x1BD14D0
	private ASN1 CertificateSafeBag(X509Certificate x509, IDictionary attributes) { }

	// RVA: 0x1BCE5C0 Offset: 0x1BCE6C1 VA: 0x1BCE5C0
	private byte[] MAC(byte[] password, byte[] salt, int iterations, byte[] data) { }

	// RVA: 0x1BD26C0 Offset: 0x1BD27C1 VA: 0x1BD26C0
	public byte[] GetBytes() { }

	// RVA: 0x1BD4CE0 Offset: 0x1BD4DE1 VA: 0x1BD4CE0
	private PKCS7.ContentInfo EncryptedContentInfo(ASN1 safeBags, string algorithmOid) { }

	// RVA: 0x1BD4CD0 Offset: 0x1BD4DD1 VA: 0x1BD4CD0
	public void AddCertificate(X509Certificate cert) { }

	// RVA: 0x1BD5460 Offset: 0x1BD5561 VA: 0x1BD5460
	public void AddCertificate(X509Certificate cert, IDictionary attributes) { }

	// RVA: 0x1BD4CC0 Offset: 0x1BD4DC1 VA: 0x1BD4CC0
	public void RemoveCertificate(X509Certificate cert) { }

	// RVA: 0x1BD57F0 Offset: 0x1BD58F1 VA: 0x1BD57F0
	public void RemoveCertificate(X509Certificate cert, IDictionary attrs) { }

	// RVA: 0x1BD5E70 Offset: 0x1BD5F71 VA: 0x1BD5E70 Slot: 4
	public object Clone() { }

	// RVA: 0x1BD5F90 Offset: 0x1BD6091 VA: 0x1BD5F90
	public static int get_MaximumPasswordLength() { }

	// RVA: 0x1BD6000 Offset: 0x1BD6101 VA: 0x1BD6000
	private static void .cctor() { }
}

