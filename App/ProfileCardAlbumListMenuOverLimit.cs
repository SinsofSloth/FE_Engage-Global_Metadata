// Namespace: App
public class ProfileCardAlbumListMenuOverLimit : BasicMenu // TypeDefIndex: 11555
{
	// Fields
	private readonly ProfileList m_ProfileList; // 0xC8
	private readonly ProfileCardAlbumRoot m_ProfileCardAlbumRoot; // 0xD0
	private readonly ProfileCardRoot m_ProfileCardRoot; // 0xD8
	private readonly ProfileCardAlbumListMenuOverLimit.CancelEventHandler m_CancelEventHandler; // 0xE0

	// Methods

	// RVA: 0x29ECB70 Offset: 0x29ECC71 VA: 0x29ECB70
	public static ProfileCardAlbumListMenuOverLimit CreateBind(ProcInst super, ProfileList profileList, ProfileCardAlbumListMenuContent menuContent, ProfileCardAlbumRoot profiledCardAlbumRoot, ProfileCardAlbumListMenuOverLimit.CancelEventHandler cancelEventHandler) { }

	// RVA: 0x29ECC70 Offset: 0x29ECD71 VA: 0x29ECC70
	private static List<BasicMenuItem> CreateMenuItem(ProfileList profileList, ProfileCardAlbumListMenuOverLimit.CancelEventHandler cancelEventHandler) { }

	// RVA: 0x29ED120 Offset: 0x29ED221 VA: 0x29ED120
	private static List<BasicMenuItem> CreateMenuItemRebuild(ProfileList profileList, List<BasicMenuItem> oldMenuList, ProfileCardAlbumListMenuOverLimit.CancelEventHandler cancelEventHandler) { }

	// RVA: 0x29ECF30 Offset: 0x29ED031 VA: 0x29ECF30
	private void .ctor(ProfileList profileList, List<BasicMenuItem> menuItemList, BasicMenuContent menuContent, ProfileCardAlbumRoot profileCardAlbumRoot, ProfileCardAlbumListMenuOverLimit.CancelEventHandler cancelEventHandler) { }

	// RVA: 0x29ED340 Offset: 0x29ED441 VA: 0x29ED340 Slot: 30
	public override string GetName() { }

	// RVA: 0x29ED390 Offset: 0x29ED491 VA: 0x29ED390
	private void UpdateCardRoot(ProfileCard profileCard, int selectIndex) { }

	// RVA: 0x29ED3A0 Offset: 0x29ED4A1 VA: 0x29ED3A0
	private void RebuildMenu() { }

	// RVA: 0x29ED4A0 Offset: 0x29ED5A1 VA: 0x29ED4A0
	private void RemoveProfileCard(ProfileCard profile) { }

	[CompilerGeneratedAttribute] // RVA: 0x2C5D50 Offset: 0x2C5E51 VA: 0x2C5D50
	// RVA: 0x29ED050 Offset: 0x29ED151 VA: 0x29ED050
	internal static void <CreateMenuItem>g__AddMenuItem|6_0(int i, ref ProfileCardAlbumListMenuOverLimit.<>c__DisplayClass6_0 ) { }
}

