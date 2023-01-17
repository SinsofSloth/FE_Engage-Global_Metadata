// Namespace: System.Threading
internal class CancellationCallbackInfo // TypeDefIndex: 735
{
	// Fields
	internal readonly Action<object> Callback; // 0x10
	internal readonly object StateForCallback; // 0x18
	internal readonly SynchronizationContext TargetSyncContext; // 0x20
	internal readonly ExecutionContext TargetExecutionContext; // 0x28
	internal readonly CancellationTokenSource CancellationTokenSource; // 0x30
	private static ContextCallback s_executionContextCallback; // 0x0

	// Methods

	// RVA: 0x35160B0 Offset: 0x35161B1 VA: 0x35160B0
	internal void .ctor(Action<object> callback, object stateForCallback, SynchronizationContext targetSyncContext, ExecutionContext targetExecutionContext, CancellationTokenSource cancellationTokenSource) { }

	// RVA: 0x3516150 Offset: 0x3516251 VA: 0x3516150
	internal void ExecuteCallback() { }

	// RVA: 0x35162E0 Offset: 0x35163E1 VA: 0x35162E0
	private static void ExecutionContextCallback(object obj) { }
}

