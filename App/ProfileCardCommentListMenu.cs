// Namespace: App
public class ProfileCardCommentListMenu : BasicMenu // TypeDefIndex: 11571
{
	// Fields
	public static readonly int m_MenuItemIndexNone; // 0x0
	public static readonly int m_MenuItemIndexEmpty; // 0x4
	private ProfileCardCommentListMenu.SelectEventHandler m_SelectEventHandler; // 0xC8
	private ProfileCardCommentListMenu.DecideEventHandler m_DecideEventHandler; // 0xD0
	private ProfileCardCommentListMenu.CancelEventHandler m_CancelEventHandler; // 0xD8
	private ProfileCardCommentListMenu.DisposeEventHandler m_DisposeEventHandler; // 0xE0
	private ProfileCard m_MyProfileCardTemp; // 0xE8
	private ProfileCardCommentData.Categories m_Category; // 0xF0
	private BasicMenuSelect[] m_Selects; // 0xF8
	private int m_DecidedMenuItemIndex; // 0x100
	private ProfileCardCommentData.Categories m_DecidedCategory; // 0x104
	private ProfileCardCommentData m_DecidedCommentData; // 0x108
	private bool m_Sorted; // 0x110

	// Methods

	// RVA: 0x280B720 Offset: 0x280B821 VA: 0x280B720
	public static ProfileCardCommentListMenu CreateBind(ProcInst super, ProfileCardMessageListMenuContent menuContent, ProfileCard myProfileCardTemp, ProfileCardCommentData initialCommentData, ProfileCardCommentListMenu.SelectEventHandler selectEventHandler, ProfileCardCommentListMenu.DecideEventHandler decideEventHandler, ProfileCardCommentListMenu.CancelEventHandler cancelEventHandler, ProfileCardCommentListMenu.DisposeEventHandler disposeEventHandler) { }

	// RVA: 0x280B8A0 Offset: 0x280B9A1 VA: 0x280B8A0
	private static List<BasicMenuItem> CreateMenuItem(ProfileCardCommentData.Categories category, ProfileCardCommentData initialCommentData, bool sorting, ProfileCardCommentListMenu.SelectEventHandler selectEventHandler, out int initialDecidedIndex) { }

	// RVA: 0x280BE00 Offset: 0x280BF01 VA: 0x280BE00
	private void .ctor(List<BasicMenuItem> menuItemList, BasicMenuContent menuContent, ProfileCard myProfileCardTemp, ProfileCardCommentData.Categories initialCategory, int initialDecidedIndex, ProfileCardCommentData initialCommentData, ProfileCardCommentListMenu.SelectEventHandler selectEventHandler, ProfileCardCommentListMenu.DecideEventHandler decideEventHandler, ProfileCardCommentListMenu.CancelEventHandler cancelEventHandler, ProfileCardCommentListMenu.DisposeEventHandler disposeEventHandler) { }

	// RVA: 0x280CC10 Offset: 0x280CD11 VA: 0x280CC10 Slot: 24
	protected override void OnBuild(bool isFirstBuild) { }

	// RVA: 0x280CD50 Offset: 0x280CE51 VA: 0x280CD50
	public void RebuildMenu() { }

	// RVA: 0x280CF30 Offset: 0x280D031 VA: 0x280CF30 Slot: 30
	public override string GetName() { }

	// RVA: 0x280CEC0 Offset: 0x280CFC1 VA: 0x280CEC0
	private BasicMenuSelect GetSelect() { }

	// RVA: 0x280CF80 Offset: 0x280D081 VA: 0x280CF80
	public bool UpdateDecided(int menuItemIndex, bool initial = False) { }

	// RVA: 0x280CAA0 Offset: 0x280CBA1 VA: 0x280CAA0
	private void UpdateContent() { }

	// RVA: 0x280D4C0 Offset: 0x280D5C1 VA: 0x280D4C0 Slot: 42
	protected override void KeyLeft(bool isTrigger) { }

	// RVA: 0x280D5E0 Offset: 0x280D6E1 VA: 0x280D5E0 Slot: 43
	protected override void KeyRight(bool isTrigger) { }

	// RVA: 0x280D700 Offset: 0x280D801 VA: 0x280D700 Slot: 51
	protected override BasicMenu.Result BCall() { }

	// RVA: 0x280D730 Offset: 0x280D831 VA: 0x280D730 Slot: 58
	protected override BasicMenu.Result CustomCall() { }

	// RVA: 0x280D930 Offset: 0x280DA31 VA: 0x280D930 Slot: 10
	protected override void OnDispose() { }

	// RVA: 0x280DA10 Offset: 0x280DB11 VA: 0x280DA10
	private static void .cctor() { }
}

