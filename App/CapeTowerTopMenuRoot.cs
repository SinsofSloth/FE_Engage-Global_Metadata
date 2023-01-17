// Namespace: App
public class CapeTowerTopMenuRoot : MonoBehaviour // TypeDefIndex: 10476
{
	// Fields
	private const string PrefabPath = "UI/Network/CapeTower/Prefabs/CapeTowerTopMenuRoot";
	public CapeTowerTopMenuContent m_CapeTowerTopMenuContent; // 0x18
	public GameObject m_InfoWindow; // 0x20
	public Animator m_InfoWindowAnimator; // 0x28
	public TextMeshProUGUI m_InfoWindowCaptionText; // 0x30
	public TextMeshProUGUI m_InfoWindowDescriptionText; // 0x38

	// Methods

	// RVA: 0x29AB430 Offset: 0x29AB531 VA: 0x29AB430
	public static void LoadPrefabAsync() { }

	// RVA: 0x29AB570 Offset: 0x29AB671 VA: 0x29AB570
	public static bool IsLoadingPrefab() { }

	// RVA: 0x29AC260 Offset: 0x29AC361 VA: 0x29AC260
	public static void UnloadPrefab() { }

	// RVA: 0x29AC2F0 Offset: 0x29AC3F1 VA: 0x29AC2F0
	public static CapeTowerTopMenuRoot CreateRoot() { }

	// RVA: 0x29ACD00 Offset: 0x29ACE01 VA: 0x29ACD00
	private void Create() { }

	// RVA: 0x29ACD10 Offset: 0x29ACE11 VA: 0x29ACD10
	private void .ctor() { }

	// RVA: 0x29ACD20 Offset: 0x29ACE21 VA: 0x29ACD20
	public CapeTowerTopMenuContent GetCapeTowerTopMenuContent() { }

	// RVA: 0x29AC600 Offset: 0x29AC701 VA: 0x29AC600
	public void UpdateInfoWindow(string captionMid, string descriptionMid) { }

	// RVA: 0x29AC7B0 Offset: 0x29AC8B1 VA: 0x29AC7B0
	public void Close() { }

	// RVA: 0x29AC9D0 Offset: 0x29ACAD1 VA: 0x29AC9D0
	public void Destroy() { }
}

