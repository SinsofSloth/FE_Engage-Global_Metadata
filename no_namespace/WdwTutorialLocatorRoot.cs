// Namespace: 
public class WdwTutorialLocatorRoot : MonoBehaviour // TypeDefIndex: 7705
{
	// Fields
	[SerializeField] // RVA: 0x27C490 Offset: 0x27C591 VA: 0x27C490
	[HeaderAttribute] // RVA: 0x27C490 Offset: 0x27C591 VA: 0x27C490
	[SpaceAttribute] // RVA: 0x27C490 Offset: 0x27C591 VA: 0x27C490
	private GameObject m_RightArrow; // 0x18
	[SerializeField] // RVA: 0x27C4F0 Offset: 0x27C5F1 VA: 0x27C4F0
	private GameObject m_LeftArrow; // 0x20
	[SerializeField] // RVA: 0x27C500 Offset: 0x27C601 VA: 0x27C500
	[HeaderAttribute] // RVA: 0x27C500 Offset: 0x27C601 VA: 0x27C500
	[SpaceAttribute] // RVA: 0x27C500 Offset: 0x27C601 VA: 0x27C500
	private TextMeshProUGUI m_TutorialTitleText; // 0x28
	[SerializeField] // RVA: 0x27C560 Offset: 0x27C661 VA: 0x27C560
	private TextMeshProUGUI m_MessageText; // 0x30
	[SerializeField] // RVA: 0x27C570 Offset: 0x27C671 VA: 0x27C570
	private TextMeshProUGUI m_Page0Text; // 0x38
	[SerializeField] // RVA: 0x27C580 Offset: 0x27C681 VA: 0x27C580
	private TextMeshProUGUI m_Page1Text; // 0x40
	[SpaceAttribute] // RVA: 0x27C590 Offset: 0x27C691 VA: 0x27C590
	[HeaderAttribute] // RVA: 0x27C590 Offset: 0x27C691 VA: 0x27C590
	[SerializeField] // RVA: 0x27C590 Offset: 0x27C691 VA: 0x27C590
	private Image m_CaptureImage; // 0x48
	[SpaceAttribute] // RVA: 0x27C5F0 Offset: 0x27C6F1 VA: 0x27C5F0
	[HeaderAttribute] // RVA: 0x27C5F0 Offset: 0x27C6F1 VA: 0x27C5F0
	[SerializeField] // RVA: 0x27C5F0 Offset: 0x27C6F1 VA: 0x27C5F0
	private Animator m_WdwTutorialAnimator; // 0x50
	private Sprite m_Sprite; // 0x58

	// Methods

	// RVA: 0x26CA2F0 Offset: 0x26CA3F1 VA: 0x26CA2F0
	private void OnDestroy() { }

	// RVA: 0x26CA370 Offset: 0x26CA471 VA: 0x26CA370
	public void SetActiveRightArrow(bool enable) { }

	// RVA: 0x26CA3C0 Offset: 0x26CA4C1 VA: 0x26CA3C0
	public void SetActiveLeftArrow(bool enable) { }

	// RVA: 0x26CA410 Offset: 0x26CA511 VA: 0x26CA410
	public void SetSprite(Sprite sprite) { }

	// RVA: 0x26CA4B0 Offset: 0x26CA5B1 VA: 0x26CA4B0
	public void SetTitle(string title) { }

	// RVA: 0x26CA4D0 Offset: 0x26CA5D1 VA: 0x26CA4D0
	public void SetText(string text) { }

	// RVA: 0x26CA4F0 Offset: 0x26CA5F1 VA: 0x26CA4F0
	public void SetPage0(int page) { }

	// RVA: 0x26CA570 Offset: 0x26CA671 VA: 0x26CA570
	public void SetPage1(int page) { }

	// RVA: 0x26CA5F0 Offset: 0x26CA6F1 VA: 0x26CA5F0
	public bool IsOpening() { }

	// RVA: 0x26CA650 Offset: 0x26CA751 VA: 0x26CA650
	public bool IsClosing() { }

	// RVA: 0x26CA6B0 Offset: 0x26CA7B1 VA: 0x26CA6B0
	public void Open() { }

	// RVA: 0x26CA710 Offset: 0x26CA811 VA: 0x26CA710
	public void Close() { }

	// RVA: 0x26CA770 Offset: 0x26CA871 VA: 0x26CA770
	public void .ctor() { }
}

