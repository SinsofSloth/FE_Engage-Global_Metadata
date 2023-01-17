// Namespace: System
public static class Console // TypeDefIndex: 355
{
	// Fields
	internal static TextWriter stdout; // 0x0
	private static TextWriter stderr; // 0x8
	private static TextReader stdin; // 0x10
	private static Encoding inputEncoding; // 0x18
	private static Encoding outputEncoding; // 0x20
	private static ConsoleCancelEventHandler cancel_event; // 0x28
	private static readonly Console.InternalCancelHandler cancel_handler; // 0x30

	// Properties
	public static TextWriter Error { get; }
	public static TextWriter Out { get; }
	public static Encoding InputEncoding { get; }
	public static Encoding OutputEncoding { get; }

	// Methods

	// RVA: 0x33AE680 Offset: 0x33AE781 VA: 0x33AE680
	private static void .cctor() { }

	// RVA: 0x33AE940 Offset: 0x33AEA41 VA: 0x33AE940
	private static void SetupStreams(Encoding inputEncoding, Encoding outputEncoding) { }

	// RVA: 0x33AF0E0 Offset: 0x33AF1E1 VA: 0x33AF0E0
	public static TextWriter get_Error() { }

	// RVA: 0x33AF150 Offset: 0x33AF251 VA: 0x33AF150
	public static TextWriter get_Out() { }

	// RVA: 0x33AF1C0 Offset: 0x33AF2C1 VA: 0x33AF1C0
	private static Stream Open(IntPtr handle, FileAccess access, int bufferSize) { }

	// RVA: 0x33AF310 Offset: 0x33AF411 VA: 0x33AF310
	public static Stream OpenStandardError() { }

	// RVA: 0x33AF030 Offset: 0x33AF131 VA: 0x33AF030
	public static Stream OpenStandardError(int bufferSize) { }

	// RVA: 0x33AF380 Offset: 0x33AF481 VA: 0x33AF380
	public static Stream OpenStandardInput() { }

	// RVA: 0x33AEED0 Offset: 0x33AEFD1 VA: 0x33AEED0
	public static Stream OpenStandardInput(int bufferSize) { }

	// RVA: 0x33AF3F0 Offset: 0x33AF4F1 VA: 0x33AF3F0
	public static Stream OpenStandardOutput() { }

	// RVA: 0x33AEF80 Offset: 0x33AF081 VA: 0x33AEF80
	public static Stream OpenStandardOutput(int bufferSize) { }

	// RVA: 0x33AF460 Offset: 0x33AF561 VA: 0x33AF460
	public static void SetOut(TextWriter newOut) { }

	// RVA: 0x33AF520 Offset: 0x33AF621 VA: 0x33AF520
	public static void WriteLine(string value) { }

	// RVA: 0x33AF5A0 Offset: 0x33AF6A1 VA: 0x33AF5A0
	public static void WriteLine(string format, object arg0) { }

	// RVA: 0x33AF630 Offset: 0x33AF731 VA: 0x33AF630
	public static Encoding get_InputEncoding() { }

	// RVA: 0x33AF6A0 Offset: 0x33AF7A1 VA: 0x33AF6A0
	public static Encoding get_OutputEncoding() { }

	// RVA: 0x33AF710 Offset: 0x33AF811 VA: 0x33AF710
	public static ConsoleKeyInfo ReadKey() { }

	// RVA: 0x33AF7C0 Offset: 0x33AF8C1 VA: 0x33AF7C0
	public static ConsoleKeyInfo ReadKey(bool intercept) { }

	// RVA: 0x33AF920 Offset: 0x33AFA21 VA: 0x33AF920
	internal static void DoConsoleCancelEvent() { }
}

