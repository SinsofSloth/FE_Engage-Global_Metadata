// Namespace: App
public class ProfileCardFavoriteRelayMapMenu : BasicMenu // TypeDefIndex: 11587
{
	// Fields
	private static readonly int m_MenuItemIndexNone; // 0x0
	private static readonly int m_MenuItemIndexEmpty; // 0x4
	private ProfileCardFavoriteRelayMapMenu.DisposeEventHandler m_DisposeEventHandler; // 0xC8
	private ProfileCardRoot m_ProfileCardRoot; // 0xD0
	private ProfileCard m_MyProfileCardTemp; // 0xD8
	private int m_DecidedMenuItemIndex; // 0xE0
	private bool m_Sorted; // 0xE4

	// Methods

	// RVA: 0x2811FA0 Offset: 0x28120A1 VA: 0x2811FA0
	public static ProfileCardFavoriteRelayMapMenu CreateBind(ProcInst super, ProfileCardTextListMenuContent menuContent, ProfileCardRoot profileCardRoot, ProfileCard myProfileCardTemp, ProfileCardFavoriteRelayMapMenu.DisposeEventHandler disposeEventHandler) { }

	// RVA: 0x28120E0 Offset: 0x28121E1 VA: 0x28120E0
	private static List<BasicMenuItem> CreateMenuItem(ProfileCardFavoriteMapData initialFavoriteMapData, bool sorting, out int initialDecidedIndex) { }

	// RVA: 0x2812590 Offset: 0x2812691 VA: 0x2812590
	private void .ctor(List<BasicMenuItem> menuItemList, BasicMenuContent menuContent, ProfileCardRoot profileCardRoot, ProfileCard myProfileCardTemp, int initialDecidedIndex, ProfileCardFavoriteRelayMapMenu.DisposeEventHandler disposeEventHandler) { }

	// RVA: 0x2812780 Offset: 0x2812881 VA: 0x2812780 Slot: 24
	protected override void OnBuild(bool isFirstBuild) { }

	// RVA: 0x2812830 Offset: 0x2812931 VA: 0x2812830
	public void RebuildMenu() { }

	// RVA: 0x28129B0 Offset: 0x2812AB1 VA: 0x28129B0 Slot: 30
	public override string GetName() { }

	// RVA: 0x2812A00 Offset: 0x2812B01 VA: 0x2812A00
	public void UpdateCardRoot(ProfileCardFavoriteMapData favoriteMapData) { }

	// RVA: 0x2812B70 Offset: 0x2812C71 VA: 0x2812B70
	public bool UpdateDecided(int menuItemIndex) { }

	// RVA: 0x2812EE0 Offset: 0x2812FE1 VA: 0x2812EE0 Slot: 51
	protected override BasicMenu.Result BCall() { }

	// RVA: 0x2812EF0 Offset: 0x2812FF1 VA: 0x2812EF0 Slot: 58
	protected override BasicMenu.Result CustomCall() { }

	// RVA: 0x28130F0 Offset: 0x28131F1 VA: 0x28130F0 Slot: 10
	protected override void OnDispose() { }

	// RVA: 0x28131D0 Offset: 0x28132D1 VA: 0x28131D0
	private static void .cctor() { }
}

