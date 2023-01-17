// Namespace: System.Security.Cryptography
[ComVisibleAttribute] // RVA: 0x473EC0 Offset: 0x473FC1 VA: 0x473EC0
public abstract class HashAlgorithm : IDisposable, ICryptoTransform // TypeDefIndex: 922
{
	// Fields
	protected int HashSizeValue; // 0x10
	protected internal byte[] HashValue; // 0x18
	protected int State; // 0x20
	private bool m_bDisposed; // 0x24

	// Properties
	public virtual int HashSize { get; }
	public virtual byte[] Hash { get; }
	public virtual int InputBlockSize { get; }
	public virtual int OutputBlockSize { get; }
	public virtual bool CanTransformMultipleBlocks { get; }

	// Methods

	// RVA: 0x38BEF10 Offset: 0x38BF011 VA: 0x38BEF10
	protected void .ctor() { }

	// RVA: 0x38BEF20 Offset: 0x38BF021 VA: 0x38BEF20 Slot: 10
	public virtual int get_HashSize() { }

	// RVA: 0x38BEF30 Offset: 0x38BF031 VA: 0x38BEF30 Slot: 11
	public virtual byte[] get_Hash() { }

	// RVA: 0x38BDCD0 Offset: 0x38BDDD1 VA: 0x38BDCD0
	public byte[] ComputeHash(byte[] buffer) { }

	// RVA: 0x38BF040 Offset: 0x38BF141 VA: 0x38BF040
	public byte[] ComputeHash(byte[] buffer, int offset, int count) { }

	// RVA: 0x38BF280 Offset: 0x38BF381 VA: 0x38BF280 Slot: 12
	public virtual int get_InputBlockSize() { }

	// RVA: 0x38BF290 Offset: 0x38BF391 VA: 0x38BF290 Slot: 13
	public virtual int get_OutputBlockSize() { }

	// RVA: 0x38BF2A0 Offset: 0x38BF3A1 VA: 0x38BF2A0 Slot: 14
	public virtual bool get_CanTransformMultipleBlocks() { }

	// RVA: 0x38BE0B0 Offset: 0x38BE1B1 VA: 0x38BE0B0 Slot: 8
	public int TransformBlock(byte[] inputBuffer, int inputOffset, int inputCount, byte[] outputBuffer, int outputOffset) { }

	// RVA: 0x38BE3D0 Offset: 0x38BE4D1 VA: 0x38BE3D0 Slot: 9
	public byte[] TransformFinalBlock(byte[] inputBuffer, int inputOffset, int inputCount) { }

	// RVA: 0x38BF2B0 Offset: 0x38BF3B1 VA: 0x38BF2B0 Slot: 4
	public void Dispose() { }

	// RVA: 0x38BF330 Offset: 0x38BF431 VA: 0x38BF330
	public void Clear() { }

	// RVA: 0x38BF3D0 Offset: 0x38BF4D1 VA: 0x38BF3D0 Slot: 15
	protected virtual void Dispose(bool disposing) { }

	// RVA: -1 Offset: -1 Slot: 16
	public abstract void Initialize();

	// RVA: -1 Offset: -1 Slot: 17
	protected abstract void HashCore(byte[] array, int ibStart, int cbSize);

	// RVA: -1 Offset: -1 Slot: 18
	protected abstract byte[] HashFinal();
}

