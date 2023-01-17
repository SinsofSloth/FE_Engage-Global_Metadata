// Namespace: System.Threading
internal struct ExecutionContextSwitcher // TypeDefIndex: 758
{
	// Fields
	internal ExecutionContext.Reader outerEC; // 0x0
	internal bool outerECBelongsToScope; // 0x8
	internal object hecsw; // 0x10
	internal Thread thread; // 0x18

	// Methods

	[ReliabilityContractAttribute] // RVA: 0x47C600 Offset: 0x47C701 VA: 0x47C600
	[HandleProcessCorruptedStateExceptionsAttribute] // RVA: 0x47C600 Offset: 0x47C701 VA: 0x47C600
	// RVA: 0x3B648B0 Offset: 0x3B649B1 VA: 0x3B648B0
	internal bool UndoNoThrow() { }

	[ReliabilityContractAttribute] // RVA: 0x47C640 Offset: 0x47C741 VA: 0x47C640
	// RVA: 0x3B64720 Offset: 0x3B64821 VA: 0x3B64720
	internal void Undo() { }
}

