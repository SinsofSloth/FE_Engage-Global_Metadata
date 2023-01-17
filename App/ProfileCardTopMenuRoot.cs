// Namespace: App
public class ProfileCardTopMenuRoot : MonoBehaviour // TypeDefIndex: 11661
{
	// Fields
	private const string PrefabPath = "UI/Network/ProfileCard/Prefabs/ProfileCardTopMenuRoot";
	public ProfileCardTopMenuContent m_ProfileCardTopMenuContent; // 0x18
	public Animator m_InfoWindowAnimator; // 0x20
	public TextMeshProUGUI m_InfoWindowCaptionText; // 0x28
	public TextMeshProUGUI m_InfoWindowDescriptionText; // 0x30
	public TextMeshProUGUI m_InfoWindowWarningText; // 0x38

	// Methods

	// RVA: 0x2EE5860 Offset: 0x2EE5961 VA: 0x2EE5860
	public static void LoadPrefabAsync() { }

	// RVA: 0x2EE5900 Offset: 0x2EE5A01 VA: 0x2EE5900
	public static bool IsLoadingPrefab() { }

	// RVA: 0x2EE5980 Offset: 0x2EE5A81 VA: 0x2EE5980
	public static void UnloadPrefab() { }

	// RVA: 0x2EE4E70 Offset: 0x2EE4F71 VA: 0x2EE4E70
	public static ProfileCardTopMenuRoot CreateRoot() { }

	// RVA: 0x2EE5A00 Offset: 0x2EE5B01 VA: 0x2EE5A00
	private void .ctor() { }

	// RVA: 0x2EE5A10 Offset: 0x2EE5B11 VA: 0x2EE5A10
	public ProfileCardTopMenuContent GetProfileCardTopMenuContent() { }

	// RVA: 0x2EE5120 Offset: 0x2EE5221 VA: 0x2EE5120
	public void UpdateInfoWindow(string captionMid, string descriptionMid, string warningMid) { }

	// RVA: 0x2EE53D0 Offset: 0x2EE54D1 VA: 0x2EE53D0
	public void Close() { }

	// RVA: 0x2EE5600 Offset: 0x2EE5701 VA: 0x2EE5600
	public void Destroy() { }
}

