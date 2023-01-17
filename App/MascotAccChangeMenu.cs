// Namespace: App
public class MascotAccChangeMenu : BasicMenu // TypeDefIndex: 10840
{
	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x295CE0 Offset: 0x295DE1 VA: 0x295CE0
	private MascotAccData.PartsType <CurrentPartsType>k__BackingField; // 0xC4
	private List<BasicMenuSelect> m_MenuSelectList; // 0xC8

	// Properties
	public MascotAccData.PartsType CurrentPartsType { get; set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x2C2530 Offset: 0x2C2631 VA: 0x2C2530
	// RVA: 0x284C4F0 Offset: 0x284C5F1 VA: 0x284C4F0
	public MascotAccData.PartsType get_CurrentPartsType() { }

	[CompilerGeneratedAttribute] // RVA: 0x2C2540 Offset: 0x2C2641 VA: 0x2C2540
	// RVA: 0x284C500 Offset: 0x284C601 VA: 0x284C500
	public void set_CurrentPartsType(MascotAccData.PartsType value) { }

	// RVA: 0x284C510 Offset: 0x284C611 VA: 0x284C510
	public void .ctor(List<BasicMenuItem> menuItemList, BasicMenuContent menuContent) { }

	// RVA: 0x284C7A0 Offset: 0x284C8A1 VA: 0x284C7A0
	public static void CreateBind(ProcInst super, MascotAccData.PartsType type) { }

	// RVA: 0x284C9F0 Offset: 0x284CAF1 VA: 0x284C9F0 Slot: 30
	public override string GetName() { }

	// RVA: 0x284CA40 Offset: 0x284CB41 VA: 0x284CA40 Slot: 26
	public override void OnClose() { }

	// RVA: 0x284C870 Offset: 0x284C971 VA: 0x284C870
	private static List<BasicMenuItem> CreateMenuList(MascotAccData.PartsType type) { }

	// RVA: 0x284C6B0 Offset: 0x284C7B1 VA: 0x284C6B0
	private bool ChangePartsType(int directional, bool isTrigger) { }

	// RVA: 0x284C700 Offset: 0x284C801 VA: 0x284C700
	private void UpdatePartsType() { }

	// RVA: 0x284CCF0 Offset: 0x284CDF1 VA: 0x284CCF0
	public void UpdateEquipAcc(MascotAccChangeMenuItem item) { }

	// RVA: 0x284CF10 Offset: 0x284D011 VA: 0x284CF10
	public void RebuildMenu(MascotAccData.PartsType type) { }

	// RVA: 0x284CFB0 Offset: 0x284D0B1 VA: 0x284CFB0 Slot: 42
	protected override void KeyLeft(bool isTrigger) { }

	// RVA: 0x284D1D0 Offset: 0x284D2D1 VA: 0x284D1D0 Slot: 43
	protected override void KeyRight(bool isTrigger) { }

	// RVA: 0x284D3F0 Offset: 0x284D4F1 VA: 0x284D3F0
	public void SetHelpText(MascotAccData mascotData, AccessoryData accData) { }
}

