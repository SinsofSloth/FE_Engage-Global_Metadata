// Namespace: System.Text
internal sealed class InternalDecoderBestFitFallbackBuffer : DecoderFallbackBuffer // TypeDefIndex: 437
{
	// Fields
	internal char cBestFit; // 0x20
	internal int iCount; // 0x24
	internal int iSize; // 0x28
	private InternalDecoderBestFitFallback oFallback; // 0x30
	private static object s_InternalSyncObject; // 0x0

	// Properties
	private static object InternalSyncObject { get; }
	public override int Remaining { get; }

	// Methods

	// RVA: 0x3411BC0 Offset: 0x3411CC1 VA: 0x3411BC0
	private static object get_InternalSyncObject() { }

	// RVA: 0x3411930 Offset: 0x3411A31 VA: 0x3411930
	public void .ctor(InternalDecoderBestFitFallback fallback) { }

	// RVA: 0x3411C80 Offset: 0x3411D81 VA: 0x3411C80 Slot: 4
	public override bool Fallback(byte[] bytesUnknown, int index) { }

	// RVA: 0x3411E20 Offset: 0x3411F21 VA: 0x3411E20 Slot: 5
	public override char GetNextChar() { }

	// RVA: 0x3411E60 Offset: 0x3411F61 VA: 0x3411E60 Slot: 6
	public override int get_Remaining() { }

	// RVA: 0x3411E70 Offset: 0x3411F71 VA: 0x3411E70 Slot: 7
	public override void Reset() { }

	// RVA: 0x3411E80 Offset: 0x3411F81 VA: 0x3411E80 Slot: 9
	internal override int InternalFallback(byte[] bytes, byte* pBytes) { }

	// RVA: 0x3411CD0 Offset: 0x3411DD1 VA: 0x3411CD0
	private char TryBestFit(byte[] bytesCheck) { }
}

