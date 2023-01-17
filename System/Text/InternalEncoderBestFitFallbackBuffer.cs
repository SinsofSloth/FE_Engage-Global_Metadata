// Namespace: System.Text
internal sealed class InternalEncoderBestFitFallbackBuffer : EncoderFallbackBuffer // TypeDefIndex: 448
{
	// Fields
	private char cBestFit; // 0x30
	private InternalEncoderBestFitFallback oFallback; // 0x38
	private int iCount; // 0x40
	private int iSize; // 0x44
	private static object s_InternalSyncObject; // 0x0

	// Properties
	private static object InternalSyncObject { get; }
	public override int Remaining { get; }

	// Methods

	// RVA: 0x34121F0 Offset: 0x34122F1 VA: 0x34121F0
	private static object get_InternalSyncObject() { }

	// RVA: 0x3411F40 Offset: 0x3412041 VA: 0x3411F40
	public void .ctor(InternalEncoderBestFitFallback fallback) { }

	// RVA: 0x34122B0 Offset: 0x34123B1 VA: 0x34122B0 Slot: 4
	public override bool Fallback(char charUnknown, int index) { }

	// RVA: 0x34123D0 Offset: 0x34124D1 VA: 0x34123D0 Slot: 5
	public override bool Fallback(char charUnknownHigh, char charUnknownLow, int index) { }

	// RVA: 0x3412660 Offset: 0x3412761 VA: 0x3412660 Slot: 6
	public override char GetNextChar() { }

	// RVA: 0x34126A0 Offset: 0x34127A1 VA: 0x34126A0 Slot: 7
	public override bool MovePrevious() { }

	// RVA: 0x34126D0 Offset: 0x34127D1 VA: 0x34126D0 Slot: 8
	public override int get_Remaining() { }

	// RVA: 0x34126E0 Offset: 0x34127E1 VA: 0x34126E0 Slot: 9
	public override void Reset() { }

	// RVA: 0x34122F0 Offset: 0x34123F1 VA: 0x34122F0
	private char TryBestFit(char cUnknown) { }
}

