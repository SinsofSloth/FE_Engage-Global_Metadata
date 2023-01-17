// Namespace: App
public class ProfileCardAlbumListMenu : BasicMenu // TypeDefIndex: 11543
{
	// Fields
	private ProfileCardRoot m_ProfileCardRoot; // 0xC8
	private ProfileCardAlbumListMenu.DecideEventHandler m_DecideEventHandler; // 0xD0
	private ProfileCardAlbumListMenu.DeleteEventHandler m_DeleteEventHandler; // 0xD8
	private ProfileCardAlbumListMenu.DisposeEventHandler m_DisposeEventHandler; // 0xE0
	private bool m_FirstTimeUpdateCardRoot; // 0xE8

	// Methods

	// RVA: 0x29EB8D0 Offset: 0x29EB9D1 VA: 0x29EB8D0
	public static ProfileCardAlbumListMenu CreateBind(ProcInst super, ProfileCardAlbumListMenuContent menuContent, ProfileCardRoot profiledCardRoot, int initialIndex, ProfileCardAlbumListMenu.DecideEventHandler decideEventHandler, ProfileCardAlbumListMenu.DeleteEventHandler deleteEventHandler, ProfileCardAlbumListMenu.DisposeEventHandler disposeEventHandler) { }

	// RVA: 0x29EBA50 Offset: 0x29EBB51 VA: 0x29EBA50
	private static List<BasicMenuItem> CreateMenuItem(ProfileCardAlbumListMenu.DecideEventHandler decideEventHandler) { }

	// RVA: 0x29EBC90 Offset: 0x29EBD91 VA: 0x29EBC90
	private void .ctor(List<BasicMenuItem> menuItemList, BasicMenuContent menuContent, ProfileCardRoot profileCardRoot, int initialIndex, ProfileCardAlbumListMenu.DecideEventHandler decideEventHandler, ProfileCardAlbumListMenu.DeleteEventHandler deleteEventHandler, ProfileCardAlbumListMenu.DisposeEventHandler disposeEventHandler) { }

	// RVA: 0x29EBDD0 Offset: 0x29EBED1 VA: 0x29EBDD0 Slot: 24
	protected override void OnBuild(bool isFirstBuild) { }

	// RVA: 0x29EBF10 Offset: 0x29EC011 VA: 0x29EBF10
	public void RebuildMenu() { }

	// RVA: 0x29EBFC0 Offset: 0x29EC0C1 VA: 0x29EBFC0 Slot: 30
	public override string GetName() { }

	// RVA: 0x29EC010 Offset: 0x29EC111 VA: 0x29EC010
	public void RemoveProfileCard(int index) { }

	// RVA: 0x29EC190 Offset: 0x29EC291 VA: 0x29EC190
	public void UpdateCardRoot(ProfileCard profileCard) { }

	// RVA: 0x29EC1B0 Offset: 0x29EC2B1 VA: 0x29EC1B0 Slot: 51
	protected override BasicMenu.Result BCall() { }

	// RVA: 0x29EC1E0 Offset: 0x29EC2E1 VA: 0x29EC1E0 Slot: 10
	protected override void OnDispose() { }
}

