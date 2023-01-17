// Namespace: App
public class AccessoryShopBuyMenuItem : BasicMenuItem // TypeDefIndex: 10889
{
	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x295E10 Offset: 0x295F11 VA: 0x295E10
	private AccessoryData <m_AccessoryData>k__BackingField; // 0x68
	[CompilerGeneratedAttribute] // RVA: 0x295E20 Offset: 0x295F21 VA: 0x295E20
	private bool <m_NewArrival>k__BackingField; // 0x70
	private AccessoryShopBuyMenu.SelectEventHandler m_SelectEventHandler; // 0x78
	private AccessoryShopBuyMenu.DecideEventHandler m_DecideEventHandler; // 0x80

	// Properties
	public AccessoryData m_AccessoryData { get; set; }
	public bool m_NewArrival { get; set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x2C28E0 Offset: 0x2C29E1 VA: 0x2C28E0
	// RVA: 0x2B19050 Offset: 0x2B19151 VA: 0x2B19050
	public AccessoryData get_m_AccessoryData() { }

	[CompilerGeneratedAttribute] // RVA: 0x2C28F0 Offset: 0x2C29F1 VA: 0x2C28F0
	// RVA: 0x2B19060 Offset: 0x2B19161 VA: 0x2B19060
	private void set_m_AccessoryData(AccessoryData value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2C2900 Offset: 0x2C2A01 VA: 0x2C2900
	// RVA: 0x2B19070 Offset: 0x2B19171 VA: 0x2B19070
	public bool get_m_NewArrival() { }

	[CompilerGeneratedAttribute] // RVA: 0x2C2910 Offset: 0x2C2A11 VA: 0x2C2910
	// RVA: 0x2B19080 Offset: 0x2B19181 VA: 0x2B19080
	private void set_m_NewArrival(bool value) { }

	// RVA: 0x2B17D80 Offset: 0x2B17E81 VA: 0x2B17D80
	public void .ctor(AccessoryShopContent accessoryShopContent, AccessoryShopBuyMenu.SelectEventHandler selectEventHandler, AccessoryShopBuyMenu.DecideEventHandler decideEventHandler) { }

	// RVA: 0x2B19090 Offset: 0x2B19191 VA: 0x2B19090 Slot: 4
	public override string GetName() { }

	// RVA: 0x2B190A0 Offset: 0x2B191A1 VA: 0x2B190A0 Slot: 8
	public override BasicMenuItem.Attribute BuildAttribute() { }

	// RVA: 0x2B19210 Offset: 0x2B19311 VA: 0x2B19210 Slot: 10
	public override void OnBuild() { }

	// RVA: 0x2B19320 Offset: 0x2B19421 VA: 0x2B19320 Slot: 11
	public override void OnBuildMenuItemContent() { }

	// RVA: 0x2B19220 Offset: 0x2B19321 VA: 0x2B19220
	public void SetInitialColor() { }

	// RVA: 0x2B19330 Offset: 0x2B19431 VA: 0x2B19330 Slot: 12
	public override void OnSelect() { }

	// RVA: 0x2B19370 Offset: 0x2B19471 VA: 0x2B19370 Slot: 18
	public override BasicMenu.Result ACall() { }

	// RVA: 0x2B193C0 Offset: 0x2B194C1 VA: 0x2B193C0
	public bool IsEnoughIronToBeBuyed() { }

	// RVA: 0x2B19460 Offset: 0x2B19561 VA: 0x2B19460
	public bool IsEnoughSteelToBeBuyed() { }

	// RVA: 0x2B19500 Offset: 0x2B19601 VA: 0x2B19500
	public bool IsEnoughSilverToBeBuyed() { }

	// RVA: 0x2B195A0 Offset: 0x2B196A1 VA: 0x2B195A0
	public bool IsEnoughMoneyToBeBuyed() { }
}

