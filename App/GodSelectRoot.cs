// Namespace: App
public class GodSelectRoot : MonoBehaviour // TypeDefIndex: 11731
{
	// Fields
	private const string PrefabPath = "UI/Hub/GodRoom/Prefabs/GodSelectRoot";
	public GameObject m_RingInfo; // 0x18
	public GameObject m_GodListRoot; // 0x20
	public RingInfoController m_RingInfoController; // 0x28
	public RefineRingInfoWindow m_RefineRingInfoWindow; // 0x30
	private GodUnitSelectMenu.DecideEventHandler m_DecideEventHandler; // 0x38
	private static GodSelectRoot s_RootInstance; // 0x0

	// Methods

	// RVA: 0x27AD280 Offset: 0x27AD381 VA: 0x27AD280
	public static void LoadPrefabAsync() { }

	// RVA: 0x27AD3E0 Offset: 0x27AD4E1 VA: 0x27AD3E0
	public static bool IsLoadingPrefab() { }

	// RVA: 0x27ADDE0 Offset: 0x27ADEE1 VA: 0x27ADDE0
	public static void UnloadPrefab() { }

	// RVA: 0x27B0810 Offset: 0x27B0911 VA: 0x27B0810
	public static GodSelectRoot CreateBind(ProcInst super, GodUnitSelectMenu.DecideEventHandler decideEventHandler, GodUnit selectedGod) { }

	// RVA: 0x27B09C0 Offset: 0x27B0AC1 VA: 0x27B09C0
	private void Create(ProcInst super, GodUnitSelectMenu.DecideEventHandler decideEventHandler, GodUnit selectedGod) { }

	// RVA: 0x27B1050 Offset: 0x27B1151 VA: 0x27B1050
	public static GodSelectRoot CreateBindForRefineRing(GodUnitSelectMenu.DecideEventHandler decideEventHandler, GodUnit selectedGod) { }

	// RVA: 0x27B11E0 Offset: 0x27B12E1 VA: 0x27B11E0
	private void CreateForRefineRing(GodUnitSelectMenu.DecideEventHandler decideEventHandler, GodUnit selectedGod) { }

	// RVA: 0x27B1340 Offset: 0x27B1441 VA: 0x27B1340
	public GodUnitSelectMenu.SelectEventHandler GetSelectEventHandlerForRefineRing() { }

	// RVA: 0x27B13C0 Offset: 0x27B14C1 VA: 0x27B13C0
	public static void Destroy(GodSelectRoot root) { }

	// RVA: 0x27B1550 Offset: 0x27B1651 VA: 0x27B1550
	public void CloseStatus() { }

	// RVA: 0x27B1620 Offset: 0x27B1721 VA: 0x27B1620
	private void OnSelectMenuItem(GodUnit god, RingCleaningSequence.GodType type) { }

	// RVA: 0x27B17A0 Offset: 0x27B18A1 VA: 0x27B17A0
	private void OnSelectMenuItemForRefineRing(GodUnit god, RingCleaningSequence.GodType type) { }

	// RVA: 0x27B1710 Offset: 0x27B1811 VA: 0x27B1710
	private void ShowModel(GodUnit godUnit, RingCleaningSequence.GodType type) { }

	// RVA: 0x27B0F70 Offset: 0x27B1071 VA: 0x27B0F70
	private void SetupRingImage() { }

	// RVA: 0x27B1830 Offset: 0x27B1931 VA: 0x27B1830
	public void .ctor() { }

	// RVA: 0x27B1840 Offset: 0x27B1941 VA: 0x27B1840
	private static void .cctor() { }
}

