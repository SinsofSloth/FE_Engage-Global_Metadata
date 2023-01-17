// Namespace: App
public class SynthesisRingBaseRingMenu : BasicMenu // TypeDefIndex: 11230
{
	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x2970E0 Offset: 0x2971E1 VA: 0x2970E0
	private List<GodUnit> <m_GodUnitList>k__BackingField; // 0xC8
	[CompilerGeneratedAttribute] // RVA: 0x2970F0 Offset: 0x2971F1 VA: 0x2970F0
	private int <m_GodUnitIndex>k__BackingField; // 0xD0
	[CompilerGeneratedAttribute] // RVA: 0x297100 Offset: 0x297201 VA: 0x297100
	private GodUnit <m_GodUnit>k__BackingField; // 0xD8
	private BasicMenuSelect[] m_Selects; // 0xE0
	private SynthesisRingBaseRingMenu.CloseEventHandler m_CloseEventHandler; // 0xE8
	private RingMenuItem.SelectEventHandler m_SelectEventHandler; // 0xF0
	private RingMenuItem.DecideEventHandler m_DecideEventHandler; // 0xF8

	// Properties
	public List<GodUnit> m_GodUnitList { get; set; }
	public int m_GodUnitIndex { get; set; }
	public GodUnit m_GodUnit { get; set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x2C3EC0 Offset: 0x2C3FC1 VA: 0x2C3EC0
	// RVA: 0x292BF80 Offset: 0x292C081 VA: 0x292BF80
	public List<GodUnit> get_m_GodUnitList() { }

	[CompilerGeneratedAttribute] // RVA: 0x2C3ED0 Offset: 0x2C3FD1 VA: 0x2C3ED0
	// RVA: 0x292BF90 Offset: 0x292C091 VA: 0x292BF90
	private void set_m_GodUnitList(List<GodUnit> value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2C3EE0 Offset: 0x2C3FE1 VA: 0x2C3EE0
	// RVA: 0x292BFA0 Offset: 0x292C0A1 VA: 0x292BFA0
	public int get_m_GodUnitIndex() { }

	[CompilerGeneratedAttribute] // RVA: 0x2C3EF0 Offset: 0x2C3FF1 VA: 0x2C3EF0
	// RVA: 0x292BFB0 Offset: 0x292C0B1 VA: 0x292BFB0
	private void set_m_GodUnitIndex(int value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2C3F00 Offset: 0x2C4001 VA: 0x2C3F00
	// RVA: 0x292BFC0 Offset: 0x292C0C1 VA: 0x292BFC0
	public GodUnit get_m_GodUnit() { }

	[CompilerGeneratedAttribute] // RVA: 0x2C3F10 Offset: 0x2C4011 VA: 0x2C3F10
	// RVA: 0x292BFD0 Offset: 0x292C0D1 VA: 0x292BFD0
	private void set_m_GodUnit(GodUnit value) { }

	// RVA: 0x292BFE0 Offset: 0x292C0E1 VA: 0x292BFE0
	public static SynthesisRingBaseRingMenu CreateBind(ProcInst super, GameObject menuObject, int initialGodUnitIndex, BasicMenuSelect initialMenuSelect, RingMenuItem.SelectEventHandler selectEventHandler, RingMenuItem.DecideEventHandler decideEventHandler, SynthesisRingBaseRingMenu.CloseEventHandler requestCloseEventHandler) { }

	// RVA: 0x292C500 Offset: 0x292C601 VA: 0x292C500
	public static List<BasicMenuItem> CreateMenuItemList(string gid, RingMenuItem.SelectEventHandler selectEventHandler, RingMenuItem.DecideEventHandler decideEventHandler) { }

	// RVA: 0x292C980 Offset: 0x292CA81 VA: 0x292C980
	protected void .ctor(List<BasicMenuItem> menuItemList, SynthesisRingBaseRingMenuContent menuContent, List<GodUnit> godUnitList, int initialGodUnitIndex, RingMenuItem.SelectEventHandler selectEventHandler, RingMenuItem.DecideEventHandler decideEventHandler, SynthesisRingBaseRingMenu.CloseEventHandler requestCloseEventHandler) { }

	// RVA: 0x292CBA0 Offset: 0x292CCA1 VA: 0x292CBA0
	public void RebuildMenu() { }

	// RVA: 0x292CC30 Offset: 0x292CD31 VA: 0x292CC30
	private void RebuildMenuItem() { }

	// RVA: 0x292CDB0 Offset: 0x292CEB1 VA: 0x292CDB0 Slot: 30
	public override string GetName() { }

	// RVA: 0x292CE00 Offset: 0x292CF01 VA: 0x292CE00
	public void EnableMenu() { }

	// RVA: 0x292CE70 Offset: 0x292CF71 VA: 0x292CE70
	public void DisableMenu() { }

	// RVA: 0x292CD40 Offset: 0x292CE41 VA: 0x292CD40
	private BasicMenuSelect GetSelect() { }

	// RVA: 0x292CEE0 Offset: 0x292CFE1 VA: 0x292CEE0 Slot: 42
	protected override void KeyLeft(bool isTrigger) { }

	// RVA: 0x292D090 Offset: 0x292D191 VA: 0x292D090 Slot: 43
	protected override void KeyRight(bool isTrigger) { }

	// RVA: 0x292D250 Offset: 0x292D351 VA: 0x292D250 Slot: 51
	protected override BasicMenu.Result BCall() { }
}

