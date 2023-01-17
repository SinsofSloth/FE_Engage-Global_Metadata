// Namespace: 
public class AkLogger // TypeDefIndex: 7949
{
	// Fields
	private static AkLogger ms_Instance; // 0x0
	private AkLogger.ErrorLoggerInteropDelegate errorLoggerDelegate; // 0x10

	// Properties
	public static AkLogger Instance { get; }

	// Methods

	// RVA: 0x317AC10 Offset: 0x317AD11 VA: 0x317AC10
	private void .ctor() { }

	// RVA: 0x317AD70 Offset: 0x317AE71 VA: 0x317AD70
	public static AkLogger get_Instance() { }

	// RVA: 0x317ADE0 Offset: 0x317AEE1 VA: 0x317ADE0 Slot: 1
	protected override void Finalize() { }

	// RVA: 0x317AF30 Offset: 0x317B031 VA: 0x317AF30
	public void Init() { }

	[MonoPInvokeCallbackAttribute] // RVA: 0x2A7030 Offset: 0x2A7131 VA: 0x2A7030
	// RVA: 0x317AB20 Offset: 0x317AC21 VA: 0x317AB20
	public static void WwiseInternalLogError(string message) { }

	// RVA: 0x317AF40 Offset: 0x317B041 VA: 0x317AF40
	public static void Message(string message) { }

	// RVA: 0x317B030 Offset: 0x317B131 VA: 0x317B030
	public static void Warning(string message) { }

	// RVA: 0x317B120 Offset: 0x317B221 VA: 0x317B120
	public static void Error(string message) { }

	// RVA: 0x317B210 Offset: 0x317B311 VA: 0x317B210
	private static void .cctor() { }
}

