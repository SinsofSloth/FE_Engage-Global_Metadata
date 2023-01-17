// Namespace: App
public class DiscardItemRoot : MonoBehaviour // TypeDefIndex: 12546
{
	// Fields
	private static readonly string PrefabPath; // 0x0
	public DiscardItemMenuContent m_DiscardItemMenuContent; // 0x18
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

	// RVA: 0x2376550 Offset: 0x2376651 VA: 0x2376550
	public static void LoadPrefabAsync() { }

	// RVA: 0x2376610 Offset: 0x2376711 VA: 0x2376610
	public static bool IsLoadingPrefab() { }

	// RVA: 0x23766B0 Offset: 0x23767B1 VA: 0x23766B0
	public static void UnloadPrefab() { }

	// RVA: 0x23748D0 Offset: 0x23749D1 VA: 0x23748D0
	public static DiscardItemRoot Create() { }

	// RVA: 0x2376750 Offset: 0x2376851 VA: 0x2376750
	private void Start() { }

	// RVA: 0x2376850 Offset: 0x2376951 VA: 0x2376850
	public DiscardItemMenuContent GetSendItemMenuContent() { }

	// RVA: 0x2375030 Offset: 0x2375131 VA: 0x2375030
	public void Show() { }

	// RVA: 0x2374EA0 Offset: 0x2374FA1 VA: 0x2374EA0
	public void Hide() { }

	// RVA: 0x2376860 Offset: 0x2376961 VA: 0x2376860
	public void OnSelect(Unit unit, UnitItem unitItem) { }

	// RVA: 0x2375AE0 Offset: 0x2375BE1 VA: 0x2375AE0
	public void OnSwitchDetailDisplayWay() { }

	// RVA: 0x23768A0 Offset: 0x23769A1 VA: 0x23768A0
	private void UpdateItemDetail() { }

	// RVA: 0x2375B80 Offset: 0x2375C81 VA: 0x2375B80
	public void Close() { }

	// RVA: 0x2375DC0 Offset: 0x2375EC1 VA: 0x2375DC0
	public void Destroy() { }

	// RVA: 0x23769D0 Offset: 0x2376AD1 VA: 0x23769D0
	public void .ctor() { }

	// RVA: 0x23769E0 Offset: 0x2376AE1 VA: 0x23769E0
	private static void .cctor() { }
}

