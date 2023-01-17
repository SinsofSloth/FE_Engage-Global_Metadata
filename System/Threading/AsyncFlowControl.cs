// Namespace: System.Threading
public struct AsyncFlowControl : IDisposable // TypeDefIndex: 759
{
	// Fields
	private bool useEC; // 0x0
	private ExecutionContext _ec; // 0x8
	private Thread _thread; // 0x10

	// Methods

	// RVA: 0x35696B0 Offset: 0x35697B1 VA: 0x35696B0
	internal void Setup() { }

	// RVA: 0x3569720 Offset: 0x3569821 VA: 0x3569720 Slot: 4
	public void Dispose() { }

	// RVA: 0x3569730 Offset: 0x3569831 VA: 0x3569730
	public void Undo() { }

	// RVA: 0x3569850 Offset: 0x3569951 VA: 0x3569850 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x3569910 Offset: 0x3569A11 VA: 0x3569910 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x35699D0 Offset: 0x3569AD1 VA: 0x35699D0
	public bool Equals(AsyncFlowControl obj) { }
}

