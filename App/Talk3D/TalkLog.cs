// Namespace: App.Talk3D
public class TalkLog : SingletonMonoBehaviour<TalkLog> // TypeDefIndex: 14126
{
	// Fields
	public GameObject[] m_Bases; // 0x20
	public int m_LogPageMax; // 0x28
	private const int ViewWindowMax = 4;
	private TalkLogUI.Cursor m_Cursor; // 0x30
	private TalkLogUI.Window[] m_WindowList; // 0x38
	private TalkLogUI.ScrollBar m_ScrollBar; // 0x40
	private string[] m_LabelList; // 0x48
	private string[] m_TalkerNameList; // 0x50
	private string[] m_MessList; // 0x58
	private string[] m_VoiceEventList; // 0x60
	private List<string> m_ScenarioSoundBankNameList; // 0x68
	private int m_LogAddCount; // 0x70
	private int m_LogNum; // 0x74
	private int m_CursorIndex; // 0x78
	private int m_ScrollIndex; // 0x7C

	// Methods

	// RVA: 0x2C2ABE0 Offset: 0x2C2ACE1 VA: 0x2C2ABE0 Slot: 4
	protected override void Awake() { }

	// RVA: 0x2C2B1B0 Offset: 0x2C2B2B1 VA: 0x2C2B1B0
	private void OnDestroy() { }

	// RVA: 0x2C2B270 Offset: 0x2C2B371 VA: 0x2C2B270
	private void ReBuild() { }

	// RVA: 0x2C2ACE0 Offset: 0x2C2ADE1 VA: 0x2C2ACE0
	private void BuildObjects() { }

	// RVA: 0x2C2B280 Offset: 0x2C2B381 VA: 0x2C2B280
	private void ResetParam() { }

	// RVA: 0x2C2B4F0 Offset: 0x2C2B5F1 VA: 0x2C2B4F0
	private void Start() { }

	// RVA: 0x2C2B500 Offset: 0x2C2B601 VA: 0x2C2B500
	private void Update() { }

	// RVA: 0x2C2B860 Offset: 0x2C2B961 VA: 0x2C2B860
	public void LoadVoiceSoundBank() { }

	// RVA: 0x2C2C230 Offset: 0x2C2C331 VA: 0x2C2C230
	public void UnloadVoiceSoundBank() { }

	// RVA: 0x2C2C3E0 Offset: 0x2C2C4E1 VA: 0x2C2C3E0
	public void ResetCursorAndScroll() { }

	// RVA: 0x2C2B470 Offset: 0x2C2B571 VA: 0x2C2B470
	public void SetupLayout() { }

	// RVA: 0x2C2C4A0 Offset: 0x2C2C5A1 VA: 0x2C2C4A0
	public void SetupWindow() { }

	// RVA: 0x2C2C830 Offset: 0x2C2C931 VA: 0x2C2C830
	public void SetupCursor() { }

	// RVA: 0x2C2C8A0 Offset: 0x2C2C9A1 VA: 0x2C2C8A0
	public void SetupScrollBar() { }

	// RVA: 0x2C2C970 Offset: 0x2C2CA71 VA: 0x2C2C970
	public void CursorUp(bool isMoveFast) { }

	// RVA: 0x2C2CBF0 Offset: 0x2C2CCF1 VA: 0x2C2CBF0
	public bool CursorDown(bool isMoveFast, bool isKeyTrigger) { }

	// RVA: 0x2C2CAC0 Offset: 0x2C2CBC1 VA: 0x2C2CAC0
	public void ScrollUp(bool isMoveFast, bool isLayoutUpdate) { }

	// RVA: 0x2C2CD60 Offset: 0x2C2CE61 VA: 0x2C2CD60
	public void ScrollDown(bool isMoveFast, bool isLayoutUpdate) { }

	// RVA: 0x2C2CE90 Offset: 0x2C2CF91 VA: 0x2C2CE90
	public void AddLog(string label, string mess, string talker) { }

	// RVA: 0x2C2D040 Offset: 0x2C2D141 VA: 0x2C2D040
	private void ResetLogImpl() { }

	// RVA: 0x2C2D0D0 Offset: 0x2C2D1D1 VA: 0x2C2D0D0
	public bool IsPlayingWindowAnimation() { }

	// RVA: 0x2C2C940 Offset: 0x2C2CA41 VA: 0x2C2C940
	public float GetWindowUpDownAnimDurationMsec() { }

	// RVA: 0x2C2B700 Offset: 0x2C2B801 VA: 0x2C2B700
	public bool IsVoiceEventExist(int messIndex) { }

	// RVA: 0x2C2B7B0 Offset: 0x2C2B8B1 VA: 0x2C2B7B0
	public bool IsVoiceEventPlaying(int messIndex) { }

	// RVA: 0x2C2D100 Offset: 0x2C2D201 VA: 0x2C2D100
	public bool TryPlayVoice() { }

	// RVA: 0x2C2D250 Offset: 0x2C2D351 VA: 0x2C2D250
	public void Open() { }

	// RVA: 0x2C2D330 Offset: 0x2C2D431 VA: 0x2C2D330
	public void Close() { }

	// RVA: 0x2C2D410 Offset: 0x2C2D511 VA: 0x2C2D410
	public bool IsClosed() { }

	// RVA: 0x2C2D4F0 Offset: 0x2C2D5F1 VA: 0x2C2D4F0
	public static void ResetLog() { }

	// RVA: 0x2C2D580 Offset: 0x2C2D681 VA: 0x2C2D580
	public void .ctor() { }
}

