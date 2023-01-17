// Namespace: App
public class SkillEditPoolSkillMenu : BasicMenu // TypeDefIndex: 13243
{
	// Fields
	private const int MaxCount = 1280;
	private List<SkillData> m_SkillList; // 0xC8

	// Methods

	// RVA: 0x27D8010 Offset: 0x27D8111 VA: 0x27D8010
	public static SkillEditPoolSkillMenu Create(ProcInst super, SkillEditPoolSkillMenuContent menuContent) { }

	// RVA: 0x27D81F0 Offset: 0x27D82F1 VA: 0x27D81F0
	protected void .ctor(List<BasicMenuItem> menuItemList, SkillEditPoolSkillMenuContent menuContent) { }

	// RVA: 0x27D82A0 Offset: 0x27D83A1 VA: 0x27D82A0
	public void UpdateList() { }

	// RVA: 0x27D84B0 Offset: 0x27D85B1 VA: 0x27D84B0
	public SkillData GetSkill(int index) { }

	// RVA: 0x27D5600 Offset: 0x27D5701 VA: 0x27D5600
	public SkillData GetSelectSkill() { }

	// RVA: 0x27D5980 Offset: 0x27D5A81 VA: 0x27D5980
	public bool IsEquipSkillExist() { }

	// RVA: 0x27D3D00 Offset: 0x27D3E01 VA: 0x27D3D00
	public void ShowCursor(bool isShow) { }

	// RVA: 0x27D7F10 Offset: 0x27D8011 VA: 0x27D7F10
	public bool IsShowCursor() { }

	// RVA: 0x27D3C70 Offset: 0x27D3D71 VA: 0x27D3C70
	public void EnableInput(bool isEnable) { }

	// RVA: 0x27D3D90 Offset: 0x27D3E91 VA: 0x27D3D90
	public void SetFirstSelection(bool bFocusEnable = False, bool bUpdateInfo = False) { }

	// RVA: 0x27D8550 Offset: 0x27D8651 VA: 0x27D8550
	public void HoldSelection() { }

	// RVA: 0x27D8690 Offset: 0x27D8791 VA: 0x27D8690 Slot: 42
	protected override void KeyLeft(bool isTrigger) { }

	// RVA: 0x27D8890 Offset: 0x27D8991 VA: 0x27D8890 Slot: 43
	protected override void KeyRight(bool isTrigger) { }

	// RVA: 0x27D86A0 Offset: 0x27D87A1 VA: 0x27D86A0
	private void ChangeMenu() { }
}

