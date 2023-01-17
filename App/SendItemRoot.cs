// Namespace: App
public class SendItemRoot : MonoBehaviour // TypeDefIndex: 12669
{
	// Fields
	private static readonly string PrefabPath; // 0x0
	public SendItemMenuContent m_SendItemMenuContent; // 0x18
	public GameObject m_MenuHelpObject; // 0x20
	public Animator m_MenuHelpAnimator; // 0x28
	public TextMeshProUGUI m_MessageText; // 0x30
	public GameObject m_ItemHelpObject; // 0x38
	public Animator m_ItemHelpAnimator; // 0x40
	public ItemMenuDetailSetter m_ItemMenuDetailSetter; // 0x48
	private Unit m_Unit; // 0x50
	private UnitItem m_UnitItem; // 0x58
	private bool m_ItemDetailDisplayWithUnit; // 0x60

	// Methods

	// RVA: 0x232AA30 Offset: 0x232AB31 VA: 0x232AA30
	public static void LoadPrefabAsync() { }

	// RVA: 0x232AAF0 Offset: 0x232ABF1 VA: 0x232AAF0
	public static bool IsLoadingPrefab() { }

	// RVA: 0x232AB90 Offset: 0x232AC91 VA: 0x232AB90
	public static void UnloadPrefab() { }

	// RVA: 0x2329A90 Offset: 0x2329B91 VA: 0x2329A90
	public static SendItemRoot Create() { }

	// RVA: 0x232AC30 Offset: 0x232AD31 VA: 0x232AC30
	private void Start() { }

	// RVA: 0x232AD30 Offset: 0x232AE31 VA: 0x232AD30
	public SendItemMenuContent GetSendItemMenuContent() { }

	// RVA: 0x2329F80 Offset: 0x232A081 VA: 0x2329F80
	public void Show() { }

	// RVA: 0x2329DA0 Offset: 0x2329EA1 VA: 0x2329DA0
	public void Hide() { }

	// RVA: 0x232AD40 Offset: 0x232AE41 VA: 0x232AD40
	public void OnSelect(Unit unit, UnitItem unitItem) { }

	// RVA: 0x232A1B0 Offset: 0x232A2B1 VA: 0x232A1B0
	public void OnSwitchDetailDisplayWay() { }

	// RVA: 0x232AD80 Offset: 0x232AE81 VA: 0x232AD80
	private void UpdateItemDetail() { }

	// RVA: 0x232A2E0 Offset: 0x232A3E1 VA: 0x232A2E0
	public void Close() { }

	// RVA: 0x232A520 Offset: 0x232A621 VA: 0x232A520
	public void Destroy() { }

	// RVA: 0x232AEB0 Offset: 0x232AFB1 VA: 0x232AEB0
	public void .ctor() { }

	// RVA: 0x232AEC0 Offset: 0x232AFC1 VA: 0x232AEC0
	private static void .cctor() { }
}

