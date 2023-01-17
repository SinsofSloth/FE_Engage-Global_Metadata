// Namespace: App
public class RingSelectMenuItemContent : BasicMenuItemContent // TypeDefIndex: 13236
{
	// Fields
	public TextMeshProUGUI m_name; // 0x48
	public TextMeshProUGUI m_emptyText; // 0x50
	public Image m_face; // 0x58
	public Image m_symbol; // 0x60
	public Image m_selectBg; // 0x68
	public Image m_frame; // 0x70
	public GameObject m_check; // 0x78
	public GameObject m_unitIcon; // 0x80
	private bool m_IsEquip; // 0x88
	private bool m_IsEmpty; // 0x89
	public GameObject m_numRoot; // 0x90
	public TextMeshProUGUI m_num; // 0x98
	public TextMeshProUGUI m_x; // 0xA0

	// Methods

	// RVA: 0x2057FE0 Offset: 0x20580E1 VA: 0x2057FE0 Slot: 5
	public override TextMeshProUGUI GetTextMeshProComponent() { }

	// RVA: 0x2058000 Offset: 0x2058101 VA: 0x2058000 Slot: 8
	public override void Build(BasicMenuItem menuItem) { }

	// RVA: 0x20585D0 Offset: 0x20586D1 VA: 0x20585D0
	private void SetFaceImage(Sprite sprite) { }

	// RVA: 0x20586C0 Offset: 0x20587C1 VA: 0x20586C0
	private void SetSymbolImage(Sprite sprite) { }

	// RVA: 0x2058810 Offset: 0x2058911 VA: 0x2058810
	private void SetOwner(Unit owner) { }

	// RVA: 0x2058980 Offset: 0x2058A81 VA: 0x2058980 Slot: 7
	protected override void UpdateTextColor() { }

	// RVA: 0x2058D70 Offset: 0x2058E71 VA: 0x2058D70
	public void .ctor() { }
}

