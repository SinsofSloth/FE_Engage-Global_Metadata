// Namespace: System
internal class WindowsConsoleDriver : IConsoleDriver // TypeDefIndex: 430
{
	// Fields
	private IntPtr inputHandle; // 0x10
	private IntPtr outputHandle; // 0x18
	private short defaultAttribute; // 0x20

	// Methods

	// RVA: 0x34D2F60 Offset: 0x34D3061 VA: 0x34D2F60
	public void .ctor() { }

	// RVA: 0x34D3200 Offset: 0x34D3301 VA: 0x34D3200 Slot: 4
	public ConsoleKeyInfo ReadKey(bool intercept) { }

	// RVA: 0x34D3500 Offset: 0x34D3601 VA: 0x34D3500
	private static bool IsModifierKey(short virtualKeyCode) { }

	// RVA: 0x34D30D0 Offset: 0x34D31D1 VA: 0x34D30D0
	private static extern IntPtr GetStdHandle(Handles handle) { }

	// RVA: 0x34D3160 Offset: 0x34D3261 VA: 0x34D3160
	private static extern bool GetConsoleScreenBufferInfo(IntPtr handle, out ConsoleScreenBufferInfo info) { }

	// RVA: 0x34D3410 Offset: 0x34D3511 VA: 0x34D3410
	private static extern bool ReadConsoleInput(IntPtr handle, out InputRecord record, int length, out int nread) { }
}

