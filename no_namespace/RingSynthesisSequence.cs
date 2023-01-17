// Namespace: 
private enum RingSynthesisSequence.Label // TypeDefIndex: 11780
{
	// Fields
	public int value__; // 0x0
	public const RingSynthesisSequence.Label Skip = 0;
}

// Namespace: 
private class RingSynthesisSequence.Result1Proc : ProcInst // TypeDefIndex: 11781
{
	// Fields
	private RefineRingResult1Window m_RefineRingResult1Window; // 0x70
	private RingData m_RingData; // 0x78

	// Methods

	// RVA: 0x1F58110 Offset: 0x1F58211 VA: 0x1F58110
	public static RingSynthesisSequence.Result1Proc CreateBind(RingSynthesisSequence super, RingData ringData) { }

	// RVA: 0x1F584C0 Offset: 0x1F585C1 VA: 0x1F584C0
	private void .ctor(RingData ringData) { }

	// RVA: 0x1F58500 Offset: 0x1F58601 VA: 0x1F58500
	private void Create() { }

	// RVA: 0x1F585D0 Offset: 0x1F586D1 VA: 0x1F585D0
	private bool IsOpening() { }

	// RVA: 0x1F58670 Offset: 0x1F58771 VA: 0x1F58670
	private bool IsKeyInputted() { }

	// RVA: 0x1F58860 Offset: 0x1F58961 VA: 0x1F58860
	private bool IsClosing() { }

	// RVA: 0x1F58900 Offset: 0x1F58A01 VA: 0x1F58900
	private void Destroy() { }
}

// Namespace: 
private class RingSynthesisSequence.SkipListenerProc : ProcInst // TypeDefIndex: 11782
{
	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x299260 Offset: 0x299361 VA: 0x299260
	private bool <m_Pause>k__BackingField; // 0x70

	// Properties
	public bool m_Pause { get; set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x2C69C0 Offset: 0x2C6AC1 VA: 0x2C69C0
	// RVA: 0x1F58990 Offset: 0x1F58A91 VA: 0x1F58990
	public bool get_m_Pause() { }

	[CompilerGeneratedAttribute] // RVA: 0x2C69D0 Offset: 0x2C6AD1 VA: 0x2C69D0
	// RVA: 0x1F589A0 Offset: 0x1F58AA1 VA: 0x1F589A0
	public void set_m_Pause(bool value) { }

	// RVA: 0x1F589B0 Offset: 0x1F58AB1 VA: 0x1F589B0
	public static RingSynthesisSequence.SkipListenerProc Create(RingSynthesisSequence super) { }

	// RVA: 0x1F58A40 Offset: 0x1F58B41 VA: 0x1F58A40 Slot: 6
	protected override void OnTick() { }

	// RVA: 0x1F58A30 Offset: 0x1F58B31 VA: 0x1F58A30
	public void .ctor() { }
}

// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x277B00 Offset: 0x277C01 VA: 0x277B00
private sealed class RingSynthesisSequence.<WaitTick>d__34 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 11783
{
	// Fields
	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	private float <time>5__2; // 0x20

	// Properties
	private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHiddenAttribute] // RVA: 0x2C69E0 Offset: 0x2C6AE1 VA: 0x2C69E0
	// RVA: 0x1F57FD0 Offset: 0x1F580D1 VA: 0x1F57FD0
	public void .ctor(int <>1__state) { }

	[DebuggerHiddenAttribute] // RVA: 0x2C69F0 Offset: 0x2C6AF1 VA: 0x2C69F0
	// RVA: 0x1F58000 Offset: 0x1F58101 VA: 0x1F58000 Slot: 5
	private void System.IDisposable.Dispose() { }

	// RVA: 0x1F58010 Offset: 0x1F58111 VA: 0x1F58010 Slot: 6
	private bool MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x2C6A00 Offset: 0x2C6B01 VA: 0x2C6A00
	// RVA: 0x1F580B0 Offset: 0x1F581B1 VA: 0x1F580B0 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHiddenAttribute] // RVA: 0x2C6A10 Offset: 0x2C6B11 VA: 0x2C6A10
	// RVA: 0x1F580C0 Offset: 0x1F581C1 VA: 0x1F580C0 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHiddenAttribute] // RVA: 0x2C6A20 Offset: 0x2C6B21 VA: 0x2C6A20
	// RVA: 0x1F58100 Offset: 0x1F58201 VA: 0x1F58100 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }
}

