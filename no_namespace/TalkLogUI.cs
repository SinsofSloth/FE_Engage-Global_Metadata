// Namespace: 
public class TalkLogUI.Window // TypeDefIndex: 14129
{
	// Fields
	private int m_Index; // 0x10
	private GameObject m_RootObject; // 0x18
	private Animator m_RootAnimator; // 0x20
	private Image m_RootImage; // 0x28
	private Image m_NameWindowImage; // 0x30
	private TextMeshProUGUI m_TalkerName; // 0x38
	private TextMeshProUGUI m_BodyMess; // 0x40
	private TextMeshProUGUI m_KeyHelpMess; // 0x48
	private Animator m_KeyHelpAnimator; // 0x50
	private Image m_KeyHelpIconImage; // 0x58
	private bool m_isMoveAnimStarted; // 0x60
	private const float WinUpDownAnimSpeed = 3;

	// Methods

	// RVA: 0x238A7D0 Offset: 0x238A8D1 VA: 0x238A7D0
	public void .ctor(int index, GameObject rootObject) { }

	// RVA: 0x238AB70 Offset: 0x238AC71 VA: 0x238AB70
	public void Update(bool isSelected, bool isVoiceEventExist, bool isVoiceEventPlaying) { }

	// RVA: 0x238B040 Offset: 0x238B141 VA: 0x238B040
	public int GetIndex() { }

	// RVA: 0x238B050 Offset: 0x238B151 VA: 0x238B050
	public bool IsSelected(int logAddCount, int viewWindowMax, int cursorIndex, int scrollIndex) { }

	// RVA: 0x238B070 Offset: 0x238B171 VA: 0x238B070
	public Transform GetTransform() { }

	// RVA: 0x238B080 Offset: 0x238B181 VA: 0x238B080
	public void SetTalkerName(string talkerName) { }

	// RVA: 0x238B0A0 Offset: 0x238B1A1 VA: 0x238B0A0
	public void SetBodyMess(string bodyMess) { }

	// RVA: 0x238B0C0 Offset: 0x238B1C1 VA: 0x238B0C0
	public void Show() { }

	// RVA: 0x238B140 Offset: 0x238B241 VA: 0x238B140
	public void Hide() { }

	// RVA: 0x238ADF0 Offset: 0x238AEF1 VA: 0x238ADF0
	public void ShowKeyHelp() { }

	// RVA: 0x238B000 Offset: 0x238B101 VA: 0x238B000
	public void HideKeyHelp() { }

	// RVA: 0x238AF70 Offset: 0x238B071 VA: 0x238AF70
	public void PlayAnim_KeyHelpIdle() { }

	// RVA: 0x238AE30 Offset: 0x238AF31 VA: 0x238AE30
	public void PlayAnim_KeyHelpPlayingVoice() { }

	// RVA: 0x238AEC0 Offset: 0x238AFC1 VA: 0x238AEC0
	public bool IsPlayingMoveAnimation() { }

	// RVA: 0x238B1A0 Offset: 0x238B2A1 VA: 0x238B1A0
	public void PlayUpAnim(bool isMoveFast) { }

	// RVA: 0x238B230 Offset: 0x238B331 VA: 0x238B230
	public void PlayDownAnim(bool isMoveFast) { }

	// RVA: 0x238B2C0 Offset: 0x238B3C1 VA: 0x238B2C0
	public float GetWindowUpDownAnimDurationMsec() { }
}

// Namespace: 
public class TalkLogUI.Cursor // TypeDefIndex: 14130
{
	// Fields
	private GameObject m_RootObject; // 0x10
	private Animator m_Animator; // 0x18
	private Vector3 m_PosFrom; // 0x20
	private Vector3 m_PosTo; // 0x2C
	private float m_Time; // 0x38
	private float m_Duration; // 0x3C

	// Methods

	// RVA: 0x20574A0 Offset: 0x20575A1 VA: 0x20574A0
	public void .ctor(GameObject rootObject) { }

	// RVA: 0x2057680 Offset: 0x2057781 VA: 0x2057680
	public void Update() { }

	// RVA: 0x20577A0 Offset: 0x20578A1 VA: 0x20577A0
	public void MovePosition(TalkLogUI.Window win, float msec = 0) { }
}

// Namespace: 
public class TalkLogUI.ScrollBar // TypeDefIndex: 14131
{
	// Fields
	private GameObject m_RootObject; // 0x10
	private Scrollbar m_ScrollBar; // 0x18
	private Image m_ScrollAreaImage; // 0x20
	private Image m_SlideHandleImage; // 0x28
	private int m_ItemMax; // 0x30
	private float m_SlideHandlePosFrom; // 0x34
	private float m_SlideHandlePosTo; // 0x38
	private float m_Time; // 0x3C
	private float m_Duration; // 0x40

	// Methods

	// RVA: 0x238A430 Offset: 0x238A531 VA: 0x238A430
	public void .ctor(GameObject rootObject, int itemMax) { }

	// RVA: 0x238A5D0 Offset: 0x238A6D1 VA: 0x238A5D0
	public void Update() { }

	// RVA: 0x238A690 Offset: 0x238A791 VA: 0x238A690
	public void MoveSlideHandlePos(float scrollIndex, float logNum, float msec = 0) { }

	// RVA: 0x238A720 Offset: 0x238A821 VA: 0x238A720
	public void SetSlideHandleSize(float logNum) { }

	// RVA: 0x238A750 Offset: 0x238A851 VA: 0x238A750
	public void Show() { }

	// RVA: 0x238A790 Offset: 0x238A891 VA: 0x238A790
	public void Hide() { }
}

