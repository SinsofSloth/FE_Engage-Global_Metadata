// Namespace: App
public class MapSequenceRevive : ProcInst // TypeDefIndex: 12447
{
	// Fields
	private List<Unit> m_Units; // 0x70
	private int m_Index; // 0x78

	// Properties
	private Unit Current { get; }

	// Methods

	// RVA: 0x2709D80 Offset: 0x2709E81 VA: 0x2709D80
	private void .ctor(List<Unit> units) { }

	// RVA: 0x2709DC0 Offset: 0x2709EC1 VA: 0x2709DC0
	private Unit get_Current() { }

	// RVA: 0x2709E30 Offset: 0x2709F31 VA: 0x2709E30
	private void Focus() { }

	// RVA: 0x2709FE0 Offset: 0x270A0E1 VA: 0x2709FE0
	private void ReviveBefre() { }

	// RVA: 0x270A060 Offset: 0x270A161 VA: 0x270A060
	private void ControlHpStock() { }

	// RVA: 0x270A0E0 Offset: 0x270A1E1 VA: 0x270A0E0
	private void ReviveExec() { }

	// RVA: 0x270A510 Offset: 0x270A611 VA: 0x270A510
	private void ReviveWait() { }

	// RVA: 0x270A5B0 Offset: 0x270A6B1 VA: 0x270A5B0
	private void HideHpStock() { }

	// RVA: 0x270A690 Offset: 0x270A791 VA: 0x270A690
	private void PlayHpStockEffect() { }

	// RVA: 0x270A760 Offset: 0x270A861 VA: 0x270A760
	private bool IsPlayingHpStockBreakEffect() { }

	// RVA: 0x270A7D0 Offset: 0x270A8D1 VA: 0x270A7D0
	private void ShowHpStock() { }

	// RVA: 0x270A8C0 Offset: 0x270A9C1 VA: 0x270A8C0
	private void ReleaseHpStock() { }

	// RVA: 0x270A940 Offset: 0x270AA41 VA: 0x270A940
	private void ReviveAfter() { }

	// RVA: 0x270AA60 Offset: 0x270AB61 VA: 0x270AA60
	private bool IsNext() { }

	// RVA: 0x270AAB0 Offset: 0x270ABB1 VA: 0x270AAB0
	public static void CreateBindAfterBattle(ProcInst super, List<Unit> deadUnits) { }

	// RVA: 0x270B3B0 Offset: 0x270B4B1 VA: 0x270B3B0
	public static void CreateBindTurnBegin(ProcInst super) { }

	// RVA: 0x2701710 Offset: 0x2701811 VA: 0x2701710
	public static void CreateBindDeadEvent(ProcInst super, Unit unit) { }

	// RVA: 0x270AC70 Offset: 0x270AD71 VA: 0x270AC70
	private static void CreateBind(ProcInst super, List<Unit> units) { }

	// RVA: 0x270AC60 Offset: 0x270AD61 VA: 0x270AC60
	private static bool IsTimingTurnBegin(Unit unit) { }
}

