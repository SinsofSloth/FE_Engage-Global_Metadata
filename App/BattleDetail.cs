// Namespace: App
public class BattleDetail : Pool.Node // TypeDefIndex: 9500
{
	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x287460 Offset: 0x287561 VA: 0x287460
	private CapabilityInt <Capability>k__BackingField; // 0x10
	private int[] m_BaseParams; // 0x18
	private BattleParam[] m_BattleParams; // 0x20
	[CompilerGeneratedAttribute] // RVA: 0x287470 Offset: 0x287571 VA: 0x287470
	private BattleCalculator.Attributes <AttackAttribute>k__BackingField; // 0x28
	[CompilerGeneratedAttribute] // RVA: 0x287480 Offset: 0x287581 VA: 0x287480
	private SkillData.Layers <SkillLayers>k__BackingField; // 0x2C
	private SkillArray m_ActiveSkill; // 0x30

	// Properties
	public CapabilityInt Capability { get; set; }
	public int BattleCount { get; set; }
	public int ActionCount { get; set; }
	public int AttackCount { get; set; }
	public int TerrainDefense { get; set; }
	public int TerrainAvoid { get; set; }
	public int SupportHit { get; set; }
	public int SupportAvoid { get; set; }
	public int SupportCritical { get; set; }
	public int SupportSecure { get; set; }
	public int WeaponAttack { get; set; }
	public int WeaponEfficacy { get; set; }
	public int WeaponHit { get; set; }
	public int WeaponAvoid { get; set; }
	public int WeaponCritical { get; set; }
	public int WeaponSecure { get; set; }
	public int WeaponWeight { get; set; }
	public int SkillCorrect { get; set; }
	public int GodSkillCorrect { get; set; }
	public int BlowRatio { get; set; }
	public int BlowDistance { get; set; }
	public BattleParam UnitAttack { get; }
	public BattleParam UnitDefense { get; }
	public BattleParam Attack { get; }
	public BattleParam Defense { get; }
	public BattleParam Hit { get; }
	public BattleParam Avoid { get; }
	public BattleParam Critical { get; }
	public BattleParam Secure { get; }
	public BattleParam Continuous { get; }
	public BattleParam SimplePower { get; }
	public BattleParam SimpleHit { get; }
	public BattleParam SimpleCritical { get; }
	public BattleCalculator.Attributes AttackAttribute { get; set; }
	public SkillData.Layers SkillLayers { get; set; }
	public SkillArray ActiveSkill { get; }

	// Methods

	// RVA: 0x2241020 Offset: 0x2241121 VA: 0x2241020
	public void .ctor() { }

	// RVA: 0x2241970 Offset: 0x2241A71 VA: 0x2241970 Slot: 4
	public override void OnEnter() { }

	// RVA: 0x2241980 Offset: 0x2241A81 VA: 0x2241980 Slot: 5
	public override void OnExit() { }

	// RVA: 0x2241610 Offset: 0x2241711 VA: 0x2241610
	public void Clear() { }

	// RVA: 0x2241990 Offset: 0x2241A91 VA: 0x2241990
	public void Copy(BattleDetail src) { }

	// RVA: 0x22422B0 Offset: 0x22423B1 VA: 0x22422B0
	public void CalcBattle(BattleInfoSide current, BattleInfoSide reverse) { }

	// RVA: 0x2242D00 Offset: 0x2242E01 VA: 0x2242D00
	public void CalcInterferenceRod(BattleInfoSide current) { }

	[CompilerGeneratedAttribute] // RVA: 0x2B08B0 Offset: 0x2B09B1 VA: 0x2B08B0
	// RVA: 0x2242D40 Offset: 0x2242E41 VA: 0x2242D40
	public CapabilityInt get_Capability() { }

	[CompilerGeneratedAttribute] // RVA: 0x2B08C0 Offset: 0x2B09C1 VA: 0x2B08C0
	// RVA: 0x2242D50 Offset: 0x2242E51 VA: 0x2242D50
	private void set_Capability(CapabilityInt value) { }

	// RVA: 0x2242D60 Offset: 0x2242E61 VA: 0x2242D60
	public void CalcCapability(BattleInfoSide current, BattleInfoSide reverse) { }

	// RVA: 0x2243F40 Offset: 0x2244041 VA: 0x2243F40
	public int get_BattleCount() { }

	// RVA: 0x2243F70 Offset: 0x2244071 VA: 0x2243F70
	public void set_BattleCount(int value) { }

	// RVA: 0x2243FA0 Offset: 0x22440A1 VA: 0x2243FA0
	public int get_ActionCount() { }

	// RVA: 0x2242CA0 Offset: 0x2242DA1 VA: 0x2242CA0
	public void set_ActionCount(int value) { }

	// RVA: 0x2243FD0 Offset: 0x22440D1 VA: 0x2243FD0
	public int get_AttackCount() { }

	// RVA: 0x2242CD0 Offset: 0x2242DD1 VA: 0x2242CD0
	public void set_AttackCount(int value) { }

	// RVA: 0x2244000 Offset: 0x2244101 VA: 0x2244000
	public int get_TerrainDefense() { }

	// RVA: 0x2244030 Offset: 0x2244131 VA: 0x2244030
	public void set_TerrainDefense(int value) { }

	// RVA: 0x2244060 Offset: 0x2244161 VA: 0x2244060
	public int get_TerrainAvoid() { }

	// RVA: 0x2244090 Offset: 0x2244191 VA: 0x2244090
	public void set_TerrainAvoid(int value) { }

	// RVA: 0x22440C0 Offset: 0x22441C1 VA: 0x22440C0
	public int get_SupportHit() { }

	// RVA: 0x22440F0 Offset: 0x22441F1 VA: 0x22440F0
	public void set_SupportHit(int value) { }

	// RVA: 0x2244120 Offset: 0x2244221 VA: 0x2244120
	public int get_SupportAvoid() { }

	// RVA: 0x2244150 Offset: 0x2244251 VA: 0x2244150
	public void set_SupportAvoid(int value) { }

	// RVA: 0x2244180 Offset: 0x2244281 VA: 0x2244180
	public int get_SupportCritical() { }

	// RVA: 0x22441B0 Offset: 0x22442B1 VA: 0x22441B0
	public void set_SupportCritical(int value) { }

	// RVA: 0x22441E0 Offset: 0x22442E1 VA: 0x22441E0
	public int get_SupportSecure() { }

	// RVA: 0x2244210 Offset: 0x2244311 VA: 0x2244210
	public void set_SupportSecure(int value) { }

	// RVA: 0x2244240 Offset: 0x2244341 VA: 0x2244240
	public int get_WeaponAttack() { }

	// RVA: 0x2244270 Offset: 0x2244371 VA: 0x2244270
	public void set_WeaponAttack(int value) { }

	// RVA: 0x22442A0 Offset: 0x22443A1 VA: 0x22442A0
	public int get_WeaponEfficacy() { }

	// RVA: 0x22442D0 Offset: 0x22443D1 VA: 0x22442D0
	public void set_WeaponEfficacy(int value) { }

	// RVA: 0x2244300 Offset: 0x2244401 VA: 0x2244300
	public int get_WeaponHit() { }

	// RVA: 0x2244330 Offset: 0x2244431 VA: 0x2244330
	public void set_WeaponHit(int value) { }

	// RVA: 0x2244360 Offset: 0x2244461 VA: 0x2244360
	public int get_WeaponAvoid() { }

	// RVA: 0x2244390 Offset: 0x2244491 VA: 0x2244390
	public void set_WeaponAvoid(int value) { }

	// RVA: 0x22443C0 Offset: 0x22444C1 VA: 0x22443C0
	public int get_WeaponCritical() { }

	// RVA: 0x22443F0 Offset: 0x22444F1 VA: 0x22443F0
	public void set_WeaponCritical(int value) { }

	// RVA: 0x2244420 Offset: 0x2244521 VA: 0x2244420
	public int get_WeaponSecure() { }

	// RVA: 0x2244450 Offset: 0x2244551 VA: 0x2244450
	public void set_WeaponSecure(int value) { }

	// RVA: 0x2244480 Offset: 0x2244581 VA: 0x2244480
	public int get_WeaponWeight() { }

	// RVA: 0x2243F10 Offset: 0x2244011 VA: 0x2243F10
	public void set_WeaponWeight(int value) { }

	// RVA: 0x22444B0 Offset: 0x22445B1 VA: 0x22444B0
	public int get_SkillCorrect() { }

	// RVA: 0x22444E0 Offset: 0x22445E1 VA: 0x22444E0
	public void set_SkillCorrect(int value) { }

	// RVA: 0x2244510 Offset: 0x2244611 VA: 0x2244510
	public int get_GodSkillCorrect() { }

	// RVA: 0x2244540 Offset: 0x2244641 VA: 0x2244540
	public void set_GodSkillCorrect(int value) { }

	// RVA: 0x2244570 Offset: 0x2244671 VA: 0x2244570
	public int get_BlowRatio() { }

	// RVA: 0x22445A0 Offset: 0x22446A1 VA: 0x22445A0
	public void set_BlowRatio(int value) { }

	// RVA: 0x22445D0 Offset: 0x22446D1 VA: 0x22445D0
	public int get_BlowDistance() { }

	// RVA: 0x2244600 Offset: 0x2244701 VA: 0x2244600
	public void set_BlowDistance(int value) { }

	// RVA: 0x2244630 Offset: 0x2244731 VA: 0x2244630
	public BattleParam get_UnitAttack() { }

	// RVA: 0x2244660 Offset: 0x2244761 VA: 0x2244660
	public BattleParam get_UnitDefense() { }

	// RVA: 0x2244690 Offset: 0x2244791 VA: 0x2244690
	public BattleParam get_Attack() { }

	// RVA: 0x22446C0 Offset: 0x22447C1 VA: 0x22446C0
	public BattleParam get_Defense() { }

	// RVA: 0x22446F0 Offset: 0x22447F1 VA: 0x22446F0
	public BattleParam get_Hit() { }

	// RVA: 0x2244720 Offset: 0x2244821 VA: 0x2244720
	public BattleParam get_Avoid() { }

	// RVA: 0x2244750 Offset: 0x2244851 VA: 0x2244750
	public BattleParam get_Critical() { }

	// RVA: 0x2244780 Offset: 0x2244881 VA: 0x2244780
	public BattleParam get_Secure() { }

	// RVA: 0x22447B0 Offset: 0x22448B1 VA: 0x22447B0
	public BattleParam get_Continuous() { }

	// RVA: 0x22447E0 Offset: 0x22448E1 VA: 0x22447E0
	public BattleParam get_SimplePower() { }

	// RVA: 0x2244810 Offset: 0x2244911 VA: 0x2244810
	public BattleParam get_SimpleHit() { }

	// RVA: 0x2244840 Offset: 0x2244941 VA: 0x2244840
	public BattleParam get_SimpleCritical() { }

	// RVA: 0x22423B0 Offset: 0x22424B1 VA: 0x22423B0
	public void CalcAttack(BattleInfoSide current, BattleInfoSide reverse) { }

	// RVA: 0x2244870 Offset: 0x2244971 VA: 0x2244870
	public bool IsEfficacy() { }

	// RVA: 0x2242670 Offset: 0x2242771 VA: 0x2242670
	public void CalcDefense(BattleInfoSide current, BattleInfoSide reverse) { }

	// RVA: 0x22427C0 Offset: 0x22428C1 VA: 0x22427C0
	public void CalcHit(BattleInfoSide current, BattleInfoSide reverse) { }

	// RVA: 0x22428B0 Offset: 0x22429B1 VA: 0x22428B0
	public void CalcAvoid(BattleInfoSide current, BattleInfoSide reverse) { }

	// RVA: 0x2242AB0 Offset: 0x2242BB1 VA: 0x2242AB0
	public void CalcCritical(BattleInfoSide current, BattleInfoSide reverse) { }

	// RVA: 0x2242BA0 Offset: 0x2242CA1 VA: 0x2242BA0
	public void CalcSecure(BattleInfoSide current, BattleInfoSide reverse) { }

	// RVA: 0x2242C70 Offset: 0x2242D71 VA: 0x2242C70
	public void CalcContinuous(BattleInfoSide current, BattleInfoSide reverse) { }

	[CompilerGeneratedAttribute] // RVA: 0x2B08D0 Offset: 0x2B09D1 VA: 0x2B08D0
	// RVA: 0x22448D0 Offset: 0x22449D1 VA: 0x22448D0
	public BattleCalculator.Attributes get_AttackAttribute() { }

	[CompilerGeneratedAttribute] // RVA: 0x2B08E0 Offset: 0x2B09E1 VA: 0x2B08E0
	// RVA: 0x22448E0 Offset: 0x22449E1 VA: 0x22448E0
	public void set_AttackAttribute(BattleCalculator.Attributes value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2B08F0 Offset: 0x2B09F1 VA: 0x2B08F0
	// RVA: 0x22448F0 Offset: 0x22449F1 VA: 0x22448F0
	public SkillData.Layers get_SkillLayers() { }

	[CompilerGeneratedAttribute] // RVA: 0x2B0900 Offset: 0x2B0A01 VA: 0x2B0900
	// RVA: 0x2244900 Offset: 0x2244A01 VA: 0x2244900
	public void set_SkillLayers(SkillData.Layers value) { }

	// RVA: 0x2244910 Offset: 0x2244A11 VA: 0x2244910
	public SkillArray get_ActiveSkill() { }

	// RVA: 0x2244920 Offset: 0x2244A21 VA: 0x2244920
	public bool IsEnable(SkillData skill) { }

	// RVA: 0x2244970 Offset: 0x2244A71 VA: 0x2244970
	public void AddActiveSkill(SkillData skill) { }
}

