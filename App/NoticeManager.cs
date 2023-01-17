// Namespace: App
public class NoticeManager : SingletonMonoBehaviour<NoticeManager> // TypeDefIndex: 13437
{
	// Fields
	private GameObject m_AchievementPopUp; // 0x20
	private Animator m_Animator; // 0x28
	private TextMeshProUGUI m_TextMesh; // 0x30
	private GameObject m_ClearObject; // 0x38
	private Queue<string>[] m_Queues; // 0x40

	// Methods

	// RVA: 0x235C820 Offset: 0x235C921 VA: 0x235C820
	public static void Add(NoticeManager.Kinds kind, string text) { }

	// RVA: 0x235C970 Offset: 0x235CA71 VA: 0x235C970
	public static void Clear() { }

	// RVA: 0x235CB00 Offset: 0x235CC01 VA: 0x235CB00
	public static void Stop() { }

	// RVA: 0x235CC30 Offset: 0x235CD31 VA: 0x235CC30
	private static bool CanKizunaTalk() { }

	// RVA: 0x235D170 Offset: 0x235D271 VA: 0x235D170
	public static void UpdateKizunaTalk() { }

	// RVA: 0x235D210 Offset: 0x235D311 VA: 0x235D210 Slot: 4
	protected override void Awake() { }

	// RVA: 0x235D4C0 Offset: 0x235D5C1 VA: 0x235D4C0
	private void Start() { }

	// RVA: 0x235D700 Offset: 0x235D801 VA: 0x235D700
	private bool IsFinish(Animator animator) { }

	// RVA: 0x235D7E0 Offset: 0x235D8E1 VA: 0x235D7E0
	private bool CanShow() { }

	// RVA: 0x235DB90 Offset: 0x235DC91 VA: 0x235DB90
	private void Show(string text, bool clear) { }

	// RVA: 0x235DC60 Offset: 0x235DD61 VA: 0x235DC60
	private void Update() { }

	// RVA: 0x235DE80 Offset: 0x235DF81 VA: 0x235DE80
	public void .ctor() { }
}

