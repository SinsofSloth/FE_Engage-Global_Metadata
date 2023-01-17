// Namespace: App
public class MyRoomSoundMenu : BasicMenu // TypeDefIndex: 11332
{
	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x297B00 Offset: 0x297C01 VA: 0x297B00
	private readonly BgmPlayer <Player>k__BackingField; // 0xC8
	[CompilerGeneratedAttribute] // RVA: 0x297B10 Offset: 0x297C11 VA: 0x297B10
	private static string <SelectBgm>k__BackingField; // 0x0
	private MyRoomSoundMenu.MenuType m_menuType; // 0xD0
	private const int DefaultBgmChangeSuppressCount = 4;
	private int m_bgmChangeSuppressCount; // 0xD4

	// Properties
	public BgmPlayer Player { get; }
	public static string SelectBgm { get; set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x2C4FB0 Offset: 0x2C50B1 VA: 0x2C4FB0
	// RVA: 0x283C040 Offset: 0x283C141 VA: 0x283C040
	public BgmPlayer get_Player() { }

	[CompilerGeneratedAttribute] // RVA: 0x2C4FC0 Offset: 0x2C50C1 VA: 0x2C4FC0
	// RVA: 0x283C050 Offset: 0x283C151 VA: 0x283C050
	public static string get_SelectBgm() { }

	[CompilerGeneratedAttribute] // RVA: 0x2C4FD0 Offset: 0x2C50D1 VA: 0x2C4FD0
	// RVA: 0x283C0C0 Offset: 0x283C1C1 VA: 0x283C0C0
	public static void set_SelectBgm(string value) { }

	// RVA: 0x283C140 Offset: 0x283C241 VA: 0x283C140
	public void .ctor(List<BasicMenuItem> menuItemList, BasicMenuContent menuContent, MyRoomSoundMenu.MenuType menuType, string selectBgm) { }

	// RVA: 0x283C400 Offset: 0x283C501 VA: 0x283C400
	public static void CreateBindMusic(ProcInst super) { }

	// RVA: 0x283CAF0 Offset: 0x283CBF1 VA: 0x283CAF0
	public static void CreateBindJukebox(ProcInst super) { }

	// RVA: 0x283CE50 Offset: 0x283CF51 VA: 0x283CE50
	public static void CreateBindFieldBgmSelect(ProcInst super, string selectBgm, Action<string> callback) { }

	// RVA: 0x283D430 Offset: 0x283D531 VA: 0x283D430 Slot: 30
	public override string GetName() { }

	// RVA: 0x283D480 Offset: 0x283D581 VA: 0x283D480 Slot: 26
	public override void OnClose() { }

	// RVA: 0x283C310 Offset: 0x283C411 VA: 0x283C310
	public void SetMusicName(string musicName) { }

	// RVA: 0x283D6A0 Offset: 0x283D7A1 VA: 0x283D6A0
	public void SetMusicHelpText(string text) { }

	// RVA: 0x283D910 Offset: 0x283DA11 VA: 0x283D910
	public void Play(string eventName) { }

	// RVA: 0x283D920 Offset: 0x283DA21 VA: 0x283D920
	public void PlaySelect(string eventName) { }

	// RVA: 0x283D930 Offset: 0x283DA31 VA: 0x283D930
	public void Stop() { }

	// RVA: 0x283D960 Offset: 0x283DA61 VA: 0x283D960
	public BasicMenuItem.Attribute BuildAttribute(MyRoomSoundMenuItem item) { }

	// RVA: 0x283DBF0 Offset: 0x283DCF1 VA: 0x283DBF0
	public BasicMenu.Result Decide(MyRoomSoundMenuItem item) { }

	// RVA: 0x283E030 Offset: 0x283E131 VA: 0x283E030 Slot: 38
	protected override void Tick() { }

	// RVA: 0x283E080 Offset: 0x283E181 VA: 0x283E080
	private static void .cctor() { }
}

