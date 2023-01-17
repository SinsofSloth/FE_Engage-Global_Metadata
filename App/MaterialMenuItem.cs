// Namespace: App
public class MaterialMenuItem : BasicMenuItem // TypeDefIndex: 11042
{
	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x2962E0 Offset: 0x2963E1 VA: 0x2962E0
	private ItemRefineExchangeData <m_ItemRefineExchangeData>k__BackingField; // 0x68
	private MaterialMenuItem.SelectEventHandler m_SelectEventHandler; // 0x70
	private MaterialMenuItem.DecideEventHandler m_DecideEventHandler; // 0x78

	// Properties
	public ItemRefineExchangeData m_ItemRefineExchangeData { get; set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x2C30D0 Offset: 0x2C31D1 VA: 0x2C30D0
	// RVA: 0x285E520 Offset: 0x285E621 VA: 0x285E520
	public ItemRefineExchangeData get_m_ItemRefineExchangeData() { }

	[CompilerGeneratedAttribute] // RVA: 0x2C30E0 Offset: 0x2C31E1 VA: 0x2C30E0
	// RVA: 0x285E530 Offset: 0x285E631 VA: 0x285E530
	private void set_m_ItemRefineExchangeData(ItemRefineExchangeData value) { }

	// RVA: 0x285E540 Offset: 0x285E641 VA: 0x285E540
	public void .ctor(ItemRefineExchangeData itemRefineExchangeData, MaterialMenuItem.SelectEventHandler selectEventHandler, MaterialMenuItem.DecideEventHandler decideEventHandler) { }

	// RVA: 0x285E5B0 Offset: 0x285E6B1 VA: 0x285E5B0 Slot: 4
	public override string GetName() { }

	// RVA: 0x285E5C0 Offset: 0x285E6C1 VA: 0x285E5C0
	public void SetSelectEventHandler(MaterialMenuItem.SelectEventHandler selectEventHandler) { }

	// RVA: 0x285E5D0 Offset: 0x285E6D1 VA: 0x285E5D0 Slot: 12
	public override void OnSelect() { }

	// RVA: 0x285E620 Offset: 0x285E721 VA: 0x285E620 Slot: 18
	public override BasicMenu.Result ACall() { }
}

