// Namespace: 
public class ConfigMenuItemContent : BasicMenuItemContent // TypeDefIndex: 7690
{
	// Fields
	[SpaceAttribute] // RVA: 0x27C380 Offset: 0x27C481 VA: 0x27C380
	[HeaderAttribute] // RVA: 0x27C380 Offset: 0x27C481 VA: 0x27C380
	public GameObject m_CommandObject; // 0x48
	public GameObject m_CommandIcon; // 0x50
	public GameObject m_GaugeObject; // 0x58
	public GameObject m_LeftArrow; // 0x60
	public GameObject m_RightArrow; // 0x68
	[SpaceAttribute] // RVA: 0x27C3D0 Offset: 0x27C4D1 VA: 0x27C3D0
	[HeaderAttribute] // RVA: 0x27C3D0 Offset: 0x27C4D1 VA: 0x27C3D0
	public TextMeshProUGUI m_TitleText; // 0x70
	public TextMeshProUGUI m_CommandText; // 0x78
	public TextMeshProUGUI m_HelpText; // 0x80
	[SpaceAttribute] // RVA: 0x27C420 Offset: 0x27C521 VA: 0x27C420
	[HeaderAttribute] // RVA: 0x27C420 Offset: 0x27C521 VA: 0x27C420
	public RectTransform m_BaseGaugeRect; // 0x88
	public RectTransform m_GaugeRect; // 0x90

	// Methods

	// RVA: 0x23B5520 Offset: 0x23B5621 VA: 0x23B5520 Slot: 10
	public override void BuildText() { }

	// RVA: 0x23B5950 Offset: 0x23B5A51 VA: 0x23B5950 Slot: 7
	protected override void UpdateTextColor() { }

	// RVA: 0x23B5900 Offset: 0x23B5A01 VA: 0x23B5900
	private void SetActive(GameObject obj, bool enable) { }

	// RVA: 0x23B5B60 Offset: 0x23B5C61 VA: 0x23B5B60
	public void .ctor() { }
}

