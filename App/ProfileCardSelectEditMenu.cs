// Namespace: App
public class ProfileCardSelectEditMenu : BasicMenu // TypeDefIndex: 11616
{
	// Fields
	private ProfileCardRoot m_ProfileCardRoot; // 0xC8
	private ProfileCardSelectEditMenu.DecideEventHandler m_DecideEventHandler; // 0xD0
	private ProfileCardSelectEditMenu.DisposeEventHandler m_DisposeEventHandler; // 0xD8

	// Methods

	// RVA: 0x281F930 Offset: 0x281FA31 VA: 0x281F930
	public static ProfileCardSelectEditMenu CreateBind(ProcInst super, ProfileCardSelectEditMenuContent menuContent, ProfileCardRoot profileCardRoot, ProfileCardSelectEditMenu.Result2 initialSelectResult2, ProfileCardSelectEditMenu.DecideEventHandler decideEventHandler, ProfileCardSelectEditMenu.DisposeEventHandler disposeEventHandler) { }

	// RVA: 0x281FCF0 Offset: 0x281FDF1 VA: 0x281FCF0
	private void .ctor(List<BasicMenuItem> menuItemList, BasicMenuContent menuContent, ProfileCardRoot profileCardRoot, int initialSelectIndex, ProfileCardSelectEditMenu.DecideEventHandler decideEventHandler, ProfileCardSelectEditMenu.DisposeEventHandler disposeEventHandler) { }

	// RVA: 0x281FD90 Offset: 0x281FE91 VA: 0x281FD90 Slot: 30
	public override string GetName() { }

	// RVA: 0x281FDE0 Offset: 0x281FEE1 VA: 0x281FDE0
	public ProfileCardRoot GetProfileCardRoot() { }

	// RVA: 0x281FDF0 Offset: 0x281FEF1 VA: 0x281FDF0 Slot: 51
	protected override BasicMenu.Result BCall() { }

	// RVA: 0x281FE20 Offset: 0x281FF21 VA: 0x281FE20 Slot: 26
	public override void OnClose() { }

	// RVA: 0x281FEC0 Offset: 0x281FFC1 VA: 0x281FEC0 Slot: 10
	protected override void OnDispose() { }
}

