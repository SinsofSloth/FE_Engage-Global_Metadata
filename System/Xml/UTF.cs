// Namespace: System.Xml
internal class UTF16Decoder : Decoder // TypeDefIndex: 1747
{
	// Fields
	private bool bigEndian; // 0x20
	private int lastByte; // 0x24

	// Methods

	// RVA: 0x19B8EA0 Offset: 0x19B8FA1 VA: 0x19B8EA0
	public void .ctor(bool bigEndian) { }

	// RVA: 0x19B8EE0 Offset: 0x19B8FE1 VA: 0x19B8EE0 Slot: 5
	public override int GetCharCount(byte[] bytes, int index, int count) { }

	// RVA: 0x19B8EF0 Offset: 0x19B8FF1 VA: 0x19B8EF0 Slot: 6
	public override int GetCharCount(byte[] bytes, int index, int count, bool flush) { }

	// RVA: 0x19B8FE0 Offset: 0x19B90E1 VA: 0x19B8FE0 Slot: 8
	public override int GetChars(byte[] bytes, int byteIndex, int byteCount, char[] chars, int charIndex) { }

	// RVA: 0x19B9220 Offset: 0x19B9321 VA: 0x19B9220 Slot: 11
	public override void Convert(byte[] bytes, int byteIndex, int byteCount, char[] chars, int charIndex, int charCount, bool flush, out int bytesUsed, out int charsUsed, out bool completed) { }
}

