// Namespace: System.Security.Cryptography
[ComVisibleAttribute] // RVA: 0x473EE0 Offset: 0x473FE1 VA: 0x473EE0
public abstract class HMAC : KeyedHashAlgorithm // TypeDefIndex: 923
{
	// Fields
	private int blockSizeValue; // 0x30
	internal string m_hashName; // 0x38
	internal HashAlgorithm m_hash1; // 0x40
	internal HashAlgorithm m_hash2; // 0x48
	private byte[] m_inner; // 0x50
	private byte[] m_outer; // 0x58
	private bool m_hashing; // 0x60

	// Properties
	protected int BlockSizeValue { get; set; }
	public override byte[] Key { get; set; }

	// Methods

	// RVA: 0x38BDA10 Offset: 0x38BDB11 VA: 0x38BDA10
	protected int get_BlockSizeValue() { }

	// RVA: 0x38BDA20 Offset: 0x38BDB21 VA: 0x38BDA20
	protected void set_BlockSizeValue(int value) { }

	// RVA: 0x38BDA30 Offset: 0x38BDB31 VA: 0x38BDA30
	private void UpdateIOPadBuffers() { }

	// RVA: 0x38BDBF0 Offset: 0x38BDCF1 VA: 0x38BDBF0
	internal void InitializeKey(byte[] key) { }

	// RVA: 0x38BDE40 Offset: 0x38BDF41 VA: 0x38BDE40 Slot: 19
	public override byte[] get_Key() { }

	// RVA: 0x38BDEC0 Offset: 0x38BDFC1 VA: 0x38BDEC0 Slot: 20
	public override void set_Key(byte[] value) { }

	// RVA: 0x38BDF30 Offset: 0x38BE031 VA: 0x38BDF30
	public static HMAC Create() { }

	// RVA: 0x38BDFE0 Offset: 0x38BE0E1 VA: 0x38BDFE0 Slot: 16
	public override void Initialize() { }

	// RVA: 0x38BE030 Offset: 0x38BE131 VA: 0x38BE030 Slot: 17
	protected override void HashCore(byte[] rgb, int ib, int cb) { }

	// RVA: 0x38BE290 Offset: 0x38BE391 VA: 0x38BE290 Slot: 18
	protected override byte[] HashFinal() { }

	// RVA: 0x38BE630 Offset: 0x38BE731 VA: 0x38BE630 Slot: 15
	protected override void Dispose(bool disposing) { }

	// RVA: 0x38BE790 Offset: 0x38BE891 VA: 0x38BE790
	protected void .ctor() { }
}

