// Namespace: Mono.Security.X509
internal class X509Certificate : ISerializable // TypeDefIndex: 54
{
	// Fields
	private ASN1 decoder; // 0x10
	private byte[] m_encodedcert; // 0x18
	private DateTime m_from; // 0x20
	private DateTime m_until; // 0x28
	private ASN1 issuer; // 0x30
	private string m_issuername; // 0x38
	private string m_keyalgo; // 0x40
	private byte[] m_keyalgoparams; // 0x48
	private ASN1 subject; // 0x50
	private string m_subject; // 0x58
	private byte[] m_publickey; // 0x60
	private byte[] signature; // 0x68
	private string m_signaturealgo; // 0x70
	private byte[] m_signaturealgoparams; // 0x78
	private RSA _rsa; // 0x80
	private DSA _dsa; // 0x88
	private int version; // 0x90
	private byte[] serialnumber; // 0x98
	private byte[] issuerUniqueID; // 0xA0
	private byte[] subjectUniqueID; // 0xA8
	private X509ExtensionCollection extensions; // 0xB0
	private static string encoding_error; // 0x0

	// Properties
	public DSA DSA { get; }
	public virtual string IssuerName { get; }
	public virtual byte[] KeyAlgorithmParameters { get; }
	public virtual RSA RSA { get; }
	public virtual byte[] RawData { get; }
	public virtual byte[] SerialNumber { get; }
	public virtual string SubjectName { get; }
	public virtual DateTime ValidFrom { get; }
	public virtual DateTime ValidUntil { get; }

	// Methods

	// RVA: 0x34D66B0 Offset: 0x34D67B1 VA: 0x34D66B0
	private void Parse(byte[] data) { }

	// RVA: 0x34D71B0 Offset: 0x34D72B1 VA: 0x34D71B0
	public void .ctor(byte[] data) { }

	// RVA: 0x34D74C0 Offset: 0x34D75C1 VA: 0x34D74C0
	private byte[] GetUnsignedBigInteger(byte[] integer) { }

	// RVA: 0x34D7560 Offset: 0x34D7661 VA: 0x34D7560
	public DSA get_DSA() { }

	// RVA: 0x34D7A50 Offset: 0x34D7B51 VA: 0x34D7A50 Slot: 5
	public virtual string get_IssuerName() { }

	// RVA: 0x34D7A60 Offset: 0x34D7B61 VA: 0x34D7A60 Slot: 6
	public virtual byte[] get_KeyAlgorithmParameters() { }

	// RVA: 0x34D7AE0 Offset: 0x34D7BE1 VA: 0x34D7AE0 Slot: 7
	public virtual RSA get_RSA() { }

	// RVA: 0x34D7D60 Offset: 0x34D7E61 VA: 0x34D7D60 Slot: 8
	public virtual byte[] get_RawData() { }

	// RVA: 0x34D7DE0 Offset: 0x34D7EE1 VA: 0x34D7DE0 Slot: 9
	public virtual byte[] get_SerialNumber() { }

	// RVA: 0x34D7E60 Offset: 0x34D7F61 VA: 0x34D7E60 Slot: 10
	public virtual string get_SubjectName() { }

	// RVA: 0x34D7E70 Offset: 0x34D7F71 VA: 0x34D7E70 Slot: 11
	public virtual DateTime get_ValidFrom() { }

	// RVA: 0x34D7E80 Offset: 0x34D7F81 VA: 0x34D7E80 Slot: 12
	public virtual DateTime get_ValidUntil() { }

	// RVA: 0x34D7E90 Offset: 0x34D7F91 VA: 0x34D7E90
	public ASN1 GetIssuerName() { }

	// RVA: 0x34D7EA0 Offset: 0x34D7FA1 VA: 0x34D7EA0
	public ASN1 GetSubjectName() { }

	// RVA: 0x34D7EB0 Offset: 0x34D7FB1 VA: 0x34D7EB0 Slot: 13
	public virtual void GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x34D7390 Offset: 0x34D7491 VA: 0x34D7390
	private static byte[] PEM(string type, byte[] data) { }

	// RVA: 0x34D7F10 Offset: 0x34D8011 VA: 0x34D7F10
	private static void .cctor() { }
}

// Namespace: Mono.Security.X509
[DefaultMemberAttribute] // RVA: 0x46F6D0 Offset: 0x46F7D1 VA: 0x46F6D0
[Serializable]
internal class X509CertificateCollection : CollectionBase, IEnumerable // TypeDefIndex: 56
{
	// Properties
	public X509Certificate Item { get; }

	// Methods

	// RVA: 0x34D8EC0 Offset: 0x34D8FC1 VA: 0x34D8EC0
	public void .ctor() { }

	// RVA: 0x34D8ED0 Offset: 0x34D8FD1 VA: 0x34D8ED0
	public X509Certificate get_Item(int index) { }

	// RVA: 0x34D8F80 Offset: 0x34D9081 VA: 0x34D8F80
	public int Add(X509Certificate value) { }

	// RVA: 0x34D9000 Offset: 0x34D9101 VA: 0x34D9000
	public X509CertificateCollection.X509CertificateEnumerator GetEnumerator() { }

	// RVA: 0x34D9070 Offset: 0x34D9171 VA: 0x34D9070 Slot: 18
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	// RVA: 0x34D90A0 Offset: 0x34D91A1 VA: 0x34D90A0 Slot: 2
	public override int GetHashCode() { }
}

// Namespace: Mono.Security.X509
[DefaultMemberAttribute] // RVA: 0x46F710 Offset: 0x46F811 VA: 0x46F710
internal sealed class X509ExtensionCollection : CollectionBase, IEnumerable // TypeDefIndex: 58
{
	// Fields
	private bool readOnly; // 0x18

	// Methods

	// RVA: 0x34DA370 Offset: 0x34DA471 VA: 0x34DA370
	public void .ctor() { }

	// RVA: 0x34D7070 Offset: 0x34D7171 VA: 0x34D7070
	public void .ctor(ASN1 asn1) { }

	// RVA: 0x34DA380 Offset: 0x34DA481 VA: 0x34DA380 Slot: 18
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
}

// Namespace: Mono.Security.X509
public class X509Certificate : ISerializable // TypeDefIndex: 1536
{
	// Fields
	private ASN1 decoder; // 0x10
	private byte[] m_encodedcert; // 0x18
	private DateTime m_from; // 0x20
	private DateTime m_until; // 0x28
	private ASN1 issuer; // 0x30
	private string m_issuername; // 0x38
	private string m_keyalgo; // 0x40
	private byte[] m_keyalgoparams; // 0x48
	private ASN1 subject; // 0x50
	private string m_subject; // 0x58
	private byte[] m_publickey; // 0x60
	private byte[] signature; // 0x68
	private string m_signaturealgo; // 0x70
	private byte[] m_signaturealgoparams; // 0x78
	private RSA _rsa; // 0x80
	private DSA _dsa; // 0x88
	private int version; // 0x90
	private byte[] serialnumber; // 0x98
	private byte[] issuerUniqueID; // 0xA0
	private byte[] subjectUniqueID; // 0xA8
	private X509ExtensionCollection extensions; // 0xB0
	private static string encoding_error; // 0x0

	// Properties
	public DSA DSA { get; set; }
	public virtual string IssuerName { get; }
	public virtual string KeyAlgorithm { get; }
	public virtual byte[] KeyAlgorithmParameters { get; }
	public virtual byte[] PublicKey { get; }
	public virtual RSA RSA { get; set; }
	public virtual byte[] RawData { get; }
	public virtual byte[] SerialNumber { get; }
	public virtual string SignatureAlgorithm { get; }
	public virtual string SubjectName { get; }
	public virtual DateTime ValidFrom { get; }
	public virtual DateTime ValidUntil { get; }
	public int Version { get; }

	// Methods

	// RVA: 0x1BDB1B0 Offset: 0x1BDB2B1 VA: 0x1BDB1B0
	private void Parse(byte[] data) { }

	// RVA: 0x1BCFF50 Offset: 0x1BD0051 VA: 0x1BCFF50
	public void .ctor(byte[] data) { }

	// RVA: 0x1BDC020 Offset: 0x1BDC121 VA: 0x1BDC020
	private byte[] GetUnsignedBigInteger(byte[] integer) { }

	// RVA: 0x1BD0CB0 Offset: 0x1BD0DB1 VA: 0x1BD0CB0
	public DSA get_DSA() { }

	// RVA: 0x1BDC0C0 Offset: 0x1BDC1C1 VA: 0x1BDC0C0
	public void set_DSA(DSA value) { }

	// RVA: 0x1BDC110 Offset: 0x1BDC211 VA: 0x1BDC110 Slot: 5
	public virtual string get_IssuerName() { }

	// RVA: 0x1BDC120 Offset: 0x1BDC221 VA: 0x1BDC120 Slot: 6
	public virtual string get_KeyAlgorithm() { }

	// RVA: 0x1BDC130 Offset: 0x1BDC231 VA: 0x1BDC130 Slot: 7
	public virtual byte[] get_KeyAlgorithmParameters() { }

	// RVA: 0x1BDC1B0 Offset: 0x1BDC2B1 VA: 0x1BDC1B0 Slot: 8
	public virtual byte[] get_PublicKey() { }

	// RVA: 0x1BDC230 Offset: 0x1BDC331 VA: 0x1BDC230 Slot: 9
	public virtual RSA get_RSA() { }

	// RVA: 0x1BDC570 Offset: 0x1BDC671 VA: 0x1BDC570 Slot: 10
	public virtual void set_RSA(RSA value) { }

	// RVA: 0x1BDC5B0 Offset: 0x1BDC6B1 VA: 0x1BDC5B0 Slot: 11
	public virtual byte[] get_RawData() { }

	// RVA: 0x1BDC630 Offset: 0x1BDC731 VA: 0x1BDC630 Slot: 12
	public virtual byte[] get_SerialNumber() { }

	// RVA: 0x1BDC6B0 Offset: 0x1BDC7B1 VA: 0x1BDC6B0 Slot: 13
	public virtual string get_SignatureAlgorithm() { }

	// RVA: 0x1BDC6C0 Offset: 0x1BDC7C1 VA: 0x1BDC6C0 Slot: 14
	public virtual string get_SubjectName() { }

	// RVA: 0x1BDC6D0 Offset: 0x1BDC7D1 VA: 0x1BDC6D0 Slot: 15
	public virtual DateTime get_ValidFrom() { }

	// RVA: 0x1BDC6E0 Offset: 0x1BDC7E1 VA: 0x1BDC6E0 Slot: 16
	public virtual DateTime get_ValidUntil() { }

	// RVA: 0x1BDC6F0 Offset: 0x1BDC7F1 VA: 0x1BDC6F0
	public int get_Version() { }

	// RVA: 0x1BDC700 Offset: 0x1BDC801 VA: 0x1BDC700
	public ASN1 GetIssuerName() { }

	// RVA: 0x1BDC710 Offset: 0x1BDC811 VA: 0x1BDC710
	public ASN1 GetSubjectName() { }

	// RVA: 0x1BDC720 Offset: 0x1BDC821 VA: 0x1BDC720 Slot: 17
	public virtual void GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x1BDBEF0 Offset: 0x1BDBFF1 VA: 0x1BDBEF0
	private static byte[] PEM(string type, byte[] data) { }

	// RVA: 0x1BDC780 Offset: 0x1BDC881 VA: 0x1BDC780
	private static void .cctor() { }
}

// Namespace: Mono.Security.X509
[DefaultMemberAttribute] // RVA: 0x858B0 Offset: 0x859B1 VA: 0x858B0
[Serializable]
public class X509CertificateCollection : CollectionBase, IEnumerable // TypeDefIndex: 1538
{
	// Properties
	public X509Certificate Item { get; }

	// Methods

	// RVA: 0x1BCD870 Offset: 0x1BCD971 VA: 0x1BCD870
	public void .ctor() { }

	// RVA: 0x1BDC7F0 Offset: 0x1BDC8F1 VA: 0x1BDC7F0
	public X509Certificate get_Item(int index) { }

	// RVA: 0x1BD0130 Offset: 0x1BD0231 VA: 0x1BD0130
	public int Add(X509Certificate value) { }

	// RVA: 0x1BD0C40 Offset: 0x1BD0D41 VA: 0x1BD0C40
	public X509CertificateCollection.X509CertificateEnumerator GetEnumerator() { }

	// RVA: 0x1BDC8A0 Offset: 0x1BDC9A1 VA: 0x1BDC8A0 Slot: 18
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	// RVA: 0x1BDC8D0 Offset: 0x1BDC9D1 VA: 0x1BDC8D0 Slot: 2
	public override int GetHashCode() { }
}

// Namespace: Mono.Security.X509
[DefaultMemberAttribute] // RVA: 0x858F0 Offset: 0x859F1 VA: 0x858F0
public sealed class X509ExtensionCollection : CollectionBase, IEnumerable // TypeDefIndex: 1540
{
	// Fields
	private bool readOnly; // 0x18

	// Methods

	// RVA: 0x1BDD230 Offset: 0x1BDD331 VA: 0x1BDD230
	public void .ctor() { }

	// RVA: 0x1BDBDB0 Offset: 0x1BDBEB1 VA: 0x1BDBDB0
	public void .ctor(ASN1 asn1) { }

	// RVA: 0x1BDD240 Offset: 0x1BDD341 VA: 0x1BDD240 Slot: 18
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
}

