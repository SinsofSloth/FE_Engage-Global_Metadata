// Namespace: System.Xml
internal class Ucs4Encoding : Encoding // TypeDefIndex: 1749
{
	// Fields
	internal Ucs4Decoder ucs4Decoder; // 0x38

	// Properties
	public override string WebName { get; }
	public override int CodePage { get; }
	internal static Encoding UCS4_Littleendian { get; }
	internal static Encoding UCS4_Bigendian { get; }
	internal static Encoding UCS4_2143 { get; }
	internal static Encoding UCS4_3412 { get; }

	// Methods

	// RVA: 0x19BA620 Offset: 0x19BA721 VA: 0x19BA620 Slot: 9
	public override string get_WebName() { }

	// RVA: 0x19BA630 Offset: 0x19BA731 VA: 0x19BA630 Slot: 29
	public override Decoder GetDecoder() { }

	// RVA: 0x19BA640 Offset: 0x19BA741 VA: 0x19BA640 Slot: 12
	public override int GetByteCount(char[] chars, int index, int count) { }

	// RVA: 0x19BA6B0 Offset: 0x19BA7B1 VA: 0x19BA6B0 Slot: 17
	public override byte[] GetBytes(string s) { }

	// RVA: 0x19BA6C0 Offset: 0x19BA7C1 VA: 0x19BA6C0 Slot: 16
	public override int GetBytes(char[] chars, int charIndex, int charCount, byte[] bytes, int byteIndex) { }

	// RVA: 0x19BA6D0 Offset: 0x19BA7D1 VA: 0x19BA6D0 Slot: 31
	public override int GetMaxByteCount(int charCount) { }

	// RVA: 0x19BA6E0 Offset: 0x19BA7E1 VA: 0x19BA6E0 Slot: 21
	public override int GetCharCount(byte[] bytes, int index, int count) { }

	// RVA: 0x19BA6F0 Offset: 0x19BA7F1 VA: 0x19BA6F0 Slot: 25
	public override int GetChars(byte[] bytes, int byteIndex, int byteCount, char[] chars, int charIndex) { }

	// RVA: 0x19BA700 Offset: 0x19BA801 VA: 0x19BA700 Slot: 32
	public override int GetMaxCharCount(int byteCount) { }

	// RVA: 0x19BA720 Offset: 0x19BA821 VA: 0x19BA720 Slot: 28
	public override int get_CodePage() { }

	// RVA: 0x19BA730 Offset: 0x19BA831 VA: 0x19BA730 Slot: 30
	public override Encoder GetEncoder() { }

	// RVA: 0x19BA740 Offset: 0x19BA841 VA: 0x19BA740
	internal static Encoding get_UCS4_Littleendian() { }

	// RVA: 0x19BA860 Offset: 0x19BA961 VA: 0x19BA860
	internal static Encoding get_UCS4_Bigendian() { }

	// RVA: 0x19BA980 Offset: 0x19BAA81 VA: 0x19BA980
	internal static Encoding get_UCS4_2143() { }

	// RVA: 0x19BAAA0 Offset: 0x19BABA1 VA: 0x19BAAA0
	internal static Encoding get_UCS4_3412() { }

	// RVA: 0x19BABC0 Offset: 0x19BACC1 VA: 0x19BABC0
	public void .ctor() { }
}

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
internal class Ucs4Encoding4321 : Ucs4Encoding // TypeDefIndex: 1751
{
	// Properties
	public override string EncodingName { get; }

	// Methods

	// RVA: 0x19BA7A0 Offset: 0x19BA8A1 VA: 0x19BA7A0
	public void .ctor() { }

	// RVA: 0x19BAE40 Offset: 0x19BAF41 VA: 0x19BAE40 Slot: 7
	public override string get_EncodingName() { }

	// RVA: 0x19BAE90 Offset: 0x19BAF91 VA: 0x19BAE90 Slot: 6
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
internal class Ucs4Encoding3412 : Ucs4Encoding // TypeDefIndex: 1753
{
	// Properties
	public override string EncodingName { get; }

	// Methods

	// RVA: 0x19BAB00 Offset: 0x19BAC01 VA: 0x19BAB00
	public void .ctor() { }

	// RVA: 0x19BAD70 Offset: 0x19BAE71 VA: 0x19BAD70 Slot: 7
	public override string get_EncodingName() { }

	// RVA: 0x19BADC0 Offset: 0x19BAEC1 VA: 0x19BADC0 Slot: 6
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
internal class Ucs4Decoder4321 : Ucs4Decoder // TypeDefIndex: 1755
{
	// Methods

	// RVA: 0x19BA350 Offset: 0x19BA451 VA: 0x19BA350 Slot: 13
	internal override int GetFullChars(byte[] bytes, int byteIndex, int byteCount, char[] chars, int charIndex) { }

	// RVA: 0x19BA5B0 Offset: 0x19BA6B1 VA: 0x19BA5B0
	public void .ctor() { }
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
internal class Ucs4Decoder2143 : Ucs4Decoder // TypeDefIndex: 1757
{
	// Methods

	// RVA: 0x19B9DB0 Offset: 0x19B9EB1 VA: 0x19B9DB0 Slot: 13
	internal override int GetFullChars(byte[] bytes, int byteIndex, int byteCount, char[] chars, int charIndex) { }

	// RVA: 0x19BA010 Offset: 0x19BA111 VA: 0x19BA010
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

