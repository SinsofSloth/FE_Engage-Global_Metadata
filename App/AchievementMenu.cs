// Namespace: App
public class AchievementMenu : BasicMenu // TypeDefIndex: 11416
{
	// Fields
	private static int m_SelectCategory; // 0x0
	private static bool[] m_DispAchievementKind; // 0x8
	private List<BasicMenuSelect> m_MenuSelectList; // 0xC8

	// Methods

	// RVA: 0x2B2BE30 Offset: 0x2B2BF31 VA: 0x2B2BE30
	public int GetSelectCategory() { }

	// RVA: 0x2B2BEA0 Offset: 0x2B2BFA1 VA: 0x2B2BEA0
	public static void CreateBind(ProcInst super) { }

	// RVA: 0x2B2C2A0 Offset: 0x2B2C3A1 VA: 0x2B2C2A0
	protected void .ctor(List<BasicMenuItem> menuItemList, AchievementMenuContent menuContent) { }

	// RVA: 0x2B2C860 Offset: 0x2B2C961 VA: 0x2B2C860 Slot: 30
	public override string GetName() { }

	// RVA: 0x2B2C8B0 Offset: 0x2B2C9B1 VA: 0x2B2C8B0 Slot: 51
	protected override BasicMenu.Result BCall() { }

	// RVA: 0x2B2C8C0 Offset: 0x2B2C9C1 VA: 0x2B2C8C0 Slot: 42
	protected override void KeyLeft(bool isTrigger) { }

	// RVA: 0x2B2CE90 Offset: 0x2B2CF91 VA: 0x2B2CE90 Slot: 43
	protected override void KeyRight(bool isTrigger) { }

	// RVA: 0x2B2D170 Offset: 0x2B2D271 VA: 0x2B2D170 Slot: 58
	protected override BasicMenu.Result CustomCall() { }

	// RVA: 0x2B2CCE0 Offset: 0x2B2CDE1 VA: 0x2B2CCE0
	public void UpdateAchievementList(bool isSort = True) { }

	// RVA: 0x2B2C0D0 Offset: 0x2B2C1D1 VA: 0x2B2C0D0
	private static List<BasicMenuItem> CreateMenuItem() { }

	// RVA: 0x2B2D7C0 Offset: 0x2B2D8C1 VA: 0x2B2D7C0
	private static List<BasicMenuItem> UpdateDispAchievementCategory(AchieveData.Categories dispCategory) { }

	// RVA: 0x2B2D610 Offset: 0x2B2D711 VA: 0x2B2D610
	private static List<BasicMenuItem> UpdateDispAchievementStateCleared() { }

	// RVA: 0x2B2D490 Offset: 0x2B2D591 VA: 0x2B2D490
	private int GetAllRewardNum() { }

	// RVA: 0x2B2DFE0 Offset: 0x2B2E0E1 VA: 0x2B2DFE0
	private void GetAllReward() { }

	// RVA: 0x2B2DC80 Offset: 0x2B2DD81 VA: 0x2B2DC80
	private static bool SetDisplayFromKind(AchieveData data) { }

	// RVA: 0x2B2E3A0 Offset: 0x2B2E4A1 VA: 0x2B2E3A0
	private static void .cctor() { }
}

