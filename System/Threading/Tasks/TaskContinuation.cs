// Namespace: System.Threading.Tasks
internal abstract class TaskContinuation // TypeDefIndex: 852
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 4
	internal abstract void Run(Task completedTask, bool bCanInlineContinuationTask);

	// RVA: 0x3668D80 Offset: 0x3668E81 VA: 0x3668D80
	protected static void InlineIfPossibleOrElseQueue(Task task, bool needsProtection) { }

	// RVA: 0x3668FC0 Offset: 0x36690C1 VA: 0x3668FC0
	protected void .ctor() { }
}

