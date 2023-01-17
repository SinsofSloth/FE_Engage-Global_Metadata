// Namespace: App
public class SkipIndicator : SingletonMonoBehaviour<SkipIndicator> // TypeDefIndex: 13441
{
	// Fields
	public GameObject m_Skip; // 0x20
	public GameObject m_Auto; // 0x28
	public GameObject m_Error; // 0x30
	private CanvasManager m_CanvasManager; // 0x38
	private Animator m_Animator; // 0x40
	private SkipIndicator.Seq m_Seq; // 0x48
	private bool m_IsReqClose; // 0x4C

	// Methods

	// RVA: 0x27E33E0 Offset: 0x27E34E1 VA: 0x27E33E0 Slot: 4
	protected override void Awake() { }

	// RVA: 0x27E34B0 Offset: 0x27E35B1 VA: 0x27E34B0
	private void Update() { }

	// RVA: 0x27E3AD0 Offset: 0x27E3BD1 VA: 0x27E3AD0
	private void ShowSkipImpl() { }

	// RVA: 0x27E4000 Offset: 0x27E4101 VA: 0x27E4000
	private void ShowAutoImpl() { }

	// RVA: 0x27E4010 Offset: 0x27E4111 VA: 0x27E4010
	private void ShowErrorImpl() { }

	// RVA: 0x27E4020 Offset: 0x27E4121 VA: 0x27E4020
	private void HideImpl() { }

	// RVA: 0x27E3AE0 Offset: 0x27E3BE1 VA: 0x27E3AE0
	private void Show(bool isShowSkip, bool isShowAuto, bool isShowError) { }

	// RVA: 0x27E3910 Offset: 0x27E3A11 VA: 0x27E3910
	private bool IsOpening() { }

	// RVA: 0x27E40F0 Offset: 0x27E41F1 VA: 0x27E40F0
	private bool IsClosing() { }

	// RVA: 0x27E39F0 Offset: 0x27E3AF1 VA: 0x27E39F0
	private bool IsClosed() { }

	// RVA: 0x27E4040 Offset: 0x27E4141 VA: 0x27E4040
	private bool GetBool(string name) { }

	// RVA: 0x27E41D0 Offset: 0x27E42D1 VA: 0x27E41D0
	public static void ShowSkip() { }

	// RVA: 0x27E42D0 Offset: 0x27E43D1 VA: 0x27E42D0
	public static void ShowAuto() { }

	// RVA: 0x27E43D0 Offset: 0x27E44D1 VA: 0x27E43D0
	public static void ShowError() { }

	// RVA: 0x27E44D0 Offset: 0x27E45D1 VA: 0x27E44D0
	public static void Hide() { }

	// RVA: 0x27E45D0 Offset: 0x27E46D1 VA: 0x27E45D0
	public void .ctor() { }
}

