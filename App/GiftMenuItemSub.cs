// Namespace: App
internal class GiftMenuItemSub : BasicMenuItem // TypeDefIndex: 10637
{
	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x293050 Offset: 0x293151 VA: 0x293050
	private bool <IsActive>k__BackingField; // 0x64
	[CompilerGeneratedAttribute] // RVA: 0x293060 Offset: 0x293161 VA: 0x293060
	private bool <IsActiveSelect>k__BackingField; // 0x65
	private ItemData m_Item; // 0x68
	private Unit m_Unit; // 0x70
	private int m_Value; // 0x78

	// Properties
	public bool IsActive { get; set; }
	public bool IsActiveSelect { get; set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x2BFF90 Offset: 0x2C0091 VA: 0x2BFF90
	// RVA: 0x28E4980 Offset: 0x28E4A81 VA: 0x28E4980
	public bool get_IsActive() { }

	[CompilerGeneratedAttribute] // RVA: 0x2BFFA0 Offset: 0x2C00A1 VA: 0x2BFFA0
	// RVA: 0x28E4990 Offset: 0x28E4A91 VA: 0x28E4990
	public void set_IsActive(bool value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2BFFB0 Offset: 0x2C00B1 VA: 0x2BFFB0
	// RVA: 0x28E49A0 Offset: 0x28E4AA1 VA: 0x28E49A0
	public bool get_IsActiveSelect() { }

	[CompilerGeneratedAttribute] // RVA: 0x2BFFC0 Offset: 0x2C00C1 VA: 0x2BFFC0
	// RVA: 0x28E49B0 Offset: 0x28E4AB1 VA: 0x28E49B0
	public void set_IsActiveSelect(bool value) { }

	// RVA: 0x28E4620 Offset: 0x28E4721 VA: 0x28E4620
	public void .ctor(ItemData item, Unit unit) { }

	// RVA: 0x28E49C0 Offset: 0x28E4AC1 VA: 0x28E49C0 Slot: 4
	public override string GetName() { }

	// RVA: 0x28E3D40 Offset: 0x28E3E41 VA: 0x28E3D40
	public string GetCountText() { }

	// RVA: 0x28E4A40 Offset: 0x28E4B41 VA: 0x28E4A40 Slot: 8
	public override BasicMenuItem.Attribute BuildAttribute() { }

	// RVA: 0x28E4A50 Offset: 0x28E4B51 VA: 0x28E4A50 Slot: 12
	public override void OnSelect() { }

	// RVA: 0x28E4B30 Offset: 0x28E4C31 VA: 0x28E4B30 Slot: 18
	public override BasicMenu.Result ACall() { }

	// RVA: 0x28E4C20 Offset: 0x28E4D21 VA: 0x28E4C20 Slot: 19
	public override BasicMenu.Result BCall() { }
}

