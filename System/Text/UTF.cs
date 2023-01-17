// Namespace: System.Text
[Serializable]
public sealed class UTF32Encoding : Encoding // TypeDefIndex: 470
{
	// Fields
	private bool emitUTF32ByteOrderMark; // 0x38
	private bool isThrowException; // 0x39
	private bool bigEndian; // 0x3A

	// Methods

	// RVA: 0x3648AB0 Offset: 0x3648BB1 VA: 0x3648AB0
	public void .ctor() { }

	// RVA: 0x3648B80 Offset: 0x3648C81 VA: 0x3648B80
	public void .ctor(bool bigEndian, bool byteOrderMark) { }

	// RVA: 0x3648AF0 Offset: 0x3648BF1 VA: 0x3648AF0
	public void .ctor(bool bigEndian, bool byteOrderMark, bool throwOnInvalidCharacters) { }

	// RVA: 0x3648BD0 Offset: 0x3648CD1 VA: 0x3648BD0 Slot: 5
	internal override void SetDefaultFallbacks() { }

	// RVA: 0x3648CE0 Offset: 0x3648DE1 VA: 0x3648CE0 Slot: 12
	public override int GetByteCount(char[] chars, int index, int count) { }

	// RVA: 0x3648E80 Offset: 0x3648F81 VA: 0x3648E80 Slot: 11
	public override int GetByteCount(string s) { }

	[CLSCompliantAttribute] // RVA: 0x47B8C0 Offset: 0x47B9C1 VA: 0x47B8C0
	// RVA: 0x3648F10 Offset: 0x3649011 VA: 0x3648F10 Slot: 13
	public override int GetByteCount(char* chars, int count) { }

	// RVA: 0x3649000 Offset: 0x3649101 VA: 0x3649000 Slot: 18
	public override int GetBytes(string s, int charIndex, int charCount, byte[] bytes, int byteIndex) { }

	// RVA: 0x3649290 Offset: 0x3649391 VA: 0x3649290 Slot: 16
	public override int GetBytes(char[] chars, int charIndex, int charCount, byte[] bytes, int byteIndex) { }

	[CLSCompliantAttribute] // RVA: 0x47B8E0 Offset: 0x47B9E1 VA: 0x47B8E0
	// RVA: 0x3649540 Offset: 0x3649641 VA: 0x3649540 Slot: 20
	public override int GetBytes(char* chars, int charCount, byte* bytes, int byteCount) { }

	// RVA: 0x3649660 Offset: 0x3649761 VA: 0x3649660 Slot: 21
	public override int GetCharCount(byte[] bytes, int index, int count) { }

	[CLSCompliantAttribute] // RVA: 0x47B900 Offset: 0x47BA01 VA: 0x47B900
	// RVA: 0x3649800 Offset: 0x3649901 VA: 0x3649800 Slot: 22
	public override int GetCharCount(byte* bytes, int count) { }

	// RVA: 0x36498F0 Offset: 0x36499F1 VA: 0x36498F0 Slot: 25
	public override int GetChars(byte[] bytes, int byteIndex, int byteCount, char[] chars, int charIndex) { }

	[CLSCompliantAttribute] // RVA: 0x47B920 Offset: 0x47BA21 VA: 0x47B920
	// RVA: 0x3649BA0 Offset: 0x3649CA1 VA: 0x3649BA0 Slot: 26
	public override int GetChars(byte* bytes, int byteCount, char* chars, int charCount) { }

	// RVA: 0x3649CC0 Offset: 0x3649DC1 VA: 0x3649CC0 Slot: 34
	public override string GetString(byte[] bytes, int index, int count) { }

	// RVA: 0x3649EB0 Offset: 0x3649FB1 VA: 0x3649EB0 Slot: 14
	internal override int GetByteCount(char* chars, int count, EncoderNLS encoder) { }

	// RVA: 0x364A2D0 Offset: 0x364A3D1 VA: 0x364A2D0 Slot: 19
	internal override int GetBytes(char* chars, int charCount, byte* bytes, int byteCount, EncoderNLS encoder) { }

	// RVA: 0x364A720 Offset: 0x364A821 VA: 0x364A720 Slot: 23
	internal override int GetCharCount(byte* bytes, int count, DecoderNLS baseDecoder) { }

	// RVA: 0x364AAB0 Offset: 0x364ABB1 VA: 0x364AAB0 Slot: 27
	internal override int GetChars(byte* bytes, int byteCount, char* chars, int charCount, DecoderNLS baseDecoder) { }

	// RVA: 0x364A700 Offset: 0x364A801 VA: 0x364A700
	private uint GetSurrogate(char cHigh, char cLow) { }

	// RVA: 0x364AEF0 Offset: 0x364AFF1 VA: 0x364AEF0
	private char GetHighSurrogate(uint iChar) { }

	// RVA: 0x364AF10 Offset: 0x364B011 VA: 0x364AF10
	private char GetLowSurrogate(uint iChar) { }

	// RVA: 0x364AF20 Offset: 0x364B021 VA: 0x364AF20 Slot: 29
	public override Decoder GetDecoder() { }

	// RVA: 0x364AF90 Offset: 0x364B091 VA: 0x364AF90 Slot: 30
	public override Encoder GetEncoder() { }

	// RVA: 0x364B000 Offset: 0x364B101 VA: 0x364B000 Slot: 31
	public override int GetMaxByteCount(int charCount) { }

	// RVA: 0x364B0E0 Offset: 0x364B1E1 VA: 0x364B0E0 Slot: 32
	public override int GetMaxCharCount(int byteCount) { }

	// RVA: 0x364B1B0 Offset: 0x364B2B1 VA: 0x364B1B0 Slot: 6
	public override byte[] GetPreamble() { }

	// RVA: 0x364B2B0 Offset: 0x364B3B1 VA: 0x364B2B0 Slot: 0
	public override bool Equals(object value) { }

	// RVA: 0x364B3A0 Offset: 0x364B4A1 VA: 0x364B3A0 Slot: 2
	public override int GetHashCode() { }
}

// Namespace: System.Text
[ComVisibleAttribute] // RVA: 0x4714A0 Offset: 0x4715A1 VA: 0x4714A0
[Serializable]
public class UTF7Encoding : Encoding // TypeDefIndex: 475
{
	// Fields
	private byte[] base64Bytes; // 0x38
	private sbyte[] base64Values; // 0x40
	private bool[] directEncode; // 0x48
	[OptionalFieldAttribute] // RVA: 0x4782E0 Offset: 0x4783E1 VA: 0x4782E0
	private bool m_allowOptionals; // 0x50

	// Methods

	// RVA: 0x364B420 Offset: 0x364B521 VA: 0x364B420
	public void .ctor() { }

	// RVA: 0x364B450 Offset: 0x364B551 VA: 0x364B450
	public void .ctor(bool allowOptionals) { }

	// RVA: 0x364B490 Offset: 0x364B591 VA: 0x364B490
	private void MakeTables() { }

	// RVA: 0x364B750 Offset: 0x364B851 VA: 0x364B750 Slot: 5
	internal override void SetDefaultFallbacks() { }

	[OnDeserializingAttribute] // RVA: 0x47B940 Offset: 0x47BA41 VA: 0x47B940
	// RVA: 0x364B820 Offset: 0x364B921 VA: 0x364B820
	private void OnDeserializing(StreamingContext ctx) { }

	[OnDeserializedAttribute] // RVA: 0x47B950 Offset: 0x47BA51 VA: 0x47B950
	// RVA: 0x364B830 Offset: 0x364B931 VA: 0x364B830
	private void OnDeserialized(StreamingContext ctx) { }

	[ComVisibleAttribute] // RVA: 0x47B960 Offset: 0x47BA61 VA: 0x47B960
	// RVA: 0x364B8D0 Offset: 0x364B9D1 VA: 0x364B8D0 Slot: 0
	public override bool Equals(object value) { }

	[ComVisibleAttribute] // RVA: 0x47B980 Offset: 0x47BA81 VA: 0x47B980
	// RVA: 0x364B9B0 Offset: 0x364BAB1 VA: 0x364B9B0 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x364BA20 Offset: 0x364BB21 VA: 0x364BA20 Slot: 12
	public override int GetByteCount(char[] chars, int index, int count) { }

	[ComVisibleAttribute] // RVA: 0x47B9A0 Offset: 0x47BAA1 VA: 0x47B9A0
	// RVA: 0x364BBC0 Offset: 0x364BCC1 VA: 0x364BBC0 Slot: 11
	public override int GetByteCount(string s) { }

	[ComVisibleAttribute] // RVA: 0x47B9C0 Offset: 0x47BAC1 VA: 0x47B9C0
	[CLSCompliantAttribute] // RVA: 0x47B9C0 Offset: 0x47BAC1 VA: 0x47B9C0
	// RVA: 0x364BC50 Offset: 0x364BD51 VA: 0x364BC50 Slot: 13
	public override int GetByteCount(char* chars, int count) { }

	[ComVisibleAttribute] // RVA: 0x47BA00 Offset: 0x47BB01 VA: 0x47BA00
	// RVA: 0x364BD40 Offset: 0x364BE41 VA: 0x364BD40 Slot: 18
	public override int GetBytes(string s, int charIndex, int charCount, byte[] bytes, int byteIndex) { }

	// RVA: 0x364BFD0 Offset: 0x364C0D1 VA: 0x364BFD0 Slot: 16
	public override int GetBytes(char[] chars, int charIndex, int charCount, byte[] bytes, int byteIndex) { }

	[CLSCompliantAttribute] // RVA: 0x47BA20 Offset: 0x47BB21 VA: 0x47BA20
	[ComVisibleAttribute] // RVA: 0x47BA20 Offset: 0x47BB21 VA: 0x47BA20
	// RVA: 0x364C280 Offset: 0x364C381 VA: 0x364C280 Slot: 20
	public override int GetBytes(char* chars, int charCount, byte* bytes, int byteCount) { }

	// RVA: 0x364C3A0 Offset: 0x364C4A1 VA: 0x364C3A0 Slot: 21
	public override int GetCharCount(byte[] bytes, int index, int count) { }

	[ComVisibleAttribute] // RVA: 0x47BA60 Offset: 0x47BB61 VA: 0x47BA60
	[CLSCompliantAttribute] // RVA: 0x47BA60 Offset: 0x47BB61 VA: 0x47BA60
	// RVA: 0x364C540 Offset: 0x364C641 VA: 0x364C540 Slot: 22
	public override int GetCharCount(byte* bytes, int count) { }

	// RVA: 0x364C630 Offset: 0x364C731 VA: 0x364C630 Slot: 25
	public override int GetChars(byte[] bytes, int byteIndex, int byteCount, char[] chars, int charIndex) { }

	[ComVisibleAttribute] // RVA: 0x47BAA0 Offset: 0x47BBA1 VA: 0x47BAA0
	[CLSCompliantAttribute] // RVA: 0x47BAA0 Offset: 0x47BBA1 VA: 0x47BAA0
	// RVA: 0x364C8E0 Offset: 0x364C9E1 VA: 0x364C8E0 Slot: 26
	public override int GetChars(byte* bytes, int byteCount, char* chars, int charCount) { }

	[ComVisibleAttribute] // RVA: 0x47BAE0 Offset: 0x47BBE1 VA: 0x47BAE0
	// RVA: 0x364CA00 Offset: 0x364CB01 VA: 0x364CA00 Slot: 34
	public override string GetString(byte[] bytes, int index, int count) { }

	// RVA: 0x364CBF0 Offset: 0x364CCF1 VA: 0x364CBF0 Slot: 14
	internal override int GetByteCount(char* chars, int count, EncoderNLS baseEncoder) { }

	// RVA: 0x364CC10 Offset: 0x364CD11 VA: 0x364CC10 Slot: 19
	internal override int GetBytes(char* chars, int charCount, byte* bytes, int byteCount, EncoderNLS baseEncoder) { }

	// RVA: 0x364D000 Offset: 0x364D101 VA: 0x364D000 Slot: 23
	internal override int GetCharCount(byte* bytes, int count, DecoderNLS baseDecoder) { }

	// RVA: 0x364D020 Offset: 0x364D121 VA: 0x364D020 Slot: 27
	internal override int GetChars(byte* bytes, int byteCount, char* chars, int charCount, DecoderNLS baseDecoder) { }

	// RVA: 0x364D340 Offset: 0x364D441 VA: 0x364D340 Slot: 29
	public override Decoder GetDecoder() { }

	// RVA: 0x364D3B0 Offset: 0x364D4B1 VA: 0x364D3B0 Slot: 30
	public override Encoder GetEncoder() { }

	// RVA: 0x364D420 Offset: 0x364D521 VA: 0x364D420 Slot: 31
	public override int GetMaxByteCount(int charCount) { }

	// RVA: 0x364D4D0 Offset: 0x364D5D1 VA: 0x364D4D0 Slot: 32
	public override int GetMaxCharCount(int byteCount) { }
}

// Namespace: System.Text
[ComVisibleAttribute] // RVA: 0x4714C0 Offset: 0x4715C1 VA: 0x4714C0
[Serializable]
public class UTF8Encoding : Encoding // TypeDefIndex: 478
{
	// Fields
	private bool emitUTF8Identifier; // 0x38
	private bool isThrowException; // 0x39

	// Methods

	// RVA: 0x364D550 Offset: 0x364D651 VA: 0x364D550
	public void .ctor() { }

	// RVA: 0x364D580 Offset: 0x364D681 VA: 0x364D580
	public void .ctor(bool encoderShouldEmitUTF8Identifier) { }

	// RVA: 0x364D5C0 Offset: 0x364D6C1 VA: 0x364D5C0
	public void .ctor(bool encoderShouldEmitUTF8Identifier, bool throwOnInvalidBytes) { }

	// RVA: 0x364D630 Offset: 0x364D731 VA: 0x364D630 Slot: 5
	internal override void SetDefaultFallbacks() { }

	// RVA: 0x364D740 Offset: 0x364D841 VA: 0x364D740 Slot: 12
	public override int GetByteCount(char[] chars, int index, int count) { }

	// RVA: 0x364D8E0 Offset: 0x364D9E1 VA: 0x364D8E0 Slot: 11
	public override int GetByteCount(string chars) { }

	[CLSCompliantAttribute] // RVA: 0x47BB00 Offset: 0x47BC01 VA: 0x47BB00
	[ComVisibleAttribute] // RVA: 0x47BB00 Offset: 0x47BC01 VA: 0x47BB00
	// RVA: 0x364D970 Offset: 0x364DA71 VA: 0x364D970 Slot: 13
	public override int GetByteCount(char* chars, int count) { }

	// RVA: 0x364DA60 Offset: 0x364DB61 VA: 0x364DA60 Slot: 18
	public override int GetBytes(string s, int charIndex, int charCount, byte[] bytes, int byteIndex) { }

	// RVA: 0x364DCF0 Offset: 0x364DDF1 VA: 0x364DCF0 Slot: 16
	public override int GetBytes(char[] chars, int charIndex, int charCount, byte[] bytes, int byteIndex) { }

	[CLSCompliantAttribute] // RVA: 0x47BB40 Offset: 0x47BC41 VA: 0x47BB40
	[ComVisibleAttribute] // RVA: 0x47BB40 Offset: 0x47BC41 VA: 0x47BB40
	// RVA: 0x364DFA0 Offset: 0x364E0A1 VA: 0x364DFA0 Slot: 20
	public override int GetBytes(char* chars, int charCount, byte* bytes, int byteCount) { }

	// RVA: 0x364E0C0 Offset: 0x364E1C1 VA: 0x364E0C0 Slot: 21
	public override int GetCharCount(byte[] bytes, int index, int count) { }

	[ComVisibleAttribute] // RVA: 0x47BB80 Offset: 0x47BC81 VA: 0x47BB80
	[CLSCompliantAttribute] // RVA: 0x47BB80 Offset: 0x47BC81 VA: 0x47BB80
	// RVA: 0x364E260 Offset: 0x364E361 VA: 0x364E260 Slot: 22
	public override int GetCharCount(byte* bytes, int count) { }

	// RVA: 0x364E350 Offset: 0x364E451 VA: 0x364E350 Slot: 25
	public override int GetChars(byte[] bytes, int byteIndex, int byteCount, char[] chars, int charIndex) { }

	[CLSCompliantAttribute] // RVA: 0x47BBC0 Offset: 0x47BCC1 VA: 0x47BBC0
	[ComVisibleAttribute] // RVA: 0x47BBC0 Offset: 0x47BCC1 VA: 0x47BBC0
	// RVA: 0x364E600 Offset: 0x364E701 VA: 0x364E600 Slot: 26
	public override int GetChars(byte* bytes, int byteCount, char* chars, int charCount) { }

	[ComVisibleAttribute] // RVA: 0x47BC00 Offset: 0x47BD01 VA: 0x47BC00
	// RVA: 0x364E720 Offset: 0x364E821 VA: 0x364E720 Slot: 34
	public override string GetString(byte[] bytes, int index, int count) { }

	// RVA: 0x364E910 Offset: 0x364EA11 VA: 0x364E910 Slot: 14
	internal override int GetByteCount(char* chars, int count, EncoderNLS baseEncoder) { }

	// RVA: 0x364EF00 Offset: 0x364F001 VA: 0x364EF00
	private static int PtrDiff(char* a, char* b) { }

	// RVA: 0x364EF10 Offset: 0x364F011 VA: 0x364EF10
	private static int PtrDiff(byte* a, byte* b) { }

	// RVA: 0x364EEE0 Offset: 0x364EFE1 VA: 0x364EEE0
	private static bool InRange(int ch, int start, int end) { }

	// RVA: 0x364EF20 Offset: 0x364F021 VA: 0x364EF20 Slot: 19
	internal override int GetBytes(char* chars, int charCount, byte* bytes, int byteCount, EncoderNLS baseEncoder) { }

	// RVA: 0x364F690 Offset: 0x364F791 VA: 0x364F690 Slot: 23
	internal override int GetCharCount(byte* bytes, int count, DecoderNLS baseDecoder) { }

	// RVA: 0x364FC30 Offset: 0x364FD31 VA: 0x364FC30 Slot: 27
	internal override int GetChars(byte* bytes, int byteCount, char* chars, int charCount, DecoderNLS baseDecoder) { }

	// RVA: 0x3650460 Offset: 0x3650561 VA: 0x3650460
	private bool FallbackInvalidByteSequence(ref byte* pSrc, int ch, DecoderFallbackBuffer fallback, ref char* pTarget) { }

	// RVA: 0x364FBF0 Offset: 0x364FCF1 VA: 0x364FBF0
	private int FallbackInvalidByteSequence(byte* pSrc, int ch, DecoderFallbackBuffer fallback) { }

	// RVA: 0x36504E0 Offset: 0x36505E1 VA: 0x36504E0
	private byte[] GetBytesUnknown(ref byte* pSrc, int ch) { }

	// RVA: 0x3650730 Offset: 0x3650831 VA: 0x3650730 Slot: 29
	public override Decoder GetDecoder() { }

	// RVA: 0x36507A0 Offset: 0x36508A1 VA: 0x36507A0 Slot: 30
	public override Encoder GetEncoder() { }

	// RVA: 0x3650810 Offset: 0x3650911 VA: 0x3650810 Slot: 31
	public override int GetMaxByteCount(int charCount) { }

	// RVA: 0x36508F0 Offset: 0x36509F1 VA: 0x36508F0 Slot: 32
	public override int GetMaxCharCount(int byteCount) { }

	// RVA: 0x36509D0 Offset: 0x3650AD1 VA: 0x36509D0 Slot: 6
	public override byte[] GetPreamble() { }

	// RVA: 0x3650AA0 Offset: 0x3650BA1 VA: 0x3650AA0 Slot: 0
	public override bool Equals(object value) { }

	// RVA: 0x3650B80 Offset: 0x3650C81 VA: 0x3650B80 Slot: 2
	public override int GetHashCode() { }
}

