// Namespace: System.Text
[Serializable]
internal class EncoderNLS : Encoder, ISerializable // TypeDefIndex: 454
{
	// Fields
	internal char charLeftOver; // 0x20
	protected Encoding m_encoding; // 0x28
	protected bool m_mustFlush; // 0x30
	internal bool m_throwOnOverflow; // 0x31
	internal int m_charsUsed; // 0x34

	// Properties
	public Encoding Encoding { get; }
	public bool MustFlush { get; }

	// Methods

	// RVA: 0x372EAE0 Offset: 0x372EBE1 VA: 0x372EAE0
	internal void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x372EBC0 Offset: 0x372ECC1 VA: 0x372EBC0 Slot: 9
	private void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x372ED00 Offset: 0x372EE01 VA: 0x372ED00
	internal void .ctor(Encoding encoding) { }

	// RVA: 0x372ED70 Offset: 0x372EE71 VA: 0x372ED70
	internal void .ctor() { }

	// RVA: 0x372EDB0 Offset: 0x372EEB1 VA: 0x372EDB0 Slot: 4
	public override void Reset() { }

	// RVA: 0x372EDD0 Offset: 0x372EED1 VA: 0x372EDD0 Slot: 5
	public override int GetByteCount(char[] chars, int index, int count, bool flush) { }

	// RVA: 0x372EFD0 Offset: 0x372F0D1 VA: 0x372EFD0 Slot: 6
	public override int GetByteCount(char* chars, int count, bool flush) { }

	// RVA: 0x372F0D0 Offset: 0x372F1D1 VA: 0x372F0D0 Slot: 7
	public override int GetBytes(char[] chars, int charIndex, int charCount, byte[] bytes, int byteIndex, bool flush) { }

	// RVA: 0x372F390 Offset: 0x372F491 VA: 0x372F390 Slot: 8
	public override int GetBytes(char* chars, int charCount, byte* bytes, int byteCount, bool flush) { }

	// RVA: 0x372F4C0 Offset: 0x372F5C1 VA: 0x372F4C0
	public Encoding get_Encoding() { }

	// RVA: 0x372F4D0 Offset: 0x372F5D1 VA: 0x372F4D0
	public bool get_MustFlush() { }

	// RVA: 0x372F4E0 Offset: 0x372F5E1 VA: 0x372F4E0
	internal void ClearMustFlush() { }
}

