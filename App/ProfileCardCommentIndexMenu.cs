// Namespace: App
public class ProfileCardCommentIndexMenu : BasicMenu // TypeDefIndex: 11564
{
	// Fields
	private ProfileCardCommentIndexMenu.DecideEventHandler m_DecideEventHandler; // 0xC8
	private ProfileCardCommentIndexMenu.DisposeEventHandler m_DisposeEventHandler; // 0xD0

	// Methods

	// RVA: 0x280AA40 Offset: 0x280AB41 VA: 0x280AA40
	public static ProfileCardCommentIndexMenu CreateBind(ProcInst super, ProfileCardMessageSelectMenuContent menuContent, ProfileCard myProfileCardTemp, int initialIndex, ProfileCardCommentIndexMenu.DecideEventHandler decideEventHandler, ProfileCardCommentIndexMenu.DisposeEventHandler disposeEventHandler) { }

	// RVA: 0x280ABA0 Offset: 0x280ACA1 VA: 0x280ABA0
	private static List<BasicMenuItem> CreateMenuItem(ProfileCard profileCard, ProfileCardCommentIndexMenu.DecideEventHandler decideEventHandler) { }

	// RVA: 0x280AD50 Offset: 0x280AE51 VA: 0x280AD50
	private void .ctor(List<BasicMenuItem> menuItemList, BasicMenuContent menuContent, int initialIndex, ProfileCardCommentIndexMenu.DecideEventHandler decideEventHandler, ProfileCardCommentIndexMenu.DisposeEventHandler disposeEventHandler) { }

	// RVA: 0x280B040 Offset: 0x280B141 VA: 0x280B040 Slot: 30
	public override string GetName() { }

	// RVA: 0x280B090 Offset: 0x280B191 VA: 0x280B090
	public void SetMenuItemMid(int menuItemIndex, string mid) { }

	// RVA: 0x280AEA0 Offset: 0x280AFA1 VA: 0x280AEA0
	private void UpdateContent() { }

	// RVA: 0x280B2D0 Offset: 0x280B3D1 VA: 0x280B2D0 Slot: 51
	protected override BasicMenu.Result BCall() { }

	// RVA: 0x280B300 Offset: 0x280B401 VA: 0x280B300 Slot: 10
	protected override void OnDispose() { }
}

