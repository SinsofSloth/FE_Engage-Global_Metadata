// Namespace: App
internal class RelayMapMenu : BasicMenu // TypeDefIndex: 12877
{
	// Fields
	private RelayMapMenu.DecideEventHandler m_DecideEventHandler; // 0xC8
	private RelayMapMenu.RequestCloseEventHandler m_RequestCloseEventHandler; // 0xD0

	// Methods

	// RVA: 0x24B7920 Offset: 0x24B7A21 VA: 0x24B7920
	public static RelayMapMenu CreateBind(ProcInst super, GameObject rootObject, RelayMapMenu.SelectEventHandler selectEventHandler, RelayMapMenu.DecideEventHandler decideEventHandler, RelayMapMenu.RequestCloseEventHandler requestCloseEventHandler) { }

	// RVA: 0x24B7CD0 Offset: 0x24B7DD1 VA: 0x24B7CD0
	protected void .ctor(List<BasicMenuItem> menuItemList, RelayMapMenuContent menuContent, RelayMapMenu.DecideEventHandler decideEventHandler, RelayMapMenu.RequestCloseEventHandler requestCloseEventHandler) { }

	// RVA: 0x24B7D20 Offset: 0x24B7E21 VA: 0x24B7D20 Slot: 30
	public override string GetName() { }

	// RVA: 0x24B7D70 Offset: 0x24B7E71 VA: 0x24B7D70 Slot: 63
	protected override string GetTutorial() { }

	// RVA: 0x24B7DC0 Offset: 0x24B7EC1 VA: 0x24B7DC0 Slot: 50
	protected override BasicMenu.Result ACall() { }

	// RVA: 0x24B7E00 Offset: 0x24B7F01 VA: 0x24B7E00 Slot: 51
	protected override BasicMenu.Result BCall() { }
}

