// Namespace: System.Runtime.CompilerServices
internal struct AsyncMethodBuilderCore // TypeDefIndex: 1243
{
	// Fields
	internal IAsyncStateMachine m_stateMachine; // 0x0
	internal Action m_defaultContextAction; // 0x8

	// Methods

	// RVA: 0x3569A20 Offset: 0x3569B21 VA: 0x3569A20
	public void SetStateMachine(IAsyncStateMachine stateMachine) { }

	// RVA: 0x3569AE0 Offset: 0x3569BE1 VA: 0x3569AE0
	internal Action GetCompletionAction(Task taskForTracing, ref AsyncMethodBuilderCore.MoveNextRunner runnerToInitialize) { }

	// RVA: 0x3569D00 Offset: 0x3569E01 VA: 0x3569D00
	private Action OutputAsyncCausalityEvents(Task innerTask, Action continuation) { }

	// RVA: 0x3569EE0 Offset: 0x3569FE1 VA: 0x3569EE0
	internal void PostBoxInitialization(IAsyncStateMachine stateMachine, AsyncMethodBuilderCore.MoveNextRunner runner, Task builtTask) { }

	// RVA: 0x356A030 Offset: 0x356A131 VA: 0x356A030
	internal static void ThrowAsync(Exception exception, SynchronizationContext targetContext) { }

	// RVA: 0x3569E00 Offset: 0x3569F01 VA: 0x3569E00
	internal static Action CreateContinuationWrapper(Action continuation, Action invokeAction, Task innerTask) { }

	// RVA: 0x356A3B0 Offset: 0x356A4B1 VA: 0x356A3B0
	internal static Task TryGetContinuationTask(Action action) { }
}

