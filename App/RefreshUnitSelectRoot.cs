// Namespace: App
public class RefreshUnitSelectRoot : MonoBehaviour // TypeDefIndex: 11712
{
	// Fields
	private const string PrefabPath = "UI/Hub/Refresh/Prefabs/RefreshUnitSelectRoot";
	public RefreshUnitSetMenuContent m_RefreshUnitSetMenuContent; // 0x18
	public RefreshUnitSelectMenuContent m_RefreshUnitSelectMenuContent; // 0x20
	public RefreshFacilitySelectMenuContent m_RefreshFacilitySelectMenuContent; // 0x28
	[HeaderAttribute] // RVA: 0x298C80 Offset: 0x298D81 VA: 0x298C80
	public Animator m_SettingInfoWindowAnimator; // 0x30
	[SpaceAttribute] // RVA: 0x298CC0 Offset: 0x298DC1 VA: 0x298CC0
	public CanvasGroup m_FacilityWindowCanvasGroup; // 0x38
	public TextMeshProUGUI m_FacilityWindowCaptionText; // 0x40
	public TextMeshProUGUI m_FacilityWindowNameText; // 0x48
	[SpaceAttribute] // RVA: 0x298CE0 Offset: 0x298DE1 VA: 0x298CE0
	public CanvasGroup m_UnitWindowCanvasGroup; // 0x50
	public TextMeshProUGUI m_UnitWindowCaptionText; // 0x58
	public RefreshUnitSelectRoot.UnitWindowUnitInfo[] m_UnitWindowUnitInfo; // 0x60
	[SpaceAttribute] // RVA: 0x298D00 Offset: 0x298E01 VA: 0x298D00
	public CanvasGroup m_RelianceWindowCanvasGroup; // 0x68
	public TextMeshProUGUI m_RelianceWindowCaptionText; // 0x70
	public Image m_RelianceWindowRankCImage; // 0x78
	public Image m_RelianceWindowRankBImage; // 0x80
	public Image m_RelianceWindowRankAImage; // 0x88
	public Image m_RelianceWindowRankSImage; // 0x90
	public Image m_RelianceWindowNoneImage; // 0x98
	[HeaderAttribute] // RVA: 0x298D20 Offset: 0x298E21 VA: 0x298D20
	public GameObject m_HelpWindowObject; // 0xA0
	public Animator m_HelpWindowAnimator; // 0xA8
	public TextMeshProUGUI m_HelpWindowCaptionText; // 0xB0
	public UnitIcon[] m_HelpWindowUnitIcon; // 0xB8
	public GameObject m_HelpWindowRankRootObject; // 0xC0
	public Image m_HelpWindowRankCImage; // 0xC8
	public Image m_HelpWindowRankBImage; // 0xD0
	public Image m_HelpWindowRankAImage; // 0xD8
	public Image m_HelpWindowRankSImage; // 0xE0
	public Image m_HelpWindowRankNoneImage; // 0xE8
	public TextMeshProUGUI m_HelpWindowMessageText; // 0xF0

	// Methods

	// RVA: 0x252C190 Offset: 0x252C291 VA: 0x252C190
	public static void LoadPrefabAsync() { }

	// RVA: 0x252C2B0 Offset: 0x252C3B1 VA: 0x252C2B0
	public static bool IsLoadingPrefab() { }

	// RVA: 0x252F6A0 Offset: 0x252F7A1 VA: 0x252F6A0
	public static void UnloadPrefab() { }

	// RVA: 0x252C880 Offset: 0x252C981 VA: 0x252C880
	public static RefreshUnitSelectRoot CreateRoot() { }

	// RVA: 0x2531AA0 Offset: 0x2531BA1 VA: 0x2531AA0
	private void .ctor() { }

	// RVA: 0x2531AB0 Offset: 0x2531BB1 VA: 0x2531AB0
	private void Start() { }

	// RVA: 0x2531C10 Offset: 0x2531D11 VA: 0x2531C10
	public RefreshUnitSetMenuContent GetRefreshUnitSetMenuContent() { }

	// RVA: 0x2531C20 Offset: 0x2531D21 VA: 0x2531C20
	public RefreshUnitSelectMenuContent GetRefreshUnitSelectMenuContent() { }

	// RVA: 0x2531C30 Offset: 0x2531D31 VA: 0x2531C30
	public RefreshFacilitySelectMenuContent GetRefreshFacilitySelectMenuContent() { }

	// RVA: 0x252EB60 Offset: 0x252EC61 VA: 0x252EB60
	public void CloseSettingInfoWindow() { }

	// RVA: 0x252ECB0 Offset: 0x252EDB1 VA: 0x252ECB0
	public bool IsClosedSettingInfoWindow() { }

	// RVA: 0x252C9F0 Offset: 0x252CAF1 VA: 0x252C9F0
	public void SetFacilityWindow(bool enabled, HubFacilityData facilityData) { }

	// RVA: 0x252CBC0 Offset: 0x252CCC1 VA: 0x252CBC0
	public void SetUnitWindow(bool enabled, Unit[] unit) { }

	// RVA: 0x252CEB0 Offset: 0x252CFB1 VA: 0x252CEB0
	public void SetRelianceWindow(bool enabled, Unit unit0, Unit unit1) { }

	// RVA: 0x252E690 Offset: 0x252E791 VA: 0x252E690
	public void SetActiveHelpWindow(bool actived) { }

	// RVA: 0x2531C40 Offset: 0x2531D41 VA: 0x2531C40
	public void SetHelpWindow(Unit[] units) { }

	// RVA: 0x2531EA0 Offset: 0x2531FA1 VA: 0x2531EA0
	public void SetHelpWindow(string captionMid, string messageMid) { }

	// RVA: 0x25320E0 Offset: 0x25321E1 VA: 0x25320E0
	public void CloseHelpWindow() { }

	// RVA: 0x252EE10 Offset: 0x252EF11 VA: 0x252EE10
	public void Destroy() { }
}

