// Namespace: App
internal class RelayWdwMapHelp : MonoBehaviour // TypeDefIndex: 12921
{
	// Fields
	public TextMeshProUGUI m_MapName; // 0x18
	public TextMeshProUGUI m_Turn; // 0x20
	public Image m_MapImage; // 0x28
	public List<GameObject> m_ItemList; // 0x30
	public GameObject m_IdRoot; // 0x38
	public TextMeshProUGUI m_Id; // 0x40
	private List<RelayWdwMapHelp.ShowItem> m_ShowItemList; // 0x48
	private List<ItemData> m_AwardItemList; // 0x50

	// Methods

	// RVA: 0x24C9080 Offset: 0x24C9181 VA: 0x24C9080
	private void .ctor() { }

	// RVA: 0x24B8E00 Offset: 0x24B8F01 VA: 0x24B8E00
	public void SetData(RelayData relayData) { }

	// RVA: 0x24C4240 Offset: 0x24C4341 VA: 0x24C4240
	public void SetData(RelayServerMetaData metaData, bool isReplay) { }

	// RVA: 0x24BE4B0 Offset: 0x24BE5B1 VA: 0x24BE4B0
	public void SetData(RelayData relayData, RelayServerMetaData metaData, bool isReplay) { }
}

