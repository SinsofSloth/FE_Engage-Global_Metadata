// Namespace: 
internal class Encoding.EncodingCharBuffer // TypeDefIndex: 459
{
	// Fields
	private char* chars; // 0x10
	private char* charStart; // 0x18
	private char* charEnd; // 0x20
	private int charCountResult; // 0x28
	private Encoding enc; // 0x30
	private DecoderNLS decoder; // 0x38
	private byte* byteStart; // 0x40
	private byte* byteEnd; // 0x48
	private byte* bytes; // 0x50
	private DecoderFallbackBuffer fallbackBuffer; // 0x58

	// Properties
	internal bool MoreData { get; }
	internal int BytesUsed { get; }
	internal int Count { get; }

	// Methods

	// RVA: 0x35EA3C0 Offset: 0x35EA4C1 VA: 0x35EA3C0
	internal void .ctor(Encoding enc, DecoderNLS decoder, char* charStart, int charCount, byte* byteStart, int byteCount) { }

	// RVA: 0x35EA490 Offset: 0x35EA591 VA: 0x35EA490
	internal bool AddChar(char ch, int numBytes) { }

	// RVA: 0x35EA510 Offset: 0x35EA611 VA: 0x35EA510
	internal bool AddChar(char ch) { }

	// RVA: 0x35EA590 Offset: 0x35EA691 VA: 0x35EA590
	internal void AdjustBytes(int count) { }

	// RVA: 0x35EA5A0 Offset: 0x35EA6A1 VA: 0x35EA5A0
	internal bool get_MoreData() { }

	// RVA: 0x35EA5B0 Offset: 0x35EA6B1 VA: 0x35EA5B0
	internal byte GetNextByte() { }

	// RVA: 0x35EA5E0 Offset: 0x35EA6E1 VA: 0x35EA5E0
	internal int get_BytesUsed() { }

	// RVA: 0x35EA5F0 Offset: 0x35EA6F1 VA: 0x35EA5F0
	internal bool Fallback(byte fallbackByte) { }

	// RVA: 0x35EA670 Offset: 0x35EA771 VA: 0x35EA670
	internal bool Fallback(byte[] byteBuffer) { }

	// RVA: 0x35EA750 Offset: 0x35EA851 VA: 0x35EA750
	internal int get_Count() { }
}

