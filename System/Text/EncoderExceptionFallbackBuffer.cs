// Namespace: System.Text
public sealed class EncoderExceptionFallbackBuffer : EncoderFallbackBuffer // TypeDefIndex: 450
{
	// Properties
	public override int Remaining { get; }

	// Methods

	// RVA: 0x372DB10 Offset: 0x372DC11 VA: 0x372DB10
	public void .ctor() { }

	// RVA: 0x372DBC0 Offset: 0x372DCC1 VA: 0x372DBC0 Slot: 4
	public override bool Fallback(char charUnknown, int index) { }

	// RVA: 0x372DD00 Offset: 0x372DE01 VA: 0x372DD00 Slot: 5
	public override bool Fallback(char charUnknownHigh, char charUnknownLow, int index) { }

	// RVA: 0x372E350 Offset: 0x372E451 VA: 0x372E350 Slot: 6
	public override char GetNextChar() { }

	// RVA: 0x372E360 Offset: 0x372E461 VA: 0x372E360 Slot: 7
	public override bool MovePrevious() { }

	// RVA: 0x372E370 Offset: 0x372E471 VA: 0x372E370 Slot: 8
	public override int get_Remaining() { }
}

