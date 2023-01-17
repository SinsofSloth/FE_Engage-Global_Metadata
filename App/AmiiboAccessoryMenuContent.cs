// Namespace: App
public class AmiiboAccessoryMenuContent : BasicMenuContent // TypeDefIndex: 10388
{
	// Fields
	private const string PrefabPath = "UI/Network/Amiibo/Prefabs/AccExchangeRoot";
	[SerializeField] // RVA: 0x28DEF0 Offset: 0x28DFF1 VA: 0x28DEF0
	private GameObject m_HelpObj; // 0xE8
	[SerializeField] // RVA: 0x28DF00 Offset: 0x28E001 VA: 0x28DF00
	private TextMeshProUGUI m_HelpAccessoryName; // 0xF0
	[SerializeField] // RVA: 0x28DF10 Offset: 0x28E011 VA: 0x28DF10
	private TextMeshProUGUI m_HelpAccessoryHelp; // 0xF8
	[SerializeField] // RVA: 0x28DF20 Offset: 0x28E021 VA: 0x28DF20
	private Image m_HelpPartsIcon; // 0x100
	[SerializeField] // RVA: 0x28DF30 Offset: 0x28E031 VA: 0x28DF30
	private TextMeshProUGUI m_HelpPartsName; // 0x108
	[SerializeField] // RVA: 0x28DF40 Offset: 0x28E041 VA: 0x28DF40
	private GameObject m_HelpNgObj; // 0x110
	[SerializeField] // RVA: 0x28DF50 Offset: 0x28E051 VA: 0x28DF50
	private TextMeshProUGUI m_TicketValue; // 0x118
	[SerializeField] // RVA: 0x28DF60 Offset: 0x28E061 VA: 0x28DF60
	private TextMeshProUGUI m_UnitName; // 0x120

	// Methods

	// RVA: 0x20E56D0 Offset: 0x20E57D1 VA: 0x20E56D0
	public static void LoadPrefabAsync() { }

	// RVA: 0x20E5770 Offset: 0x20E5871 VA: 0x20E5770
	public static bool IsLoadingPrefab() { }

	// RVA: 0x20E57F0 Offset: 0x20E58F1 VA: 0x20E57F0
	public static void UnloadPrefab() { }

	// RVA: 0x20E2D30 Offset: 0x20E2E31 VA: 0x20E2D30
	public static AmiiboAccessoryMenuContent Create() { }

	// RVA: 0x20E5870 Offset: 0x20E5971 VA: 0x20E5870 Slot: 21
	public override float CalcW() { }

	// RVA: 0x20E58E0 Offset: 0x20E59E1 VA: 0x20E58E0 Slot: 22
	public override float CalcH() { }

	// RVA: 0x20E5950 Offset: 0x20E5A51 VA: 0x20E5950 Slot: 27
	public override void AfterBuild() { }

	// RVA: 0x20E5980 Offset: 0x20E5A81 VA: 0x20E5980 Slot: 10
	protected override float CalcCursorMovedPosY(int menuItemIndex) { }

	// RVA: 0x20E4FE0 Offset: 0x20E50E1 VA: 0x20E4FE0
	public void UpdateTicketValue() { }

	// RVA: 0x20E2F80 Offset: 0x20E3081 VA: 0x20E2F80
	public void HideMenuInfo() { }

	// RVA: 0x20E4680 Offset: 0x20E4781 VA: 0x20E4680
	public void SetMenuInfo(AccessoryData data, bool isNg) { }

	// RVA: 0x20E3420 Offset: 0x20E3521 VA: 0x20E3420
	public void SetUnitName(string unitName) { }

	// RVA: 0x20E5A70 Offset: 0x20E5B71 VA: 0x20E5A70
	public void .ctor() { }
}

