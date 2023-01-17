// Namespace: App
internal class MascotFoodSelectMenuItem : BasicMenuItem // TypeDefIndex: 10857
{
	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x295D50 Offset: 0x295E51 VA: 0x295D50
	private bool <IsActive>k__BackingField; // 0x64
	[CompilerGeneratedAttribute] // RVA: 0x295D60 Offset: 0x295E61 VA: 0x295D60
	private bool <IsActiveSelect>k__BackingField; // 0x65
	private FoodstuffData m_foodStuffData; // 0x68

	// Properties
	public bool IsActive { get; set; }
	public bool IsActiveSelect { get; set; }
	public FoodstuffData Data { get; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x2C2670 Offset: 0x2C2771 VA: 0x2C2670
	// RVA: 0x2854B20 Offset: 0x2854C21 VA: 0x2854B20
	public bool get_IsActive() { }

	[CompilerGeneratedAttribute] // RVA: 0x2C2680 Offset: 0x2C2781 VA: 0x2C2680
	// RVA: 0x2854B30 Offset: 0x2854C31 VA: 0x2854B30
	public void set_IsActive(bool value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2C2690 Offset: 0x2C2791 VA: 0x2C2690
	// RVA: 0x2854B40 Offset: 0x2854C41 VA: 0x2854B40
	public bool get_IsActiveSelect() { }

	[CompilerGeneratedAttribute] // RVA: 0x2C26A0 Offset: 0x2C27A1 VA: 0x2C26A0
	// RVA: 0x2854B50 Offset: 0x2854C51 VA: 0x2854B50
	public void set_IsActiveSelect(bool value) { }

	// RVA: 0x2854B60 Offset: 0x2854C61 VA: 0x2854B60
	public FoodstuffData get_Data() { }

	// RVA: 0x28548A0 Offset: 0x28549A1 VA: 0x28548A0
	public void .ctor(FoodstuffData foodStuffData) { }

	// RVA: 0x2854B70 Offset: 0x2854C71 VA: 0x2854B70 Slot: 4
	public override string GetName() { }

	// RVA: 0x28541F0 Offset: 0x28542F1 VA: 0x28541F0
	public string GetCountText() { }

	// RVA: 0x2854C60 Offset: 0x2854D61 VA: 0x2854C60 Slot: 8
	public override BasicMenuItem.Attribute BuildAttribute() { }

	// RVA: 0x2854CA0 Offset: 0x2854DA1 VA: 0x2854CA0 Slot: 12
	public override void OnSelect() { }

	// RVA: 0x2854E40 Offset: 0x2854F41 VA: 0x2854E40 Slot: 18
	public override BasicMenu.Result ACall() { }

	// RVA: 0x2854F60 Offset: 0x2855061 VA: 0x2854F60 Slot: 19
	public override BasicMenu.Result BCall() { }
}

