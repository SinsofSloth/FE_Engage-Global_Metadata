// Namespace: System.Threading
internal class ThreadHelper // TypeDefIndex: 778
{
	// Fields
	private Delegate _start; // 0x10
	private object _startArg; // 0x18
	private ExecutionContext _executionContext; // 0x20
	internal static ContextCallback _ccb; // 0x0

	// Methods

	// RVA: 0x1B147B0 Offset: 0x1B148B1 VA: 0x1B147B0
	private static void .cctor() { }

	// RVA: 0x1B13C00 Offset: 0x1B13D01 VA: 0x1B13C00
	internal void .ctor(Delegate start) { }

	// RVA: 0x1B14850 Offset: 0x1B14951 VA: 0x1B14850
	internal void SetExecutionContextHelper(ExecutionContext ec) { }

	// RVA: 0x1B14860 Offset: 0x1B14961 VA: 0x1B14860
	private static void ThreadStart_Context(object state) { }

	// RVA: 0x1B14B50 Offset: 0x1B14C51 VA: 0x1B14B50
	internal void ThreadStart(object obj) { }

	// RVA: 0x1B14C70 Offset: 0x1B14D71 VA: 0x1B14C70
	internal void ThreadStart() { }
}

