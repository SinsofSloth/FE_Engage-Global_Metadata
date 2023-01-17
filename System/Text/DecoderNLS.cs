// Namespace: System.Text
[Serializable]
internal class DecoderNLS : Decoder, ISerializable // TypeDefIndex: 443
{
	// Fields
	protected Encoding m_encoding; // 0x20
	protected bool m_mustFlush; // 0x28
	internal bool m_throwOnOverflow; // 0x29
	internal int m_bytesUsed; // 0x2C

	// Properties
	public bool MustFlush { get; }
	internal virtual bool HasState { get; }

	// Methods

	// RVA: 0x371EC50 Offset: 0x371ED51 VA: 0x371EC50
	internal void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x371ED30 Offset: 0x371EE31 VA: 0x371ED30 Slot: 13
	private void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x371EE40 Offset: 0x371EF41 VA: 0x371EE40
	internal void .ctor(Encoding encoding) { }

	// RVA: 0x371EEB0 Offset: 0x371EFB1 VA: 0x371EEB0
	internal void .ctor() { }

	// RVA: 0x371EEF0 Offset: 0x371EFF1 VA: 0x371EEF0 Slot: 4
	public override void Reset() { }

	// RVA: 0x371EF10 Offset: 0x371F011 VA: 0x371EF10 Slot: 5
	public override int GetCharCount(byte[] bytes, int index, int count) { }

	// RVA: 0x371EF20 Offset: 0x371F021 VA: 0x371EF20 Slot: 6
	public override int GetCharCount(byte[] bytes, int index, int count, bool flush) { }

	// RVA: 0x371F120 Offset: 0x371F221 VA: 0x371F120 Slot: 7
	public override int GetCharCount(byte* bytes, int count, bool flush) { }

	// RVA: 0x371F220 Offset: 0x371F321 VA: 0x371F220 Slot: 8
	public override int GetChars(byte[] bytes, int byteIndex, int byteCount, char[] chars, int charIndex) { }

	// RVA: 0x371F230 Offset: 0x371F331 VA: 0x371F230 Slot: 9
	public override int GetChars(byte[] bytes, int byteIndex, int byteCount, char[] chars, int charIndex, bool flush) { }

	// RVA: 0x371F4F0 Offset: 0x371F5F1 VA: 0x371F4F0 Slot: 10
	public override int GetChars(byte* bytes, int byteCount, char* chars, int charCount, bool flush) { }

	// RVA: 0x371F620 Offset: 0x371F721 VA: 0x371F620 Slot: 11
	public override void Convert(byte[] bytes, int byteIndex, int byteCount, char[] chars, int charIndex, int charCount, bool flush, out int bytesUsed, out int charsUsed, out bool completed) { }

	// RVA: 0x371F930 Offset: 0x371FA31 VA: 0x371F930 Slot: 12
	public override void Convert(byte* bytes, int byteCount, char* chars, int charCount, bool flush, out int bytesUsed, out int charsUsed, out bool completed) { }

	// RVA: 0x371FAF0 Offset: 0x371FBF1 VA: 0x371FAF0
	public bool get_MustFlush() { }

	// RVA: 0x371FB00 Offset: 0x371FC01 VA: 0x371FB00 Slot: 14
	internal virtual bool get_HasState() { }

	// RVA: 0x371FB10 Offset: 0x371FC11 VA: 0x371FB10
	internal void ClearMustFlush() { }
}

