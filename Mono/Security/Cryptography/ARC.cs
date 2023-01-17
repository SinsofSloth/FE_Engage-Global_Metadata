// Namespace: Mono.Security.Cryptography
internal class ARC4Managed : RC4, ICryptoTransform, IDisposable // TypeDefIndex: 59
{
	// Fields
	private byte[] key; // 0x48
	private byte[] state; // 0x50
	private byte x; // 0x58
	private byte y; // 0x59
	private bool m_disposed; // 0x5A

	// Properties
	public override byte[] Key { get; set; }
	public bool CanTransformMultipleBlocks { get; }
	public int InputBlockSize { get; }
	public int OutputBlockSize { get; }

	// Methods

	// RVA: 0x35540A0 Offset: 0x35541A1 VA: 0x35540A0
	public void .ctor() { }

	// RVA: 0x3554150 Offset: 0x3554251 VA: 0x3554150 Slot: 1
	protected override void Finalize() { }

	// RVA: 0x35541D0 Offset: 0x35542D1 VA: 0x35541D0 Slot: 5
	protected override void Dispose(bool disposing) { }

	// RVA: 0x3554420 Offset: 0x3554521 VA: 0x3554420 Slot: 11
	public override byte[] get_Key() { }

	// RVA: 0x35544E0 Offset: 0x35545E1 VA: 0x35544E0 Slot: 12
	public override void set_Key(byte[] value) { }

	// RVA: 0x3554760 Offset: 0x3554861 VA: 0x3554760 Slot: 21
	public override ICryptoTransform CreateEncryptor(byte[] rgbKey, byte[] rgvIV) { }

	// RVA: 0x3554790 Offset: 0x3554891 VA: 0x3554790 Slot: 23
	public override ICryptoTransform CreateDecryptor(byte[] rgbKey, byte[] rgvIV) { }

	// RVA: 0x35547D0 Offset: 0x35548D1 VA: 0x35547D0 Slot: 25
	public override void GenerateIV() { }

	// RVA: 0x3554840 Offset: 0x3554941 VA: 0x3554840 Slot: 24
	public override void GenerateKey() { }

	// RVA: 0x3554880 Offset: 0x3554981 VA: 0x3554880 Slot: 28
	public bool get_CanTransformMultipleBlocks() { }

	// RVA: 0x3554890 Offset: 0x3554991 VA: 0x3554890 Slot: 26
	public int get_InputBlockSize() { }

	// RVA: 0x35548A0 Offset: 0x35549A1 VA: 0x35548A0 Slot: 27
	public int get_OutputBlockSize() { }

	// RVA: 0x3554680 Offset: 0x3554781 VA: 0x3554680
	private void KeySetup(byte[] key) { }

	// RVA: 0x35548B0 Offset: 0x35549B1 VA: 0x35548B0
	private void CheckInput(byte[] inputBuffer, int inputOffset, int inputCount) { }

	// RVA: 0x3554AA0 Offset: 0x3554BA1 VA: 0x3554AA0 Slot: 29
	public int TransformBlock(byte[] inputBuffer, int inputOffset, int inputCount, byte[] outputBuffer, int outputOffset) { }

	// RVA: 0x3554C00 Offset: 0x3554D01 VA: 0x3554C00
	private int InternalTransformBlock(byte[] inputBuffer, int inputOffset, int inputCount, byte[] outputBuffer, int outputOffset) { }

	// RVA: 0x3554D40 Offset: 0x3554E41 VA: 0x3554D40 Slot: 30
	public byte[] TransformFinalBlock(byte[] inputBuffer, int inputOffset, int inputCount) { }
}

