// Namespace: App
public class VersusViolationTopContent : MonoBehaviour // TypeDefIndex: 13736
{
	// Fields
	private const string PrefabPath = "UI/Network/Versus/Prefabs/VersusViolationTop";
	[HeaderAttribute] // RVA: 0x29C9C0 Offset: 0x29CAC1 VA: 0x29C9C0
	[SerializeField] // RVA: 0x29C9C0 Offset: 0x29CAC1 VA: 0x29C9C0
	private Image m_CaptureImage; // 0x18
	[SerializeField] // RVA: 0x29CA10 Offset: 0x29CB11 VA: 0x29CA10
	private TextMeshProUGUI m_CategoryText; // 0x20
	[SerializeField] // RVA: 0x29CA20 Offset: 0x29CB21 VA: 0x29CA20
	private TextMeshProUGUI m_ReasonText; // 0x28
	[HeaderAttribute] // RVA: 0x29CA30 Offset: 0x29CB31 VA: 0x29CA30
	[SerializeField] // RVA: 0x29CA30 Offset: 0x29CB31 VA: 0x29CA30
	private TextMeshProUGUI m_CaptureTitle; // 0x30
	[SerializeField] // RVA: 0x29CA80 Offset: 0x29CB81 VA: 0x29CA80
	private TextMeshProUGUI m_CategoryTitle; // 0x38
	[SerializeField] // RVA: 0x29CA90 Offset: 0x29CB91 VA: 0x29CA90
	private TextMeshProUGUI m_ReasonTitle; // 0x40
	[SerializeField] // RVA: 0x29CAA0 Offset: 0x29CBA1 VA: 0x29CAA0
	[HeaderAttribute] // RVA: 0x29CAA0 Offset: 0x29CBA1 VA: 0x29CAA0
	private GameObject m_CategoryWindow; // 0x48
	[SerializeField] // RVA: 0x29CAF0 Offset: 0x29CBF1 VA: 0x29CAF0
	private GameObject m_ReasonWindow; // 0x50
	private readonly float EnableAlpha; // 0x58
	private readonly float DisableAlpha; // 0x5C

	// Methods

	// RVA: 0x26BF700 Offset: 0x26BF801 VA: 0x26BF700
	public static void LoadPrefabAsync() { }

	// RVA: 0x26BF7A0 Offset: 0x26BF8A1 VA: 0x26BF7A0
	public static bool IsLoadingPrefab() { }

	// RVA: 0x26BF820 Offset: 0x26BF921 VA: 0x26BF820
	public static void UnloadPrefab() { }

	// RVA: 0x26BF8A0 Offset: 0x26BF9A1 VA: 0x26BF8A0
	public static VersusViolationTopContent Create() { }

	// RVA: 0x26BF950 Offset: 0x26BFA51 VA: 0x26BF950
	public static void Destroy(VersusViolationTopContent content) { }

	// RVA: 0x26BF9D0 Offset: 0x26BFAD1 VA: 0x26BF9D0
	private void Start() { }

	// RVA: 0x26BFB40 Offset: 0x26BFC41 VA: 0x26BFB40
	public void SetCapture(Texture2D tex) { }

	// RVA: 0x26BFBF0 Offset: 0x26BFCF1 VA: 0x26BFBF0
	public void SetCategoryText(string text) { }

	// RVA: 0x26BFC70 Offset: 0x26BFD71 VA: 0x26BFC70
	public void SetReasonText(string text) { }

	// RVA: 0x26BFCF0 Offset: 0x26BFDF1 VA: 0x26BFCF0
	public void HideCategory() { }

	// RVA: 0x26BFDB0 Offset: 0x26BFEB1 VA: 0x26BFDB0
	public void ShowCategory() { }

	// RVA: 0x26BFE70 Offset: 0x26BFF71 VA: 0x26BFE70
	public void HideReason() { }

	// RVA: 0x26BFF30 Offset: 0x26C0031 VA: 0x26BFF30
	public void ShowReason() { }

	// RVA: 0x26BFFF0 Offset: 0x26C00F1 VA: 0x26BFFF0
	public void .ctor() { }
}

