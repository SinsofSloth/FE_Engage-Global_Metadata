// Namespace: App
public class BattleGrow : ProcBattleCallback // TypeDefIndex: 12400
{
	// Fields
	private bool m_IsTalk; // 0x81

	// Methods

	// RVA: 0x2244F00 Offset: 0x2245001 VA: 0x2244F00
	protected void .ctor(BattleCalculator calculator, bool isTalk) { }

	// RVA: 0x2244F40 Offset: 0x2245041 VA: 0x2244F40
	protected void GainExp() { }

	// RVA: 0x22452C0 Offset: 0x22453C1 VA: 0x22452C0
	public static void CreateBind(ProcInst super, BattleCalculator calculator, float waitTime = 0) { }

	// RVA: 0x22453A0 Offset: 0x22454A1 VA: 0x22453A0
	public static void CreateBind(ProcInst super, BattleCalculator calculator, bool isTalk, float waitTime = 0) { }

	// RVA: 0x22455B0 Offset: 0x22456B1 VA: 0x22455B0
	public static void CreateBind(ProcInst super, BattleInfoSide side) { }
}

