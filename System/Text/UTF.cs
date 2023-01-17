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

