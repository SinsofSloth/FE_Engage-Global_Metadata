// Namespace: App
internal class RelayAwardSequence : SingletonProcInst<RelayAwardSequence> // TypeDefIndex: 12945
{
	// Fields
	private RelayUserData.EnteredBattle m_EnteredBattle; // 0x78
	private string[] m_Raids; // 0x80
	private ItemData m_GainItem; // 0x88
	private bool m_IsAwarded; // 0x90
	private int m_PrevMasterProofCount; // 0x94
	private int m_PrevChangeProofCount; // 0x98

	// Methods

	// RVA: 0x253DA80 Offset: 0x253DB81 VA: 0x253DA80 Slot: 9
	protected override void OnCreate() { }

	// RVA: 0x253DDA0 Offset: 0x253DEA1 VA: 0x253DDA0 Slot: 10
	protected override void OnDispose() { }

	// RVA: 0x253DEB0 Offset: 0x253DFB1 VA: 0x253DEB0
	private void TeamAward() { }

	// RVA: 0x253E2A0 Offset: 0x253E3A1 VA: 0x253E2A0
	private void UnitAward() { }

	// RVA: 0x253E340 Offset: 0x253E441 VA: 0x253E340
	private void GainItem() { }

	// RVA: 0x253E230 Offset: 0x253E331 VA: 0x253E230
	private void GainItems(RelayCompletionAwardData.CalcResult result) { }

	// RVA: 0x253E3A0 Offset: 0x253E4A1 VA: 0x253E3A0
	private void GainItems(List<RelayCompletionAwardData.CalcResult.Item> items) { }

	// RVA: 0x253E280 Offset: 0x253E381 VA: 0x253E280
	private void SetGainItem(ItemData item) { }

	// RVA: 0x253E560 Offset: 0x253E661 VA: 0x253E560
	private void TutorialClassChange() { }

	// RVA: 0x253E650 Offset: 0x253E751 VA: 0x253E650
	private void End() { }

	// RVA: 0x253E6F0 Offset: 0x253E7F1 VA: 0x253E6F0
	public static void CreateBind(ProcInst super) { }

	// RVA: 0x253DD10 Offset: 0x253DE11 VA: 0x253DD10
	private static RelayUserData.EnteredBattle GetEnteredBattle() { }

	// RVA: 0x253DDD0 Offset: 0x253DED1 VA: 0x253DDD0
	private static RelayUserData.EnteredBattle GetEnteredBattleFromUserData() { }

	// RVA: 0x253EB90 Offset: 0x253EC91 VA: 0x253EB90
	public void .ctor() { }
}

