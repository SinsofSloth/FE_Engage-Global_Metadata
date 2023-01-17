// Namespace: App
public class RankingMenuContent : BasicMenuContent // TypeDefIndex: 12837
{
	// Fields
	private const string PrefabPath = "UI/Network/GodRanking/Prefabs/GodRankingRoot";
	public TextMeshProUGUI m_chapterNo; // 0xE8
	public TextMeshProUGUI m_chapterTitle; // 0xF0

	// Methods

	// RVA: 0x276ED80 Offset: 0x276EE81 VA: 0x276ED80 Slot: 27
	public override void AfterBuild() { }

	// RVA: 0x276EE60 Offset: 0x276EF61 VA: 0x276EE60 Slot: 10
	protected override float CalcCursorMovedPosY(int menuItemIndex) { }

	// RVA: 0x276EF30 Offset: 0x276F031 VA: 0x276EF30
	public static void LoadPrefabAsync() { }

	// RVA: 0x276EFD0 Offset: 0x276F0D1 VA: 0x276EFD0
	public static bool IsLoadingPrefab() { }

	// RVA: 0x276F050 Offset: 0x276F151 VA: 0x276F050
	public static void UnloadPrefab() { }

	// RVA: 0x276EB50 Offset: 0x276EC51 VA: 0x276EB50
	public static RankingMenuContent Create() { }

	// RVA: 0x276F0D0 Offset: 0x276F1D1 VA: 0x276F0D0
	public static void Destroy(RankingMenuContent content) { }

	// RVA: 0x276F150 Offset: 0x276F251 VA: 0x276F150 Slot: 4
	public override int GetMenuItemContentMax() { }

	// RVA: 0x276F160 Offset: 0x276F261 VA: 0x276F160 Slot: 21
	public override float CalcW() { }

	// RVA: 0x276F1D0 Offset: 0x276F2D1 VA: 0x276F1D0 Slot: 22
	public override float CalcH() { }

	// RVA: 0x276EC10 Offset: 0x276ED11 VA: 0x276EC10
	public void SetCapter(ChapterData chapter) { }

	// RVA: 0x276F240 Offset: 0x276F341 VA: 0x276F240
	public void .ctor() { }
}

