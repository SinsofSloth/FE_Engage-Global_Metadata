// Namespace: Mono.Security.Cryptography
internal class DSAManaged : DSA // TypeDefIndex: 75
{
	// Fields
	private bool keypairGenerated; // 0x20
	private bool m_disposed; // 0x21
	private BigInteger p; // 0x28
	private BigInteger q; // 0x30
	private BigInteger g; // 0x38
	private BigInteger x; // 0x40
	private BigInteger y; // 0x48
	private BigInteger j; // 0x50
	private BigInteger seed; // 0x58
	private int counter; // 0x60
	private bool j_missing; // 0x64
	private RandomNumberGenerator rng; // 0x68
	[CompilerGeneratedAttribute] // RVA: 0x477EB0 Offset: 0x477FB1 VA: 0x477EB0
	private DSAManaged.KeyGeneratedEventHandler KeyGenerated; // 0x70

	// Properties
	private RandomNumberGenerator Random { get; }
	public override int KeySize { get; }
	public bool PublicOnly { get; }

	// Methods

	// RVA: 0x35AE4C0 Offset: 0x35AE5C1 VA: 0x35AE4C0
	public void .ctor(int dwKeySize) { }

	// RVA: 0x35AEAB0 Offset: 0x35AEBB1 VA: 0x35AEAB0 Slot: 1
	protected override void Finalize() { }

	// RVA: 0x35AEB30 Offset: 0x35AEC31 VA: 0x35AEB30
	private void Generate() { }

	// RVA: 0x35AF1A0 Offset: 0x35AF2A1 VA: 0x35AF1A0
	private void GenerateKeyPair() { }

	// RVA: 0x35AF2C0 Offset: 0x35AF3C1 VA: 0x35AF2C0
	private void add(byte[] a, byte[] b, int value) { }

	// RVA: 0x35AEB90 Offset: 0x35AEC91 VA: 0x35AEB90
	private void GenerateParams(int keyLength) { }

	// RVA: 0x35AF370 Offset: 0x35AF471 VA: 0x35AF370
	private RandomNumberGenerator get_Random() { }

	// RVA: 0x35AF3C0 Offset: 0x35AF4C1 VA: 0x35AF3C0 Slot: 6
	public override int get_KeySize() { }

	// RVA: 0x35AE790 Offset: 0x35AE891 VA: 0x35AE790
	public bool get_PublicOnly() { }

	// RVA: 0x35AF3E0 Offset: 0x35AF4E1 VA: 0x35AF3E0
	private byte[] NormalizeArray(byte[] array) { }

	// RVA: 0x35AF490 Offset: 0x35AF591 VA: 0x35AF490 Slot: 10
	public override DSAParameters ExportParameters(bool includePrivateParameters) { }

	// RVA: 0x35AFAF0 Offset: 0x35AFBF1 VA: 0x35AFAF0 Slot: 11
	public override void ImportParameters(DSAParameters parameters) { }

	// RVA: 0x35AFE50 Offset: 0x35AFF51 VA: 0x35AFE50 Slot: 5
	protected override void Dispose(bool disposing) { }

	[CompilerGeneratedAttribute] // RVA: 0x479480 Offset: 0x479581 VA: 0x479480
	// RVA: 0x35AE5C0 Offset: 0x35AE6C1 VA: 0x35AE5C0
	public void add_KeyGenerated(DSAManaged.KeyGeneratedEventHandler value) { }

	[CompilerGeneratedAttribute] // RVA: 0x479490 Offset: 0x479591 VA: 0x479490
	// RVA: 0x35B00F0 Offset: 0x35B01F1 VA: 0x35B00F0
	public void remove_KeyGenerated(DSAManaged.KeyGeneratedEventHandler value) { }
}

