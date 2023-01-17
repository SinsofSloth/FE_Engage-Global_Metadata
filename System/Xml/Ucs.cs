// Namespace: System.Xml
internal class Ucs4Encoding1234 : Ucs4Encoding // TypeDefIndex: 1750
{
	// Properties
	public override string EncodingName { get; }

	// Methods

	// RVA: 0x19BA8C0 Offset: 0x19BA9C1 VA: 0x19BA8C0
	public void .ctor() { }

	// RVA: 0x19BABD0 Offset: 0x19BACD1 VA: 0x19BABD0 Slot: 7
	public override string get_EncodingName() { }

	// RVA: 0x19BAC20 Offset: 0x19BAD21 VA: 0x19BAC20 Slot: 6
	public override byte[] GetPreamble() { }
}

// Namespace: System.Xml
internal class Ucs4Encoding2143 : Ucs4Encoding // TypeDefIndex: 1752
{
	// Properties
	public override string EncodingName { get; }

	// Methods

	// RVA: 0x19BA9E0 Offset: 0x19BAAE1 VA: 0x19BA9E0
	public void .ctor() { }

	// RVA: 0x19BACA0 Offset: 0x19BADA1 VA: 0x19BACA0 Slot: 7
	public override string get_EncodingName() { }

	// RVA: 0x19BACF0 Offset: 0x19BADF1 VA: 0x19BACF0 Slot: 6
	public override byte[] GetPreamble() { }
}

// Namespace: System.Xml
internal abstract class Ucs4Decoder : Decoder // TypeDefIndex: 1754
{
	// Fields
	internal byte[] lastBytes; // 0x20
	internal int lastBytesCount; // 0x28

	// Methods

	// RVA: 0x19B94F0 Offset: 0x19B95F1 VA: 0x19B94F0 Slot: 5
	public override int GetCharCount(byte[] bytes, int index, int count) { }

	// RVA: -1 Offset: -1 Slot: 13
	internal abstract int GetFullChars(byte[] bytes, int byteIndex, int byteCount, char[] chars, int charIndex);

	// RVA: 0x19B9510 Offset: 0x19B9611 VA: 0x19B9510 Slot: 8
	public override int GetChars(byte[] bytes, int byteIndex, int byteCount, char[] chars, int charIndex) { }

	// RVA: 0x19B96E0 Offset: 0x19B97E1 VA: 0x19B96E0 Slot: 11
	public override void Convert(byte[] bytes, int byteIndex, int byteCount, char[] chars, int charIndex, int charCount, bool flush, out int bytesUsed, out int charsUsed, out bool completed) { }

	// RVA: 0x19B9A10 Offset: 0x19B9B11 VA: 0x19B9A10
	internal void Ucs4ToUTF16(uint code, char[] chars, int charIndex) { }

	// RVA: 0x19B9A70 Offset: 0x19B9B71 VA: 0x19B9A70
	protected void .ctor() { }
}

// Namespace: System.Xml
internal class Ucs4Decoder1234 : Ucs4Decoder // TypeDefIndex: 1756
{
	// Methods

	// RVA: 0x19B9AE0 Offset: 0x19B9BE1 VA: 0x19B9AE0 Slot: 13
	internal override int GetFullChars(byte[] bytes, int byteIndex, int byteCount, char[] chars, int charIndex) { }

	// RVA: 0x19B9D40 Offset: 0x19B9E41 VA: 0x19B9D40
	public void .ctor() { }
}

// Namespace: System.Xml
internal class Ucs4Decoder3412 : Ucs4Decoder // TypeDefIndex: 1758
{
	// Methods

	// RVA: 0x19BA080 Offset: 0x19BA181 VA: 0x19BA080 Slot: 13
	internal override int GetFullChars(byte[] bytes, int byteIndex, int byteCount, char[] chars, int charIndex) { }

	// RVA: 0x19BA2E0 Offset: 0x19BA3E1 VA: 0x19BA2E0
	public void .ctor() { }
}

