// Namespace: App
public class UnitItemMenu : BasicMenu // TypeDefIndex: 12680
{
	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x29B4F0 Offset: 0x29B5F1 VA: 0x29B4F0
	private Unit <m_Unit>k__BackingField; // 0xC8
	private UnitItemMenu.SelectEventHandler m_SelectEventHandler; // 0xD0
	private UnitItemMenu.DecideEventHandler m_DecideEventHandler; // 0xD8
	private UnitItemMenu.RequestCloseEventHandler m_RequestCloseEventHandler; // 0xE0

	// Properties
	public Unit m_Unit { get; set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x2C9DB0 Offset: 0x2C9EB1 VA: 0x2C9DB0
	// RVA: 0x2441E80 Offset: 0x2441F81 VA: 0x2441E80
	public Unit get_m_Unit() { }

	[CompilerGeneratedAttribute] // RVA: 0x2C9DC0 Offset: 0x2C9EC1 VA: 0x2C9DC0
	// RVA: 0x2441E90 Offset: 0x2441F91 VA: 0x2441E90
	private void set_m_Unit(Unit value) { }

	// RVA: 0x2441EA0 Offset: 0x2441FA1 VA: 0x2441EA0
	public static UnitItemMenu CreateBind(ProcInst super, UnitItemMenuContent menuContent, Unit unit, UnitItemMenu.SelectEventHandler selectEventHandler, UnitItemMenu.DecideEventHandler decideEventHandler, UnitItemMenu.RequestCloseEventHandler requestCloseEventHandler) { }

	// RVA: 0x2441FD0 Offset: 0x24420D1 VA: 0x2441FD0
	public static List<BasicMenuItem> CreateMenuItem(Unit unit, UnitItemMenu.SelectEventHandler selectEventHandler, UnitItemMenu.DecideEventHandler decideEventHandler, UnitItemMenu.RequestCloseEventHandler requestCloseEventHandler) { }

	// RVA: 0x2442310 Offset: 0x2442411 VA: 0x2442310
	protected void .ctor(List<BasicMenuItem> menuItemList, UnitItemMenuContent menuContent, Unit unit, UnitItemMenu.SelectEventHandler selectEventHandler, UnitItemMenu.DecideEventHandler decideEventHandler, UnitItemMenu.RequestCloseEventHandler requestCloseEventHandler) { }

	// RVA: 0x2442390 Offset: 0x2442491 VA: 0x2442390
	public void RebuildMenu(Unit unit) { }

	// RVA: 0x2442490 Offset: 0x2442591 VA: 0x2442490 Slot: 30
	public override string GetName() { }

	// RVA: 0x24424E0 Offset: 0x24425E1 VA: 0x24424E0
	public void EnableMenu() { }

	// RVA: 0x2442550 Offset: 0x2442651 VA: 0x2442550
	public void DisableMenu() { }

	// RVA: 0x24425C0 Offset: 0x24426C1 VA: 0x24425C0
	public void Show() { }

	// RVA: 0x2442670 Offset: 0x2442771 VA: 0x2442670
	public void Hide() { }
}

