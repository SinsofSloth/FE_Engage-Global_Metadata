// Namespace: 
private class Console.WindowsConsole // TypeDefIndex: 353
{
	// Fields
	public static bool ctrlHandlerAdded; // 0x0
	private static Console.WindowsConsole.WindowsCancelHandler cancelHandler; // 0x8

	// Methods

	// RVA: 0x35E6820 Offset: 0x35E6921 VA: 0x35E6820
	private static extern int GetConsoleCP() { }

	// RVA: 0x35E6890 Offset: 0x35E6991 VA: 0x35E6890
	private static extern int GetConsoleOutputCP() { }

	// RVA: 0x35E6910 Offset: 0x35E6A11 VA: 0x35E6910
	private static bool DoWindowsConsoleCancelEvent(int keyCode) { }

	// RVA: 0x35E6980 Offset: 0x35E6A81 VA: 0x35E6980
	public static int GetInputCodePage() { }

	// RVA: 0x35E6A40 Offset: 0x35E6B41 VA: 0x35E6A40
	public static int GetOutputCodePage() { }

	// RVA: 0x35E6B10 Offset: 0x35E6C11 VA: 0x35E6B10
	private static void .cctor() { }
}

