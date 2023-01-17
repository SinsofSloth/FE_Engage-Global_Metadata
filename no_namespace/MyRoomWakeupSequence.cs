// Namespace: 
private enum MyRoomWakeupSequence.Label // TypeDefIndex: 11376
{
	// Fields
	public int value__; // 0x0
	public const MyRoomWakeupSequence.Label WakeupMain = 0;
	public const MyRoomWakeupSequence.Label WakeupExit = 1;
	public const MyRoomWakeupSequence.Label SkipEndFade = 2;
}

// Namespace: 
public class MyRoomWakeupSequence.RelianceWakeup // TypeDefIndex: 11377
{
	// Fields
	public string m_pid; // 0x10
	public RelianceData.Level m_level; // 0x18
	public GameSound.WakeupVoicePattern m_pattern; // 0x1C

	// Methods

	// RVA: 0x26E75B0 Offset: 0x26E76B1 VA: 0x26E75B0
	public void .ctor(string pid, RelianceData.Level level, GameSound.WakeupVoicePattern pattern) { }

	// RVA: 0x26E7600 Offset: 0x26E7701 VA: 0x26E7600 Slot: 3
	public override string ToString() { }
}

// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x277500 Offset: 0x277601 VA: 0x277500
private sealed class MyRoomWakeupSequence.<ChangeEnv>d__122 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 11378
{
	// Fields
	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public MyRoomWakeupSequence <>4__this; // 0x20
	private int <nextTimezone>5__2; // 0x28
	private IEnumerator <load>5__3; // 0x30
	private IEnumerator <setup>5__4; // 0x38
	private HubEnv <env>5__5; // 0x40
	private HubUtil.TimezoneType <timezoneType>5__6; // 0x48
	private IEnumerator <envLoad>5__7; // 0x50

	// Properties
	private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHiddenAttribute] // RVA: 0x2C5580 Offset: 0x2C5681 VA: 0x2C5580
	// RVA: 0x26E6250 Offset: 0x26E6351 VA: 0x26E6250
	public void .ctor(int <>1__state) { }

	[DebuggerHiddenAttribute] // RVA: 0x2C5590 Offset: 0x2C5691 VA: 0x2C5590
	// RVA: 0x26E6280 Offset: 0x26E6381 VA: 0x26E6280 Slot: 5
	private void System.IDisposable.Dispose() { }

	// RVA: 0x26E6290 Offset: 0x26E6391 VA: 0x26E6290 Slot: 6
	private bool MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x2C55A0 Offset: 0x2C56A1 VA: 0x2C55A0
	// RVA: 0x26E6A90 Offset: 0x26E6B91 VA: 0x26E6A90 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHiddenAttribute] // RVA: 0x2C55B0 Offset: 0x2C56B1 VA: 0x2C55B0
	// RVA: 0x26E6AA0 Offset: 0x26E6BA1 VA: 0x26E6AA0 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHiddenAttribute] // RVA: 0x2C55C0 Offset: 0x2C56C1 VA: 0x2C55C0
	// RVA: 0x26E6AE0 Offset: 0x26E6BE1 VA: 0x26E6AE0 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }
}

// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x277510 Offset: 0x277611 VA: 0x277510
private sealed class MyRoomWakeupSequence.<>c__DisplayClass127_0 // TypeDefIndex: 11379
{
	// Fields
	public List<MyRoomWakeupSequence.RelianceWakeup> tempList; // 0x10

	// Methods

	// RVA: 0x26E5A60 Offset: 0x26E5B61 VA: 0x26E5A60
	public void .ctor() { }

	// RVA: 0x26E5A70 Offset: 0x26E5B71 VA: 0x26E5A70
	internal void <SelectRelianceWakeup>b__0(MyRoomWakeupSequence.RelianceWakeup wakeup) { }
}

// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x277520 Offset: 0x277621 VA: 0x277520
private sealed class MyRoomWakeupSequence.<>c__DisplayClass131_0 // TypeDefIndex: 11380
{
	// Fields
	public Character chara; // 0x10
	public MyRoomWakeupSequence <>4__this; // 0x18

	// Methods

	// RVA: 0x26E5C10 Offset: 0x26E5D11 VA: 0x26E5C10
	public void .ctor() { }

	// RVA: 0x26E5C20 Offset: 0x26E5D21 VA: 0x26E5C20
	internal void <LoadResources>b__0() { }

	// RVA: 0x26E5FD0 Offset: 0x26E60D1 VA: 0x26E5FD0
	internal void <LoadResources>b__1(AnimatorOverrideController aoc) { }

	// RVA: 0x26E6040 Offset: 0x26E6141 VA: 0x26E6040
	internal void <LoadResources>b__2(AnimatorOverrideController aoc) { }

	// RVA: 0x26E60B0 Offset: 0x26E61B1 VA: 0x26E60B0
	internal void <LoadResources>b__3(AnimatorOverrideController aoc) { }

	// RVA: 0x26E6120 Offset: 0x26E6221 VA: 0x26E6120
	internal void <LoadResources>b__4(AnimatorOverrideController aoc) { }

	// RVA: 0x26E6190 Offset: 0x26E6291 VA: 0x26E6190
	internal void <LoadResources>b__5(string path) { }
}

// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x277530 Offset: 0x277631 VA: 0x277530
private sealed class MyRoomWakeupSequence.<WaitBeforeWakeupAction>d__136 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 11381
{
	// Fields
	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public MyRoomWakeupSequence <>4__this; // 0x20
	private float <time>5__2; // 0x28

	// Properties
	private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHiddenAttribute] // RVA: 0x2C55D0 Offset: 0x2C56D1 VA: 0x2C55D0
	// RVA: 0x26E7370 Offset: 0x26E7471 VA: 0x26E7370
	public void .ctor(int <>1__state) { }

	[DebuggerHiddenAttribute] // RVA: 0x2C55E0 Offset: 0x2C56E1 VA: 0x2C55E0
	// RVA: 0x26E73A0 Offset: 0x26E74A1 VA: 0x26E73A0 Slot: 5
	private void System.IDisposable.Dispose() { }

	// RVA: 0x26E73B0 Offset: 0x26E74B1 VA: 0x26E73B0 Slot: 6
	private bool MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x2C55F0 Offset: 0x2C56F1 VA: 0x2C55F0
	// RVA: 0x26E7550 Offset: 0x26E7651 VA: 0x26E7550 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHiddenAttribute] // RVA: 0x2C5600 Offset: 0x2C5701 VA: 0x2C5600
	// RVA: 0x26E7560 Offset: 0x26E7661 VA: 0x26E7560 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHiddenAttribute] // RVA: 0x2C5610 Offset: 0x2C5711 VA: 0x2C5610
	// RVA: 0x26E75A0 Offset: 0x26E76A1 VA: 0x26E75A0 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }
}

// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x277540 Offset: 0x277641 VA: 0x277540
private sealed class MyRoomWakeupSequence.<MainWakeupEnter>d__138 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 11382
{
	// Fields
	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public MyRoomWakeupSequence <>4__this; // 0x20

	// Properties
	private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHiddenAttribute] // RVA: 0x2C5620 Offset: 0x2C5721 VA: 0x2C5620
	// RVA: 0x26E70B0 Offset: 0x26E71B1 VA: 0x26E70B0
	public void .ctor(int <>1__state) { }

	[DebuggerHiddenAttribute] // RVA: 0x2C5630 Offset: 0x2C5731 VA: 0x2C5630
	// RVA: 0x26E70E0 Offset: 0x26E71E1 VA: 0x26E70E0 Slot: 5
	private void System.IDisposable.Dispose() { }

	// RVA: 0x26E70F0 Offset: 0x26E71F1 VA: 0x26E70F0 Slot: 6
	private bool MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x2C5640 Offset: 0x2C5741 VA: 0x2C5640
	// RVA: 0x26E7310 Offset: 0x26E7411 VA: 0x26E7310 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHiddenAttribute] // RVA: 0x2C5650 Offset: 0x2C5751 VA: 0x2C5650
	// RVA: 0x26E7320 Offset: 0x26E7421 VA: 0x26E7320 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHiddenAttribute] // RVA: 0x2C5660 Offset: 0x2C5761 VA: 0x2C5660
	// RVA: 0x26E7360 Offset: 0x26E7461 VA: 0x26E7360 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }
}

// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x277550 Offset: 0x277651 VA: 0x277550
private sealed class MyRoomWakeupSequence.<MainWakeup>d__139 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 11383
{
	// Fields
	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public MyRoomWakeupSequence <>4__this; // 0x20

	// Properties
	private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHiddenAttribute] // RVA: 0x2C5670 Offset: 0x2C5771 VA: 0x2C5670
	// RVA: 0x26E6AF0 Offset: 0x26E6BF1 VA: 0x26E6AF0
	public void .ctor(int <>1__state) { }

	[DebuggerHiddenAttribute] // RVA: 0x2C5680 Offset: 0x2C5781 VA: 0x2C5680
	// RVA: 0x26E6B20 Offset: 0x26E6C21 VA: 0x26E6B20 Slot: 5
	private void System.IDisposable.Dispose() { }

	// RVA: 0x26E6B30 Offset: 0x26E6C31 VA: 0x26E6B30 Slot: 6
	private bool MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x2C5690 Offset: 0x2C5791 VA: 0x2C5690
	// RVA: 0x26E6D50 Offset: 0x26E6E51 VA: 0x26E6D50 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHiddenAttribute] // RVA: 0x2C56A0 Offset: 0x2C57A1 VA: 0x2C56A0
	// RVA: 0x26E6D60 Offset: 0x26E6E61 VA: 0x26E6D60 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHiddenAttribute] // RVA: 0x2C56B0 Offset: 0x2C57B1 VA: 0x2C56B0
	// RVA: 0x26E6DA0 Offset: 0x26E6EA1 VA: 0x26E6DA0 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }
}

// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x277560 Offset: 0x277661 VA: 0x277560
private sealed class MyRoomWakeupSequence.<MainWakeupBeforeAfter>d__140 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 11384
{
	// Fields
	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public MyRoomWakeupSequence <>4__this; // 0x20

	// Properties
	private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHiddenAttribute] // RVA: 0x2C56C0 Offset: 0x2C57C1 VA: 0x2C56C0
	// RVA: 0x26E6DB0 Offset: 0x26E6EB1 VA: 0x26E6DB0
	public void .ctor(int <>1__state) { }

	[DebuggerHiddenAttribute] // RVA: 0x2C56D0 Offset: 0x2C57D1 VA: 0x2C56D0
	// RVA: 0x26E6DE0 Offset: 0x26E6EE1 VA: 0x26E6DE0 Slot: 5
	private void System.IDisposable.Dispose() { }

	// RVA: 0x26E6DF0 Offset: 0x26E6EF1 VA: 0x26E6DF0 Slot: 6
	private bool MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x2C56E0 Offset: 0x2C57E1 VA: 0x2C56E0
	// RVA: 0x26E7050 Offset: 0x26E7151 VA: 0x26E7050 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHiddenAttribute] // RVA: 0x2C56F0 Offset: 0x2C57F1 VA: 0x2C56F0
	// RVA: 0x26E7060 Offset: 0x26E7161 VA: 0x26E7060 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHiddenAttribute] // RVA: 0x2C5700 Offset: 0x2C5801 VA: 0x2C5700
	// RVA: 0x26E70A0 Offset: 0x26E71A1 VA: 0x26E70A0 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }
}

