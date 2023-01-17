// Namespace: UniRx.Async.Internal
public static class TaskTracker // TypeDefIndex: 5224
{
	// Fields
	[TupleElementNamesAttribute] // RVA: 0x29CF0 Offset: 0x29DF1 VA: 0x29CF0
	private static List<KeyValuePair<IAwaiter, ValueTuple<int, DateTime, string>>> listPool; // 0x0
	[TupleElementNamesAttribute] // RVA: 0x29DB0 Offset: 0x29EB1 VA: 0x29DB0
	private static readonly WeakDictionary<IAwaiter, ValueTuple<int, DateTime, string>> tracking; // 0x8
	private static bool dirty; // 0x10

	// Methods

	[ConditionalAttribute] // RVA: 0x2EA70 Offset: 0x2EB71 VA: 0x2EA70
	// RVA: 0x2E85E20 Offset: 0x2E85F21 VA: 0x2E85E20
	public static void TrackActiveTask(IAwaiter task, int skipFrame = 1) { }

	[ConditionalAttribute] // RVA: 0x2EAB0 Offset: 0x2EBB1 VA: 0x2EAB0
	// RVA: 0x2E85E30 Offset: 0x2E85F31 VA: 0x2E85E30
	public static void TrackActiveTask(IAwaiter task, string stackTrace) { }

	// RVA: 0x2E85E40 Offset: 0x2E85F41 VA: 0x2E85E40
	public static string CaptureStackTrace(int skipFrame) { }

	[ConditionalAttribute] // RVA: 0x2EAF0 Offset: 0x2EBF1 VA: 0x2EAF0
	// RVA: 0x2E85E50 Offset: 0x2E85F51 VA: 0x2E85E50
	public static void RemoveTracking(IAwaiter task) { }

	// RVA: 0x2E85E60 Offset: 0x2E85F61 VA: 0x2E85E60
	public static bool CheckAndResetDirty() { }

	// RVA: 0x2E85ED0 Offset: 0x2E85FD1 VA: 0x2E85ED0
	public static void ForEachActiveTask(Action<int, string, AwaiterStatus, DateTime, string> action) { }

	// RVA: 0x2E864D0 Offset: 0x2E865D1 VA: 0x2E864D0
	private static void .cctor() { }
}

