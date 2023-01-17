// Namespace: App
public class BattleTalkEvent : ProcBattleCallback // TypeDefIndex: 12398
{
	// Fields
	private Unit m_Unit; // 0x88
	private Unit m_Target; // 0x90

	// Methods

	// RVA: 0x2261580 Offset: 0x2261681 VA: 0x2261580
	protected void .ctor(BattleCalculator calculator, Unit unit, Unit target, Action completed) { }

	// RVA: 0x22615E0 Offset: 0x22616E1 VA: 0x22615E0 Slot: 6
	protected override void OnTick() { }

	// RVA: 0x2261610 Offset: 0x2261711 VA: 0x2261610
	public static bool IsEnable(BattleCalculator calculator) { }

	// RVA: 0x22616D0 Offset: 0x22617D1 VA: 0x22616D0
	public static bool IsEnable(BattleCalculator calculator, Unit unit, Unit target) { }

	// RVA: 0x2261770 Offset: 0x2261871 VA: 0x2261770
	public static bool TryCreateBind(ProcInst super, BattleCalculator calculator, Action completed) { }

	// RVA: 0x22617E0 Offset: 0x22618E1 VA: 0x22617E0
	public static bool TryCreateBind(ProcInst super, BattleCalculator calculator, Unit unit, Unit target, Action completed) { }
}

