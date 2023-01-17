// Namespace: 
private enum MonoChunkStream.State // TypeDefIndex: 2566
{
	// Fields
	public int value__; // 0x0
	public const MonoChunkStream.State None = 0;
	public const MonoChunkStream.State PartialSize = 1;
	public const MonoChunkStream.State Body = 2;
	public const MonoChunkStream.State BodyFinished = 3;
	public const MonoChunkStream.State Trailer = 4;
}

// Namespace: 
private class MonoChunkStream.Chunk // TypeDefIndex: 2567
{
	// Fields
	public byte[] Bytes; // 0x10
	public int Offset; // 0x18

	// Methods

	// RVA: 0x191D080 Offset: 0x191D181 VA: 0x191D080
	public void .ctor(byte[] chunk) { }

	// RVA: 0x191D0C0 Offset: 0x191D1C1 VA: 0x191D0C0
	public int Read(byte[] buffer, int offset, int size) { }
}

