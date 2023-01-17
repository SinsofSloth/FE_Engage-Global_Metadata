// Namespace: 
private enum ExecutionContext.Flags // TypeDefIndex: 760
{
	// Fields
	public int value__; // 0x0
	public const ExecutionContext.Flags None = 0;
	public const ExecutionContext.Flags IsNewCapture = 1;
	public const ExecutionContext.Flags IsFlowSuppressed = 2;
	public const ExecutionContext.Flags IsPreAllocatedDefault = 4;
}

// Namespace: 
[FlagsAttribute] // RVA: 0x473340 Offset: 0x473441 VA: 0x473340
internal enum ExecutionContext.CaptureOptions // TypeDefIndex: 762
{
	// Fields
	public int value__; // 0x0
	public const ExecutionContext.CaptureOptions None = 0;
	public const ExecutionContext.CaptureOptions IgnoreSyncCtx = 1;
	public const ExecutionContext.CaptureOptions OptimizeDefaultCase = 2;
}

