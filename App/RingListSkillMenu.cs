// Namespace: App
public class RingListSkillMenu // TypeDefIndex: 12630
{
	// Fields
	private RingListSkillMenu.Menu m_Menu; // 0x10
	private BasicMenuContent m_menuContent; // 0x18
	[CompilerGeneratedAttribute] // RVA: 0x29B3E0 Offset: 0x29B4E1 VA: 0x29B3E0
	private readonly GameObject <RootObject>k__BackingField; // 0x20
	[CompilerGeneratedAttribute] // RVA: 0x29B3F0 Offset: 0x29B4F1 VA: 0x29B3F0
	private RingListSkillMenu.ItemHelpWindow <ItemHelpWdw>k__BackingField; // 0x28
	[CompilerGeneratedAttribute] // RVA: 0x29B400 Offset: 0x29B501 VA: 0x29B400
	private RingListSkillMenu.SkillHelpWindow <SkillHelpWdw>k__BackingField; // 0x30
	[CompilerGeneratedAttribute] // RVA: 0x29B410 Offset: 0x29B511 VA: 0x29B410
	private bool <IsEnableGotIcon>k__BackingField; // 0x38
	[CompilerGeneratedAttribute] // RVA: 0x29B420 Offset: 0x29B521 VA: 0x29B420
	private bool <IsEnableUnitGotIcon>k__BackingField; // 0x39
	[CompilerGeneratedAttribute] // RVA: 0x29B430 Offset: 0x29B531 VA: 0x29B430
	private int <FromLv>k__BackingField; // 0x3C

	// Properties
	public GameObject RootObject { get; }
	public RingListSkillMenu.ItemHelpWindow ItemHelpWdw { get; set; }
	public RingListSkillMenu.SkillHelpWindow SkillHelpWdw { get; set; }
	public bool IsEnableGotIcon { get; set; }
	public bool IsEnableUnitGotIcon { get; set; }
	public int FromLv { get; set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x2C9C40 Offset: 0x2C9D41 VA: 0x2C9C40
	// RVA: 0x2690A30 Offset: 0x2690B31 VA: 0x2690A30
	public GameObject get_RootObject() { }

	[CompilerGeneratedAttribute] // RVA: 0x2C9C50 Offset: 0x2C9D51 VA: 0x2C9C50
	// RVA: 0x2690A40 Offset: 0x2690B41 VA: 0x2690A40
	public RingListSkillMenu.ItemHelpWindow get_ItemHelpWdw() { }

	[CompilerGeneratedAttribute] // RVA: 0x2C9C60 Offset: 0x2C9D61 VA: 0x2C9C60
	// RVA: 0x2690A50 Offset: 0x2690B51 VA: 0x2690A50
	public void set_ItemHelpWdw(RingListSkillMenu.ItemHelpWindow value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2C9C70 Offset: 0x2C9D71 VA: 0x2C9C70
	// RVA: 0x2690A60 Offset: 0x2690B61 VA: 0x2690A60
	public RingListSkillMenu.SkillHelpWindow get_SkillHelpWdw() { }

	[CompilerGeneratedAttribute] // RVA: 0x2C9C80 Offset: 0x2C9D81 VA: 0x2C9C80
	// RVA: 0x2690A70 Offset: 0x2690B71 VA: 0x2690A70
	public void set_SkillHelpWdw(RingListSkillMenu.SkillHelpWindow value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2C9C90 Offset: 0x2C9D91 VA: 0x2C9C90
	// RVA: 0x2690A80 Offset: 0x2690B81 VA: 0x2690A80
	public bool get_IsEnableGotIcon() { }

	[CompilerGeneratedAttribute] // RVA: 0x2C9CA0 Offset: 0x2C9DA1 VA: 0x2C9CA0
	// RVA: 0x2690A90 Offset: 0x2690B91 VA: 0x2690A90
	public void set_IsEnableGotIcon(bool value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2C9CB0 Offset: 0x2C9DB1 VA: 0x2C9CB0
	// RVA: 0x2690AA0 Offset: 0x2690BA1 VA: 0x2690AA0
	public bool get_IsEnableUnitGotIcon() { }

	[CompilerGeneratedAttribute] // RVA: 0x2C9CC0 Offset: 0x2C9DC1 VA: 0x2C9CC0
	// RVA: 0x2690AB0 Offset: 0x2690BB1 VA: 0x2690AB0
	public void set_IsEnableUnitGotIcon(bool value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2C9CD0 Offset: 0x2C9DD1 VA: 0x2C9CD0
	// RVA: 0x2690AC0 Offset: 0x2690BC1 VA: 0x2690AC0
	public int get_FromLv() { }

	[CompilerGeneratedAttribute] // RVA: 0x2C9CE0 Offset: 0x2C9DE1 VA: 0x2C9CE0
	// RVA: 0x2690AD0 Offset: 0x2690BD1 VA: 0x2690AD0
	public void set_FromLv(int value) { }

	// RVA: 0x2690AE0 Offset: 0x2690BE1 VA: 0x2690AE0
	public RingListSkillMenu.Menu GetMenu() { }

	// RVA: 0x268E5B0 Offset: 0x268E6B1 VA: 0x268E5B0
	public void .ctor(GameObject rootObject) { }

	// RVA: 0x2690AF0 Offset: 0x2690BF1 VA: 0x2690AF0
	public static void CreateGodGrowthMenuItem(GodData godData, RingListSkillMenu root, int fromLv, int toLv, int maxBondLevel, out List<BasicMenuItem> outList, bool isRingSelectMenu = False) { }

	// RVA: 0x268E9D0 Offset: 0x268EAD1 VA: 0x268E9D0
	public bool CreateMenu(ProcInst super, bool isBindParent, bool isEnableGotIcon, bool isEnableUnitGotIcon, RingListSequence.GodPageData godPageData, int fromLv, RingListSkillMenu.CancelEventHandler cancel, bool isRingSelectMenu = False) { }

	// RVA: 0x268E970 Offset: 0x268EA71 VA: 0x268E970
	public void Delete() { }

	// RVA: 0x268FCE0 Offset: 0x268FDE1 VA: 0x268FCE0
	public void IncSuspend() { }

	// RVA: 0x2691A40 Offset: 0x2691B41 VA: 0x2691A40
	public void DecSuspend() { }
}

