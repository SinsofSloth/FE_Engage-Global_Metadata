// Namespace: 
[FlagsAttribute] // RVA: 0x278E70 Offset: 0x278F71 VA: 0x278E70
public enum UnitAI.Flag // TypeDefIndex: 13497
{
	// Fields
	public int value__; // 0x0
	public const UnitAI.Flag Ec_Attack = 1;
	public const UnitAI.Flag Ec_AttackLongRange = 2;
	public const UnitAI.Flag Hc_Vulnerary = 4;
	public const UnitAI.Flag Hc_Terrain = 8;
	public const UnitAI.Flag Rc_Deactivate = 16;
	public const UnitAI.Flag EnchantWeaponDone = 32;
	public const UnitAI.Flag AllowCrossfire = 64;
	public const UnitAI.Flag ThinkNoMove = 256;
	public const UnitAI.Flag RejectPower0Attack = 512;
	public const UnitAI.Flag MoveBreak = 1024;
	public const UnitAI.Flag MoveThrough = 2048;
	public const UnitAI.Flag MoveSlow = 4096;
	public const UnitAI.Flag MoveWithAttack = 8192;
	public const UnitAI.Flag ThinkBreak = 16384;
	public const UnitAI.Flag ThinkChain = 32768;
	public const UnitAI.Flag EquipShortAfterLongRange = 65536;
	public const UnitAI.Flag BandActivation = 131072;
	public const UnitAI.Flag BandActivationMove = 262144;
	public const UnitAI.Flag BandActivationAttacked = 524288;
	public const UnitAI.Flag AskHealA = 1048576;
	public const UnitAI.Flag AskHealB = 2097152;
	public const UnitAI.Flag Idle = 4194304;
	public const UnitAI.Flag MoveoverFailed = 8388608;
	public const UnitAI.Flag TargetToAttack = 16777216;
	public const UnitAI.Flag TargetToHeal = 33554432;
	public const UnitAI.Flag TargetToInterference = 67108864;
	public const UnitAI.Flag TargetToCannon = 134217728;
	public const UnitAI.Flag DoneAskHealB = 268435456;
	public const UnitAI.Flag EngageAttackOnce = 536870912;
	public const UnitAI.Flag EngageAttackOnceDone = 1073741824;
	public const UnitAI.Flag MagicShieldOnceDone = -2147483648;
	public const UnitAI.Flag MaskTarget = 251658240;
	public const UnitAI.Flag MaskThink = 535822336;
	public const UnitAI.Flag MaskBandActivation = 917504;
}

// Namespace: 
public class UnitAI.FlagField : BitField32 // TypeDefIndex: 13498
{
	// Methods

	// RVA: 0x23ABA50 Offset: 0x23ABB51 VA: 0x23ABA50
	public void Set(UnitAI.Flag f) { }

	// RVA: 0x23ABA60 Offset: 0x23ABB61 VA: 0x23ABA60
	public bool Test(UnitAI.Flag f) { }

	// RVA: 0x23ABA70 Offset: 0x23ABB71 VA: 0x23ABA70
	public bool Not(UnitAI.Flag f) { }

	// RVA: 0x23ABA80 Offset: 0x23ABB81 VA: 0x23ABA80
	public void Clear(UnitAI.Flag f) { }

	// RVA: 0x23ABA90 Offset: 0x23ABB91 VA: 0x23ABA90
	public int Mask(UnitAI.Flag f) { }

	// RVA: 0x23ABAA0 Offset: 0x23ABBA1 VA: 0x23ABAA0
	public void .ctor() { }
}

// Namespace: 
[FlagsAttribute] // RVA: 0x278E80 Offset: 0x278F81 VA: 0x278E80
public enum UnitAI.RandomFlag // TypeDefIndex: 13499
{
	// Fields
	public int value__; // 0x0
	public const UnitAI.RandomFlag ClearAskHealB = 1;
}

// Namespace: 
public class UnitAI.RandomFlagField : BitField32 // TypeDefIndex: 13500
{
	// Methods

	// RVA: 0x23ABDD0 Offset: 0x23ABED1 VA: 0x23ABDD0
	public void Set(UnitAI.RandomFlag f) { }

	// RVA: 0x23ABDE0 Offset: 0x23ABEE1 VA: 0x23ABDE0
	public bool Test(UnitAI.RandomFlag f) { }

	// RVA: 0x23ABDF0 Offset: 0x23ABEF1 VA: 0x23ABDF0
	public bool Not(UnitAI.RandomFlag f) { }

	// RVA: 0x23ABE00 Offset: 0x23ABF01 VA: 0x23ABE00
	public void .ctor() { }
}

// Namespace: 
public enum UnitAI.BattleRate // TypeDefIndex: 13501
{
	// Fields
	public int value__; // 0x0
	public const UnitAI.BattleRate Rush = 0;
	public const UnitAI.BattleRate Attack = 1;
	public const UnitAI.BattleRate Chariness = 2;
	public const UnitAI.BattleRate Num = 3;
}

// Namespace: 
public enum UnitAI.MoveLimitRange.LimitType // TypeDefIndex: 13502
{
	// Fields
	public int value__; // 0x0
	public const UnitAI.MoveLimitRange.LimitType None = 0;
	public const UnitAI.MoveLimitRange.LimitType Move = 1;
	public const UnitAI.MoveLimitRange.LimitType Distance = 2;
	public const UnitAI.MoveLimitRange.LimitType Rect = 3;
	public const UnitAI.MoveLimitRange.LimitType InterferenceRodRect = 4;
	public const UnitAI.MoveLimitRange.LimitType Num = 5;
}

// Namespace: 
public class UnitAI.MoveLimitRange // TypeDefIndex: 13503
{
	// Fields
	private const int Version = 0;
	private byte m_Type; // 0x10
	private sbyte m_X; // 0x11
	private sbyte m_Z; // 0x12
	private sbyte m_W; // 0x13
	private sbyte m_H; // 0x14

	// Properties
	public UnitAI.MoveLimitRange.LimitType Type { get; set; }
	public int X { get; set; }
	public int Z { get; set; }
	public int W { get; set; }
	public int H { get; set; }

	// Methods

	// RVA: 0x23ABAB0 Offset: 0x23ABBB1 VA: 0x23ABAB0
	public UnitAI.MoveLimitRange.LimitType get_Type() { }

	// RVA: 0x23ABAC0 Offset: 0x23ABBC1 VA: 0x23ABAC0
	public void set_Type(UnitAI.MoveLimitRange.LimitType value) { }

	// RVA: 0x23ABAD0 Offset: 0x23ABBD1 VA: 0x23ABAD0
	public int get_X() { }

	// RVA: 0x23ABAE0 Offset: 0x23ABBE1 VA: 0x23ABAE0
	public void set_X(int value) { }

	// RVA: 0x23ABAF0 Offset: 0x23ABBF1 VA: 0x23ABAF0
	public int get_Z() { }

	// RVA: 0x23ABB00 Offset: 0x23ABC01 VA: 0x23ABB00
	public void set_Z(int value) { }

	// RVA: 0x23ABB10 Offset: 0x23ABC11 VA: 0x23ABB10
	public int get_W() { }

	// RVA: 0x23ABB20 Offset: 0x23ABC21 VA: 0x23ABB20
	public void set_W(int value) { }

	// RVA: 0x23ABB30 Offset: 0x23ABC31 VA: 0x23ABB30
	public int get_H() { }

	// RVA: 0x23ABB40 Offset: 0x23ABC41 VA: 0x23ABB40
	public void set_H(int value) { }

	// RVA: 0x23ABB50 Offset: 0x23ABC51 VA: 0x23ABB50
	public void Clear() { }

	// RVA: 0x23ABB60 Offset: 0x23ABC61 VA: 0x23ABB60
	public void Serialize(Stream stream) { }

	// RVA: 0x23ABBE0 Offset: 0x23ABCE1 VA: 0x23ABBE0
	public void Deserialize(Stream stream) { }

	// RVA: 0x23ABDC0 Offset: 0x23ABEC1 VA: 0x23ABDC0
	public void .ctor() { }
}

// Namespace: 
public enum UnitAI.VersusTypes // TypeDefIndex: 13504
{
	// Fields
	public int value__; // 0x0
	public const UnitAI.VersusTypes NotMove = 0;
	public const UnitAI.VersusTypes Defense = 1;
	public const UnitAI.VersusTypes Rush = 2;
	public const UnitAI.VersusTypes ResponseA = 3;
	public const UnitAI.VersusTypes ResponseB = 4;
	public const UnitAI.VersusTypes ResponseC = 5;
	public const UnitAI.VersusTypes Num = 6;
}

