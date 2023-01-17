// Namespace: 
internal sealed class AsyncMethodBuilderCore.MoveNextRunner // TypeDefIndex: 1239
{
	// Fields
	private readonly ExecutionContext m_context; // 0x10
	internal IAsyncStateMachine m_stateMachine; // 0x18
	private static ContextCallback s_invokeMoveNext; // 0x0

	// Methods

	// RVA: 0x35E2EA0 Offset: 0x35E2FA1 VA: 0x35E2EA0
	internal void .ctor(ExecutionContext context, IAsyncStateMachine stateMachine) { }

	// RVA: 0x35E2EF0 Offset: 0x35E2FF1 VA: 0x35E2EF0
	internal void Run() { }

	// RVA: 0x35E30C0 Offset: 0x35E31C1 VA: 0x35E30C0
	private static void InvokeMoveNext(object stateMachine) { }
}

// Namespace: 
private class AsyncMethodBuilderCore.ContinuationWrapper // TypeDefIndex: 1240
{
	// Fields
	internal readonly Action m_continuation; // 0x10
	private readonly Action m_invokeAction; // 0x18
	internal readonly Task m_innerTask; // 0x20

	// Methods

	// RVA: 0x35E2E10 Offset: 0x35E2F11 VA: 0x35E2E10
	internal void .ctor(Action continuation, Action invokeAction, Task innerTask) { }

	// RVA: 0x35E2E90 Offset: 0x35E2F91 VA: 0x35E2E90
	internal void Invoke() { }
}

// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x475520 Offset: 0x475621 VA: 0x475520
private sealed class AsyncMethodBuilderCore.<>c__DisplayClass4_0 // TypeDefIndex: 1241
{
	// Fields
	public Task innerTask; // 0x10
	public Action continuation; // 0x18

	// Methods

	// RVA: 0x35E2DA0 Offset: 0x35E2EA1 VA: 0x35E2DA0
	public void .ctor() { }

	// RVA: 0x35E2DB0 Offset: 0x35E2EB1 VA: 0x35E2DB0
	internal void <OutputAsyncCausalityEvents>b__0() { }
}

// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x475530 Offset: 0x475631 VA: 0x475530
[Serializable]
private sealed class AsyncMethodBuilderCore.<>c // TypeDefIndex: 1242
{
	// Fields
	public static readonly AsyncMethodBuilderCore.<>c <>9; // 0x0
	public static SendOrPostCallback <>9__6_0; // 0x8
	public static WaitCallback <>9__6_1; // 0x10

	// Methods

	// RVA: 0x35E2C40 Offset: 0x35E2D41 VA: 0x35E2C40
	private static void .cctor() { }

	// RVA: 0x35E2CB0 Offset: 0x35E2DB1 VA: 0x35E2CB0
	public void .ctor() { }

	// RVA: 0x35E2CC0 Offset: 0x35E2DC1 VA: 0x35E2CC0
	internal void <ThrowAsync>b__6_0(object state) { }

	// RVA: 0x35E2D30 Offset: 0x35E2E31 VA: 0x35E2D30
	internal void <ThrowAsync>b__6_1(object state) { }
}

