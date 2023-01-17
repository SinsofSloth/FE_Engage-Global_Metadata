// Namespace: System.Security.Cryptography
internal abstract class RSAPKCS1SignatureDescription : SignatureDescription // TypeDefIndex: 956
{
	// Fields
	private string _hashAlgorithm; // 0x30

	// Methods

	// RVA: 0x3B6F180 Offset: 0x3B6F281 VA: 0x3B6F180
	protected void .ctor(string hashAlgorithm, string digestAlgorithm) { }
}

// Namespace: System.Security.Cryptography
internal class RSAPKCS1SHA256SignatureDescription : RSAPKCS1SignatureDescription // TypeDefIndex: 958
{
	// Methods

	// RVA: 0x3B6F270 Offset: 0x3B6F371 VA: 0x3B6F270
	public void .ctor() { }
}

// Namespace: System.Security.Cryptography
internal class RSAPKCS1SHA512SignatureDescription : RSAPKCS1SignatureDescription // TypeDefIndex: 960
{
	// Methods

	// RVA: 0x3B6F350 Offset: 0x3B6F451 VA: 0x3B6F350
	public void .ctor() { }
}

// Namespace: System.Security.Cryptography
[ComVisibleAttribute] // RVA: 0x474380 Offset: 0x474481 VA: 0x474380
public class RSAPKCS1SignatureDeformatter : AsymmetricSignatureDeformatter // TypeDefIndex: 972
{
	// Methods

	// RVA: 0x3B6F3C0 Offset: 0x3B6F4C1 VA: 0x3B6F3C0
	public void .ctor() { }
}

