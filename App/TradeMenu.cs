// Namespace: App
public class TradeMenu : GridMenu // TypeDefIndex: 12674
{
	// Fields
	protected int m_selectItemIndex; // 0xD4
	protected bool m_CanLeftUnitAutoEquipBefore; // 0xD8
	protected bool m_CanRightUnitAutoEquipBefore; // 0xD9

	// Methods

	// RVA: 0x25E8DB0 Offset: 0x25E8EB1 VA: 0x25E8DB0
	public void .ctor(List<BasicMenuItem> menuItemList, TradeMenuContent menuContent) { }

	// RVA: 0x25E8E40 Offset: 0x25E8F41 VA: 0x25E8E40 Slot: 30
	public override string GetName() { }

	// RVA: 0x25E8E90 Offset: 0x25E8F91 VA: 0x25E8E90 Slot: 32
	public override int GetShowRowMax() { }

	// RVA: 0x25E8EA0 Offset: 0x25E8FA1 VA: 0x25E8EA0 Slot: 33
	protected override int GetBuildRowNum() { }

	// RVA: 0x25E8EB0 Offset: 0x25E8FB1 VA: 0x25E8EB0 Slot: 42
	protected override void KeyLeft(bool isTrigger) { }

	// RVA: 0x25E9030 Offset: 0x25E9131 VA: 0x25E9030 Slot: 43
	protected override void KeyRight(bool isTrigger) { }

	// RVA: 0x25E91C0 Offset: 0x25E92C1 VA: 0x25E91C0 Slot: 25
	protected override void AfterBuild() { }

	// RVA: 0x25E9430 Offset: 0x25E9531 VA: 0x25E9430
	public void InitLeftUnitInfo(Unit unit) { }

	// RVA: 0x25E95A0 Offset: 0x25E96A1 VA: 0x25E95A0
	public void InitRightUnitInfo(Unit unit) { }

	// RVA: 0x25E9500 Offset: 0x25E9601 VA: 0x25E9500
	public void SetLeftUnitName(string name) { }

	// RVA: 0x25E9670 Offset: 0x25E9771 VA: 0x25E9670
	public void SetRightUnitName(string name) { }

	// RVA: 0x25E9750 Offset: 0x25E9851 VA: 0x25E9750
	public bool CanLeftUnitAutoEquip() { }

	// RVA: 0x25E9760 Offset: 0x25E9861 VA: 0x25E9760
	public bool CanRightUnitAutoEquip() { }

	// RVA: 0x25E93A0 Offset: 0x25E94A1 VA: 0x25E93A0
	public void ShowSelectCursor() { }

	// RVA: 0x25E9780 Offset: 0x25E9881 VA: 0x25E9780
	public void HideSelectCursor() { }

	// RVA: 0x25E9270 Offset: 0x25E9371 VA: 0x25E9270
	public void SetSelectItemIndex(int itemIndex) { }

	// RVA: 0x25E98E0 Offset: 0x25E99E1 VA: 0x25E98E0
	public int GetSelectItemIndex() { }
}

