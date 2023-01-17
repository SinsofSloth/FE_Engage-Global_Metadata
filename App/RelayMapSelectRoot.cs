// Namespace: App
internal class RelayMapSelectRoot : MonoBehaviour // TypeDefIndex: 12880
{
	// Fields
	private const string PrefabPath = "UI/Network/Relay/Prefabs/RelayMapSelectRoot";
	public GameObject m_MapHelpObject; // 0x18
	private RelayMapMenu m_MapMenu; // 0x20
	private RelayWdwMapHelp m_WdwMapHelp; // 0x28

	// Methods

	// RVA: 0x24B8080 Offset: 0x24B8181 VA: 0x24B8080
	public static RelayMapSelectRoot CreateBind(ProcInst super) { }

	// RVA: 0x24B8270 Offset: 0x24B8371 VA: 0x24B8270
	public static bool CheckExistEnableItem() { }

	// RVA: 0x24B7C20 Offset: 0x24B7D21 VA: 0x24B7C20
	public static bool CanSelectNewRelayMap(ChapterData chapter) { }

	// RVA: 0x24B8780 Offset: 0x24B8881 VA: 0x24B8780
	public static void LoadPrefabAsync() { }

	// RVA: 0x24B8820 Offset: 0x24B8921 VA: 0x24B8820
	public static bool IsLoadingPrefab() { }

	// RVA: 0x24B8AB0 Offset: 0x24B8BB1 VA: 0x24B8AB0
	public static void UnloadPrefab() { }

	// RVA: 0x24B8D50 Offset: 0x24B8E51 VA: 0x24B8D50
	protected void .ctor() { }

	// RVA: 0x24B8590 Offset: 0x24B8691 VA: 0x24B8590
	private void Create(ProcInst super) { }

	// RVA: 0x24B8D60 Offset: 0x24B8E61 VA: 0x24B8D60
	public void OnSelectMenuItem(RelayData relayData) { }

	// RVA: 0x24B8E10 Offset: 0x24B8F11 VA: 0x24B8E10
	public void OnDecideMenuItem() { }

	// RVA: 0x24B8E30 Offset: 0x24B8F31 VA: 0x24B8E30
	public void OnRequestCloseMenu() { }
}

