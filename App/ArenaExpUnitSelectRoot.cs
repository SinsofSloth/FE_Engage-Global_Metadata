// Namespace: App
public class ArenaExpUnitSelectRoot : MonoBehaviour // TypeDefIndex: 10976
{
	// Fields
	private const string PrefabPath = "UI/Hub/Arena/Prefabs/ArenaUnitSelectRoot";
	public ArenaExpUnitSelectMenuContent m_MenuContent; // 0x18
	public ArenaUnitSelectStatus m_Status; // 0x20
	private ArenaExpUnitSelectMenu.DecideEventHandler m_DecideEventHandler; // 0x28

	// Methods

	// RVA: 0x2108BF0 Offset: 0x2108CF1 VA: 0x2108BF0
	public static void LoadPrefabAsync() { }

	// RVA: 0x2108C70 Offset: 0x2108D71 VA: 0x2108C70
	public static bool IsLoadingPrefab() { }

	// RVA: 0x2108CF0 Offset: 0x2108DF1 VA: 0x2108CF0
	public static void UnloadPrefab() { }

	// RVA: 0x2108D70 Offset: 0x2108E71 VA: 0x2108D70
	public static ArenaExpUnitSelectRoot CreateBind(ProcInst super, Unit defaultUnit, ArenaExpUnitSelectMenu.DecideEventHandler decideEventHandler) { }

	// RVA: 0x2108EF0 Offset: 0x2108FF1 VA: 0x2108EF0
	private void Create(ProcInst super, Unit defaultUnit, ArenaExpUnitSelectMenu.DecideEventHandler decideEventHandler) { }

	// RVA: 0x21090C0 Offset: 0x21091C1 VA: 0x21090C0
	public void OnSelectMenuItem(Unit baseUnit) { }

	// RVA: 0x21091E0 Offset: 0x21092E1 VA: 0x21091E0
	public void OnDecideMenuItem(Unit unit) { }

	// RVA: 0x2109280 Offset: 0x2109381 VA: 0x2109280
	public void OnHelp(ProcInst parent) { }

	// RVA: 0x2109310 Offset: 0x2109411 VA: 0x2109310
	public void .ctor() { }
}

