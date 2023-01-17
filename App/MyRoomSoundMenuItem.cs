// Namespace: App
public class MyRoomSoundMenuItem : BasicMenuItem // TypeDefIndex: 11333
{
	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x297B20 Offset: 0x297C21 VA: 0x297B20
	private readonly Action<string> <Callback>k__BackingField; // 0x68
	private string m_eventName; // 0x70
	private string m_label; // 0x78
	private string m_help; // 0x80

	// Properties
	public Action<string> Callback { get; }
	public bool IsPlay { get; }
	public string EventName { get; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x2C4FE0 Offset: 0x2C50E1 VA: 0x2C4FE0
	// RVA: 0x283E680 Offset: 0x283E781 VA: 0x283E680
	public Action<string> get_Callback() { }

	// RVA: 0x283DB50 Offset: 0x283DC51 VA: 0x283DB50
	public bool get_IsPlay() { }

	// RVA: 0x283E690 Offset: 0x283E791 VA: 0x283E690
	public string get_EventName() { }

	// RVA: 0x283C910 Offset: 0x283CA11 VA: 0x283C910
	public void .ctor(string eventName, string name, string help, Action<string> callback) { }

	// RVA: 0x283E6A0 Offset: 0x283E7A1 VA: 0x283E6A0 Slot: 4
	public override string GetName() { }

	// RVA: 0x283E740 Offset: 0x283E841 VA: 0x283E740 Slot: 8
	public override BasicMenuItem.Attribute BuildAttribute() { }

	// RVA: 0x283E7F0 Offset: 0x283E8F1 VA: 0x283E7F0 Slot: 12
	public override void OnSelect() { }

	// RVA: 0x283E9D0 Offset: 0x283EAD1 VA: 0x283E9D0 Slot: 18
	public override BasicMenu.Result ACall() { }

	// RVA: 0x283EA60 Offset: 0x283EB61 VA: 0x283EA60 Slot: 19
	public override BasicMenu.Result BCall() { }

	// RVA: 0x283EA70 Offset: 0x283EB71 VA: 0x283EA70 Slot: 14
	public override void OnCursorMoveEnd() { }

	// RVA: 0x283DF90 Offset: 0x283E091 VA: 0x283DF90
	public void SetCurrentMusicName() { }

	// RVA: 0x283EAC0 Offset: 0x283EBC1 VA: 0x283EAC0
	public void SetMusicName(string musicName) { }

	// RVA: 0x283E930 Offset: 0x283EA31 VA: 0x283E930
	public void SetMusicHelpText(string text) { }
}

