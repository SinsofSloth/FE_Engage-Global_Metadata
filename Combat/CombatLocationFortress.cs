// Namespace: Combat
public class CombatLocationFortress : BaseCombatLocation // TypeDefIndex: 8760
{
	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x284260 Offset: 0x284361 VA: 0x284260
	private int <HighSide>k__BackingField; // 0x8C
	[CompilerGeneratedAttribute] // RVA: 0x284270 Offset: 0x284371 VA: 0x284270
	private int <LowSide>k__BackingField; // 0x90

	// Properties
	private int HighSide { get; set; }
	private int LowSide { get; set; }
	protected override int RoughPosCount { get; }
	protected override int PatternCount { get; }

	// Methods

	// RVA: 0x22CF540 Offset: 0x22CF641 VA: 0x22CF540
	public void .ctor(CombatRecord record) { }

	[CompilerGeneratedAttribute] // RVA: 0x2ACAB0 Offset: 0x2ACBB1 VA: 0x2ACAB0
	// RVA: 0x22CF5C0 Offset: 0x22CF6C1 VA: 0x22CF5C0
	private int get_HighSide() { }

	[CompilerGeneratedAttribute] // RVA: 0x2ACAC0 Offset: 0x2ACBC1 VA: 0x2ACAC0
	// RVA: 0x22CF5D0 Offset: 0x22CF6D1 VA: 0x22CF5D0
	private void set_HighSide(int value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2ACAD0 Offset: 0x2ACBD1 VA: 0x2ACAD0
	// RVA: 0x22CF5E0 Offset: 0x22CF6E1 VA: 0x22CF5E0
	private int get_LowSide() { }

	[CompilerGeneratedAttribute] // RVA: 0x2ACAE0 Offset: 0x2ACBE1 VA: 0x2ACAE0
	// RVA: 0x22CF5F0 Offset: 0x22CF6F1 VA: 0x22CF5F0
	private void set_LowSide(int value) { }

	// RVA: 0x22CF600 Offset: 0x22CF701 VA: 0x22CF600 Slot: 6
	protected override int get_RoughPosCount() { }

	// RVA: 0x22CF610 Offset: 0x22CF711 VA: 0x22CF610 Slot: 7
	protected override void SetRoughPos(int tryCount) { }

	// RVA: 0x22CFC70 Offset: 0x22CFD71 VA: 0x22CFC70 Slot: 8
	protected override int get_PatternCount() { }

	// RVA: 0x22CFC80 Offset: 0x22CFD81 VA: 0x22CFC80 Slot: 9
	protected override void SetBattlePatern(int pattern) { }

	// RVA: 0x22D0490 Offset: 0x22D0591 VA: 0x22D0490 Slot: 10
	protected override void CalcLocation() { }
}

