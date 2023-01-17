// Namespace: 
[FlagsAttribute] // RVA: 0x2784D0 Offset: 0x2785D1 VA: 0x2784D0
private enum MapSequenceBattle.Status // TypeDefIndex: 12374
{
	// Fields
	public int value__; // 0x0
	public const MapSequenceBattle.Status MultiBattle = 1;
	public const MapSequenceBattle.Status SingleRod = 2;
	public const MapSequenceBattle.Status UsedRod = 4;
	public const MapSequenceBattle.Status UsedMove = 8;
	public const MapSequenceBattle.Status LastBossDie = 16;
}

// Namespace: 
private enum MapSequenceBattle.Kinds // TypeDefIndex: 12375
{
	// Fields
	public int value__; // 0x0
	public const MapSequenceBattle.Kinds None = 0;
	public const MapSequenceBattle.Kinds Battle = 1;
	public const MapSequenceBattle.Kinds Destroy = 2;
	public const MapSequenceBattle.Kinds Rod = 3;
}

// Namespace: 
private class MapSequenceBattle.BitFieldStatus : BitFieldTemplate32<MapSequenceBattle.Status> // TypeDefIndex: 12376
{
	// Methods

	// RVA: 0x2417D10 Offset: 0x2417E11 VA: 0x2417D10 Slot: 5
	protected override int ToInt(MapSequenceBattle.Status value) { }

	// RVA: 0x2417D20 Offset: 0x2417E21 VA: 0x2417D20
	public void .ctor() { }
}

// Namespace: 
private enum MapSequenceBattle.Label // TypeDefIndex: 12377
{
	// Fields
	public int value__; // 0x0
	public const MapSequenceBattle.Label BattleStart = 0;
	public const MapSequenceBattle.Label CombatRod = 1;
	public const MapSequenceBattle.Label SimpleRod = 2;
	public const MapSequenceBattle.Label Destroy = 3;
	public const MapSequenceBattle.Label CombatBattle = 4;
	public const MapSequenceBattle.Label SimpleBattle = 5;
	public const MapSequenceBattle.Label MultiBattleStart = 6;
	public const MapSequenceBattle.Label MultiBattleLoop = 7;
	public const MapSequenceBattle.Label MultiBattleSkip = 8;
	public const MapSequenceBattle.Label MultiBattleEnd = 9;
	public const MapSequenceBattle.Label Die = 10;
	public const MapSequenceBattle.Label Grow = 11;
	public const MapSequenceBattle.Label CombatAfter = 12;
	public const MapSequenceBattle.Label Commit = 13;
	public const MapSequenceBattle.Label After = 14;
	public const MapSequenceBattle.Label LastBossDie = 15;
	public const MapSequenceBattle.Label EngageTurnRecovery = 16;
	public const MapSequenceBattle.Label HpStockCreate = 17;
	public const MapSequenceBattle.Label End = 18;
}

// Namespace: 
private class MapSequenceBattle.UnitList : List<Unit> // TypeDefIndex: 12378
{
	// Methods

	// RVA: 0x2416F20 Offset: 0x2417021 VA: 0x2416F20
	public bool TryAdd(Unit unit) { }

	// RVA: 0x2418980 Offset: 0x2418A81 VA: 0x2418980
	public void .ctor() { }
}

// Namespace: 
private struct MapSequenceBattle.BattleUnitScope : IDisposable // TypeDefIndex: 12379
{
	// Fields
	private BattleInfo m_Info; // 0x0

	// Methods

	// RVA: 0x2415290 Offset: 0x2415391 VA: 0x2415290
	public void .ctor(BattleInfo info) { }

	// RVA: 0x24153B0 Offset: 0x24154B1 VA: 0x24153B0 Slot: 4
	public void Dispose() { }
}

// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x2784E0 Offset: 0x2785E1 VA: 0x2784E0
private sealed class MapSequenceBattle.RangeWarpTargets.<>c__DisplayClass0_0 // TypeDefIndex: 12380
{
	// Fields
	public int warpX; // 0x10
	public int warpZ; // 0x14
	public int rootX; // 0x18
	public int rootZ; // 0x1C

	// Methods

	// RVA: 0x21E5FE0 Offset: 0x21E60E1 VA: 0x21E5FE0
	public void .ctor() { }

	// RVA: 0x21E5FF0 Offset: 0x21E60F1 VA: 0x21E5FF0
	internal int <.ctor>b__0(Unit a, Unit b) { }
}

// Namespace: 
private class MapSequenceBattle.RangeWarpTargets : List<Unit>, IDisposable // TypeDefIndex: 12381
{
	// Methods

	// RVA: 0x2417D80 Offset: 0x2417E81 VA: 0x2417D80
	public void .ctor(Unit rodUnit, Unit unit, int range, int warpX, int warpZ, bool canSelf) { }

	// RVA: 0x2418920 Offset: 0x2418A21 VA: 0x2418920 Slot: 34
	public void Dispose() { }
}

// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x2784F0 Offset: 0x2785F1 VA: 0x2784F0
private sealed class MapSequenceBattle.<MultiBattleTalk>d__29 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 12382
{
	// Fields
	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public MapSequenceBattle <>4__this; // 0x20
	private int <i>5__2; // 0x28
	private int <index>5__3; // 0x2C

	// Properties
	private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHiddenAttribute] // RVA: 0x2C8680 Offset: 0x2C8781 VA: 0x2C8680
	// RVA: 0x24179F0 Offset: 0x2417AF1 VA: 0x24179F0
	public void .ctor(int <>1__state) { }

	[DebuggerHiddenAttribute] // RVA: 0x2C8690 Offset: 0x2C8791 VA: 0x2C8690
	// RVA: 0x2417A20 Offset: 0x2417B21 VA: 0x2417A20 Slot: 5
	private void System.IDisposable.Dispose() { }

	// RVA: 0x2417A30 Offset: 0x2417B31 VA: 0x2417A30 Slot: 6
	private bool MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x2C86A0 Offset: 0x2C87A1 VA: 0x2C86A0
	// RVA: 0x2417CB0 Offset: 0x2417DB1 VA: 0x2417CB0 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHiddenAttribute] // RVA: 0x2C86B0 Offset: 0x2C87B1 VA: 0x2C86B0
	// RVA: 0x2417CC0 Offset: 0x2417DC1 VA: 0x2417CC0 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHiddenAttribute] // RVA: 0x2C86C0 Offset: 0x2C87C1 VA: 0x2C86C0
	// RVA: 0x2417D00 Offset: 0x2417E01 VA: 0x2417D00 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }
}

// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x278500 Offset: 0x278601 VA: 0x278500
private sealed class MapSequenceBattle.<BattleSkillAfter>d__48 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 12383
{
	// Fields
	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public MapSequenceBattle <>4__this; // 0x20
	private MapSequenceBattle.BattleUnitScope <>7__wrap1; // 0x28
	private BattleInfoEnum <>7__wrap2; // 0x30
	private BattleInfoSide <side>5__4; // 0x48
	private List.Enumerator<SkillData> <>7__wrap4; // 0x50
	private SkillData <skill>5__6; // 0x68
	private MapSkill.SkillCalculator <calculator>5__7; // 0x70

	// Properties
	private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHiddenAttribute] // RVA: 0x2C86D0 Offset: 0x2C87D1 VA: 0x2C86D0
	// RVA: 0x24142A0 Offset: 0x24143A1 VA: 0x24142A0
	public void .ctor(int <>1__state) { }

	[DebuggerHiddenAttribute] // RVA: 0x2C86E0 Offset: 0x2C87E1 VA: 0x2C86E0
	// RVA: 0x24142D0 Offset: 0x24143D1 VA: 0x24142D0 Slot: 5
	private void System.IDisposable.Dispose() { }

	// RVA: 0x2414510 Offset: 0x2414611 VA: 0x2414510 Slot: 6
	private bool MoveNext() { }

	// RVA: 0x2414500 Offset: 0x2414601 VA: 0x2414500
	private void <>m__Finally1() { }

	// RVA: 0x24144E0 Offset: 0x24145E1 VA: 0x24144E0
	private void <>m__Finally2() { }

	// RVA: 0x2414480 Offset: 0x2414581 VA: 0x2414480
	private void <>m__Finally3() { }

	// RVA: 0x2414460 Offset: 0x2414561 VA: 0x2414460
	private void <>m__Finally4() { }

	[DebuggerHiddenAttribute] // RVA: 0x2C86F0 Offset: 0x2C87F1 VA: 0x2C86F0
	// RVA: 0x24154C0 Offset: 0x24155C1 VA: 0x24154C0 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHiddenAttribute] // RVA: 0x2C8700 Offset: 0x2C8801 VA: 0x2C8700
	// RVA: 0x24154D0 Offset: 0x24155D1 VA: 0x24154D0 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHiddenAttribute] // RVA: 0x2C8710 Offset: 0x2C8811 VA: 0x2C8710
	// RVA: 0x2415510 Offset: 0x2415611 VA: 0x2415510 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }
}

// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x278510 Offset: 0x278611 VA: 0x278510
private sealed class MapSequenceBattle.<BattleSkillAround>d__50 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 12384
{
	// Fields
	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public MapSequenceBattle <>4__this; // 0x20
	private MapSequenceBattle.BattleUnitScope <>7__wrap1; // 0x28
	private BattleInfoEnum <>7__wrap2; // 0x30
	private BattleInfoSide <side>5__4; // 0x48
	private MapSkill.AroundCalculator <calculator>5__5; // 0x50
	private List.Enumerator<MapSkill.AroundCalculator.Result> <>7__wrap5; // 0x60
	private MapSkill.AroundCalculator.Result <result>5__7; // 0x80
	private SkillData <skill>5__8; // 0x90

	// Properties
	private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHiddenAttribute] // RVA: 0x2C8720 Offset: 0x2C8821 VA: 0x2C8720
	// RVA: 0x2415520 Offset: 0x2415621 VA: 0x2415520
	public void .ctor(int <>1__state) { }

	[DebuggerHiddenAttribute] // RVA: 0x2C8730 Offset: 0x2C8831 VA: 0x2C8730
	// RVA: 0x2415550 Offset: 0x2415651 VA: 0x2415550 Slot: 5
	private void System.IDisposable.Dispose() { }

	// RVA: 0x2415790 Offset: 0x2415891 VA: 0x2415790 Slot: 6
	private bool MoveNext() { }

	// RVA: 0x2415780 Offset: 0x2415881 VA: 0x2415780
	private void <>m__Finally1() { }

	// RVA: 0x2415760 Offset: 0x2415861 VA: 0x2415760
	private void <>m__Finally2() { }

	// RVA: 0x2415740 Offset: 0x2415841 VA: 0x2415740
	private void <>m__Finally3() { }

	// RVA: 0x24156E0 Offset: 0x24157E1 VA: 0x24156E0
	private void <>m__Finally4() { }

	[DebuggerHiddenAttribute] // RVA: 0x2C8740 Offset: 0x2C8841 VA: 0x2C8740
	// RVA: 0x2416510 Offset: 0x2416611 VA: 0x2416510 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHiddenAttribute] // RVA: 0x2C8750 Offset: 0x2C8851 VA: 0x2C8750
	// RVA: 0x2416520 Offset: 0x2416621 VA: 0x2416520 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHiddenAttribute] // RVA: 0x2C8760 Offset: 0x2C8861 VA: 0x2C8760
	// RVA: 0x2416560 Offset: 0x2416661 VA: 0x2416560 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }
}

// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x278520 Offset: 0x278621 VA: 0x278520
private sealed class MapSequenceBattle.<>c__DisplayClass62_0 // TypeDefIndex: 12385
{
	// Fields
	public MapSequenceBattle <>4__this; // 0x10
	public BattleInfoSide offense; // 0x18

	// Methods

	// RVA: 0x2414210 Offset: 0x2414311 VA: 0x2414210
	public void .ctor() { }

	// RVA: 0x2414220 Offset: 0x2414321 VA: 0x2414220
	internal void <UseRod>b__0(int x, int z, int r) { }
}

// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x278530 Offset: 0x278631 VA: 0x278530
private sealed class MapSequenceBattle.<EngageTurnRecovery>d__68 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 12386
{
	// Fields
	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public MapSequenceBattle <>4__this; // 0x20

	// Properties
	private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHiddenAttribute] // RVA: 0x2C8770 Offset: 0x2C8871 VA: 0x2C8770
	// RVA: 0x2417610 Offset: 0x2417711 VA: 0x2417610
	public void .ctor(int <>1__state) { }

	[DebuggerHiddenAttribute] // RVA: 0x2C8780 Offset: 0x2C8881 VA: 0x2C8780
	// RVA: 0x2417640 Offset: 0x2417741 VA: 0x2417640 Slot: 5
	private void System.IDisposable.Dispose() { }

	// RVA: 0x2417650 Offset: 0x2417751 VA: 0x2417650 Slot: 6
	private bool MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x2C8790 Offset: 0x2C8891 VA: 0x2C8790
	// RVA: 0x24177E0 Offset: 0x24178E1 VA: 0x24177E0 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHiddenAttribute] // RVA: 0x2C87A0 Offset: 0x2C88A1 VA: 0x2C87A0
	// RVA: 0x24177F0 Offset: 0x24178F1 VA: 0x24177F0 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHiddenAttribute] // RVA: 0x2C87B0 Offset: 0x2C88B1 VA: 0x2C87B0
	// RVA: 0x2417830 Offset: 0x2417931 VA: 0x2417830 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }
}

// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x278540 Offset: 0x278641 VA: 0x278540
private sealed class MapSequenceBattle.<HpStockCreate>d__69 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 12387
{
	// Fields
	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public MapSequenceBattle <>4__this; // 0x20

	// Properties
	private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHiddenAttribute] // RVA: 0x2C87C0 Offset: 0x2C88C1 VA: 0x2C87C0
	// RVA: 0x2417840 Offset: 0x2417941 VA: 0x2417840
	public void .ctor(int <>1__state) { }

	[DebuggerHiddenAttribute] // RVA: 0x2C87D0 Offset: 0x2C88D1 VA: 0x2C87D0
	// RVA: 0x2417870 Offset: 0x2417971 VA: 0x2417870 Slot: 5
	private void System.IDisposable.Dispose() { }

	// RVA: 0x2417880 Offset: 0x2417981 VA: 0x2417880 Slot: 6
	private bool MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x2C87E0 Offset: 0x2C88E1 VA: 0x2C87E0
	// RVA: 0x2417990 Offset: 0x2417A91 VA: 0x2417990 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHiddenAttribute] // RVA: 0x2C87F0 Offset: 0x2C88F1 VA: 0x2C87F0
	// RVA: 0x24179A0 Offset: 0x2417AA1 VA: 0x24179A0 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHiddenAttribute] // RVA: 0x2C8800 Offset: 0x2C8901 VA: 0x2C8800
	// RVA: 0x24179E0 Offset: 0x2417AE1 VA: 0x24179E0 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }
}

// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x278550 Offset: 0x278651 VA: 0x278550
private sealed class MapSequenceBattle.<DropItem>d__79 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 12388
{
	// Fields
	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public MapSequenceBattle <>4__this; // 0x20
	private List.Enumerator<Unit> <>7__wrap1; // 0x28
	private Unit <dead>5__3; // 0x40
	private Unit <winner>5__4; // 0x48
	private int <i>5__5; // 0x50

	// Properties
	private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHiddenAttribute] // RVA: 0x2C8810 Offset: 0x2C8911 VA: 0x2C8810
	// RVA: 0x2417030 Offset: 0x2417131 VA: 0x2417030
	public void .ctor(int <>1__state) { }

	[DebuggerHiddenAttribute] // RVA: 0x2C8820 Offset: 0x2C8921 VA: 0x2C8820
	// RVA: 0x2417060 Offset: 0x2417161 VA: 0x2417060 Slot: 5
	private void System.IDisposable.Dispose() { }

	// RVA: 0x2417140 Offset: 0x2417241 VA: 0x2417140 Slot: 6
	private bool MoveNext() { }

	// RVA: 0x24170E0 Offset: 0x24171E1 VA: 0x24170E0
	private void <>m__Finally1() { }

	[DebuggerHiddenAttribute] // RVA: 0x2C8830 Offset: 0x2C8931 VA: 0x2C8830
	// RVA: 0x24175B0 Offset: 0x24176B1 VA: 0x24175B0 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHiddenAttribute] // RVA: 0x2C8840 Offset: 0x2C8941 VA: 0x2C8840
	// RVA: 0x24175C0 Offset: 0x24176C1 VA: 0x24175C0 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHiddenAttribute] // RVA: 0x2C8850 Offset: 0x2C8951 VA: 0x2C8850
	// RVA: 0x2417600 Offset: 0x2417701 VA: 0x2417600 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }
}

// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x278560 Offset: 0x278661 VA: 0x278560
private sealed class MapSequenceBattle.<Die>d__87 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 12389
{
	// Fields
	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public MapSequenceBattle <>4__this; // 0x20
	private List.Enumerator<Unit> <>7__wrap1; // 0x28
	private Unit <dead>5__3; // 0x40

	// Properties
	private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHiddenAttribute] // RVA: 0x2C8860 Offset: 0x2C8961 VA: 0x2C8860
	// RVA: 0x2416570 Offset: 0x2416671 VA: 0x2416570
	public void .ctor(int <>1__state) { }

	[DebuggerHiddenAttribute] // RVA: 0x2C8870 Offset: 0x2C8971 VA: 0x2C8870
	// RVA: 0x24165A0 Offset: 0x24166A1 VA: 0x24165A0 Slot: 5
	private void System.IDisposable.Dispose() { }

	// RVA: 0x2416690 Offset: 0x2416791 VA: 0x2416690 Slot: 6
	private bool MoveNext() { }

	// RVA: 0x2416630 Offset: 0x2416731 VA: 0x2416630
	private void <>m__Finally1() { }

	[DebuggerHiddenAttribute] // RVA: 0x2C8880 Offset: 0x2C8981 VA: 0x2C8880
	// RVA: 0x2416FD0 Offset: 0x24170D1 VA: 0x2416FD0 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHiddenAttribute] // RVA: 0x2C8890 Offset: 0x2C8991 VA: 0x2C8890
	// RVA: 0x2416FE0 Offset: 0x24170E1 VA: 0x2416FE0 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHiddenAttribute] // RVA: 0x2C88A0 Offset: 0x2C89A1 VA: 0x2C88A0
	// RVA: 0x2417020 Offset: 0x2417121 VA: 0x2417020 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }
}

