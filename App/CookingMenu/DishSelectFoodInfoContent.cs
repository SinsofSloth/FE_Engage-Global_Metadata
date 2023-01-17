// Namespace: App.CookingMenu
public class DishSelectFoodInfoContent : MonoBehaviour // TypeDefIndex: 14230
{
	// Fields
	[SerializeField] // RVA: 0x29DFB0 Offset: 0x29E0B1 VA: 0x29DFB0
	[HeaderAttribute] // RVA: 0x29DFB0 Offset: 0x29E0B1 VA: 0x29DFB0
	private TextMeshProUGUI m_FoodName; // 0x18
	[SerializeField] // RVA: 0x29E000 Offset: 0x29E101 VA: 0x29E000
	private TextMeshProUGUI m_FoodMessage; // 0x20
	[HeaderAttribute] // RVA: 0x29E010 Offset: 0x29E111 VA: 0x29E010
	[SerializeField] // RVA: 0x29E010 Offset: 0x29E111 VA: 0x29E010
	private GameObject m_DifficultyIcon; // 0x28
	[SerializeField] // RVA: 0x29E060 Offset: 0x29E161 VA: 0x29E060
	private TextMeshProUGUI m_DifficultyText; // 0x30
	[HeaderAttribute] // RVA: 0x29E070 Offset: 0x29E171 VA: 0x29E070
	[SerializeField] // RVA: 0x29E070 Offset: 0x29E171 VA: 0x29E070
	private DishSelectFoodInfoContent.EnhanceObject m_EnhanceAtkObject; // 0x38
	[SerializeField] // RVA: 0x29E0C0 Offset: 0x29E1C1 VA: 0x29E0C0
	private DishSelectFoodInfoContent.EnhanceObject m_EnhanceMagObject; // 0x40
	[SerializeField] // RVA: 0x29E0D0 Offset: 0x29E1D1 VA: 0x29E0D0
	private DishSelectFoodInfoContent.EnhanceObject m_EnhanceSpdObject; // 0x48
	[SerializeField] // RVA: 0x29E0E0 Offset: 0x29E1E1 VA: 0x29E0E0
	private DishSelectFoodInfoContent.EnhanceObject m_EnhanceDefObject; // 0x50
	[SerializeField] // RVA: 0x29E0F0 Offset: 0x29E1F1 VA: 0x29E0F0
	private DishSelectFoodInfoContent.EnhanceObject m_EnhanceResObject; // 0x58
	[SerializeField] // RVA: 0x29E100 Offset: 0x29E201 VA: 0x29E100
	[HeaderAttribute] // RVA: 0x29E100 Offset: 0x29E201 VA: 0x29E100
	private List<DishSelectFoodInfoContent.FoodstuffObject> m_FoodstuffList; // 0x60
	[HeaderAttribute] // RVA: 0x29E150 Offset: 0x29E251 VA: 0x29E150
	[SerializeField] // RVA: 0x29E150 Offset: 0x29E251 VA: 0x29E150
	private List<DishSelectFoodInfoContent.UnitObject> m_UnitObjectList; // 0x68
	private CookData m_Cook; // 0x70
	private List<CookData> m_SelectedUnitCookList; // 0x78

	// Methods

	// RVA: 0x237BC50 Offset: 0x237BD51 VA: 0x237BC50
	private void Awake() { }

	// RVA: 0x237C040 Offset: 0x237C141 VA: 0x237C040
	public void SetFood(FoodData food, List<Unit> selectedUnitList) { }

	// RVA: 0x237C490 Offset: 0x237C591 VA: 0x237C490
	private void SetDifficulty(FoodData food) { }

	// RVA: 0x237C600 Offset: 0x237C701 VA: 0x237C600
	private void SetEnhance(DishSelectFoodInfoContent.EnhanceObject enhanceObject, int value) { }

	// RVA: 0x237C840 Offset: 0x237C941 VA: 0x237C840
	private void SetFoodstuffs(string[] fids) { }

	// RVA: 0x237CAB0 Offset: 0x237CBB1 VA: 0x237CAB0
	private void SetUnit(FoodData food, CookData cook, Unit unit, DishSelectFoodInfoContent.UnitObject unitObject) { }

	// RVA: 0x237CC30 Offset: 0x237CD31 VA: 0x237CC30
	public void .ctor() { }
}

