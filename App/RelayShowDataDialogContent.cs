// Namespace: App
internal class RelayShowDataDialogContent : GameMessageContent // TypeDefIndex: 12913
{
	// Fields
	private const string PrefabPath = "UI/Network/Relay/Prefabs/WdwDialogRelayShowData";
	public RelayWdwMapHelp m_MapHelp; // 0x48
	public RelayWdwPlayerList m_PlayerList; // 0x50
	public GameObject m_Play; // 0x58
	public GameObject m_StampRoot; // 0x60
	public RelayMessageMenuItemContent m_PlayStamp; // 0x68
	public GameObject m_PlayEnd; // 0x70
	public GameObject m_PlayEndWin; // 0x78
	public GameObject m_PlayEndLose; // 0x80
	public GameObject m_TakeOverTitle; // 0x88

	// Methods

	// RVA: 0x24C3D60 Offset: 0x24C3E61 VA: 0x24C3D60
	public static void LoadPrefabAsync() { }

	// RVA: 0x24C3E00 Offset: 0x24C3F01 VA: 0x24C3E00
	public static bool IsLoadingPrefab() { }

	// RVA: 0x24C3E80 Offset: 0x24C3F81 VA: 0x24C3E80
	public static void UnloadPrefab() { }

	// RVA: 0x24C3C10 Offset: 0x24C3D11 VA: 0x24C3C10
	public static RelayShowDataDialogContent Create(RelayServerMetaData metaData, RelayShowDataDialog.Mode mode) { }

	// RVA: 0x24C3F00 Offset: 0x24C4001 VA: 0x24C3F00
	public void Setup(RelayServerMetaData metaData, RelayShowDataDialog.Mode mode) { }

	// RVA: 0x24C4510 Offset: 0x24C4611 VA: 0x24C4510
	public void .ctor() { }
}

