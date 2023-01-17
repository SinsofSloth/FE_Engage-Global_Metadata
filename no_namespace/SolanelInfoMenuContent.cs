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
private class SolanelInfoMenuContent.HelpFastTravel // TypeDefIndex: 11455
{
	// Fields
	private GameObject m_Root; // 0x10
	private Image m_Icon; // 0x18
	private TextMeshProUGUI m_Name; // 0x20
	private GameObject m_CheckDone; // 0x28
	private GameObject m_Value; // 0x30

	// Methods

	// RVA: 0x203DE00 Offset: 0x203DF01 VA: 0x203DE00
	public void .ctor(GameObject root) { }

	// RVA: 0x203DFD0 Offset: 0x203E0D1 VA: 0x203DFD0
	public bool TrySetFastTravel(HubFacilityData data, Sprite sprite) { }

	// RVA: 0x203E620 Offset: 0x203E721 VA: 0x203E620
	public void Hide() { }

	// RVA: 0x203E6A0 Offset: 0x203E7A1 VA: 0x203E6A0
	private void SetOneOnly(bool isDone) { }

	// RVA: 0x203E860 Offset: 0x203E961 VA: 0x203E860
	private void SetOneDone(bool isDone) { }

	// RVA: 0x203E9A0 Offset: 0x203EAA1 VA: 0x203E9A0
	private void SetCount(int num) { }
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

// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x2778C0 Offset: 0x2779C1 VA: 0x2778C0
private sealed class SolanelInfoMenuContent.<>c__DisplayClass30_0 // TypeDefIndex: 11457
{
	// Fields
	public int showCount; // 0x10
	public List<SolanelInfoMenuContent.Infomation> infomationList; // 0x18
	public SolanelInfoMenuContent <>4__this; // 0x20

	// Methods

	// RVA: 0x203DB70 Offset: 0x203DC71 VA: 0x203DB70
	public void .ctor() { }

	// RVA: 0x203DB80 Offset: 0x203DC81 VA: 0x203DB80
	internal void <Initialize>b__0(string aid, string messege) { }
}

