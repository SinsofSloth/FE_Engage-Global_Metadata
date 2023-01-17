// Namespace: App
public class MyRoomWakeupSelectMenu : BasicMenu // TypeDefIndex: 11339
{
	// Fields
	public bool IsRankPhase; // 0xC4
	private List<BasicMenuSelect> m_MenuSelectList; // 0xC8
	private RelianceData.Level m_OldLevel; // 0xD0
	private GameSound.WakeupVoicePattern m_OldPattern; // 0xD4

	// Methods

	// RVA: 0x2840DC0 Offset: 0x2840EC1 VA: 0x2840DC0
	public static MyRoomWakeupSelectMenu CreateBind(ProcInst super, int select, int scroll) { }

	// RVA: 0x2841610 Offset: 0x2841711 VA: 0x2841610 Slot: 18
	public override ProcDesc[] CreateDefaultDesc() { }

	// RVA: 0x2840F00 Offset: 0x2841001 VA: 0x2840F00
	private static List<BasicMenuItem> CreateMenuList() { }

	// RVA: 0x28412A0 Offset: 0x28413A1 VA: 0x28412A0
	protected void .ctor(List<BasicMenuItem> menuItemList, MyRoomWakeupSelectMenuContent menuContent) { }

	// RVA: 0x2841C90 Offset: 0x2841D91 VA: 0x2841C90 Slot: 30
	public override string GetName() { }

	// RVA: 0x2841CE0 Offset: 0x2841DE1 VA: 0x2841CE0
	public void SetOldLevelAndPattern(RelianceData.Level level, GameSound.WakeupVoicePattern pattern) { }

	// RVA: 0x2841CF0 Offset: 0x2841DF1 VA: 0x2841CF0 Slot: 25
	protected override void AfterBuild() { }

	// RVA: 0x2841EA0 Offset: 0x2841FA1 VA: 0x2841EA0 Slot: 40
	protected override void KeyUp(bool isTrigger) { }

	// RVA: 0x2841F60 Offset: 0x2842061 VA: 0x2841F60 Slot: 41
	protected override void KeyDown(bool isTrigger) { }

	// RVA: 0x2842020 Offset: 0x2842121 VA: 0x2842020 Slot: 42
	protected override void KeyLeft(bool isTrigger) { }

	// RVA: 0x28420D0 Offset: 0x28421D1 VA: 0x28420D0 Slot: 43
	protected override void KeyRight(bool isTrigger) { }

	// RVA: 0x2842180 Offset: 0x2842281 VA: 0x2842180 Slot: 58
	protected override BasicMenu.Result CustomCall() { }

	// RVA: 0x2842AF0 Offset: 0x2842BF1 VA: 0x2842AF0 Slot: 10
	protected override void OnDispose() { }
}

