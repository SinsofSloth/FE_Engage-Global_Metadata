// Namespace: App
public class HubAccessData // TypeDefIndex: 10644
{
	// Fields
	public string AID; // 0x10
	[CompilerGeneratedAttribute] // RVA: 0x293150 Offset: 0x293251 VA: 0x293150
	private HubDisposData <DisposData>k__BackingField; // 0x18
	[CompilerGeneratedAttribute] // RVA: 0x293160 Offset: 0x293261 VA: 0x293160
	private bool <IsStory>k__BackingField; // 0x20
	[CompilerGeneratedAttribute] // RVA: 0x293170 Offset: 0x293271 VA: 0x293170
	private bool <IsReliance>k__BackingField; // 0x21
	[CompilerGeneratedAttribute] // RVA: 0x293180 Offset: 0x293281 VA: 0x293180
	private bool <IsGod>k__BackingField; // 0x22
	[CompilerGeneratedAttribute] // RVA: 0x293190 Offset: 0x293291 VA: 0x293190
	private bool <IsUnit>k__BackingField; // 0x23
	[CompilerGeneratedAttribute] // RVA: 0x2931A0 Offset: 0x2932A1 VA: 0x2931A0
	private bool <IsAnimal>k__BackingField; // 0x24
	[CompilerGeneratedAttribute] // RVA: 0x2931B0 Offset: 0x2932B1 VA: 0x2931B0
	private bool <IsPerson>k__BackingField; // 0x25
	[CompilerGeneratedAttribute] // RVA: 0x2931C0 Offset: 0x2932C1 VA: 0x2931C0
	private int <ResultTalkIndex>k__BackingField; // 0x28
	[CompilerGeneratedAttribute] // RVA: 0x2931D0 Offset: 0x2932D1 VA: 0x2931D0
	private bool <IsHeroBirthday>k__BackingField; // 0x2C
	[CompilerGeneratedAttribute] // RVA: 0x2931E0 Offset: 0x2932E1 VA: 0x2931E0
	private string <TalkItem>k__BackingField; // 0x30
	[CompilerGeneratedAttribute] // RVA: 0x2931F0 Offset: 0x2932F1 VA: 0x2931F0
	private int <ItemCount>k__BackingField; // 0x38
	private string m_flagName; // 0x40
	private List<string> m_messages; // 0x48
	private static List<string> ignoreUsedPattern; // 0x0

	// Properties
	public string MID { get; }
	public HubDisposData DisposData { get; set; }
	public bool IsStory { get; set; }
	public bool IsReliance { get; set; }
	public bool IsGod { get; set; }
	public bool IsUnit { get; set; }
	public bool IsAnimal { get; set; }
	public bool IsPerson { get; set; }
	public bool IsDone { get; }
	public bool IsAccessed { get; }
	public int AccessCount { get; }
	private string AccessCountFlagName { get; }
	public bool IsAccessEnabled { get; }
	public int ResultTalkIndex { get; set; }
	public bool IsHeroBirthday { get; set; }
	public string TalkItem { get; set; }
	public int ItemCount { get; set; }

	// Methods

	// RVA: 0x2668340 Offset: 0x2668441 VA: 0x2668340
	public string get_MID() { }

	[CompilerGeneratedAttribute] // RVA: 0x2C0180 Offset: 0x2C0281 VA: 0x2C0180
	// RVA: 0x266CF40 Offset: 0x266D041 VA: 0x266CF40
	public HubDisposData get_DisposData() { }

	[CompilerGeneratedAttribute] // RVA: 0x2C0190 Offset: 0x2C0291 VA: 0x2C0190
	// RVA: 0x266CF50 Offset: 0x266D051 VA: 0x266CF50
	public void set_DisposData(HubDisposData value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2C01A0 Offset: 0x2C02A1 VA: 0x2C01A0
	// RVA: 0x266CF60 Offset: 0x266D061 VA: 0x266CF60
	public bool get_IsStory() { }

	[CompilerGeneratedAttribute] // RVA: 0x2C01B0 Offset: 0x2C02B1 VA: 0x2C01B0
	// RVA: 0x266CF70 Offset: 0x266D071 VA: 0x266CF70
	public void set_IsStory(bool value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2C01C0 Offset: 0x2C02C1 VA: 0x2C01C0
	// RVA: 0x266CF80 Offset: 0x266D081 VA: 0x266CF80
	public bool get_IsReliance() { }

	[CompilerGeneratedAttribute] // RVA: 0x2C01D0 Offset: 0x2C02D1 VA: 0x2C01D0
	// RVA: 0x266CF90 Offset: 0x266D091 VA: 0x266CF90
	public void set_IsReliance(bool value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2C01E0 Offset: 0x2C02E1 VA: 0x2C01E0
	// RVA: 0x266CFA0 Offset: 0x266D0A1 VA: 0x266CFA0
	public bool get_IsGod() { }

	[CompilerGeneratedAttribute] // RVA: 0x2C01F0 Offset: 0x2C02F1 VA: 0x2C01F0
	// RVA: 0x266CFB0 Offset: 0x266D0B1 VA: 0x266CFB0
	public void set_IsGod(bool value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2C0200 Offset: 0x2C0301 VA: 0x2C0200
	// RVA: 0x266CFC0 Offset: 0x266D0C1 VA: 0x266CFC0
	public bool get_IsUnit() { }

	[CompilerGeneratedAttribute] // RVA: 0x2C0210 Offset: 0x2C0311 VA: 0x2C0210
	// RVA: 0x266CFD0 Offset: 0x266D0D1 VA: 0x266CFD0
	public void set_IsUnit(bool value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2C0220 Offset: 0x2C0321 VA: 0x2C0220
	// RVA: 0x266CFE0 Offset: 0x266D0E1 VA: 0x266CFE0
	public bool get_IsAnimal() { }

	[CompilerGeneratedAttribute] // RVA: 0x2C0230 Offset: 0x2C0331 VA: 0x2C0230
	// RVA: 0x266CFF0 Offset: 0x266D0F1 VA: 0x266CFF0
	public void set_IsAnimal(bool value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2C0240 Offset: 0x2C0341 VA: 0x2C0240
	// RVA: 0x266D000 Offset: 0x266D101 VA: 0x266D000
	public bool get_IsPerson() { }

	[CompilerGeneratedAttribute] // RVA: 0x2C0250 Offset: 0x2C0351 VA: 0x2C0250
	// RVA: 0x266D010 Offset: 0x266D111 VA: 0x266D010
	public void set_IsPerson(bool value) { }

	// RVA: 0x2668740 Offset: 0x2668841 VA: 0x2668740
	public bool get_IsDone() { }

	// RVA: 0x2668530 Offset: 0x2668631 VA: 0x2668530
	public bool get_IsAccessed() { }

	// RVA: 0x26688B0 Offset: 0x26689B1 VA: 0x26688B0
	public int get_AccessCount() { }

	// RVA: 0x266D020 Offset: 0x266D121 VA: 0x266D020
	private string get_AccessCountFlagName() { }

	// RVA: 0x26684D0 Offset: 0x26685D1 VA: 0x26684D0
	public bool get_IsAccessEnabled() { }

	[CompilerGeneratedAttribute] // RVA: 0x2C0260 Offset: 0x2C0361 VA: 0x2C0260
	// RVA: 0x266D100 Offset: 0x266D201 VA: 0x266D100
	public int get_ResultTalkIndex() { }

	[CompilerGeneratedAttribute] // RVA: 0x2C0270 Offset: 0x2C0371 VA: 0x2C0270
	// RVA: 0x266D110 Offset: 0x266D211 VA: 0x266D110
	public void set_ResultTalkIndex(int value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2C0280 Offset: 0x2C0381 VA: 0x2C0280
	// RVA: 0x266D120 Offset: 0x266D221 VA: 0x266D120
	public bool get_IsHeroBirthday() { }

	[CompilerGeneratedAttribute] // RVA: 0x2C0290 Offset: 0x2C0391 VA: 0x2C0290
	// RVA: 0x266D130 Offset: 0x266D231 VA: 0x266D130
	public void set_IsHeroBirthday(bool value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2C02A0 Offset: 0x2C03A1 VA: 0x2C02A0
	// RVA: 0x266D140 Offset: 0x266D241 VA: 0x266D140
	public string get_TalkItem() { }

	[CompilerGeneratedAttribute] // RVA: 0x2C02B0 Offset: 0x2C03B1 VA: 0x2C02B0
	// RVA: 0x266D150 Offset: 0x266D251 VA: 0x266D150
	public void set_TalkItem(string value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2C02C0 Offset: 0x2C03C1 VA: 0x2C02C0
	// RVA: 0x266D160 Offset: 0x266D261 VA: 0x266D160
	public int get_ItemCount() { }

	[CompilerGeneratedAttribute] // RVA: 0x2C02D0 Offset: 0x2C03D1 VA: 0x2C02D0
	// RVA: 0x266D170 Offset: 0x266D271 VA: 0x266D170
	public void set_ItemCount(int value) { }

	// RVA: 0x2668BC0 Offset: 0x2668CC1 VA: 0x2668BC0
	public int GetMessageCount() { }

	// RVA: 0x2668CC0 Offset: 0x2668DC1 VA: 0x2668CC0
	public string GetMessage(int index) { }

	// RVA: 0x2668D40 Offset: 0x2668E41 VA: 0x2668D40
	public void UpdateAccessCount() { }

	// RVA: 0x266D180 Offset: 0x266D281 VA: 0x266D180
	public void PreLocate() { }

	// RVA: 0x266A7A0 Offset: 0x266A8A1 VA: 0x266A7A0
	public bool DoneAccess() { }

	// RVA: 0x266D3D0 Offset: 0x266D4D1 VA: 0x266D3D0
	public bool ConfirmMessage(string label, bool newAdd = False) { }

	// RVA: 0x266ADB0 Offset: 0x266AEB1 VA: 0x266ADB0
	public void ConfirmContent(HubAccessManager manager) { }

	// RVA: 0x266D510 Offset: 0x266D611 VA: 0x266D510
	private void ConfirmContentHub(HubAccessManager manager) { }

	// RVA: 0x266EF80 Offset: 0x266F081 VA: 0x266EF80
	private bool ConfirmResult(HubAccessManager manager, string baseName, string talkType, Func<int, int, bool> func) { }

	// RVA: 0x266F2B0 Offset: 0x266F3B1 VA: 0x266F2B0
	private bool ConfirmStoryResult(string storyLabel) { }

	// RVA: 0x266DED0 Offset: 0x266DFD1 VA: 0x266DED0
	private void ConfirmContentKizuna(HubAccessManager manager) { }

	// RVA: 0x266C150 Offset: 0x266C251 VA: 0x266C150
	public string TryGetPID() { }

	// RVA: 0x266F470 Offset: 0x266F571 VA: 0x266F470
	public void ChangeTalk(string mid) { }

	// RVA: 0x2669800 Offset: 0x2669901 VA: 0x2669800
	public void .ctor() { }

	// RVA: 0x266F500 Offset: 0x266F601 VA: 0x266F500
	private static void .cctor() { }
}

