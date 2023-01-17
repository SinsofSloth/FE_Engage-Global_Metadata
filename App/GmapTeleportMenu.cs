// Namespace: App
public class GmapTeleportMenu : BasicMenu // TypeDefIndex: 10365
{
	// Fields
	private SystemScrollMenuContent m_Content; // 0xC8
	private GmapMapInfoContent m_GmapInfo; // 0xD0
	private GmapTeleportMenu.DecideEventHandler m_DecideCallback; // 0xD8
	private Action m_GoToSolanelCallback; // 0xE0
	private Action m_CloseMapAndBarFunc; // 0xE8

	// Methods

	// RVA: 0x2CF5A90 Offset: 0x2CF5B91 VA: 0x2CF5A90
	public static void CreateBind(ProcInst super, GmapMapInfoContent gmapInfo, GmapTeleportMenu.DecideEventHandler decideEventHandler, Action gotoSolanelCallback, Action closeMapAndBarFunc) { }

	// RVA: 0x2CF5BF0 Offset: 0x2CF5CF1 VA: 0x2CF5BF0
	private static void AddMenuItems(List<BasicMenuItem> list, Action closeMapAndBarFunc) { }

	// RVA: 0x2CF5DC0 Offset: 0x2CF5EC1 VA: 0x2CF5DC0
	protected void .ctor(List<BasicMenuItem> menuItemList, BasicMenuContent menuContent, GmapMapInfoContent gmapMapInfo, GmapTeleportMenu.DecideEventHandler decideEventHandler, Action gotoSolanelCallback, Action closeMapAndBarFunc) { }

	// RVA: 0x2CF5ED0 Offset: 0x2CF5FD1 VA: 0x2CF5ED0 Slot: 30
	public override string GetName() { }

	// RVA: 0x2CF5F20 Offset: 0x2CF6021 VA: 0x2CF5F20
	public SystemScrollMenuContent GetMenuContent() { }

	// RVA: 0x2CF5F30 Offset: 0x2CF6031 VA: 0x2CF5F30 Slot: 51
	protected override BasicMenu.Result BCall() { }
}

