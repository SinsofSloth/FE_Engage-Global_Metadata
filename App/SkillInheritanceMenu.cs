// Namespace: App
public class SkillInheritanceMenu : BasicMenu // TypeDefIndex: 11223
{
	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x296FA0 Offset: 0x2970A1 VA: 0x296FA0
	private static Unit <m_Unit>k__BackingField; // 0x0
	private static Action<Unit> m_DecideEventHandler; // 0x8
	private List<GodUnit> m_GodListActive; // 0xC8
	private List<BasicMenuSelect> m_MenuSelectList; // 0xD0
	private int m_GodIndex; // 0xD8

	// Properties
	public static Unit m_Unit { get; set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x2C3DB0 Offset: 0x2C3EB1 VA: 0x2C3DB0
	// RVA: 0x27DB430 Offset: 0x27DB531 VA: 0x27DB430
	public static Unit get_m_Unit() { }

	[CompilerGeneratedAttribute] // RVA: 0x2C3DC0 Offset: 0x2C3EC1 VA: 0x2C3DC0
	// RVA: 0x27DB4A0 Offset: 0x27DB5A1 VA: 0x27DB4A0
	private static void set_m_Unit(Unit value) { }

	// RVA: 0x27DB520 Offset: 0x27DB621 VA: 0x27DB520
	public static void CreateBind(ProcInst super, Unit unit, List<GodUnit> godList, Action<Unit> decideEventHandler) { }

	// RVA: 0x27DBB90 Offset: 0x27DBC91 VA: 0x27DBB90
	private static List<BasicMenuItem> CreateMenuItemList(GodUnit god) { }

	// RVA: 0x27DC130 Offset: 0x27DC231 VA: 0x27DC130
	protected void .ctor(List<BasicMenuItem> menuItemList, SkillInheritanceMenuContent menuContent, List<GodUnit> godList) { }

	// RVA: 0x27DCB40 Offset: 0x27DCC41 VA: 0x27DCB40
	public void SetupMenuSkill() { }

	// RVA: 0x27DCC80 Offset: 0x27DCD81 VA: 0x27DCC80
	public void UpdateSkillPoint() { }

	// RVA: 0x27DCFD0 Offset: 0x27DD0D1 VA: 0x27DCFD0 Slot: 30
	public override string GetName() { }

	// RVA: 0x27DD020 Offset: 0x27DD121 VA: 0x27DD020 Slot: 51
	protected override BasicMenu.Result BCall() { }

	// RVA: 0x27DD220 Offset: 0x27DD321 VA: 0x27DD220 Slot: 58
	protected override BasicMenu.Result CustomCall() { }

	// RVA: 0x27DE3A0 Offset: 0x27DE4A1 VA: 0x27DE3A0 Slot: 42
	protected override void KeyLeft(bool isTrigger) { }

	// RVA: 0x27DE9A0 Offset: 0x27DEAA1 VA: 0x27DE9A0 Slot: 43
	protected override void KeyRight(bool isTrigger) { }

	// RVA: 0x27DCD60 Offset: 0x27DCE61 VA: 0x27DCD60
	public GodUnit GetGod() { }

	// RVA: 0x27DEC80 Offset: 0x27DED81 VA: 0x27DEC80
	public GodUnit GetGod(int index) { }

	// RVA: 0x27DE670 Offset: 0x27DE771 VA: 0x27DE670
	public int GetGodNum() { }

	// RVA: 0x27DED40 Offset: 0x27DEE41 VA: 0x27DED40
	public void SetSkillHelp(SkillData skill, int level) { }

	// RVA: 0x27DF400 Offset: 0x27DF501 VA: 0x27DF400
	public int GetSelectGodIndex() { }

	// RVA: 0x27DF410 Offset: 0x27DF511 VA: 0x27DF410
	private static void .cctor() { }
}

