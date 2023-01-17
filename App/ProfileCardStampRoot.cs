// Namespace: App
public class ProfileCardStampRoot : MonoBehaviour // TypeDefIndex: 11640
{
	// Fields
	[HeaderAttribute] // RVA: 0x298AA0 Offset: 0x298BA1 VA: 0x298AA0
	public TextMeshProUGUI m_StampCountCaption; // 0x18
	public TextMeshProUGUI m_StampCountText; // 0x20
	[HeaderAttribute] // RVA: 0x298AE0 Offset: 0x298BE1 VA: 0x298AE0
	public GameObject m_StampObject; // 0x28
	public RectTransform m_StampRectTransform; // 0x30
	public Animator m_StampAnimator; // 0x38
	public RectTransform m_StampGroupRectTransform; // 0x40
	public Image m_StampImage; // 0x48
	public RectTransform m_StampImageRectTransform; // 0x50
	public RectTransform m_StampIconRectTransform; // 0x58
	public GameObject m_FrameObject; // 0x60
	public Image m_FrameImage; // 0x68
	[HeaderAttribute] // RVA: 0x298B20 Offset: 0x298C21 VA: 0x298B20
	public RectTransform m_StampEffectRectTransform; // 0x70
	public Animator m_StampEffectAnimator; // 0x78
	[HeaderAttribute] // RVA: 0x298B60 Offset: 0x298C61 VA: 0x298B60
	public GameObject m_StampKeyHelpObject; // 0x80
	public Animator m_StampKeyHelpAnimator; // 0x88
	[HeaderAttribute] // RVA: 0x298BA0 Offset: 0x298CA1 VA: 0x298BA0
	public Color m_FrameColorEnable; // 0x90
	public Color m_FrameColorDisable; // 0xA0
	private int m_StampCountCurrent; // 0xB0
	private int m_StampCountMax; // 0xB4
	private Vector2 m_InitialStampPosition; // 0xB8
	private Vector2 m_InitialStampSize; // 0xC0
	private Vector2 m_StampScale; // 0xC8
	private bool m_IsStarted; // 0xD0
	private float m_RecordRotZ; // 0xD4
	private Vector2 m_RecordScale; // 0xD8
	private Vector2 m_RecordImageScale; // 0xE0

	// Methods

	// RVA: 0x2EE0AA0 Offset: 0x2EE0BA1 VA: 0x2EE0AA0
	private void Start() { }

	// RVA: 0x2ED9A50 Offset: 0x2ED9B51 VA: 0x2ED9A50
	public void Reuse() { }

	// RVA: 0x2ED97A0 Offset: 0x2ED98A1 VA: 0x2ED97A0
	public void SetStampCountCurrent(int count) { }

	// RVA: 0x2ED9870 Offset: 0x2ED9971 VA: 0x2ED9870
	public void SetStampCountMax(int max) { }

	// RVA: 0x2ED9960 Offset: 0x2ED9A61 VA: 0x2ED9960
	public void SetStampImage(ProfileCardStampData stampData) { }

	// RVA: 0x2EE0D60 Offset: 0x2EE0E61 VA: 0x2EE0D60
	public GameObject GetStampObject() { }

	// RVA: 0x2EDF370 Offset: 0x2EDF471 VA: 0x2EDF370
	public void SetStampObjectActive(bool actived) { }

	// RVA: 0x2EDF870 Offset: 0x2EDF971 VA: 0x2EDF870
	public Vector2 GetStampPosition() { }

	// RVA: 0x2EDEE30 Offset: 0x2EDEF31 VA: 0x2EDEE30
	public void SetStampPosition(Vector2 position) { }

	// RVA: 0x2EE0C00 Offset: 0x2EE0D01 VA: 0x2EE0C00
	public void ResetStampPosition() { }

	// RVA: 0x2EDDF50 Offset: 0x2EDE051 VA: 0x2EDDF50
	public void MoveStamp(Vector2 movement, Rect range, bool isFrame) { }

	// RVA: 0x2EDF910 Offset: 0x2EDFA11 VA: 0x2EDF910
	public float GetStampRotation() { }

	// RVA: 0x2EDEEF0 Offset: 0x2EDEFF1 VA: 0x2EDEEF0
	public void ResetStampRotation() { }

	// RVA: 0x2EDEF90 Offset: 0x2EDF091 VA: 0x2EDEF90
	public void RotateStamp(float rotation) { }

	// RVA: 0x2EE0D70 Offset: 0x2EE0E71 VA: 0x2EE0D70
	public Vector2 GetStampScale() { }

	// RVA: 0x2EDF830 Offset: 0x2EDF931 VA: 0x2EDF830
	public void ResetStampScale() { }

	// RVA: 0x2EDF040 Offset: 0x2EDF141 VA: 0x2EDF040
	public void SetStampScale(Vector2 scaling, float min, float max) { }

	// RVA: 0x2EE0D80 Offset: 0x2EE0E81 VA: 0x2EE0D80
	public void ScaleStamp(Vector2 scaling, float min, float max) { }

	// RVA: 0x2EE0E50 Offset: 0x2EE0F51 VA: 0x2EE0E50
	public void ScaleStamp(float scaling, float min, float max) { }

	// RVA: 0x2EDF660 Offset: 0x2EDF761 VA: 0x2EDF660
	public void AddStampScale(float scaling, float min, float max) { }

	// RVA: 0x2EDF4E0 Offset: 0x2EDF5E1 VA: 0x2EDF4E0
	public void SaveTransform() { }

	// RVA: 0x2EDF590 Offset: 0x2EDF691 VA: 0x2EDF590
	public void LoadTransform() { }

	// RVA: 0x2EDE480 Offset: 0x2EDE581 VA: 0x2EDE480
	public ProfileCardRoot.RectInfo GetStampRect() { }

	// RVA: 0x2EDE2E0 Offset: 0x2EDE3E1 VA: 0x2EDE2E0
	public ProfileCardRoot.RectInfo GetIconRect() { }

	// RVA: 0x2EDF9B0 Offset: 0x2EDFAB1 VA: 0x2EDF9B0
	public Vector2 GetStampImageScale() { }

	// RVA: 0x2EE0CC0 Offset: 0x2EE0DC1 VA: 0x2EE0CC0
	public void ResetStampImageScale() { }

	// RVA: 0x2EDF740 Offset: 0x2EDF841 VA: 0x2EDF740
	public void ScaleStampImage(Vector2 scaling, float min, float max) { }

	// RVA: 0x2EDF140 Offset: 0x2EDF241 VA: 0x2EDF140
	public void SetStampImageScale(Vector2 scaling, float min, float max) { }

	// RVA: 0x2EDFD50 Offset: 0x2EDFE51 VA: 0x2EDFD50
	public void PlayIdleStampAnimation() { }

	// RVA: 0x2EDEAA0 Offset: 0x2EDEBA1 VA: 0x2EDEAA0
	public void PlayPushStampAnimation() { }

	// RVA: 0x2EE0020 Offset: 0x2EE0121 VA: 0x2EE0020
	public void PlayCatchStampAnimation() { }

	// RVA: 0x2EDFEB0 Offset: 0x2EDFFB1 VA: 0x2EDFEB0
	public void PlayHoldStampAnimation() { }

	// RVA: 0x2EE0160 Offset: 0x2EE0261 VA: 0x2EE0160
	public void PlayDeleteStampAnimation() { }

	// RVA: 0x2EDEB60 Offset: 0x2EDEC61 VA: 0x2EDEB60
	public void PlayEffectAnimation() { }

	// RVA: 0x2ED9940 Offset: 0x2ED9A41 VA: 0x2ED9940
	public void SetKeyHelpActive(bool actived) { }

	// RVA: 0x2EDF2C0 Offset: 0x2EDF3C1 VA: 0x2EDF2C0
	public void OpenKeyHelpWindow() { }

	// RVA: 0x2EE0780 Offset: 0x2EE0881 VA: 0x2EE0780
	public void CloseKeyHelpWindow() { }

	// RVA: 0x2EDFE90 Offset: 0x2EDFF91 VA: 0x2EDFE90
	public void SetStampFrameActive(bool isActive) { }

	// RVA: 0x2EE0270 Offset: 0x2EE0371 VA: 0x2EE0270
	public void SetStampFrameColor(bool isEnable) { }

	// RVA: 0x2EE0F10 Offset: 0x2EE1011 VA: 0x2EE0F10
	public void .ctor() { }
}

