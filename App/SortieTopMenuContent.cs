// Namespace: App
public class SortieTopMenuContent : BasicMenuContent // TypeDefIndex: 13285
{
	// Fields
	private static readonly string PrefabPath; // 0x0
	public Animator m_MenuListAnimator; // 0xE8
	public int m_GridSize; // 0xF0
	public Color m_ColorPlayer; // 0xF4
	public Color m_ColorEnemy; // 0x104
	public Color m_ColorAlly; // 0x114
	public Color[] m_CostTypeColors; // 0x128
	public Color m_DifficultyFrameColorNormal; // 0x130
	public Color m_DifficultyFrameColorHard; // 0x140
	public Color m_DifficultyFrameColorLunatic; // 0x150

	// Methods

	// RVA: 0x216FEE0 Offset: 0x216FFE1 VA: 0x216FEE0
	public void UpdateInfo(bool isSortieTop) { }

	// RVA: 0x2171170 Offset: 0x2171271 VA: 0x2171170
	public RectTransform GetSubItemMenuRect() { }

	// RVA: 0x2171220 Offset: 0x2171321 VA: 0x2171220 Slot: 17
	public override void SetColor(Color color) { }

	// RVA: 0x2171230 Offset: 0x2171331 VA: 0x2171230 Slot: 4
	public override int GetMenuItemContentMax() { }

	// RVA: 0x21712D0 Offset: 0x21713D1 VA: 0x21712D0 Slot: 21
	public override float CalcW() { }

	// RVA: 0x2171330 Offset: 0x2171431 VA: 0x2171330 Slot: 22
	public override float CalcH() { }

	// RVA: 0x21713A0 Offset: 0x21714A1 VA: 0x21713A0
	public static void LoadPrefabAsync() { }

	// RVA: 0x2171440 Offset: 0x2171541 VA: 0x2171440
	public static bool IsLoadingPrefab() { }

	// RVA: 0x21714E0 Offset: 0x21715E1 VA: 0x21714E0
	public static void UnloadPrefab() { }

	// RVA: 0x216F880 Offset: 0x216F981 VA: 0x216F880
	public static SortieTopMenuContent Create() { }

	// RVA: 0x2171580 Offset: 0x2171681 VA: 0x2171580 Slot: 18
	public override void BuildMenuItemContent() { }

	// RVA: 0x2171700 Offset: 0x2171801 VA: 0x2171700 Slot: 25
	public override void OpenAnime() { }

	// RVA: 0x2171770 Offset: 0x2171871 VA: 0x2171770
	public void .ctor() { }

	// RVA: 0x21717F0 Offset: 0x21718F1 VA: 0x21717F0
	private static void .cctor() { }
}

