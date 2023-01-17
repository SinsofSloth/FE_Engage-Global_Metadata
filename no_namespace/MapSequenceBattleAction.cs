// Namespace: 
private enum MapSequenceBattleAction.Label // TypeDefIndex: 12391
{
	// Fields
	public int value__; // 0x0
	public const MapSequenceBattleAction.Label Branch = 0;
	public const MapSequenceBattleAction.Label Attack = 1;
	public const MapSequenceBattleAction.Label Impact = 2;
	public const MapSequenceBattleAction.Label Skill = 3;
	public const MapSequenceBattleAction.Label Next = 4;
	public const MapSequenceBattleAction.Label Wait = 5;
	public const MapSequenceBattleAction.Label Skip = 6;
	public const MapSequenceBattleAction.Label WhiteOut = 7;
	public const MapSequenceBattleAction.Label End = 8;
}

// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x278570 Offset: 0x278671 VA: 0x278570
private sealed class MapSequenceBattleAction.<Landing>d__55 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 12392
{
	// Fields
	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public MapSequenceBattleAction <>4__this; // 0x20
	private BattleInfoSide <offense>5__2; // 0x28
	private BattleInfoSide <defense>5__3; // 0x30

	// Properties
	private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHiddenAttribute] // RVA: 0x2C8A70 Offset: 0x2C8B71 VA: 0x2C8A70
	// RVA: 0x2418A00 Offset: 0x2418B01 VA: 0x2418A00
	public void .ctor(int <>1__state) { }

	[DebuggerHiddenAttribute] // RVA: 0x2C8A80 Offset: 0x2C8B81 VA: 0x2C8A80
	// RVA: 0x2418A30 Offset: 0x2418B31 VA: 0x2418A30 Slot: 5
	private void System.IDisposable.Dispose() { }

	// RVA: 0x2418A40 Offset: 0x2418B41 VA: 0x2418A40 Slot: 6
	private bool MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x2C8A90 Offset: 0x2C8B91 VA: 0x2C8A90
	// RVA: 0x2418CF0 Offset: 0x2418DF1 VA: 0x2418CF0 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHiddenAttribute] // RVA: 0x2C8AA0 Offset: 0x2C8BA1 VA: 0x2C8AA0
	// RVA: 0x2418D00 Offset: 0x2418E01 VA: 0x2418D00 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHiddenAttribute] // RVA: 0x2C8AB0 Offset: 0x2C8BB1 VA: 0x2C8AB0
	// RVA: 0x2418D40 Offset: 0x2418E41 VA: 0x2418D40 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }
}

// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x278580 Offset: 0x278681 VA: 0x278580
private sealed class MapSequenceBattleAction.<WaitLoading>d__65 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 12393
{
	// Fields
	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public MapSequenceBattleAction <>4__this; // 0x20
	private BattleInfoSide <offense>5__2; // 0x28
	private BattleInfoSide <defense>5__3; // 0x30

	// Properties
	private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHiddenAttribute] // RVA: 0x2C8AC0 Offset: 0x2C8BC1 VA: 0x2C8AC0
	// RVA: 0x241A2E0 Offset: 0x241A3E1 VA: 0x241A2E0
	public void .ctor(int <>1__state) { }

	[DebuggerHiddenAttribute] // RVA: 0x2C8AD0 Offset: 0x2C8BD1 VA: 0x2C8AD0
	// RVA: 0x241A310 Offset: 0x241A411 VA: 0x241A310 Slot: 5
	private void System.IDisposable.Dispose() { }

	// RVA: 0x241A320 Offset: 0x241A421 VA: 0x241A320 Slot: 6
	private bool MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x2C8AE0 Offset: 0x2C8BE1 VA: 0x2C8AE0
	// RVA: 0x241A510 Offset: 0x241A611 VA: 0x241A510 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHiddenAttribute] // RVA: 0x2C8AF0 Offset: 0x2C8BF1 VA: 0x2C8AF0
	// RVA: 0x241A520 Offset: 0x241A621 VA: 0x241A520 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHiddenAttribute] // RVA: 0x2C8B00 Offset: 0x2C8C01 VA: 0x2C8B00
	// RVA: 0x241A560 Offset: 0x241A661 VA: 0x241A560 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }
}

// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x278590 Offset: 0x278691 VA: 0x278590
private sealed class MapSequenceBattleAction.<TryTransOn>d__87 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 12394
{
	// Fields
	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public MapSequenceBattleAction <>4__this; // 0x20
	private BattleInfoEnum <>7__wrap1; // 0x28
	private BattleInfoSide <side>5__3; // 0x40
	private UnitModel.ResourceHandle <cache>5__4; // 0x48
	private int <i>5__5; // 0x50

	// Properties
	private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHiddenAttribute] // RVA: 0x2C8B10 Offset: 0x2C8C11 VA: 0x2C8B10
	// RVA: 0x2419810 Offset: 0x2419911 VA: 0x2419810
	public void .ctor(int <>1__state) { }

	[DebuggerHiddenAttribute] // RVA: 0x2C8B20 Offset: 0x2C8C21 VA: 0x2C8B20
	// RVA: 0x2419840 Offset: 0x2419941 VA: 0x2419840 Slot: 5
	private void System.IDisposable.Dispose() { }

	// RVA: 0x2419B00 Offset: 0x2419C01 VA: 0x2419B00 Slot: 6
	private bool MoveNext() { }

	// RVA: 0x2419AC0 Offset: 0x2419BC1 VA: 0x2419AC0
	private void <>m__Finally1() { }

	// RVA: 0x2419A00 Offset: 0x2419B01 VA: 0x2419A00
	private void <>m__Finally2() { }

	// RVA: 0x2419AE0 Offset: 0x2419BE1 VA: 0x2419AE0
	private void <>m__Finally3() { }

	[DebuggerHiddenAttribute] // RVA: 0x2C8B30 Offset: 0x2C8C31 VA: 0x2C8B30
	// RVA: 0x241A280 Offset: 0x241A381 VA: 0x241A280 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHiddenAttribute] // RVA: 0x2C8B40 Offset: 0x2C8C41 VA: 0x2C8B40
	// RVA: 0x241A290 Offset: 0x241A391 VA: 0x241A290 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHiddenAttribute] // RVA: 0x2C8B50 Offset: 0x2C8C51 VA: 0x2C8B50
	// RVA: 0x241A2D0 Offset: 0x241A3D1 VA: 0x241A2D0 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }
}

// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x2785A0 Offset: 0x2786A1 VA: 0x2785A0
private sealed class MapSequenceBattleAction.<TryTransOff>d__88 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 12395
{
	// Fields
	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public MapSequenceBattleAction <>4__this; // 0x20
	private BattleInfoEnum <>7__wrap1; // 0x28
	private BattleInfoSide <side>5__3; // 0x40
	private UnitModel.ResourceHandle <cache>5__4; // 0x48
	private int <i>5__5; // 0x50

	// Properties
	private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHiddenAttribute] // RVA: 0x2C8B60 Offset: 0x2C8C61 VA: 0x2C8B60
	// RVA: 0x2418D50 Offset: 0x2418E51 VA: 0x2418D50
	public void .ctor(int <>1__state) { }

	[DebuggerHiddenAttribute] // RVA: 0x2C8B70 Offset: 0x2C8C71 VA: 0x2C8B70
	// RVA: 0x2418D80 Offset: 0x2418E81 VA: 0x2418D80 Slot: 5
	private void System.IDisposable.Dispose() { }

	// RVA: 0x2419040 Offset: 0x2419141 VA: 0x2419040 Slot: 6
	private bool MoveNext() { }

	// RVA: 0x2419000 Offset: 0x2419101 VA: 0x2419000
	private void <>m__Finally1() { }

	// RVA: 0x2418F40 Offset: 0x2419041 VA: 0x2418F40
	private void <>m__Finally2() { }

	// RVA: 0x2419020 Offset: 0x2419121 VA: 0x2419020
	private void <>m__Finally3() { }

	[DebuggerHiddenAttribute] // RVA: 0x2C8B80 Offset: 0x2C8C81 VA: 0x2C8B80
	// RVA: 0x24197B0 Offset: 0x24198B1 VA: 0x24197B0 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHiddenAttribute] // RVA: 0x2C8B90 Offset: 0x2C8C91 VA: 0x2C8B90
	// RVA: 0x24197C0 Offset: 0x24198C1 VA: 0x24197C0 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHiddenAttribute] // RVA: 0x2C8BA0 Offset: 0x2C8CA1 VA: 0x2C8BA0
	// RVA: 0x2419800 Offset: 0x2419901 VA: 0x2419800 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }
}

