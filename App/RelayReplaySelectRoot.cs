// Namespace: App
internal class RelayReplaySelectRoot : MonoBehaviour // TypeDefIndex: 12907
{
	// Fields
	private const string PrefabPath = "UI/Network/Relay/Prefabs/RelayReplaySelectRoot";
	public GameObject m_MapHelpObject; // 0x18
	public GameObject m_PlayerListObject; // 0x20
	private RelayReplayMenu m_MapMenu; // 0x28
	private RelayWdwMapHelp m_WdwMapHelp; // 0x30
	private RelayWdwPlayerList m_WdwPlayerList; // 0x38

	// Methods

	// RVA: 0x24BDE10 Offset: 0x24BDF11 VA: 0x24BDE10
	public static RelayReplaySelectRoot CreateBind(ProcInst super, List<RelayServerMetaData> searchResults) { }

	// RVA: 0x24BE1C0 Offset: 0x24BE2C1 VA: 0x24BE1C0
	public static void LoadPrefabAsync() { }

	// RVA: 0x24BE260 Offset: 0x24BE361 VA: 0x24BE260
	public static bool IsLoadingPrefab() { }

	// RVA: 0x24BE2E0 Offset: 0x24BE3E1 VA: 0x24BE2E0
	public static void UnloadPrefab() { }

	// RVA: 0x24BE360 Offset: 0x24BE461 VA: 0x24BE360
	protected void .ctor() { }

	// RVA: 0x24BDF70 Offset: 0x24BE071 VA: 0x24BDF70
	private void Create(ProcInst super, List<RelayServerMetaData> searchResults) { }

	// RVA: 0x24BE370 Offset: 0x24BE471 VA: 0x24BE370
	public void OnSelectMenuItem(RelayServerMetaData metaData) { }

	// RVA: 0x24BED20 Offset: 0x24BEE21 VA: 0x24BED20
	public void OnDecideMenuItem() { }

	// RVA: 0x24BED40 Offset: 0x24BEE41 VA: 0x24BED40
	public void OnRequestCloseMenu() { }
}

