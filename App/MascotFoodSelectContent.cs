// Namespace: App
public class MascotFoodSelectContent : BasicMenuContent // TypeDefIndex: 10850
{
	// Fields
	private const string PrefabPath = "UI/Hub/Mascot/Prefabs/FoodSelectRoot";
	private const string UIName = "MascotFoodSelect";
	[SerializeField] // RVA: 0x295D10 Offset: 0x295E11 VA: 0x295D10
	private GameObject m_Food; // 0xE8
	[SerializeField] // RVA: 0x295D20 Offset: 0x295E21 VA: 0x295D20
	private GameObject m_FoodCount; // 0xF0
	[SerializeField] // RVA: 0x295D30 Offset: 0x295E31 VA: 0x295D30
	private GameObject m_FoodHelp; // 0xF8
	private GameObject m_HelpRoot; // 0x100

	// Methods

	// RVA: 0x2853590 Offset: 0x2853691 VA: 0x2853590
	public static void LoadPrefabAsync() { }

	// RVA: 0x2853630 Offset: 0x2853731 VA: 0x2853630
	public static bool IsLoadingPrefab() { }

	// RVA: 0x28536B0 Offset: 0x28537B1 VA: 0x28536B0
	public static void UnloadPrefab() { }

	// RVA: 0x2853730 Offset: 0x2853831 VA: 0x2853730
	public static MascotFoodSelectContent Create() { }

	// RVA: 0x2853800 Offset: 0x2853901 VA: 0x2853800
	public static void Destroy() { }

	// RVA: 0x2853890 Offset: 0x2853991 VA: 0x2853890
	public void SetHelpText(string help) { }

	// RVA: 0x28539B0 Offset: 0x2853AB1 VA: 0x28539B0 Slot: 10
	protected override float CalcCursorMovedPosY(int menuItemIndex) { }

	// RVA: 0x2853A70 Offset: 0x2853B71 VA: 0x2853A70 Slot: 4
	public override int GetMenuItemContentMax() { }

	// RVA: 0x2853A80 Offset: 0x2853B81 VA: 0x2853A80 Slot: 21
	public override float CalcW() { }

	// RVA: 0x2853AF0 Offset: 0x2853BF1 VA: 0x2853AF0 Slot: 22
	public override float CalcH() { }

	// RVA: 0x2853B60 Offset: 0x2853C61 VA: 0x2853B60 Slot: 30
	protected override void Awake() { }

	// RVA: 0x2853E30 Offset: 0x2853F31 VA: 0x2853E30
	public void .ctor() { }
}

