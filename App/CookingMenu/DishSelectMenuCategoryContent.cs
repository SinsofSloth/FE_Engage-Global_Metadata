// Namespace: App.CookingMenu
public class DishSelectMenuCategoryContent : MonoBehaviour // TypeDefIndex: 14243
{
	// Fields
	[SerializeField] // RVA: 0x29E270 Offset: 0x29E371 VA: 0x29E270
	private List<DishSelectMenuCategoryContent.CategoryObject> m_CategoryList; // 0x18
	private static List<DishSelectMenuCategoryContent.CategoryObject> s_EnableCategoryList; // 0x0
	private static int s_Index; // 0x8
	private static int s_OldIndex; // 0xC

	// Methods

	// RVA: 0x237E040 Offset: 0x237E141 VA: 0x237E040
	private void Awake() { }

	// RVA: 0x237E2D0 Offset: 0x237E3D1 VA: 0x237E2D0
	public static void Initialize() { }

	// RVA: 0x237E330 Offset: 0x237E431 VA: 0x237E330
	public bool Next(bool isTrigger) { }

	// RVA: 0x237E4E0 Offset: 0x237E5E1 VA: 0x237E4E0
	public bool Prev(bool isTrigger) { }

	// RVA: 0x237E0A0 Offset: 0x237E1A1 VA: 0x237E0A0
	private void InitObject() { }

	// RVA: 0x237E5A0 Offset: 0x237E6A1 VA: 0x237E5A0
	private bool CheckEnable(DishSelectMenuCategoryContent.CategoryObject category) { }

	// RVA: 0x237E720 Offset: 0x237E821 VA: 0x237E720
	private void SetActive(GameObject gameObject, bool value) { }

	// RVA: 0x237E6F0 Offset: 0x237E7F1 VA: 0x237E6F0
	private static PersonData.Country GetCountry(DishSelectMenuCategoryContent.Category category) { }

	// RVA: 0x237E400 Offset: 0x237E501 VA: 0x237E400
	public void UpdateIndex() { }

	// RVA: 0x237E880 Offset: 0x237E981 VA: 0x237E880
	public static bool IsSetup() { }

	// RVA: 0x237E8E0 Offset: 0x237E9E1 VA: 0x237E8E0
	public static bool IsRecommended() { }

	// RVA: 0x237D5C0 Offset: 0x237D6C1 VA: 0x237D5C0
	public static bool IsInitRecommended() { }

	// RVA: 0x237E970 Offset: 0x237EA71 VA: 0x237E970
	public static PersonData.Country GetCountry() { }

	// RVA: 0x237EA20 Offset: 0x237EB21 VA: 0x237EA20
	public static int GetIndex() { }

	// RVA: 0x237EA70 Offset: 0x237EB71 VA: 0x237EA70
	public static int GetOldIndex() { }

	// RVA: 0x237EAC0 Offset: 0x237EBC1 VA: 0x237EAC0
	public void .ctor() { }
}

