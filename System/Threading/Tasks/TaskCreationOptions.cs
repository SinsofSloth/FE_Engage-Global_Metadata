// Namespace: System.Threading.Tasks
[FlagsAttribute] // RVA: 0x4738F0 Offset: 0x4739F1 VA: 0x4738F0
[Serializable]
public enum TaskCreationOptions // TypeDefIndex: 839
{
	// Fields
	public int value__; // 0x0
	public const TaskCreationOptions None = 0;
	public const TaskCreationOptions PreferFairness = 1;
	public const TaskCreationOptions LongRunning = 2;
	public const TaskCreationOptions AttachedToParent = 4;
	public const TaskCreationOptions DenyChildAttach = 8;
	public const TaskCreationOptions HideScheduler = 16;
	public const TaskCreationOptions RunContinuationsAsynchronously = 64;
}

