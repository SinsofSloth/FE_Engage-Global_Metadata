// Namespace: System.Xml
internal class BinHexDecoder : IncrementalReadDecoder // TypeDefIndex: 1626
{
	// Fields
	private byte[] buffer; // 0x10
	private int curIndex; // 0x18
	private int endIndex; // 0x1C
	private bool hasHalfByteCached; // 0x20
	private byte cachedHalfByte; // 0x21

	// Properties
	internal override bool IsFull { get; }

	// Methods

	// RVA: 0x1A26320 Offset: 0x1A26421 VA: 0x1A26320 Slot: 4
	internal override bool get_IsFull() { }

	// RVA: 0x1A26330 Offset: 0x1A26431 VA: 0x1A26330 Slot: 5
	internal override int Decode(char[] chars, int startPos, int len) { }

	// RVA: 0x1A26670 Offset: 0x1A26771 VA: 0x1A26670
	public static byte[] Decode(char[] chars, bool allowOddChars) { }

	// RVA: 0x1A264A0 Offset: 0x1A265A1 VA: 0x1A264A0
	private static void Decode(char* pChars, char* pCharsEndPos, byte* pBytes, byte* pBytesEndPos, ref bool hasHalfByteCached, ref byte cachedHalfByte, out int charsDecoded, out int bytesDecoded) { }
}

