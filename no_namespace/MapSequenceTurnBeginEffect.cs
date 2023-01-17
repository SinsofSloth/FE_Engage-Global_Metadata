// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x278650 Offset: 0x278751 VA: 0x278650
private sealed class MapSequenceTurnBeginEffect.ProcTerrainDamage.<Execute>d__1 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 12458
{
	// Fields
	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public MapSequenceTurnBeginEffect.ProcTerrainDamage <>4__this; // 0x20
	private int <damage>5__2; // 0x28

	// Properties
	private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHiddenAttribute] // RVA: 0x2C8FE0 Offset: 0x2C90E1 VA: 0x2C8FE0
	// RVA: 0x21E8D50 Offset: 0x21E8E51 VA: 0x21E8D50
	public void .ctor(int <>1__state) { }

	[DebuggerHiddenAttribute] // RVA: 0x2C8FF0 Offset: 0x2C90F1 VA: 0x2C8FF0
	// RVA: 0x21E8D80 Offset: 0x21E8E81 VA: 0x21E8D80 Slot: 5
	private void System.IDisposable.Dispose() { }

	// RVA: 0x21E8D90 Offset: 0x21E8E91 VA: 0x21E8D90 Slot: 6
	private bool MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x2C9000 Offset: 0x2C9101 VA: 0x2C9000
	// RVA: 0x21E9000 Offset: 0x21E9101 VA: 0x21E9000 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHiddenAttribute] // RVA: 0x2C9010 Offset: 0x2C9111 VA: 0x2C9010
	// RVA: 0x21E9010 Offset: 0x21E9111 VA: 0x21E9010 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHiddenAttribute] // RVA: 0x2C9020 Offset: 0x2C9121 VA: 0x2C9020
	// RVA: 0x21E9050 Offset: 0x21E9151 VA: 0x21E9050 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }
}

// Namespace: 
private class MapSequenceTurnBeginEffect.ProcTerrainDamage : TurnEffect // TypeDefIndex: 12459
{
	// Methods

	// RVA: 0x2139780 Offset: 0x2139881 VA: 0x2139780
	private static int GetDamage(Unit unit, TerrainData terrain) { }

	[IteratorStateMachineAttribute] // RVA: 0x2C8F70 Offset: 0x2C9071 VA: 0x2C8F70
	// RVA: 0x21398C0 Offset: 0x21399C1 VA: 0x21398C0 Slot: 18
	protected override IEnumerator Execute() { }

	// RVA: 0x2139940 Offset: 0x2139A41 VA: 0x2139940
	public void .ctor() { }
}

// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x278660 Offset: 0x278761 VA: 0x278660
private sealed class MapSequenceTurnBeginEffect.ProcSkillHeal.<Execute>d__0 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 12460
{
	// Fields
	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public MapSequenceTurnBeginEffect.ProcSkillHeal <>4__this; // 0x20
	private Unit <unit>5__2; // 0x28
	private SkillArray.Enumerator <>7__wrap2; // 0x30
	private SkillData <skill>5__4; // 0x48

	// Properties
	private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHiddenAttribute] // RVA: 0x2C90A0 Offset: 0x2C91A1 VA: 0x2C90A0
	// RVA: 0x21E81B0 Offset: 0x21E82B1 VA: 0x21E81B0
	public void .ctor(int <>1__state) { }

	[DebuggerHiddenAttribute] // RVA: 0x2C90B0 Offset: 0x2C91B1 VA: 0x2C90B0
	// RVA: 0x21E81E0 Offset: 0x21E82E1 VA: 0x21E81E0 Slot: 5
	private void System.IDisposable.Dispose() { }

	// RVA: 0x21E8240 Offset: 0x21E8341 VA: 0x21E8240 Slot: 6
	private bool MoveNext() { }

	// RVA: 0x21E8220 Offset: 0x21E8321 VA: 0x21E8220
	private void <>m__Finally1() { }

	[DebuggerHiddenAttribute] // RVA: 0x2C90C0 Offset: 0x2C91C1 VA: 0x2C90C0
	// RVA: 0x21E8670 Offset: 0x21E8771 VA: 0x21E8670 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHiddenAttribute] // RVA: 0x2C90D0 Offset: 0x2C91D1 VA: 0x2C90D0
	// RVA: 0x21E8680 Offset: 0x21E8781 VA: 0x21E8680 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHiddenAttribute] // RVA: 0x2C90E0 Offset: 0x2C91E1 VA: 0x2C90E0
	// RVA: 0x21E86C0 Offset: 0x21E87C1 VA: 0x21E86C0 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }
}

// Namespace: 
private class MapSequenceTurnBeginEffect.ProcSkillHeal : TurnEffect // TypeDefIndex: 12461
{
	// Methods

	[IteratorStateMachineAttribute] // RVA: 0x2C9030 Offset: 0x2C9131 VA: 0x2C9030
	// RVA: 0x2139660 Offset: 0x2139761 VA: 0x2139660 Slot: 18
	protected override IEnumerator Execute() { }

	// RVA: 0x21396E0 Offset: 0x21397E1 VA: 0x21396E0
	public void .ctor() { }
}

// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x278670 Offset: 0x278771 VA: 0x278670
private sealed class MapSequenceTurnBeginEffect.ProcTerrainHeal.<Execute>d__1 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 12462
{
	// Fields
	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public MapSequenceTurnBeginEffect.ProcTerrainHeal <>4__this; // 0x20
	private int <heal>5__2; // 0x28

	// Properties
	private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHiddenAttribute] // RVA: 0x2C9160 Offset: 0x2C9261 VA: 0x2C9160
	// RVA: 0x21E9060 Offset: 0x21E9161 VA: 0x21E9060
	public void .ctor(int <>1__state) { }

	[DebuggerHiddenAttribute] // RVA: 0x2C9170 Offset: 0x2C9271 VA: 0x2C9170
	// RVA: 0x21E9090 Offset: 0x21E9191 VA: 0x21E9090 Slot: 5
	private void System.IDisposable.Dispose() { }

	// RVA: 0x21E90A0 Offset: 0x21E91A1 VA: 0x21E90A0 Slot: 6
	private bool MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x2C9180 Offset: 0x2C9281 VA: 0x2C9180
	// RVA: 0x21E9470 Offset: 0x21E9571 VA: 0x21E9470 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHiddenAttribute] // RVA: 0x2C9190 Offset: 0x2C9291 VA: 0x2C9190
	// RVA: 0x21E9480 Offset: 0x21E9581 VA: 0x21E9480 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHiddenAttribute] // RVA: 0x2C91A0 Offset: 0x2C92A1 VA: 0x2C91A0
	// RVA: 0x21E94C0 Offset: 0x21E95C1 VA: 0x21E94C0 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }
}

// Namespace: 
private class MapSequenceTurnBeginEffect.ProcTerrainHeal : TurnEffect // TypeDefIndex: 12463
{
	// Methods

	// RVA: 0x2139950 Offset: 0x2139A51 VA: 0x2139950
	private static int GetHeal(Unit unit, TerrainData terrain) { }

	[IteratorStateMachineAttribute] // RVA: 0x2C90F0 Offset: 0x2C91F1 VA: 0x2C90F0
	// RVA: 0x21399E0 Offset: 0x2139AE1 VA: 0x21399E0 Slot: 18
	protected override IEnumerator Execute() { }

	// RVA: 0x2139A60 Offset: 0x2139B61 VA: 0x2139A60
	public void .ctor() { }
}

// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x278680 Offset: 0x278781 VA: 0x278680
[Serializable]
private sealed class MapSequenceTurnBeginEffect.ProcEngageSkill.<>c // TypeDefIndex: 12464
{
	// Fields
	public static readonly MapSequenceTurnBeginEffect.ProcEngageSkill.<>c <>9; // 0x0
	public static MapSkill.UnitFunc <>9__0_0; // 0x8
	public static MapSkill.TerrainFunc <>9__0_1; // 0x10

	// Methods

	// RVA: 0x21E7010 Offset: 0x21E7111 VA: 0x21E7010
	private static void .cctor() { }

	// RVA: 0x21E7080 Offset: 0x21E7181 VA: 0x21E7080
	public void .ctor() { }

	// RVA: 0x21E7090 Offset: 0x21E7191 VA: 0x21E7090
	internal void <Execute>b__0_0(int x, int z, Unit target) { }

	// RVA: 0x21E7140 Offset: 0x21E7241 VA: 0x21E7140
	internal void <Execute>b__0_1(int x, int z, TerrainData terrain) { }
}

// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x278690 Offset: 0x278791 VA: 0x278690
private sealed class MapSequenceTurnBeginEffect.ProcEngageSkill.<Execute>d__0 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 12465
{
	// Fields
	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public MapSequenceTurnBeginEffect.ProcEngageSkill <>4__this; // 0x20
	private Unit <unit>5__2; // 0x28

	// Properties
	private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHiddenAttribute] // RVA: 0x2C9220 Offset: 0x2C9321 VA: 0x2C9220
	// RVA: 0x21E71F0 Offset: 0x21E72F1 VA: 0x21E71F0
	public void .ctor(int <>1__state) { }

	[DebuggerHiddenAttribute] // RVA: 0x2C9230 Offset: 0x2C9331 VA: 0x2C9230
	// RVA: 0x21E7220 Offset: 0x21E7321 VA: 0x21E7220 Slot: 5
	private void System.IDisposable.Dispose() { }

	// RVA: 0x21E7230 Offset: 0x21E7331 VA: 0x21E7230 Slot: 6
	private bool MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x2C9240 Offset: 0x2C9341 VA: 0x2C9240
	// RVA: 0x21E7A60 Offset: 0x21E7B61 VA: 0x21E7A60 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHiddenAttribute] // RVA: 0x2C9250 Offset: 0x2C9351 VA: 0x2C9250
	// RVA: 0x21E7A70 Offset: 0x21E7B71 VA: 0x21E7A70 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHiddenAttribute] // RVA: 0x2C9260 Offset: 0x2C9361 VA: 0x2C9260
	// RVA: 0x21E7AB0 Offset: 0x21E7BB1 VA: 0x21E7AB0 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }
}

// Namespace: 
private class MapSequenceTurnBeginEffect.ProcEngageSkill : TurnEffect // TypeDefIndex: 12466
{
	// Methods

	[IteratorStateMachineAttribute] // RVA: 0x2C91B0 Offset: 0x2C92B1 VA: 0x2C91B0
	// RVA: 0x2139540 Offset: 0x2139641 VA: 0x2139540 Slot: 18
	protected override IEnumerator Execute() { }

	// RVA: 0x21395C0 Offset: 0x21396C1 VA: 0x21395C0
	public void .ctor() { }
}

// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x2786A0 Offset: 0x2787A1 VA: 0x2786A0
private sealed class MapSequenceTurnBeginEffect.ProcSkillTurn.<Execute>d__0 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 12467
{
	// Fields
	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public MapSequenceTurnBeginEffect.ProcSkillTurn <>4__this; // 0x20
	private Unit <unit>5__2; // 0x28
	private List.Enumerator<SkillData> <>7__wrap2; // 0x30
	private SkillData <skill>5__4; // 0x48
	private MapSkill.SkillCalculator <calculator>5__5; // 0x50

	// Properties
	private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHiddenAttribute] // RVA: 0x2C92E0 Offset: 0x2C93E1 VA: 0x2C92E0
	// RVA: 0x21E86D0 Offset: 0x21E87D1 VA: 0x21E86D0
	public void .ctor(int <>1__state) { }

	[DebuggerHiddenAttribute] // RVA: 0x2C92F0 Offset: 0x2C93F1 VA: 0x2C92F0
	// RVA: 0x21E8700 Offset: 0x21E8801 VA: 0x21E8700 Slot: 5
	private void System.IDisposable.Dispose() { }

	// RVA: 0x21E8850 Offset: 0x21E8951 VA: 0x21E8850 Slot: 6
	private bool MoveNext() { }

	// RVA: 0x21E87F0 Offset: 0x21E88F1 VA: 0x21E87F0
	private void <>m__Finally1() { }

	// RVA: 0x21E87D0 Offset: 0x21E88D1 VA: 0x21E87D0
	private void <>m__Finally2() { }

	[DebuggerHiddenAttribute] // RVA: 0x2C9300 Offset: 0x2C9401 VA: 0x2C9300
	// RVA: 0x21E8CF0 Offset: 0x21E8DF1 VA: 0x21E8CF0 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHiddenAttribute] // RVA: 0x2C9310 Offset: 0x2C9411 VA: 0x2C9310
	// RVA: 0x21E8D00 Offset: 0x21E8E01 VA: 0x21E8D00 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHiddenAttribute] // RVA: 0x2C9320 Offset: 0x2C9421 VA: 0x2C9320
	// RVA: 0x21E8D40 Offset: 0x21E8E41 VA: 0x21E8D40 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }
}

// Namespace: 
private class MapSequenceTurnBeginEffect.ProcSkillTurn : TurnEffect // TypeDefIndex: 12468
{
	// Methods

	[IteratorStateMachineAttribute] // RVA: 0x2C9270 Offset: 0x2C9371 VA: 0x2C9270
	// RVA: 0x21396F0 Offset: 0x21397F1 VA: 0x21396F0 Slot: 18
	protected override IEnumerator Execute() { }

	// RVA: 0x2139770 Offset: 0x2139871 VA: 0x2139770
	public void .ctor() { }
}

// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x2786B0 Offset: 0x2787B1 VA: 0x2786B0
[Serializable]
private sealed class MapSequenceTurnBeginEffect.ProcFullBulletAttack.<>c // TypeDefIndex: 12469
{
	// Fields
	public static readonly MapSequenceTurnBeginEffect.ProcFullBulletAttack.<>c <>9; // 0x0
	public static MapSkill.UnitFunc <>9__0_0; // 0x8

	// Methods

	// RVA: 0x21E7AC0 Offset: 0x21E7BC1 VA: 0x21E7AC0
	private static void .cctor() { }

	// RVA: 0x21E7B30 Offset: 0x21E7C31 VA: 0x21E7B30
	public void .ctor() { }

	// RVA: 0x21E7B40 Offset: 0x21E7C41 VA: 0x21E7B40
	internal void <Execute>b__0_0(int x, int z, Unit target) { }
}

// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x2786C0 Offset: 0x2787C1 VA: 0x2786C0
private sealed class MapSequenceTurnBeginEffect.ProcFullBulletAttack.<Execute>d__0 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 12470
{
	// Fields
	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public MapSequenceTurnBeginEffect.ProcFullBulletAttack <>4__this; // 0x20

	// Properties
	private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHiddenAttribute] // RVA: 0x2C93A0 Offset: 0x2C94A1 VA: 0x2C93A0
	// RVA: 0x21E7BF0 Offset: 0x21E7CF1 VA: 0x21E7BF0
	public void .ctor(int <>1__state) { }

	[DebuggerHiddenAttribute] // RVA: 0x2C93B0 Offset: 0x2C94B1 VA: 0x2C93B0
	// RVA: 0x21E7C20 Offset: 0x21E7D21 VA: 0x21E7C20 Slot: 5
	private void System.IDisposable.Dispose() { }

	// RVA: 0x21E7C30 Offset: 0x21E7D31 VA: 0x21E7C30 Slot: 6
	private bool MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x2C93C0 Offset: 0x2C94C1 VA: 0x2C93C0
	// RVA: 0x21E8150 Offset: 0x21E8251 VA: 0x21E8150 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHiddenAttribute] // RVA: 0x2C93D0 Offset: 0x2C94D1 VA: 0x2C93D0
	// RVA: 0x21E8160 Offset: 0x21E8261 VA: 0x21E8160 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHiddenAttribute] // RVA: 0x2C93E0 Offset: 0x2C94E1 VA: 0x2C93E0
	// RVA: 0x21E81A0 Offset: 0x21E82A1 VA: 0x21E81A0 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }
}

// Namespace: 
private class MapSequenceTurnBeginEffect.ProcFullBulletAttack : TurnEffect // TypeDefIndex: 12471
{
	// Methods

	[IteratorStateMachineAttribute] // RVA: 0x2C9330 Offset: 0x2C9431 VA: 0x2C9330
	// RVA: 0x21395D0 Offset: 0x21396D1 VA: 0x21395D0 Slot: 18
	protected override IEnumerator Execute() { }

	// RVA: 0x2139650 Offset: 0x2139751 VA: 0x2139650
	public void .ctor() { }
}

