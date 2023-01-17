// Namespace: System
internal static class ConsoleDriver // TypeDefIndex: 356
{
	// Fields
	internal static IConsoleDriver driver; // 0x0
	private static bool is_console; // 0x8
	private static bool called_isatty; // 0x9

	// Properties
	public static bool IsConsole { get; }

	// Methods

	// RVA: 0x33B0040 Offset: 0x33B0141 VA: 0x33B0040
	private static void .cctor() { }

	// RVA: 0x33B0120 Offset: 0x33B0221 VA: 0x33B0120
	private static IConsoleDriver CreateNullConsoleDriver() { }

	// RVA: 0x33B0180 Offset: 0x33B0281 VA: 0x33B0180
	private static IConsoleDriver CreateWindowsConsoleDriver() { }

	// RVA: 0x33B01E0 Offset: 0x33B02E1 VA: 0x33B01E0
	private static IConsoleDriver CreateTermInfoDriver(string term) { }

	// RVA: 0x33AF830 Offset: 0x33AF931 VA: 0x33AF830
	public static ConsoleKeyInfo ReadKey(bool intercept) { }

	// RVA: 0x33AED30 Offset: 0x33AEE31 VA: 0x33AED30
	public static bool get_IsConsole() { }

	// RVA: 0x33B0250 Offset: 0x33B0351 VA: 0x33B0250
	private static bool Isatty(IntPtr handle) { }

	// RVA: 0x33B0260 Offset: 0x33B0361 VA: 0x33B0260
	internal static int InternalKeyAvailable(int ms_timeout) { }

	// RVA: 0x33B0270 Offset: 0x33B0371 VA: 0x33B0270
	internal static bool TtySetup(string keypadXmit, string teardown, out byte[] control_characters, out int* address) { }

	// RVA: 0x33B0280 Offset: 0x33B0381 VA: 0x33B0280
	internal static bool SetEcho(bool wantEcho) { }
}

