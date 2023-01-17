// Namespace: System.Security.Cryptography
[ComVisibleAttribute] // RVA: 0x474360 Offset: 0x474461 VA: 0x474360
public sealed class MD5CryptoServiceProvider : MD5 // TypeDefIndex: 969
{
	// Fields
	private uint[] _H; // 0x28
	private uint[] buff; // 0x30
	private ulong count; // 0x38
	private byte[] _ProcessingBuffer; // 0x40
	private int _ProcessingBufferCount; // 0x48
	private static readonly uint[] K; // 0x0

	// Methods

	// RVA: 0x34242F0 Offset: 0x34243F1 VA: 0x34242F0
	public void .ctor() { }

	// RVA: 0x34243D0 Offset: 0x34244D1 VA: 0x34243D0 Slot: 1
	protected override void Finalize() { }

	// RVA: 0x3424450 Offset: 0x3424551 VA: 0x3424450 Slot: 15
	protected override void Dispose(bool disposing) { }

	// RVA: 0x34244D0 Offset: 0x34245D1 VA: 0x34244D0 Slot: 17
	protected override void HashCore(byte[] rgb, int ibStart, int cbSize) { }

	// RVA: 0x3425260 Offset: 0x3425361 VA: 0x3425260 Slot: 18
	protected override byte[] HashFinal() { }

	// RVA: 0x34256B0 Offset: 0x34257B1 VA: 0x34256B0 Slot: 16
	public override void Initialize() { }

	// RVA: 0x34245E0 Offset: 0x34246E1 VA: 0x34245E0
	private void ProcessBlock(byte[] inputBuffer, int inputOffset) { }

	// RVA: 0x34254E0 Offset: 0x34255E1 VA: 0x34254E0
	private void ProcessFinalBlock(byte[] inputBuffer, int inputOffset, int inputCount) { }

	// RVA: 0x3425740 Offset: 0x3425841 VA: 0x3425740
	internal void AddLength(ulong length, byte[] buffer, int position) { }

	// RVA: 0x3425840 Offset: 0x3425941 VA: 0x3425840
	private static void .cctor() { }
}

