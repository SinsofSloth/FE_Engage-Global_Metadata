// Namespace: System.Text
[Serializable]
internal class Latin1Encoding : EncodingNLS, ISerializable // TypeDefIndex: 464
{
	// Fields
	private static readonly char[] arrayCharBestFit; // 0x0

	// Methods

	// RVA: 0x341B9E0 Offset: 0x341BAE1 VA: 0x341B9E0
	public void .ctor() { }

	// RVA: 0x341B9F0 Offset: 0x341BAF1 VA: 0x341B9F0
	internal void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x341BA40 Offset: 0x341BB41 VA: 0x341BA40 Slot: 37
	private void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x341BB40 Offset: 0x341BC41 VA: 0x341BB40 Slot: 14
	internal override int GetByteCount(char* chars, int charCount, EncoderNLS encoder) { }

	// RVA: 0x341BE10 Offset: 0x341BF11 VA: 0x341BE10 Slot: 19
	internal override int GetBytes(char* chars, int charCount, byte* bytes, int byteCount, EncoderNLS encoder) { }

	// RVA: 0x341C270 Offset: 0x341C371 VA: 0x341C270 Slot: 23
	internal override int GetCharCount(byte* bytes, int count, DecoderNLS decoder) { }

	// RVA: 0x341C280 Offset: 0x341C381 VA: 0x341C280 Slot: 27
	internal override int GetChars(byte* bytes, int byteCount, char* chars, int charCount, DecoderNLS decoder) { }

	// RVA: 0x341C320 Offset: 0x341C421 VA: 0x341C320 Slot: 31
	public override int GetMaxByteCount(int charCount) { }

	// RVA: 0x341C400 Offset: 0x341C501 VA: 0x341C400 Slot: 32
	public override int GetMaxCharCount(int byteCount) { }

	// RVA: 0x341C4E0 Offset: 0x341C5E1 VA: 0x341C4E0 Slot: 35
	internal override char[] GetBestFitUnicodeToBytesData() { }

	// RVA: 0x341C550 Offset: 0x341C651 VA: 0x341C550
	private static void .cctor() { }
}

