// Namespace: App
public class ArenaBondUnitSelectRoot : MonoBehaviour // TypeDefIndex: 10965
{
	// Fields
	private const string PrefabPath = "UI/Hub/Arena/Prefabs/GodTrainingUnitSelectRoot";
	[SerializeField] // RVA: 0x296100 Offset: 0x296201 VA: 0x296100
	private ArenaBondUnitSelectMenuContent m_MenuContent; // 0x18
	[SerializeField] // RVA: 0x296110 Offset: 0x296211 VA: 0x296110
	private GodRoomGodInfoSetter m_GodInfo; // 0x20
	[SerializeField] // RVA: 0x296120 Offset: 0x296221 VA: 0x296120
	private ArenaUnitSelectStatus m_Status; // 0x28
	private ArenaBondUnitSelectMenu.DecideEventHandler m_DecideEventHandler; // 0x30

	// Methods

	// RVA: 0x2106AB0 Offset: 0x2106BB1 VA: 0x2106AB0
	public static void LoadPrefabAsync() { }

	// RVA: 0x2106B30 Offset: 0x2106C31 VA: 0x2106B30
	public static bool IsLoadingPrefab() { }

	// RVA: 0x2106BB0 Offset: 0x2106CB1 VA: 0x2106BB0
	public static void UnloadPrefab() { }

	// RVA: 0x2106C30 Offset: 0x2106D31 VA: 0x2106C30
	public static ArenaBondUnitSelectRoot CreateBind(ProcInst super, Unit defaultUnit, ArenaBondUnitSelectMenu.DecideEventHandler decideEventHandler) { }

	// RVA: 0x2106DB0 Offset: 0x2106EB1 VA: 0x2106DB0
	private void Create(ProcInst super, Unit defaultUnit, ArenaBondUnitSelectMenu.DecideEventHandler decideEventHandler) { }

	// RVA: 0x2107000 Offset: 0x2107101 VA: 0x2107000
	public void OnSelectMenuItem(Unit unit) { }

	// RVA: 0x2107140 Offset: 0x2107241 VA: 0x2107140
	public void OnDecideMenuItem(Unit unit) { }

	// RVA: 0x2107170 Offset: 0x2107271 VA: 0x2107170
	public void OnHelp(ProcInst parent) { }

	// RVA: 0x2107200 Offset: 0x2107301 VA: 0x2107200
	public void .ctor() { }
}

