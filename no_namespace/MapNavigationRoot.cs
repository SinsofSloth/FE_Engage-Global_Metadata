// Namespace: 
public class MapNavigationRoot : MonoBehaviour // TypeDefIndex: 7731
{
	// Fields
	private const string PrefabPath = "UI/Map/MapNavigation/Prefabs/MapNavigationRoot";
	public GameObject m_StatusMenuContentObject; // 0x18
	public GameObject m_MiniMapMenuContentObject; // 0x20
	public TextMeshProUGUI m_StatusTitleText; // 0x28
	public TextMeshProUGUI m_MiniMapTitleText; // 0x30

	// Methods

	// RVA: 0x2210BF0 Offset: 0x2210CF1 VA: 0x2210BF0
	public static void LoadPrefab() { }

	// RVA: 0x2210C70 Offset: 0x2210D71 VA: 0x2210C70
	public static void UnloadPrefab() { }

	// RVA: 0x2210CF0 Offset: 0x2210DF1 VA: 0x2210CF0
	public static bool IsLoadingPrefab() { }

	// RVA: 0x2210D70 Offset: 0x2210E71 VA: 0x2210D70
	public static GameObject Create() { }

	// RVA: 0x2210FD0 Offset: 0x22110D1 VA: 0x2210FD0
	public static void Destroy(GameObject gameObject) { }

	// RVA: 0x2210E30 Offset: 0x2210F31 VA: 0x2210E30
	private void SetTitleText() { }

	// RVA: 0x2211040 Offset: 0x2211141 VA: 0x2211040
	public MapNavigationStatusMenuContent GetStatusMenuContent() { }

	// RVA: 0x22108F0 Offset: 0x22109F1 VA: 0x22108F0
	public MapNavigationMiniMapMenuContent GetMiniMapMenuContent() { }

	// RVA: 0x22110A0 Offset: 0x22111A1 VA: 0x22110A0
	public Animator GetAnimator() { }

	// RVA: 0x2211100 Offset: 0x2211201 VA: 0x2211100
	public void .ctor() { }
}

