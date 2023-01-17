// Namespace: 
[Serializable]
internal class Encoding.DefaultDecoder : Decoder, ISerializable, IObjectReference // TypeDefIndex: 458
{
	// Fields
	private Encoding m_encoding; // 0x20
	private bool m_hasInitializedEncoding; // 0x28

	// Methods

	// RVA: 0x35E93A0 Offset: 0x35E94A1 VA: 0x35E93A0
	public void .ctor(Encoding encoding) { }

	// RVA: 0x35E93E0 Offset: 0x35E94E1 VA: 0x35E93E0
	internal void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x35E96B0 Offset: 0x35E97B1 VA: 0x35E96B0 Slot: 14
	public object GetRealObject(StreamingContext context) { }

	// RVA: 0x35E9720 Offset: 0x35E9821 VA: 0x35E9720 Slot: 13
	private void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x35E97D0 Offset: 0x35E98D1 VA: 0x35E97D0 Slot: 5
	public override int GetCharCount(byte[] bytes, int index, int count) { }

	// RVA: 0x35E97E0 Offset: 0x35E98E1 VA: 0x35E97E0 Slot: 6
	public override int GetCharCount(byte[] bytes, int index, int count, bool flush) { }

	// RVA: 0x35E9800 Offset: 0x35E9901 VA: 0x35E9800 Slot: 7
	public override int GetCharCount(byte* bytes, int count, bool flush) { }

	// RVA: 0x35E9820 Offset: 0x35E9921 VA: 0x35E9820 Slot: 8
	public override int GetChars(byte[] bytes, int byteIndex, int byteCount, char[] chars, int charIndex) { }

	// RVA: 0x35E9830 Offset: 0x35E9931 VA: 0x35E9830 Slot: 9
	public override int GetChars(byte[] bytes, int byteIndex, int byteCount, char[] chars, int charIndex, bool flush) { }

	// RVA: 0x35E9850 Offset: 0x35E9951 VA: 0x35E9850 Slot: 10
	public override int GetChars(byte* bytes, int byteCount, char* chars, int charCount, bool flush) { }
}

// Namespace: 
internal class Encoding.EncodingByteBuffer // TypeDefIndex: 460
{
	// Fields
	private byte* bytes; // 0x10
	private byte* byteStart; // 0x18
	private byte* byteEnd; // 0x20
	private char* chars; // 0x28
	private char* charStart; // 0x30
	private char* charEnd; // 0x38
	private int byteCountResult; // 0x40
	private Encoding enc; // 0x48
	private EncoderNLS encoder; // 0x50
	internal EncoderFallbackBuffer fallbackBuffer; // 0x58

	// Properties
	internal bool MoreData { get; }
	internal int CharsUsed { get; }
	internal int Count { get; }

	// Methods

	// RVA: 0x35E9DF0 Offset: 0x35E9EF1 VA: 0x35E9DF0
	internal void .ctor(Encoding inEncoding, EncoderNLS inEncoder, byte* inByteStart, int inByteCount, char* inCharStart, int inCharCount) { }

	// RVA: 0x35E9FE0 Offset: 0x35EA0E1 VA: 0x35E9FE0
	internal bool AddByte(byte b, int moreBytesExpected) { }

	// RVA: 0x35EA110 Offset: 0x35EA211 VA: 0x35EA110
	internal bool AddByte(byte b1) { }

	// RVA: 0x35EA1C0 Offset: 0x35EA2C1 VA: 0x35EA1C0
	internal bool AddByte(byte b1, byte b2) { }

	// RVA: 0x35EA1D0 Offset: 0x35EA2D1 VA: 0x35EA1D0
	internal bool AddByte(byte b1, byte b2, int moreBytesExpected) { }

	// RVA: 0x35EA090 Offset: 0x35EA191 VA: 0x35EA090
	internal void MovePrevious(bool bThrow) { }

	// RVA: 0x35EA2C0 Offset: 0x35EA3C1 VA: 0x35EA2C0
	internal bool get_MoreData() { }

	// RVA: 0x35EA320 Offset: 0x35EA421 VA: 0x35EA320
	internal char GetNextChar() { }

	// RVA: 0x35EA390 Offset: 0x35EA491 VA: 0x35EA390
	internal int get_CharsUsed() { }

	// RVA: 0x35EA3B0 Offset: 0x35EA4B1 VA: 0x35EA3B0
	internal int get_Count() { }
}

