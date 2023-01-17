// Namespace: 
private class MapSequenceMind.ProcMindBase : ProcInst // TypeDefIndex: 12428
{
	// Methods

	// RVA: 0x2137F50 Offset: 0x2138051 VA: 0x2137F50 Slot: 6
	protected override void OnTick() { }

	// RVA: 0x2137D40 Offset: 0x2137E41 VA: 0x2137D40
	public void .ctor() { }
}

// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x278600 Offset: 0x278701 VA: 0x278600
[Serializable]
private sealed class MapSequenceMind.<>c // TypeDefIndex: 12430
{
	// Fields
	public static readonly MapSequenceMind.<>c <>9; // 0x0
	public static MapSkill.UnitFunc <>9__13_0; // 0x8
	public static MapSkill.UnitFunc <>9__13_1; // 0x10
	public static MapSkill.TerrainFunc <>9__13_2; // 0x18
	public static Action<Unit> <>9__13_3; // 0x20
	public static Action<Unit, int, int> <>9__13_4; // 0x28

	// Methods

	// RVA: 0x2135AA0 Offset: 0x2135BA1 VA: 0x2135AA0
	private static void .cctor() { }

	// RVA: 0x2135B10 Offset: 0x2135C11 VA: 0x2135B10
	public void .ctor() { }

	// RVA: 0x2135B20 Offset: 0x2135C21 VA: 0x2135B20
	internal void <MultiTarget>b__13_0(int x, int z, Unit target) { }

	// RVA: 0x2135BD0 Offset: 0x2135CD1 VA: 0x2135BD0
	internal void <MultiTarget>b__13_1(int x, int z, Unit target) { }

	// RVA: 0x2135C80 Offset: 0x2135D81 VA: 0x2135C80
	internal void <MultiTarget>b__13_2(int x, int z, TerrainData terrain) { }

	// RVA: 0x2135D30 Offset: 0x2135E31 VA: 0x2135D30
	internal void <MultiTarget>b__13_3(Unit target) { }

	// RVA: 0x2135DC0 Offset: 0x2135EC1 VA: 0x2135DC0
	internal void <MultiTarget>b__13_4(Unit target, int x, int z) { }
}

// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x278620 Offset: 0x278721 VA: 0x278620
private sealed class MapSequenceMind.<FixedSkill>d__42 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 12432
{
	// Fields
	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public MapSequenceMind <>4__this; // 0x20
	private Unit <unit>5__2; // 0x28
	private List.Enumerator<SkillData> <>7__wrap2; // 0x30
	private SkillData <skill>5__4; // 0x48
	private MapSkill.FixedCalculator <calculator>5__5; // 0x50

	// Properties
	private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHiddenAttribute] // RVA: 0x2C8E60 Offset: 0x2C8F61 VA: 0x2C8E60
	// RVA: 0x2136260 Offset: 0x2136361 VA: 0x2136260
	public void .ctor(int <>1__state) { }

	[DebuggerHiddenAttribute] // RVA: 0x2C8E70 Offset: 0x2C8F71 VA: 0x2C8E70
	// RVA: 0x2136290 Offset: 0x2136391 VA: 0x2136290 Slot: 5
	private void System.IDisposable.Dispose() { }

	// RVA: 0x2136440 Offset: 0x2136541 VA: 0x2136440 Slot: 6
	private bool MoveNext() { }

	// RVA: 0x21363E0 Offset: 0x21364E1 VA: 0x21363E0
	private void <>m__Finally1() { }

	// RVA: 0x2136380 Offset: 0x2136481 VA: 0x2136380
	private void <>m__Finally2() { }

	[DebuggerHiddenAttribute] // RVA: 0x2C8E80 Offset: 0x2C8F81 VA: 0x2C8E80
	// RVA: 0x2137B60 Offset: 0x2137C61 VA: 0x2137B60 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHiddenAttribute] // RVA: 0x2C8E90 Offset: 0x2C8F91 VA: 0x2C8E90
	// RVA: 0x2137B70 Offset: 0x2137C71 VA: 0x2137B70 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHiddenAttribute] // RVA: 0x2C8EA0 Offset: 0x2C8FA1 VA: 0x2C8EA0
	// RVA: 0x2137BB0 Offset: 0x2137CB1 VA: 0x2137BB0 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }
}

