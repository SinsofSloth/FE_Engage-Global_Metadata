// Namespace: App
public class ShopUnitSelectMenu : BasicMenu // TypeDefIndex: 11213
{
	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x296F80 Offset: 0x297081 VA: 0x296F80
	private ShopUnitSelectMenu.HelpEventHandler <m_HelpEventHandler>k__BackingField; // 0xC8
	private GameObject m_GameObject; // 0xD0
	private bool m_ShowGodRingIcon; // 0xD8

	// Properties
	public ShopUnitSelectMenu.HelpEventHandler m_HelpEventHandler { get; set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x2C3D70 Offset: 0x2C3E71 VA: 0x2C3D70
	// RVA: 0x233F300 Offset: 0x233F401 VA: 0x233F300
	public ShopUnitSelectMenu.HelpEventHandler get_m_HelpEventHandler() { }

	[CompilerGeneratedAttribute] // RVA: 0x2C3D80 Offset: 0x2C3E81 VA: 0x2C3D80
	// RVA: 0x233F310 Offset: 0x233F411 VA: 0x233F310
	public void set_m_HelpEventHandler(ShopUnitSelectMenu.HelpEventHandler value) { }

	// RVA: 0x233F320 Offset: 0x233F421 VA: 0x233F320
	public static void CreateBind(ProcInst super, GameObject gameObject, Unit defaultUnit, int defaultScrollIndex, bool addingTransporter, ShopUnitSelectMenu.DecideEventHandler decideEventHandler, ShopUnitSelectMenu.SelectEventHandler selectEventHandler, ShopUnitSelectMenu.HelpEventHandler helpEventHandler, bool showGodRingIcon) { }

	// RVA: 0x233F6D0 Offset: 0x233F7D1 VA: 0x233F6D0
	protected void .ctor(List<BasicMenuItem> menuItemList, ShopUnitSelectMenuContent menuContent, GameObject menuObject, int defaultMenuItemIndex, int defaultScrollIndex, ShopUnitSelectMenu.HelpEventHandler helpEventHandler, bool showGodRingIcon) { }

	// RVA: 0x233F7C0 Offset: 0x233F8C1 VA: 0x233F7C0 Slot: 30
	public override string GetName() { }

	// RVA: 0x233F810 Offset: 0x233F911 VA: 0x233F810 Slot: 52
	protected override BasicMenu.Result XCall() { }

	// RVA: 0x233F840 Offset: 0x233F941 VA: 0x233F840
	public bool IsShowGodRingIcon() { }
}

