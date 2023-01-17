// Namespace: nn.account
public sealed class AsyncContext : IDisposable // TypeDefIndex: 14781
{
	// Fields
	internal IntPtr _context; // 0x10

	// Methods

	// RVA: 0x260EAC0 Offset: 0x260EBC1 VA: 0x260EAC0
	public void .ctor() { }

	// RVA: 0x260EB30 Offset: 0x260EC31 VA: 0x260EB30 Slot: 1
	protected override void Finalize() { }

	// RVA: 0x260EC40 Offset: 0x260ED41 VA: 0x260EC40 Slot: 4
	public void Dispose() { }

	// RVA: 0x260EBE0 Offset: 0x260ECE1 VA: 0x260EBE0
	private void Dispose(bool disposing) { }

	// RVA: 0x260ED00 Offset: 0x260EE01 VA: 0x260ED00
	public Result Cancel() { }

	// RVA: 0x260ED40 Offset: 0x260EE41 VA: 0x260ED40
	public Result HasDone(ref bool pOut) { }

	// RVA: 0x260ED80 Offset: 0x260EE81 VA: 0x260ED80
	public Result GetResult() { }

	// RVA: 0x260EB20 Offset: 0x260EC21 VA: 0x260EB20
	private static extern IntPtr Create() { }

	// RVA: 0x260ECF0 Offset: 0x260EDF1 VA: 0x260ECF0
	private static extern void Destroy(IntPtr context) { }

	// RVA: 0x260ED20 Offset: 0x260EE21 VA: 0x260ED20
	private static extern Result Cancel(IntPtr context) { }

	// RVA: 0x260ED60 Offset: 0x260EE61 VA: 0x260ED60
	private static extern Result HasDone(IntPtr context, ref bool pOut) { }

	// RVA: 0x260EDA0 Offset: 0x260EEA1 VA: 0x260EDA0
	private static extern Result GetResult(IntPtr context) { }
}

