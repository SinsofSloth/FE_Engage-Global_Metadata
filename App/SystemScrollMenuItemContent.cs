// Namespace: App
public class SystemScrollMenuItemContent : BasicMenuItemContent // TypeDefIndex: 13439
{
	// Fields
	public GameObject m_Partner; // 0x48
	public TextMeshProUGUI m_Title; // 0x50
	public TextMeshProUGUI m_Help; // 0x58
	public GameObject m_Icon; // 0x60

	// Methods

	// RVA: 0x2931950 Offset: 0x2931A51 VA: 0x2931950 Slot: 8
	public override void Build(BasicMenuItem menuItem) { }

	// RVA: 0x2931C70 Offset: 0x2931D71 VA: 0x2931C70 Slot: 15
	protected override void Update() { }

	// RVA: 0x2931D80 Offset: 0x2931E81 VA: 0x2931D80 Slot: 7
	protected override void UpdateTextColor() { }

	// RVA: 0x2931F00 Offset: 0x2932001 VA: 0x2931F00 Slot: 13
	public override void Disable() { }

	// RVA: 0x2931FA0 Offset: 0x29320A1 VA: 0x2931FA0
	public void SetHelpText(string help, Color c) { }

	// RVA: 0x29320D0 Offset: 0x29321D1 VA: 0x29320D0
	public void SetHelpActive(bool bActive, Color c) { }

	// RVA: 0x2931A30 Offset: 0x2931B31 VA: 0x2931A30
	private void SetIcon(GmapSpot spot) { }

	// RVA: 0x2932200 Offset: 0x2932301 VA: 0x2932200
	private Sprite GetEncountIcon(EncountUnitData.RareType rareType) { }

	// RVA: 0x29322A0 Offset: 0x29323A1 VA: 0x29322A0
	public void .ctor() { }
}

