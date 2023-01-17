// Namespace: App
public abstract class ProcBattleCallback : ProcInst // TypeDefIndex: 12397
{
	// Fields
	protected BattleCalculator m_Calculator; // 0x70
	protected Action m_Completed; // 0x78
	protected bool m_Skipable; // 0x80

	// Methods

	// RVA: 0x29E1430 Offset: 0x29E1531 VA: 0x29E1430
	protected void .ctor(BattleCalculator calculator, Action completed, bool skipable) { }

	// RVA: 0x29E1490 Offset: 0x29E1591 VA: 0x29E1490 Slot: 9
	protected override void OnCreate() { }

	// RVA: 0x29E14C0 Offset: 0x29E15C1 VA: 0x29E14C0 Slot: 10
	protected override void OnDispose() { }

	// RVA: 0x29E1510 Offset: 0x29E1611 VA: 0x29E1510
	protected static ProcInst GetCurrent(ProcInst super) { }
}

