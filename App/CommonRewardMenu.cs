// Namespace: App
public class CommonRewardMenu : BasicMenu // TypeDefIndex: 12591
{
	// Fields
	private bool m_IsGaugeAllEnd; // 0xC4
	private Action<Unit, int> m_AddLevelUpUnitList; // 0xC8
	private float m_WaitTimeStart; // 0xD0
	private float m_WaitTimeEnd; // 0xD4
	private int m_ShowIndex; // 0xD8

	// Methods

	// RVA: 0x257C1C0 Offset: 0x257C2C1 VA: 0x257C1C0
	public static CommonRewardMenu CreateBind(ProcInst super, Dictionary<Unit, int> rewardExpList, Action<Unit, int> addLevelUpUnitList) { }

	// RVA: 0x257C5A0 Offset: 0x257C6A1 VA: 0x257C5A0
	private void .ctor(List<BasicMenuItem> menuItemList, BasicMenuContent menuContent, Action<Unit, int> addLevelUpUnitList) { }

	// RVA: 0x257C680 Offset: 0x257C781 VA: 0x257C680 Slot: 30
	public override string GetName() { }

	// RVA: 0x257C6D0 Offset: 0x257C7D1 VA: 0x257C6D0 Slot: 38
	protected override void Tick() { }

	// RVA: 0x257D390 Offset: 0x257D491 VA: 0x257D390 Slot: 50
	protected override BasicMenu.Result ACall() { }

	// RVA: 0x257D3B0 Offset: 0x257D4B1 VA: 0x257D3B0 Slot: 51
	protected override BasicMenu.Result BCall() { }

	// RVA: 0x257D3D0 Offset: 0x257D4D1 VA: 0x257D3D0 Slot: 44
	protected override void MoveUp(bool isTrigger) { }

	// RVA: 0x257D3F0 Offset: 0x257D4F1 VA: 0x257D3F0 Slot: 45
	protected override void MoveDown(bool isTrigger) { }
}

