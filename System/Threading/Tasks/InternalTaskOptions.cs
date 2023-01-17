// Namespace: System.Threading.Tasks
[FlagsAttribute] // RVA: 0x473900 Offset: 0x473A01 VA: 0x473900
[Serializable]
internal enum InternalTaskOptions // TypeDefIndex: 840
{
	// Fields
	public int value__; // 0x0
	public const InternalTaskOptions None = 0;
	public const InternalTaskOptions InternalOptionsMask = 65280;
	public const InternalTaskOptions ChildReplica = 256;
	public const InternalTaskOptions ContinuationTask = 512;
	public const InternalTaskOptions PromiseTask = 1024;
	public const InternalTaskOptions SelfReplicating = 2048;
	public const InternalTaskOptions LazyCancellation = 4096;
	public const InternalTaskOptions QueuedByRuntime = 8192;
	public const InternalTaskOptions DoNotDispose = 16384;
}
