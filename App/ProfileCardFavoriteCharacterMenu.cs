// Namespace: App
public class ProfileCardFavoriteCharacterMenu : BasicMenu // TypeDefIndex: 11582
{
	// Fields
	private static readonly int m_MenuItemIndexNone; // 0x0
	private static readonly int m_MenuItemIndexEmpty; // 0x4
	private ProfileCardFavoriteCharacterMenu.DisposeEventHandler m_DisposeEventHandler; // 0xC8
	private ProfileCardRoot m_ProfileCardRoot; // 0xD0
	private ProfileCard m_MyProfileCardTemp; // 0xD8
	private int m_DecidedMenuItemIndex; // 0xE0
	private bool m_Sorted; // 0xE4

	// Methods

	// RVA: 0x280FF10 Offset: 0x2810011 VA: 0x280FF10
	public static ProfileCardFavoriteCharacterMenu CreateBind(ProcInst super, ProfileCardTextListMenuContent menuContent, ProfileCardRoot profileCardRoot, ProfileCard myProfileCardTemp, ProfileCardFavoriteCharacterMenu.DisposeEventHandler disposeEventHandler) { }

	// RVA: 0x2810050 Offset: 0x2810151 VA: 0x2810050
	private static List<BasicMenuItem> CreateMenuItem(ProfileCardFavoriteCharacterData initialCharacter, bool sorting, out int initialDecidedIndex) { }

	// RVA: 0x2810500 Offset: 0x2810601 VA: 0x2810500
	private void .ctor(List<BasicMenuItem> menuItemList, BasicMenuContent menuContent, ProfileCardRoot profileCardRoot, ProfileCard myProfileCardTemp, int initialDecidedIndex, ProfileCardFavoriteCharacterMenu.DisposeEventHandler disposeEventHandler) { }

	// RVA: 0x28106F0 Offset: 0x28107F1 VA: 0x28106F0 Slot: 24
	protected override void OnBuild(bool isFirstBuild) { }

	// RVA: 0x28107A0 Offset: 0x28108A1 VA: 0x28107A0
	public void RebuildMenu() { }

	// RVA: 0x2810920 Offset: 0x2810A21 VA: 0x2810920 Slot: 30
	public override string GetName() { }

	// RVA: 0x2810970 Offset: 0x2810A71 VA: 0x2810970
	public void UpdateCardRoot(ProfileCardFavoriteCharacterData characterData) { }

	// RVA: 0x2810AC0 Offset: 0x2810BC1 VA: 0x2810AC0
	public bool UpdateDecided(int menuItemIndex) { }

	// RVA: 0x2810E30 Offset: 0x2810F31 VA: 0x2810E30 Slot: 51
	protected override BasicMenu.Result BCall() { }

	// RVA: 0x2810E40 Offset: 0x2810F41 VA: 0x2810E40 Slot: 58
	protected override BasicMenu.Result CustomCall() { }

	// RVA: 0x2811040 Offset: 0x2811141 VA: 0x2811040 Slot: 10
	protected override void OnDispose() { }

	// RVA: 0x2811120 Offset: 0x2811221 VA: 0x2811120
	private static void .cctor() { }
}

