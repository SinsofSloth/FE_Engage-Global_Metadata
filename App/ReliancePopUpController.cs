// Namespace: App
public class ReliancePopUpController : MonoBehaviour // TypeDefIndex: 11730
{
	// Fields
	private const string PrefabPath = "UI/Hub/ReliancePopUp/Prefabs/ReliancePopUpRoot";
	[SerializeField] // RVA: 0x298E20 Offset: 0x298F21 VA: 0x298E20
	private Animator m_Animator; // 0x18
	private UnitIcon m_UnitIcon0; // 0x20
	private UnitIcon m_UnitIcon1; // 0x28
	private GameObject m_Heart0; // 0x30
	private GameObject m_Heart1; // 0x38
	private GameObject m_WdwReliance; // 0x40
	private GameObject m_WdwTalk; // 0x48
	private GameObject m_TextReliance; // 0x50
	private GameObject m_TextTalk; // 0x58
	private GameObject m_TalkIcon; // 0x60

	// Methods

	// RVA: 0x24CA6D0 Offset: 0x24CA7D1 VA: 0x24CA6D0
	public static void LoadPrefabAsync() { }

	// RVA: 0x24CA770 Offset: 0x24CA871 VA: 0x24CA770
	public static bool IsLoadingPrefab() { }

	// RVA: 0x24CA7F0 Offset: 0x24CA8F1 VA: 0x24CA7F0
	public static bool IsLoaded() { }

	// RVA: 0x24CA8C0 Offset: 0x24CA9C1 VA: 0x24CA8C0
	public static void UnloadPrefab() { }

	// RVA: 0x24CA940 Offset: 0x24CAA41 VA: 0x24CA940
	public static ReliancePopUpController Create() { }

	// RVA: 0x24CA9F0 Offset: 0x24CAAF1 VA: 0x24CA9F0
	public static void Destroy(ReliancePopUpController content) { }

	// RVA: 0x24CAA70 Offset: 0x24CAB71 VA: 0x24CAA70
	private void Awake() { }

	// RVA: 0x24CAD70 Offset: 0x24CAE71 VA: 0x24CAD70
	private void Update() { }

	// RVA: 0x24CAE70 Offset: 0x24CAF71 VA: 0x24CAE70
	public bool IsPlayingAnim() { }

	// RVA: 0x24CAE90 Offset: 0x24CAF91 VA: 0x24CAE90
	public void PopUp(Unit unitL, Unit unitR, int value = 2) { }

	// RVA: 0x24CB280 Offset: 0x24CB381 VA: 0x24CB280
	public void Hide() { }

	// RVA: 0x24CB1C0 Offset: 0x24CB2C1 VA: 0x24CB1C0
	private void ActiveReliance() { }

	// RVA: 0x24CB0E0 Offset: 0x24CB1E1 VA: 0x24CB0E0
	private void ActiveTalk() { }

	// RVA: 0x24CB300 Offset: 0x24CB401 VA: 0x24CB300
	public void .ctor() { }
}

