// Namespace: App
public class ShopSellEmptyMenuItem : BasicMenuItem // TypeDefIndex: 11199
{
	// Fields
	private ShopSellMenu.SelectEventHandler m_SelectEventHandler; // 0x68
	private ShopSellMenu.ChangeUnitToPrevEventHandler m_ChangeUnitToPrevEventHandler; // 0x70
	private ShopSellMenu.ChangeUnitToNextEventHandler m_ChangeUnitToNextEventHandler; // 0x78

	// Methods

	// RVA: 0x2335F30 Offset: 0x2336031 VA: 0x2335F30
	public void .ctor(ShopSellMenu.SelectEventHandler selectEventHandler, ShopSellMenu.ChangeUnitToPrevEventHandler changeUnitToPrevEventHandler, ShopSellMenu.ChangeUnitToNextEventHandler changeUnitToNextEventHandler) { }

	// RVA: 0x2336010 Offset: 0x2336111 VA: 0x2336010 Slot: 8
	public override BasicMenuItem.Attribute BuildAttribute() { }

	// RVA: 0x2336020 Offset: 0x2336121 VA: 0x2336020 Slot: 12
	public override void OnSelect() { }

	// RVA: 0x2336060 Offset: 0x2336161 VA: 0x2336060 Slot: 18
	public override BasicMenu.Result ACall() { }

	// RVA: 0x2336070 Offset: 0x2336171 VA: 0x2336070 Slot: 26
	public override BasicMenu.Result CustomCall() { }
}

