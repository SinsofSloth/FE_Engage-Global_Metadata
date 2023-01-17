// Namespace: System.Net
internal class MonoChunkStream // TypeDefIndex: 2568
{
	// Fields
	internal WebHeaderCollection headers; // 0x10
	private int chunkSize; // 0x18
	private int chunkRead; // 0x1C
	private int totalWritten; // 0x20
	private MonoChunkStream.State state; // 0x24
	private StringBuilder saved; // 0x28
	private bool sawCR; // 0x30
	private bool gotit; // 0x31
	private int trailerState; // 0x34
	private ArrayList chunks; // 0x38

	// Properties
	public bool WantMore { get; }
	public bool DataAvailable { get; }
	public int ChunkLeft { get; }

	// Methods

	// RVA: 0x1AC8D70 Offset: 0x1AC8E71 VA: 0x1AC8D70
	public void .ctor(byte[] buffer, int offset, int size, WebHeaderCollection headers) { }

	// RVA: 0x1AC8DD0 Offset: 0x1AC8ED1 VA: 0x1AC8DD0
	public void .ctor(WebHeaderCollection headers) { }

	// RVA: 0x1AC8EE0 Offset: 0x1AC8FE1 VA: 0x1AC8EE0
	public void ResetBuffer() { }

	// RVA: 0x1AC8F00 Offset: 0x1AC9001 VA: 0x1AC8F00
	public void WriteAndReadBack(byte[] buffer, int offset, int size, ref int read) { }

	// RVA: 0x1AC8F80 Offset: 0x1AC9081 VA: 0x1AC8F80
	public int Read(byte[] buffer, int offset, int size) { }

	// RVA: 0x1AC8F90 Offset: 0x1AC9091 VA: 0x1AC8F90
	private int ReadFromChunks(byte[] buffer, int offset, int size) { }

	// RVA: 0x1AC8EB0 Offset: 0x1AC8FB1 VA: 0x1AC8EB0
	public void Write(byte[] buffer, int offset, int size) { }

	// RVA: 0x1AC9210 Offset: 0x1AC9311 VA: 0x1AC9210
	private void InternalWrite(byte[] buffer, ref int offset, int size) { }

	// RVA: 0x1AC9CA0 Offset: 0x1AC9DA1 VA: 0x1AC9CA0
	public bool get_WantMore() { }

	// RVA: 0x1AC9CD0 Offset: 0x1AC9DD1 VA: 0x1AC9CD0
	public bool get_DataAvailable() { }

	// RVA: 0x1AC9DE0 Offset: 0x1AC9EE1 VA: 0x1AC9DE0
	public int get_ChunkLeft() { }

	// RVA: 0x1AC96B0 Offset: 0x1AC97B1 VA: 0x1AC96B0
	private MonoChunkStream.State ReadBody(byte[] buffer, ref int offset, int size) { }

	// RVA: 0x1AC9360 Offset: 0x1AC9461 VA: 0x1AC9360
	private MonoChunkStream.State GetChunkSize(byte[] buffer, ref int offset, int size) { }

	// RVA: 0x1AC9E50 Offset: 0x1AC9F51 VA: 0x1AC9E50
	private static string RemoveChunkExtension(string input) { }

	// RVA: 0x1AC97E0 Offset: 0x1AC98E1 VA: 0x1AC97E0
	private MonoChunkStream.State ReadCRLF(byte[] buffer, ref int offset, int size) { }

	// RVA: 0x1AC98F0 Offset: 0x1AC99F1 VA: 0x1AC98F0
	private MonoChunkStream.State ReadTrailer(byte[] buffer, ref int offset, int size) { }

	// RVA: 0x1AC9DF0 Offset: 0x1AC9EF1 VA: 0x1AC9DF0
	private static void ThrowProtocolViolation(string message) { }
}

