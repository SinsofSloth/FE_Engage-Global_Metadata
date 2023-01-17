// Namespace: System.Text
[Serializable]
public sealed class DecoderFallbackException : ArgumentException // TypeDefIndex: 440
{
	// Fields
	private byte[] bytesUnknown; // 0x90
	private int index; // 0x98

	// Methods

	// RVA: 0x371EBC0 Offset: 0x371ECC1 VA: 0x371EBC0
	public void .ctor() { }

	// RVA: 0x371EC40 Offset: 0x371ED41 VA: 0x371EC40
	internal void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x371E210 Offset: 0x371E311 VA: 0x371E210
	public void .ctor(string message, byte[] bytesUnknown, int index) { }
}

