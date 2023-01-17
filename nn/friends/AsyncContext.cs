// Namespace: nn.friends
public sealed class AsyncContext : IDisposable // TypeDefIndex: 14749
{
	// Fields
	internal IntPtr _context; // 0x10

	// Methods

	// RVA: 0x260EDC0 Offset: 0x260EEC1 VA: 0x260EDC0
	public void .ctor() { }

	// RVA: 0x260EE30 Offset: 0x260EF31 VA: 0x260EE30 Slot: 1
	protected override void Finalize() { }

	// RVA: 0x260EF40 Offset: 0x260F041 VA: 0x260EF40 Slot: 4
	public void Dispose() { }

	// RVA: 0x260EEE0 Offset: 0x260EFE1 VA: 0x260EEE0
	private void Dispose(bool disposing) { }

	// RVA: 0x260F000 Offset: 0x260F101 VA: 0x260F000
	public Result Cancel() { }

	// RVA: 0x260F040 Offset: 0x260F141 VA: 0x260F040
	public Result HasDone(ref bool outDone) { }

	// RVA: 0x260F080 Offset: 0x260F181 VA: 0x260F080
	public Result GetResult() { }

	// RVA: 0x260EE20 Offset: 0x260EF21 VA: 0x260EE20
	private static extern IntPtr Create() { }

	// RVA: 0x260EFF0 Offset: 0x260F0F1 VA: 0x260EFF0
	private static extern void Destroy(IntPtr context) { }

	// RVA: 0x260F020 Offset: 0x260F121 VA: 0x260F020
	private static extern Result Cancel(IntPtr context) { }

	// RVA: 0x260F060 Offset: 0x260F161 VA: 0x260F060
	private static extern Result HasDone(IntPtr context, ref bool outDone) { }

	// RVA: 0x260F0A0 Offset: 0x260F1A1 VA: 0x260F0A0
	private static extern Result GetResult(IntPtr context) { }
}

