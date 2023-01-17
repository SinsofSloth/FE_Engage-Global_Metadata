// Namespace: App
public class SkillInheritanceMenuItem : BasicMenuItem // TypeDefIndex: 11224
{
	// Fields
	private const int c_ReleaseLevel = 5;
	[CompilerGeneratedAttribute] // RVA: 0x296FB0 Offset: 0x2970B1 VA: 0x296FB0
	private SkillData <Skill>k__BackingField; // 0x68
	[CompilerGeneratedAttribute] // RVA: 0x296FC0 Offset: 0x2970C1 VA: 0x296FC0
	private int <SortId>k__BackingField; // 0x70
	[CompilerGeneratedAttribute] // RVA: 0x296FD0 Offset: 0x2970D1 VA: 0x296FD0
	private int <SkillLevel>k__BackingField; // 0x74
	[CompilerGeneratedAttribute] // RVA: 0x296FE0 Offset: 0x2970E1 VA: 0x296FE0
	private int <SkillCost>k__BackingField; // 0x78
	public Action<Unit> m_DecideEventHandler; // 0x80

	// Properties
	public SkillData Skill { get; set; }
	public int SortId { get; set; }
	public int SkillLevel { get; set; }
	public int SkillCost { get; set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x2C3DD0 Offset: 0x2C3ED1 VA: 0x2C3DD0
	// RVA: 0x27DF950 Offset: 0x27DFA51 VA: 0x27DF950
	public SkillData get_Skill() { }

	[CompilerGeneratedAttribute] // RVA: 0x2C3DE0 Offset: 0x2C3EE1 VA: 0x2C3DE0
	// RVA: 0x27DF960 Offset: 0x27DFA61 VA: 0x27DF960
	private void set_Skill(SkillData value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2C3DF0 Offset: 0x2C3EF1 VA: 0x2C3DF0
	// RVA: 0x27DF970 Offset: 0x27DFA71 VA: 0x27DF970
	public int get_SortId() { }

	[CompilerGeneratedAttribute] // RVA: 0x2C3E00 Offset: 0x2C3F01 VA: 0x2C3E00
	// RVA: 0x27DF980 Offset: 0x27DFA81 VA: 0x27DF980
	private void set_SortId(int value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2C3E10 Offset: 0x2C3F11 VA: 0x2C3E10
	// RVA: 0x27DF990 Offset: 0x27DFA91 VA: 0x27DF990
	public int get_SkillLevel() { }

	[CompilerGeneratedAttribute] // RVA: 0x2C3E20 Offset: 0x2C3F21 VA: 0x2C3E20
	// RVA: 0x27DF9A0 Offset: 0x27DFAA1 VA: 0x27DF9A0
	private void set_SkillLevel(int value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2C3E30 Offset: 0x2C3F31 VA: 0x2C3E30
	// RVA: 0x27DF9B0 Offset: 0x27DFAB1 VA: 0x27DF9B0
	public int get_SkillCost() { }

	[CompilerGeneratedAttribute] // RVA: 0x2C3E40 Offset: 0x2C3F41 VA: 0x2C3E40
	// RVA: 0x27DF9C0 Offset: 0x27DFAC1 VA: 0x27DF9C0
	private void set_SkillCost(int value) { }

	// RVA: 0x27DCA10 Offset: 0x27DCB11 VA: 0x27DCA10
	public void .ctor(int sortId, SkillData skill, int skillLevel, Action<Unit> decideEventHandler) { }

	// RVA: 0x27DFBE0 Offset: 0x27DFCE1 VA: 0x27DFBE0 Slot: 8
	public override BasicMenuItem.Attribute BuildAttribute() { }

	// RVA: 0x27DFEA0 Offset: 0x27DFFA1 VA: 0x27DFEA0 Slot: 11
	public override void OnBuildMenuItemContent() { }

	// RVA: 0x27DFEB0 Offset: 0x27DFFB1 VA: 0x27DFEB0
	public void SetInitialColor() { }

	// RVA: 0x27DFFB0 Offset: 0x27E00B1 VA: 0x27DFFB0 Slot: 12
	public override void OnSelect() { }

	// RVA: 0x27E0050 Offset: 0x27E0151 VA: 0x27E0050 Slot: 18
	public override BasicMenu.Result ACall() { }

	// RVA: 0x27DF9D0 Offset: 0x27DFAD1 VA: 0x27DF9D0
	public bool IsInherited() { }

	// RVA: 0x27DFCD0 Offset: 0x27DFDD1 VA: 0x27DFCD0
	public bool IsEnoughLevel() { }

	// RVA: 0x27DFDC0 Offset: 0x27DFEC1 VA: 0x27DFDC0
	public bool IsEnoughSp() { }

	// RVA: 0x27DFAD0 Offset: 0x27DFBD1 VA: 0x27DFAD0
	public void ResetCost() { }

	// RVA: 0x27E0310 Offset: 0x27E0411 VA: 0x27E0310
	private void OnInherite() { }

	// RVA: 0x27E0120 Offset: 0x27E0221 VA: 0x27E0120
	private Unit GetUnit() { }

	// RVA: 0x27E01E0 Offset: 0x27E02E1 VA: 0x27E01E0
	private GodUnit GetGod() { }
}

