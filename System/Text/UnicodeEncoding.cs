// Namespace: System.Text
[ComVisibleAttribute] // RVA: 0x471480 Offset: 0x471581 VA: 0x471480
[Serializable]
public class UnicodeEncoding : Encoding // TypeDefIndex: 468
{
	// Fields
	[OptionalFieldAttribute] // RVA: 0x4782A0 Offset: 0x4783A1 VA: 0x4782A0
	internal bool isThrowException; // 0x38
	internal bool bigEndian; // 0x39
	internal bool byteOrderMark; // 0x3A
	private static readonly ulong highLowPatternMask; // 0x0

	// Methods

	// RVA: 0x3651E30 Offset: 0x3651F31 VA: 0x3651E30
	public void .ctor() { }

	// RVA: 0x3651E70 Offset: 0x3651F71 VA: 0x3651E70
	public void .ctor(bool bigEndian, bool byteOrderMark) { }

	// RVA: 0x3651ED0 Offset: 0x3651FD1 VA: 0x3651ED0
	public void .ctor(bool bigEndian, bool byteOrderMark, bool throwOnInvalidBytes) { }

	[OnDeserializingAttribute] // RVA: 0x47B770 Offset: 0x47B871 VA: 0x47B770
	// RVA: 0x3651F60 Offset: 0x3652061 VA: 0x3651F60
	private void OnDeserializing(StreamingContext ctx) { }

	// RVA: 0x3651F70 Offset: 0x3652071 VA: 0x3651F70 Slot: 5
	internal override void SetDefaultFallbacks() { }

	// RVA: 0x3652080 Offset: 0x3652181 VA: 0x3652080 Slot: 12
	public override int GetByteCount(char[] chars, int index, int count) { }

	// RVA: 0x3652220 Offset: 0x3652321 VA: 0x3652220 Slot: 11
	public override int GetByteCount(string s) { }

	[ComVisibleAttribute] // RVA: 0x47B780 Offset: 0x47B881 VA: 0x47B780
	[CLSCompliantAttribute] // RVA: 0x47B780 Offset: 0x47B881 VA: 0x47B780
	// RVA: 0x36522B0 Offset: 0x36523B1 VA: 0x36522B0 Slot: 13
	public override int GetByteCount(char* chars, int count) { }

	// RVA: 0x36523A0 Offset: 0x36524A1 VA: 0x36523A0 Slot: 18
	public override int GetBytes(string s, int charIndex, int charCount, byte[] bytes, int byteIndex) { }

	// RVA: 0x3652630 Offset: 0x3652731 VA: 0x3652630 Slot: 16
	public override int GetBytes(char[] chars, int charIndex, int charCount, byte[] bytes, int byteIndex) { }

	[CLSCompliantAttribute] // RVA: 0x47B7C0 Offset: 0x47B8C1 VA: 0x47B7C0
	[ComVisibleAttribute] // RVA: 0x47B7C0 Offset: 0x47B8C1 VA: 0x47B7C0
	// RVA: 0x36528E0 Offset: 0x36529E1 VA: 0x36528E0 Slot: 20
	public override int GetBytes(char* chars, int charCount, byte* bytes, int byteCount) { }

	// RVA: 0x3652A00 Offset: 0x3652B01 VA: 0x3652A00 Slot: 21
	public override int GetCharCount(byte[] bytes, int index, int count) { }

	[CLSCompliantAttribute] // RVA: 0x47B800 Offset: 0x47B901 VA: 0x47B800
	[ComVisibleAttribute] // RVA: 0x47B800 Offset: 0x47B901 VA: 0x47B800
	// RVA: 0x3652BA0 Offset: 0x3652CA1 VA: 0x3652BA0 Slot: 22
	public override int GetCharCount(byte* bytes, int count) { }

	// RVA: 0x3652C90 Offset: 0x3652D91 VA: 0x3652C90 Slot: 25
	public override int GetChars(byte[] bytes, int byteIndex, int byteCount, char[] chars, int charIndex) { }

	[CLSCompliantAttribute] // RVA: 0x47B840 Offset: 0x47B941 VA: 0x47B840
	[ComVisibleAttribute] // RVA: 0x47B840 Offset: 0x47B941 VA: 0x47B840
	// RVA: 0x3652F40 Offset: 0x3653041 VA: 0x3652F40 Slot: 26
	public override int GetChars(byte* bytes, int byteCount, char* chars, int charCount) { }

	[ComVisibleAttribute] // RVA: 0x47B880 Offset: 0x47B981 VA: 0x47B880
	// RVA: 0x3653060 Offset: 0x3653161 VA: 0x3653060 Slot: 34
	public override string GetString(byte[] bytes, int index, int count) { }

	// RVA: 0x3653250 Offset: 0x3653351 VA: 0x3653250 Slot: 14
	internal override int GetByteCount(char* chars, int count, EncoderNLS encoder) { }

	// RVA: 0x3653950 Offset: 0x3653A51 VA: 0x3653950 Slot: 19
	internal override int GetBytes(char* chars, int charCount, byte* bytes, int byteCount, EncoderNLS encoder) { }

	// RVA: 0x3654140 Offset: 0x3654241 VA: 0x3654140 Slot: 23
	internal override int GetCharCount(byte* bytes, int count, DecoderNLS baseDecoder) { }

	// RVA: 0x3654870 Offset: 0x3654971 VA: 0x3654870 Slot: 27
	internal override int GetChars(byte* bytes, int byteCount, char* chars, int charCount, DecoderNLS baseDecoder) { }

	[ComVisibleAttribute] // RVA: 0x47B8A0 Offset: 0x47B9A1 VA: 0x47B8A0
	// RVA: 0x36551C0 Offset: 0x36552C1 VA: 0x36551C0 Slot: 30
	public override Encoder GetEncoder() { }

	// RVA: 0x3655230 Offset: 0x3655331 VA: 0x3655230 Slot: 29
	public override Decoder GetDecoder() { }

	// RVA: 0x36552A0 Offset: 0x36553A1 VA: 0x36552A0 Slot: 6
	public override byte[] GetPreamble() { }

	// RVA: 0x36553A0 Offset: 0x36554A1 VA: 0x36553A0 Slot: 31
	public override int GetMaxByteCount(int charCount) { }

	// RVA: 0x3655480 Offset: 0x3655581 VA: 0x3655480 Slot: 32
	public override int GetMaxCharCount(int byteCount) { }

	// RVA: 0x3655560 Offset: 0x3655661 VA: 0x3655560 Slot: 0
	public override bool Equals(object value) { }

	// RVA: 0x36556A0 Offset: 0x36557A1 VA: 0x36556A0 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x3655720 Offset: 0x3655821 VA: 0x3655720
	private static void .cctor() { }
}

