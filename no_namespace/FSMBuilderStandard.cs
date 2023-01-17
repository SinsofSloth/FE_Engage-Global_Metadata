// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x2735D0 Offset: 0x2736D1 VA: 0x2735D0
[Serializable]
private sealed class FSMBuilderStandard.<>c // TypeDefIndex: 8484
{
	// Fields
	public static readonly FSMBuilderStandard.<>c <>9; // 0x0
	public static Func<Character, bool> <>9__0_0; // 0x8
	public static Action <>9__0_1; // 0x10
	public static Action <>9__1_0; // 0x18
	public static Action<Unit> <>9__4_2; // 0x20
	public static Action<Character> <>9__4_0; // 0x28
	public static Action <>9__5_0; // 0x30
	public static Action<Character> <>9__7_0; // 0x38
	public static Func<Character, bool> <>9__8_1; // 0x40
	public static Action <>9__18_2; // 0x48

	// Methods

	// RVA: 0x22D7220 Offset: 0x22D7321 VA: 0x22D7220
	private static void .cctor() { }

	// RVA: 0x22D7290 Offset: 0x22D7391 VA: 0x22D7290
	public void .ctor() { }

	// RVA: 0x22D72A0 Offset: 0x22D73A1 VA: 0x22D72A0
	internal bool <BuildEnd>b__0_0(Character _) { }

	// RVA: 0x22D7320 Offset: 0x22D7421 VA: 0x22D7320
	internal void <BuildEnd>b__0_1() { }

	// RVA: 0x22D7410 Offset: 0x22D7511 VA: 0x22D7410
	internal void <BuildEnd_BothAlive>b__1_0() { }

	// RVA: 0x22D7850 Offset: 0x22D7951 VA: 0x22D7850
	internal void <BuildEnd_EnemyKilled>b__4_0(Character pl) { }

	// RVA: 0x22D7DD0 Offset: 0x22D7ED1 VA: 0x22D7DD0
	internal void <BuildEnd_EnemyKilled>b__4_2(Unit _) { }

	// RVA: 0x22D7F20 Offset: 0x22D8021 VA: 0x22D7F20
	internal void <BuildMain>b__5_0() { }

	// RVA: 0x22D7F90 Offset: 0x22D8091 VA: 0x22D7F90
	internal void <BuildStart>b__7_0(Character x) { }

	// RVA: 0x22D7FA0 Offset: 0x22D80A1 VA: 0x22D7FA0
	internal bool <Start_Training>b__8_1(Character _) { }

	// RVA: 0x22D8020 Offset: 0x22D8121 VA: 0x22D8020
	internal void <BuildChainFSM>b__18_2() { }
}

// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x2735F0 Offset: 0x2736F1 VA: 0x2735F0
private sealed class FSMBuilderStandard.<>c__DisplayClass2_0 // TypeDefIndex: 8486
{
	// Fields
	public Character eg; // 0x10

	// Methods

	// RVA: 0x22D8B40 Offset: 0x22D8C41 VA: 0x22D8B40
	public void .ctor() { }

	// RVA: 0x22D8B50 Offset: 0x22D8C51 VA: 0x22D8B50
	internal void <BuildEnd_PlayerKilled>b__0() { }
}

// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x273610 Offset: 0x273711 VA: 0x273610
private struct FSMBuilderStandard.<>c__DisplayClass8_0 // TypeDefIndex: 8488
{
	// Fields
	public float startRate; // 0x0
}

// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x273630 Offset: 0x273731 VA: 0x273630
private sealed class FSMBuilderStandard.<>c__DisplayClass17_0 // TypeDefIndex: 8490
{
	// Fields
	public int chainNum; // 0x10
	public int nextSide; // 0x14
	public FSMBuilderStandard <>4__this; // 0x18
	public Phase nextPhase; // 0x20
	public Character defence; // 0x28
	public Character attack; // 0x30

	// Methods

	// RVA: 0x22D80A0 Offset: 0x22D81A1 VA: 0x22D80A0
	public void .ctor() { }

	// RVA: 0x22D80B0 Offset: 0x22D81B1 VA: 0x22D80B0
	internal void <BuildChainAttackPhase>b__5() { }
}

// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x273650 Offset: 0x273751 VA: 0x273650
private sealed class FSMBuilderStandard.<>c__DisplayClass18_0 // TypeDefIndex: 8492
{
	// Fields
	public Character chain; // 0x10
	public Phase phase; // 0x18
	public int chainNum; // 0x20
	public Action<Unit> <>9__5; // 0x28

	// Methods

	// RVA: 0x22D8500 Offset: 0x22D8601 VA: 0x22D8500
	public void .ctor() { }

	// RVA: 0x22D8510 Offset: 0x22D8611 VA: 0x22D8510
	internal void <BuildChainFSM>b__0() { }

	// RVA: 0x22D8580 Offset: 0x22D8681 VA: 0x22D8580
	internal void <BuildChainFSM>b__1() { }

	// RVA: 0x22D8860 Offset: 0x22D8961 VA: 0x22D8860
	internal void <BuildChainFSM>b__3() { }

	// RVA: 0x22D8970 Offset: 0x22D8A71 VA: 0x22D8970
	internal void <BuildChainFSM>b__5(Unit _) { }
}

