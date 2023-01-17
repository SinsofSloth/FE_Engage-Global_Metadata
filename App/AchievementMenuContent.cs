// Namespace: App
public class AchievementMenuContent : BasicMenuContent // TypeDefIndex: 11417
{
	// Fields
	private const string PrefabPath = "UI/Hub/CafeTerrace/NoticeBoard/Prefabs/AchievementRoot";
	[HeaderAttribute] // RVA: 0x297DB0 Offset: 0x297EB1 VA: 0x297DB0
	public Color m_activeIconColor; // 0xE8
	public Color m_inactiveIconColor; // 0xF8
	[HeaderAttribute] // RVA: 0x297DF0 Offset: 0x297EF1 VA: 0x297DF0
	public List<TextMeshProUGUI> m_categoryValue; // 0x108
	public TextMeshProUGUI m_totalValue; // 0x110
	[HeaderAttribute] // RVA: 0x297E30 Offset: 0x297F31 VA: 0x297E30
	public List<GameObject> m_categoryIcon; // 0x118

	// Methods

	// RVA: 0x2B2E430 Offset: 0x2B2E531 VA: 0x2B2E430 Slot: 10
	protected override float CalcCursorMovedPosY(int menuItemIndex) { }

	// RVA: 0x2B2E4F0 Offset: 0x2B2E5F1 VA: 0x2B2E4F0 Slot: 21
	public override float CalcW() { }

	// RVA: 0x2B2E560 Offset: 0x2B2E661 VA: 0x2B2E560 Slot: 22
	public override float CalcH() { }

	// RVA: 0x2B2E5D0 Offset: 0x2B2E6D1 VA: 0x2B2E5D0
	public static void LoadPrefabAsync() { }

	// RVA: 0x2B2E670 Offset: 0x2B2E771 VA: 0x2B2E670
	public static bool IsLoadingPrefab() { }

	// RVA: 0x2B2E6F0 Offset: 0x2B2E7F1 VA: 0x2B2E6F0
	public static void UnloadPrefab() { }

	// RVA: 0x2B2C020 Offset: 0x2B2C121 VA: 0x2B2C020
	public static AchievementMenuContent Create() { }

	// RVA: 0x2B2C400 Offset: 0x2B2C501 VA: 0x2B2C400
	public void Setup() { }

	// RVA: 0x2B2C810 Offset: 0x2B2C911 VA: 0x2B2C810
	public int GetCategoryIconNum() { }

	// RVA: 0x2B2CB90 Offset: 0x2B2CC91 VA: 0x2B2CB90
	public void SetCategoryIconActive(int index, bool isActive) { }

	// RVA: 0x2B2E770 Offset: 0x2B2E871 VA: 0x2B2E770
	public void .ctor() { }
}

