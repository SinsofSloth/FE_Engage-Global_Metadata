// Namespace: App
public class MapSequenceAI : SingletonProcInst<MapSequenceAI> // TypeDefIndex: 12372
{
	// Fields
	private static MapAiThread s_AiThread; // 0x0
	private int m_LastMindX; // 0x74
	private int m_LastMindZ; // 0x78
	private bool m_IsOrderUnitEngageOrGodChange; // 0x7C

	// Methods

	// RVA: 0x1D70BA0 Offset: 0x1D70CA1 VA: 0x1D70BA0
	public void JumpForRemove(Unit unit) { }

	// RVA: 0x1D70C70 Offset: 0x1D70D71 VA: 0x1D70C70
	public void JumpForRemagic(Unit unit) { }

	// RVA: 0x1D70D40 Offset: 0x1D70E41 VA: 0x1D70D40
	public void JumpForRerewarp(Unit unit) { }

	// RVA: 0x1D70E10 Offset: 0x1D70F11 VA: 0x1D70E10
	private void .ctor() { }

	// RVA: 0x1D70EA0 Offset: 0x1D70FA1 VA: 0x1D70EA0
	private void Setup() { }

	// RVA: 0x1D711F0 Offset: 0x1D712F1 VA: 0x1D711F0
	private void Cleanup() { }

	// RVA: 0x1D71380 Offset: 0x1D71481 VA: 0x1D71380 Slot: 8
	protected override void OnPersistent() { }

	// RVA: 0x1D715B0 Offset: 0x1D716B1 VA: 0x1D715B0
	private void Think() { }

	// RVA: 0x1D718E0 Offset: 0x1D719E1 VA: 0x1D718E0
	private bool Wait() { }

	// RVA: 0x1D71930 Offset: 0x1D71A31 VA: 0x1D71930
	private void Focus() { }

	// RVA: 0x1D71B00 Offset: 0x1D71C01 VA: 0x1D71B00
	private void PickupEvent() { }

	// RVA: 0x1D71BB0 Offset: 0x1D71CB1 VA: 0x1D71BB0
	private void PreMindBranch() { }

	// RVA: 0x1D71DD0 Offset: 0x1D71ED1 VA: 0x1D71DD0
	private void Mind() { }

	// RVA: 0x1D71F20 Offset: 0x1D72021 VA: 0x1D71F20
	private void GameEndBranch() { }

	// RVA: 0x1D722E0 Offset: 0x1D723E1 VA: 0x1D722E0
	private void Fixed() { }

	// RVA: 0x1D72B90 Offset: 0x1D72C91 VA: 0x1D72B90
	private void SetSkippedCamera() { }

	// RVA: 0x1D73230 Offset: 0x1D73331 VA: 0x1D73230
	private void PostEngage() { }

	// RVA: 0x1D73310 Offset: 0x1D73411 VA: 0x1D73310
	private void PrepareEngageRewarp() { }

	// RVA: 0x1D733F0 Offset: 0x1D734F1 VA: 0x1D733F0
	private void PostGodChange() { }

	// RVA: 0x1D71680 Offset: 0x1D71781 VA: 0x1D71680
	private bool CheckEntrustCancel(bool think) { }

	// RVA: 0x1D734D0 Offset: 0x1D735D1 VA: 0x1D734D0
	private void EntrustCancel() { }

	// RVA: 0x1D71D50 Offset: 0x1D71E51 VA: 0x1D71D50
	private void HistoryPickup(Unit unit) { }

	// RVA: 0x1D72380 Offset: 0x1D72481 VA: 0x1D72380
	private void EquipShortAfterLongRange() { }

	// RVA: 0x1D710D0 Offset: 0x1D711D1 VA: 0x1D710D0
	private bool IsSkipTrigger() { }

	// RVA: 0x1D735F0 Offset: 0x1D736F1 VA: 0x1D735F0
	private void TrySkip() { }

	// RVA: 0x1D73620 Offset: 0x1D73721 VA: 0x1D73620
	public static void CreateBind(ProcInst super) { }

	// RVA: 0x1D748E0 Offset: 0x1D749E1 VA: 0x1D748E0
	public static void InitializeThread() { }

	// RVA: 0x1D74960 Offset: 0x1D74A61 VA: 0x1D74960
	public static void FinalizeThread() { }
}

