// Namespace: App
public class ProfileCardTitleMenu : BasicMenu // TypeDefIndex: 11649
{
	// Fields
	private static readonly int m_MenuItemIndexNone; // 0x0
	private static readonly int m_MenuItemIndexEmpty; // 0x4
	private ProfileCardRoot m_CardRoot; // 0xC8
	private ProfileCardTitleMenu.DisposeEventHandler m_DisposeEventHandler; // 0xD0
	private ProfileCard m_MyProfileCardTemp; // 0xD8
	private int m_DecidedMenuItemIndex; // 0xE0
	private bool m_Sorted; // 0xE4

	// Methods

	// RVA: 0x2EE3300 Offset: 0x2EE3401 VA: 0x2EE3300
	public static ProfileCardTitleMenu CreateBind(ProcInst super, ProfileCardTextListMenuContent menuContent, ProfileCardRoot cardRoot, ProfileCard myProfileCardTemp, ProfileCardTitleMenu.DisposeEventHandler disposeEventHandler) { }

	// RVA: 0x2EE3440 Offset: 0x2EE3541 VA: 0x2EE3440
	private static List<BasicMenuItem> CreateMenuItem(ProfileCardTitleData initialTitleData, bool sorting, out int initialDecidedIndex) { }

	// RVA: 0x2EE38E0 Offset: 0x2EE39E1 VA: 0x2EE38E0
	private void .ctor(List<BasicMenuItem> menuItemList, BasicMenuContent menuContent, ProfileCardRoot cardRoot, ProfileCard myProfileCardTemp, int initialDecidedIndex, ProfileCardTitleMenu.DisposeEventHandler disposeEventHandler) { }

	// RVA: 0x2EE3B30 Offset: 0x2EE3C31 VA: 0x2EE3B30 Slot: 24
	protected override void OnBuild(bool isFirstBuild) { }

	// RVA: 0x2EE3C10 Offset: 0x2EE3D11 VA: 0x2EE3C10
	public void RebuildMenu() { }

	// RVA: 0x2EE3D90 Offset: 0x2EE3E91 VA: 0x2EE3D90 Slot: 30
	public override string GetName() { }

	// RVA: 0x2EE3DE0 Offset: 0x2EE3EE1 VA: 0x2EE3DE0
	public void UpdateCardRoot(ProfileCardTitleData titleData) { }

	// RVA: 0x2EE3E00 Offset: 0x2EE3F01 VA: 0x2EE3E00
	public bool UpdateDecided(int menuItemIndex) { }

	// RVA: 0x2EE4170 Offset: 0x2EE4271 VA: 0x2EE4170 Slot: 51
	protected override BasicMenu.Result BCall() { }

	// RVA: 0x2EE4180 Offset: 0x2EE4281 VA: 0x2EE4180 Slot: 58
	protected override BasicMenu.Result CustomCall() { }

	// RVA: 0x2EE4300 Offset: 0x2EE4401 VA: 0x2EE4300 Slot: 10
	protected override void OnDispose() { }

	// RVA: 0x2EE43E0 Offset: 0x2EE44E1 VA: 0x2EE43E0
	private static void .cctor() { }
}

