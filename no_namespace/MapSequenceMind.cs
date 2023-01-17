// Namespace: 
private enum MapSequenceMind.Label // TypeDefIndex: 12427
{
	// Fields
	public int value__; // 0x0
	public const MapSequenceMind.Label MoveSkip = 0;
	public const MapSequenceMind.Label AfterAIEngageRewarp = 1;
	public const MapSequenceMind.Label Attack = 2;
	public const MapSequenceMind.Label Rod = 3;
	public const MapSequenceMind.Label ItemUse = 4;
	public const MapSequenceMind.Label Breakdown = 5;
	public const MapSequenceMind.Label BreakdownEnemy = 6;
	public const MapSequenceMind.Label Destroy = 7;
	public const MapSequenceMind.Label Escape = 8;
	public const MapSequenceMind.Label Visit = 9;
	public const MapSequenceMind.Label DestroyVillage = 10;
	public const MapSequenceMind.Label TreasureBox = 11;
	public const MapSequenceMind.Label Door = 12;
	public const MapSequenceMind.Label Torch = 13;
	public const MapSequenceMind.Label Talk = 14;
	public const MapSequenceMind.Label Dance = 15;
	public const MapSequenceMind.Label Guard = 16;
	public const MapSequenceMind.Label FullBullet = 17;
	public const MapSequenceMind.Label Enchant = 18;
	public const MapSequenceMind.Label Contract = 19;
	public const MapSequenceMind.Label EngageCharge = 20;
	public const MapSequenceMind.Label EngageWait = 21;
	public const MapSequenceMind.Label EngageSummon = 22;
	public const MapSequenceMind.Label OverlapSkill = 23;
	public const MapSequenceMind.Label CommandSkill = 24;
	public const MapSequenceMind.Label EventBattle = 25;
	public const MapSequenceMind.Label Fixed = 26;
	public const MapSequenceMind.Label Dead = 27;
	public const MapSequenceMind.Label DeadWithoutEvent = 28;
	public const MapSequenceMind.Label End = 29;
}

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
private class MapSequenceMind.ProcEscape : MapSequenceMind.ProcMindBase // TypeDefIndex: 12429
{
	// Fields
	private Unit m_Unit; // 0x70

	// Methods

	// RVA: 0x2137BC0 Offset: 0x2137CC1 VA: 0x2137BC0
	public static void CreateBind(ProcInst super) { }

	// RVA: 0x2137C30 Offset: 0x2137D31 VA: 0x2137C30
	public void .ctor() { }

	// RVA: 0x2137F40 Offset: 0x2138041 VA: 0x2137F40 Slot: 10
	protected override void OnDispose() { }

	// RVA: 0x2137D50 Offset: 0x2137E51 VA: 0x2137D50
	private Dir.Type GetDir() { }
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
[CompilerGeneratedAttribute] // RVA: 0x278610 Offset: 0x278711 VA: 0x278610
private sealed class MapSequenceMind.<EngageWait>d__34 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 12431
{
	// Fields
	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public MapSequenceMind <>4__this; // 0x20
	private MapMind.Type <mind>5__2; // 0x28
	private Unit <unit>5__3; // 0x30
	private SkillData <skill>5__4; // 0x38

	// Properties
	private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHiddenAttribute] // RVA: 0x2C8E10 Offset: 0x2C8F11 VA: 0x2C8E10
	// RVA: 0x2135E50 Offset: 0x2135F51 VA: 0x2135E50
	public void .ctor(int <>1__state) { }

	[DebuggerHiddenAttribute] // RVA: 0x2C8E20 Offset: 0x2C8F21 VA: 0x2C8E20
	// RVA: 0x2135E80 Offset: 0x2135F81 VA: 0x2135E80 Slot: 5
	private void System.IDisposable.Dispose() { }

	// RVA: 0x2135E90 Offset: 0x2135F91 VA: 0x2135E90 Slot: 6
	private bool MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x2C8E30 Offset: 0x2C8F31 VA: 0x2C8E30
	// RVA: 0x2136200 Offset: 0x2136301 VA: 0x2136200 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHiddenAttribute] // RVA: 0x2C8E40 Offset: 0x2C8F41 VA: 0x2C8E40
	// RVA: 0x2136210 Offset: 0x2136311 VA: 0x2136210 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHiddenAttribute] // RVA: 0x2C8E50 Offset: 0x2C8F51 VA: 0x2C8E50
	// RVA: 0x2136250 Offset: 0x2136351 VA: 0x2136250 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }
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

