// Namespace: 
[FlagsAttribute] // RVA: 0x275CF0 Offset: 0x275DF1 VA: 0x275CF0
public enum BattleInfo.Flags // TypeDefIndex: 9501
{
	// Fields
	public int value__; // 0x0
	public const BattleInfo.Flags Simulation = 1;
	public const BattleInfo.Flags Warmup = 2;
	public const BattleInfo.Flags Alone = 4;
	public const BattleInfo.Flags Event = 8;
	public const BattleInfo.Flags Dance = 16;
	public const BattleInfo.Flags Training = 32;
	public const BattleInfo.Flags Rod = 64;
	public const BattleInfo.Flags Destroy = 128;
	public const BattleInfo.Flags MultiBattle = 256;
	public const BattleInfo.Flags BowCannon = 512;
	public const BattleInfo.Flags MagicCannon = 1024;
	public const BattleInfo.Flags FireCannon = 2048;
	public const BattleInfo.Flags EngageAttack = 4096;
	public const BattleInfo.Flags Traial = 8192;
	public const BattleInfo.Flags IgnoreRange = 16384;
	public const BattleInfo.Flags IgnorePosition = 32768;
	public const BattleInfo.Flags IgnoreOffensePosition = 65536;
	public const BattleInfo.Flags IgnoreRevenge = 131072;
	public const BattleInfo.Flags IgnoreBreak = 262144;
	public const BattleInfo.Flags IgnoreTerrain = 524288;
	public const BattleInfo.Flags IgnoreSupport = 1048576;
	public const BattleInfo.Flags IgnoreBlow = 2097152;
	public const BattleInfo.Flags IgnoreChain = 4194304;
	public const BattleInfo.Flags IgnoreSkill = 8388608;
	public const BattleInfo.Flags HideCombatGauge = 16777216;
	public const BattleInfo.Flags SkipCombatGrow = 33554432;
	public const BattleInfo.Flags FullBullet = 67108864;
	public const BattleInfo.Flags Summon = 134217728;
	public const BattleInfo.Flags Enchant = 268435456;
	public const BattleInfo.Flags CannonMask = 3584;
}

// Namespace: 
public class BattleInfo.FlagField : BitFieldTemplate32<BattleInfo.Flags> // TypeDefIndex: 9502
{
	// Methods

	// RVA: 0x1F756C0 Offset: 0x1F757C1 VA: 0x1F756C0 Slot: 5
	protected override int ToInt(BattleInfo.Flags value) { }

	// RVA: 0x1F756D0 Offset: 0x1F757D1 VA: 0x1F756D0
	public void .ctor() { }
}

// Namespace: 
public class BattleInfo.BattleInfoSideArray : BattleSide.ContainerArray<BattleInfoSide> // TypeDefIndex: 9503
{
	// Methods

	// RVA: 0x1F75660 Offset: 0x1F75761 VA: 0x1F75660
	public void .ctor() { }
}

// Namespace: 
public struct BattleInfo.SupportData // TypeDefIndex: 9504
{
	// Fields
	public Unit unit; // 0x0
	public BattleInfoSide.Status status; // 0x8

	// Methods

	// RVA: 0x1F76F10 Offset: 0x1F77011 VA: 0x1F76F10
	public void .ctor(Unit unit) { }

	// RVA: 0x1F76F40 Offset: 0x1F77041 VA: 0x1F76F40
	public void .ctor(Unit unit, BattleInfoSide.Status status) { }
}

// Namespace: 
public class BattleInfo.SupportList : List<BattleInfo.SupportData> // TypeDefIndex: 9505
{
	// Fields
	private Unit m_Offense; // 0x28
	private Unit m_Defense; // 0x30
	private Comparison<BattleInfo.SupportData> m_Compare; // 0x38

	// Methods

	// RVA: 0x1F76F70 Offset: 0x1F77071 VA: 0x1F76F70
	public void .ctor() { }

	// RVA: 0x1F77070 Offset: 0x1F77171 VA: 0x1F77070
	private int Compare(BattleInfo.SupportData a, BattleInfo.SupportData b) { }

	// RVA: 0x1F78650 Offset: 0x1F78751 VA: 0x1F78650
	public void Sort(Unit offense, Unit defense) { }

	// RVA: 0x1F786E0 Offset: 0x1F787E1 VA: 0x1F786E0
	public void Add(Unit unit) { }

	// RVA: 0x1F78760 Offset: 0x1F78861 VA: 0x1F78760
	public void Add(Unit unit, BattleInfoSide.Status status) { }
}

// Namespace: 
internal struct BattleInfo.SetupScope : IDisposable // TypeDefIndex: 9506
{
	// Fields
	private BattleInfo m_Info; // 0x0
	private Unit m_Offense; // 0x8
	private Unit m_Defense; // 0x10
	private byte m_Updated; // 0x18

	// Methods

	// RVA: 0x1F757B0 Offset: 0x1F758B1 VA: 0x1F757B0
	private BattleInfoSide GetSide(BattleSide.Type side) { }

	// RVA: 0x1F75810 Offset: 0x1F75911 VA: 0x1F75810
	public void .ctor(BattleInfo info, Unit offense, UnitItem unitItem, Unit defense, UnitItem revengeItem, int attackX = -1, int attackZ = -1, int targetX = -1, int targetZ = -1) { }

	// RVA: 0x1F76EC0 Offset: 0x1F76FC1 VA: 0x1F76EC0 Slot: 4
	public void Dispose() { }
}

// Namespace: 
public struct BattleInfo.MindScope : IDisposable // TypeDefIndex: 9507
{
	// Fields
	private Unit m_Unit; // 0x0
	private SkillData m_Skill; // 0x8
	private MapMind.Type m_Mind; // 0x10

	// Methods

	// RVA: 0x1F75730 Offset: 0x1F75831 VA: 0x1F75730
	public void .ctor(Unit unit, MapMind.Type mind, SkillData skill) { }

	// RVA: 0x1F75790 Offset: 0x1F75891 VA: 0x1F75790 Slot: 4
	public void Dispose() { }
}

