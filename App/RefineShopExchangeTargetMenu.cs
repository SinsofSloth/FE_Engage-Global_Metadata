// Namespace: App
public class RefineShopExchangeTargetMenu : BasicMenu // TypeDefIndex: 11140
{
	// Fields
	public RefineShopExchangeTargetMenu.CloseEventHandler m_CloseEventHandler; // 0xC8
	[CompilerGeneratedAttribute] // RVA: 0x296B40 Offset: 0x296C41 VA: 0x296B40
	private bool <m_MenuItemIsEnoughMaterial>k__BackingField; // 0xD0
	[CompilerGeneratedAttribute] // RVA: 0x296B50 Offset: 0x296C51 VA: 0x296B50
	private bool <m_MenuItemIsMaxMaterial>k__BackingField; // 0xD1

	// Properties
	public bool m_MenuItemIsEnoughMaterial { get; set; }
	public bool m_MenuItemIsMaxMaterial { get; set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x2C38A0 Offset: 0x2C39A1 VA: 0x2C38A0
	// RVA: 0x2C6B6D0 Offset: 0x2C6B7D1 VA: 0x2C6B6D0
	public bool get_m_MenuItemIsEnoughMaterial() { }

	[CompilerGeneratedAttribute] // RVA: 0x2C38B0 Offset: 0x2C39B1 VA: 0x2C38B0
	// RVA: 0x2C6B6E0 Offset: 0x2C6B7E1 VA: 0x2C6B6E0
	private void set_m_MenuItemIsEnoughMaterial(bool value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2C38C0 Offset: 0x2C39C1 VA: 0x2C38C0
	// RVA: 0x2C6B6F0 Offset: 0x2C6B7F1 VA: 0x2C6B6F0
	public bool get_m_MenuItemIsMaxMaterial() { }

	[CompilerGeneratedAttribute] // RVA: 0x2C38D0 Offset: 0x2C39D1 VA: 0x2C38D0
	// RVA: 0x2C6B700 Offset: 0x2C6B801 VA: 0x2C6B700
	private void set_m_MenuItemIsMaxMaterial(bool value) { }

	// RVA: 0x2C68980 Offset: 0x2C68A81 VA: 0x2C68980
	public static RefineShopExchangeTargetMenu CreateBind(ProcInst super, RefineShopExchangeTargetMenuContent menuContent, string initialTargetMaterialId, MaterialMenuItem.SelectEventHandler selectEventHandler, MaterialMenuItem.DecideEventHandler decideEventHandler, RefineShopExchangeTargetMenu.CloseEventHandler closeEventHandler) { }

	// RVA: 0x2C6B8D0 Offset: 0x2C6B9D1 VA: 0x2C6B8D0
	private void .ctor(List<BasicMenuItem> menuItemList, RefineShopExchangeTargetMenuContent menuContent, int initialSelectIndex, RefineShopExchangeTargetMenu.CloseEventHandler closeEventHandler) { }

	// RVA: 0x2C6BA20 Offset: 0x2C6BB21 VA: 0x2C6BA20 Slot: 30
	public override string GetName() { }

	// RVA: 0x2C6BA70 Offset: 0x2C6BB71 VA: 0x2C6BA70
	public void UpdateContent(bool menuItemIsEnabled) { }

	// RVA: 0x2C6BE30 Offset: 0x2C6BF31 VA: 0x2C6BE30 Slot: 26
	public override void OnClose() { }

	// RVA: 0x2C6BE50 Offset: 0x2C6BF51 VA: 0x2C6BE50 Slot: 10
	protected override void OnDispose() { }
}

