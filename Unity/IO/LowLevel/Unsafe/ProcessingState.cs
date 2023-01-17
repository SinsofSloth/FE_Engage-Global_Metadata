// Namespace: Unity.IO.LowLevel.Unsafe
[NativeHeaderAttribute] // RVA: 0x43B040 Offset: 0x43B141 VA: 0x43B040
public enum ProcessingState // TypeDefIndex: 3352
{
	// Fields
	public int value__; // 0x0
	public const ProcessingState Unknown = 0;
	public const ProcessingState InQueue = 1;
	public const ProcessingState Reading = 2;
	public const ProcessingState Completed = 3;
	public const ProcessingState Failed = 4;
	public const ProcessingState Canceled = 5;
}

