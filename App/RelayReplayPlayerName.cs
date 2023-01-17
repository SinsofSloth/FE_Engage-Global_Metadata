// Namespace: App
internal class RelayReplayPlayerName : SingletonMonoBehaviour<RelayReplayPlayerName> // TypeDefIndex: 12906
{
	// Fields
	public TextMeshProUGUI m_Text; // 0x20
	private const string PrefabPath = "UI/Network/Relay/Prefabs/RelayReplayPlayerNameRoot";
	private CanvasManager m_CanvasManager; // 0x28
	private Animator m_Animator; // 0x30
	private RelayReplayPlayerName.Seq m_Seq; // 0x38
	private bool m_IsReqClose; // 0x3C

	// Methods

	// RVA: 0x24BC6D0 Offset: 0x24BC7D1 VA: 0x24BC6D0 Slot: 4
	protected override void Awake() { }

	// RVA: 0x24BC7A0 Offset: 0x24BC8A1 VA: 0x24BC7A0
	private void Update() { }

	// RVA: 0x24BCDC0 Offset: 0x24BCEC1 VA: 0x24BCDC0
	private void ShowImpl() { }

	// RVA: 0x24BD380 Offset: 0x24BD481 VA: 0x24BD380
	private void HideImpl() { }

	// RVA: 0x24BD1F0 Offset: 0x24BD2F1 VA: 0x24BD1F0
	private void UpdatePlayerNameImpl() { }

	// RVA: 0x24BCC00 Offset: 0x24BCD01 VA: 0x24BCC00
	private bool IsOpening() { }

	// RVA: 0x24BD450 Offset: 0x24BD551 VA: 0x24BD450
	private bool IsClosing() { }

	// RVA: 0x24BCCE0 Offset: 0x24BCDE1 VA: 0x24BCCE0
	private bool IsClosed() { }

	// RVA: 0x24BD3A0 Offset: 0x24BD4A1 VA: 0x24BD3A0
	private bool GetBool(string name) { }

	// RVA: 0x24BD530 Offset: 0x24BD631 VA: 0x24BD530
	public static void TryShow() { }

	// RVA: 0x24BD620 Offset: 0x24BD721 VA: 0x24BD620
	public static void TryHide() { }

	// RVA: 0x24BD720 Offset: 0x24BD821 VA: 0x24BD720
	public static void TryUpdatePlayerName() { }

	// RVA: 0x24BD810 Offset: 0x24BD911 VA: 0x24BD810
	public static void TryCreateAsync() { }

	// RVA: 0x24BDA40 Offset: 0x24BDB41 VA: 0x24BDA40
	public static bool IsCreating() { }

	// RVA: 0x24BDB10 Offset: 0x24BDC11 VA: 0x24BDB10
	public static void TryDestroy() { }

	// RVA: 0x24BD990 Offset: 0x24BDA91 VA: 0x24BD990
	private static bool IsRequired() { }

	// RVA: 0x24BDD90 Offset: 0x24BDE91 VA: 0x24BDD90
	public void .ctor() { }
}

