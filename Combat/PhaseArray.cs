// Namespace: Combat
public sealed class PhaseArray : List<Phase> // TypeDefIndex: 8503
{
	// Fields
	private int m_CurrentIndex; // 0x28
	[CompilerGeneratedAttribute] // RVA: 0x27FE90 Offset: 0x27FF91 VA: 0x27FE90
	private int <AttackRight>k__BackingField; // 0x2C

	// Properties
	public Phase Current { get; }
	public Phase Last { get; }
	public int AttackRight { get; set; }
	public bool HasCounter { get; }

	// Methods

	// RVA: 0x236C930 Offset: 0x236CA31 VA: 0x236C930
	public Phase get_Current() { }

	// RVA: 0x236CAB0 Offset: 0x236CBB1 VA: 0x236CAB0
	public Phase get_Last() { }

	[CompilerGeneratedAttribute] // RVA: 0x2A8AC0 Offset: 0x2A8BC1 VA: 0x2A8AC0
	// RVA: 0x236CBE0 Offset: 0x236CCE1 VA: 0x236CBE0
	public int get_AttackRight() { }

	[CompilerGeneratedAttribute] // RVA: 0x2A8AD0 Offset: 0x2A8BD1 VA: 0x2A8AD0
	// RVA: 0x236CBF0 Offset: 0x236CCF1 VA: 0x236CBF0
	private void set_AttackRight(int value) { }

	// RVA: 0x236CC00 Offset: 0x236CD01 VA: 0x236CC00
	public bool get_HasCounter() { }

	// RVA: 0x236CD30 Offset: 0x236CE31 VA: 0x236CD30
	public void Add(Phase phase) { }

	// RVA: 0x236CDF0 Offset: 0x236CEF1 VA: 0x236CDF0
	public void Next() { }

	// RVA: 0x236CE90 Offset: 0x236CF91 VA: 0x236CE90
	public void SetCurrentToLast() { }

	// RVA: 0x236CEE0 Offset: 0x236CFE1 VA: 0x236CEE0
	public void .ctor() { }

	// RVA: 0x236CFA0 Offset: 0x236D0A1 VA: 0x236CFA0
	public void Clear() { }

	// RVA: 0x236D000 Offset: 0x236D101 VA: 0x236D000
	public void UpdateAttackRight() { }

	// RVA: 0x236D1B0 Offset: 0x236D2B1 VA: 0x236D1B0
	public void PostProcess(CombatStyle style, CharacterGameStatus[] gameStatus, CharacterGameStatus[] gsChainAtk, CharacterGameStatus[] gsDragonic) { }

	// RVA: 0x236EF40 Offset: 0x236F041 VA: 0x236EF40
	public void MarkFirstAndLastAttack() { }

	// RVA: 0x236F0E0 Offset: 0x236F1E1 VA: 0x236F0E0
	public Phase FindDetailFirst(Phase.Detail detail) { }

	// RVA: 0x236D200 Offset: 0x236D301 VA: 0x236D200
	private void DecideAnimationHash(CombatStyle style, CharacterGameStatus[] gameStatus, CharacterGameStatus[] gsChainAtk) { }

	// RVA: 0x236E4B0 Offset: 0x236E5B1 VA: 0x236E4B0
	private void MarkUseAnims(CharacterGameStatus[] gameStatus, CharacterGameStatus[] gsChainAtk, CharacterGameStatus[] gsDragonic) { }

	// RVA: 0x236F240 Offset: 0x236F341 VA: 0x236F240
	private static void RegisterPreloadAnim(PreloadAnims use, CharacterGameStatus gs) { }

	// RVA: 0x236F320 Offset: 0x236F421 VA: 0x236F320
	public int GetBrokenSide() { }
}

