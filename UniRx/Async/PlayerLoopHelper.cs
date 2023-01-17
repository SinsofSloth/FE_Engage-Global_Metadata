// Namespace: UniRx.Async
public static class PlayerLoopHelper // TypeDefIndex: 4938
{
	// Fields
	private static int mainThreadId; // 0x0
	private static SynchronizationContext unitySynchronizationContetext; // 0x8
	private static ContinuationQueue[] yielders; // 0x10
	private static PlayerLoopRunner[] runners; // 0x18

	// Properties
	public static SynchronizationContext UnitySynchronizationContext { get; }
	public static int MainThreadId { get; }

	// Methods

	// RVA: 0x2E82EC0 Offset: 0x2E82FC1 VA: 0x2E82EC0
	public static SynchronizationContext get_UnitySynchronizationContext() { }

	// RVA: 0x2E82F10 Offset: 0x2E83011 VA: 0x2E82F10
	public static int get_MainThreadId() { }

	// RVA: 0x2E82F60 Offset: 0x2E83061 VA: 0x2E82F60
	private static PlayerLoopSystem[] InsertRunner(PlayerLoopSystem loopSystem, Type loopRunnerYieldType, ContinuationQueue cq, Type loopRunnerType, PlayerLoopRunner runner) { }

	[RuntimeInitializeOnLoadMethodAttribute] // RVA: 0x2A040 Offset: 0x2A141 VA: 0x2A040
	// RVA: 0x2E831C0 Offset: 0x2E832C1 VA: 0x2E831C0
	private static void Init() { }

	// RVA: 0x2E832A0 Offset: 0x2E833A1 VA: 0x2E832A0
	public static void Initialize(ref PlayerLoopSystem playerLoop) { }

	// RVA: 0x2E727A0 Offset: 0x2E728A1 VA: 0x2E727A0
	public static void AddAction(PlayerLoopTiming timing, IPlayerLoopItem action) { }

	// RVA: 0x2E845F0 Offset: 0x2E846F1 VA: 0x2E845F0
	public static void AddContinuation(PlayerLoopTiming timing, Action continuation) { }
}

