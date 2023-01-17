// Namespace: Mono.Security.Cryptography
internal abstract class SymmetricTransform : ICryptoTransform, IDisposable // TypeDefIndex: 73
{
	// Fields
	protected SymmetricAlgorithm algo; // 0x10
	protected bool encrypt; // 0x18
	protected int BlockSizeByte; // 0x1C
	protected byte[] temp; // 0x20
	protected byte[] temp2; // 0x28
	private byte[] workBuff; // 0x30
	private byte[] workout; // 0x38
	protected PaddingMode padmode; // 0x40
	protected int FeedBackByte; // 0x44
	private bool m_disposed; // 0x48
	protected bool lastBlock; // 0x49
	private RandomNumberGenerator _rng; // 0x50

	// Properties
	public virtual bool CanTransformMultipleBlocks { get; }
	public virtual int InputBlockSize { get; }
	public virtual int OutputBlockSize { get; }
	private bool KeepLastBlock { get; }

	// Methods

	// RVA: 0x365B9A0 Offset: 0x365BAA1 VA: 0x365B9A0
	public void .ctor(SymmetricAlgorithm symmAlgo, bool encryption, byte[] rgbIV) { }

	// RVA: 0x365BCA0 Offset: 0x365BDA1 VA: 0x365BCA0 Slot: 1
	protected override void Finalize() { }

	// RVA: 0x365BD20 Offset: 0x365BE21 VA: 0x365BD20 Slot: 9
	private void System.IDisposable.Dispose() { }

	// RVA: 0x365BDA0 Offset: 0x365BEA1 VA: 0x365BDA0 Slot: 10
	protected virtual void Dispose(bool disposing) { }

	// RVA: 0x365BE30 Offset: 0x365BF31 VA: 0x365BE30 Slot: 11
	public virtual bool get_CanTransformMultipleBlocks() { }

	// RVA: 0x365BE40 Offset: 0x365BF41 VA: 0x365BE40 Slot: 12
	public virtual int get_InputBlockSize() { }

	// RVA: 0x365BE50 Offset: 0x365BF51 VA: 0x365BE50 Slot: 13
	public virtual int get_OutputBlockSize() { }

	// RVA: 0x365BE60 Offset: 0x365BF61 VA: 0x365BE60 Slot: 14
	protected virtual void Transform(byte[] input, byte[] output) { }

	// RVA: -1 Offset: -1 Slot: 15
	protected abstract void ECB(byte[] input, byte[] output);

	// RVA: 0x365BFD0 Offset: 0x365C0D1 VA: 0x365BFD0 Slot: 16
	protected virtual void CBC(byte[] input, byte[] output) { }

	// RVA: 0x365C140 Offset: 0x365C241 VA: 0x365C140 Slot: 17
	protected virtual void CFB(byte[] input, byte[] output) { }

	// RVA: 0x365C300 Offset: 0x365C401 VA: 0x365C300 Slot: 18
	protected virtual void OFB(byte[] input, byte[] output) { }

	// RVA: 0x365C360 Offset: 0x365C461 VA: 0x365C360 Slot: 19
	protected virtual void CTS(byte[] input, byte[] output) { }

	// RVA: 0x365C3C0 Offset: 0x365C4C1 VA: 0x365C3C0
	private void CheckInput(byte[] inputBuffer, int inputOffset, int inputCount) { }

	// RVA: 0x365C510 Offset: 0x365C611 VA: 0x365C510 Slot: 20
	public virtual int TransformBlock(byte[] inputBuffer, int inputOffset, int inputCount, byte[] outputBuffer, int outputOffset) { }

	// RVA: 0x365C720 Offset: 0x365C821 VA: 0x365C720
	private bool get_KeepLastBlock() { }

	// RVA: 0x365C750 Offset: 0x365C851 VA: 0x365C750
	private int InternalTransformBlock(byte[] inputBuffer, int inputOffset, int inputCount, byte[] outputBuffer, int outputOffset) { }

	// RVA: 0x365C930 Offset: 0x365CA31 VA: 0x365C930
	private void Random(byte[] buffer, int start, int length) { }

	// RVA: 0x365C9F0 Offset: 0x365CAF1 VA: 0x365C9F0
	private void ThrowBadPaddingException(PaddingMode padding, int length, int position) { }

	// RVA: 0x365CB40 Offset: 0x365CC41 VA: 0x365CB40 Slot: 21
	protected virtual byte[] FinalEncrypt(byte[] inputBuffer, int inputOffset, int inputCount) { }

	// RVA: 0x365CE70 Offset: 0x365CF71 VA: 0x365CE70 Slot: 22
	protected virtual byte[] FinalDecrypt(byte[] inputBuffer, int inputOffset, int inputCount) { }

	// RVA: 0x365D130 Offset: 0x365D231 VA: 0x365D130 Slot: 23
	public virtual byte[] TransformFinalBlock(byte[] inputBuffer, int inputOffset, int inputCount) { }
}

