// Namespace: 
public enum BattleDetail.BaseParams // TypeDefIndex: 9484
{
	// Fields
	public int value__; // 0x0
	public const BattleDetail.BaseParams BattleCount = 0;
	public const BattleDetail.BaseParams ActionCount = 1;
	public const BattleDetail.BaseParams AttackCount = 2;
	public const BattleDetail.BaseParams TerrainDefense = 3;
	public const BattleDetail.BaseParams TerrainAvoid = 4;
	public const BattleDetail.BaseParams SupportHit = 5;
	public const BattleDetail.BaseParams SupportAvoid = 6;
	public const BattleDetail.BaseParams SupportCritical = 7;
	public const BattleDetail.BaseParams SupportSecure = 8;
	public const BattleDetail.BaseParams WeaponAttack = 9;
	public const BattleDetail.BaseParams WeaponEfficacy = 10;
	public const BattleDetail.BaseParams WeaponHit = 11;
	public const BattleDetail.BaseParams WeaponAvoid = 12;
	public const BattleDetail.BaseParams WeaponCritical = 13;
	public const BattleDetail.BaseParams WeaponSecure = 14;
	public const BattleDetail.BaseParams WeaponWeight = 15;
	public const BattleDetail.BaseParams SkillCorrect = 16;
	public const BattleDetail.BaseParams GodSkillCorrect = 17;
	public const BattleDetail.BaseParams BlowRatio = 18;
	public const BattleDetail.BaseParams BlowDistance = 19;
	public const BattleDetail.BaseParams Num = 20;
}

// Namespace: 
public enum BattleDetail.BattleParams // TypeDefIndex: 9485
{
	// Fields
	public int value__; // 0x0
	public const BattleDetail.BattleParams UnitAttack = 0;
	public const BattleDetail.BattleParams UnitDefense = 1;
	public const BattleDetail.BattleParams Attack = 2;
	public const BattleDetail.BattleParams Defense = 3;
	public const BattleDetail.BattleParams Hit = 4;
	public const BattleDetail.BattleParams Avoid = 5;
	public const BattleDetail.BattleParams Critical = 6;
	public const BattleDetail.BattleParams Secure = 7;
	public const BattleDetail.BattleParams Continuous = 8;
	public const BattleDetail.BattleParams SimplePower = 9;
	public const BattleDetail.BattleParams SimpleHit = 10;
	public const BattleDetail.BattleParams SimpleCritical = 11;
	public const BattleDetail.BattleParams Num = 12;
}

// Namespace: 
public class BattleDetail.CommandParam : BattleParam // TypeDefIndex: 9486
{
	// Fields
	private CalculatorCommand m_Command; // 0x20

	// Properties
	public CalculatorCommand Command { get; }

	// Methods

	// RVA: 0x1F74C90 Offset: 0x1F74D91 VA: 0x1F74C90
	public void .ctor(string command) { }

	// RVA: 0x1F74D90 Offset: 0x1F74E91 VA: 0x1F74D90
	public CalculatorCommand get_Command() { }

	// RVA: 0x1F74BD0 Offset: 0x1F74CD1 VA: 0x1F74BD0
	public float Get(string name, BattleInfoSide side) { }

	// RVA: 0x1F74DA0 Offset: 0x1F74EA1 VA: 0x1F74DA0 Slot: 6
	public override float Calculate(BattleInfoSide side) { }
}

// Namespace: 
public class BattleDetail.DetailParam : BattleDetail.CommandParam // TypeDefIndex: 9487
{
	// Fields
	private BattleDetail m_Detail; // 0x28

	// Properties
	public BattleDetail Detail { get; }

	// Methods

	// RVA: 0x1F749D0 Offset: 0x1F74AD1 VA: 0x1F749D0
	public void .ctor(BattleDetail detail, string command) { }

	// RVA: 0x1F74F10 Offset: 0x1F75011 VA: 0x1F74F10
	public BattleDetail get_Detail() { }

	// RVA: 0x1F74F20 Offset: 0x1F75021 VA: 0x1F74F20 Slot: 6
	public override float Calculate(BattleInfoSide side) { }
}

// Namespace: 
public class BattleDetail.UnitAttackParam : BattleDetail.DetailParam // TypeDefIndex: 9488
{
	// Methods

	// RVA: 0x1F75580 Offset: 0x1F75681 VA: 0x1F75580
	public void .ctor(BattleDetail detail) { }
}

// Namespace: 
public class BattleDetail.UnitDefenseParam : BattleDetail.DetailParam // TypeDefIndex: 9489
{
	// Methods

	// RVA: 0x1F755F0 Offset: 0x1F756F1 VA: 0x1F755F0
	public void .ctor(BattleDetail detail) { }
}

// Namespace: 
public class BattleDetail.AttackParam : BattleDetail.DetailParam // TypeDefIndex: 9490
{
	// Methods

	// RVA: 0x1F74960 Offset: 0x1F74A61 VA: 0x1F74960
	public void .ctor(BattleDetail detail) { }

	// RVA: 0x1F74A10 Offset: 0x1F74B11 VA: 0x1F74A10 Slot: 6
	public override float Calculate(BattleInfoSide side) { }
}

// Namespace: 
public class BattleDetail.DefenseParam : BattleDetail.DetailParam // TypeDefIndex: 9491
{
	// Methods

	// RVA: 0x1F74EA0 Offset: 0x1F74FA1 VA: 0x1F74EA0
	public void .ctor(BattleDetail detail) { }
}

// Namespace: 
public class BattleDetail.HitParam : BattleDetail.DetailParam // TypeDefIndex: 9492
{
	// Fields
	private CalculatorCommand m_InterferenceRod; // 0x30

	// Methods

	// RVA: 0x1F74F40 Offset: 0x1F75041 VA: 0x1F74F40
	public void .ctor(BattleDetail detail) { }

	// RVA: 0x1F74FB0 Offset: 0x1F750B1 VA: 0x1F74FB0 Slot: 6
	public override float Calculate(BattleInfoSide side) { }
}

// Namespace: 
public class BattleDetail.AvoidParam : BattleDetail.DetailParam // TypeDefIndex: 9493
{
	// Methods

	// RVA: 0x1F74AB0 Offset: 0x1F74BB1 VA: 0x1F74AB0
	public void .ctor(BattleDetail detail) { }

	// RVA: 0x1F74B20 Offset: 0x1F74C21 VA: 0x1F74B20 Slot: 6
	public override float Calculate(BattleInfoSide side) { }
}

// Namespace: 
public class BattleDetail.CriticalParam : BattleDetail.DetailParam // TypeDefIndex: 9494
{
	// Methods

	// RVA: 0x1F74E30 Offset: 0x1F74F31 VA: 0x1F74E30
	public void .ctor(BattleDetail detail) { }
}

// Namespace: 
public class BattleDetail.SecureParam : BattleDetail.DetailParam // TypeDefIndex: 9495
{
	// Methods

	// RVA: 0x1F750A0 Offset: 0x1F751A1 VA: 0x1F750A0
	public void .ctor(BattleDetail detail) { }
}

// Namespace: 
public class BattleDetail.ContinuousParam : BattleDetail.DetailParam // TypeDefIndex: 9496
{
	// Methods

	// RVA: 0x1F74DC0 Offset: 0x1F74EC1 VA: 0x1F74DC0
	public void .ctor(BattleDetail detail) { }
}

// Namespace: 
public class BattleDetail.SimplePowerParam : BattleDetail.CommandParam // TypeDefIndex: 9497
{
	// Methods

	// RVA: 0x1F753E0 Offset: 0x1F754E1 VA: 0x1F753E0
	public void .ctor() { }

	// RVA: 0x1F75440 Offset: 0x1F75541 VA: 0x1F75440 Slot: 6
	public override float Calculate(BattleInfoSide side) { }
}

// Namespace: 
public class BattleDetail.SimpleHitParam : BattleDetail.CommandParam // TypeDefIndex: 9498
{
	// Properties
	protected override BattleParam.Kinds Kind { get; }

	// Methods

	// RVA: 0x1F75290 Offset: 0x1F75391 VA: 0x1F75290
	public void .ctor() { }

	// RVA: 0x1F752F0 Offset: 0x1F753F1 VA: 0x1F752F0 Slot: 4
	protected override BattleParam.Kinds get_Kind() { }

	// RVA: 0x1F75300 Offset: 0x1F75401 VA: 0x1F75300 Slot: 6
	public override float Calculate(BattleInfoSide side) { }
}

// Namespace: 
public class BattleDetail.SimpleCriticalParam : BattleDetail.CommandParam // TypeDefIndex: 9499
{
	// Properties
	protected override BattleParam.Kinds Kind { get; }

	// Methods

	// RVA: 0x1F75110 Offset: 0x1F75211 VA: 0x1F75110
	public void .ctor() { }

	// RVA: 0x1F75170 Offset: 0x1F75271 VA: 0x1F75170 Slot: 4
	protected override BattleParam.Kinds get_Kind() { }

	// RVA: 0x1F75180 Offset: 0x1F75281 VA: 0x1F75180 Slot: 6
	public override float Calculate(BattleInfoSide side) { }
}

