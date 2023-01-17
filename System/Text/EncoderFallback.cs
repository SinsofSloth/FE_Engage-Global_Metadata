// Namespace: System.Text
[Serializable]
public abstract class EncoderFallback // TypeDefIndex: 452
{
	// Fields
	internal bool bIsMicrosoftBestFitFallback; // 0x10
	private static EncoderFallback replacementFallback; // 0x0
	private static EncoderFallback exceptionFallback; // 0x8
	private static object s_InternalSyncObject; // 0x10

	// Properties
	private static object InternalSyncObject { get; }
	public static EncoderFallback ReplacementFallback { get; }
	public static EncoderFallback ExceptionFallback { get; }
	public abstract int MaxCharCount { get; }

	// Methods

	// RVA: 0x372E380 Offset: 0x372E481 VA: 0x372E380
	private static object get_InternalSyncObject() { }

	// RVA: 0x372D3C0 Offset: 0x372D4C1 VA: 0x372D3C0
	public static EncoderFallback get_ReplacementFallback() { }

	// RVA: 0x372E4A0 Offset: 0x372E5A1 VA: 0x372E4A0
	public static EncoderFallback get_ExceptionFallback() { }

	// RVA: -1 Offset: -1 Slot: 4
	public abstract EncoderFallbackBuffer CreateFallbackBuffer();

	// RVA: -1 Offset: -1 Slot: 5
	public abstract int get_MaxCharCount();

	// RVA: 0x372DAA0 Offset: 0x372DBA1 VA: 0x372DAA0
	protected void .ctor() { }
}

