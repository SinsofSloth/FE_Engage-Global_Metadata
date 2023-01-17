// Namespace: App
public class ClassChangeJobMenuContent : BasicMenuContent // TypeDefIndex: 13192
{
	// Fields
	[HeaderAttribute] // RVA: 0x29BB60 Offset: 0x29BC61 VA: 0x29BB60
	public TextMeshProUGUI m_CostTextLevel; // 0xE8
	public List<GameObject> m_CostWeaponIconObjList; // 0xF0
	public TextMeshProUGUI m_CostWeaponText; // 0xF8
	public Image m_CostItemImage; // 0x100
	public TextMeshProUGUI m_CostItemTitle; // 0x108
	public TextMeshProUGUI m_CostItemValue; // 0x110
	[HeaderAttribute] // RVA: 0x29BBA0 Offset: 0x29BCA1 VA: 0x29BBA0
	public TextMeshProUGUI m_HelpText; // 0x118
	[HeaderAttribute] // RVA: 0x29BBE0 Offset: 0x29BCE1 VA: 0x29BBE0
	public GameObject m_SkillRoodObj; // 0x120
	public Image m_SkillImage; // 0x128
	public TextMeshProUGUI m_SkillName; // 0x130
	public TextMeshProUGUI m_SkillGetLevel; // 0x138
	public TextMeshProUGUI m_SkillHelpText; // 0x140

	// Methods

	// RVA: 0x22C4840 Offset: 0x22C4941 VA: 0x22C4840 Slot: 10
	protected override float CalcCursorMovedPosY(int menuItemIndex) { }

	// RVA: 0x22C3F80 Offset: 0x22C4081 VA: 0x22C3F80
	public void SetJobDetails(ClassChange.ChangeJobData data) { }

	// RVA: 0x22C4930 Offset: 0x22C4A31 VA: 0x22C4930
	public void .ctor() { }
}

