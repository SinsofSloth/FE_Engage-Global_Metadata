// Namespace: System.Security.Principal
[ComVisibleAttribute] // RVA: 0x473BB0 Offset: 0x473CB1 VA: 0x473BB0
public class WindowsImpersonationContext : IDisposable // TypeDefIndex: 896
{
	// Fields
	private IntPtr _token; // 0x10
	private bool undo; // 0x18

	// Methods

	// RVA: 0x34D38F0 Offset: 0x34D39F1 VA: 0x34D38F0
	internal void .ctor(IntPtr token) { }

	[ComVisibleAttribute] // RVA: 0x47CE40 Offset: 0x47CF41 VA: 0x47CE40
	// RVA: 0x34D3F70 Offset: 0x34D4071 VA: 0x34D3F70 Slot: 4
	public void Dispose() { }

	// RVA: 0x34D3F80 Offset: 0x34D4081 VA: 0x34D3F80
	public void Undo() { }

	// RVA: 0x34D4060 Offset: 0x34D4161 VA: 0x34D4060
	private static bool CloseToken(IntPtr token) { }

	// RVA: 0x34D3F50 Offset: 0x34D4051 VA: 0x34D3F50
	private static IntPtr DuplicateToken(IntPtr token) { }

	// RVA: 0x34D3F60 Offset: 0x34D4061 VA: 0x34D3F60
	private static bool SetCurrentToken(IntPtr token) { }

	// RVA: 0x34D4050 Offset: 0x34D4151 VA: 0x34D4050
	private static bool RevertToSelf() { }
}

