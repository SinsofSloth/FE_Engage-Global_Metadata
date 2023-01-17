// Namespace: System.Runtime.CompilerServices
public struct TaskAwaiter : ICriticalNotifyCompletion, INotifyCompletion // TypeDefIndex: 1255
{
	// Fields
	private readonly Task m_task; // 0x0

	// Properties
	public bool IsCompleted { get; }

	// Methods

	// RVA: 0x3668900 Offset: 0x3668A01 VA: 0x3668900
	internal void .ctor(Task task) { }

	// RVA: 0x3668910 Offset: 0x3668A11 VA: 0x3668910
	public bool get_IsCompleted() { }

	// RVA: 0x3668990 Offset: 0x3668A91 VA: 0x3668990 Slot: 5
	public void OnCompleted(Action continuation) { }

	// RVA: 0x3668A20 Offset: 0x3668B21 VA: 0x3668A20 Slot: 4
	public void UnsafeOnCompleted(Action continuation) { }

	// RVA: 0x3668A30 Offset: 0x3668B31 VA: 0x3668A30
	public void GetResult() { }

	// RVA: 0x3668A80 Offset: 0x3668B81 VA: 0x3668A80
	internal static void ValidateEnd(Task task) { }

	// RVA: 0x3668AD0 Offset: 0x3668BD1 VA: 0x3668AD0
	private static void HandleNonSuccessAndDebuggerNotification(Task task) { }

	// RVA: 0x3668BD0 Offset: 0x3668CD1 VA: 0x3668BD0
	private static void ThrowForNonSuccess(Task task) { }

	// RVA: 0x36689A0 Offset: 0x3668AA1 VA: 0x36689A0
	internal static void OnCompletedInternal(Task task, Action continuation, bool continueOnCapturedContext, bool flowExecutionContext) { }
}

