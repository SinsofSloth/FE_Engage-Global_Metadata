// Namespace: System.Text
[Serializable]
public abstract class DecoderFallback // TypeDefIndex: 441
{
	// Fields
	internal bool bIsMicrosoftBestFitFallback; // 0x10
	private static DecoderFallback replacementFallback; // 0x0
	private static DecoderFallback exceptionFallback; // 0x8
	private static object s_InternalSyncObject; // 0x10

	// Properties
	private static object InternalSyncObject { get; }
	public static DecoderFallback ReplacementFallback { get; }
	public static DecoderFallback ExceptionFallback { get; }
	public abstract int MaxCharCount { get; }

	// Methods

	// RVA: 0x371E270 Offset: 0x371E371 VA: 0x371E270
	private static object get_InternalSyncObject() { }

	// RVA: 0x371D210 Offset: 0x371D311 VA: 0x371D210
	public static DecoderFallback get_ReplacementFallback() { }

	// RVA: 0x371E390 Offset: 0x371E491 VA: 0x371E390
	public static DecoderFallback get_ExceptionFallback() { }

	// RVA: -1 Offset: -1 Slot: 4
	public abstract DecoderFallbackBuffer CreateFallbackBuffer();

	// RVA: -1 Offset: -1 Slot: 5
	public abstract int get_MaxCharCount();

	// RVA: 0x371DE80 Offset: 0x371DF81 VA: 0x371DE80
	protected void .ctor() { }
}

