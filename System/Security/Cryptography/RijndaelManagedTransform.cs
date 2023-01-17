// Namespace: System.Security.Cryptography
[ComVisibleAttribute] // RVA: 0x4740E0 Offset: 0x4741E1 VA: 0x4740E0
public sealed class RijndaelManagedTransform : ICryptoTransform, IDisposable // TypeDefIndex: 941
{
	// Fields
	private CipherMode m_cipherMode; // 0x10
	private PaddingMode m_paddingValue; // 0x14
	private RijndaelManagedTransformMode m_transformMode; // 0x18
	private int m_blockSizeBits; // 0x1C
	private int m_blockSizeBytes; // 0x20
	private int m_inputBlockSize; // 0x24
	private int m_outputBlockSize; // 0x28
	private int[] m_encryptKeyExpansion; // 0x30
	private int[] m_decryptKeyExpansion; // 0x38
	private int m_Nr; // 0x40
	private int m_Nb; // 0x44
	private int m_Nk; // 0x48
	private int[] m_encryptindex; // 0x50
	private int[] m_decryptindex; // 0x58
	private int[] m_IV; // 0x60
	private int[] m_lastBlockBuffer; // 0x68
	private byte[] m_depadBuffer; // 0x70
	private byte[] m_shiftRegister; // 0x78
	private static readonly byte[] s_Sbox; // 0x0
	private static readonly int[] s_Rcon; // 0x8
	private static readonly int[] s_T; // 0x10
	private static readonly int[] s_TF; // 0x18
	private static readonly int[] s_iT; // 0x20
	private static readonly int[] s_iTF; // 0x28

	// Properties
	public int InputBlockSize { get; }
	public int OutputBlockSize { get; }
	public bool CanTransformMultipleBlocks { get; }

	// Methods

	// RVA: 0x3227F50 Offset: 0x3228051 VA: 0x3227F50
	internal void .ctor(byte[] rgbKey, CipherMode mode, byte[] rgbIV, int blockSize, int feedbackSize, PaddingMode PaddingValue, RijndaelManagedTransformMode transformMode) { }

	// RVA: 0x3228B40 Offset: 0x3228C41 VA: 0x3228B40 Slot: 9
	public void Dispose() { }

	// RVA: 0x3228B50 Offset: 0x3228C51 VA: 0x3228B50
	private void Dispose(bool disposing) { }

	// RVA: 0x3228C80 Offset: 0x3228D81 VA: 0x3228C80 Slot: 4
	public int get_InputBlockSize() { }

	// RVA: 0x3228C90 Offset: 0x3228D91 VA: 0x3228C90 Slot: 5
	public int get_OutputBlockSize() { }

	// RVA: 0x3228CA0 Offset: 0x3228DA1 VA: 0x3228CA0 Slot: 6
	public bool get_CanTransformMultipleBlocks() { }

	// RVA: 0x3228CB0 Offset: 0x3228DB1 VA: 0x3228CB0 Slot: 7
	public int TransformBlock(byte[] inputBuffer, int inputOffset, int inputCount, byte[] outputBuffer, int outputOffset) { }

	// RVA: 0x322A550 Offset: 0x322A651 VA: 0x322A550 Slot: 8
	public byte[] TransformFinalBlock(byte[] inputBuffer, int inputOffset, int inputCount) { }

	// RVA: 0x322A940 Offset: 0x322AA41 VA: 0x322A940
	public void Reset() { }

	// RVA: 0x3228F90 Offset: 0x3229091 VA: 0x3228F90
	private int EncryptData(byte[] inputBuffer, int inputOffset, int inputCount, ref byte[] outputBuffer, int outputOffset, PaddingMode paddingMode, bool fLast) { }

	// RVA: 0x3229AD0 Offset: 0x3229BD1 VA: 0x3229AD0
	private int DecryptData(byte[] inputBuffer, int inputOffset, int inputCount, ref byte[] outputBuffer, int outputOffset, PaddingMode paddingMode, bool fLast) { }

	// RVA: 0x322A9D0 Offset: 0x322AAD1 VA: 0x322A9D0
	private void Enc(int* encryptindex, int* encryptKeyExpansion, int* T, int* TF, int* work, int* temp) { }

	// RVA: 0x322ABA0 Offset: 0x322ACA1 VA: 0x322ABA0
	private void Dec(int* decryptindex, int* decryptKeyExpansion, int* iT, int* iTF, int* work, int* temp) { }

	// RVA: 0x3228590 Offset: 0x3228691 VA: 0x3228590
	private void GenerateKeyExpansion(byte[] rgbKey) { }

	// RVA: 0x322AEB0 Offset: 0x322AFB1 VA: 0x322AEB0
	private static int rot1(int val) { }

	// RVA: 0x322AEA0 Offset: 0x322AFA1 VA: 0x322AEA0
	private static int rot2(int val) { }

	// RVA: 0x322AD80 Offset: 0x322AE81 VA: 0x322AD80
	private static int rot3(int val) { }

	// RVA: 0x322AD90 Offset: 0x322AE91 VA: 0x322AD90
	private static int SubWord(int a) { }

	// RVA: 0x322AE70 Offset: 0x322AF71 VA: 0x322AE70
	private static int MulX(int x) { }

	// RVA: 0x322AEC0 Offset: 0x322AFC1 VA: 0x322AEC0
	private static void .cctor() { }
}

