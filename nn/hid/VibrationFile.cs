// Namespace: nn.hid
public static class VibrationFile // TypeDefIndex: 14661
{
	// Properties
	public static ErrorRange ResultInvalid { get; }

	// Methods

	// RVA: 0x26C2470 Offset: 0x26C2571 VA: 0x26C2470
	public static ErrorRange get_ResultInvalid() { }

	// RVA: 0x26C2440 Offset: 0x26C2541 VA: 0x26C2440
	public static extern Result Parse(ref VibrationFileInfo pOutInfo, ref VibrationFileParserContext pOutContext, byte[] address, long fileSize) { }

	// RVA: 0x26C24B0 Offset: 0x26C25B1 VA: 0x26C24B0
	public static extern void RetrieveValue(ref VibrationValue pOutValue, int position, ref VibrationFileParserContext pContext) { }

	// RVA: 0x26C24C0 Offset: 0x26C25C1 VA: 0x26C24C0
	private static extern void Generate(ref long pOutSize, byte[] outBuffer, long bufferSize, VibrationValueArrayInfo info, VibrationValue[] pValues) { }

	// RVA: 0x26C2510 Offset: 0x26C2611 VA: 0x26C2510
	public static void Generate(ref long pOutSize, byte[] outBuffer, VibrationValueArrayInfo info, VibrationValue[] pValues) { }

	// RVA: 0x26C2570 Offset: 0x26C2671 VA: 0x26C2570
	public static extern long CalculateSize(VibrationValueArrayInfo info) { }
}

