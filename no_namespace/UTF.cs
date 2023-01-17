// Namespace: 
[Serializable]
internal class UTF32Encoding.UTF32Decoder : DecoderNLS // TypeDefIndex: 469
{
	// Fields
	internal int iChar; // 0x30
	internal int readByteCount; // 0x34

	// Properties
	internal override bool HasState { get; }

	// Methods

	// RVA: 0x1C0D240 Offset: 0x1C0D341 VA: 0x1C0D240
	public void .ctor(UTF32Encoding encoding) { }

	// RVA: 0x1C0D250 Offset: 0x1C0D351 VA: 0x1C0D250 Slot: 4
	public override void Reset() { }

	// RVA: 0x1C0D270 Offset: 0x1C0D371 VA: 0x1C0D270 Slot: 14
	internal override bool get_HasState() { }
}

// Namespace: 
[Serializable]
private class UTF7Encoding.Decoder : DecoderNLS, ISerializable // TypeDefIndex: 471
{
	// Fields
	internal int bits; // 0x30
	internal int bitCount; // 0x34
	internal bool firstByte; // 0x38

	// Properties
	internal override bool HasState { get; }

	// Methods

	// RVA: 0x1C0D280 Offset: 0x1C0D381 VA: 0x1C0D280
	public void .ctor(UTF7Encoding encoding) { }

	// RVA: 0x1C0D290 Offset: 0x1C0D391 VA: 0x1C0D290
	internal void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x1C0D570 Offset: 0x1C0D671 VA: 0x1C0D570 Slot: 13
	private void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x1C0D6A0 Offset: 0x1C0D7A1 VA: 0x1C0D6A0 Slot: 4
	public override void Reset() { }

	// RVA: 0x1C0D6D0 Offset: 0x1C0D7D1 VA: 0x1C0D6D0 Slot: 14
	internal override bool get_HasState() { }
}

// Namespace: 
[Serializable]
private class UTF7Encoding.Encoder : EncoderNLS, ISerializable // TypeDefIndex: 472
{
	// Fields
	internal int bits; // 0x38
	internal int bitCount; // 0x3C

	// Methods

	// RVA: 0x1C0D900 Offset: 0x1C0DA01 VA: 0x1C0D900
	public void .ctor(UTF7Encoding encoding) { }

	// RVA: 0x1C0D910 Offset: 0x1C0DA11 VA: 0x1C0D910
	internal void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x1C0DB70 Offset: 0x1C0DC71 VA: 0x1C0DB70 Slot: 9
	private void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x1C0DC70 Offset: 0x1C0DD71 VA: 0x1C0DC70 Slot: 4
	public override void Reset() { }
}

// Namespace: 
[Serializable]
internal sealed class UTF7Encoding.DecoderUTF7Fallback : DecoderFallback // TypeDefIndex: 473
{
	// Properties
	public override int MaxCharCount { get; }

	// Methods

	// RVA: 0x1C0D6E0 Offset: 0x1C0D7E1 VA: 0x1C0D6E0
	public void .ctor() { }

	// RVA: 0x1C0D6F0 Offset: 0x1C0D7F1 VA: 0x1C0D6F0 Slot: 4
	public override DecoderFallbackBuffer CreateFallbackBuffer() { }

	// RVA: 0x1C0D760 Offset: 0x1C0D861 VA: 0x1C0D760 Slot: 5
	public override int get_MaxCharCount() { }

	// RVA: 0x1C0D770 Offset: 0x1C0D871 VA: 0x1C0D770 Slot: 0
	public override bool Equals(object value) { }

	// RVA: 0x1C0D7E0 Offset: 0x1C0D8E1 VA: 0x1C0D7E0 Slot: 2
	public override int GetHashCode() { }
}

// Namespace: 
internal sealed class UTF7Encoding.DecoderUTF7FallbackBuffer : DecoderFallbackBuffer // TypeDefIndex: 474
{
	// Fields
	private char cFallback; // 0x20
	private int iCount; // 0x24
	private int iSize; // 0x28

	// Properties
	public override int Remaining { get; }

	// Methods

	// RVA: 0x1C0D750 Offset: 0x1C0D851 VA: 0x1C0D750
	public void .ctor(UTF7Encoding.DecoderUTF7Fallback fallback) { }

	// RVA: 0x1C0D7F0 Offset: 0x1C0D8F1 VA: 0x1C0D7F0 Slot: 4
	public override bool Fallback(byte[] bytesUnknown, int index) { }

	// RVA: 0x1C0D840 Offset: 0x1C0D941 VA: 0x1C0D840 Slot: 5
	public override char GetNextChar() { }

	// RVA: 0x1C0D860 Offset: 0x1C0D961 VA: 0x1C0D860 Slot: 6
	public override int get_Remaining() { }

	// RVA: 0x1C0D870 Offset: 0x1C0D971 VA: 0x1C0D870 Slot: 7
	public override void Reset() { }

	// RVA: 0x1C0D880 Offset: 0x1C0D981 VA: 0x1C0D880 Slot: 9
	internal override int InternalFallback(byte[] bytes, byte* pBytes) { }
}

// Namespace: 
[Serializable]
internal class UTF8Encoding.UTF8Encoder : EncoderNLS, ISerializable // TypeDefIndex: 476
{
	// Fields
	internal int surrogateChar; // 0x38

	// Methods

	// RVA: 0x1C0E1F0 Offset: 0x1C0E2F1 VA: 0x1C0E1F0
	public void .ctor(UTF8Encoding encoding) { }

	// RVA: 0x1C0E200 Offset: 0x1C0E301 VA: 0x1C0E200
	internal void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x1C0E560 Offset: 0x1C0E661 VA: 0x1C0E560 Slot: 9
	private void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x1C0E6C0 Offset: 0x1C0E7C1 VA: 0x1C0E6C0 Slot: 4
	public override void Reset() { }
}

// Namespace: 
[Serializable]
internal class UTF8Encoding.UTF8Decoder : DecoderNLS, ISerializable // TypeDefIndex: 477
{
	// Fields
	internal int bits; // 0x30

	// Properties
	internal override bool HasState { get; }

	// Methods

	// RVA: 0x1C0DC90 Offset: 0x1C0DD91 VA: 0x1C0DC90
	public void .ctor(UTF8Encoding encoding) { }

	// RVA: 0x1C0DCA0 Offset: 0x1C0DDA1 VA: 0x1C0DCA0
	internal void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x1C0E010 Offset: 0x1C0E111 VA: 0x1C0E010 Slot: 13
	private void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x1C0E1C0 Offset: 0x1C0E2C1 VA: 0x1C0E1C0 Slot: 4
	public override void Reset() { }

	// RVA: 0x1C0E1E0 Offset: 0x1C0E2E1 VA: 0x1C0E1E0 Slot: 14
	internal override bool get_HasState() { }
}

