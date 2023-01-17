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

