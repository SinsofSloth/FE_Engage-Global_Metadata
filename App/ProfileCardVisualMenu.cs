// Namespace: App
public class ProfileCardVisualMenu : GridMenu // TypeDefIndex: 11667
{
	// Fields
	private string[] CaptionMid; // 0xD8
	private static readonly int m_MenuItemIndexNone; // 0x0
	private ProfileCardRoot m_ProfileCardRoot; // 0xE0
	private ProfileCard m_MyProfileCardTemp; // 0xE8
	private int m_DecidedMenuItemIndex; // 0xF0
	private ProfileCardVisualMenu.Category m_Category; // 0xF4
	private BasicMenuSelect[] m_Selects; // 0xF8
	private ProfileCardVisualMenu.DecideEventHandler m_DecideEventHandler; // 0x100
	private ProfileCardVisualMenu.DisposeEventHandler m_DisposeEventHandler; // 0x108

	// Methods

	// RVA: 0x2EE9FB0 Offset: 0x2EEA0B1 VA: 0x2EE9FB0
	public static ProfileCardVisualMenu CreateBind(ProcInst super, ProfileCardVisualMenuContent menuContent, ProfileCardRoot profileCardRoot, ProfileCard myProfileCardTemp, ProfileCardVisualMenu.Category initialCategory, ProfileCardVisualMenu.DecideEventHandler decideEventHandler, ProfileCardVisualMenu.DisposeEventHandler disposeEventHandler) { }

	// RVA: 0x2EEA100 Offset: 0x2EEA201 VA: 0x2EEA100
	private static List<BasicMenuItem> CreateMenuItem(ProfileCardVisualMenu.Category category, ProfileCard myProfileCardTemp, out int initialDecidedIndex) { }

	// RVA: 0x2EEACC0 Offset: 0x2EEADC1 VA: 0x2EEACC0
	private void .ctor(List<BasicMenuItem> menuItemList, GridMenuContent menuContent, ProfileCardRoot profileCardRoot, ProfileCard myProfileCardTemp, ProfileCardVisualMenu.Category category, int initialDecidedIndex, ProfileCardVisualMenu.DecideEventHandler decideEventHandler, ProfileCardVisualMenu.DisposeEventHandler disposeEventHandler) { }

	// RVA: 0x2EEB2B0 Offset: 0x2EEB3B1 VA: 0x2EEB2B0 Slot: 24
	protected override void OnBuild(bool isFirstBuild) { }

	// RVA: 0x2EEB3F0 Offset: 0x2EEB4F1 VA: 0x2EEB3F0
	public void RebuildMenu() { }

	// RVA: 0x2EEB5B0 Offset: 0x2EEB6B1 VA: 0x2EEB5B0 Slot: 30
	public override string GetName() { }

	// RVA: 0x2EEB540 Offset: 0x2EEB641 VA: 0x2EEB540
	private BasicMenuSelect GetSelect() { }

	// RVA: 0x2EE8990 Offset: 0x2EE8A91 VA: 0x2EE8990
	public bool UpdateDecided(int menuItemIndex) { }

	// RVA: 0x2EEB980 Offset: 0x2EEBA81 VA: 0x2EEB980
	public void UpdateDecidedRemovable(int menuItemIndex) { }

	// RVA: 0x2EEB600 Offset: 0x2EEB701 VA: 0x2EEB600
	private string UpdateProfileData(bool remove) { }

	// RVA: 0x2EEB150 Offset: 0x2EEB251 VA: 0x2EEB150
	private void UpdateContent() { }

	// RVA: 0x2EE8540 Offset: 0x2EE8641 VA: 0x2EE8540
	public void UpdateCardRoot(int menuItemIndex) { }

	// RVA: 0x2EEBDC0 Offset: 0x2EEBEC1 VA: 0x2EEBDC0 Slot: 10
	protected override void OnDispose() { }

	// RVA: 0x2EEBEA0 Offset: 0x2EEBFA1 VA: 0x2EEBEA0
	private static void .cctor() { }
}

