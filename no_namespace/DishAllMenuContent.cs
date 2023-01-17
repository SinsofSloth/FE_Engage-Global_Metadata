// Namespace: 
[Serializable]
private class DishAllMenuContent.EnhanceObject // TypeDefIndex: 14219
{
	// Fields
	[SerializeField] // RVA: 0x29DF80 Offset: 0x29E081 VA: 0x29DF80
	public GameObject m_GameObject; // 0x10
	[SerializeField] // RVA: 0x29DF90 Offset: 0x29E091 VA: 0x29DF90
	public TextMeshProUGUI m_Name; // 0x18
	[SerializeField] // RVA: 0x29DFA0 Offset: 0x29E0A1 VA: 0x29DFA0
	public TextMeshProUGUI m_Value; // 0x20

	// Methods

	// RVA: 0x1EFD8C0 Offset: 0x1EFD9C1 VA: 0x1EFD8C0
	public void .ctor() { }
}

// Namespace: 
private class DishAllMenuContent.HistoryObject // TypeDefIndex: 14220
{
	// Fields
	protected GameObject m_GameObject; // 0x10
	private CanvasGroup m_CanvasGroup; // 0x18

	// Properties
	public GameObject gameObject { get; }

	// Methods

	// RVA: 0x1EFCB80 Offset: 0x1EFCC81 VA: 0x1EFCB80
	public void .ctor(GameObject gameObject) { }

	// RVA: 0x1EFD190 Offset: 0x1EFD291 VA: 0x1EFD190 Slot: 4
	public virtual void Show() { }

	// RVA: 0x1EFD880 Offset: 0x1EFD981 VA: 0x1EFD880 Slot: 5
	public virtual void Hide() { }

	// RVA: 0x1EFE0D0 Offset: 0x1EFE1D1 VA: 0x1EFE0D0
	public GameObject get_gameObject() { }
}

// Namespace: 
private class DishAllMenuContent.CookHistory : DishAllMenuContent.HistoryObject // TypeDefIndex: 14221
{
	// Methods

	// RVA: 0x1EFCA70 Offset: 0x1EFCB71 VA: 0x1EFCA70
	public void .ctor(GameObject gameObject) { }

	// RVA: 0x1EFCC10 Offset: 0x1EFCD11 VA: 0x1EFCC10
	private void SetupCook() { }

	[CompilerGeneratedAttribute] // RVA: 0x2CE3E0 Offset: 0x2CE4E1 VA: 0x2CE3E0
	// RVA: 0x1EFCCC0 Offset: 0x1EFCDC1 VA: 0x1EFCCC0
	private void <SetupCook>b__1_0(Unit unit) { }
}

// Namespace: 
private class DishAllMenuContent.UnitsHistory : DishAllMenuContent.HistoryObject // TypeDefIndex: 14222
{
	// Fields
	private UnitIcon m_UnitIcon0; // 0x20
	private TextMeshProUGUI m_UnitName0; // 0x28
	private UnitIcon m_UnitIcon1; // 0x30
	private TextMeshProUGUI m_UnitName1; // 0x38
	private GameObject m_UnitGrp; // 0x40
	private GameObject m_Blank; // 0x48

	// Methods

	// RVA: 0x1EFE0E0 Offset: 0x1EFE1E1 VA: 0x1EFE0E0
	public void .ctor(GameObject gameObject, UnitIcon unitIcon0, TextMeshProUGUI unitName0, UnitIcon unitIcon1, TextMeshProUGUI unitName1) { }

	// RVA: 0x1EFE280 Offset: 0x1EFE381 VA: 0x1EFE280
	public void Show(List<Unit> unitList) { }

	// RVA: 0x1EFE4B0 Offset: 0x1EFE5B1 VA: 0x1EFE4B0 Slot: 5
	public override void Hide() { }
}

// Namespace: 
private class DishAllMenuContent.DishHistory : DishAllMenuContent.HistoryObject // TypeDefIndex: 14223
{
	// Fields
	private TextMeshProUGUI m_FoodName; // 0x20
	private GameObject m_DifficultyIcon; // 0x28
	private TextMeshProUGUI m_FoodDifficulty; // 0x30
	private List<DishAllMenuContent.EnhanceObject> m_EnhanceObjectList; // 0x38
	private GameObject m_Dish; // 0x40
	private GameObject m_Params; // 0x48
	private GameObject m_Blank0; // 0x50
	private GameObject m_Blank1; // 0x58

	// Methods

	// RVA: 0x1EFCEC0 Offset: 0x1EFCFC1 VA: 0x1EFCEC0
	public void .ctor(GameObject gameObject, TextMeshProUGUI foodName, GameObject difficultyIcon, TextMeshProUGUI foodDifficulty, List<DishAllMenuContent.EnhanceObject> enhanceObjectList) { }

	// RVA: 0x1EFD0C0 Offset: 0x1EFD1C1 VA: 0x1EFD0C0
	public void Show(FoodData food) { }

	// RVA: 0x1EFD720 Offset: 0x1EFD821 VA: 0x1EFD720 Slot: 5
	public override void Hide() { }

	// RVA: 0x1EFD1A0 Offset: 0x1EFD2A1 VA: 0x1EFD1A0
	private void SetFoodInfo(FoodData food) { }

	// RVA: 0x1EFD8A0 Offset: 0x1EFD9A1 VA: 0x1EFD8A0
	private CapabilityDefinition.Type GetEnhanceType(int index) { }
}

// Namespace: 
private class DishAllMenuContent.FoodstuffsHistory : DishAllMenuContent.HistoryObject // TypeDefIndex: 14224
{
	// Fields
	private List<GameObject> m_FoodstuffItemList; // 0x20
	private GameObject m_FoodstuffGroup; // 0x28
	private GameObject m_Nothing; // 0x30
	private GameObject m_Blank; // 0x38

	// Methods

	// RVA: 0x1EFD8D0 Offset: 0x1EFD9D1 VA: 0x1EFD8D0
	public void .ctor(GameObject gameObject, List<GameObject> foodstuffItemList, GameObject foodstuffGroup) { }

	// RVA: 0x1EFDA40 Offset: 0x1EFDB41 VA: 0x1EFDA40
	public void Show(List<FoodstuffData> foodstuffs) { }

	// RVA: 0x1EFDB20 Offset: 0x1EFDC21 VA: 0x1EFDB20
	private void SetFoodstuffs(List<FoodstuffData> foodstuffs) { }

	// RVA: 0x1EFDEF0 Offset: 0x1EFDFF1 VA: 0x1EFDEF0
	private void SetFoodstuffItem(GameObject contentItem, FoodstuffData data) { }

	// RVA: 0x1EFE020 Offset: 0x1EFE121 VA: 0x1EFE020 Slot: 5
	public override void Hide() { }
}

// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x279830 Offset: 0x279931 VA: 0x279830
[Serializable]
private sealed class DishAllMenuContent.<>c // TypeDefIndex: 14225
{
	// Fields
	public static readonly DishAllMenuContent.<>c <>9; // 0x0
	public static Action<DishAllMenuContent.HistoryObject> <>9__37_0; // 0x8

	// Methods

	// RVA: 0x1EFC9E0 Offset: 0x1EFCAE1 VA: 0x1EFC9E0
	private static void .cctor() { }

	// RVA: 0x1EFCA50 Offset: 0x1EFCB51 VA: 0x1EFCA50
	public void .ctor() { }

	// RVA: 0x1EFCA60 Offset: 0x1EFCB61 VA: 0x1EFCA60
	internal void <Awake>b__37_0(DishAllMenuContent.HistoryObject history) { }
}

