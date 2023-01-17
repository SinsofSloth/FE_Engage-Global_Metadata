// Namespace: App
public class DishResultDialog : ProcInst // TypeDefIndex: 10490
{
	// Fields
	private const string PrefabPath = "UI/Hub/CafeTerrace/Cafe/Prefabs/DishResultRoot";
	private GameObject m_DishResultRoot; // 0x70
	private DishResultDialogContent m_ResultContent; // 0x78
	private Dish m_Dish; // 0x80
	private List<Unit> m_SelectedUnits; // 0x88

	// Methods

	// RVA: 0x2379920 Offset: 0x2379A21 VA: 0x2379920
	public static void LoadPrefabAsync() { }

	// RVA: 0x23799C0 Offset: 0x2379AC1 VA: 0x23799C0
	public static bool IsLoadingPrefab() { }

	// RVA: 0x2379A40 Offset: 0x2379B41 VA: 0x2379A40
	public static void UnloadPrefab() { }

	// RVA: 0x2379AC0 Offset: 0x2379BC1 VA: 0x2379AC0
	public void .ctor(Dish dish, List<Unit> selectedUnits) { }

	// RVA: 0x2379B10 Offset: 0x2379C11 VA: 0x2379B10
	private void CreateWindow() { }

	// RVA: 0x237A410 Offset: 0x237A511 VA: 0x237A410
	private bool IsOpening() { }

	// RVA: 0x237A4D0 Offset: 0x237A5D1 VA: 0x237A4D0
	private void Tick() { }

	// RVA: 0x237A830 Offset: 0x237A931 VA: 0x237A830
	private bool IsClosing() { }

	// RVA: 0x237A8F0 Offset: 0x237A9F1 VA: 0x237A8F0
	private void DeleteWindow() { }

	// RVA: 0x237A960 Offset: 0x237AA61 VA: 0x237A960
	public static void CreateBind(ProcInst super, Dish dish, List<Unit> selectedUnits) { }
}

