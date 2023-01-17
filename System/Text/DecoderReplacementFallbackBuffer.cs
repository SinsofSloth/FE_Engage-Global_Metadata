// Namespace: System.Text
public sealed class DecoderReplacementFallbackBuffer : DecoderFallbackBuffer // TypeDefIndex: 445
{
	// Fields
	private string strDefault; // 0x20
	private int fallbackCount; // 0x28
	private int fallbackIndex; // 0x2C

	// Properties
	public override int Remaining { get; }

	// Methods

	// RVA: 0x371FDC0 Offset: 0x371FEC1 VA: 0x371FDC0
	public void .ctor(DecoderReplacementFallback fallback) { }

	// RVA: 0x371FEB0 Offset: 0x371FFB1 VA: 0x371FEB0 Slot: 4
	public override bool Fallback(byte[] bytesUnknown, int index) { }

	// RVA: 0x371FF00 Offset: 0x3720001 VA: 0x371FF00 Slot: 5
	public override char GetNextChar() { }

	// RVA: 0x371FF40 Offset: 0x3720041 VA: 0x371FF40 Slot: 6
	public override int get_Remaining() { }

	// RVA: 0x371FF50 Offset: 0x3720051 VA: 0x371FF50 Slot: 7
	public override void Reset() { }

	// RVA: 0x371FF60 Offset: 0x3720061 VA: 0x371FF60 Slot: 9
	internal override int InternalFallback(byte[] bytes, byte* pBytes) { }
}

