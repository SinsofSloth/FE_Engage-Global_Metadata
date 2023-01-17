// Namespace: App.CookingMenu
public class DishAllMenuContent : MonoBehaviour // TypeDefIndex: 14226
{
	// Fields
	private const string PrefabPath = "UI/Hub/CafeTerrace/Cafe/Prefabs/DishAllMenuRoot";
	[HeaderAttribute] // RVA: 0x29DD10 Offset: 0x29DE11 VA: 0x29DD10
	[SerializeField] // RVA: 0x29DD10 Offset: 0x29DE11 VA: 0x29DD10
	private UnitSelectMenuContent m_UnitSelectMenuContent; // 0x18
	[SerializeField] // RVA: 0x29DD60 Offset: 0x29DE61 VA: 0x29DD60
	private DishSelectMenuContent m_DishSelectMenuContent; // 0x20
	[SerializeField] // RVA: 0x29DD70 Offset: 0x29DE71 VA: 0x29DD70
	private FoodstuffMenuContent m_FoodstuffMenuContent; // 0x28
	private List<DishAllMenuContent.HistoryObject> m_HistoryList; // 0x30
	private DishAllMenuContent.CookHistory m_CookHistory; // 0x38
	private DishAllMenuContent.UnitsHistory m_UnitsHistory; // 0x40
	private DishAllMenuContent.DishHistory m_DishHistory; // 0x48
	private DishAllMenuContent.FoodstuffsHistory m_FoodstuffsHistory; // 0x50
	[HeaderAttribute] // RVA: 0x29DD80 Offset: 0x29DE81 VA: 0x29DD80
	[SerializeField] // RVA: 0x29DD80 Offset: 0x29DE81 VA: 0x29DD80
	private UnitIcon m_UnitIcon0; // 0x58
	[SerializeField] // RVA: 0x29DDD0 Offset: 0x29DED1 VA: 0x29DDD0
	private TextMeshProUGUI m_UnitName0; // 0x60
	[SerializeField] // RVA: 0x29DDE0 Offset: 0x29DEE1 VA: 0x29DDE0
	private UnitIcon m_UnitIcon1; // 0x68
	[SerializeField] // RVA: 0x29DDF0 Offset: 0x29DEF1 VA: 0x29DDF0
	private TextMeshProUGUI m_UnitName1; // 0x70
	[HeaderAttribute] // RVA: 0x29DE00 Offset: 0x29DF01 VA: 0x29DE00
	[SerializeField] // RVA: 0x29DE00 Offset: 0x29DF01 VA: 0x29DE00
	private TextMeshProUGUI m_FoodName; // 0x78
	[SerializeField] // RVA: 0x29DE50 Offset: 0x29DF51 VA: 0x29DE50
	private GameObject m_DifficultyIcon; // 0x80
	[SerializeField] // RVA: 0x29DE60 Offset: 0x29DF61 VA: 0x29DE60
	private TextMeshProUGUI m_FoodDifficulty; // 0x88
	[SerializeField] // RVA: 0x29DE70 Offset: 0x29DF71 VA: 0x29DE70
	private List<DishAllMenuContent.EnhanceObject> m_EnhanceObjectList; // 0x90
	[HeaderAttribute] // RVA: 0x29DE80 Offset: 0x29DF81 VA: 0x29DE80
	[SerializeField] // RVA: 0x29DE80 Offset: 0x29DF81 VA: 0x29DE80
	private List<GameObject> m_FoodstuffItemList; // 0x98
	[SerializeField] // RVA: 0x29DED0 Offset: 0x29DFD1 VA: 0x29DED0
	private GameObject m_FoodstuffGroup; // 0xA0
	[HeaderAttribute] // RVA: 0x29DEE0 Offset: 0x29DFE1 VA: 0x29DEE0
	[SerializeField] // RVA: 0x29DEE0 Offset: 0x29DFE1 VA: 0x29DEE0
	private TextMeshProUGUI m_CookChefTitleText; // 0xA8
	[SerializeField] // RVA: 0x29DF30 Offset: 0x29E031 VA: 0x29DF30
	private TextMeshProUGUI m_FriendTitleText; // 0xB0
	[SerializeField] // RVA: 0x29DF40 Offset: 0x29E041 VA: 0x29DF40
	private TextMeshProUGUI m_CookMenuTitleText; // 0xB8
	[SerializeField] // RVA: 0x29DF50 Offset: 0x29E051 VA: 0x29DF50
	private TextMeshProUGUI m_BasicEffectTitleText; // 0xC0
	[SerializeField] // RVA: 0x29DF60 Offset: 0x29E061 VA: 0x29DF60
	private TextMeshProUGUI m_CookAddFoodTitleText; // 0xC8
	[SerializeField] // RVA: 0x29DF70 Offset: 0x29E071 VA: 0x29DF70
	private TextMeshProUGUI m_CookAddFoodNothingTitleText; // 0xD0
	private Animator m_Animator; // 0xD8

	// Methods

	// RVA: 0x2378B90 Offset: 0x2378C91 VA: 0x2378B90
	public static void LoadPrefabAsync() { }

	// RVA: 0x2378C30 Offset: 0x2378D31 VA: 0x2378C30
	public static bool IsLoadingPrefab() { }

	// RVA: 0x2378CB0 Offset: 0x2378DB1 VA: 0x2378CB0
	public static void UnloadPrefab() { }

	// RVA: 0x2378D30 Offset: 0x2378E31 VA: 0x2378D30
	public static DishAllMenuContent Create() { }

	// RVA: 0x2378DE0 Offset: 0x2378EE1 VA: 0x2378DE0
	public static void Destroy(DishAllMenuContent content) { }

	// RVA: 0x2378E60 Offset: 0x2378F61 VA: 0x2378E60
	private void Awake() { }

	// RVA: 0x2379260 Offset: 0x2379361 VA: 0x2379260
	private void SetMessages() { }

	// RVA: 0x2379440 Offset: 0x2379541 VA: 0x2379440
	public UnitSelectMenuContent GetAndEnableUnitSelect() { }

	// RVA: 0x2379500 Offset: 0x2379601 VA: 0x2379500
	public DishSelectMenuContent GetAndEnableDishSelect(List<Unit> selectedUnitList) { }

	// RVA: 0x23795C0 Offset: 0x23796C1 VA: 0x23795C0
	public FoodstuffMenuContent GetAndEnableFoodstuffSelect(FoodData food) { }

	// RVA: 0x2379680 Offset: 0x2379781 VA: 0x2379680
	private void DisableMenuAll() { }

	// RVA: 0x2379720 Offset: 0x2379821 VA: 0x2379720
	public void OnOpenConfirmDialog(List<FoodstuffData> foodstuffs) { }

	// RVA: 0x23797D0 Offset: 0x23798D1 VA: 0x23797D0
	public void Close() { }

	// RVA: 0x2379830 Offset: 0x2379931 VA: 0x2379830
	public bool IsClosed() { }

	// RVA: 0x2379890 Offset: 0x2379991 VA: 0x2379890
	public void .ctor() { }
}

