// Namespace: App
public class ProfileCardAlbumRoot : MonoBehaviour // TypeDefIndex: 11560
{
	// Fields
	private const string PrefabPath = "UI/Network/ProfileCard/Prefabs/AlbumRoot";
	public ProfileCardRoot m_ProfileCardRoot; // 0x18
	public ProfileCardAlbumListMenuContent m_AlbumListMenuContent; // 0x20
	public TextMeshProUGUI m_PageText; // 0x28
	public TextMeshProUGUI m_PageMaxText; // 0x30
	public GameObject m_ArrowGroupObject; // 0x38

	// Methods

	// RVA: 0x2808840 Offset: 0x2808941 VA: 0x2808840
	public static void LoadPrefabAsync() { }

	// RVA: 0x28088E0 Offset: 0x28089E1 VA: 0x28088E0
	public static bool IsLoadingPrefab() { }

	// RVA: 0x2808960 Offset: 0x2808A61 VA: 0x2808960
	public static void UnloadPrefab() { }

	// RVA: 0x28089E0 Offset: 0x2808AE1 VA: 0x28089E0
	public static ProfileCardAlbumRoot CreateRoot() { }

	// RVA: 0x2808B50 Offset: 0x2808C51 VA: 0x2808B50
	private void .ctor() { }

	// RVA: 0x2808B60 Offset: 0x2808C61 VA: 0x2808B60
	private void Start() { }

	// RVA: 0x2808C70 Offset: 0x2808D71 VA: 0x2808C70
	public ProfileCardRoot GetProfileCardRoot() { }

	// RVA: 0x2808C80 Offset: 0x2808D81 VA: 0x2808C80
	public ProfileCardAlbumListMenuContent GetAlbumListMenuContent() { }

	// RVA: 0x2808C90 Offset: 0x2808D91 VA: 0x2808C90
	public void SetPageNum(int num, bool warningColor = False) { }

	// RVA: 0x2808B70 Offset: 0x2808C71 VA: 0x2808B70
	public void SetPageMax(int max) { }

	// RVA: 0x2808E50 Offset: 0x2808F51 VA: 0x2808E50
	public void SetActiveArrowGroup(bool enabled) { }

	// RVA: 0x2808F00 Offset: 0x2809001 VA: 0x2808F00
	public void Close() { }

	// RVA: 0x2809000 Offset: 0x2809101 VA: 0x2809000
	public bool IsClosing() { }

	// RVA: 0x28091E0 Offset: 0x28092E1 VA: 0x28091E0
	public void Destroy() { }
}

