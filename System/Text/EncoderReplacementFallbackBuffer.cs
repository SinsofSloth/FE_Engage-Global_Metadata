// Namespace: System.Text
public sealed class EncoderReplacementFallbackBuffer : EncoderFallbackBuffer // TypeDefIndex: 456
{
	// Fields
	private string strDefault; // 0x30
	private int fallbackCount; // 0x38
	private int fallbackIndex; // 0x3C

	// Properties
	public override int Remaining { get; }

	// Methods

	// RVA: 0x372F7A0 Offset: 0x372F8A1 VA: 0x372F7A0
	public void .ctor(EncoderReplacementFallback fallback) { }

	// RVA: 0x372F8A0 Offset: 0x372F9A1 VA: 0x372F8A0 Slot: 4
	public override bool Fallback(char charUnknown, int index) { }

	// RVA: 0x372F9F0 Offset: 0x372FAF1 VA: 0x372F9F0 Slot: 5
	public override bool Fallback(char charUnknownHigh, char charUnknownLow, int index) { }

	// RVA: 0x372FCC0 Offset: 0x372FDC1 VA: 0x372FCC0 Slot: 6
	public override char GetNextChar() { }

	// RVA: 0x372FD00 Offset: 0x372FE01 VA: 0x372FD00 Slot: 7
	public override bool MovePrevious() { }

	// RVA: 0x372FD30 Offset: 0x372FE31 VA: 0x372FD30 Slot: 8
	public override int get_Remaining() { }

	// RVA: 0x372FD40 Offset: 0x372FE41 VA: 0x372FD40 Slot: 9
	public override void Reset() { }
}

