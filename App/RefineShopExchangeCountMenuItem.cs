// Namespace: App
public class RefineShopExchangeCountMenuItem : BasicMenuItem // TypeDefIndex: 11125
{
	// Fields
	private bool m_AttributeEnable; // 0x64
	private RefineShopExchangeCountMenuItem.SelectEventHandler m_SelectEventHandler; // 0x68
	private RefineShopExchangeCountMenuItem.DecideEventHandler m_DecideEventHandler; // 0x70

	// Methods

	// RVA: 0x2C65AC0 Offset: 0x2C65BC1 VA: 0x2C65AC0
	public void .ctor(RefineShopExchangeCountMenuItem.SelectEventHandler selectEventHandler, RefineShopExchangeCountMenuItem.DecideEventHandler decideEventHandler) { }

	// RVA: 0x2C67960 Offset: 0x2C67A61 VA: 0x2C67960 Slot: 4
	public override string GetName() { }

	// RVA: 0x2C679E0 Offset: 0x2C67AE1 VA: 0x2C679E0 Slot: 8
	public override BasicMenuItem.Attribute BuildAttribute() { }

	// RVA: 0x2C67A00 Offset: 0x2C67B01 VA: 0x2C67A00 Slot: 10
	public override void OnBuild() { }

	// RVA: 0x2C67A10 Offset: 0x2C67B11 VA: 0x2C67A10
	public void SetColor() { }

	// RVA: 0x2C660A0 Offset: 0x2C661A1 VA: 0x2C660A0
	public void SetAttributeEnable(bool enabled) { }

	// RVA: 0x2C67B10 Offset: 0x2C67C11 VA: 0x2C67B10 Slot: 18
	public override BasicMenu.Result ACall() { }
}

