// Namespace: System.IO
internal sealed class PinnedBufferMemoryStream : UnmanagedMemoryStream // TypeDefIndex: 635
{
	// Fields
	private byte[] _array; // 0x68
	private GCHandle _pinningHandle; // 0x70

	// Methods

	// RVA: 0x38217E0 Offset: 0x38218E1 VA: 0x38217E0
	internal void .ctor(byte[] array) { }

	// RVA: 0x38218D0 Offset: 0x38219D1 VA: 0x38218D0 Slot: 1
	protected override void Finalize() { }

	// RVA: 0x3821950 Offset: 0x3821A51 VA: 0x3821950 Slot: 19
	protected override void Dispose(bool disposing) { }
}

