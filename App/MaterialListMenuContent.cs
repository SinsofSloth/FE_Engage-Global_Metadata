// Namespace: App
public class MaterialListMenuContent : BasicMenuContent // TypeDefIndex: 11036
{
	// Fields
	private const string PrefabPath = "UI/Hub/MaterialList/Prefabs/MaterialListRoot";
	[CompilerGeneratedAttribute] // RVA: 0x296290 Offset: 0x296391 VA: 0x296290
	private MaterialListMenuContent.CategoryType <Category>k__BackingField; // 0xE8
	[SerializeField] // RVA: 0x2962A0 Offset: 0x2963A1 VA: 0x2962A0
	private TextMeshProUGUI m_ItemHelpText; // 0xF0
	[SerializeField] // RVA: 0x2962B0 Offset: 0x2963B1 VA: 0x2962B0
	private List<Image> m_CategoryIconList; // 0xF8

	// Properties
	public MaterialListMenuContent.CategoryType Category { get; set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x2C30B0 Offset: 0x2C31B1 VA: 0x2C30B0
	// RVA: 0x285D2B0 Offset: 0x285D3B1 VA: 0x285D2B0
	public MaterialListMenuContent.CategoryType get_Category() { }

	[CompilerGeneratedAttribute] // RVA: 0x2C30C0 Offset: 0x2C31C1 VA: 0x2C30C0
	// RVA: 0x285D2C0 Offset: 0x285D3C1 VA: 0x285D2C0
	private void set_Category(MaterialListMenuContent.CategoryType value) { }

	// RVA: 0x285D2D0 Offset: 0x285D3D1 VA: 0x285D2D0
	public static void LoadPrefabAsync() { }

	// RVA: 0x285D370 Offset: 0x285D471 VA: 0x285D370
	public static bool IsLoadingPrefab() { }

	// RVA: 0x285D3F0 Offset: 0x285D4F1 VA: 0x285D3F0
	public static void UnloadPrefab() { }

	// RVA: 0x285BFB0 Offset: 0x285C0B1 VA: 0x285BFB0
	public static MaterialListMenuContent Create() { }

	// RVA: 0x285D470 Offset: 0x285D571 VA: 0x285D470 Slot: 10
	protected override float CalcCursorMovedPosY(int menuItemIndex) { }

	// RVA: 0x285C060 Offset: 0x285C161 VA: 0x285C060
	public void InitCategory() { }

	// RVA: 0x285C910 Offset: 0x285CA11 VA: 0x285C910
	public void LeftCategory(bool isTrigger) { }

	// RVA: 0x285CF40 Offset: 0x285D041 VA: 0x285CF40
	public void RightCategory(bool isTrigger) { }

	// RVA: 0x285D230 Offset: 0x285D331 VA: 0x285D230
	public void SetItemHelpText(string text) { }

	// RVA: 0x285D530 Offset: 0x285D631 VA: 0x285D530
	public void .ctor() { }
}

