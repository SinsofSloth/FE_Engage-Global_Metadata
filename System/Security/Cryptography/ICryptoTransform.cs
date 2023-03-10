// Namespace: System.Security.Cryptography
[ComVisibleAttribute] // RVA: 0x473FC0 Offset: 0x4740C1 VA: 0x473FC0
public interface ICryptoTransform : IDisposable // TypeDefIndex: 930
{
	// Properties
	public abstract int InputBlockSize { get; }
	public abstract int OutputBlockSize { get; }
	public abstract bool CanTransformMultipleBlocks { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract int get_InputBlockSize();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract int get_OutputBlockSize();

	// RVA: -1 Offset: -1 Slot: 2
	public abstract bool get_CanTransformMultipleBlocks();

	// RVA: -1 Offset: -1 Slot: 3
	public abstract int TransformBlock(byte[] inputBuffer, int inputOffset, int inputCount, byte[] outputBuffer, int outputOffset);

	// RVA: -1 Offset: -1 Slot: 4
	public abstract byte[] TransformFinalBlock(byte[] inputBuffer, int inputOffset, int inputCount);
}

