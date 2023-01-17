// Namespace: Mono.Security.Cryptography
internal class RSAManaged : RSA // TypeDefIndex: 72
{
	// Fields
	private bool isCRTpossible; // 0x20
	private bool keyBlinding; // 0x21
	private bool keypairGenerated; // 0x22
	private bool m_disposed; // 0x23
	private BigInteger d; // 0x28
	private BigInteger p; // 0x30
	private BigInteger q; // 0x38
	private BigInteger dp; // 0x40
	private BigInteger dq; // 0x48
	private BigInteger qInv; // 0x50
	private BigInteger n; // 0x58
	private BigInteger e; // 0x60
	[CompilerGeneratedAttribute] // RVA: 0x477EA0 Offset: 0x477FA1 VA: 0x477EA0
	private RSAManaged.KeyGeneratedEventHandler KeyGenerated; // 0x68

	// Properties
	public override int KeySize { get; }
	public bool PublicOnly { get; }

	// Methods

	// RVA: 0x3B6CE70 Offset: 0x3B6CF71 VA: 0x3B6CE70
	public void .ctor(int keySize) { }

	// RVA: 0x3B6D470 Offset: 0x3B6D571 VA: 0x3B6D470 Slot: 1
	protected override void Finalize() { }

	// RVA: 0x3B6D4F0 Offset: 0x3B6D5F1 VA: 0x3B6D4F0
	private void GenerateKeyPair() { }

	// RVA: 0x3B6D870 Offset: 0x3B6D971 VA: 0x3B6D870 Slot: 6
	public override int get_KeySize() { }

	// RVA: 0x3B6D0F0 Offset: 0x3B6D1F1 VA: 0x3B6D0F0
	public bool get_PublicOnly() { }

	// RVA: 0x3B6D920 Offset: 0x3B6DA21 VA: 0x3B6D920 Slot: 10
	public override RSAParameters ExportParameters(bool includePrivateParameters) { }

	// RVA: 0x3B6E050 Offset: 0x3B6E151 VA: 0x3B6E050 Slot: 11
	public override void ImportParameters(RSAParameters parameters) { }

	// RVA: 0x3B6E680 Offset: 0x3B6E781 VA: 0x3B6E680 Slot: 5
	protected override void Dispose(bool disposing) { }

	[CompilerGeneratedAttribute] // RVA: 0x479460 Offset: 0x479561 VA: 0x479460
	// RVA: 0x3B6CF90 Offset: 0x3B6D091 VA: 0x3B6CF90
	public void add_KeyGenerated(RSAManaged.KeyGeneratedEventHandler value) { }

	[CompilerGeneratedAttribute] // RVA: 0x479470 Offset: 0x479571 VA: 0x479470
	// RVA: 0x3B6E970 Offset: 0x3B6EA71 VA: 0x3B6E970
	public void remove_KeyGenerated(RSAManaged.KeyGeneratedEventHandler value) { }

	// RVA: 0x3B6EA20 Offset: 0x3B6EB21 VA: 0x3B6EA20 Slot: 9
	public override string ToXmlString(bool includePrivateParameters) { }

	// RVA: 0x3B6DF90 Offset: 0x3B6E091 VA: 0x3B6DF90
	private byte[] GetPaddedValue(BigInteger value, int length) { }
}

// Namespace: Mono.Security.Cryptography
public class RSAManaged : RSA // TypeDefIndex: 1578
{
	// Fields
	private bool isCRTpossible; // 0x20
	private bool keypairGenerated; // 0x21
	private bool m_disposed; // 0x22
	private BigInteger d; // 0x28
	private BigInteger p; // 0x30
	private BigInteger q; // 0x38
	private BigInteger dp; // 0x40
	private BigInteger dq; // 0x48
	private BigInteger qInv; // 0x50
	private BigInteger n; // 0x58
	private BigInteger e; // 0x60
	[CompilerGeneratedAttribute] // RVA: 0x85A90 Offset: 0x85B91 VA: 0x85A90
	private RSAManaged.KeyGeneratedEventHandler KeyGenerated; // 0x68

	// Properties
	public bool PublicOnly { get; }

	// Methods

	// RVA: 0x1BD6B40 Offset: 0x1BD6C41 VA: 0x1BD6B40
	private void GenerateKeyPair() { }

	// RVA: 0x1BD6FF0 Offset: 0x1BD70F1 VA: 0x1BD6FF0
	public bool get_PublicOnly() { }

	// RVA: 0x1BD70D0 Offset: 0x1BD71D1 VA: 0x1BD70D0 Slot: 10
	public override RSAParameters ExportParameters(bool includePrivateParameters) { }

	// RVA: 0x1BD77B0 Offset: 0x1BD78B1 VA: 0x1BD77B0 Slot: 11
	public override void ImportParameters(RSAParameters parameters) { }

	// RVA: 0x1BD7700 Offset: 0x1BD7801 VA: 0x1BD7700
	private byte[] GetPaddedValue(BigInteger value, int length) { }
}

