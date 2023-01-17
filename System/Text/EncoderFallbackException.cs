// Namespace: System.Text
[Serializable]
public sealed class EncoderFallbackException : ArgumentException // TypeDefIndex: 451
{
	// Fields
	private char charUnknown; // 0x90
	private char charUnknownHigh; // 0x92
	private char charUnknownLow; // 0x94
	private int index; // 0x98

	// Methods

	// RVA: 0x372EA50 Offset: 0x372EB51 VA: 0x372EA50
	public void .ctor() { }

	// RVA: 0x372EAD0 Offset: 0x372EBD1 VA: 0x372EAD0
	internal void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x372DCC0 Offset: 0x372DDC1 VA: 0x372DCC0
	internal void .ctor(string message, char charUnknown, int index) { }

	// RVA: 0x372E0B0 Offset: 0x372E1B1 VA: 0x372E0B0
	internal void .ctor(string message, char charUnknownHigh, char charUnknownLow, int index) { }
}

