// Namespace: 
private enum RingGachaSequence.Label // TypeDefIndex: 11772
{
	// Fields
	public int value__; // 0x0
	public const RingGachaSequence.Label StartEffect = 0;
	public const RingGachaSequence.Label SkipOne = 1;
	public const RingGachaSequence.Label ResultOne = 2;
	public const RingGachaSequence.Label SkipAll = 3;
	public const RingGachaSequence.Label End = 4;
}

// Namespace: 
public enum RingGachaSequence.SkipListenerProc.Type // TypeDefIndex: 11773
{
	// Fields
	public int value__; // 0x0
	public const RingGachaSequence.SkipListenerProc.Type None = 0;
	public const RingGachaSequence.SkipListenerProc.Type One = 1;
	public const RingGachaSequence.SkipListenerProc.Type All = 2;
}

// Namespace: 
public sealed class RingGachaSequence.SkipListenerProc.SkipCallback : MulticastDelegate // TypeDefIndex: 11774
{
	// Methods

	// RVA: 0x21F5B20 Offset: 0x21F5C21 VA: 0x21F5B20
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x21F5B40 Offset: 0x21F5C41 VA: 0x21F5B40 Slot: 13
	public virtual void Invoke(RingGachaSequence.SkipListenerProc.Type type) { }

	// RVA: 0x21F5DA0 Offset: 0x21F5EA1 VA: 0x21F5DA0 Slot: 14
	public virtual IAsyncResult BeginInvoke(RingGachaSequence.SkipListenerProc.Type type, AsyncCallback callback, object object) { }

	// RVA: 0x21F5E30 Offset: 0x21F5F31 VA: 0x21F5E30 Slot: 15
	public virtual void EndInvoke(IAsyncResult result) { }
}

// Namespace: 
private class RingGachaSequence.SkipListenerProc : ProcInst // TypeDefIndex: 11775
{
	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x299240 Offset: 0x299341 VA: 0x299240
	private bool <m_Pause>k__BackingField; // 0x70
	[CompilerGeneratedAttribute] // RVA: 0x299250 Offset: 0x299351 VA: 0x299250
	private bool <m_PauseOne>k__BackingField; // 0x71
	private RingGachaSequence.SkipListenerProc.SkipCallback m_SkipCallback; // 0x78

	// Properties
	public bool m_Pause { get; set; }
	public bool m_PauseOne { get; set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x2C68C0 Offset: 0x2C69C1 VA: 0x2C68C0
	// RVA: 0x1F4BDF0 Offset: 0x1F4BEF1 VA: 0x1F4BDF0
	public bool get_m_Pause() { }

	[CompilerGeneratedAttribute] // RVA: 0x2C68D0 Offset: 0x2C69D1 VA: 0x2C68D0
	// RVA: 0x1F4BE00 Offset: 0x1F4BF01 VA: 0x1F4BE00
	public void set_m_Pause(bool value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2C68E0 Offset: 0x2C69E1 VA: 0x2C68E0
	// RVA: 0x1F4BE10 Offset: 0x1F4BF11 VA: 0x1F4BE10
	public bool get_m_PauseOne() { }

	[CompilerGeneratedAttribute] // RVA: 0x2C68F0 Offset: 0x2C69F1 VA: 0x2C68F0
	// RVA: 0x1F4BE20 Offset: 0x1F4BF21 VA: 0x1F4BE20
	public void set_m_PauseOne(bool value) { }

	// RVA: 0x1F4BE30 Offset: 0x1F4BF31 VA: 0x1F4BE30
	public static RingGachaSequence.SkipListenerProc Create(RingGachaSequence super, RingGachaSequence.SkipListenerProc.SkipCallback skipCallback) { }

	// RVA: 0x1F4BEC0 Offset: 0x1F4BFC1 VA: 0x1F4BEC0
	public void .ctor(RingGachaSequence.SkipListenerProc.SkipCallback skipCallback) { }

	// RVA: 0x1F4BF00 Offset: 0x1F4C001 VA: 0x1F4BF00 Slot: 6
	protected override void OnTick() { }
}

// Namespace: 
private class RingGachaSequence.Result1Proc : ProcInst // TypeDefIndex: 11776
{
	// Fields
	private RefineRingResult1Window m_RefineRingResult1Window; // 0x70
	private UnitRing m_UnitRing; // 0x78
	private bool m_New; // 0x80
	private TitleBar m_TitleBar; // 0x88

	// Methods

	// RVA: 0x1F4B590 Offset: 0x1F4B691 VA: 0x1F4B590
	public static RingGachaSequence.Result1Proc CreateBind(RingGachaSequence super, UnitRing ringData, bool newRing) { }

	// RVA: 0x1F4B850 Offset: 0x1F4B951 VA: 0x1F4B850
	private void .ctor(UnitRing ringData, bool newRing) { }

	// RVA: 0x1F4B960 Offset: 0x1F4BA61 VA: 0x1F4B960 Slot: 9
	protected override void OnCreate() { }

	// RVA: 0x1F4BA30 Offset: 0x1F4BB31 VA: 0x1F4BA30
	private bool IsOpening() { }

	// RVA: 0x1F4BAD0 Offset: 0x1F4BBD1 VA: 0x1F4BAD0
	private bool IsKeyInputted() { }

	// RVA: 0x1F4BCC0 Offset: 0x1F4BDC1 VA: 0x1F4BCC0
	private bool IsClosing() { }

	// RVA: 0x1F4BD60 Offset: 0x1F4BE61 VA: 0x1F4BD60 Slot: 10
	protected override void OnDispose() { }
}

// Namespace: 
private class RingGachaSequence.Result10Proc : ProcInst // TypeDefIndex: 11777
{
	// Fields
	private RefineRingResult10Window m_RefineRingResult10Window; // 0x70
	private List<UnitRing> m_UnitRingList; // 0x78
	private List<bool> m_NewList; // 0x80
	private TitleBar m_TitleBar; // 0x88

	// Methods

	// RVA: 0x1F4AC60 Offset: 0x1F4AD61 VA: 0x1F4AC60
	public static RingGachaSequence.Result10Proc CreateBind(RingGachaSequence super, List<UnitRing> ringDataList, List<bool> newList) { }

	// RVA: 0x1F4AF20 Offset: 0x1F4B021 VA: 0x1F4AF20
	private void .ctor(List<UnitRing> ringDataList, List<bool> newList) { }

	// RVA: 0x1F4B030 Offset: 0x1F4B131 VA: 0x1F4B030 Slot: 9
	protected override void OnCreate() { }

	// RVA: 0x1F4B1D0 Offset: 0x1F4B2D1 VA: 0x1F4B1D0
	private bool IsOpening() { }

	// RVA: 0x1F4B270 Offset: 0x1F4B371 VA: 0x1F4B270
	private bool IsKeyInputted() { }

	// RVA: 0x1F4B460 Offset: 0x1F4B561 VA: 0x1F4B460
	private bool IsClosing() { }

	// RVA: 0x1F4B500 Offset: 0x1F4B601 VA: 0x1F4B500 Slot: 10
	protected override void OnDispose() { }
}

// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x277AF0 Offset: 0x277BF1 VA: 0x277AF0
private sealed class RingGachaSequence.<Start>d__36 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 11778
{
	// Fields
	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public RingGachaSequence <>4__this; // 0x20

	// Properties
	private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHiddenAttribute] // RVA: 0x2C6900 Offset: 0x2C6A01 VA: 0x2C6900
	// RVA: 0x1F4AAA0 Offset: 0x1F4ABA1 VA: 0x1F4AAA0
	public void .ctor(int <>1__state) { }

	[DebuggerHiddenAttribute] // RVA: 0x2C6910 Offset: 0x2C6A11 VA: 0x2C6910
	// RVA: 0x1F4AAD0 Offset: 0x1F4ABD1 VA: 0x1F4AAD0 Slot: 5
	private void System.IDisposable.Dispose() { }

	// RVA: 0x1F4AAE0 Offset: 0x1F4ABE1 VA: 0x1F4AAE0 Slot: 6
	private bool MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x2C6920 Offset: 0x2C6A21 VA: 0x2C6920
	// RVA: 0x1F4AC00 Offset: 0x1F4AD01 VA: 0x1F4AC00 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHiddenAttribute] // RVA: 0x2C6930 Offset: 0x2C6A31 VA: 0x2C6930
	// RVA: 0x1F4AC10 Offset: 0x1F4AD11 VA: 0x1F4AC10 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHiddenAttribute] // RVA: 0x2C6940 Offset: 0x2C6A41 VA: 0x2C6940
	// RVA: 0x1F4AC50 Offset: 0x1F4AD51 VA: 0x1F4AC50 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }
}

