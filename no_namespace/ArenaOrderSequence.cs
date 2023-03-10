// Namespace: 
public struct ArenaOrderSequence.GodInfo // TypeDefIndex: 10456
{
	// Fields
	public GodUnit God; // 0x0
	public RingCleaningSequence.GodType Type; // 0x8
}

// Namespace: 
public enum ArenaOrderSequence.Label // TypeDefIndex: 10457
{
	// Fields
	public int value__; // 0x0
	public const ArenaOrderSequence.Label Top = 0;
	public const ArenaOrderSequence.Label ExpSelectUnit = 1;
	public const ArenaOrderSequence.Label BondSelectUnit = 2;
	public const ArenaOrderSequence.Label BondSelectEmblem = 3;
	public const ArenaOrderSequence.Label BondSelectLevel = 4;
	public const ArenaOrderSequence.Label Training = 5;
	public const ArenaOrderSequence.Label Result = 6;
	public const ArenaOrderSequence.Label End = 7;
}

// Namespace: 
public enum ArenaOrderSequence.TrainType // TypeDefIndex: 10458
{
	// Fields
	public int value__; // 0x0
	public const ArenaOrderSequence.TrainType Random = 0;
	public const ArenaOrderSequence.TrainType Emblem = 1;
}

// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x276B70 Offset: 0x276C71 VA: 0x276B70
private sealed class ArenaOrderSequence.<>c__DisplayClass65_0 // TypeDefIndex: 10459
{
	// Fields
	public ArenaOrderSequence p; // 0x10

	// Methods

	// RVA: 0x1F672C0 Offset: 0x1F673C1 VA: 0x1F672C0
	public void .ctor() { }

	// RVA: 0x1F672D0 Offset: 0x1F673D1 VA: 0x1F672D0
	internal void <CreateBind>b__0() { }

	// RVA: 0x1F67350 Offset: 0x1F67451 VA: 0x1F67350
	internal void <CreateBind>b__1() { }

	// RVA: 0x1F673D0 Offset: 0x1F674D1 VA: 0x1F673D0
	internal void <CreateBind>b__2() { }

	// RVA: 0x1F67450 Offset: 0x1F67551 VA: 0x1F67450
	internal void <CreateBind>b__3() { }

	// RVA: 0x1F674D0 Offset: 0x1F675D1 VA: 0x1F674D0
	internal void <CreateBind>b__4() { }
}

// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x276B80 Offset: 0x276C81 VA: 0x276B80
private sealed class ArenaOrderSequence.<Load>d__66 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 10460
{
	// Fields
	private int <>1__state; // 0x10
	private object <>2__current; // 0x18

	// Properties
	private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHiddenAttribute] // RVA: 0x2BE6F0 Offset: 0x2BE7F1 VA: 0x2BE6F0
	// RVA: 0x1F67880 Offset: 0x1F67981 VA: 0x1F67880
	public void .ctor(int <>1__state) { }

	[DebuggerHiddenAttribute] // RVA: 0x2BE700 Offset: 0x2BE801 VA: 0x2BE700
	// RVA: 0x1F678B0 Offset: 0x1F679B1 VA: 0x1F678B0 Slot: 5
	private void System.IDisposable.Dispose() { }

	// RVA: 0x1F678C0 Offset: 0x1F679C1 VA: 0x1F678C0 Slot: 6
	private bool MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x2BE710 Offset: 0x2BE811 VA: 0x2BE710
	// RVA: 0x1F679A0 Offset: 0x1F67AA1 VA: 0x1F679A0 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHiddenAttribute] // RVA: 0x2BE720 Offset: 0x2BE821 VA: 0x2BE720
	// RVA: 0x1F679B0 Offset: 0x1F67AB1 VA: 0x1F679B0 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHiddenAttribute] // RVA: 0x2BE730 Offset: 0x2BE831 VA: 0x2BE730
	// RVA: 0x1F679F0 Offset: 0x1F67AF1 VA: 0x1F679F0 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }
}

// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x276B90 Offset: 0x276C91 VA: 0x276B90
private sealed class ArenaOrderSequence.<>c__DisplayClass80_0 // TypeDefIndex: 10461
{
	// Fields
	public List<Unit> unitList; // 0x10

	// Methods

	// RVA: 0x1F67550 Offset: 0x1F67651 VA: 0x1F67550
	public void .ctor() { }

	// RVA: 0x1F67560 Offset: 0x1F67661 VA: 0x1F67560
	internal void <SetupRandomUnit>b__0(Unit unit) { }
}

// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x276BA0 Offset: 0x276CA1 VA: 0x276BA0
private sealed class ArenaOrderSequence.<>c__DisplayClass86_0 // TypeDefIndex: 10462
{
	// Fields
	public ArenaOrderSequence <>4__this; // 0x10
	[TupleElementNamesAttribute] // RVA: 0x28E2F0 Offset: 0x28E3F1 VA: 0x28E2F0
	public HashSet<ValueTuple<string, int>> itemSet; // 0x18
	public ItemData.Kinds kind; // 0x20
	public Unit unit; // 0x28
	public WeaponLevel.Kind weapoLevel; // 0x30

	// Methods

	// RVA: 0x1F675C0 Offset: 0x1F676C1 VA: 0x1F675C0
	public void .ctor() { }

	// RVA: 0x1F675D0 Offset: 0x1F676D1 VA: 0x1F675D0
	internal void <SetBattleUnitWeapon>b__0(Unit u) { }

	// RVA: 0x1F677F0 Offset: 0x1F678F1 VA: 0x1F677F0
	internal bool <SetBattleUnitWeapon>g__IsCandidate|1(ItemData item) { }
}

