// Namespace: 
private sealed class Console.WindowsConsole.WindowsCancelHandler : MulticastDelegate // TypeDefIndex: 352
{
	// Methods

	// RVA: 0x1C0F260 Offset: 0x1C0F361 VA: 0x1C0F260
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x1C0F280 Offset: 0x1C0F381 VA: 0x1C0F280 Slot: 13
	public virtual bool Invoke(int keyCode) { }

	// RVA: 0x1C0F4B0 Offset: 0x1C0F5B1 VA: 0x1C0F4B0 Slot: 14
	public virtual IAsyncResult BeginInvoke(int keyCode, AsyncCallback callback, object object) { }

	// RVA: 0x1C0F540 Offset: 0x1C0F641 VA: 0x1C0F540 Slot: 15
	public virtual bool EndInvoke(IAsyncResult result) { }
}

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

// Namespace: 
private sealed class Console.InternalCancelHandler : MulticastDelegate // TypeDefIndex: 354
{
	// Methods

	// RVA: 0x35E65B0 Offset: 0x35E66B1 VA: 0x35E65B0
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x35E65D0 Offset: 0x35E66D1 VA: 0x35E65D0 Slot: 13
	public virtual void Invoke() { }

	// RVA: 0x35E67E0 Offset: 0x35E68E1 VA: 0x35E67E0 Slot: 14
	public virtual IAsyncResult BeginInvoke(AsyncCallback callback, object object) { }

	// RVA: 0x35E6810 Offset: 0x35E6911 VA: 0x35E6810 Slot: 15
	public virtual void EndInvoke(IAsyncResult result) { }
}

