// Namespace: App
public class RewindMenu : BasicMenu // TypeDefIndex: 12611
{
	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x29B330 Offset: 0x29B431 VA: 0x29B330
	private Unit <CurrentActorUnit>k__BackingField; // 0xC8
	protected int m_scrollNow; // 0xD0

	// Properties
	public Unit CurrentActorUnit { get; set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x2C9B60 Offset: 0x2C9C61 VA: 0x2C9B60
	// RVA: 0x24D3380 Offset: 0x24D3481 VA: 0x24D3380
	public Unit get_CurrentActorUnit() { }

	[CompilerGeneratedAttribute] // RVA: 0x2C9B70 Offset: 0x2C9C71 VA: 0x2C9B70
	// RVA: 0x24D3390 Offset: 0x24D3491 VA: 0x24D3390
	public void set_CurrentActorUnit(Unit value) { }

	// RVA: 0x24D33A0 Offset: 0x24D34A1 VA: 0x24D33A0
	private void .ctor(List<BasicMenuItem> menuItemList, BasicMenuContent menuContent) { }

	// RVA: 0x24D33D0 Offset: 0x24D34D1 VA: 0x24D33D0 Slot: 30
	public override string GetName() { }

	// RVA: 0x24D3420 Offset: 0x24D3521 VA: 0x24D3420
	public Color GetForcePlayerColor() { }

	// RVA: 0x24D34B0 Offset: 0x24D35B1 VA: 0x24D34B0
	public Color GetForceEnemyColor() { }

	// RVA: 0x24D3540 Offset: 0x24D3641 VA: 0x24D3540
	public Color GetForceAllyColor() { }

	// RVA: 0x24D3660 Offset: 0x24D3761 VA: 0x24D3660 Slot: 25
	protected override void AfterBuild() { }

	// RVA: 0x24D3680 Offset: 0x24D3781 VA: 0x24D3680 Slot: 26
	public override void OnClose() { }

	// RVA: 0x24D3730 Offset: 0x24D3831 VA: 0x24D3730 Slot: 32
	public override int GetShowRowMax() { }

	// RVA: 0x24D3740 Offset: 0x24D3841 VA: 0x24D3740
	public void UpdateSelectAndScroll() { }

	// RVA: 0x24D4510 Offset: 0x24D4611 VA: 0x24D4510 Slot: 35
	public override void AdjustScrollIndex() { }

	// RVA: 0x24D4520 Offset: 0x24D4621 VA: 0x24D4520
	public void UpdateParts(Force.Type currentForceType, int turn, int restUnitNum) { }

	// RVA: 0x24D36E0 Offset: 0x24D37E1 VA: 0x24D36E0
	public void BrightOffCurrentActorUnit() { }

	// RVA: 0x24D4850 Offset: 0x24D4951 VA: 0x24D4850 Slot: 51
	protected override BasicMenu.Result BCall() { }

	// RVA: 0x24D4970 Offset: 0x24D4A71 VA: 0x24D4970 Slot: 40
	protected override void KeyUp(bool isTrigger) { }

	// RVA: 0x24D4A20 Offset: 0x24D4B21 VA: 0x24D4A20 Slot: 41
	protected override void KeyDown(bool isTrigger) { }

	// RVA: 0x24D4AD0 Offset: 0x24D4BD1 VA: 0x24D4AD0 Slot: 42
	protected override void KeyLeft(bool isTrigger) { }

	// RVA: 0x24D4BF0 Offset: 0x24D4CF1 VA: 0x24D4BF0 Slot: 43
	protected override void KeyRight(bool isTrigger) { }

	// RVA: 0x24D4D00 Offset: 0x24D4E01 VA: 0x24D4D00
	public static RewindMenu CreateMenu(ProcInst super) { }
}

