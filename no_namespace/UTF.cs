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

