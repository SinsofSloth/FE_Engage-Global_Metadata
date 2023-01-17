// Namespace: App
public class RefreshFacilitySelectMenu : BasicMenu // TypeDefIndex: 11692
{
	// Fields
	private static readonly string[] m_FacilityAid; // 0x0
	private RefreshFacilitySelectMenu.DecideEventHandler m_DecideEventHandler; // 0xC8
	private RefreshFacilitySelectMenu.CloseEventHandler m_CloseEventHandler; // 0xD0
	private RefreshFacilitySelectMenu.DisposeEventHandler m_DisposeEventHandler; // 0xD8

	// Methods

	// RVA: 0x252A870 Offset: 0x252A971 VA: 0x252A870
	public static RefreshFacilitySelectMenu CreateBind(ProcInst super, RefreshFacilitySelectMenuContent menuContent, RefreshFacilitySelectMenu.SelectEventHandler selectEventHandler, RefreshFacilitySelectMenu.DecideEventHandler decideEventHandler, RefreshFacilitySelectMenu.CloseEventHandler closeEventHandler, RefreshFacilitySelectMenu.DisposeEventHandler disposeEventHandler) { }

	// RVA: 0x252AA40 Offset: 0x252AB41 VA: 0x252AA40
	private static List<BasicMenuItem> CreateMenuItem(RefreshFacilitySelectMenu.SelectEventHandler selectEventHandler, RefreshFacilitySelectMenu.DecideEventHandler decideEventHandler) { }

	// RVA: 0x252ABD0 Offset: 0x252ACD1 VA: 0x252ABD0
	private void .ctor(List<BasicMenuItem> menuItemList, RefreshFacilitySelectMenuContent menuContent, RefreshFacilitySelectMenu.DecideEventHandler decideEventHandler, RefreshFacilitySelectMenu.CloseEventHandler closeEventHandler, RefreshFacilitySelectMenu.DisposeEventHandler disposeEventHandler) { }

	// RVA: 0x252AD20 Offset: 0x252AE21 VA: 0x252AD20 Slot: 30
	public override string GetName() { }

	// RVA: 0x252AD70 Offset: 0x252AE71 VA: 0x252AD70 Slot: 51
	protected override BasicMenu.Result BCall() { }

	// RVA: 0x252ADA0 Offset: 0x252AEA1 VA: 0x252ADA0 Slot: 10
	protected override void OnDispose() { }

	// RVA: 0x252AE80 Offset: 0x252AF81 VA: 0x252AE80
	private static void .cctor() { }
}

