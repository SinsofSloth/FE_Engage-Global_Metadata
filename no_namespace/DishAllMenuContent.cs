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

