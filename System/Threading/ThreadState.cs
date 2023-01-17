// Namespace: System.Threading
[ComVisibleAttribute] // RVA: 0x4735B0 Offset: 0x4736B1 VA: 0x4735B0
[FlagsAttribute] // RVA: 0x4735B0 Offset: 0x4736B1 VA: 0x4735B0
[Serializable]
public enum ThreadState // TypeDefIndex: 797
{
	// Fields
	public int value__; // 0x0
	public const ThreadState Running = 0;
	public const ThreadState StopRequested = 1;
	public const ThreadState SuspendRequested = 2;
	public const ThreadState Background = 4;
	public const ThreadState Unstarted = 8;
	public const ThreadState Stopped = 16;
	public const ThreadState WaitSleepJoin = 32;
	public const ThreadState Suspended = 64;
	public const ThreadState AbortRequested = 128;
	public const ThreadState Aborted = 256;
}
