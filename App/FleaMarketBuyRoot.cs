// Namespace: App
public class FleaMarketBuyRoot : MonoBehaviour // TypeDefIndex: 10979
{
	// Fields
	private const string PrefabPath = "UI/Hub/Shop/Prefabs/ShopFleaMarketBuyRoot";
	public GameObject m_MenuObject; // 0x18
	public GameObject m_HoldingInfoWindowObject; // 0x20
	private Unit m_Unit; // 0x28
	private ItemShopBuyMenu m_FleaMarketBuyMenu; // 0x30
	private ItemHoldingInfoWindow m_ItemHoldingInfoWindow; // 0x38
	private FleaMarketBuyRoot.ReturnEventHandler m_ReturnEventHandler; // 0x40
	private UnitItem m_UnitItem; // 0x48
	private ItemData m_ItemData; // 0x50
	private bool m_IsSendingItemToTransporter; // 0x58
	private bool m_IsSendingUnitItem; // 0x59
	private int m_SendingUnitItemIndex; // 0x5C
	private bool m_IsDiscardingTransporterItem; // 0x60
	private int m_DiscardingTransporterItemIndex; // 0x64
	private bool m_IsEnabledVoice; // 0x68

	// Methods

	// RVA: 0x29F84D0 Offset: 0x29F85D1 VA: 0x29F84D0
	public static void LoadPrefabAsync() { }

	// RVA: 0x29F8570 Offset: 0x29F8671 VA: 0x29F8570
	public static bool IsLoadingPrefab() { }

	// RVA: 0x29F85F0 Offset: 0x29F86F1 VA: 0x29F85F0
	public static void UnloadPrefab() { }

	// RVA: 0x29F8670 Offset: 0x29F8771 VA: 0x29F8670
	public static FleaMarketBuyRoot CreateBind(ProcInst super, Unit unit, FleaMarketBuyRoot.ReturnEventHandler returnEventHandler, bool isEnabledVoice) { }

	// RVA: 0x29F8820 Offset: 0x29F8921 VA: 0x29F8820
	private void Create(ProcInst super, Unit unit, FleaMarketBuyRoot.ReturnEventHandler returnEventHandler, bool isEnabledVoice) { }

	// RVA: 0x29F8B90 Offset: 0x29F8C91 VA: 0x29F8B90
	public static void Destroy(FleaMarketBuyRoot root) { }

	// RVA: 0x29F8C80 Offset: 0x29F8D81 VA: 0x29F8C80
	protected void .ctor() { }

	// RVA: 0x29F8C90 Offset: 0x29F8D91 VA: 0x29F8C90
	public void OnSelectMenuItem(UnitItem unitItem) { }

	// RVA: 0x29F8D50 Offset: 0x29F8E51 VA: 0x29F8D50
	public bool OnDecideMenuItem(ItemData itemData) { }

	// RVA: 0x29F8EA0 Offset: 0x29F8FA1 VA: 0x29F8EA0
	public void OnYesToBuy() { }

	// RVA: 0x29F9470 Offset: 0x29F9571 VA: 0x29F9470
	public void OnDecideToSendItem(bool isSelectingUnitItem, int unitItemIndex) { }

	// RVA: 0x29F9670 Offset: 0x29F9771 VA: 0x29F9670
	public void OnCancelToSendItem() { }

	// RVA: 0x29F9760 Offset: 0x29F9861 VA: 0x29F9760
	public void OnDecidelToDiscardItem(bool transporterIsSelected, int transporterItemIndex) { }

	// RVA: 0x29F9870 Offset: 0x29F9971 VA: 0x29F9870
	public void OnCancelToDiscardItem() { }

	// RVA: 0x29F9260 Offset: 0x29F9361 VA: 0x29F9260
	public void OnBuy() { }

	// RVA: 0x29F9A30 Offset: 0x29F9B31 VA: 0x29F9A30
	public void OnRequestClose() { }

	// RVA: 0x29F9A40 Offset: 0x29F9B41 VA: 0x29F9A40
	public void Close() { }
}

