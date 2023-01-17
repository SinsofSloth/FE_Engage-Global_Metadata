// Namespace: 
protected class BasicMenuContent.Cursor // TypeDefIndex: 12517
{
	// Fields
	private BasicMenuContent m_menuContent; // 0x10
	protected GameObject m_objFrontCursor; // 0x18
	protected GameObject m_objBackCursor; // 0x20
	protected GameObject m_objFrontCursorBase; // 0x28
	private RectTransform m_backCursorRect; // 0x30
	private Image m_backCursorImage; // 0x38
	private Animator m_backCursorAnimator; // 0x40
	private Animator m_frontCursorAnimator; // 0x48
	private RectTransform m_frontCursorBaseRect; // 0x50
	private RectTransform m_frontCursorBaseParentRect; // 0x58
	private float m_posX; // 0x60
	private float m_posY; // 0x64
	private float m_fromX; // 0x68
	private float m_fromY; // 0x6C
	private float m_fromW; // 0x70
	private float m_fromH; // 0x74
	private float m_moveTick; // 0x78
	private float m_moveFrame; // 0x7C
	private bool m_fixed; // 0x80
	private bool m_fixedWH; // 0x81
	private bool m_firstTick; // 0x82
	private bool m_lastVisibility; // 0x83
	private bool m_frontCursorVisibility; // 0x84
	private float m_frontCursorMoveTick; // 0x88
	private float m_frontCursorMoveFrame; // 0x8C
	private float m_frontCursorFromX; // 0x90
	private float m_frontCursorFromY; // 0x94

	// Methods

	// RVA: 0x1F71950 Offset: 0x1F71A51 VA: 0x1F71950
	public void .ctor(BasicMenuContent menuContent, GameObject objFrontCursor, GameObject objBackCursor) { }

	// RVA: 0x1F71D30 Offset: 0x1F71E31 VA: 0x1F71D30
	public float GetPosX() { }

	// RVA: 0x1F71D40 Offset: 0x1F71E41 VA: 0x1F71D40
	public float GetPosY() { }

	// RVA: 0x1F71D50 Offset: 0x1F71E51 VA: 0x1F71D50
	public void Tick(BasicMenuContent.Scroll scroll) { }

	// RVA: 0x1F723E0 Offset: 0x1F724E1 VA: 0x1F723E0
	public void UpdateVisibility() { }

	// RVA: 0x1F72480 Offset: 0x1F72581 VA: 0x1F72480
	public void MoveInstant() { }

	// RVA: 0x1F72650 Offset: 0x1F72751 VA: 0x1F72650
	public void SetMoveFrame(float frame) { }

	// RVA: 0x1F72660 Offset: 0x1F72761 VA: 0x1F72660
	public void PauseAnim() { }

	// RVA: 0x1F727A0 Offset: 0x1F728A1 VA: 0x1F727A0
	public void ResumeAnim() { }

	// RVA: 0x1F727F0 Offset: 0x1F728F1 VA: 0x1F727F0
	public void RestartAnim() { }

	// RVA: 0x1F728A0 Offset: 0x1F729A1 VA: 0x1F728A0
	public void SetSiblingIndex(int index) { }

	// RVA: 0x1F728D0 Offset: 0x1F729D1 VA: 0x1F728D0
	public void SetBackCursorImageEnabled(bool enabled) { }

	// RVA: 0x1F72970 Offset: 0x1F72A71 VA: 0x1F72970
	public void SetToKeepAnimatorState(bool keep) { }

	// RVA: 0x1F72980 Offset: 0x1F72A81 VA: 0x1F72980
	public void MoveFrontCursorFrom(float fromX, float fromY, float frame) { }

	// RVA: 0x1F729A0 Offset: 0x1F72AA1 VA: 0x1F729A0
	public void SetFrontCursorVisibility(bool visibility) { }
}

