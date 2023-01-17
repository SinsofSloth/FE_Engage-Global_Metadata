// Namespace: App
public class ProfileCardStampListMenu : GridMenu // TypeDefIndex: 11627
{
	// Fields
	public static readonly int m_MenuItemIndexNone; // 0x0
	public static readonly int m_MenuItemIndexEmpty; // 0x4
	private BasicMenuSelect[] m_Selects; // 0xD8
	private ProfileCardStampData.Categories m_Category; // 0xE0
	private ProfileCardStampListMenu.DecideEventHandler m_DecideEventHandler; // 0xE8
	private ProfileCardStampListMenu.CloseEventHandler m_CloseEventHandler; // 0xF0
	private ProfileCardStampListMenu.DisposeEventHandler m_DisposeEventHandler; // 0xF8

	// Methods

	// RVA: 0x2ED6A10 Offset: 0x2ED6B11 VA: 0x2ED6A10
	public static ProfileCardStampListMenu CreateBind(ProcInst super, ProfileCardStampListMenuContent menuContent, ProfileCardStampData initialStampData, ProfileCardStampListMenu.DecideEventHandler decideEventHandler, ProfileCardStampListMenu.CloseEventHandler closeEventHandler, ProfileCardStampListMenu.DisposeEventHandler disposeEventHandler) { }

	// RVA: 0x2ED6B80 Offset: 0x2ED6C81 VA: 0x2ED6B80
	private static List<BasicMenuItem> CreateMenuItem(ProfileCardStampData.Categories category, ProfileCardStampData initialStampData, ProfileCardStampListMenu.DecideEventHandler decideEventHandler, out int initialDecidedIndex) { }

	// RVA: 0x2ED6EF0 Offset: 0x2ED6FF1 VA: 0x2ED6EF0
	private void .ctor(List<BasicMenuItem> menuItemList, GridMenuContent menuContent, ProfileCardStampData.Categories initialCategory, int initialSelectedIndex, ProfileCardStampListMenu.DecideEventHandler decideEventHandler, ProfileCardStampListMenu.CloseEventHandler closeEventHandler, ProfileCardStampListMenu.DisposeEventHandler disposeEventHandler) { }

	// RVA: 0x2ED72C0 Offset: 0x2ED73C1 VA: 0x2ED72C0 Slot: 24
	protected override void OnBuild(bool isFirstBuild) { }

	// RVA: 0x2ED7400 Offset: 0x2ED7501 VA: 0x2ED7400
	public void RebuildMenu() { }

	// RVA: 0x2ED75C0 Offset: 0x2ED76C1 VA: 0x2ED75C0 Slot: 30
	public override string GetName() { }

	// RVA: 0x2ED7550 Offset: 0x2ED7651 VA: 0x2ED7550
	private BasicMenuSelect GetSelect() { }

	// RVA: 0x2ED7150 Offset: 0x2ED7251 VA: 0x2ED7150
	private void UpdateContent() { }

	// RVA: 0x2ED7790 Offset: 0x2ED7891 VA: 0x2ED7790 Slot: 58
	protected override BasicMenu.Result CustomCall() { }

	// RVA: 0x2ED7D00 Offset: 0x2ED7E01 VA: 0x2ED7D00
	protected BasicMenu.Result LRepeatCall(bool isTrigger) { }

	// RVA: 0x2ED7E10 Offset: 0x2ED7F11 VA: 0x2ED7E10
	protected BasicMenu.Result RRepeatCall(bool isTrigger) { }

	// RVA: 0x2ED7F20 Offset: 0x2ED8021 VA: 0x2ED7F20 Slot: 26
	public override void OnClose() { }

	// RVA: 0x2ED7F40 Offset: 0x2ED8041 VA: 0x2ED7F40 Slot: 10
	protected override void OnDispose() { }

	// RVA: 0x2ED8020 Offset: 0x2ED8121 VA: 0x2ED8020
	private static void .cctor() { }
}

