// Namespace: 
private class SolanelInfoMenuContent.SolanelUnit // TypeDefIndex: 11454
{
	// Fields
	private GameObject m_Root; // 0x10
	private GameObject m_Icon; // 0x18
	private TextMeshProUGUI m_UnitName; // 0x20
	private GameObject m_TalkIcon; // 0x28

	// Methods

	// RVA: 0x203EEC0 Offset: 0x203EFC1 VA: 0x203EEC0
	public void .ctor(GameObject root) { }

	// RVA: 0x203F040 Offset: 0x203F141 VA: 0x203F040
	public void SetUnit(Unit unit, HubAccessData hubAccessData) { }

	// RVA: 0x203F570 Offset: 0x203F671 VA: 0x203F570
	public void SetGodUnit(GodData god, HubAccessData hubAccessData) { }

	// RVA: 0x203F1A0 Offset: 0x203F2A1 VA: 0x203F1A0
	public void Hide() { }

	// RVA: 0x203F220 Offset: 0x203F321 VA: 0x203F220
	private void SetTalkIcon(HubAccessData hubAccessData) { }
}

// Namespace: 
private class SolanelInfoMenuContent.Infomation // TypeDefIndex: 11456
{
	// Fields
	private GameObject m_Root; // 0x10
	private Image m_Icon; // 0x18
	private TextMeshProUGUI m_Title; // 0x20
	private TextMeshProUGUI m_Message; // 0x28

	// Methods

	// RVA: 0x203EC50 Offset: 0x203ED51 VA: 0x203EC50
	public void .ctor(GameObject root) { }

	// RVA: 0x203DD40 Offset: 0x203DE41 VA: 0x203DD40
	public void Show(Sprite sprite, string title, string message) { }

	// RVA: 0x203EE40 Offset: 0x203EF41 VA: 0x203EE40
	public void Hide() { }
}

