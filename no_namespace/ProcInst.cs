// Namespace: 
[FlagsAttribute] // RVA: 0x2792F0 Offset: 0x2793F1 VA: 0x2792F0
private enum ProcInst.State // TypeDefIndex: 13904
{
	// Fields
	public int value__; // 0x0
	public const ProcInst.State Dead = 1;
	public const ProcInst.State ParentBind = 2;
	public const ProcInst.State Executed = 4;
	public const ProcInst.State Continue = 8;
	public const ProcInst.State Yield = 16;
}

// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x279300 Offset: 0x279401 VA: 0x279300
private sealed class ProcInst.<OnCoroutine>d__82 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 13905
{
	// Fields
	private int <>1__state; // 0x10
	private object <>2__current; // 0x18

	// Properties
	private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHiddenAttribute] // RVA: 0x2CD870 Offset: 0x2CD971 VA: 0x2CD870
	// RVA: 0x1F20410 Offset: 0x1F20511 VA: 0x1F20410
	public void .ctor(int <>1__state) { }

	[DebuggerHiddenAttribute] // RVA: 0x2CD880 Offset: 0x2CD981 VA: 0x2CD880
	// RVA: 0x1F20440 Offset: 0x1F20541 VA: 0x1F20440 Slot: 5
	private void System.IDisposable.Dispose() { }

	// RVA: 0x1F20450 Offset: 0x1F20551 VA: 0x1F20450 Slot: 6
	private bool MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x2CD890 Offset: 0x2CD991 VA: 0x2CD890
	// RVA: 0x1F204B0 Offset: 0x1F205B1 VA: 0x1F204B0 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHiddenAttribute] // RVA: 0x2CD8A0 Offset: 0x2CD9A1 VA: 0x2CD8A0
	// RVA: 0x1F204C0 Offset: 0x1F205C1 VA: 0x1F204C0 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHiddenAttribute] // RVA: 0x2CD8B0 Offset: 0x2CD9B1 VA: 0x2CD8B0
	// RVA: 0x1F20500 Offset: 0x1F20601 VA: 0x1F20500 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }
}

