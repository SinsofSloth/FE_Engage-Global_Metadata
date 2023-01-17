// Namespace: 
private class AIBattleSimulator.Indication // TypeDefIndex: 9271
{
	// Fields
	private int m_Power; // 0x10
	private int m_SkillPower; // 0x14
	private float m_Hit; // 0x18
	private float m_Critical; // 0x1C
	private float m_Skill; // 0x20
	private float m_SkillCritical; // 0x24
	private float m_Prevent; // 0x28
	private float m_Miss; // 0x2C
	private float m_Expectation; // 0x30
	private bool m_IsSkillKill; // 0x34

	// Properties
	public int Power { get; set; }
	public int SkillPower { get; set; }
	public float Hit { get; set; }
	public float Critical { get; set; }
	public float Skill { get; set; }
	public float SkillCritical { get; set; }
	public float Prevent { get; set; }
	public float Miss { get; set; }
	public float Expectation { get; set; }
	public bool IsSkillKill { get; set; }

	// Methods

	// RVA: 0x26DA4E0 Offset: 0x26DA5E1 VA: 0x26DA4E0
	public int get_Power() { }

	// RVA: 0x26DA4F0 Offset: 0x26DA5F1 VA: 0x26DA4F0
	public void set_Power(int value) { }

	// RVA: 0x26DA500 Offset: 0x26DA601 VA: 0x26DA500
	public int get_SkillPower() { }

	// RVA: 0x26DA510 Offset: 0x26DA611 VA: 0x26DA510
	public void set_SkillPower(int value) { }

	// RVA: 0x26DA520 Offset: 0x26DA621 VA: 0x26DA520
	public float get_Hit() { }

	// RVA: 0x26DA530 Offset: 0x26DA631 VA: 0x26DA530
	public void set_Hit(float value) { }

	// RVA: 0x26DA540 Offset: 0x26DA641 VA: 0x26DA540
	public float get_Critical() { }

	// RVA: 0x26DA550 Offset: 0x26DA651 VA: 0x26DA550
	public void set_Critical(float value) { }

	// RVA: 0x26DA560 Offset: 0x26DA661 VA: 0x26DA560
	public float get_Skill() { }

	// RVA: 0x26DA570 Offset: 0x26DA671 VA: 0x26DA570
	public void set_Skill(float value) { }

	// RVA: 0x26DA580 Offset: 0x26DA681 VA: 0x26DA580
	public float get_SkillCritical() { }

	// RVA: 0x26DA590 Offset: 0x26DA691 VA: 0x26DA590
	public void set_SkillCritical(float value) { }

	// RVA: 0x26DA5A0 Offset: 0x26DA6A1 VA: 0x26DA5A0
	public float get_Prevent() { }

	// RVA: 0x26DA5B0 Offset: 0x26DA6B1 VA: 0x26DA5B0
	public void set_Prevent(float value) { }

	// RVA: 0x26DA5C0 Offset: 0x26DA6C1 VA: 0x26DA5C0
	public float get_Miss() { }

	// RVA: 0x26DA5D0 Offset: 0x26DA6D1 VA: 0x26DA5D0
	public void set_Miss(float value) { }

	// RVA: 0x26DA5E0 Offset: 0x26DA6E1 VA: 0x26DA5E0
	public float get_Expectation() { }

	// RVA: 0x26DA5F0 Offset: 0x26DA6F1 VA: 0x26DA5F0
	public void set_Expectation(float value) { }

	// RVA: 0x26DA600 Offset: 0x26DA701 VA: 0x26DA600
	public bool get_IsSkillKill() { }

	// RVA: 0x26DA610 Offset: 0x26DA711 VA: 0x26DA610
	public void set_IsSkillKill(bool value) { }

	// RVA: 0x26DA620 Offset: 0x26DA721 VA: 0x26DA620
	public void Clear() { }

	// RVA: 0x26DA630 Offset: 0x26DA731 VA: 0x26DA630
	public void .ctor() { }
}

// Namespace: 
private class AIBattleSimulator.ChainAttackCandidate // TypeDefIndex: 9272
{
	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x286F80 Offset: 0x287081 VA: 0x286F80
	private BattleInfoSide <Side>k__BackingField; // 0x10

	// Properties
	public BattleInfoSide Side { get; set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x2AEF20 Offset: 0x2AF021 VA: 0x2AEF20
	// RVA: 0x26DA4A0 Offset: 0x26DA5A1 VA: 0x26DA4A0
	public BattleInfoSide get_Side() { }

	[CompilerGeneratedAttribute] // RVA: 0x2AEF30 Offset: 0x2AF031 VA: 0x2AEF30
	// RVA: 0x26DA4B0 Offset: 0x26DA5B1 VA: 0x26DA4B0
	public void set_Side(BattleInfoSide value) { }

	// RVA: 0x26DA4C0 Offset: 0x26DA5C1 VA: 0x26DA4C0
	public void Clear() { }

	// RVA: 0x26DA4D0 Offset: 0x26DA5D1 VA: 0x26DA4D0
	public void .ctor() { }
}

// Namespace: 
private class AIBattleSimulator.Break // TypeDefIndex: 9273
{
	// Fields
	public const float MaxStun = 0.85;
	private float m_BreakAttack; // 0x10
	private float m_Stun; // 0x14

	// Properties
	public float BreakAttack { get; }
	public float Stun { get; }
	public bool IsNotBreak { get; }

	// Methods

	// RVA: 0x26DA390 Offset: 0x26DA491 VA: 0x26DA390
	public void Setup(BattleInfoSide side, AIBattleSimulator.Indication indication) { }

	// RVA: 0x26DA400 Offset: 0x26DA501 VA: 0x26DA400
	public void Disable() { }

	// RVA: 0x26DA410 Offset: 0x26DA511 VA: 0x26DA410
	public void Add(float breakAttack) { }

	// RVA: 0x26DA450 Offset: 0x26DA551 VA: 0x26DA450
	public float get_BreakAttack() { }

	// RVA: 0x26DA460 Offset: 0x26DA561 VA: 0x26DA460
	public float get_Stun() { }

	// RVA: 0x26DA470 Offset: 0x26DA571 VA: 0x26DA470
	public bool get_IsNotBreak() { }

	// RVA: 0x26DA490 Offset: 0x26DA591 VA: 0x26DA490
	public void .ctor() { }
}

