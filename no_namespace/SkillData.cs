// Namespace: 
public enum SkillData.Phase // TypeDefIndex: 10068
{
	// Fields
	public int value__; // 0x0
	public const SkillData.Phase Current = 0;
	public const SkillData.Phase Other = 1;
}

// Namespace: 
public enum SkillData.Timings // TypeDefIndex: 10070
{
	// Fields
	public int value__; // 0x0
	public const SkillData.Timings None = 0;
	public const SkillData.Timings Always = 1;
	public const SkillData.Timings BattleBefore = 2;
	public const SkillData.Timings BattleDetail = 3;
	public const SkillData.Timings BattleInvoke = 4;
	public const SkillData.Timings BattleStart = 5;
	public const SkillData.Timings OrderStart = 6;
	public const SkillData.Timings ActionStart = 7;
	public const SkillData.Timings AttackStart = 8;
	public const SkillData.Timings AttackBranch = 9;
	public const SkillData.Timings HitBefore = 10;
	public const SkillData.Timings HitAfter = 11;
	public const SkillData.Timings HitAffect = 12;
	public const SkillData.Timings AttackEnd = 13;
	public const SkillData.Timings ActionEnd = 14;
	public const SkillData.Timings OrderEnd = 15;
	public const SkillData.Timings BattleEnd = 16;
	public const SkillData.Timings BattleResult = 17;
	public const SkillData.Timings BattleAfter = 18;
	public const SkillData.Timings Around = 19;
	public const SkillData.Timings Support = 20;
	public const SkillData.Timings BattleCommand = 21;
	public const SkillData.Timings ActionCommand = 22;
	public const SkillData.Timings OverlapCommand = 23;
	public const SkillData.Timings SupportCommand = 24;
	public const SkillData.Timings FixedNone = 25;
	public const SkillData.Timings FixedDone = 26;
	public const SkillData.Timings PhaseStart = 27;
}

// Namespace: 
[FlagsAttribute] // RVA: 0x276560 Offset: 0x276661 VA: 0x276560
public enum SkillData.CycleMasks // TypeDefIndex: 10072
{
	// Fields
	public int value__; // 0x0
	public const SkillData.CycleMasks None = 0;
	public const SkillData.CycleMasks Full = 1048575;
}

// Namespace: 
public enum SkillData.Actions // TypeDefIndex: 10074
{
	// Fields
	public int value__; // 0x0
	public const SkillData.Actions None = 0;
	public const SkillData.Actions Offence = 1;
	public const SkillData.Actions Defence = 2;
}

// Namespace: 
public enum SkillData.Cycles // TypeDefIndex: 10076
{
	// Fields
	public int value__; // 0x0
	public const SkillData.Cycles None = 0;
	public const SkillData.Cycles Map = 1;
	public const SkillData.Cycles PhaseBefore = 2;
	public const SkillData.Cycles PhaseAfter = 3;
	public const SkillData.Cycles Fixed = 4;
	public const SkillData.Cycles Engaged = 5;
	public const SkillData.Cycles Battled = 6;
	public const SkillData.Cycles BattledOf = 7;
	public const SkillData.Cycles BattledDf = 8;
}

// Namespace: 
public enum SkillData.Works // TypeDefIndex: 10078
{
	// Fields
	public int value__; // 0x0
	public const SkillData.Works None = 0;
	public const SkillData.Works ItemHealScale = 1;
	public const SkillData.Works JobGrowChange = 2;
	public const SkillData.Works TotalGrowChange = 3;
}

// Namespace: 
[FlagsAttribute] // RVA: 0x276570 Offset: 0x276671 VA: 0x276570
public enum SkillData.Layers // TypeDefIndex: 10080
{
	// Fields
	public int value__; // 0x0
	public const SkillData.Layers A = 1;
	public const SkillData.Layers B = 2;
	public const SkillData.Layers C = 4;
	public const SkillData.Layers D = 8;
}

// Namespace: 
[FlagsAttribute] // RVA: 0x276590 Offset: 0x276691 VA: 0x276590
public enum SkillData.Flags // TypeDefIndex: 10082
{
	// Fields
	public long value__; // 0x0
	public const SkillData.Flags Invisible = 1;
	public const SkillData.Flags EngageAttack = 2;
	public const SkillData.Flags EngageCharge = 4;
	public const SkillData.Flags EngageLink = 8;
	public const SkillData.Flags EngageWait = 16;
	public const SkillData.Flags EngageSummon = 32;
	public const SkillData.Flags IgnoreEngageAttacking = 64;
	public const SkillData.Flags IgnoreNoEngageAttacking = 128;
	public const SkillData.Flags EnableChaining = 256;
	public const SkillData.Flags EnableDestory = 512;
	public const SkillData.Flags EnableCannon = 1024;
	public const SkillData.Flags EnableRod = 2048;
	public const SkillData.Flags IgnoreAlone = 4096;
	public const SkillData.Flags IgnoreMultiAttacking = 8192;
	public const SkillData.Flags IgnoreTraining = 16384;
	public const SkillData.Flags IgnoreTraial = 32768;
	public const SkillData.Flags IgnoreSimulation = 65536;
	public const SkillData.Flags ExclusiveDance = 131072;
	public const SkillData.Flags RevengeAutoEquip = 262144;
	public const SkillData.Flags SwapOrder = 524288;
	public const SkillData.Flags InterruptOrder = 1048576;
	public const SkillData.Flags ContinueBattle = 2097152;
	public const SkillData.Flags ForceLateOrder = 4194304;
	public const SkillData.Flags EachSupport = 8388608;
	public const SkillData.Flags Reactable = 16777216;
	public const SkillData.Flags Remagicable = 33554432;
	public const SkillData.Flags BeforeMove = 67108864;
	public const SkillData.Flags AllowChainAttack = 134217728;
	public const SkillData.Flags AllowChainGuard = 268435456;
	public const SkillData.Flags AllowEngageGuard = 536870912;
	public const SkillData.Flags ForceChainAttack = 1073741824;
	public const SkillData.Flags JoinChainAttack = 2147483648;
	public const SkillData.Flags RangeReliance = 4294967296;
	public const SkillData.Flags PickupReliance = 8589934592;
	public const SkillData.Flags MoveCostFree = 17179869184;
	public const SkillData.Flags MoveEnemyPass = 34359738368;
	public const SkillData.Flags ResetDisorder = 68719476736;
	public const SkillData.Flags ItemHealAround = 137438953472;
	public const SkillData.Flags ItemHealGive = 274877906944;
	public const SkillData.Flags SelfHealRod = 549755813888;
	public const SkillData.Flags OnlyRecvoerRod = 1099511627776;
	public const SkillData.Flags DecayEnhance = 2199023255552;
	public const SkillData.Flags SubEngageCountLimit = 4398046511104;
	public const SkillData.Flags ReverseCount = 8796093022208;
	public const SkillData.Flags ReCooking = 17592186044416;
	public const SkillData.Flags BasisSkill = 35184372088832;
	public const SkillData.Flags Unstoppable = 70368744177664;
	public const SkillData.Flags HideChangeGod = 140737488355328;
	public const SkillData.Flags OverExpChange = 281474976710656;
	public const SkillData.Flags MoveFly = 562949953421312;
	public const SkillData.Flags ViewRestriction = 1125899906842624;
	public const SkillData.Flags HasIconBmap = 9007199254740992;
	public const SkillData.Flags HasContract = 18014398509481984;
	public const SkillData.Flags HauntChainAttack = 36028797018963968;
	public const SkillData.Flags HasRootCommand = 72057594037927936;
	public const SkillData.Flags HasZOC = 144115188075855872;
	public const SkillData.Flags HasWork = 288230376151711744;
	public const SkillData.Flags HasVision = 576460752303423488;
	public const SkillData.Flags NotCondition = 1152921504606846976;
	public const SkillData.Flags HasCondition = 2305843009213693952;
	public const SkillData.Flags HasEnhance = 4611686018427387904;
	public const SkillData.Flags HasRangeTarget = -9223372036854775808;
	public const SkillData.Flags IgnoreMask = 127168;
}

// Namespace: 
public enum SkillData.IconKinds // TypeDefIndex: 10084
{
	// Fields
	public int value__; // 0x0
	public const SkillData.IconKinds None = 0;
	public const SkillData.IconKinds Efficacy = 1;
	public const SkillData.IconKinds Category = 2;
}

// Namespace: 
public enum SkillData.Categorys // TypeDefIndex: 10086
{
	// Fields
	public int value__; // 0x0
	public const SkillData.Categorys None = 0;
	public const SkillData.Categorys Person = 1;
	public const SkillData.Categorys Job = 2;
	public const SkillData.Categorys Item = 3;
	public const SkillData.Categorys Equip = 4;
	public const SkillData.Categorys God = 5;
	public const SkillData.Categorys Ring = 6;
	public const SkillData.Categorys Hub = 7;
	public const SkillData.Categorys Support = 8;
	public const SkillData.Categorys Battle = 9;
	public const SkillData.Categorys Private = 10;
	public const SkillData.Categorys Inheritance = 11;
	public const SkillData.Categorys Command = 12;
}

// Namespace: 
public enum SkillData.AroundTargets // TypeDefIndex: 10088
{
	// Fields
	public int value__; // 0x0
	public const SkillData.AroundTargets None = 0;
	public const SkillData.AroundTargets Friend = 1;
	public const SkillData.AroundTargets Enemy = 2;
	public const SkillData.AroundTargets Both = 3;
}

// Namespace: 
private class SkillData.Func // TypeDefIndex: 10090
{
	// Fields
	public string Name; // 0x10
	public SkillData.Operations Operation; // 0x18
	public CalculatorCommand SetCommand; // 0x20
	public CalculatorCommand GetCommand; // 0x28

	// Methods

	// RVA: 0x203BB20 Offset: 0x203BC21 VA: 0x203BB20
	public void .ctor() { }
}

