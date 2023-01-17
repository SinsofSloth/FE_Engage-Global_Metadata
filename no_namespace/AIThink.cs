// Namespace: 
private sealed class AIThink.AcFunc : MulticastDelegate // TypeDefIndex: 9277
{
	// Methods

	// RVA: 0x24A0B10 Offset: 0x24A0C11 VA: 0x24A0B10
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x24A0B30 Offset: 0x24A0C31 VA: 0x24A0B30 Slot: 13
	public virtual bool Invoke(int command, AIValue v0, AIValue v1) { }

	// RVA: 0x24A0D90 Offset: 0x24A0E91 VA: 0x24A0D90 Slot: 14
	public virtual IAsyncResult BeginInvoke(int command, AIValue v0, AIValue v1, AsyncCallback callback, object object) { }

	// RVA: 0x24A0E40 Offset: 0x24A0F41 VA: 0x24A0E40 Slot: 15
	public virtual bool EndInvoke(IAsyncResult result) { }
}

// Namespace: 
private sealed class AIThink.RcFunc : MulticastDelegate // TypeDefIndex: 9278
{
	// Methods

	// RVA: 0x24A6820 Offset: 0x24A6921 VA: 0x24A6820
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x24A6840 Offset: 0x24A6941 VA: 0x24A6840 Slot: 13
	public virtual bool Invoke(int command, AIValue v0, AIValue v1) { }

	// RVA: 0x24A6AA0 Offset: 0x24A6BA1 VA: 0x24A6AA0 Slot: 14
	public virtual IAsyncResult BeginInvoke(int command, AIValue v0, AIValue v1, AsyncCallback callback, object object) { }

	// RVA: 0x24A6B50 Offset: 0x24A6C51 VA: 0x24A6B50 Slot: 15
	public virtual bool EndInvoke(IAsyncResult result) { }
}

// Namespace: 
private sealed class AIThink.ActionFunc : MulticastDelegate // TypeDefIndex: 9279
{
	// Methods

	// RVA: 0x24A0E70 Offset: 0x24A0F71 VA: 0x24A0E70
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x24A0E90 Offset: 0x24A0F91 VA: 0x24A0E90 Slot: 13
	public virtual AIThink.Result Invoke(int command, AIValue v0, AIValue v1) { }

	// RVA: 0x24A10F0 Offset: 0x24A11F1 VA: 0x24A10F0 Slot: 14
	public virtual IAsyncResult BeginInvoke(int command, AIValue v0, AIValue v1, AsyncCallback callback, object object) { }

	// RVA: 0x24A11A0 Offset: 0x24A12A1 VA: 0x24A11A0 Slot: 15
	public virtual AIThink.Result EndInvoke(IAsyncResult result) { }
}

// Namespace: 
public enum AIThink.Think // TypeDefIndex: 9280
{
	// Fields
	public int value__; // 0x0
	public const AIThink.Think None = 0;
	public const AIThink.Think Cause = 1;
	public const AIThink.Think Mind = 2;
	public const AIThink.Think Attack = 3;
	public const AIThink.Think AttackLongRange = 4;
	public const AIThink.Think AttackHigh = 5;
	public const AIThink.Think AttackMiddle = 6;
	public const AIThink.Think AttackLow = 7;
	public const AIThink.Think Move = 8;
	public const AIThink.Think EntrustHeal = 1;
	public const AIThink.Think EntrustAttack = 2;
	public const AIThink.Think EntrustMove = 3;
	public const AIThink.Think EntrustFixed = 4;
	public const AIThink.Think UncontrollHeal = 1;
	public const AIThink.Think UncontrollAttack = 2;
	public const AIThink.Think UncontrollMove = 3;
	public const AIThink.Think UncontrollFixed = 4;
}

// Namespace: 
public enum AIThink.Result // TypeDefIndex: 9281
{
	// Fields
	public int value__; // 0x0
	public const AIThink.Result None = 0;
	public const AIThink.Result Decide = 1;
	public const AIThink.Result Reserve = 2;
}

// Namespace: 
public class AIThink.UpdateFlag : BitField32 // TypeDefIndex: 9282
{
	// Fields
	public const int Active = 1;
	public const int Value0 = 2;
	public const int Value1 = 4;
	public const int Value2 = 8;
	public const int Value3 = 16;
	public const int Retry = 32;
	public const int MaskUpdate = 31;

	// Methods

	// RVA: 0x24A7430 Offset: 0x24A7531 VA: 0x24A7430
	public void .ctor() { }
}

// Namespace: 
public class AIThink.MoveFlag : BitField32 // TypeDefIndex: 9283
{
	// Fields
	public const int Through = 1;
	public const int Break = 2;
	public const int Back = 4;
	public const int Slow = 8;
	public const int Door = 16;
	public const int Ignore = 32;
	public const int IgnoreIceTile = 64;

	// Methods

	// RVA: 0x24A65F0 Offset: 0x24A66F1 VA: 0x24A65F0
	public void .ctor() { }
}

// Namespace: 
public class AIThink.AttackFlag : BitField32 // TypeDefIndex: 9284
{
	// Fields
	public const int Side = 1;
	public const int Nearest = 2;
	public const int AheadIgnore = 4;
	public const int __IgnoreSilent = 8;
	public const int __DestroyTargetCastleOffset = 16;
	public const int ScoreExpectation = 32;
	public const int InterferenceHighMagic = 128;
	public const int InterferenceLowMagic = 256;
	public const int Break = 512;
	public const int Chain = 1024;
	public const int MagicOnly = 2048;
	public const int ChainAttackCount = 4096;
	public const int PierceMultiple = 8192;
	public const int InterferenceRange = 16384;
	public const int EquipSkillMultiple = 32768;

	// Methods

	// RVA: 0x24A11D0 Offset: 0x24A12D1 VA: 0x24A11D0
	public void .ctor() { }
}

// Namespace: 
private enum AIThink.Command // TypeDefIndex: 9285
{
	// Fields
	public int value__; // 0x0
	public const AIThink.Command EveryTime = -1;
	public const AIThink.Command NonActiive = -2;
	public const AIThink.Command Active = 0;
}

// Namespace: 
private enum AIThink.GodSkillTypes // TypeDefIndex: 9286
{
	// Fields
	public int value__; // 0x0
	public const AIThink.GodSkillTypes None = 0;
	public const AIThink.GodSkillTypes Remagic = 1;
	public const AIThink.GodSkillTypes BeforeMove = 2;
	public const AIThink.GodSkillTypes Vision = 3;
	public const AIThink.GodSkillTypes Overlap = 4;
	public const AIThink.GodSkillTypes Support = 5;
	public const AIThink.GodSkillTypes EngageGuard = 6;
	public const AIThink.GodSkillTypes PullBack = 7;
	public const AIThink.GodSkillTypes GodChange = 8;
	public const AIThink.GodSkillTypes Decoy = 9;
	public const AIThink.GodSkillTypes Strategy = 10;
	public const AIThink.GodSkillTypes StrategyHolyShield = 11;
	public const AIThink.GodSkillTypes Trimasteries = 12;
	public const AIThink.GodSkillTypes Contract = 13;
	public const AIThink.GodSkillTypes Gaze = 14;
	public const AIThink.GodSkillTypes Num = 15;
}

// Namespace: 
private enum AIThink.CGBSResult // TypeDefIndex: 9287
{
	// Fields
	public int value__; // 0x0
	public const AIThink.CGBSResult NoGive = 0;
	public const AIThink.CGBSResult CannotGive = 1;
	public const AIThink.CGBSResult CanGive = 2;
}

// Namespace: 
private class AIThink.EngageWaitAdditionalAttackImage : MapImageCore<ushort> // TypeDefIndex: 9288
{
	// Methods

	// RVA: 0x24A5A90 Offset: 0x24A5B91 VA: 0x24A5A90 Slot: 5
	public override void Add(int index, ushort v) { }

	// RVA: 0x24A5AD0 Offset: 0x24A5BD1 VA: 0x24A5AD0
	public void IncRange1(int x, int z) { }

	// RVA: 0x24A5CC0 Offset: 0x24A5DC1 VA: 0x24A5CC0
	public void IncRange2(int x, int z) { }

	// RVA: 0x24A5C30 Offset: 0x24A5D31 VA: 0x24A5C30
	public void SetRange12(int x, int z, byte range1, byte range2) { }

	// RVA: 0x24A5BA0 Offset: 0x24A5CA1 VA: 0x24A5BA0
	public void GetRange12(int x, int z, out byte range1, out byte range2) { }

	// RVA: 0x24A5D90 Offset: 0x24A5E91 VA: 0x24A5D90
	public void .ctor() { }
}

// Namespace: 
private struct AIThink.EngageWaitRangeScore // TypeDefIndex: 9289
{
	// Fields
	public uint score; // 0x0
	public int x; // 0x4
	public int z; // 0x8

	// Methods

	// RVA: 0x24A5DF0 Offset: 0x24A5EF1 VA: 0x24A5DF0
	public void CompareAndSwap(uint tempScore, int tempX, int tempZ) { }

	// RVA: 0x24A5E50 Offset: 0x24A5F51 VA: 0x24A5E50
	public static void New(out AIThink.EngageWaitRangeScore inst) { }
}

// Namespace: 
private struct AIThink.EngageWaitResult // TypeDefIndex: 9290
{
	// Fields
	public uint score; // 0x0
	public int x; // 0x4
	public int z; // 0x8
	public int itemIndex; // 0xC
	public int power; // 0x10
	private Unit unit; // 0x18

	// Methods

	// RVA: 0x24A5E70 Offset: 0x24A5F71 VA: 0x24A5E70
	public void CompareAndSwap(uint tempScore, int tempX, int tempZ, int tempItemIndex) { }

	// RVA: 0x24A5F60 Offset: 0x24A6061 VA: 0x24A5F60
	public static void New(Unit unit, out AIThink.EngageWaitResult inst) { }
}

// Namespace: 
private sealed class AIThink.EnchantThink.CalcUnitScoreFunction : MulticastDelegate // TypeDefIndex: 9291
{
	// Methods

	// RVA: 0x1DBFD60 Offset: 0x1DBFE61 VA: 0x1DBFD60
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x1DBFD80 Offset: 0x1DBFE81 VA: 0x1DBFD80 Slot: 13
	public virtual byte Invoke(AIThink.EnchantThink think, Unit actor, Unit target, UnitItem unitItem) { }

	// RVA: 0x1DC0140 Offset: 0x1DC0241 VA: 0x1DC0140 Slot: 14
	public virtual IAsyncResult BeginInvoke(AIThink.EnchantThink think, Unit actor, Unit target, UnitItem unitItem, AsyncCallback callback, object object) { }

	// RVA: 0x1DC0180 Offset: 0x1DC0281 VA: 0x1DC0180 Slot: 15
	public virtual byte EndInvoke(IAsyncResult result) { }
}

// Namespace: 
private enum AIThink.EnchantThink.Kinds // TypeDefIndex: 9292
{
	// Fields
	public byte value__; // 0x0
	public const AIThink.EnchantThink.Kinds Rest = 0;
	public const AIThink.EnchantThink.Kinds EngageCount = 1;
	public const AIThink.EnchantThink.Kinds EfficacyMorph = 2;
	public const AIThink.EnchantThink.Kinds Sight = 3;
	public const AIThink.EnchantThink.Kinds NoChainAttack = 4;
	public const AIThink.EnchantThink.Kinds WeightZero = 5;
	public const AIThink.EnchantThink.Kinds NoSilence = 6;
	public const AIThink.EnchantThink.Kinds ReflectPhysics = 7;
	public const AIThink.EnchantThink.Kinds ReflectMagic = 8;
	public const AIThink.EnchantThink.Kinds NoBreak = 9;
	public const AIThink.EnchantThink.Kinds NoFreeze = 10;
	public const AIThink.EnchantThink.Kinds NoDamage = 11;
	public const AIThink.EnchantThink.Kinds HoldOut = 12;
	public const AIThink.EnchantThink.Kinds Weapon = 13;
	public const AIThink.EnchantThink.Kinds Max = 14;
}

// Namespace: 
private struct AIThink.EnchantThink.ItemInfo : IComparable<AIThink.EnchantThink.ItemInfo> // TypeDefIndex: 9293
{
	// Fields
	public byte itemIndex; // 0x0
	public byte kind; // 0x1

	// Methods

	// RVA: 0x1DC01D0 Offset: 0x1DC02D1 VA: 0x1DC01D0 Slot: 4
	public int CompareTo(AIThink.EnchantThink.ItemInfo other) { }
}

// Namespace: 
private struct AIThink.EnchantThink.SurroundingInfo // TypeDefIndex: 9294
{
	// Fields
	private const uint CountMask = 15;
	private const int MorphShift = 0;
	private const int PhysicalAttackShift = 4;
	private const int MagicAttackShift = 8;
	private const int ChainAttackShift = 12;
	private const int BreakShift = 16;
	private const int SilenceShift = 20;
	private const int FreezeShift = 24;
	private uint m_Value; // 0x0

	// Properties
	public int MorphCount { get; set; }
	public int PhysicalAttackCount { get; set; }
	public int MagicAttackCount { get; set; }
	public int AttackCount { get; }
	public int ChainAttackCount { get; set; }
	public int BreakCount { get; set; }
	public int SilenceCount { get; set; }
	public int FreezeCount { get; set; }

	// Methods

	// RVA: 0x1DC0290 Offset: 0x1DC0391 VA: 0x1DC0290
	public int get_MorphCount() { }

	// RVA: 0x1DC02A0 Offset: 0x1DC03A1 VA: 0x1DC02A0
	public void set_MorphCount(int value) { }

	// RVA: 0x1DC0330 Offset: 0x1DC0431 VA: 0x1DC0330
	public int get_PhysicalAttackCount() { }

	// RVA: 0x1DC0340 Offset: 0x1DC0441 VA: 0x1DC0340
	public void set_PhysicalAttackCount(int value) { }

	// RVA: 0x1DC03D0 Offset: 0x1DC04D1 VA: 0x1DC03D0
	public int get_MagicAttackCount() { }

	// RVA: 0x1DC03E0 Offset: 0x1DC04E1 VA: 0x1DC03E0
	public void set_MagicAttackCount(int value) { }

	// RVA: 0x1DC0470 Offset: 0x1DC0571 VA: 0x1DC0470
	public int get_AttackCount() { }

	// RVA: 0x1DC0490 Offset: 0x1DC0591 VA: 0x1DC0490
	public int get_ChainAttackCount() { }

	// RVA: 0x1DC04A0 Offset: 0x1DC05A1 VA: 0x1DC04A0
	public void set_ChainAttackCount(int value) { }

	// RVA: 0x1DC0530 Offset: 0x1DC0631 VA: 0x1DC0530
	public int get_BreakCount() { }

	// RVA: 0x1DC0540 Offset: 0x1DC0641 VA: 0x1DC0540
	public void set_BreakCount(int value) { }

	// RVA: 0x1DC05D0 Offset: 0x1DC06D1 VA: 0x1DC05D0
	public int get_SilenceCount() { }

	// RVA: 0x1DC05E0 Offset: 0x1DC06E1 VA: 0x1DC05E0
	public void set_SilenceCount(int value) { }

	// RVA: 0x1DC0670 Offset: 0x1DC0771 VA: 0x1DC0670
	public int get_FreezeCount() { }

	// RVA: 0x1DC0680 Offset: 0x1DC0781 VA: 0x1DC0680
	public void set_FreezeCount(int value) { }

	// RVA: 0x1DC0710 Offset: 0x1DC0811 VA: 0x1DC0710
	private int Get(uint mask, int shift) { }

	// RVA: 0x1DC0720 Offset: 0x1DC0821 VA: 0x1DC0720
	private void Set(uint mask, int shift, int v) { }
}

// Namespace: 
private struct AIThink.EnchantThink.DMPTResult // TypeDefIndex: 9295
{
	// Fields
	public int moveX; // 0x0
	public int moveZ; // 0x4
	public int targetIndex; // 0x8
	public int targetX; // 0xC
	public int targetZ; // 0x10

	// Methods

	// RVA: 0x1DC01B0 Offset: 0x1DC02B1 VA: 0x1DC01B0
	public void Clear() { }
}

// Namespace: 
private struct AIThink.EnchantThink.Desc // TypeDefIndex: 9296
{
	// Fields
	public int priority; // 0x0
	public AIThink.EnchantThink.CalcUnitScoreFunction CalcUnitScore; // 0x8

	// Methods

	// RVA: 0x1DC01C0 Offset: 0x1DC02C1 VA: 0x1DC01C0
	public void .ctor(int priority, AIThink.EnchantThink.CalcUnitScoreFunction calcUnitScore) { }
}

// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x2753D0 Offset: 0x2754D1 VA: 0x2753D0
private sealed class AIThink.EnchantThink.<>c__DisplayClass14_0 // TypeDefIndex: 9297
{
	// Fields
	public AIThink.EnchantThink <>4__this; // 0x10
	public byte kind; // 0x18
	public UnitItem unitItem; // 0x20
	public int itemInfoIndex; // 0x28
	public bool isTarget; // 0x2C

	// Methods

	// RVA: 0x1DBD120 Offset: 0x1DBD221 VA: 0x1DBD120
	public void .ctor() { }

	// RVA: 0x1DBD130 Offset: 0x1DBD231 VA: 0x1DBD130
	internal void <CanUseItem>b__0(Unit unit) { }
}

// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x2753E0 Offset: 0x2754E1 VA: 0x2753E0
private sealed class AIThink.EnchantThink.<>c__DisplayClass15_0 // TypeDefIndex: 9298
{
	// Fields
	public AIThink.EnchantThink <>4__this; // 0x10
	public byte kind; // 0x18
	public int itemInfoIndex; // 0x1C
	public UnitItem unitItem; // 0x20
	public uint score; // 0x28
	public AIThink.EnchantThink.DMPTResult workResult; // 0x2C

	// Methods

	// RVA: 0x1DBD230 Offset: 0x1DBD331 VA: 0x1DBD230
	public void .ctor() { }

	// RVA: 0x1DBD240 Offset: 0x1DBD341 VA: 0x1DBD240
	internal void <DecideMovePosAndTarget>b__0(int x, int z) { }
}

// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x2753F0 Offset: 0x2754F1 VA: 0x2753F0
private sealed class AIThink.EnchantThink.<>c__DisplayClass21_0 // TypeDefIndex: 9299
{
	// Fields
	public Unit target; // 0x10
	public AIDeploy deploy; // 0x18
	public int targetDef; // 0x20
	public int targetMdef; // 0x24
	public int targetRange; // 0x28
	public AIThink.EnchantThink.SurroundingInfo info; // 0x2C
	public bool targetHasMagicOrRod; // 0x30
	public int targetMovePower; // 0x34

	// Methods

	// RVA: 0x1DBD440 Offset: 0x1DBD541 VA: 0x1DBD440
	public void .ctor() { }

	// RVA: 0x1DBD450 Offset: 0x1DBD551 VA: 0x1DBD450
	internal void <CollectSurroundingInfo>b__0(Unit enemy) { }
}

// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x275400 Offset: 0x275501 VA: 0x275400
private sealed class AIThink.EnchantThink.<>c__DisplayClass21_1 // TypeDefIndex: 9300
{
	// Fields
	public bool enemyCanPhysicalAttack; // 0x10
	public bool enemyCanMagicAttack; // 0x11
	public bool enemyCanUseSilence; // 0x12
	public bool enemyCanUseFreeze; // 0x13
	public bool targetCanAttack; // 0x14
	public AIThink.EnchantThink.<>c__DisplayClass21_0 CS$<>8__locals1; // 0x18

	// Methods

	// RVA: 0x1DBF390 Offset: 0x1DBF491 VA: 0x1DBF390
	public void .ctor() { }

	// RVA: 0x1DBF3A0 Offset: 0x1DBF4A1 VA: 0x1DBF3A0
	internal MapFor.Return <CollectSurroundingInfo>b__1(int x, int z) { }

	// RVA: 0x1DBF4A0 Offset: 0x1DBF5A1 VA: 0x1DBF4A0
	internal MapFor.Return <CollectSurroundingInfo>b__2(int x, int z) { }

	// RVA: 0x1DBF5A0 Offset: 0x1DBF6A1 VA: 0x1DBF5A0
	internal MapFor.Return <CollectSurroundingInfo>b__3(int x, int z) { }

	// RVA: 0x1DBF6A0 Offset: 0x1DBF7A1 VA: 0x1DBF6A0
	internal MapFor.Return <CollectSurroundingInfo>b__4(int x, int z) { }

	// RVA: 0x1DBF7A0 Offset: 0x1DBF8A1 VA: 0x1DBF7A0
	internal MapFor.Return <CollectSurroundingInfo>b__5(int x, int z) { }
}

// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x275410 Offset: 0x275511 VA: 0x275410
private sealed class AIThink.EnchantThink.<>c__DisplayClass39_0 // TypeDefIndex: 9301
{
	// Fields
	public bool isWhole; // 0x10
	public int moveX; // 0x14
	public int moveZ; // 0x18
	public int rangeI; // 0x1C
	public int rangeO; // 0x20
	public Unit actor; // 0x28
	public AIThink.EnchantThink <>4__this; // 0x30
	public int itemInfoIndex; // 0x38
	public uint score; // 0x3C

	// Methods

	// RVA: 0x1DBF8A0 Offset: 0x1DBF9A1 VA: 0x1DBF8A0
	public void .ctor() { }

	// RVA: 0x1DBF8B0 Offset: 0x1DBF9B1 VA: 0x1DBF8B0
	internal void <CalcPosScoreRangeImpl>b__0(Unit unit) { }
}

// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x275420 Offset: 0x275521 VA: 0x275420
private sealed class AIThink.EnchantThink.<>c__DisplayClass40_0 // TypeDefIndex: 9302
{
	// Fields
	public AIThink.EnchantThink <>4__this; // 0x10
	public int itemInfoIndex; // 0x18
	public uint score; // 0x1C
	public Unit workTarget; // 0x20

	// Methods

	// RVA: 0x1DBFBF0 Offset: 0x1DBFCF1 VA: 0x1DBFBF0
	public void .ctor() { }

	// RVA: 0x1DBFC00 Offset: 0x1DBFD01 VA: 0x1DBFC00
	internal void <CalcPosScoreNeighbor>b__0(int x, int z, int range) { }
}

// Namespace: 
private class AIThink.EnchantThink // TypeDefIndex: 9303
{
	// Fields
	private Unit m_Unit; // 0x10
	private AIThink.EnchantThink.ItemInfo[] m_ItemInfos; // 0x18
	private int m_ItemInfoCount; // 0x20
	private Dictionary<int, byte> m_UnitScores; // 0x28
	private Dictionary<int, AIThink.EnchantThink.SurroundingInfo> m_UnitSurroundings; // 0x30
	private static readonly AIThink.EnchantThink.Desc[] Descs; // 0x0

	// Methods

	// RVA: 0x24A15F0 Offset: 0x24A16F1 VA: 0x24A15F0
	public void .ctor() { }

	// RVA: 0x24A1810 Offset: 0x24A1911 VA: 0x24A1810
	public bool Think(Unit unit, bool isEntrust) { }

	// RVA: 0x24A1B40 Offset: 0x24A1C41 VA: 0x24A1B40
	private bool CollectItemInfos() { }

	// RVA: 0x24A23B0 Offset: 0x24A24B1 VA: 0x24A23B0
	private bool CanUseItem(int itemInfoIndex) { }

	// RVA: 0x24A2560 Offset: 0x24A2661 VA: 0x24A2560
	private bool DecideMovePosAndTarget(int itemInfoIndex, ref AIThink.EnchantThink.DMPTResult result) { }

	// RVA: 0x24A1770 Offset: 0x24A1871 VA: 0x24A1770
	private void Reset(Unit unit) { }

	// RVA: 0x24A2700 Offset: 0x24A2801 VA: 0x24A2700
	private void AddItemInfo(int itemIndex, AIThink.EnchantThink.Kinds kind) { }

	// RVA: 0x24A2760 Offset: 0x24A2861 VA: 0x24A2760
	private static int MakeUnitScoreKey(Unit unit, int itemInfoIndex) { }

	// RVA: 0x24A2770 Offset: 0x24A2871 VA: 0x24A2770
	private byte CalcUnitScore(byte kind, Unit target, UnitItem unitItem) { }

	// RVA: 0x24A2870 Offset: 0x24A2971 VA: 0x24A2870
	private uint CalcPosScore(byte kind, int moveX, int moveZ, int move, int itemInfoIndex, UnitItem unitItem, out AIThink.EnchantThink.DMPTResult result) { }

	// RVA: 0x24A2BF0 Offset: 0x24A2CF1 VA: 0x24A2BF0
	private void CollectSurroundingInfo(Unit target) { }

	// RVA: 0x24A3BB0 Offset: 0x24A3CB1 VA: 0x24A3BB0
	private static byte CalcUnitScoreRest(AIThink.EnchantThink think, Unit actor, Unit target, UnitItem unitItem) { }

	// RVA: 0x24A3BE0 Offset: 0x24A3CE1 VA: 0x24A3BE0
	private static byte CalcUnitScoreEngageCount(AIThink.EnchantThink think, Unit actor, Unit target, UnitItem unitItem) { }

	// RVA: 0x24A3CF0 Offset: 0x24A3DF1 VA: 0x24A3CF0
	private static byte CalcUnitScoreEfficacyMorph(AIThink.EnchantThink think, Unit actor, Unit target, UnitItem unitItem) { }

	// RVA: 0x24A3D90 Offset: 0x24A3E91 VA: 0x24A3D90
	private static byte CalcUnitScoreSight(AIThink.EnchantThink think, Unit actor, Unit target, UnitItem unitItem) { }

	// RVA: 0x24A3DA0 Offset: 0x24A3EA1 VA: 0x24A3DA0
	private static byte CalcUnitScoreNoChainAttack(AIThink.EnchantThink think, Unit actor, Unit target, UnitItem unitItem) { }

	// RVA: 0x24A3E40 Offset: 0x24A3F41 VA: 0x24A3E40
	private static byte CalcUnitScoreWeightZero(AIThink.EnchantThink think, Unit actor, Unit target, UnitItem unitItem) { }

	// RVA: 0x24A44E0 Offset: 0x24A45E1 VA: 0x24A44E0
	private static byte CalcUnitScoreNoSilence(AIThink.EnchantThink think, Unit actor, Unit target, UnitItem unitItem) { }

	// RVA: 0x24A4580 Offset: 0x24A4681 VA: 0x24A4580
	private static byte CalcUnitScoreReflectPhysics(AIThink.EnchantThink think, Unit actor, Unit target, UnitItem unitItem) { }

	// RVA: 0x24A4620 Offset: 0x24A4721 VA: 0x24A4620
	private static byte CalcUnitScoreReflectMagic(AIThink.EnchantThink think, Unit actor, Unit target, UnitItem unitItem) { }

	// RVA: 0x24A46C0 Offset: 0x24A47C1 VA: 0x24A46C0
	private static byte CalcUnitScoreNoBreak(AIThink.EnchantThink think, Unit actor, Unit target, UnitItem unitItem) { }

	// RVA: 0x24A4760 Offset: 0x24A4861 VA: 0x24A4760
	private static byte CalcUnitScoreNoFreeze(AIThink.EnchantThink think, Unit actor, Unit target, UnitItem unitItem) { }

	// RVA: 0x24A4800 Offset: 0x24A4901 VA: 0x24A4800
	private static byte CalcUnitScoreNoDamage(AIThink.EnchantThink think, Unit actor, Unit target, UnitItem unitItem) { }

	// RVA: 0x24A48B0 Offset: 0x24A49B1 VA: 0x24A48B0
	private static byte CalcUnitScoreHoldOut(AIThink.EnchantThink think, Unit actor, Unit target, UnitItem unitItem) { }

	// RVA: 0x24A4A70 Offset: 0x24A4B71 VA: 0x24A4A70
	private static byte CalcUnitScoreWeapon(AIThink.EnchantThink think, Unit actor, Unit target, UnitItem unitItem) { }

	// RVA: 0x24A5060 Offset: 0x24A5161 VA: 0x24A5060
	private static byte CalcUnitScoreDummy(AIThink.EnchantThink think, Unit actor, Unit target, UnitItem unitItem) { }

	// RVA: 0x24A2B90 Offset: 0x24A2C91 VA: 0x24A2B90
	private uint CalcPosScoreWhole(Unit actor, int moveX, int moveZ, int move, int itemInfoIndex, UnitItem unitItem, out AIThink.EnchantThink.DMPTResult result) { }

	// RVA: 0x24A2910 Offset: 0x24A2A11 VA: 0x24A2910
	private uint CalcPosScoreRange(Unit actor, int moveX, int moveZ, int move, int itemInfoIndex, UnitItem unitItem, out AIThink.EnchantThink.DMPTResult result) { }

	// RVA: 0x24A5070 Offset: 0x24A5171 VA: 0x24A5070
	private uint CalcPosScoreRangeImpl(Unit actor, int moveX, int moveZ, int move, int itemInfoIndex, UnitItem unitItem, out AIThink.EnchantThink.DMPTResult result, bool isWhole) { }

	// RVA: 0x24A2930 Offset: 0x24A2A31 VA: 0x24A2930
	private uint CalcPosScoreNeighbor(Unit actor, int moveX, int moveZ, int move, int itemInfoIndex, UnitItem unitItem, out AIThink.EnchantThink.DMPTResult result) { }

	// RVA: 0x24A2BC0 Offset: 0x24A2CC1 VA: 0x24A2BC0
	private uint CalcPosScoreDummy(Unit actor, int moveX, int moveZ, int move, int itemInfoIndex, UnitItem unitItem, out AIThink.EnchantThink.DMPTResult result) { }

	// RVA: 0x24A53C0 Offset: 0x24A54C1 VA: 0x24A53C0
	private static void .cctor() { }
}

// Namespace: 
private struct AIThink.OverlapSkills // TypeDefIndex: 9304
{
	// Fields
	private SkillData[] m_Skills; // 0x0
	private int m_Count; // 0x8

	// Properties
	public int Count { get; }

	// Methods

	// RVA: 0x24A6600 Offset: 0x24A6701 VA: 0x24A6600
	public void Prepare() { }

	// RVA: 0x24A66C0 Offset: 0x24A67C1 VA: 0x24A66C0
	public void Add(SkillData skill) { }

	// RVA: 0x24A6770 Offset: 0x24A6871 VA: 0x24A6770
	public SkillData GetByRandom() { }

	// RVA: 0x24A6810 Offset: 0x24A6911 VA: 0x24A6810
	public int get_Count() { }
}

// Namespace: 
public struct AIThink.AttackPositionResult // TypeDefIndex: 9305
{
	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x286F90 Offset: 0x287091 VA: 0x286F90
	private int <MoveX>k__BackingField; // 0x0
	[CompilerGeneratedAttribute] // RVA: 0x286FA0 Offset: 0x2870A1 VA: 0x286FA0
	private int <MoveZ>k__BackingField; // 0x4
	[CompilerGeneratedAttribute] // RVA: 0x286FB0 Offset: 0x2870B1 VA: 0x286FB0
	private int <AttackX>k__BackingField; // 0x8
	[CompilerGeneratedAttribute] // RVA: 0x286FC0 Offset: 0x2870C1 VA: 0x286FC0
	private int <AttackZ>k__BackingField; // 0xC
	[CompilerGeneratedAttribute] // RVA: 0x286FD0 Offset: 0x2870D1 VA: 0x286FD0
	private uint <BlowScore>k__BackingField; // 0x10
	[CompilerGeneratedAttribute] // RVA: 0x286FE0 Offset: 0x2870E1 VA: 0x286FE0
	private int <ChainAttackCount>k__BackingField; // 0x14

	// Properties
	public int MoveX { get; set; }
	public int MoveZ { get; set; }
	public int AttackX { get; set; }
	public int AttackZ { get; set; }
	public uint BlowScore { get; set; }
	public int ChainAttackCount { get; set; }

	// Methods

	[IsReadOnlyAttribute] // RVA: 0x2AF060 Offset: 0x2AF161 VA: 0x2AF060
	[CompilerGeneratedAttribute] // RVA: 0x2AF060 Offset: 0x2AF161 VA: 0x2AF060
	// RVA: 0x24A11E0 Offset: 0x24A12E1 VA: 0x24A11E0
	public int get_MoveX() { }

	[CompilerGeneratedAttribute] // RVA: 0x2AF0A0 Offset: 0x2AF1A1 VA: 0x2AF0A0
	// RVA: 0x24A11F0 Offset: 0x24A12F1 VA: 0x24A11F0
	public void set_MoveX(int value) { }

	[IsReadOnlyAttribute] // RVA: 0x2AF0B0 Offset: 0x2AF1B1 VA: 0x2AF0B0
	[CompilerGeneratedAttribute] // RVA: 0x2AF0B0 Offset: 0x2AF1B1 VA: 0x2AF0B0
	// RVA: 0x24A1200 Offset: 0x24A1301 VA: 0x24A1200
	public int get_MoveZ() { }

	[CompilerGeneratedAttribute] // RVA: 0x2AF0F0 Offset: 0x2AF1F1 VA: 0x2AF0F0
	// RVA: 0x24A1210 Offset: 0x24A1311 VA: 0x24A1210
	public void set_MoveZ(int value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2AF100 Offset: 0x2AF201 VA: 0x2AF100
	[IsReadOnlyAttribute] // RVA: 0x2AF100 Offset: 0x2AF201 VA: 0x2AF100
	// RVA: 0x24A1220 Offset: 0x24A1321 VA: 0x24A1220
	public int get_AttackX() { }

	[CompilerGeneratedAttribute] // RVA: 0x2AF140 Offset: 0x2AF241 VA: 0x2AF140
	// RVA: 0x24A1230 Offset: 0x24A1331 VA: 0x24A1230
	public void set_AttackX(int value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2AF150 Offset: 0x2AF251 VA: 0x2AF150
	[IsReadOnlyAttribute] // RVA: 0x2AF150 Offset: 0x2AF251 VA: 0x2AF150
	// RVA: 0x24A1240 Offset: 0x24A1341 VA: 0x24A1240
	public int get_AttackZ() { }

	[CompilerGeneratedAttribute] // RVA: 0x2AF190 Offset: 0x2AF291 VA: 0x2AF190
	// RVA: 0x24A1250 Offset: 0x24A1351 VA: 0x24A1250
	public void set_AttackZ(int value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2AF1A0 Offset: 0x2AF2A1 VA: 0x2AF1A0
	[IsReadOnlyAttribute] // RVA: 0x2AF1A0 Offset: 0x2AF2A1 VA: 0x2AF1A0
	// RVA: 0x24A1260 Offset: 0x24A1361 VA: 0x24A1260
	public uint get_BlowScore() { }

	[CompilerGeneratedAttribute] // RVA: 0x2AF1E0 Offset: 0x2AF2E1 VA: 0x2AF1E0
	// RVA: 0x24A1270 Offset: 0x24A1371 VA: 0x24A1270
	public void set_BlowScore(uint value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2AF1F0 Offset: 0x2AF2F1 VA: 0x2AF1F0
	[IsReadOnlyAttribute] // RVA: 0x2AF1F0 Offset: 0x2AF2F1 VA: 0x2AF1F0
	// RVA: 0x24A1280 Offset: 0x24A1381 VA: 0x24A1280
	public int get_ChainAttackCount() { }

	[CompilerGeneratedAttribute] // RVA: 0x2AF230 Offset: 0x2AF331 VA: 0x2AF230
	// RVA: 0x24A1290 Offset: 0x24A1391 VA: 0x24A1290
	public void set_ChainAttackCount(int value) { }

	// RVA: 0x24A12A0 Offset: 0x24A13A1 VA: 0x24A12A0
	public void Clear() { }
}

// Namespace: 
private struct AIThink.AttackScoreResult // TypeDefIndex: 9306
{
	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x286FF0 Offset: 0x2870F1 VA: 0x286FF0
	private uint <Score>k__BackingField; // 0x0
	[CompilerGeneratedAttribute] // RVA: 0x287000 Offset: 0x287101 VA: 0x287000
	private int <MoveX>k__BackingField; // 0x4
	[CompilerGeneratedAttribute] // RVA: 0x287010 Offset: 0x287111 VA: 0x287010
	private int <MoveZ>k__BackingField; // 0x8
	[CompilerGeneratedAttribute] // RVA: 0x287020 Offset: 0x287121 VA: 0x287020
	private int <AttackX>k__BackingField; // 0xC
	[CompilerGeneratedAttribute] // RVA: 0x287030 Offset: 0x287131 VA: 0x287030
	private int <AttackZ>k__BackingField; // 0x10
	[CompilerGeneratedAttribute] // RVA: 0x287040 Offset: 0x287141 VA: 0x287040
	private int <ItemIndex>k__BackingField; // 0x14
	[CompilerGeneratedAttribute] // RVA: 0x287050 Offset: 0x287151 VA: 0x287050
	private float <KillRate>k__BackingField; // 0x18
	[CompilerGeneratedAttribute] // RVA: 0x287060 Offset: 0x287161 VA: 0x287060
	private float <DeadRate>k__BackingField; // 0x1C
	[CompilerGeneratedAttribute] // RVA: 0x287070 Offset: 0x287171 VA: 0x287070
	private float <Expectation>k__BackingField; // 0x20
	[CompilerGeneratedAttribute] // RVA: 0x287080 Offset: 0x287181 VA: 0x287080
	private uint <BlowScore>k__BackingField; // 0x24
	[CompilerGeneratedAttribute] // RVA: 0x287090 Offset: 0x287191 VA: 0x287090
	private int <ChainAttackCount>k__BackingField; // 0x28

	// Properties
	public uint Score { get; set; }
	public int MoveX { get; set; }
	public int MoveZ { get; set; }
	public int AttackX { get; set; }
	public int AttackZ { get; set; }
	public int ItemIndex { get; set; }
	public float KillRate { get; set; }
	public float DeadRate { get; set; }
	public float Expectation { get; set; }
	public uint BlowScore { get; set; }
	public int ChainAttackCount { get; set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x2AF240 Offset: 0x2AF341 VA: 0x2AF240
	[IsReadOnlyAttribute] // RVA: 0x2AF240 Offset: 0x2AF341 VA: 0x2AF240
	// RVA: 0x24A12B0 Offset: 0x24A13B1 VA: 0x24A12B0
	public uint get_Score() { }

	[CompilerGeneratedAttribute] // RVA: 0x2AF280 Offset: 0x2AF381 VA: 0x2AF280
	// RVA: 0x24A12C0 Offset: 0x24A13C1 VA: 0x24A12C0
	public void set_Score(uint value) { }

	[IsReadOnlyAttribute] // RVA: 0x2AF290 Offset: 0x2AF391 VA: 0x2AF290
	[CompilerGeneratedAttribute] // RVA: 0x2AF290 Offset: 0x2AF391 VA: 0x2AF290
	// RVA: 0x24A12D0 Offset: 0x24A13D1 VA: 0x24A12D0
	public int get_MoveX() { }

	[CompilerGeneratedAttribute] // RVA: 0x2AF2D0 Offset: 0x2AF3D1 VA: 0x2AF2D0
	// RVA: 0x24A12E0 Offset: 0x24A13E1 VA: 0x24A12E0
	public void set_MoveX(int value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2AF2E0 Offset: 0x2AF3E1 VA: 0x2AF2E0
	[IsReadOnlyAttribute] // RVA: 0x2AF2E0 Offset: 0x2AF3E1 VA: 0x2AF2E0
	// RVA: 0x24A12F0 Offset: 0x24A13F1 VA: 0x24A12F0
	public int get_MoveZ() { }

	[CompilerGeneratedAttribute] // RVA: 0x2AF320 Offset: 0x2AF421 VA: 0x2AF320
	// RVA: 0x24A1300 Offset: 0x24A1401 VA: 0x24A1300
	public void set_MoveZ(int value) { }

	[IsReadOnlyAttribute] // RVA: 0x2AF330 Offset: 0x2AF431 VA: 0x2AF330
	[CompilerGeneratedAttribute] // RVA: 0x2AF330 Offset: 0x2AF431 VA: 0x2AF330
	// RVA: 0x24A1310 Offset: 0x24A1411 VA: 0x24A1310
	public int get_AttackX() { }

	[CompilerGeneratedAttribute] // RVA: 0x2AF370 Offset: 0x2AF471 VA: 0x2AF370
	// RVA: 0x24A1320 Offset: 0x24A1421 VA: 0x24A1320
	public void set_AttackX(int value) { }

	[IsReadOnlyAttribute] // RVA: 0x2AF380 Offset: 0x2AF481 VA: 0x2AF380
	[CompilerGeneratedAttribute] // RVA: 0x2AF380 Offset: 0x2AF481 VA: 0x2AF380
	// RVA: 0x24A1330 Offset: 0x24A1431 VA: 0x24A1330
	public int get_AttackZ() { }

	[CompilerGeneratedAttribute] // RVA: 0x2AF3C0 Offset: 0x2AF4C1 VA: 0x2AF3C0
	// RVA: 0x24A1340 Offset: 0x24A1441 VA: 0x24A1340
	public void set_AttackZ(int value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2AF3D0 Offset: 0x2AF4D1 VA: 0x2AF3D0
	[IsReadOnlyAttribute] // RVA: 0x2AF3D0 Offset: 0x2AF4D1 VA: 0x2AF3D0
	// RVA: 0x24A1350 Offset: 0x24A1451 VA: 0x24A1350
	public int get_ItemIndex() { }

	[CompilerGeneratedAttribute] // RVA: 0x2AF410 Offset: 0x2AF511 VA: 0x2AF410
	// RVA: 0x24A1360 Offset: 0x24A1461 VA: 0x24A1360
	public void set_ItemIndex(int value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2AF420 Offset: 0x2AF521 VA: 0x2AF420
	[IsReadOnlyAttribute] // RVA: 0x2AF420 Offset: 0x2AF521 VA: 0x2AF420
	// RVA: 0x24A1370 Offset: 0x24A1471 VA: 0x24A1370
	public float get_KillRate() { }

	[CompilerGeneratedAttribute] // RVA: 0x2AF460 Offset: 0x2AF561 VA: 0x2AF460
	// RVA: 0x24A1380 Offset: 0x24A1481 VA: 0x24A1380
	public void set_KillRate(float value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2AF470 Offset: 0x2AF571 VA: 0x2AF470
	[IsReadOnlyAttribute] // RVA: 0x2AF470 Offset: 0x2AF571 VA: 0x2AF470
	// RVA: 0x24A1390 Offset: 0x24A1491 VA: 0x24A1390
	public float get_DeadRate() { }

	[CompilerGeneratedAttribute] // RVA: 0x2AF4B0 Offset: 0x2AF5B1 VA: 0x2AF4B0
	// RVA: 0x24A13A0 Offset: 0x24A14A1 VA: 0x24A13A0
	public void set_DeadRate(float value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2AF4C0 Offset: 0x2AF5C1 VA: 0x2AF4C0
	[IsReadOnlyAttribute] // RVA: 0x2AF4C0 Offset: 0x2AF5C1 VA: 0x2AF4C0
	// RVA: 0x24A13B0 Offset: 0x24A14B1 VA: 0x24A13B0
	public float get_Expectation() { }

	[CompilerGeneratedAttribute] // RVA: 0x2AF500 Offset: 0x2AF601 VA: 0x2AF500
	// RVA: 0x24A13C0 Offset: 0x24A14C1 VA: 0x24A13C0
	public void set_Expectation(float value) { }

	[IsReadOnlyAttribute] // RVA: 0x2AF510 Offset: 0x2AF611 VA: 0x2AF510
	[CompilerGeneratedAttribute] // RVA: 0x2AF510 Offset: 0x2AF611 VA: 0x2AF510
	// RVA: 0x24A13D0 Offset: 0x24A14D1 VA: 0x24A13D0
	public uint get_BlowScore() { }

	[CompilerGeneratedAttribute] // RVA: 0x2AF550 Offset: 0x2AF651 VA: 0x2AF550
	// RVA: 0x24A13E0 Offset: 0x24A14E1 VA: 0x24A13E0
	public void set_BlowScore(uint value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2AF560 Offset: 0x2AF661 VA: 0x2AF560
	[IsReadOnlyAttribute] // RVA: 0x2AF560 Offset: 0x2AF661 VA: 0x2AF560
	// RVA: 0x24A13F0 Offset: 0x24A14F1 VA: 0x24A13F0
	public int get_ChainAttackCount() { }

	[CompilerGeneratedAttribute] // RVA: 0x2AF5A0 Offset: 0x2AF6A1 VA: 0x2AF5A0
	// RVA: 0x24A1400 Offset: 0x24A1501 VA: 0x24A1400
	public void set_ChainAttackCount(int value) { }

	// RVA: 0x24A1410 Offset: 0x24A1511 VA: 0x24A1410
	public void Clear() { }
}

// Namespace: 
private struct AIThink.AttackTarget // TypeDefIndex: 9307
{
	// Fields
	public AIThink.AttackScoreResult ASResult; // 0x0
	[CompilerGeneratedAttribute] // RVA: 0x2870A0 Offset: 0x2871A1 VA: 0x2870A0
	private Unit <Unit>k__BackingField; // 0x30
	[CompilerGeneratedAttribute] // RVA: 0x2870B0 Offset: 0x2871B1 VA: 0x2870B0
	private int <X>k__BackingField; // 0x38
	[CompilerGeneratedAttribute] // RVA: 0x2870C0 Offset: 0x2871C1 VA: 0x2870C0
	private int <Z>k__BackingField; // 0x3C

	// Properties
	public Unit Unit { get; set; }
	public int X { get; set; }
	public int Z { get; set; }
	public uint Score { get; }
	public int MoveX { get; }
	public int MoveZ { get; }
	public int AttackX { get; }
	public int AttackZ { get; }
	public int ItemIndex { get; }
	public float KillRate { get; }
	public float DeadRate { get; }
	public float Expectation { get; }
	public uint BlowScore { get; }
	public int ChainAttackCount { get; }

	// Methods

	[IsReadOnlyAttribute] // RVA: 0x2AF5B0 Offset: 0x2AF6B1 VA: 0x2AF5B0
	[CompilerGeneratedAttribute] // RVA: 0x2AF5B0 Offset: 0x2AF6B1 VA: 0x2AF5B0
	// RVA: 0x24A1430 Offset: 0x24A1531 VA: 0x24A1430
	public Unit get_Unit() { }

	[CompilerGeneratedAttribute] // RVA: 0x2AF5F0 Offset: 0x2AF6F1 VA: 0x2AF5F0
	// RVA: 0x24A1440 Offset: 0x24A1541 VA: 0x24A1440
	public void set_Unit(Unit value) { }

	[IsReadOnlyAttribute] // RVA: 0x2AF600 Offset: 0x2AF701 VA: 0x2AF600
	[CompilerGeneratedAttribute] // RVA: 0x2AF600 Offset: 0x2AF701 VA: 0x2AF600
	// RVA: 0x24A1450 Offset: 0x24A1551 VA: 0x24A1450
	public int get_X() { }

	[CompilerGeneratedAttribute] // RVA: 0x2AF640 Offset: 0x2AF741 VA: 0x2AF640
	// RVA: 0x24A1460 Offset: 0x24A1561 VA: 0x24A1460
	public void set_X(int value) { }

	[IsReadOnlyAttribute] // RVA: 0x2AF650 Offset: 0x2AF751 VA: 0x2AF650
	[CompilerGeneratedAttribute] // RVA: 0x2AF650 Offset: 0x2AF751 VA: 0x2AF650
	// RVA: 0x24A1470 Offset: 0x24A1571 VA: 0x24A1470
	public int get_Z() { }

	[CompilerGeneratedAttribute] // RVA: 0x2AF690 Offset: 0x2AF791 VA: 0x2AF690
	// RVA: 0x24A1480 Offset: 0x24A1581 VA: 0x24A1480
	public void set_Z(int value) { }

	// RVA: 0x24A1490 Offset: 0x24A1591 VA: 0x24A1490
	public uint get_Score() { }

	// RVA: 0x24A14A0 Offset: 0x24A15A1 VA: 0x24A14A0
	public int get_MoveX() { }

	// RVA: 0x24A14B0 Offset: 0x24A15B1 VA: 0x24A14B0
	public int get_MoveZ() { }

	// RVA: 0x24A14C0 Offset: 0x24A15C1 VA: 0x24A14C0
	public int get_AttackX() { }

	// RVA: 0x24A14D0 Offset: 0x24A15D1 VA: 0x24A14D0
	public int get_AttackZ() { }

	// RVA: 0x24A14E0 Offset: 0x24A15E1 VA: 0x24A14E0
	public int get_ItemIndex() { }

	// RVA: 0x24A14F0 Offset: 0x24A15F1 VA: 0x24A14F0
	public float get_KillRate() { }

	// RVA: 0x24A1500 Offset: 0x24A1601 VA: 0x24A1500
	public float get_DeadRate() { }

	// RVA: 0x24A1510 Offset: 0x24A1611 VA: 0x24A1510
	public float get_Expectation() { }

	// RVA: 0x24A1520 Offset: 0x24A1621 VA: 0x24A1520
	public uint get_BlowScore() { }

	// RVA: 0x24A1530 Offset: 0x24A1631 VA: 0x24A1530
	public int get_ChainAttackCount() { }

	// RVA: 0x24A1540 Offset: 0x24A1641 VA: 0x24A1540
	public void Clear() { }

	// RVA: 0x24A1590 Offset: 0x24A1691 VA: 0x24A1590
	public static void New(out AIThink.AttackTarget inst) { }
}

// Namespace: 
private struct AIThink.HealRodPositionResult // TypeDefIndex: 9308
{
	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x2870D0 Offset: 0x2871D1 VA: 0x2870D0
	private int <MoveX>k__BackingField; // 0x0
	[CompilerGeneratedAttribute] // RVA: 0x2870E0 Offset: 0x2871E1 VA: 0x2870E0
	private int <MoveZ>k__BackingField; // 0x4
	[CompilerGeneratedAttribute] // RVA: 0x2870F0 Offset: 0x2871F1 VA: 0x2870F0
	private int <AttackX>k__BackingField; // 0x8
	[CompilerGeneratedAttribute] // RVA: 0x287100 Offset: 0x287201 VA: 0x287100
	private int <AttackZ>k__BackingField; // 0xC

	// Properties
	public int MoveX { get; set; }
	public int MoveZ { get; set; }
	public int AttackX { get; set; }
	public int AttackZ { get; set; }

	// Methods

	[IsReadOnlyAttribute] // RVA: 0x2AF6A0 Offset: 0x2AF7A1 VA: 0x2AF6A0
	[CompilerGeneratedAttribute] // RVA: 0x2AF6A0 Offset: 0x2AF7A1 VA: 0x2AF6A0
	// RVA: 0x24A61E0 Offset: 0x24A62E1 VA: 0x24A61E0
	public int get_MoveX() { }

	[CompilerGeneratedAttribute] // RVA: 0x2AF6E0 Offset: 0x2AF7E1 VA: 0x2AF6E0
	// RVA: 0x24A61F0 Offset: 0x24A62F1 VA: 0x24A61F0
	public void set_MoveX(int value) { }

	[IsReadOnlyAttribute] // RVA: 0x2AF6F0 Offset: 0x2AF7F1 VA: 0x2AF6F0
	[CompilerGeneratedAttribute] // RVA: 0x2AF6F0 Offset: 0x2AF7F1 VA: 0x2AF6F0
	// RVA: 0x24A6200 Offset: 0x24A6301 VA: 0x24A6200
	public int get_MoveZ() { }

	[CompilerGeneratedAttribute] // RVA: 0x2AF730 Offset: 0x2AF831 VA: 0x2AF730
	// RVA: 0x24A6210 Offset: 0x24A6311 VA: 0x24A6210
	public void set_MoveZ(int value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2AF740 Offset: 0x2AF841 VA: 0x2AF740
	[IsReadOnlyAttribute] // RVA: 0x2AF740 Offset: 0x2AF841 VA: 0x2AF740
	// RVA: 0x24A6220 Offset: 0x24A6321 VA: 0x24A6220
	public int get_AttackX() { }

	[CompilerGeneratedAttribute] // RVA: 0x2AF780 Offset: 0x2AF881 VA: 0x2AF780
	// RVA: 0x24A6230 Offset: 0x24A6331 VA: 0x24A6230
	public void set_AttackX(int value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2AF790 Offset: 0x2AF891 VA: 0x2AF790
	[IsReadOnlyAttribute] // RVA: 0x2AF790 Offset: 0x2AF891 VA: 0x2AF790
	// RVA: 0x24A6240 Offset: 0x24A6341 VA: 0x24A6240
	public int get_AttackZ() { }

	[CompilerGeneratedAttribute] // RVA: 0x2AF7D0 Offset: 0x2AF8D1 VA: 0x2AF7D0
	// RVA: 0x24A6250 Offset: 0x24A6351 VA: 0x24A6250
	public void set_AttackZ(int value) { }

	// RVA: 0x24A6260 Offset: 0x24A6361 VA: 0x24A6260
	public void Clear() { }
}

// Namespace: 
private struct AIThink.HealRodScoreImplResult // TypeDefIndex: 9309
{
	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x287110 Offset: 0x287211 VA: 0x287110
	private int <MoveX>k__BackingField; // 0x0
	[CompilerGeneratedAttribute] // RVA: 0x287120 Offset: 0x287221 VA: 0x287120
	private int <MoveZ>k__BackingField; // 0x4
	[CompilerGeneratedAttribute] // RVA: 0x287130 Offset: 0x287231 VA: 0x287130
	private int <AttackX>k__BackingField; // 0x8
	[CompilerGeneratedAttribute] // RVA: 0x287140 Offset: 0x287241 VA: 0x287140
	private int <AttackZ>k__BackingField; // 0xC
	[CompilerGeneratedAttribute] // RVA: 0x287150 Offset: 0x287251 VA: 0x287150
	private int <Heal>k__BackingField; // 0x10
	[CompilerGeneratedAttribute] // RVA: 0x287160 Offset: 0x287261 VA: 0x287160
	private int <Damage>k__BackingField; // 0x14

	// Properties
	public int MoveX { get; set; }
	public int MoveZ { get; set; }
	public int AttackX { get; set; }
	public int AttackZ { get; set; }
	public int Heal { get; set; }
	public int Damage { get; set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x2AF7E0 Offset: 0x2AF8E1 VA: 0x2AF7E0
	[IsReadOnlyAttribute] // RVA: 0x2AF7E0 Offset: 0x2AF8E1 VA: 0x2AF7E0
	// RVA: 0x24A6270 Offset: 0x24A6371 VA: 0x24A6270
	public int get_MoveX() { }

	[CompilerGeneratedAttribute] // RVA: 0x2AF820 Offset: 0x2AF921 VA: 0x2AF820
	// RVA: 0x24A6280 Offset: 0x24A6381 VA: 0x24A6280
	public void set_MoveX(int value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2AF830 Offset: 0x2AF931 VA: 0x2AF830
	[IsReadOnlyAttribute] // RVA: 0x2AF830 Offset: 0x2AF931 VA: 0x2AF830
	// RVA: 0x24A6290 Offset: 0x24A6391 VA: 0x24A6290
	public int get_MoveZ() { }

	[CompilerGeneratedAttribute] // RVA: 0x2AF870 Offset: 0x2AF971 VA: 0x2AF870
	// RVA: 0x24A62A0 Offset: 0x24A63A1 VA: 0x24A62A0
	public void set_MoveZ(int value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2AF880 Offset: 0x2AF981 VA: 0x2AF880
	[IsReadOnlyAttribute] // RVA: 0x2AF880 Offset: 0x2AF981 VA: 0x2AF880
	// RVA: 0x24A62B0 Offset: 0x24A63B1 VA: 0x24A62B0
	public int get_AttackX() { }

	[CompilerGeneratedAttribute] // RVA: 0x2AF8C0 Offset: 0x2AF9C1 VA: 0x2AF8C0
	// RVA: 0x24A62C0 Offset: 0x24A63C1 VA: 0x24A62C0
	public void set_AttackX(int value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2AF8D0 Offset: 0x2AF9D1 VA: 0x2AF8D0
	[IsReadOnlyAttribute] // RVA: 0x2AF8D0 Offset: 0x2AF9D1 VA: 0x2AF8D0
	// RVA: 0x24A62D0 Offset: 0x24A63D1 VA: 0x24A62D0
	public int get_AttackZ() { }

	[CompilerGeneratedAttribute] // RVA: 0x2AF910 Offset: 0x2AFA11 VA: 0x2AF910
	// RVA: 0x24A62E0 Offset: 0x24A63E1 VA: 0x24A62E0
	public void set_AttackZ(int value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2AF920 Offset: 0x2AFA21 VA: 0x2AF920
	[IsReadOnlyAttribute] // RVA: 0x2AF920 Offset: 0x2AFA21 VA: 0x2AF920
	// RVA: 0x24A62F0 Offset: 0x24A63F1 VA: 0x24A62F0
	public int get_Heal() { }

	[CompilerGeneratedAttribute] // RVA: 0x2AF960 Offset: 0x2AFA61 VA: 0x2AF960
	// RVA: 0x24A6300 Offset: 0x24A6401 VA: 0x24A6300
	public void set_Heal(int value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2AF970 Offset: 0x2AFA71 VA: 0x2AF970
	[IsReadOnlyAttribute] // RVA: 0x2AF970 Offset: 0x2AFA71 VA: 0x2AF970
	// RVA: 0x24A6310 Offset: 0x24A6411 VA: 0x24A6310
	public int get_Damage() { }

	[CompilerGeneratedAttribute] // RVA: 0x2AF9B0 Offset: 0x2AFAB1 VA: 0x2AF9B0
	// RVA: 0x24A6320 Offset: 0x24A6421 VA: 0x24A6320
	public void set_Damage(int value) { }

	// RVA: 0x24A6330 Offset: 0x24A6431 VA: 0x24A6330
	public void Clear() { }
}

// Namespace: 
private struct AIThink.HealRodScoreResult // TypeDefIndex: 9310
{
	// Fields
	public AIThink.HealRodScoreImplResult HRSIResult; // 0x0
	[CompilerGeneratedAttribute] // RVA: 0x287170 Offset: 0x287271 VA: 0x287170
	private uint <Score>k__BackingField; // 0x18
	[CompilerGeneratedAttribute] // RVA: 0x287180 Offset: 0x287281 VA: 0x287180
	private int <ItemIndex>k__BackingField; // 0x1C

	// Properties
	public uint Score { get; set; }
	public int ItemIndex { get; set; }
	public int MoveX { get; }
	public int MoveZ { get; }
	public int AttackX { get; }
	public int AttackZ { get; }
	public int Heal { get; }
	public int Damage { get; }

	// Methods

	[IsReadOnlyAttribute] // RVA: 0x2AF9C0 Offset: 0x2AFAC1 VA: 0x2AF9C0
	[CompilerGeneratedAttribute] // RVA: 0x2AF9C0 Offset: 0x2AFAC1 VA: 0x2AF9C0
	// RVA: 0x24A6340 Offset: 0x24A6441 VA: 0x24A6340
	public uint get_Score() { }

	[CompilerGeneratedAttribute] // RVA: 0x2AFA00 Offset: 0x2AFB01 VA: 0x2AFA00
	// RVA: 0x24A6350 Offset: 0x24A6451 VA: 0x24A6350
	public void set_Score(uint value) { }

	[IsReadOnlyAttribute] // RVA: 0x2AFA10 Offset: 0x2AFB11 VA: 0x2AFA10
	[CompilerGeneratedAttribute] // RVA: 0x2AFA10 Offset: 0x2AFB11 VA: 0x2AFA10
	// RVA: 0x24A6360 Offset: 0x24A6461 VA: 0x24A6360
	public int get_ItemIndex() { }

	[CompilerGeneratedAttribute] // RVA: 0x2AFA50 Offset: 0x2AFB51 VA: 0x2AFA50
	// RVA: 0x24A6370 Offset: 0x24A6471 VA: 0x24A6370
	public void set_ItemIndex(int value) { }

	// RVA: 0x249DCB0 Offset: 0x249DDB1 VA: 0x249DCB0
	public int get_MoveX() { }

	// RVA: 0x249DCC0 Offset: 0x249DDC1 VA: 0x249DCC0
	public int get_MoveZ() { }

	// RVA: 0x249DCD0 Offset: 0x249DDD1 VA: 0x249DCD0
	public int get_AttackX() { }

	// RVA: 0x249DCE0 Offset: 0x249DDE1 VA: 0x249DCE0
	public int get_AttackZ() { }

	// RVA: 0x24A6380 Offset: 0x24A6481 VA: 0x24A6380
	public int get_Heal() { }

	// RVA: 0x24A6390 Offset: 0x24A6491 VA: 0x24A6390
	public int get_Damage() { }

	// RVA: 0x24A63A0 Offset: 0x24A64A1 VA: 0x24A63A0
	public void Clear() { }
}

// Namespace: 
private struct AIThink.WarpRodEvaluationResult // TypeDefIndex: 9311
{
	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x287190 Offset: 0x287291 VA: 0x287190
	private int <MoveX>k__BackingField; // 0x0
	[CompilerGeneratedAttribute] // RVA: 0x2871A0 Offset: 0x2872A1 VA: 0x2871A0
	private int <MoveZ>k__BackingField; // 0x4
	[CompilerGeneratedAttribute] // RVA: 0x2871B0 Offset: 0x2872B1 VA: 0x2871B0
	private int <AttackX>k__BackingField; // 0x8
	[CompilerGeneratedAttribute] // RVA: 0x2871C0 Offset: 0x2872C1 VA: 0x2871C0
	private int <AttackZ>k__BackingField; // 0xC
	[CompilerGeneratedAttribute] // RVA: 0x2871D0 Offset: 0x2872D1 VA: 0x2871D0
	private int <WarpX>k__BackingField; // 0x10
	[CompilerGeneratedAttribute] // RVA: 0x2871E0 Offset: 0x2872E1 VA: 0x2871E0
	private int <WarpZ>k__BackingField; // 0x14
	[CompilerGeneratedAttribute] // RVA: 0x2871F0 Offset: 0x2872F1 VA: 0x2871F0
	private int <MoveDist>k__BackingField; // 0x18
	[CompilerGeneratedAttribute] // RVA: 0x287200 Offset: 0x287301 VA: 0x287200
	private int <EnemyDist>k__BackingField; // 0x1C

	// Properties
	public int MoveX { get; set; }
	public int MoveZ { get; set; }
	public int AttackX { get; set; }
	public int AttackZ { get; set; }
	public int WarpX { get; set; }
	public int WarpZ { get; set; }
	public int MoveDist { get; set; }
	public int EnemyDist { get; set; }

	// Methods

	[IsReadOnlyAttribute] // RVA: 0x2AFA60 Offset: 0x2AFB61 VA: 0x2AFA60
	[CompilerGeneratedAttribute] // RVA: 0x2AFA60 Offset: 0x2AFB61 VA: 0x2AFA60
	// RVA: 0x24A7440 Offset: 0x24A7541 VA: 0x24A7440
	public int get_MoveX() { }

	[CompilerGeneratedAttribute] // RVA: 0x2AFAA0 Offset: 0x2AFBA1 VA: 0x2AFAA0
	// RVA: 0x24A7450 Offset: 0x24A7551 VA: 0x24A7450
	public void set_MoveX(int value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2AFAB0 Offset: 0x2AFBB1 VA: 0x2AFAB0
	[IsReadOnlyAttribute] // RVA: 0x2AFAB0 Offset: 0x2AFBB1 VA: 0x2AFAB0
	// RVA: 0x24A7460 Offset: 0x24A7561 VA: 0x24A7460
	public int get_MoveZ() { }

	[CompilerGeneratedAttribute] // RVA: 0x2AFAF0 Offset: 0x2AFBF1 VA: 0x2AFAF0
	// RVA: 0x24A7470 Offset: 0x24A7571 VA: 0x24A7470
	public void set_MoveZ(int value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2AFB00 Offset: 0x2AFC01 VA: 0x2AFB00
	[IsReadOnlyAttribute] // RVA: 0x2AFB00 Offset: 0x2AFC01 VA: 0x2AFB00
	// RVA: 0x24A7480 Offset: 0x24A7581 VA: 0x24A7480
	public int get_AttackX() { }

	[CompilerGeneratedAttribute] // RVA: 0x2AFB40 Offset: 0x2AFC41 VA: 0x2AFB40
	// RVA: 0x24A7490 Offset: 0x24A7591 VA: 0x24A7490
	public void set_AttackX(int value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2AFB50 Offset: 0x2AFC51 VA: 0x2AFB50
	[IsReadOnlyAttribute] // RVA: 0x2AFB50 Offset: 0x2AFC51 VA: 0x2AFB50
	// RVA: 0x24A74A0 Offset: 0x24A75A1 VA: 0x24A74A0
	public int get_AttackZ() { }

	[CompilerGeneratedAttribute] // RVA: 0x2AFB90 Offset: 0x2AFC91 VA: 0x2AFB90
	// RVA: 0x24A74B0 Offset: 0x24A75B1 VA: 0x24A74B0
	public void set_AttackZ(int value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2AFBA0 Offset: 0x2AFCA1 VA: 0x2AFBA0
	[IsReadOnlyAttribute] // RVA: 0x2AFBA0 Offset: 0x2AFCA1 VA: 0x2AFBA0
	// RVA: 0x24A74C0 Offset: 0x24A75C1 VA: 0x24A74C0
	public int get_WarpX() { }

	[CompilerGeneratedAttribute] // RVA: 0x2AFBE0 Offset: 0x2AFCE1 VA: 0x2AFBE0
	// RVA: 0x24A74D0 Offset: 0x24A75D1 VA: 0x24A74D0
	public void set_WarpX(int value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2AFBF0 Offset: 0x2AFCF1 VA: 0x2AFBF0
	[IsReadOnlyAttribute] // RVA: 0x2AFBF0 Offset: 0x2AFCF1 VA: 0x2AFBF0
	// RVA: 0x24A74E0 Offset: 0x24A75E1 VA: 0x24A74E0
	public int get_WarpZ() { }

	[CompilerGeneratedAttribute] // RVA: 0x2AFC30 Offset: 0x2AFD31 VA: 0x2AFC30
	// RVA: 0x24A74F0 Offset: 0x24A75F1 VA: 0x24A74F0
	public void set_WarpZ(int value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2AFC40 Offset: 0x2AFD41 VA: 0x2AFC40
	[IsReadOnlyAttribute] // RVA: 0x2AFC40 Offset: 0x2AFD41 VA: 0x2AFC40
	// RVA: 0x24A7500 Offset: 0x24A7601 VA: 0x24A7500
	public int get_MoveDist() { }

	[CompilerGeneratedAttribute] // RVA: 0x2AFC80 Offset: 0x2AFD81 VA: 0x2AFC80
	// RVA: 0x24A7510 Offset: 0x24A7611 VA: 0x24A7510
	public void set_MoveDist(int value) { }

	[IsReadOnlyAttribute] // RVA: 0x2AFC90 Offset: 0x2AFD91 VA: 0x2AFC90
	[CompilerGeneratedAttribute] // RVA: 0x2AFC90 Offset: 0x2AFD91 VA: 0x2AFC90
	// RVA: 0x24A7520 Offset: 0x24A7621 VA: 0x24A7520
	public int get_EnemyDist() { }

	[CompilerGeneratedAttribute] // RVA: 0x2AFCD0 Offset: 0x2AFDD1 VA: 0x2AFCD0
	// RVA: 0x24A7530 Offset: 0x24A7631 VA: 0x24A7530
	public void set_EnemyDist(int value) { }

	// RVA: 0x24A7540 Offset: 0x24A7641 VA: 0x24A7540
	public void Clear() { }
}

// Namespace: 
private struct AIThink.WarpRodTarget // TypeDefIndex: 9312
{
	// Fields
	public AIThink.WarpRodEvaluationResult WREResult; // 0x0
	[CompilerGeneratedAttribute] // RVA: 0x287210 Offset: 0x287311 VA: 0x287210
	private Unit <Unit>k__BackingField; // 0x20
	[CompilerGeneratedAttribute] // RVA: 0x287220 Offset: 0x287321 VA: 0x287220
	private uint <Score>k__BackingField; // 0x28

	// Properties
	public Unit Unit { get; set; }
	public uint Score { get; set; }
	public int MoveX { get; }
	public int MoveZ { get; }
	public int AttackX { get; }
	public int AttackZ { get; }
	public int WarpX { get; }
	public int WarpZ { get; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x2AFCE0 Offset: 0x2AFDE1 VA: 0x2AFCE0
	[IsReadOnlyAttribute] // RVA: 0x2AFCE0 Offset: 0x2AFDE1 VA: 0x2AFCE0
	// RVA: 0x24A7560 Offset: 0x24A7661 VA: 0x24A7560
	public Unit get_Unit() { }

	[CompilerGeneratedAttribute] // RVA: 0x2AFD20 Offset: 0x2AFE21 VA: 0x2AFD20
	// RVA: 0x24A7570 Offset: 0x24A7671 VA: 0x24A7570
	public void set_Unit(Unit value) { }

	[IsReadOnlyAttribute] // RVA: 0x2AFD30 Offset: 0x2AFE31 VA: 0x2AFD30
	[CompilerGeneratedAttribute] // RVA: 0x2AFD30 Offset: 0x2AFE31 VA: 0x2AFD30
	// RVA: 0x24A7580 Offset: 0x24A7681 VA: 0x24A7580
	public uint get_Score() { }

	[CompilerGeneratedAttribute] // RVA: 0x2AFD70 Offset: 0x2AFE71 VA: 0x2AFD70
	// RVA: 0x24A7590 Offset: 0x24A7691 VA: 0x24A7590
	public void set_Score(uint value) { }

	// RVA: 0x24A75A0 Offset: 0x24A76A1 VA: 0x24A75A0
	public int get_MoveX() { }

	// RVA: 0x24A75B0 Offset: 0x24A76B1 VA: 0x24A75B0
	public int get_MoveZ() { }

	// RVA: 0x24A75C0 Offset: 0x24A76C1 VA: 0x24A75C0
	public int get_AttackX() { }

	// RVA: 0x24A75D0 Offset: 0x24A76D1 VA: 0x24A75D0
	public int get_AttackZ() { }

	// RVA: 0x24A75E0 Offset: 0x24A76E1 VA: 0x24A75E0
	public int get_WarpX() { }

	// RVA: 0x24A75F0 Offset: 0x24A76F1 VA: 0x24A75F0
	public int get_WarpZ() { }

	// RVA: 0x24A7600 Offset: 0x24A7701 VA: 0x24A7600
	public void Clear() { }

	// RVA: 0x24A7640 Offset: 0x24A7741 VA: 0x24A7640
	public static void New(out AIThink.WarpRodTarget inst) { }
}

// Namespace: 
private struct AIThink.RescueRodScoreResult // TypeDefIndex: 9313
{
	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x287230 Offset: 0x287331 VA: 0x287230
	private uint <Score>k__BackingField; // 0x0
	[CompilerGeneratedAttribute] // RVA: 0x287240 Offset: 0x287341 VA: 0x287240
	private int <MoveX>k__BackingField; // 0x4
	[CompilerGeneratedAttribute] // RVA: 0x287250 Offset: 0x287351 VA: 0x287250
	private int <MoveZ>k__BackingField; // 0x8
	[CompilerGeneratedAttribute] // RVA: 0x287260 Offset: 0x287361 VA: 0x287260
	private int <AttackX>k__BackingField; // 0xC
	[CompilerGeneratedAttribute] // RVA: 0x287270 Offset: 0x287371 VA: 0x287270
	private int <AttackZ>k__BackingField; // 0x10

	// Properties
	public uint Score { get; set; }
	public int MoveX { get; set; }
	public int MoveZ { get; set; }
	public int AttackX { get; set; }
	public int AttackZ { get; set; }

	// Methods

	[IsReadOnlyAttribute] // RVA: 0x2AFD80 Offset: 0x2AFE81 VA: 0x2AFD80
	[CompilerGeneratedAttribute] // RVA: 0x2AFD80 Offset: 0x2AFE81 VA: 0x2AFD80
	// RVA: 0x24A6B80 Offset: 0x24A6C81 VA: 0x24A6B80
	public uint get_Score() { }

	[CompilerGeneratedAttribute] // RVA: 0x2AFDC0 Offset: 0x2AFEC1 VA: 0x2AFDC0
	// RVA: 0x24A6B90 Offset: 0x24A6C91 VA: 0x24A6B90
	public void set_Score(uint value) { }

	[IsReadOnlyAttribute] // RVA: 0x2AFDD0 Offset: 0x2AFED1 VA: 0x2AFDD0
	[CompilerGeneratedAttribute] // RVA: 0x2AFDD0 Offset: 0x2AFED1 VA: 0x2AFDD0
	// RVA: 0x24A6BA0 Offset: 0x24A6CA1 VA: 0x24A6BA0
	public int get_MoveX() { }

	[CompilerGeneratedAttribute] // RVA: 0x2AFE10 Offset: 0x2AFF11 VA: 0x2AFE10
	// RVA: 0x24A6BB0 Offset: 0x24A6CB1 VA: 0x24A6BB0
	public void set_MoveX(int value) { }

	[IsReadOnlyAttribute] // RVA: 0x2AFE20 Offset: 0x2AFF21 VA: 0x2AFE20
	[CompilerGeneratedAttribute] // RVA: 0x2AFE20 Offset: 0x2AFF21 VA: 0x2AFE20
	// RVA: 0x24A6BC0 Offset: 0x24A6CC1 VA: 0x24A6BC0
	public int get_MoveZ() { }

	[CompilerGeneratedAttribute] // RVA: 0x2AFE60 Offset: 0x2AFF61 VA: 0x2AFE60
	// RVA: 0x24A6BD0 Offset: 0x24A6CD1 VA: 0x24A6BD0
	public void set_MoveZ(int value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2AFE70 Offset: 0x2AFF71 VA: 0x2AFE70
	[IsReadOnlyAttribute] // RVA: 0x2AFE70 Offset: 0x2AFF71 VA: 0x2AFE70
	// RVA: 0x24A6BE0 Offset: 0x24A6CE1 VA: 0x24A6BE0
	public int get_AttackX() { }

	[CompilerGeneratedAttribute] // RVA: 0x2AFEB0 Offset: 0x2AFFB1 VA: 0x2AFEB0
	// RVA: 0x24A6BF0 Offset: 0x24A6CF1 VA: 0x24A6BF0
	public void set_AttackX(int value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2AFEC0 Offset: 0x2AFFC1 VA: 0x2AFEC0
	[IsReadOnlyAttribute] // RVA: 0x2AFEC0 Offset: 0x2AFFC1 VA: 0x2AFEC0
	// RVA: 0x24A6C00 Offset: 0x24A6D01 VA: 0x24A6C00
	public int get_AttackZ() { }

	[CompilerGeneratedAttribute] // RVA: 0x2AFF00 Offset: 0x2B0001 VA: 0x2AFF00
	// RVA: 0x24A6C10 Offset: 0x24A6D11 VA: 0x24A6C10
	public void set_AttackZ(int value) { }

	// RVA: 0x24A6C20 Offset: 0x24A6D21 VA: 0x24A6C20
	public void Clear() { }
}

// Namespace: 
private struct AIThink.RescueRodTarget // TypeDefIndex: 9314
{
	// Fields
	public AIThink.RescueRodScoreResult RRSResult; // 0x0
	[CompilerGeneratedAttribute] // RVA: 0x287280 Offset: 0x287381 VA: 0x287280
	private Unit <Unit>k__BackingField; // 0x18
	[CompilerGeneratedAttribute] // RVA: 0x287290 Offset: 0x287391 VA: 0x287290
	private int <X>k__BackingField; // 0x20
	[CompilerGeneratedAttribute] // RVA: 0x2872A0 Offset: 0x2873A1 VA: 0x2872A0
	private int <Z>k__BackingField; // 0x24

	// Properties
	public Unit Unit { get; set; }
	public int X { get; set; }
	public int Z { get; set; }
	public uint Score { get; }
	public int MoveX { get; }
	public int MoveZ { get; }
	public int AttackX { get; }
	public int AttackZ { get; }

	// Methods

	[IsReadOnlyAttribute] // RVA: 0x2AFF10 Offset: 0x2B0011 VA: 0x2AFF10
	[CompilerGeneratedAttribute] // RVA: 0x2AFF10 Offset: 0x2B0011 VA: 0x2AFF10
	// RVA: 0x24A6C40 Offset: 0x24A6D41 VA: 0x24A6C40
	public Unit get_Unit() { }

	[CompilerGeneratedAttribute] // RVA: 0x2AFF50 Offset: 0x2B0051 VA: 0x2AFF50
	// RVA: 0x24A6C50 Offset: 0x24A6D51 VA: 0x24A6C50
	public void set_Unit(Unit value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2AFF60 Offset: 0x2B0061 VA: 0x2AFF60
	[IsReadOnlyAttribute] // RVA: 0x2AFF60 Offset: 0x2B0061 VA: 0x2AFF60
	// RVA: 0x24A6C60 Offset: 0x24A6D61 VA: 0x24A6C60
	public int get_X() { }

	[CompilerGeneratedAttribute] // RVA: 0x2AFFA0 Offset: 0x2B00A1 VA: 0x2AFFA0
	// RVA: 0x24A6C70 Offset: 0x24A6D71 VA: 0x24A6C70
	public void set_X(int value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2AFFB0 Offset: 0x2B00B1 VA: 0x2AFFB0
	[IsReadOnlyAttribute] // RVA: 0x2AFFB0 Offset: 0x2B00B1 VA: 0x2AFFB0
	// RVA: 0x24A6C80 Offset: 0x24A6D81 VA: 0x24A6C80
	public int get_Z() { }

	[CompilerGeneratedAttribute] // RVA: 0x2AFFF0 Offset: 0x2B00F1 VA: 0x2AFFF0
	// RVA: 0x24A6C90 Offset: 0x24A6D91 VA: 0x24A6C90
	public void set_Z(int value) { }

	// RVA: 0x24A6CA0 Offset: 0x24A6DA1 VA: 0x24A6CA0
	public uint get_Score() { }

	// RVA: 0x24A6CB0 Offset: 0x24A6DB1 VA: 0x24A6CB0
	public int get_MoveX() { }

	// RVA: 0x24A6CC0 Offset: 0x24A6DC1 VA: 0x24A6CC0
	public int get_MoveZ() { }

	// RVA: 0x24A6CD0 Offset: 0x24A6DD1 VA: 0x24A6CD0
	public int get_AttackX() { }

	// RVA: 0x24A6CE0 Offset: 0x24A6DE1 VA: 0x24A6CE0
	public int get_AttackZ() { }

	// RVA: 0x24A6CF0 Offset: 0x24A6DF1 VA: 0x24A6CF0
	public void Clear() { }

	// RVA: 0x24A6D30 Offset: 0x24A6E31 VA: 0x24A6D30
	public static void New(out AIThink.RescueRodTarget inst) { }
}

// Namespace: 
private struct AIThink.InterferenceScoreResult // TypeDefIndex: 9315
{
	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x2872B0 Offset: 0x2873B1 VA: 0x2872B0
	private uint <Score>k__BackingField; // 0x0
	[CompilerGeneratedAttribute] // RVA: 0x2872C0 Offset: 0x2873C1 VA: 0x2872C0
	private int <MoveX>k__BackingField; // 0x4
	[CompilerGeneratedAttribute] // RVA: 0x2872D0 Offset: 0x2873D1 VA: 0x2872D0
	private int <MoveZ>k__BackingField; // 0x8
	[CompilerGeneratedAttribute] // RVA: 0x2872E0 Offset: 0x2873E1 VA: 0x2872E0
	private int <AttackX>k__BackingField; // 0xC
	[CompilerGeneratedAttribute] // RVA: 0x2872F0 Offset: 0x2873F1 VA: 0x2872F0
	private int <AttackZ>k__BackingField; // 0x10
	[CompilerGeneratedAttribute] // RVA: 0x287300 Offset: 0x287401 VA: 0x287300
	private int <ItemIndex>k__BackingField; // 0x14

	// Properties
	public uint Score { get; set; }
	public int MoveX { get; set; }
	public int MoveZ { get; set; }
	public int AttackX { get; set; }
	public int AttackZ { get; set; }
	public int ItemIndex { get; set; }

	// Methods

	[IsReadOnlyAttribute] // RVA: 0x2B0000 Offset: 0x2B0101 VA: 0x2B0000
	[CompilerGeneratedAttribute] // RVA: 0x2B0000 Offset: 0x2B0101 VA: 0x2B0000
	// RVA: 0x24A63C0 Offset: 0x24A64C1 VA: 0x24A63C0
	public uint get_Score() { }

	[CompilerGeneratedAttribute] // RVA: 0x2B0040 Offset: 0x2B0141 VA: 0x2B0040
	// RVA: 0x24A63D0 Offset: 0x24A64D1 VA: 0x24A63D0
	public void set_Score(uint value) { }

	[IsReadOnlyAttribute] // RVA: 0x2B0050 Offset: 0x2B0151 VA: 0x2B0050
	[CompilerGeneratedAttribute] // RVA: 0x2B0050 Offset: 0x2B0151 VA: 0x2B0050
	// RVA: 0x24A63E0 Offset: 0x24A64E1 VA: 0x24A63E0
	public int get_MoveX() { }

	[CompilerGeneratedAttribute] // RVA: 0x2B0090 Offset: 0x2B0191 VA: 0x2B0090
	// RVA: 0x24A63F0 Offset: 0x24A64F1 VA: 0x24A63F0
	public void set_MoveX(int value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2B00A0 Offset: 0x2B01A1 VA: 0x2B00A0
	[IsReadOnlyAttribute] // RVA: 0x2B00A0 Offset: 0x2B01A1 VA: 0x2B00A0
	// RVA: 0x24A6400 Offset: 0x24A6501 VA: 0x24A6400
	public int get_MoveZ() { }

	[CompilerGeneratedAttribute] // RVA: 0x2B00E0 Offset: 0x2B01E1 VA: 0x2B00E0
	// RVA: 0x24A6410 Offset: 0x24A6511 VA: 0x24A6410
	public void set_MoveZ(int value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2B00F0 Offset: 0x2B01F1 VA: 0x2B00F0
	[IsReadOnlyAttribute] // RVA: 0x2B00F0 Offset: 0x2B01F1 VA: 0x2B00F0
	// RVA: 0x24A6420 Offset: 0x24A6521 VA: 0x24A6420
	public int get_AttackX() { }

	[CompilerGeneratedAttribute] // RVA: 0x2B0130 Offset: 0x2B0231 VA: 0x2B0130
	// RVA: 0x24A6430 Offset: 0x24A6531 VA: 0x24A6430
	public void set_AttackX(int value) { }

	[IsReadOnlyAttribute] // RVA: 0x2B0140 Offset: 0x2B0241 VA: 0x2B0140
	[CompilerGeneratedAttribute] // RVA: 0x2B0140 Offset: 0x2B0241 VA: 0x2B0140
	// RVA: 0x24A6440 Offset: 0x24A6541 VA: 0x24A6440
	public int get_AttackZ() { }

	[CompilerGeneratedAttribute] // RVA: 0x2B0180 Offset: 0x2B0281 VA: 0x2B0180
	// RVA: 0x24A6450 Offset: 0x24A6551 VA: 0x24A6450
	public void set_AttackZ(int value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2B0190 Offset: 0x2B0291 VA: 0x2B0190
	[IsReadOnlyAttribute] // RVA: 0x2B0190 Offset: 0x2B0291 VA: 0x2B0190
	// RVA: 0x24A6460 Offset: 0x24A6561 VA: 0x24A6460
	public int get_ItemIndex() { }

	[CompilerGeneratedAttribute] // RVA: 0x2B01D0 Offset: 0x2B02D1 VA: 0x2B01D0
	// RVA: 0x24A6470 Offset: 0x24A6571 VA: 0x24A6470
	public void set_ItemIndex(int value) { }

	// RVA: 0x24A6480 Offset: 0x24A6581 VA: 0x24A6480
	public void Clear() { }
}

// Namespace: 
private struct AIThink.InterferenceTarget // TypeDefIndex: 9316
{
	// Fields
	public AIThink.InterferenceScoreResult ISResult; // 0x0
	[CompilerGeneratedAttribute] // RVA: 0x287310 Offset: 0x287411 VA: 0x287310
	private Unit <Unit>k__BackingField; // 0x18
	[CompilerGeneratedAttribute] // RVA: 0x287320 Offset: 0x287421 VA: 0x287320
	private int <X>k__BackingField; // 0x20
	[CompilerGeneratedAttribute] // RVA: 0x287330 Offset: 0x287431 VA: 0x287330
	private int <Z>k__BackingField; // 0x24

	// Properties
	public Unit Unit { get; set; }
	public int X { get; set; }
	public int Z { get; set; }
	public uint Score { get; }
	public int MoveX { get; }
	public int MoveZ { get; }
	public int AttackX { get; }
	public int AttackZ { get; }
	public int ItemIndex { get; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x2B01E0 Offset: 0x2B02E1 VA: 0x2B01E0
	[IsReadOnlyAttribute] // RVA: 0x2B01E0 Offset: 0x2B02E1 VA: 0x2B01E0
	// RVA: 0x24A64A0 Offset: 0x24A65A1 VA: 0x24A64A0
	public Unit get_Unit() { }

	[CompilerGeneratedAttribute] // RVA: 0x2B0220 Offset: 0x2B0321 VA: 0x2B0220
	// RVA: 0x24A64B0 Offset: 0x24A65B1 VA: 0x24A64B0
	public void set_Unit(Unit value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2B0230 Offset: 0x2B0331 VA: 0x2B0230
	[IsReadOnlyAttribute] // RVA: 0x2B0230 Offset: 0x2B0331 VA: 0x2B0230
	// RVA: 0x24A64C0 Offset: 0x24A65C1 VA: 0x24A64C0
	public int get_X() { }

	[CompilerGeneratedAttribute] // RVA: 0x2B0270 Offset: 0x2B0371 VA: 0x2B0270
	// RVA: 0x24A64D0 Offset: 0x24A65D1 VA: 0x24A64D0
	public void set_X(int value) { }

	[IsReadOnlyAttribute] // RVA: 0x2B0280 Offset: 0x2B0381 VA: 0x2B0280
	[CompilerGeneratedAttribute] // RVA: 0x2B0280 Offset: 0x2B0381 VA: 0x2B0280
	// RVA: 0x24A64E0 Offset: 0x24A65E1 VA: 0x24A64E0
	public int get_Z() { }

	[CompilerGeneratedAttribute] // RVA: 0x2B02C0 Offset: 0x2B03C1 VA: 0x2B02C0
	// RVA: 0x24A64F0 Offset: 0x24A65F1 VA: 0x24A64F0
	public void set_Z(int value) { }

	// RVA: 0x24A6500 Offset: 0x24A6601 VA: 0x24A6500
	public uint get_Score() { }

	// RVA: 0x24A6510 Offset: 0x24A6611 VA: 0x24A6510
	public int get_MoveX() { }

	// RVA: 0x24A6520 Offset: 0x24A6621 VA: 0x24A6520
	public int get_MoveZ() { }

	// RVA: 0x24A6530 Offset: 0x24A6631 VA: 0x24A6530
	public int get_AttackX() { }

	// RVA: 0x24A6540 Offset: 0x24A6641 VA: 0x24A6540
	public int get_AttackZ() { }

	// RVA: 0x24A6550 Offset: 0x24A6651 VA: 0x24A6550
	public int get_ItemIndex() { }

	// RVA: 0x24A6560 Offset: 0x24A6661 VA: 0x24A6560
	public void Clear() { }

	// RVA: 0x24A65A0 Offset: 0x24A66A1 VA: 0x24A65A0
	public static void New(out AIThink.InterferenceTarget inst) { }
}

// Namespace: 
private struct AIThink.EntrustAttackScoreResult // TypeDefIndex: 9317
{
	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x287340 Offset: 0x287441 VA: 0x287340
	private uint <Score>k__BackingField; // 0x0
	[CompilerGeneratedAttribute] // RVA: 0x287350 Offset: 0x287451 VA: 0x287350
	private int <MoveX>k__BackingField; // 0x4
	[CompilerGeneratedAttribute] // RVA: 0x287360 Offset: 0x287461 VA: 0x287360
	private int <MoveZ>k__BackingField; // 0x8
	[CompilerGeneratedAttribute] // RVA: 0x287370 Offset: 0x287471 VA: 0x287370
	private int <AttackX>k__BackingField; // 0xC
	[CompilerGeneratedAttribute] // RVA: 0x287380 Offset: 0x287481 VA: 0x287380
	private int <AttackZ>k__BackingField; // 0x10
	[CompilerGeneratedAttribute] // RVA: 0x287390 Offset: 0x287491 VA: 0x287390
	private float <KillRate>k__BackingField; // 0x14
	[CompilerGeneratedAttribute] // RVA: 0x2873A0 Offset: 0x2874A1 VA: 0x2873A0
	private float <DeadRate>k__BackingField; // 0x18

	// Properties
	public uint Score { get; set; }
	public int MoveX { get; set; }
	public int MoveZ { get; set; }
	public int AttackX { get; set; }
	public int AttackZ { get; set; }
	public float KillRate { get; set; }
	public float DeadRate { get; set; }

	// Methods

	[IsReadOnlyAttribute] // RVA: 0x2B02D0 Offset: 0x2B03D1 VA: 0x2B02D0
	[CompilerGeneratedAttribute] // RVA: 0x2B02D0 Offset: 0x2B03D1 VA: 0x2B02D0
	// RVA: 0x24A5F90 Offset: 0x24A6091 VA: 0x24A5F90
	public uint get_Score() { }

	[CompilerGeneratedAttribute] // RVA: 0x2B0310 Offset: 0x2B0411 VA: 0x2B0310
	// RVA: 0x24A5FA0 Offset: 0x24A60A1 VA: 0x24A5FA0
	public void set_Score(uint value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2B0320 Offset: 0x2B0421 VA: 0x2B0320
	[IsReadOnlyAttribute] // RVA: 0x2B0320 Offset: 0x2B0421 VA: 0x2B0320
	// RVA: 0x24A5FB0 Offset: 0x24A60B1 VA: 0x24A5FB0
	public int get_MoveX() { }

	[CompilerGeneratedAttribute] // RVA: 0x2B0360 Offset: 0x2B0461 VA: 0x2B0360
	// RVA: 0x24A5FC0 Offset: 0x24A60C1 VA: 0x24A5FC0
	public void set_MoveX(int value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2B0370 Offset: 0x2B0471 VA: 0x2B0370
	[IsReadOnlyAttribute] // RVA: 0x2B0370 Offset: 0x2B0471 VA: 0x2B0370
	// RVA: 0x24A5FD0 Offset: 0x24A60D1 VA: 0x24A5FD0
	public int get_MoveZ() { }

	[CompilerGeneratedAttribute] // RVA: 0x2B03B0 Offset: 0x2B04B1 VA: 0x2B03B0
	// RVA: 0x24A5FE0 Offset: 0x24A60E1 VA: 0x24A5FE0
	public void set_MoveZ(int value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2B03C0 Offset: 0x2B04C1 VA: 0x2B03C0
	[IsReadOnlyAttribute] // RVA: 0x2B03C0 Offset: 0x2B04C1 VA: 0x2B03C0
	// RVA: 0x24A5FF0 Offset: 0x24A60F1 VA: 0x24A5FF0
	public int get_AttackX() { }

	[CompilerGeneratedAttribute] // RVA: 0x2B0400 Offset: 0x2B0501 VA: 0x2B0400
	// RVA: 0x24A6000 Offset: 0x24A6101 VA: 0x24A6000
	public void set_AttackX(int value) { }

	[IsReadOnlyAttribute] // RVA: 0x2B0410 Offset: 0x2B0511 VA: 0x2B0410
	[CompilerGeneratedAttribute] // RVA: 0x2B0410 Offset: 0x2B0511 VA: 0x2B0410
	// RVA: 0x24A6010 Offset: 0x24A6111 VA: 0x24A6010
	public int get_AttackZ() { }

	[CompilerGeneratedAttribute] // RVA: 0x2B0450 Offset: 0x2B0551 VA: 0x2B0450
	// RVA: 0x24A6020 Offset: 0x24A6121 VA: 0x24A6020
	public void set_AttackZ(int value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2B0460 Offset: 0x2B0561 VA: 0x2B0460
	[IsReadOnlyAttribute] // RVA: 0x2B0460 Offset: 0x2B0561 VA: 0x2B0460
	// RVA: 0x24A6030 Offset: 0x24A6131 VA: 0x24A6030
	public float get_KillRate() { }

	[CompilerGeneratedAttribute] // RVA: 0x2B04A0 Offset: 0x2B05A1 VA: 0x2B04A0
	// RVA: 0x24A6040 Offset: 0x24A6141 VA: 0x24A6040
	public void set_KillRate(float value) { }

	[IsReadOnlyAttribute] // RVA: 0x2B04B0 Offset: 0x2B05B1 VA: 0x2B04B0
	[CompilerGeneratedAttribute] // RVA: 0x2B04B0 Offset: 0x2B05B1 VA: 0x2B04B0
	// RVA: 0x24A6050 Offset: 0x24A6151 VA: 0x24A6050
	public float get_DeadRate() { }

	[CompilerGeneratedAttribute] // RVA: 0x2B04F0 Offset: 0x2B05F1 VA: 0x2B04F0
	// RVA: 0x24A6060 Offset: 0x24A6161 VA: 0x24A6060
	public void set_DeadRate(float value) { }

	// RVA: 0x24A6070 Offset: 0x24A6171 VA: 0x24A6070
	public void Clear() { }
}

// Namespace: 
private struct AIThink.EntrustAttackTarget // TypeDefIndex: 9318
{
	// Fields
	public AIThink.EntrustAttackScoreResult EASResult; // 0x0
	[CompilerGeneratedAttribute] // RVA: 0x2873B0 Offset: 0x2874B1 VA: 0x2873B0
	private Unit <Unit>k__BackingField; // 0x20
	[CompilerGeneratedAttribute] // RVA: 0x2873C0 Offset: 0x2874C1 VA: 0x2873C0
	private int <X>k__BackingField; // 0x28
	[CompilerGeneratedAttribute] // RVA: 0x2873D0 Offset: 0x2874D1 VA: 0x2873D0
	private int <Z>k__BackingField; // 0x2C

	// Properties
	public Unit Unit { get; set; }
	public int X { get; set; }
	public int Z { get; set; }
	public uint Score { get; }
	public int MoveX { get; }
	public int MoveZ { get; }
	public int AttackX { get; }
	public int AttackZ { get; }
	public float KillRate { get; }
	public float DeadRate { get; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x2B0500 Offset: 0x2B0601 VA: 0x2B0500
	[IsReadOnlyAttribute] // RVA: 0x2B0500 Offset: 0x2B0601 VA: 0x2B0500
	// RVA: 0x24A6090 Offset: 0x24A6191 VA: 0x24A6090
	public Unit get_Unit() { }

	[CompilerGeneratedAttribute] // RVA: 0x2B0540 Offset: 0x2B0641 VA: 0x2B0540
	// RVA: 0x24A60A0 Offset: 0x24A61A1 VA: 0x24A60A0
	public void set_Unit(Unit value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2B0550 Offset: 0x2B0651 VA: 0x2B0550
	[IsReadOnlyAttribute] // RVA: 0x2B0550 Offset: 0x2B0651 VA: 0x2B0550
	// RVA: 0x24A60B0 Offset: 0x24A61B1 VA: 0x24A60B0
	public int get_X() { }

	[CompilerGeneratedAttribute] // RVA: 0x2B0590 Offset: 0x2B0691 VA: 0x2B0590
	// RVA: 0x24A60C0 Offset: 0x24A61C1 VA: 0x24A60C0
	public void set_X(int value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2B05A0 Offset: 0x2B06A1 VA: 0x2B05A0
	[IsReadOnlyAttribute] // RVA: 0x2B05A0 Offset: 0x2B06A1 VA: 0x2B05A0
	// RVA: 0x24A60D0 Offset: 0x24A61D1 VA: 0x24A60D0
	public int get_Z() { }

	[CompilerGeneratedAttribute] // RVA: 0x2B05E0 Offset: 0x2B06E1 VA: 0x2B05E0
	// RVA: 0x24A60E0 Offset: 0x24A61E1 VA: 0x24A60E0
	public void set_Z(int value) { }

	// RVA: 0x249B4D0 Offset: 0x249B5D1 VA: 0x249B4D0
	public uint get_Score() { }

	// RVA: 0x24A60F0 Offset: 0x24A61F1 VA: 0x24A60F0
	public int get_MoveX() { }

	// RVA: 0x24A6100 Offset: 0x24A6201 VA: 0x24A6100
	public int get_MoveZ() { }

	// RVA: 0x24A6110 Offset: 0x24A6211 VA: 0x24A6110
	public int get_AttackX() { }

	// RVA: 0x24A6120 Offset: 0x24A6221 VA: 0x24A6120
	public int get_AttackZ() { }

	// RVA: 0x24A6130 Offset: 0x24A6231 VA: 0x24A6130
	public float get_KillRate() { }

	// RVA: 0x24A6140 Offset: 0x24A6241 VA: 0x24A6140
	public float get_DeadRate() { }

	// RVA: 0x24A6150 Offset: 0x24A6251 VA: 0x24A6150
	public void Clear() { }

	// RVA: 0x24A6190 Offset: 0x24A6291 VA: 0x24A6190
	public static void New(out AIThink.EntrustAttackTarget inst) { }
}

// Namespace: 
private struct AIThink.UncontrollAttackScoreResult // TypeDefIndex: 9319
{
	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x2873E0 Offset: 0x2874E1 VA: 0x2873E0
	private uint <Score>k__BackingField; // 0x0
	[CompilerGeneratedAttribute] // RVA: 0x2873F0 Offset: 0x2874F1 VA: 0x2873F0
	private int <MoveX>k__BackingField; // 0x4
	[CompilerGeneratedAttribute] // RVA: 0x287400 Offset: 0x287501 VA: 0x287400
	private int <MoveZ>k__BackingField; // 0x8
	[CompilerGeneratedAttribute] // RVA: 0x287410 Offset: 0x287511 VA: 0x287410
	private int <AttackX>k__BackingField; // 0xC
	[CompilerGeneratedAttribute] // RVA: 0x287420 Offset: 0x287521 VA: 0x287420
	private int <AttackZ>k__BackingField; // 0x10

	// Properties
	public uint Score { get; set; }
	public int MoveX { get; set; }
	public int MoveZ { get; set; }
	public int AttackX { get; set; }
	public int AttackZ { get; set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x2B05F0 Offset: 0x2B06F1 VA: 0x2B05F0
	[IsReadOnlyAttribute] // RVA: 0x2B05F0 Offset: 0x2B06F1 VA: 0x2B05F0
	// RVA: 0x24A7240 Offset: 0x24A7341 VA: 0x24A7240
	public uint get_Score() { }

	[CompilerGeneratedAttribute] // RVA: 0x2B0630 Offset: 0x2B0731 VA: 0x2B0630
	// RVA: 0x24A7250 Offset: 0x24A7351 VA: 0x24A7250
	public void set_Score(uint value) { }

	[IsReadOnlyAttribute] // RVA: 0x2B0640 Offset: 0x2B0741 VA: 0x2B0640
	[CompilerGeneratedAttribute] // RVA: 0x2B0640 Offset: 0x2B0741 VA: 0x2B0640
	// RVA: 0x24A7260 Offset: 0x24A7361 VA: 0x24A7260
	public int get_MoveX() { }

	[CompilerGeneratedAttribute] // RVA: 0x2B0680 Offset: 0x2B0781 VA: 0x2B0680
	// RVA: 0x24A7270 Offset: 0x24A7371 VA: 0x24A7270
	public void set_MoveX(int value) { }

	[IsReadOnlyAttribute] // RVA: 0x2B0690 Offset: 0x2B0791 VA: 0x2B0690
	[CompilerGeneratedAttribute] // RVA: 0x2B0690 Offset: 0x2B0791 VA: 0x2B0690
	// RVA: 0x24A7280 Offset: 0x24A7381 VA: 0x24A7280
	public int get_MoveZ() { }

	[CompilerGeneratedAttribute] // RVA: 0x2B06D0 Offset: 0x2B07D1 VA: 0x2B06D0
	// RVA: 0x24A7290 Offset: 0x24A7391 VA: 0x24A7290
	public void set_MoveZ(int value) { }

	[IsReadOnlyAttribute] // RVA: 0x2B06E0 Offset: 0x2B07E1 VA: 0x2B06E0
	[CompilerGeneratedAttribute] // RVA: 0x2B06E0 Offset: 0x2B07E1 VA: 0x2B06E0
	// RVA: 0x24A72A0 Offset: 0x24A73A1 VA: 0x24A72A0
	public int get_AttackX() { }

	[CompilerGeneratedAttribute] // RVA: 0x2B0720 Offset: 0x2B0821 VA: 0x2B0720
	// RVA: 0x24A72B0 Offset: 0x24A73B1 VA: 0x24A72B0
	public void set_AttackX(int value) { }

	[IsReadOnlyAttribute] // RVA: 0x2B0730 Offset: 0x2B0831 VA: 0x2B0730
	[CompilerGeneratedAttribute] // RVA: 0x2B0730 Offset: 0x2B0831 VA: 0x2B0730
	// RVA: 0x24A72C0 Offset: 0x24A73C1 VA: 0x24A72C0
	public int get_AttackZ() { }

	[CompilerGeneratedAttribute] // RVA: 0x2B0770 Offset: 0x2B0871 VA: 0x2B0770
	// RVA: 0x24A72D0 Offset: 0x24A73D1 VA: 0x24A72D0
	public void set_AttackZ(int value) { }

	// RVA: 0x24A72E0 Offset: 0x24A73E1 VA: 0x24A72E0
	public void Clear() { }
}

// Namespace: 
private struct AIThink.UncontrollAttackTarget // TypeDefIndex: 9320
{
	// Fields
	public AIThink.UncontrollAttackScoreResult UASResult; // 0x0
	[CompilerGeneratedAttribute] // RVA: 0x287430 Offset: 0x287531 VA: 0x287430
	private Unit <Unit>k__BackingField; // 0x18
	[CompilerGeneratedAttribute] // RVA: 0x287440 Offset: 0x287541 VA: 0x287440
	private int <X>k__BackingField; // 0x20
	[CompilerGeneratedAttribute] // RVA: 0x287450 Offset: 0x287551 VA: 0x287450
	private int <Z>k__BackingField; // 0x24

	// Properties
	public Unit Unit { get; set; }
	public int X { get; set; }
	public int Z { get; set; }
	public uint Score { get; }
	public int MoveX { get; }
	public int MoveZ { get; }
	public int AttackX { get; }
	public int AttackZ { get; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x2B0780 Offset: 0x2B0881 VA: 0x2B0780
	[IsReadOnlyAttribute] // RVA: 0x2B0780 Offset: 0x2B0881 VA: 0x2B0780
	// RVA: 0x24A7300 Offset: 0x24A7401 VA: 0x24A7300
	public Unit get_Unit() { }

	[CompilerGeneratedAttribute] // RVA: 0x2B07C0 Offset: 0x2B08C1 VA: 0x2B07C0
	// RVA: 0x24A7310 Offset: 0x24A7411 VA: 0x24A7310
	public void set_Unit(Unit value) { }

	[IsReadOnlyAttribute] // RVA: 0x2B07D0 Offset: 0x2B08D1 VA: 0x2B07D0
	[CompilerGeneratedAttribute] // RVA: 0x2B07D0 Offset: 0x2B08D1 VA: 0x2B07D0
	// RVA: 0x24A7320 Offset: 0x24A7421 VA: 0x24A7320
	public int get_X() { }

	[CompilerGeneratedAttribute] // RVA: 0x2B0810 Offset: 0x2B0911 VA: 0x2B0810
	// RVA: 0x24A7330 Offset: 0x24A7431 VA: 0x24A7330
	public void set_X(int value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2B0820 Offset: 0x2B0921 VA: 0x2B0820
	[IsReadOnlyAttribute] // RVA: 0x2B0820 Offset: 0x2B0921 VA: 0x2B0820
	// RVA: 0x24A7340 Offset: 0x24A7441 VA: 0x24A7340
	public int get_Z() { }

	[CompilerGeneratedAttribute] // RVA: 0x2B0860 Offset: 0x2B0961 VA: 0x2B0860
	// RVA: 0x24A7350 Offset: 0x24A7451 VA: 0x24A7350
	public void set_Z(int value) { }

	// RVA: 0x249FC70 Offset: 0x249FD71 VA: 0x249FC70
	public uint get_Score() { }

	// RVA: 0x24A7360 Offset: 0x24A7461 VA: 0x24A7360
	public int get_MoveX() { }

	// RVA: 0x24A7370 Offset: 0x24A7471 VA: 0x24A7370
	public int get_MoveZ() { }

	// RVA: 0x24A7380 Offset: 0x24A7481 VA: 0x24A7380
	public int get_AttackX() { }

	// RVA: 0x24A7390 Offset: 0x24A7491 VA: 0x24A7390
	public int get_AttackZ() { }

	// RVA: 0x24A73A0 Offset: 0x24A74A1 VA: 0x24A73A0
	public void Clear() { }

	// RVA: 0x24A73E0 Offset: 0x24A74E1 VA: 0x24A73E0
	public static void New(out AIThink.UncontrollAttackTarget inst) { }
}

// Namespace: 
public enum AIThink.TrimasteriesSkills.Kinds // TypeDefIndex: 9321
{
	// Fields
	public int value__; // 0x0
	public const AIThink.TrimasteriesSkills.Kinds Unknown = -1;
	public const AIThink.TrimasteriesSkills.Kinds MadStorm = 0;
	public const AIThink.TrimasteriesSkills.Kinds Miserable = 1;
	public const AIThink.TrimasteriesSkills.Kinds FallingStars = 2;
	public const AIThink.TrimasteriesSkills.Kinds Max = 3;
}

// Namespace: 
private struct AIThink.TrimasteriesSkills // TypeDefIndex: 9322
{
	// Fields
	private SkillData[] m_Skills; // 0x0
	private int m_Count; // 0x8
	private int m_LastEngageTurn; // 0xC

	// Properties
	public int Count { get; }
	public SkillData MadStorm { get; }
	public SkillData Miserable { get; }
	public SkillData FallingStars { get; }

	// Methods

	// RVA: 0x24A6D80 Offset: 0x24A6E81 VA: 0x24A6D80
	public void Prepare(Unit unit) { }

	// RVA: 0x24A6FC0 Offset: 0x24A70C1 VA: 0x24A6FC0
	public void Add(SkillData skill) { }

	// RVA: 0x24A71A0 Offset: 0x24A72A1 VA: 0x24A71A0
	public int get_Count() { }

	// RVA: 0x24A71B0 Offset: 0x24A72B1 VA: 0x24A71B0
	public SkillData get_MadStorm() { }

	// RVA: 0x24A71E0 Offset: 0x24A72E1 VA: 0x24A71E0
	public SkillData get_Miserable() { }

	// RVA: 0x24A7210 Offset: 0x24A7311 VA: 0x24A7210
	public SkillData get_FallingStars() { }

	// RVA: 0x24A7120 Offset: 0x24A7221 VA: 0x24A7120
	private AIThink.TrimasteriesSkills.Kinds GetKind(SkillData skill) { }
}

// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x275430 Offset: 0x275531 VA: 0x275430
private sealed class AIThink.<>c__DisplayClass70_0 // TypeDefIndex: 9323
{
	// Fields
	public Unit actor; // 0x10
	public bool isAheadIgnore; // 0x18
	public bool isChangeXZ; // 0x19
	public int targetX; // 0x1C
	public int targetZ; // 0x20
	public bool isNearest; // 0x24
	public ulong eRange; // 0x28
	public int moveX; // 0x30
	public uint score; // 0x34
	public int moveZ; // 0x38
	public int attackX; // 0x3C
	public int attackZ; // 0x40
	public ulong mRange; // 0x48
	public bool isPierceMultiple; // 0x50
	public int reqTargetCountInRange; // 0x54
	public Unit target; // 0x58
	public SkillData skill; // 0x60
	public bool isChain; // 0x68
	public Unit chained; // 0x70
	public bool isBreak; // 0x78
	public bool isChainAttackCount; // 0x79

	// Methods

	// RVA: 0x249FFF0 Offset: 0x24A00F1 VA: 0x249FFF0
	public void .ctor() { }

	// RVA: 0x24A0000 Offset: 0x24A0101 VA: 0x24A0000
	internal void <GetAttackPosition>b__0(int x, int z) { }
}

// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x275440 Offset: 0x275541 VA: 0x275440
private sealed class AIThink.<>c__DisplayClass70_1 // TypeDefIndex: 9324
{
	// Fields
	public SkillArray equipSkillsOfItem; // 0x10
	public BattleInfo battleInfo; // 0x18
	public Unit copiedActor; // 0x20
	public UnitItem attackUnitItem; // 0x28
	public uint blowScore; // 0x30
	public int chainAttackCount; // 0x34
	public AIThink.<>c__DisplayClass70_0 CS$<>8__locals1; // 0x38

	// Methods

	// RVA: 0x24A0240 Offset: 0x24A0341 VA: 0x24A0240
	public void .ctor() { }

	// RVA: 0x24A0250 Offset: 0x24A0351 VA: 0x24A0250
	internal void <GetAttackPosition>b__1(int x, int z, int range) { }
}

// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x275450 Offset: 0x275551 VA: 0x275450
private sealed class AIThink.<>c__DisplayClass74_0 // TypeDefIndex: 9325
{
	// Fields
	public int count; // 0x10

	// Methods

	// RVA: 0x24A0760 Offset: 0x24A0861 VA: 0x24A0760
	public void .ctor() { }

	// RVA: 0x24A0770 Offset: 0x24A0871 VA: 0x24A0770
	internal void <CountPierceTargets>b__0(int x, int z, Unit u) { }
}

// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x275460 Offset: 0x275561 VA: 0x275460
private sealed class AIThink.<>c__DisplayClass78_0 // TypeDefIndex: 9326
{
	// Fields
	public bool isIn; // 0x10
	public bool isArrival; // 0x11
	public uint priority; // 0x14
	public uint score; // 0x18
	public int workX; // 0x1C
	public int workZ; // 0x20
	public int workTargetX; // 0x24
	public int workTargetZ; // 0x28

	// Methods

	// RVA: 0x24A0790 Offset: 0x24A0891 VA: 0x24A0790
	public void .ctor() { }

	// RVA: 0x24A07A0 Offset: 0x24A08A1 VA: 0x24A07A0
	internal void <GetEventPosition>b__0(int x, int z, PokeInspector inspector) { }
}

// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x275470 Offset: 0x275571 VA: 0x275470
private sealed class AIThink.<>c__DisplayClass79_0 // TypeDefIndex: 9327
{
	// Fields
	public AIDeploy deploy; // 0x10

	// Methods

	// RVA: 0x24A09F0 Offset: 0x24A0AF1 VA: 0x24A09F0
	public void .ctor() { }

	// RVA: 0x24A0A00 Offset: 0x24A0B01 VA: 0x24A0A00
	internal void <LimitMoveImage>b__0(int x, int z) { }
}

// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x275480 Offset: 0x275581 VA: 0x275480
private sealed class AIThink.<>c__DisplayClass101_0 // TypeDefIndex: 9328
{
	// Fields
	public AIThink <>4__this; // 0x10
	public MapMind mind; // 0x18
	public int attackX; // 0x20
	public int attackZ; // 0x24
	public int targetX; // 0x28
	public int targetZ; // 0x2C
	public bool isClever; // 0x30
	public Unit target; // 0x38
	public uint score; // 0x40
	public int itemIndex; // 0x44

	// Methods

	// RVA: 0x2F32620 Offset: 0x2F32721 VA: 0x2F32620
	public void .ctor() { }

	// RVA: 0x2F32630 Offset: 0x2F32731 VA: 0x2F32630
	internal void <ProcessingMutation>b__0(Unit unit) { }
}

// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x275490 Offset: 0x275591 VA: 0x275490
private sealed class AIThink.<>c__DisplayClass110_0 // TypeDefIndex: 9329
{
	// Fields
	public AIThink <>4__this; // 0x10
	public AIValue v1; // 0x18
	public int factor; // 0x20
	public int bandNum; // 0x24
	public bool isPerson; // 0x28
	public MapDeployTemplate.Flag<AIDeploy> moveFlag; // 0x30
	public MapDeployTemplate.Flag<AIDeploy> weaponFlag; // 0x38

	// Methods

	// RVA: 0x2F33010 Offset: 0x2F33111 VA: 0x2F33010
	public void .ctor() { }

	// RVA: 0x2F33020 Offset: 0x2F33121 VA: 0x2F33020
	internal void <ActiveCauseBandRange>b__0(Unit unit) { }
}

// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x2754A0 Offset: 0x2755A1 VA: 0x2754A0
[Serializable]
private sealed class AIThink.<>c // TypeDefIndex: 9330
{
	// Fields
	public static readonly AIThink.<>c <>9; // 0x0
	public static MapFor.PosFunction <>9__110_1; // 0x8
	public static MapFor.PosFunction <>9__280_2; // 0x10

	// Methods

	// RVA: 0x2F32300 Offset: 0x2F32401 VA: 0x2F32300
	private static void .cctor() { }

	// RVA: 0x2F32370 Offset: 0x2F32471 VA: 0x2F32370
	public void .ctor() { }

	// RVA: 0x2F32380 Offset: 0x2F32481 VA: 0x2F32380
	internal void <ActiveCauseBandRange>b__110_1(int x, int z) { }

	// RVA: 0x2F324B0 Offset: 0x2F325B1 VA: 0x2F324B0
	internal void <CommandSkillOverlapToCommon>b__280_2(int x, int z) { }
}

// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x2754B0 Offset: 0x2755B1 VA: 0x2754B0
private sealed class AIThink.<>c__DisplayClass111_0 // TypeDefIndex: 9331
{
	// Fields
	public AIThink <>4__this; // 0x10
	public bool ret; // 0x18

	// Methods

	// RVA: 0x2F33250 Offset: 0x2F33351 VA: 0x2F33250
	public void .ctor() { }

	// RVA: 0x2F33260 Offset: 0x2F33361 VA: 0x2F33260
	internal MapFor.Return <ActiveCauseHealRange>b__0(Unit unit) { }
}

// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x2754C0 Offset: 0x2755C1 VA: 0x2754C0
private sealed class AIThink.<>c__DisplayClass112_0 // TypeDefIndex: 9332
{
	// Fields
	public AIThink <>4__this; // 0x10
	public int x0; // 0x18
	public int x1; // 0x1C
	public int z0; // 0x20
	public int z1; // 0x24
	public bool ret; // 0x28

	// Methods

	// RVA: 0x2F333B0 Offset: 0x2F334B1 VA: 0x2F333B0
	public void .ctor() { }

	// RVA: 0x2F333C0 Offset: 0x2F334C1 VA: 0x2F333C0
	internal MapFor.Return <ActiveCauseAreaEnemy>b__0(Unit unit) { }
}

// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x2754D0 Offset: 0x2755D1 VA: 0x2754D0
private sealed class AIThink.<>c__DisplayClass135_0 // TypeDefIndex: 9333
{
	// Fields
	public AIThink <>4__this; // 0x10
	public PersonData person; // 0x18
	public int force; // 0x20
	public Unit target; // 0x28
	public uint score; // 0x30
	public int tx; // 0x34
	public int tz; // 0x38

	// Methods

	// RVA: 0x2F33470 Offset: 0x2F33571 VA: 0x2F33470
	public void .ctor() { }

	// RVA: 0x2F33480 Offset: 0x2F33581 VA: 0x2F33480
	internal void <ActionMindTalk>b__0(Unit unit) { }
}

// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x2754E0 Offset: 0x2755E1 VA: 0x2754E0
private sealed class AIThink.<>c__DisplayClass136_0 // TypeDefIndex: 9334
{
	// Fields
	public int xx; // 0x10
	public uint score; // 0x14
	public int tx; // 0x18
	public int tz; // 0x1C
	public PokeInspector targetInspector; // 0x20

	// Methods

	// RVA: 0x2F33890 Offset: 0x2F33991 VA: 0x2F33890
	public void .ctor() { }

	// RVA: 0x2F338A0 Offset: 0x2F339A1 VA: 0x2F338A0
	internal void <ActionMindTreasure>b__0(int x, int z, PokeInspector inspector) { }
}

// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x2754F0 Offset: 0x2755F1 VA: 0x2754F0
private sealed class AIThink.<>c__DisplayClass137_0 // TypeDefIndex: 9335
{
	// Fields
	public int xx; // 0x10
	public uint score; // 0x14
	public int tx; // 0x18
	public int tz; // 0x1C

	// Methods

	// RVA: 0x2F33AF0 Offset: 0x2F33BF1 VA: 0x2F33AF0
	public void .ctor() { }

	// RVA: 0x2F33B00 Offset: 0x2F33C01 VA: 0x2F33B00
	internal void <ActionMindVillage>b__0(int x, int z) { }
}

// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x275500 Offset: 0x275601 VA: 0x275500
private sealed class AIThink.<>c__DisplayClass138_0 // TypeDefIndex: 9336
{
	// Fields
	public int xx; // 0x10
	public AIThink <>4__this; // 0x18
	public uint score; // 0x20
	public int tx; // 0x24
	public int tz; // 0x28

	// Methods

	// RVA: 0x2F33D40 Offset: 0x2F33E41 VA: 0x2F33D40
	public void .ctor() { }

	// RVA: 0x2F33D50 Offset: 0x2F33E51 VA: 0x2F33D50
	internal void <ActionMindEscape>b__0(int x, int z) { }
}

// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x275510 Offset: 0x275611 VA: 0x275510
private sealed class AIThink.<>c__DisplayClass139_0 // TypeDefIndex: 9337
{
	// Fields
	public uint score; // 0x10
	public int tx; // 0x14
	public int tz; // 0x18

	// Methods

	// RVA: 0x2F33FA0 Offset: 0x2F340A1 VA: 0x2F33FA0
	public void .ctor() { }

	// RVA: 0x2F33FB0 Offset: 0x2F340B1 VA: 0x2F33FB0
	internal void <ActionMindBreakDown>b__0(int x, int z) { }
}

// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x275520 Offset: 0x275621 VA: 0x275520
private sealed class AIThink.<>c__DisplayClass142_0 // TypeDefIndex: 9338
{
	// Fields
	public AIThink <>4__this; // 0x10
	public uint score; // 0x18
	public int tx; // 0x1C
	public int tz; // 0x20
	public PokeInspector targetInspector; // 0x28

	// Methods

	// RVA: 0x2F34150 Offset: 0x2F34251 VA: 0x2F34150
	public void .ctor() { }

	// RVA: 0x2F34160 Offset: 0x2F34261 VA: 0x2F34160
	internal void <ActionMindTorch>b__0(int x, int z, PokeInspector inspector) { }
}

// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x275530 Offset: 0x275631 VA: 0x275530
private sealed class AIThink.<>c__DisplayClass145_0 // TypeDefIndex: 9339
{
	// Fields
	public AIThink <>4__this; // 0x10
	public int score; // 0x18
	public bool isClever; // 0x1C
	public int attackFlag; // 0x20
	public AIThink.AttackScoreResult dummyResult; // 0x24
	public Unit target; // 0x50
	public int targetX; // 0x58
	public int targetZ; // 0x5C

	// Methods

	// RVA: 0x2F34430 Offset: 0x2F34531 VA: 0x2F34430
	public void .ctor() { }

	// RVA: 0x2F34440 Offset: 0x2F34541 VA: 0x2F34440
	internal void <ActionMoveNearestEnemy>b__0(Unit unit) { }
}

// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x275540 Offset: 0x275641 VA: 0x275540
private sealed class AIThink.<>c__DisplayClass146_0 // TypeDefIndex: 9340
{
	// Fields
	public AIThink <>4__this; // 0x10
	public int score; // 0x18
	public Unit target; // 0x20
	public int targetX; // 0x28
	public int targetZ; // 0x2C

	// Methods

	// RVA: 0x2F34650 Offset: 0x2F34751 VA: 0x2F34650
	public void .ctor() { }

	// RVA: 0x2F34660 Offset: 0x2F34761 VA: 0x2F34660
	internal void <ActionMoveNearestFriend>b__0(Unit unit) { }
}

// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x275550 Offset: 0x275651 VA: 0x275550
private sealed class AIThink.<>c__DisplayClass148_0 // TypeDefIndex: 9341
{
	// Fields
	public AIThink <>4__this; // 0x10
	public PersonData person0; // 0x18
	public PersonData person1; // 0x20
	public int attackFlag; // 0x28
	public AIThink.AttackPositionResult apResult; // 0x2C
	public bool isWeak; // 0x44
	public int movePower; // 0x48
	public bool isClever; // 0x4C
	public int attackFlagForScore; // 0x50
	public AIThink.AttackScoreResult asResult; // 0x54
	public int score; // 0x80
	public Unit target; // 0x88
	public int targetX; // 0x90
	public int targetZ; // 0x94
	public int moveX; // 0x98
	public int moveZ; // 0x9C

	// Methods

	// RVA: 0x2F34810 Offset: 0x2F34911 VA: 0x2F34810
	public void .ctor() { }

	// RVA: 0x2F34820 Offset: 0x2F34921 VA: 0x2F34820
	internal void <ActionMoveAttackRangeImpl>b__0(Unit unit) { }
}

// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x275560 Offset: 0x275661 VA: 0x275560
private sealed class AIThink.<>c__DisplayClass149_0 // TypeDefIndex: 9342
{
	// Fields
	public AIThink <>4__this; // 0x10
	public int attackFlag; // 0x18
	public AIThink.HealRodPositionResult hrpResult; // 0x1C
	public int movePower; // 0x2C
	public int score; // 0x30
	public Unit target; // 0x38
	public int moveX; // 0x40
	public int moveZ; // 0x44
	public int targetX; // 0x48
	public int targetZ; // 0x4C

	// Methods

	// RVA: 0x2F34BA0 Offset: 0x2F34CA1 VA: 0x2F34BA0
	public void .ctor() { }

	// RVA: 0x2F34BB0 Offset: 0x2F34CB1 VA: 0x2F34BB0
	internal void <ActionMoveHealRange>b__0(Unit unit) { }
}

// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x275570 Offset: 0x275671 VA: 0x275570
private sealed class AIThink.<>c__DisplayClass151_0 // TypeDefIndex: 9343
{
	// Fields
	public AIThink <>4__this; // 0x10
	public AIValue v0; // 0x18
	public int score; // 0x20
	public Unit target; // 0x28
	public int targetX; // 0x30
	public int targetZ; // 0x34

	// Methods

	// RVA: 0x2F34E40 Offset: 0x2F34F41 VA: 0x2F34E40
	public void .ctor() { }

	// RVA: 0x2F34E50 Offset: 0x2F34F51 VA: 0x2F34E50
	internal void <ActionMovePerson>b__0(Unit unit) { }
}

// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x275580 Offset: 0x275681 VA: 0x275580
private sealed class AIThink.<>c__DisplayClass153_0 // TypeDefIndex: 9344
{
	// Fields
	public AIValue v0; // 0x10
	public uint score; // 0x18
	public int tx; // 0x1C
	public int tz; // 0x20

	// Methods

	// RVA: 0x2F35030 Offset: 0x2F35131 VA: 0x2F35030
	public void .ctor() { }

	// RVA: 0x2F35040 Offset: 0x2F35141 VA: 0x2F35040
	internal void <ActionMoveTerrain>b__0(int x, int z) { }
}

// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x275590 Offset: 0x275691 VA: 0x275590
private sealed class AIThink.<>c__DisplayClass154_0 // TypeDefIndex: 9345
{
	// Fields
	public AIThink <>4__this; // 0x10
	public PersonData person; // 0x18
	public int score; // 0x20
	public Unit target; // 0x28
	public int targetX; // 0x30
	public int targetZ; // 0x34

	// Methods

	// RVA: 0x2F352E0 Offset: 0x2F353E1 VA: 0x2F352E0
	public void .ctor() { }

	// RVA: 0x2F352F0 Offset: 0x2F353F1 VA: 0x2F352F0
	internal void <ActionMoveForce>b__0(Unit unit) { }
}

// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x2755A0 Offset: 0x2756A1 VA: 0x2755A0
private sealed class AIThink.<>c__DisplayClass156_0 // TypeDefIndex: 9346
{
	// Fields
	public AIDeploy deploy; // 0x10
	public uint score; // 0x18
	public int tx; // 0x1C
	public int tz; // 0x20

	// Methods

	// RVA: 0x2F354D0 Offset: 0x2F355D1 VA: 0x2F354D0
	public void .ctor() { }

	// RVA: 0x2F354E0 Offset: 0x2F355E1 VA: 0x2F354E0
	internal void <ActionMoveTreasure>b__0(int x, int z) { }
}

// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x2755B0 Offset: 0x2756B1 VA: 0x2755B0
private sealed class AIThink.<>c__DisplayClass157_0 // TypeDefIndex: 9347
{
	// Fields
	public AIDeploy deploy; // 0x10
	public uint score; // 0x18
	public int tx; // 0x1C
	public int tz; // 0x20

	// Methods

	// RVA: 0x2F35630 Offset: 0x2F35731 VA: 0x2F35630
	public void .ctor() { }

	// RVA: 0x2F35640 Offset: 0x2F35741 VA: 0x2F35640
	internal void <ActionMoveVillage>b__0(int x, int z) { }
}

// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x2755C0 Offset: 0x2756C1 VA: 0x2755C0
private sealed class AIThink.<>c__DisplayClass158_0 // TypeDefIndex: 9348
{
	// Fields
	public AIDeploy deploy; // 0x10
	public AIThink <>4__this; // 0x18
	public uint score; // 0x20
	public int tx; // 0x24
	public int tz; // 0x28

	// Methods

	// RVA: 0x2F35790 Offset: 0x2F35891 VA: 0x2F35790
	public void .ctor() { }

	// RVA: 0x2F357A0 Offset: 0x2F358A1 VA: 0x2F357A0
	internal void <ActionMoveEscape>b__0(int x, int z) { }
}

// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x2755D0 Offset: 0x2756D1 VA: 0x2755D0
private sealed class AIThink.<>c__DisplayClass159_0 // TypeDefIndex: 9349
{
	// Fields
	public AIThink <>4__this; // 0x10
	public uint score; // 0x18
	public int tx; // 0x1C
	public int tz; // 0x20

	// Methods

	// RVA: 0x2F35900 Offset: 0x2F35A01 VA: 0x2F35900
	public void .ctor() { }

	// RVA: 0x2F35910 Offset: 0x2F35A11 VA: 0x2F35910
	internal void <ActionMoveTerrainDestroy>b__0(int x, int z, int itemIndex, int targetX, int targetZ) { }
}

// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x2755E0 Offset: 0x2756E1 VA: 0x2755E0
private sealed class AIThink.<>c__DisplayClass160_0 // TypeDefIndex: 9350
{
	// Fields
	public AIThink <>4__this; // 0x10
	public int px; // 0x18
	public int pz; // 0x1C
	public uint score; // 0x20
	public int tx; // 0x24
	public int tz; // 0x28

	// Methods

	// RVA: 0x2F35A50 Offset: 0x2F35B51 VA: 0x2F35A50
	public void .ctor() { }

	// RVA: 0x2F35A60 Offset: 0x2F35B61 VA: 0x2F35A60
	internal void <ActionMoveRetreat>b__0(int x, int z, int range) { }
}

// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x2755F0 Offset: 0x2756F1 VA: 0x2755F0
private sealed class AIThink.<>c__DisplayClass161_0 // TypeDefIndex: 9351
{
	// Fields
	public uint score; // 0x10
	public int tx; // 0x14
	public int tz; // 0x18

	// Methods

	// RVA: 0x2F35CD0 Offset: 0x2F35DD1 VA: 0x2F35CD0
	public void .ctor() { }

	// RVA: 0x2F35CE0 Offset: 0x2F35DE1 VA: 0x2F35CE0
	internal void <ActionMoveBreakDown>b__0(int x, int z) { }
}

// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x275600 Offset: 0x275701 VA: 0x275600
private sealed class AIThink.<>c__DisplayClass162_0 // TypeDefIndex: 9352
{
	// Fields
	public AIThink <>4__this; // 0x10
	public int attackFlag; // 0x18
	public AIThink.AttackPositionResult apResult; // 0x1C
	public AIThink.AttackScoreResult asResult; // 0x34
	public int score; // 0x60
	public Unit target; // 0x68
	public int targetX; // 0x70
	public int targetZ; // 0x74
	public int moveX; // 0x78
	public int moveZ; // 0x7C
	public uint rewarpScore; // 0x80
	public UnitItem rewarpItem; // 0x88
	public int rewarpUseX; // 0x90
	public int rewarpUseZ; // 0x94
	public int rewarpTargetX; // 0x98
	public int rewarpTargetZ; // 0x9C

	// Methods

	// RVA: 0x2F35E00 Offset: 0x2F35F01 VA: 0x2F35E00
	public void .ctor() { }

	// RVA: 0x2F35E10 Offset: 0x2F35F11 VA: 0x2F35E10
	internal void <ActionMoveRewarp>b__0(Unit unit) { }

	// RVA: 0x2F36130 Offset: 0x2F36231 VA: 0x2F36130
	internal void <ActionMoveRewarp>b__1(int x, int z) { }
}

// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x275610 Offset: 0x275711 VA: 0x275610
private sealed class AIThink.<>c__DisplayClass164_0 // TypeDefIndex: 9353
{
	// Fields
	public MapDeployMoveImage moveImage; // 0x10
	public uint score; // 0x18
	public int xx; // 0x1C
	public int zz; // 0x20

	// Methods

	// RVA: 0x2F364A0 Offset: 0x2F365A1 VA: 0x2F364A0
	public void .ctor() { }

	// RVA: 0x2F364B0 Offset: 0x2F365B1 VA: 0x2F364B0
	internal void <GetRewarpPosition>b__0(int x, int z, int range) { }
}

// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x275620 Offset: 0x275721 VA: 0x275620
private sealed class AIThink.<>c__DisplayClass167_0 // TypeDefIndex: 9354
{
	// Fields
	public AIThink <>4__this; // 0x10
	public uint score; // 0x18
	public int tx; // 0x1C
	public int tz; // 0x20

	// Methods

	// RVA: 0x2F36610 Offset: 0x2F36711 VA: 0x2F36610
	public void .ctor() { }

	// RVA: 0x2F36620 Offset: 0x2F36721 VA: 0x2F36620
	internal void <ActionRemove>b__0(int x, int z, int range) { }
}

// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x275630 Offset: 0x275731 VA: 0x275630
private sealed class AIThink.<>c__DisplayClass168_0 // TypeDefIndex: 9355
{
	// Fields
	public AIThink <>4__this; // 0x10
	public int flag; // 0x18
	public AIThink.AttackScoreResult asResult; // 0x1C
	public AIThink.AttackTarget target; // 0x48

	// Methods

	// RVA: 0x2F368B0 Offset: 0x2F369B1 VA: 0x2F368B0
	public void .ctor() { }

	// RVA: 0x2F368C0 Offset: 0x2F369C1 VA: 0x2F368C0
	internal void <ActionRemagic>b__0(Unit unit) { }
}

// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x275640 Offset: 0x275741 VA: 0x275640
private sealed class AIThink.<>c__DisplayClass170_0 // TypeDefIndex: 9356
{
	// Fields
	public Force force; // 0x10
	public Unit actor; // 0x18
	public int friendX; // 0x20
	public int friendZ; // 0x24
	public int friendCount; // 0x28
	public int properRange; // 0x2C
	public MapImageCoreByte workingImage; // 0x30
	public int enemyX; // 0x38
	public int enemyZ; // 0x3C
	public int enemyCount; // 0x40
	public bool isRough; // 0x44
	public uint score; // 0x48
	public int tx; // 0x4C
	public int tz; // 0x50
	public MapFor.RangeFunction <>9__2; // 0x58

	// Methods

	// RVA: 0x2F36AF0 Offset: 0x2F36BF1 VA: 0x2F36AF0
	public void .ctor() { }

	// RVA: 0x2F36B00 Offset: 0x2F36C01 VA: 0x2F36B00
	internal void <GetRerewarpPosition>b__0(Unit unit) { }

	// RVA: 0x2F36D10 Offset: 0x2F36E11 VA: 0x2F36D10
	internal void <GetRerewarpPosition>b__2(int x, int z, int range) { }

	// RVA: 0x2F36E00 Offset: 0x2F36F01 VA: 0x2F36E00
	internal void <GetRerewarpPosition>b__1(int x, int z) { }
}

// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x275650 Offset: 0x275751 VA: 0x275650
private sealed class AIThink.<>c__DisplayClass171_0 // TypeDefIndex: 9357
{
	// Fields
	public AIThink <>4__this; // 0x10
	public bool isPerson; // 0x18
	public AIValue v1; // 0x20
	public bool isExcludeSelf; // 0x28
	public AIDeploy deploy; // 0x30
	public int bandThreshold; // 0x38
	public bool ret; // 0x3C

	// Methods

	// RVA: 0x2F37190 Offset: 0x2F37291 VA: 0x2F37190
	public void .ctor() { }

	// RVA: 0x2F371A0 Offset: 0x2F372A1 VA: 0x2F371A0
	internal MapFor.Return <IsEnemyInsideAttackAreaForAC>b__0(Unit unit) { }
}

// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x275660 Offset: 0x275761 VA: 0x275660
private sealed class AIThink.<>c__DisplayClass172_0 // TypeDefIndex: 9358
{
	// Fields
	public AIThink <>4__this; // 0x10
	public int command; // 0x18
	public AIValue v0; // 0x20
	public AIValue v1; // 0x28
	public Unit actor; // 0x30
	public int attackFlag; // 0x38
	public AIThink.AttackPositionResult apResult; // 0x3C
	public AIThink.InterferenceScoreResult isResult; // 0x54
	public bool isFound; // 0x6C

	// Methods

	// RVA: 0x2F37350 Offset: 0x2F37451 VA: 0x2F37350
	public void .ctor() { }

	// RVA: 0x2F37360 Offset: 0x2F37461 VA: 0x2F37360
	internal MapFor.Return <IsAttackableEnemy>b__0(Unit unit) { }
}

// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x275670 Offset: 0x275771 VA: 0x275670
private sealed class AIThink.<>c__DisplayClass173_0 // TypeDefIndex: 9359
{
	// Fields
	public AIThink <>4__this; // 0x10
	public Unit actor; // 0x18
	public int itemIndex; // 0x20
	public AIThink.AttackPositionResult apResult; // 0x24
	public bool isFound; // 0x3C

	// Methods

	// RVA: 0x2F375D0 Offset: 0x2F376D1 VA: 0x2F375D0
	public void .ctor() { }

	// RVA: 0x2F375E0 Offset: 0x2F376E1 VA: 0x2F375E0
	internal MapFor.Return <IsAttackableEnemyForEntrust>b__0(Unit unit) { }
}

// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x275680 Offset: 0x275781 VA: 0x275680
private sealed class AIThink.<>c__DisplayClass174_0 // TypeDefIndex: 9360
{
	// Fields
	public AIThink <>4__this; // 0x10
	public int command; // 0x18
	public AIValue v0; // 0x20
	public AIValue v1; // 0x28
	public int flag; // 0x30
	public int priorItemIndex; // 0x34
	public SkillData commandSkill; // 0x38
	public int bulletPattern; // 0x40
	public AIThink.AttackScoreResult asResult; // 0x44
	public AIThink.AttackTarget target; // 0x70

	// Methods

	// RVA: 0x2F377A0 Offset: 0x2F378A1 VA: 0x2F377A0
	public void .ctor() { }

	// RVA: 0x2F377B0 Offset: 0x2F378B1 VA: 0x2F377B0
	internal void <AttackTo>b__0(Unit unit) { }
}

// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x275690 Offset: 0x275791 VA: 0x275690
private sealed class AIThink.<>c__DisplayClass211_0 // TypeDefIndex: 9361
{
	// Fields
	public AIThink <>4__this; // 0x10
	public UnitItem warpRodItem; // 0x18
	public bool isFarZ; // 0x20
	public int warpRodItemIndex; // 0x24
	public int attackFlag; // 0x28
	public AIThink.WarpRodEvaluationResult wreResult; // 0x2C
	public AIThink.WarpRodTarget target; // 0x50

	// Methods

	// RVA: 0x2F379A0 Offset: 0x2F37AA1 VA: 0x2F379A0
	public void .ctor() { }

	// RVA: 0x2F379B0 Offset: 0x2F37AB1 VA: 0x2F379B0
	internal void <RodWarpTo>b__0(Unit unit) { }
}

// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x2756A0 Offset: 0x2757A1 VA: 0x2756A0
private sealed class AIThink.<>c__DisplayClass212_0 // TypeDefIndex: 9362
{
	// Fields
	public Unit target; // 0x10
	public int enemyDist; // 0x18
	public Unit enemyUnit; // 0x20
	public int warpX; // 0x28
	public uint score; // 0x2C
	public int warpZ; // 0x30

	// Methods

	// RVA: 0x2F37BC0 Offset: 0x2F37CC1 VA: 0x2F37BC0
	public void .ctor() { }

	// RVA: 0x2F37BD0 Offset: 0x2F37CD1 VA: 0x2F37BD0
	internal void <GetWarpRodEvalution>b__0(Unit unit) { }

	// RVA: 0x2F37CA0 Offset: 0x2F37DA1 VA: 0x2F37CA0
	internal void <GetWarpRodEvalution>b__1(int x, int z) { }
}

// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x2756B0 Offset: 0x2757B1 VA: 0x2756B0
private sealed class AIThink.<>c__DisplayClass213_0 // TypeDefIndex: 9363
{
	// Fields
	public Unit target; // 0x10
	public int warpX; // 0x18
	public uint score; // 0x1C
	public int warpZ; // 0x20

	// Methods

	// RVA: 0x2F38050 Offset: 0x2F38151 VA: 0x2F38050
	public void .ctor() { }

	// RVA: 0x2F38060 Offset: 0x2F38161 VA: 0x2F38060
	internal void <GetWarpRodFarZEvalution>b__0(int x, int z) { }
}

// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x2756C0 Offset: 0x2757C1 VA: 0x2756C0
private sealed class AIThink.<>c__DisplayClass214_0 // TypeDefIndex: 9364
{
	// Fields
	public AIThink <>4__this; // 0x10
	public UnitItem rescueRodItem; // 0x18
	public int rescueRodItemIndex; // 0x20
	public int attackFlag; // 0x24
	public AIThink.RescueRodScoreResult rrsResult; // 0x28
	public AIThink.RescueRodTarget target; // 0x40

	// Methods

	// RVA: 0x2F381B0 Offset: 0x2F382B1 VA: 0x2F381B0
	public void .ctor() { }

	// RVA: 0x2F381C0 Offset: 0x2F382C1 VA: 0x2F381C0
	internal void <RodRescueTo>b__0(Unit unit) { }
}

// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x2756D0 Offset: 0x2757D1 VA: 0x2756D0
private sealed class AIThink.<>c__DisplayClass216_0 // TypeDefIndex: 9365
{
	// Fields
	public AIThink <>4__this; // 0x10
	public bool isPerson; // 0x18
	public AIValue v1; // 0x20
	public AIDeploy deploy; // 0x28
	public bool ret; // 0x30

	// Methods

	// RVA: 0x2F383C0 Offset: 0x2F384C1 VA: 0x2F383C0
	public void .ctor() { }

	// RVA: 0x2F383D0 Offset: 0x2F384D1 VA: 0x2F383D0
	internal MapFor.Return <IsEnemyInsideInterferenceArea>b__0(Unit unit) { }
}

// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x2756E0 Offset: 0x2757E1 VA: 0x2756E0
private sealed class AIThink.<>c__DisplayClass217_0 // TypeDefIndex: 9366
{
	// Fields
	public AIThink <>4__this; // 0x10
	public int command; // 0x18
	public AIValue v0; // 0x20
	public AIValue v1; // 0x28
	public int lx; // 0x30
	public int rx; // 0x34
	public int tz; // 0x38
	public int bz; // 0x3C
	public int attackFlag; // 0x40
	public AIThink.InterferenceScoreResult isResult; // 0x44
	public AIThink.InterferenceTarget target; // 0x60

	// Methods

	// RVA: 0x2F384F0 Offset: 0x2F385F1 VA: 0x2F384F0
	public void .ctor() { }

	// RVA: 0x2F38500 Offset: 0x2F38601 VA: 0x2F38500
	internal void <InterferenceTo>b__0(Unit unit) { }
}

// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x2756F0 Offset: 0x2757F1 VA: 0x2756F0
private sealed class AIThink.<>c__DisplayClass219_0 // TypeDefIndex: 9367
{
	// Fields
	public AIThink <>4__this; // 0x10
	public uint score; // 0x18
	public Unit target; // 0x20
	public int moveX; // 0x28
	public int moveZ; // 0x2C
	public int attackX; // 0x30
	public int attackZ; // 0x34
	public int targetX; // 0x38
	public int targetZ; // 0x3C
	public int itemIndex; // 0x40

	// Methods

	// RVA: 0x2F38860 Offset: 0x2F38961 VA: 0x2F38860
	public void .ctor() { }

	// RVA: 0x2F38870 Offset: 0x2F38971 VA: 0x2F38870
	internal void <RodHealTo>b__0(Unit unit) { }
}

// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x275700 Offset: 0x275801 VA: 0x275700
private sealed class AIThink.<>c__DisplayClass224_0 // TypeDefIndex: 9368
{
	// Fields
	public AIThink <>4__this; // 0x10
	public AIThink.HealRodScoreImplResult hrsiResult; // 0x18
	public int i; // 0x30

	// Methods

	// RVA: 0x2F389C0 Offset: 0x2F38AC1 VA: 0x2F389C0
	public void .ctor() { }
}

// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x275710 Offset: 0x275811 VA: 0x275710
private sealed class AIThink.<>c__DisplayClass224_1 // TypeDefIndex: 9369
{
	// Fields
	public int allHeal; // 0x10
	public int allDamage; // 0x14
	public AIThink.<>c__DisplayClass224_0 CS$<>8__locals1; // 0x18

	// Methods

	// RVA: 0x2F389D0 Offset: 0x2F38AD1 VA: 0x2F389D0
	public void .ctor() { }

	// RVA: 0x2F389E0 Offset: 0x2F38AE1 VA: 0x2F389E0
	internal void <GetRangeHealRodScore>b__0(Unit unit) { }

	// RVA: 0x2F38A70 Offset: 0x2F38B71 VA: 0x2F38A70
	internal void <GetRangeHealRodScore>b__1(Unit unit) { }
}

// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x275720 Offset: 0x275821 VA: 0x275720
private sealed class AIThink.<>c__DisplayClass225_0 // TypeDefIndex: 9370
{
	// Fields
	public Unit actor; // 0x10
	public bool isAheadIgnore; // 0x18
	public bool isNearest; // 0x19
	public uint score; // 0x1C
	public int moveX; // 0x20
	public int moveZ; // 0x24
	public int attackX; // 0x28
	public int attackZ; // 0x2C
	public uint mRange; // 0x30

	// Methods

	// RVA: 0x2F38B00 Offset: 0x2F38C01 VA: 0x2F38B00
	public void .ctor() { }

	// RVA: 0x2F38B10 Offset: 0x2F38C11 VA: 0x2F38B10
	internal void <GetHealRodPosition>b__0(int x, int z) { }

	// RVA: 0x2F38C60 Offset: 0x2F38D61 VA: 0x2F38C60
	internal void <GetHealRodPosition>b__1(int x, int z, int range) { }
}

// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x275730 Offset: 0x275831 VA: 0x275730
private sealed class AIThink.<>c__DisplayClass227_0 // TypeDefIndex: 9371
{
	// Fields
	public Unit actor; // 0x10
	public UnitItem rod; // 0x18
	public int rangeO; // 0x20
	public int moveX; // 0x24
	public int moveZ; // 0x28
	public int rangeI; // 0x2C

	// Methods

	// RVA: 0x2F38DB0 Offset: 0x2F38EB1 VA: 0x2F38DB0
	public void .ctor() { }

	// RVA: 0x2F38DC0 Offset: 0x2F38EC1 VA: 0x2F38DC0
	internal void <UpdateHealConditionByRod>b__0(Unit unit) { }
}

// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x275740 Offset: 0x275841 VA: 0x275740
private sealed class AIThink.<>c__DisplayClass233_0 // TypeDefIndex: 9372
{
	// Fields
	public AIThink <>4__this; // 0x10
	public uint score; // 0x18
	public int workX; // 0x1C
	public int workZ; // 0x20
	public bool isInMoveRange; // 0x24
	public int movePower; // 0x28
	public int heal; // 0x2C

	// Methods

	// RVA: 0x2F39170 Offset: 0x2F39271 VA: 0x2F39170
	public void .ctor() { }

	// RVA: 0x2F39180 Offset: 0x2F39281 VA: 0x2F39180
	internal void <GetTerrainHealPosition>b__0(Unit unit) { }

	// RVA: 0x2F39550 Offset: 0x2F39651 VA: 0x2F39550
	internal void <GetTerrainHealPosition>b__1(int xx, int zz) { }
}

// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x275750 Offset: 0x275851 VA: 0x275750
private sealed class AIThink.<>c__DisplayClass235_0 // TypeDefIndex: 9373
{
	// Fields
	public AIThink <>4__this; // 0x10
	public Unit target; // 0x18
	public uint score; // 0x20
	public int tx; // 0x24
	public int tz; // 0x28

	// Methods

	// RVA: 0x2F397A0 Offset: 0x2F398A1 VA: 0x2F397A0
	public void .ctor() { }

	// RVA: 0x2F397B0 Offset: 0x2F398B1 VA: 0x2F397B0
	internal void <DanceTo>b__0(Unit unit) { }
}

// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x275760 Offset: 0x275861 VA: 0x275760
private sealed class AIThink.<>c__DisplayClass236_0 // TypeDefIndex: 9374
{
	// Fields
	public AIThink <>4__this; // 0x10
	public int command; // 0x18
	public AIValue v0; // 0x20
	public AIValue v1; // 0x28
	public PersonData person; // 0x30
	public int tx; // 0x38
	public uint score; // 0x3C
	public int tz; // 0x40

	// Methods

	// RVA: 0x2F3AD10 Offset: 0x2F3AE11 VA: 0x2F3AD10
	public void .ctor() { }

	// RVA: 0x2F3AD20 Offset: 0x2F3AE21 VA: 0x2F3AD20
	internal void <GuardTo>b__0(Unit unit) { }
}

// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x275770 Offset: 0x275871 VA: 0x275770
private sealed class AIThink.<>c__DisplayClass236_1 // TypeDefIndex: 9375
{
	// Fields
	public int flag; // 0x10
	public AIThink.AttackScoreResult asResult; // 0x14
	public AIThink.AttackTarget target; // 0x40
	public AIThink.<>c__DisplayClass236_0 CS$<>8__locals1; // 0x80

	// Methods

	// RVA: 0x2F3B2E0 Offset: 0x2F3B3E1 VA: 0x2F3B2E0
	public void .ctor() { }

	// RVA: 0x2F3B2F0 Offset: 0x2F3B3F1 VA: 0x2F3B2F0
	internal void <GuardTo>b__1(Unit unit) { }
}

// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x275780 Offset: 0x275881 VA: 0x275780
private sealed class AIThink.<>c__DisplayClass237_0 // TypeDefIndex: 9376
{
	// Fields
	public AIThink <>4__this; // 0x10
	public uint score; // 0x18
	public int px; // 0x1C
	public int pz; // 0x20
	public int tx; // 0x24
	public int tz; // 0x28
	public int item; // 0x2C

	// Methods

	// RVA: 0x2F3B4E0 Offset: 0x2F3B5E1 VA: 0x2F3B4E0
	public void .ctor() { }

	// RVA: 0x2F3B4F0 Offset: 0x2F3B5F1 VA: 0x2F3B4F0
	internal void <TerrainDestroyTo>b__0(int x, int z, int itemIndex, int targetX, int targetZ) { }
}

// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x275790 Offset: 0x275891 VA: 0x275790
private sealed class AIThink.<>c__DisplayClass239_0 // TypeDefIndex: 9377
{
	// Fields
	public AIThink <>4__this; // 0x10
	public int command; // 0x18
	public AIValue v0; // 0x20
	public AIValue v1; // 0x28
	public SkillData engageAttack; // 0x30
	public int flag; // 0x38
	public AIThink.AttackScoreResult asResult; // 0x3C
	public AIThink.AttackTarget target; // 0x68

	// Methods

	// RVA: 0x2F3B710 Offset: 0x2F3B811 VA: 0x2F3B710
	public void .ctor() { }

	// RVA: 0x2F3B720 Offset: 0x2F3B821 VA: 0x2F3B720
	internal void <EngageAttackTo>b__0(Unit unit) { }
}

// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x2757A0 Offset: 0x2758A1 VA: 0x2757A0
private sealed class AIThink.<>c__DisplayClass241_0 // TypeDefIndex: 9378
{
	// Fields
	public AIThink <>4__this; // 0x10
	public uint score; // 0x18
	public int workMoveX; // 0x1C
	public int workMoveZ; // 0x20

	// Methods

	// RVA: 0x2F3B960 Offset: 0x2F3BA61 VA: 0x2F3B960
	public void .ctor() { }

	// RVA: 0x2F3B970 Offset: 0x2F3BA71 VA: 0x2F3B970
	internal void <GetEngageRewarpPos>b__0(int x, int z, int range) { }
}

// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x2757B0 Offset: 0x2758B1 VA: 0x2757B0
private sealed class AIThink.<>c__DisplayClass243_0 // TypeDefIndex: 9379
{
	// Fields
	public int rangeI; // 0x10
	public int rangeO; // 0x14
	public AIThink <>4__this; // 0x18
	public ItemData engageItem; // 0x20
	public uint score; // 0x28
	public int workMoveX; // 0x2C
	public int workMoveZ; // 0x30

	// Methods

	// RVA: 0x2F3BB80 Offset: 0x2F3BC81 VA: 0x2F3BB80
	public void .ctor() { }

	// RVA: 0x2F3BB90 Offset: 0x2F3BC91 VA: 0x2F3BB90
	internal void <EngageDanceToCommon>b__0(int x, int z) { }
}

// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x2757C0 Offset: 0x2758C1 VA: 0x2757C0
private sealed class AIThink.<>c__DisplayClass243_1 // TypeDefIndex: 9380
{
	// Fields
	public bool isValid; // 0x10
	public uint tempScore; // 0x14
	public AIThink.<>c__DisplayClass243_0 CS$<>8__locals1; // 0x18

	// Methods

	// RVA: 0x2F3BEC0 Offset: 0x2F3BFC1 VA: 0x2F3BEC0
	public void .ctor() { }

	// RVA: 0x2F3BED0 Offset: 0x2F3BFD1 VA: 0x2F3BED0
	internal void <EngageDanceToCommon>b__1(int xx, int zz, int range) { }
}

// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x2757D0 Offset: 0x2758D1 VA: 0x2757D0
private sealed class AIThink.<>c__DisplayClass244_0 // TypeDefIndex: 9381
{
	// Fields
	public AIThink <>4__this; // 0x10
	public int command; // 0x18
	public AIValue v0; // 0x20
	public AIValue v1; // 0x28
	public int flag; // 0x30
	public SkillData engageAttack; // 0x38
	public AIThink.AttackScoreResult asResult; // 0x40
	public AIThink.AttackTarget target; // 0x70

	// Methods

	// RVA: 0x2F3C210 Offset: 0x2F3C311 VA: 0x2F3C210
	public void .ctor() { }

	// RVA: 0x2F3C220 Offset: 0x2F3C321 VA: 0x2F3C220
	internal void <EngagePierceTo>b__0(Unit unit) { }
}

// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x2757E0 Offset: 0x2758E1 VA: 0x2757E0
private sealed class AIThink.<>c__DisplayClass246_0 // TypeDefIndex: 9382
{
	// Fields
	public AIThink <>4__this; // 0x10
	public int hp; // 0x18
	public SkillData engageAttack; // 0x20
	public uint score; // 0x28
	public int workMoveX; // 0x2C
	public int workMoveZ; // 0x30

	// Methods

	// RVA: 0x2F3C410 Offset: 0x2F3C511 VA: 0x2F3C410
	public void .ctor() { }

	// RVA: 0x2F3C420 Offset: 0x2F3C521 VA: 0x2F3C420
	internal void <EngageChargeToCommon>b__0(int x, int z) { }
}

// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x2757F0 Offset: 0x2758F1 VA: 0x2757F0
private sealed class AIThink.<>c__DisplayClass246_1 // TypeDefIndex: 9383
{
	// Fields
	public uint tempScore; // 0x10
	public AIThink.<>c__DisplayClass246_0 CS$<>8__locals1; // 0x18

	// Methods

	// RVA: 0x2F3C770 Offset: 0x2F3C871 VA: 0x2F3C770
	public void .ctor() { }

	// RVA: 0x2F3C780 Offset: 0x2F3C881 VA: 0x2F3C780
	internal void <EngageChargeToCommon>b__1(int xx, int zz, Unit target) { }
}

// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x275800 Offset: 0x275901 VA: 0x275800
private sealed class AIThink.<>c__DisplayClass248_0 // TypeDefIndex: 9384
{
	// Fields
	public AIThink <>4__this; // 0x10
	public uint score; // 0x18
	public int workMoveX; // 0x1C
	public int workMoveZ; // 0x20

	// Methods

	// RVA: 0x2F3C810 Offset: 0x2F3C911 VA: 0x2F3C810
	public void .ctor() { }

	// RVA: 0x2F3C820 Offset: 0x2F3C921 VA: 0x2F3C820
	internal void <EngageHealToCommon>b__0(int x, int z) { }
}

// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x275810 Offset: 0x275911 VA: 0x275810
private sealed class AIThink.<>c__DisplayClass249_0 // TypeDefIndex: 9385
{
	// Fields
	public Unit actor; // 0x10
	public AIThink <>4__this; // 0x18
	public UnitItem engageEquipItem; // 0x20
	public int targetCount; // 0x28

	// Methods

	// RVA: 0x2F3CA50 Offset: 0x2F3CB51 VA: 0x2F3CA50
	public void .ctor() { }

	// RVA: 0x2F3CA60 Offset: 0x2F3CB61 VA: 0x2F3CA60
	internal void <EngageHealToCountTarget>b__0(Unit target) { }
}

// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x275820 Offset: 0x275921 VA: 0x275820
private sealed class AIThink.<>c__DisplayClass250_0 // TypeDefIndex: 9386
{
	// Fields
	public AIThink <>4__this; // 0x10
	public bool isEntrust; // 0x18
	public int itemIndex; // 0x1C
	public int attackFlag; // 0x20
	public AIThink.AttackPositionResult apResult; // 0x24
	public AIThink.EntrustAttackScoreResult easResult; // 0x3C
	public bool isClever; // 0x58
	public AIThink.AttackScoreResult asResult; // 0x5C
	public uint score; // 0x88
	public Unit target; // 0x90
	public int targetX; // 0x98
	public int targetZ; // 0x9C
	public int moveX; // 0xA0
	public int moveZ; // 0xA4

	// Methods

	// RVA: 0x2F3CB90 Offset: 0x2F3CC91 VA: 0x2F3CB90
	public void .ctor() { }

	// RVA: 0x2F3CBA0 Offset: 0x2F3CCA1 VA: 0x2F3CBA0
	internal void <EngageVisionTo>b__0(Unit unit) { }

	// RVA: 0x2F3CEC0 Offset: 0x2F3CFC1 VA: 0x2F3CEC0
	internal void <EngageVisionTo>b__1(int x, int z) { }
}

// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x275830 Offset: 0x275931 VA: 0x275830
private sealed class AIThink.<>c__DisplayClass252_0 // TypeDefIndex: 9387
{
	// Fields
	public AIThink <>4__this; // 0x10
	public SkillData commandSkill; // 0x18
	public uint score; // 0x20
	public int moveX; // 0x24
	public int moveZ; // 0x28
	public Unit target; // 0x30

	// Methods

	// RVA: 0x2F3D150 Offset: 0x2F3D251 VA: 0x2F3D150
	public void .ctor() { }

	// RVA: 0x2F3D160 Offset: 0x2F3D261 VA: 0x2F3D160
	internal void <EngageSupportToCommon>b__0(int x, int z) { }
}

// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x275840 Offset: 0x275941 VA: 0x275840
private sealed class AIThink.<>c__DisplayClass252_1 // TypeDefIndex: 9388
{
	// Fields
	public uint tempScore; // 0x10
	public Unit tempUnit; // 0x18
	public AIThink.<>c__DisplayClass252_0 CS$<>8__locals1; // 0x20

	// Methods

	// RVA: 0x2F3D4E0 Offset: 0x2F3D5E1 VA: 0x2F3D4E0
	public void .ctor() { }

	// RVA: 0x2F3D4F0 Offset: 0x2F3D5F1 VA: 0x2F3D4F0
	internal void <EngageSupportToCommon>b__1(int xx, int zz, int range) { }
}

// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x275850 Offset: 0x275951 VA: 0x275850
private sealed class AIThink.<>c__DisplayClass254_0 // TypeDefIndex: 9389
{
	// Fields
	public AIThink <>4__this; // 0x10
	public SkillData commandSkill; // 0x18
	public uint score; // 0x20
	public int moveX; // 0x24
	public int moveZ; // 0x28
	public Unit target; // 0x30

	// Methods

	// RVA: 0x2F3D930 Offset: 0x2F3DA31 VA: 0x2F3D930
	public void .ctor() { }

	// RVA: 0x2F3D940 Offset: 0x2F3DA41 VA: 0x2F3D940
	internal void <EngagePullBackToCommon>b__0(int x, int z) { }
}

// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x275860 Offset: 0x275961 VA: 0x275860
private sealed class AIThink.<>c__DisplayClass254_1 // TypeDefIndex: 9390
{
	// Fields
	public int x; // 0x10
	public int z; // 0x14
	public AIThink.<>c__DisplayClass254_0 CS$<>8__locals1; // 0x18

	// Methods

	// RVA: 0x2F3DBD0 Offset: 0x2F3DCD1 VA: 0x2F3DBD0
	public void .ctor() { }

	// RVA: 0x2F3DBE0 Offset: 0x2F3DCE1 VA: 0x2F3DBE0
	internal void <EngagePullBackToCommon>b__1(int xx, int zz, int range) { }
}

// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x275870 Offset: 0x275971 VA: 0x275870
private sealed class AIThink.<>c__DisplayClass255_0 // TypeDefIndex: 9391
{
	// Fields
	public AIThink <>4__this; // 0x10
	public bool isEngage; // 0x18

	// Methods

	// RVA: 0x2F3E1D0 Offset: 0x2F3E2D1 VA: 0x2F3E1D0
	public void .ctor() { }

	// RVA: 0x2F3E1E0 Offset: 0x2F3E2E1 VA: 0x2F3E1E0
	internal MapFor.Return <EngageTo>b__0(int x, int z) { }
}

// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x275880 Offset: 0x275981 VA: 0x275880
private sealed class AIThink.<>c__DisplayClass265_0 // TypeDefIndex: 9392
{
	// Fields
	public AIDeploy deploy; // 0x10
	public AIThink <>4__this; // 0x18
	public int xx; // 0x20
	public int zz; // 0x24
	public int flag; // 0x28
	public int tx; // 0x2C
	public int tz; // 0x30

	// Methods

	// RVA: 0x2F3E4A0 Offset: 0x2F3E5A1 VA: 0x2F3E4A0
	public void .ctor() { }
}

// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x275890 Offset: 0x275991 VA: 0x275890
private sealed class AIThink.<>c__DisplayClass265_1 // TypeDefIndex: 9393
{
	// Fields
	public int score; // 0x10
	public AIThink.<>c__DisplayClass265_0 CS$<>8__locals1; // 0x18

	// Methods

	// RVA: 0x2F3E4B0 Offset: 0x2F3E5B1 VA: 0x2F3E4B0
	public void .ctor() { }

	// RVA: 0x2F3E4C0 Offset: 0x2F3E5C1 VA: 0x2F3E4C0
	internal void <MoveTo>b__0(int x, int z, int range) { }
}

// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x2758A0 Offset: 0x2759A1 VA: 0x2758A0
private sealed class AIThink.<>c__DisplayClass265_2 // TypeDefIndex: 9394
{
	// Fields
	public uint score; // 0x10
	public AIThink.<>c__DisplayClass265_0 CS$<>8__locals2; // 0x18

	// Methods

	// RVA: 0x2F3E590 Offset: 0x2F3E691 VA: 0x2F3E590
	public void .ctor() { }

	// RVA: 0x2F3E5A0 Offset: 0x2F3E6A1 VA: 0x2F3E5A0
	internal void <MoveTo>b__1(int x, int z) { }
}

// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x2758B0 Offset: 0x2759B1 VA: 0x2758B0
private sealed class AIThink.<>c__DisplayClass266_0 // TypeDefIndex: 9395
{
	// Fields
	public AIThink <>4__this; // 0x10
	public int targetMoveB; // 0x18
	public int x; // 0x1C
	public int z; // 0x20
	public AIThink.AttackScoreResult asResult; // 0x24
	public Unit target; // 0x50
	public uint score; // 0x58
	public int moveX; // 0x5C
	public int moveZ; // 0x60
	public int itemIndex; // 0x64

	// Methods

	// RVA: 0x2F3E9B0 Offset: 0x2F3EAB1 VA: 0x2F3E9B0
	public void .ctor() { }

	// RVA: 0x2F3E9C0 Offset: 0x2F3EAC1 VA: 0x2F3E9C0
	internal void <ToBreak>b__0(Unit unit) { }
}

// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x2758C0 Offset: 0x2759C1 VA: 0x2758C0
private sealed class AIThink.<>c__DisplayClass267_0 // TypeDefIndex: 9396
{
	// Fields
	public int targetMoveB; // 0x10
	public int x; // 0x14
	public int z; // 0x18
	public uint score; // 0x1C
	public int tx; // 0x20
	public int tz; // 0x24
	public PokeInspector targetInspector; // 0x28

	// Methods

	// RVA: 0x2F3EBA0 Offset: 0x2F3ECA1 VA: 0x2F3EBA0
	public void .ctor() { }

	// RVA: 0x2F3EBB0 Offset: 0x2F3ECB1 VA: 0x2F3EBB0
	internal void <ToDoor>b__0(int xx, int zz, PokeInspector inspector) { }
}

// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x2758D0 Offset: 0x2759D1 VA: 0x2758D0
private sealed class AIThink.<>c__DisplayClass268_0 // TypeDefIndex: 9397
{
	// Fields
	public AIThink <>4__this; // 0x10
	public int targetMoveB; // 0x18
	public int moveX; // 0x1C
	public uint score; // 0x20
	public int moveZ; // 0x24
	public int attackX; // 0x28
	public int attackZ; // 0x2C
	public int targetX; // 0x30
	public int targetZ; // 0x34
	public int item; // 0x38

	// Methods

	// RVA: 0x2F3EDC0 Offset: 0x2F3EEC1 VA: 0x2F3EDC0
	public void .ctor() { }

	// RVA: 0x2F3EDD0 Offset: 0x2F3EED1 VA: 0x2F3EDD0
	internal void <ToBlock>b__0(int xx, int zz, int itemIndex, int blockX, int blockZ) { }
}

// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x2758E0 Offset: 0x2759E1 VA: 0x2758E0
private sealed class AIThink.<>c__DisplayClass269_0 // TypeDefIndex: 9398
{
	// Fields
	public MapFor.DestroyFunction func; // 0x10

	// Methods

	// RVA: 0x2F3F040 Offset: 0x2F3F141 VA: 0x2F3F040
	public void .ctor() { }
}

// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x2758F0 Offset: 0x2759F1 VA: 0x2758F0
private sealed class AIThink.<>c__DisplayClass269_1 // TypeDefIndex: 9399
{
	// Fields
	public int overlapX; // 0x10
	public int overlapZ; // 0x14
	public int i; // 0x18
	public AIThink.<>c__DisplayClass269_0 CS$<>8__locals1; // 0x20
	public MapFor.RangeFunction <>9__0; // 0x28

	// Methods

	// RVA: 0x2F3F050 Offset: 0x2F3F151 VA: 0x2F3F050
	public void .ctor() { }

	// RVA: 0x2F3F060 Offset: 0x2F3F161 VA: 0x2F3F060
	internal void <EachBlock>b__0(int px, int pz, int range) { }
}

// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x275900 Offset: 0x275A01 VA: 0x275900
private sealed class AIThink.<>c__DisplayClass270_0 // TypeDefIndex: 9400
{
	// Fields
	public MapFor.DestroyFunction func; // 0x10
	public int itemIndex; // 0x18

	// Methods

	// RVA: 0x2F3F080 Offset: 0x2F3F181 VA: 0x2F3F080
	public void .ctor() { }
}

// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x275910 Offset: 0x275A11 VA: 0x275910
private sealed class AIThink.<>c__DisplayClass270_1 // TypeDefIndex: 9401
{
	// Fields
	public int overlapX; // 0x10
	public int overlapZ; // 0x14
	public AIThink.<>c__DisplayClass270_0 CS$<>8__locals1; // 0x18

	// Methods

	// RVA: 0x2F3F090 Offset: 0x2F3F191 VA: 0x2F3F090
	public void .ctor() { }

	// RVA: 0x2F3F0A0 Offset: 0x2F3F1A1 VA: 0x2F3F0A0
	internal void <EachBlockForEntrust>b__0(int px, int pz, int range) { }
}

// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x275920 Offset: 0x275A21 VA: 0x275920
private sealed class AIThink.<>c__DisplayClass271_0 // TypeDefIndex: 9402
{
	// Fields
	public AIDeploy deploy; // 0x10
	public AIThink <>4__this; // 0x18
	public int score; // 0x20
	public bool ret; // 0x24

	// Methods

	// RVA: 0x2F3F0C0 Offset: 0x2F3F1C1 VA: 0x2F3F0C0
	public void .ctor() { }

	// RVA: 0x2F3F0D0 Offset: 0x2F3F1D1 VA: 0x2F3F0D0
	internal MapFor.Return <IsMoveNear>b__0(int x, int z) { }
}

// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x275930 Offset: 0x275A31 VA: 0x275930
private sealed class AIThink.<>c__DisplayClass273_0 // TypeDefIndex: 9403
{
	// Fields
	public AIThink <>4__this; // 0x10
	public uint score; // 0x18
	public int xx; // 0x1C
	public int zz; // 0x20

	// Methods

	// RVA: 0x2F3F300 Offset: 0x2F3F401 VA: 0x2F3F300
	public void .ctor() { }

	// RVA: 0x2F3F310 Offset: 0x2F3F411 VA: 0x2F3F310
	internal void <GetSidePosition>b__0(int x, int z, int range) { }
}

// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x275940 Offset: 0x275A41 VA: 0x275940
private sealed class AIThink.<>c__DisplayClass280_0 // TypeDefIndex: 9404
{
	// Fields
	public AIThink <>4__this; // 0x10
	public bool isTargetAllied; // 0x18
	public int targetCount; // 0x1C
	public int[] targetDists; // 0x20
	public Unit[] nearTargets; // 0x28
	public int skillRangeMin; // 0x30
	public int skillRangeMax; // 0x34
	public TerrainData skillOverlapTerrain; // 0x38
	public SkillData commandSkill; // 0x40
	public bool isHeal; // 0x48
	public int moveX; // 0x4C
	public uint score; // 0x50
	public int moveZ; // 0x54
	public int targetX; // 0x58
	public int targetZ; // 0x5C

	// Methods

	// RVA: 0x2F3F550 Offset: 0x2F3F651 VA: 0x2F3F550
	public void .ctor() { }

	// RVA: 0x2F3F560 Offset: 0x2F3F661 VA: 0x2F3F560
	internal void <CommandSkillOverlapToCommon>b__0(Unit unit) { }

	// RVA: 0x2F3FE30 Offset: 0x2F3FF31 VA: 0x2F3FE30
	internal void <CommandSkillOverlapToCommon>b__1(int x, int z) { }
}

// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x275950 Offset: 0x275A51 VA: 0x275950
private sealed class AIThink.<>c__DisplayClass280_1 // TypeDefIndex: 9405
{
	// Fields
	public int x; // 0x10
	public int z; // 0x14
	public sbyte move; // 0x18
	public AIThink.<>c__DisplayClass280_0 CS$<>8__locals1; // 0x20

	// Methods

	// RVA: 0x2F400C0 Offset: 0x2F401C1 VA: 0x2F400C0
	public void .ctor() { }

	// RVA: 0x2F400D0 Offset: 0x2F401D1 VA: 0x2F400D0
	internal void <CommandSkillOverlapToCommon>b__3(int tx, int tz, int range) { }
}

// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x275960 Offset: 0x275A61 VA: 0x275960
private sealed class AIThink.<>c__DisplayClass284_0 // TypeDefIndex: 9406
{
	// Fields
	public Unit actor; // 0x10
	public AIDeploy deploy; // 0x18
	public AIThink <>4__this; // 0x20

	// Methods

	// RVA: 0x2F40790 Offset: 0x2F40891 VA: 0x2F40790
	public void .ctor() { }

	// RVA: 0x2F407A0 Offset: 0x2F408A1 VA: 0x2F407A0
	internal MapFor.Return <UpdateTargetOne>b__0(Unit unit) { }

	// RVA: 0x2F40800 Offset: 0x2F40901 VA: 0x2F40800
	internal void <UpdateTargetOne>b__1(Unit unit) { }
}

// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x275970 Offset: 0x275A71 VA: 0x275970
private sealed class AIThink.<>c__DisplayClass285_0 // TypeDefIndex: 9407
{
	// Fields
	public bool isMoreCaution; // 0x10
	public bool isChainGuard; // 0x11
	public bool isIgnoreEngageAttack; // 0x12
	public AIThink <>4__this; // 0x18
	public bool isRemove; // 0x20
	public AIDeploy deploy; // 0x28

	// Methods

	// RVA: 0x2F40940 Offset: 0x2F40A41 VA: 0x2F40940
	public void .ctor() { }

	// RVA: 0x2F40950 Offset: 0x2F40A51 VA: 0x2F40950
	internal void <Caution>b__0(Unit unit) { }
}

// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x275980 Offset: 0x275A81 VA: 0x275980
private sealed class AIThink.<>c__DisplayClass285_1 // TypeDefIndex: 9408
{
	// Fields
	public int maxRange; // 0x10
	public int maxExpectation; // 0x14
	public int maxExpectationLongRange; // 0x18
	public AIThink.<>c__DisplayClass285_0 CS$<>8__locals1; // 0x20

	// Methods

	// RVA: 0x2F41500 Offset: 0x2F41601 VA: 0x2F41500
	public void .ctor() { }

	// RVA: 0x2F41510 Offset: 0x2F41611 VA: 0x2F41510
	internal void <Caution>b__1(int x, int z) { }
}

// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x275990 Offset: 0x275A91 VA: 0x275990
private sealed class AIThink.<>c__DisplayClass295_0 // TypeDefIndex: 9409
{
	// Fields
	public PersonData person; // 0x10
	public bool hasExtraHpStock; // 0x18
	public AIThink <>4__this; // 0x20
	public ItemData engageItem; // 0x28
	public AIThink.HealRodPositionResult hrpResult; // 0x30
	public SkillData engageAttack; // 0x40
	public uint score; // 0x48
	public Unit target; // 0x50
	public int moveX; // 0x58
	public int moveZ; // 0x5C
	public int attackX; // 0x60
	public int attackZ; // 0x64
	public int targetX; // 0x68
	public int targetZ; // 0x6C
	public bool isHeal; // 0x70

	// Methods

	// RVA: 0x2F416F0 Offset: 0x2F417F1 VA: 0x2F416F0
	public void .ctor() { }

	// RVA: 0x2F41700 Offset: 0x2F41801 VA: 0x2F41700
	internal void <EngageBlessToCommon>b__0(Unit unit) { }

	// RVA: 0x2F41760 Offset: 0x2F41861 VA: 0x2F41760
	internal void <EngageBlessToCommon>b__1(Unit unit) { }
}

// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x2759A0 Offset: 0x275AA1 VA: 0x2759A0
private sealed class AIThink.<>c__DisplayClass299_0 // TypeDefIndex: 9410
{
	// Fields
	public AIThink <>4__this; // 0x10
	public int hp; // 0x18
	public AIThink.EngageWaitRangeScore range1Score; // 0x1C
	public AIThink.EngageWaitRangeScore range2Score; // 0x28

	// Methods

	// RVA: 0x2F41940 Offset: 0x2F41A41 VA: 0x2F41940
	public void .ctor() { }

	// RVA: 0x2F41950 Offset: 0x2F41A51 VA: 0x2F41950
	internal void <EngageWaitToCommon>b__0(int x, int z) { }
}

// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x2759B0 Offset: 0x275AB1 VA: 0x2759B0
private sealed class AIThink.<>c__DisplayClass300_0 // TypeDefIndex: 9411
{
	// Fields
	public AIThink <>4__this; // 0x10
	public AIDeploy deploy; // 0x18

	// Methods

	// RVA: 0x2F41B50 Offset: 0x2F41C51 VA: 0x2F41B50
	public void .ctor() { }

	// RVA: 0x2F41B60 Offset: 0x2F41C61 VA: 0x2F41B60
	internal void <EngageWaitCalcAdditionalAttackImage>b__0(Unit unit) { }
}

// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x2759C0 Offset: 0x275AC1 VA: 0x2759C0
private sealed class AIThink.<>c__DisplayClass300_1 // TypeDefIndex: 9412
{
	// Fields
	public int minRange; // 0x10
	public int maxRange; // 0x14
	public AIThink.<>c__DisplayClass300_0 CS$<>8__locals1; // 0x18

	// Methods

	// RVA: 0x2F42AB0 Offset: 0x2F42BB1 VA: 0x2F42AB0
	public void .ctor() { }

	// RVA: 0x2F42AC0 Offset: 0x2F42BC1 VA: 0x2F42AC0
	internal void <EngageWaitCalcAdditionalAttackImage>b__1(int x, int z) { }
}

// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x2759D0 Offset: 0x275AD1 VA: 0x2759D0
private sealed class AIThink.<>c__DisplayClass308_0 // TypeDefIndex: 9413
{
	// Fields
	public AIThink <>4__this; // 0x10
	public uint score; // 0x18
	public int workMoveX; // 0x1C
	public int workMoveZ; // 0x20

	// Methods

	// RVA: 0x2F42C10 Offset: 0x2F42D11 VA: 0x2F42C10
	public void .ctor() { }

	// RVA: 0x2F42C20 Offset: 0x2F42D21 VA: 0x2F42C20
	internal void <EngageSummonToCommon>b__0(int x, int z) { }
}

// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x2759E0 Offset: 0x275AE1 VA: 0x2759E0
private sealed class AIThink.<>c__DisplayClass308_1 // TypeDefIndex: 9414
{
	// Fields
	public bool isEmpty; // 0x10
	public int totalCaution; // 0x14
	public AIThink.<>c__DisplayClass308_0 CS$<>8__locals1; // 0x18

	// Methods

	// RVA: 0x2F42F90 Offset: 0x2F43091 VA: 0x2F42F90
	public void .ctor() { }

	// RVA: 0x2F42FA0 Offset: 0x2F430A1 VA: 0x2F42FA0
	internal void <EngageSummonToCommon>b__1(int xx, int zz, int range) { }
}

// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x2759F0 Offset: 0x275AF1 VA: 0x2759F0
private sealed class AIThink.<>c__DisplayClass309_0 // TypeDefIndex: 9415
{
	// Fields
	public AIThink <>4__this; // 0x10
	public int noneCount; // 0x18
	public int redCount; // 0x1C
	public int greenCount; // 0x20
	public int blueCount; // 0x24

	// Methods

	// RVA: 0x2F430D0 Offset: 0x2F431D1 VA: 0x2F430D0
	public void .ctor() { }

	// RVA: 0x2F430E0 Offset: 0x2F431E1 VA: 0x2F430E0
	internal void <EngageSummonDecideColor>b__0(Unit unit) { }
}

// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x275A00 Offset: 0x275B01 VA: 0x275A00
private sealed class AIThink.<>c__DisplayClass313_0 // TypeDefIndex: 9416
{
	// Fields
	public AIThink <>4__this; // 0x10
	public SkillData engageAttack; // 0x18
	public List<RangeData.Offset> overlapRange; // 0x20
	public TerrainData overlapTerrain; // 0x28
	public int overlapRangeCount; // 0x30
	public uint score; // 0x34
	public int workMoveX; // 0x38
	public int workMoveZ; // 0x3C

	// Methods

	// RVA: 0x2F43510 Offset: 0x2F43611 VA: 0x2F43510
	public void .ctor() { }

	// RVA: 0x2F43520 Offset: 0x2F43621 VA: 0x2F43520
	internal void <EngageOverlapToCommon>b__0(int x, int z) { }
}

// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x275A10 Offset: 0x275B11 VA: 0x275A10
private sealed class AIThink.<>c__DisplayClass317_0 // TypeDefIndex: 9417
{
	// Fields
	public int minRange; // 0x10
	public int maxRange; // 0x14
	public AIThink <>4__this; // 0x18
	public uint score; // 0x20
	public int moveX; // 0x24
	public int moveZ; // 0x28

	// Methods

	// RVA: 0x2F43FD0 Offset: 0x2F440D1 VA: 0x2F43FD0
	public void .ctor() { }

	// RVA: 0x2F43FE0 Offset: 0x2F440E1 VA: 0x2F43FE0
	internal void <ActionRodMagicShield>b__0(int x, int z) { }
}

// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x275A20 Offset: 0x275B21 VA: 0x275A20
private sealed class AIThink.<>c__DisplayClass317_1 // TypeDefIndex: 9418
{
	// Fields
	public uint tempScore; // 0x10
	public AIThink.<>c__DisplayClass317_0 CS$<>8__locals1; // 0x18

	// Methods

	// RVA: 0x2F442C0 Offset: 0x2F443C1 VA: 0x2F442C0
	public void .ctor() { }

	// RVA: 0x2F442D0 Offset: 0x2F443D1 VA: 0x2F442D0
	internal void <ActionRodMagicShield>b__1(int xx, int zz, int range) { }
}

// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x275A30 Offset: 0x275B31 VA: 0x275A30
private sealed class AIThink.<>c__DisplayClass320_0 // TypeDefIndex: 9419
{
	// Fields
	public Unit target; // 0x10
	public AIDeploy deploy; // 0x18
	public int targetMdef; // 0x20
	public int attackCount; // 0x24
	public int totalDamage; // 0x28
	public int maxDamage; // 0x2C
	public int minDamage; // 0x30
	public MapFor.UnitFunction <>9__0; // 0x38

	// Methods

	// RVA: 0x2F44480 Offset: 0x2F44581 VA: 0x2F44480
	public void .ctor() { }

	// RVA: 0x2F44490 Offset: 0x2F44591 VA: 0x2F44490
	internal void <MagicShieldCalcUnitScore>b__0(Unit enemy) { }
}

// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x275A40 Offset: 0x275B41 VA: 0x275A40
private sealed class AIThink.<>c__DisplayClass320_1 // TypeDefIndex: 9420
{
	// Fields
	public bool enemyCanAttack; // 0x10
	public AIThink.<>c__DisplayClass320_0 CS$<>8__locals1; // 0x18

	// Methods

	// RVA: 0x2F45840 Offset: 0x2F45941 VA: 0x2F45840
	public void .ctor() { }

	// RVA: 0x2F45850 Offset: 0x2F45951 VA: 0x2F45850
	internal MapFor.Return <MagicShieldCalcUnitScore>b__1(int x, int z) { }
}

// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x275A50 Offset: 0x275B51 VA: 0x275A50
private sealed class AIThink.<>c__DisplayClass323_0 // TypeDefIndex: 9421
{
	// Fields
	public bool isDecoy; // 0x10
	public AIThink <>4__this; // 0x18
	public bool isEntrust; // 0x20
	public int equipIndex; // 0x24
	public SkillData commandSkill; // 0x28
	public uint score; // 0x30
	public int moveX; // 0x34
	public int moveZ; // 0x38
	public Unit target; // 0x40

	// Methods

	// RVA: 0x2F45950 Offset: 0x2F45A51 VA: 0x2F45950
	public void .ctor() { }

	// RVA: 0x2F45960 Offset: 0x2F45A61 VA: 0x2F45960
	internal MapFor.Return <CommandSkillDecoyTo>b__0(Unit unit) { }

	// RVA: 0x2F45990 Offset: 0x2F45A91 VA: 0x2F45990
	internal void <CommandSkillDecoyTo>b__1(int x, int z) { }
}

// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x275A60 Offset: 0x275B61 VA: 0x275A60
private sealed class AIThink.<>c__DisplayClass323_1 // TypeDefIndex: 9422
{
	// Fields
	public AIThink.EntrustAttackScoreResult easResult; // 0x10
	public bool canKillEnemy; // 0x2C
	public AIThink.AttackScoreResult asResult; // 0x30
	public int nearEnemyCount; // 0x5C
	public AIThink.<>c__DisplayClass323_0 CS$<>8__locals1; // 0x60

	// Methods

	// RVA: 0x2498630 Offset: 0x2498731 VA: 0x2498630
	public void .ctor() { }

	// RVA: 0x2498640 Offset: 0x2498741 VA: 0x2498640
	internal void <CommandSkillDecoyTo>b__2(Unit unit) { }
}

// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x275A70 Offset: 0x275B71 VA: 0x275A70
private sealed class AIThink.<>c__DisplayClass323_2 // TypeDefIndex: 9423
{
	// Fields
	public int x; // 0x10
	public int z; // 0x14
	public AIThink.<>c__DisplayClass323_0 CS$<>8__locals2; // 0x18

	// Methods

	// RVA: 0x2498DC0 Offset: 0x2498EC1 VA: 0x2498DC0
	public void .ctor() { }

	// RVA: 0x2498DD0 Offset: 0x2498ED1 VA: 0x2498DD0
	internal void <CommandSkillDecoyTo>b__3(int xx, int zz, int range) { }
}

// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x275A80 Offset: 0x275B81 VA: 0x275A80
private sealed class AIThink.<>c__DisplayClass324_0 // TypeDefIndex: 9424
{
	// Fields
	public bool isEntrust; // 0x10
	public Unit unit; // 0x18
	public int movePower; // 0x20
	public int totalPhysicalPower; // 0x24
	public int totalMagicPower; // 0x28
	public int enemyCount; // 0x2C

	// Methods

	// RVA: 0x2499250 Offset: 0x2499351 VA: 0x2499250
	public void .ctor() { }

	// RVA: 0x2499260 Offset: 0x2499361 VA: 0x2499260
	internal void <DecoyGetScore>b__0(Unit enemy) { }
}

// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x275A90 Offset: 0x275B91 VA: 0x275A90
private sealed class AIThink.<>c__DisplayClass326_0 // TypeDefIndex: 9425
{
	// Fields
	public bool isEntrust; // 0x10
	public AIThink <>4__this; // 0x18
	public uint score; // 0x20
	public int moveX; // 0x24
	public int moveZ; // 0x28
	public MapFor.PosFunction <>9__2; // 0x30

	// Methods

	// RVA: 0x249A0C0 Offset: 0x249A1C1 VA: 0x249A0C0
	public void .ctor() { }

	// RVA: 0x249A0D0 Offset: 0x249A1D1 VA: 0x249A0D0
	internal void <CommandSkillStrategyHolyShield>b__0(Unit unit) { }

	// RVA: 0x249A920 Offset: 0x249AA21 VA: 0x249A920
	internal void <CommandSkillStrategyHolyShield>b__2(int x, int z) { }

	// RVA: 0x249AA70 Offset: 0x249AB71 VA: 0x249AA70
	internal void <CommandSkillStrategyHolyShield>b__1(int x, int z) { }
}

// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x275AA0 Offset: 0x275BA1 VA: 0x275AA0
private sealed class AIThink.<>c__DisplayClass330_0 // TypeDefIndex: 9426
{
	// Fields
	public AIThink <>4__this; // 0x10
	public AIThink.AttackScoreResult asResult; // 0x18
	public int killEnemyCount; // 0x44

	// Methods

	// RVA: 0x249ACC0 Offset: 0x249ADC1 VA: 0x249ACC0
	public void .ctor() { }

	// RVA: 0x249ACD0 Offset: 0x249ADD1 VA: 0x249ACD0
	internal void <TrimasteriesCountKillEnemies>b__0(Unit unit) { }
}

// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x275AB0 Offset: 0x275BB1 VA: 0x275AB0
private sealed class AIThink.<>c__DisplayClass331_0 // TypeDefIndex: 9427
{
	// Fields
	public AIThink <>4__this; // 0x10
	public int flag; // 0x18
	public SkillData commandSkill; // 0x20
	public AIThink.AttackScoreResult asResult; // 0x28
	public AIThink.AttackTarget target; // 0x58

	// Methods

	// RVA: 0x249AE60 Offset: 0x249AF61 VA: 0x249AE60
	public void .ctor() { }

	// RVA: 0x249AE70 Offset: 0x249AF71 VA: 0x249AE70
	internal void <TrimasteriesThink>b__0(Unit unit) { }
}

// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x275AC0 Offset: 0x275BC1 VA: 0x275AC0
private sealed class AIThink.<>c__DisplayClass332_0 // TypeDefIndex: 9428
{
	// Fields
	public AIThink <>4__this; // 0x10
	public int itemIndex; // 0x18
	public int killEnemyCount; // 0x1C

	// Methods

	// RVA: 0x249B050 Offset: 0x249B151 VA: 0x249B050
	public void .ctor() { }

	// RVA: 0x249B060 Offset: 0x249B161 VA: 0x249B060
	internal void <EntrustTrimasteriesCountKillEnemies>b__0(Unit unit) { }
}

// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x275AD0 Offset: 0x275BD1 VA: 0x275AD0
private sealed class AIThink.<>c__DisplayClass333_0 // TypeDefIndex: 9429
{
	// Fields
	public AIThink <>4__this; // 0x10
	public int itemIndex; // 0x18
	public SkillData commandSkill; // 0x20
	public AIThink.EntrustAttackTarget target; // 0x28

	// Methods

	// RVA: 0x249B270 Offset: 0x249B371 VA: 0x249B270
	public void .ctor() { }

	// RVA: 0x249B280 Offset: 0x249B381 VA: 0x249B280
	internal void <EntrustTrimasteriesThink>b__0(Unit unit) { }
}

// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x275AE0 Offset: 0x275BE1 VA: 0x275AE0
private sealed class AIThink.<>c__DisplayClass336_0 // TypeDefIndex: 9430
{
	// Fields
	public SkillData commandSkill; // 0x10
	public AIThink <>4__this; // 0x18
	public bool isEntrust; // 0x20
	public uint score; // 0x24
	public int moveX; // 0x28
	public int moveZ; // 0x2C
	public Unit target; // 0x30

	// Methods

	// RVA: 0x249B4E0 Offset: 0x249B5E1 VA: 0x249B4E0
	public void .ctor() { }

	// RVA: 0x249B4F0 Offset: 0x249B5F1 VA: 0x249B4F0
	internal void <CommandSkillContractTo>b__0(int x, int z) { }
}

// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x275AF0 Offset: 0x275BF1 VA: 0x275AF0
private sealed class AIThink.<>c__DisplayClass336_1 // TypeDefIndex: 9431
{
	// Fields
	public int x; // 0x10
	public int z; // 0x14
	public AIThink.<>c__DisplayClass336_0 CS$<>8__locals1; // 0x18

	// Methods

	// RVA: 0x249B760 Offset: 0x249B861 VA: 0x249B760
	public void .ctor() { }

	// RVA: 0x249B770 Offset: 0x249B871 VA: 0x249B770
	internal void <CommandSkillContractTo>b__1(int xx, int zz, int range) { }
}

// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x275B00 Offset: 0x275C01 VA: 0x275B00
private sealed class AIThink.<>c__DisplayClass337_0 // TypeDefIndex: 9432
{
	// Fields
	public Unit unit; // 0x10
	public AIThink <>4__this; // 0x18
	public AIThink.AttackScoreResult asResult; // 0x20
	public AIThink.AttackTarget target; // 0x50
	public AIThink.AttackScoreResult asActorResult; // 0x90
	public bool isActorAttack; // 0xBC

	// Methods

	// RVA: 0x249BCE0 Offset: 0x249BDE1 VA: 0x249BCE0
	public void .ctor() { }

	// RVA: 0x249BCF0 Offset: 0x249BDF1 VA: 0x249BCF0
	internal void <ContractGetBattleScore>b__0(Unit enemy) { }
}

// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x275B10 Offset: 0x275C11 VA: 0x275B10
private sealed class AIThink.<>c__DisplayClass338_0 // TypeDefIndex: 9433
{
	// Fields
	public Unit unit; // 0x10
	public AIThink <>4__this; // 0x18
	public int itemIndex; // 0x20
	public AIThink.EntrustAttackTarget target; // 0x28
	public bool isActorAttack; // 0x58

	// Methods

	// RVA: 0x249C0B0 Offset: 0x249C1B1 VA: 0x249C0B0
	public void .ctor() { }

	// RVA: 0x249C0C0 Offset: 0x249C1C1 VA: 0x249C0C0
	internal void <ContractGetEntrustBattleScore>b__0(Unit enemy) { }
}

// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x275B20 Offset: 0x275C21 VA: 0x275B20
private sealed class AIThink.<>c__DisplayClass340_0 // TypeDefIndex: 9434
{
	// Fields
	public AIThink <>4__this; // 0x10
	public int moveX; // 0x18
	public uint score; // 0x1C
	public int moveZ; // 0x20

	// Methods

	// RVA: 0x249C4C0 Offset: 0x249C5C1 VA: 0x249C4C0
	public void .ctor() { }

	// RVA: 0x249C4D0 Offset: 0x249C5D1 VA: 0x249C4D0
	internal void <ActionCommandSkillGaze>b__0(int x, int z, int range) { }
}

// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x275B30 Offset: 0x275C31 VA: 0x275B30
private sealed class AIThink.<>c__DisplayClass348_0 // TypeDefIndex: 9435
{
	// Fields
	public List<RangeData.Offset> attackRange; // 0x10
	public AIThink <>4__this; // 0x18
	public Unit[] enemyUnits; // 0x20
	public int attackRangeCount; // 0x28
	public int enemyCount; // 0x2C
	public uint itemBit; // 0x30
	public uint rangeBit; // 0x34
	public int maxRange; // 0x38
	public bool isExcludeFreeze; // 0x3C
	public uint targetScore; // 0x40
	public uint moveScore; // 0x44
	public int targetX; // 0x48
	public int targetZ; // 0x4C
	public int moveX; // 0x50
	public int moveZ; // 0x54
	public int itemIndex; // 0x58

	// Methods

	// RVA: 0x249C6E0 Offset: 0x249C7E1 VA: 0x249C6E0
	public void .ctor() { }

	// RVA: 0x249C6F0 Offset: 0x249C7F1 VA: 0x249C6F0
	internal void <CommandSkillFullBulletTo>b__0(int x, int z) { }
}

// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x275B40 Offset: 0x275C41 VA: 0x275B40
private sealed class AIThink.<>c__DisplayClass348_1 // TypeDefIndex: 9436
{
	// Fields
	public int x; // 0x10
	public int z; // 0x14
	public bool isAlreadyLocked; // 0x18

	// Methods

	// RVA: 0x249CD00 Offset: 0x249CE01 VA: 0x249CD00
	public void .ctor() { }

	// RVA: 0x249CD10 Offset: 0x249CE11 VA: 0x249CD10
	internal void <CommandSkillFullBulletTo>b__1(Unit unit) { }
}

// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x275B50 Offset: 0x275C51 VA: 0x275B50
private sealed class AIThink.<>c__DisplayClass353_0 // TypeDefIndex: 9437
{
	// Fields
	public uint rangeBit; // 0x10
	public uint itemBit; // 0x14
	public AIThink <>4__this; // 0x18
	public bool isExcludeFreeze; // 0x20
	public uint score; // 0x24
	public int workMoveX; // 0x28
	public int workMoveZ; // 0x2C
	public int workItemIndex; // 0x30

	// Methods

	// RVA: 0x249CDB0 Offset: 0x249CEB1 VA: 0x249CDB0
	public void .ctor() { }

	// RVA: 0x249CDC0 Offset: 0x249CEC1 VA: 0x249CDC0
	internal void <FullBulletGetMovePos>b__0(int x, int z, int range) { }
}

// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x275B60 Offset: 0x275C61 VA: 0x275B60
private sealed class AIThink.<>c__DisplayClass354_0 // TypeDefIndex: 9438
{
	// Fields
	public uint rangeBit; // 0x10
	public AIThink <>4__this; // 0x18
	public int itemIndex; // 0x20
	public uint score; // 0x24
	public int workMoveX; // 0x28
	public int workMoveZ; // 0x2C

	// Methods

	// RVA: 0x249D0E0 Offset: 0x249D1E1 VA: 0x249D0E0
	public void .ctor() { }

	// RVA: 0x249D0F0 Offset: 0x249D1F1 VA: 0x249D0F0
	internal void <FullBulletGetMovePosVersus>b__0(int x, int z, int range) { }
}

// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x275B70 Offset: 0x275C71 VA: 0x275B70
private sealed class AIThink.<>c__DisplayClass363_0 // TypeDefIndex: 9439
{
	// Fields
	public AIThink <>4__this; // 0x10
	public uint itemBit; // 0x18
	public uint score; // 0x1C
	public int moveX; // 0x20
	public int moveZ; // 0x24
	public int itemIndex; // 0x28

	// Methods

	// RVA: 0x249D340 Offset: 0x249D441 VA: 0x249D340
	public void .ctor() { }

	// RVA: 0x249D350 Offset: 0x249D451 VA: 0x249D350
	internal void <CommandSkillEnchantHealToCommon>b__0(int x, int z) { }
}

// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x275B80 Offset: 0x275C81 VA: 0x275B80
private sealed class AIThink.<>c__DisplayClass366_0 // TypeDefIndex: 9440
{
	// Fields
	public AIThink <>4__this; // 0x10
	public int moveX; // 0x18
	public int moveZ; // 0x1C

	// Methods

	// RVA: 0x249D530 Offset: 0x249D631 VA: 0x249D530
	public void .ctor() { }
}

// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x275B90 Offset: 0x275C91 VA: 0x275B90
private sealed class AIThink.<>c__DisplayClass366_1 // TypeDefIndex: 9441
{
	// Fields
	public ItemData item; // 0x10
	public int rangeI; // 0x18
	public int rangeO; // 0x1C
	public int totalHeal; // 0x20
	public int enchantHeal; // 0x24
	public int totalDamage; // 0x28
	public bool isAsking; // 0x2C
	public bool isSelf; // 0x2D
	public int targetCount; // 0x30
	public AIThink.<>c__DisplayClass366_0 CS$<>8__locals1; // 0x38

	// Methods

	// RVA: 0x249D540 Offset: 0x249D641 VA: 0x249D540
	public void .ctor() { }

	// RVA: 0x249D550 Offset: 0x249D651 VA: 0x249D550
	internal void <EnchantHealGetScore>b__0(Unit target) { }
}

// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x275BA0 Offset: 0x275CA1 VA: 0x275BA0
private sealed class AIThink.<>c__DisplayClass367_0 // TypeDefIndex: 9442
{
	// Fields
	public AIThink <>4__this; // 0x10
	public ItemData item; // 0x18
	public int moveX; // 0x20
	public int moveZ; // 0x24
	public int rangeI; // 0x28
	public int rangeO; // 0x2C
	public int heal; // 0x30

	// Methods

	// RVA: 0x249D9E0 Offset: 0x249DAE1 VA: 0x249D9E0
	public void .ctor() { }

	// RVA: 0x249D9F0 Offset: 0x249DAF1 VA: 0x249D9F0
	internal void <EnchantHealUpdateHealCondition>b__0(Unit unit) { }
}

// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x275BB0 Offset: 0x275CB1 VA: 0x275BB0
private sealed class AIThink.<>c__DisplayClass379_0 // TypeDefIndex: 9443
{
	// Fields
	public AIThink <>4__this; // 0x10
	public uint score; // 0x18
	public Unit target; // 0x20
	public int moveX; // 0x28
	public int moveZ; // 0x2C
	public int attackX; // 0x30
	public int attackZ; // 0x34
	public int targetX; // 0x38
	public int targetZ; // 0x3C
	public int itemIndex; // 0x40

	// Methods

	// RVA: 0x249DB10 Offset: 0x249DC11 VA: 0x249DB10
	public void .ctor() { }

	// RVA: 0x249DB20 Offset: 0x249DC21 VA: 0x249DB20
	internal void <EntrustHealRod>b__0(Unit unit) { }
}

// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x275BC0 Offset: 0x275CC1 VA: 0x275BC0
private sealed class AIThink.<>c__DisplayClass384_0 // TypeDefIndex: 9444
{
	// Fields
	public AIThink <>4__this; // 0x10
	public SkillData engageAttack; // 0x18
	public int itemIndex; // 0x20
	public int flag; // 0x24
	public AIThink.EntrustAttackScoreResult easResult; // 0x28
	public AIThink.EntrustAttackTarget target; // 0x48

	// Methods

	// RVA: 0x249DCF0 Offset: 0x249DDF1 VA: 0x249DCF0
	public void .ctor() { }

	// RVA: 0x249DD00 Offset: 0x249DE01 VA: 0x249DD00
	internal void <EntrustEngageAttackTo>b__0(Unit unit) { }
}

// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x275BD0 Offset: 0x275CD1 VA: 0x275BD0
private sealed class AIThink.<>c__DisplayClass385_0 // TypeDefIndex: 9445
{
	// Fields
	public AIThink <>4__this; // 0x10
	public int itemIndex; // 0x18
	public int flag; // 0x1C
	public SkillData engageAttack; // 0x20
	public AIThink.EntrustAttackScoreResult easResult; // 0x28
	public AIThink.EntrustAttackTarget target; // 0x48

	// Methods

	// RVA: 0x249DF20 Offset: 0x249E021 VA: 0x249DF20
	public void .ctor() { }

	// RVA: 0x249DF30 Offset: 0x249E031 VA: 0x249DF30
	internal void <EntrustEngagePierceTo>b__0(Unit unit) { }
}

// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x275BE0 Offset: 0x275CE1 VA: 0x275BE0
private sealed class AIThink.<>c__DisplayClass398_0 // TypeDefIndex: 9446
{
	// Fields
	public AIThink <>4__this; // 0x10
	public AIDeploy deploy; // 0x18
	public int itemIndex; // 0x20
	public SkillData commandSkill; // 0x28
	public AIThink.EntrustAttackTarget target; // 0x30

	// Methods

	// RVA: 0x249E110 Offset: 0x249E211 VA: 0x249E110
	public void .ctor() { }

	// RVA: 0x249E120 Offset: 0x249E221 VA: 0x249E120
	internal void <EntrustAttackTo>b__0(Unit unit) { }
}

// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x275BF0 Offset: 0x275CF1 VA: 0x275BF0
private sealed class AIThink.<>c__DisplayClass404_0 // TypeDefIndex: 9447
{
	// Fields
	public int itemIndex; // 0x10
	public AIThink <>4__this; // 0x18
	public uint score; // 0x20
	public int moveX; // 0x24
	public int moveZ; // 0x28
	public int targetX; // 0x2C
	public int targetZ; // 0x30

	// Methods

	// RVA: 0x249E330 Offset: 0x249E431 VA: 0x249E330
	public void .ctor() { }

	// RVA: 0x249E340 Offset: 0x249E441 VA: 0x249E340
	internal void <EntrustMindDoorAndDestroy>b__0(int x, int z, int item, int tx, int tz) { }
}

// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x275C00 Offset: 0x275D01 VA: 0x275C00
private sealed class AIThink.<>c__DisplayClass406_0 // TypeDefIndex: 9448
{
	// Fields
	public AIThink <>4__this; // 0x10
	public int tx; // 0x18
	public uint score; // 0x1C
	public int tz; // 0x20

	// Methods

	// RVA: 0x249E520 Offset: 0x249E621 VA: 0x249E520
	public void .ctor() { }

	// RVA: 0x249E530 Offset: 0x249E631 VA: 0x249E530
	internal void <EntrustGuardTo>b__0(Unit unit) { }
}

// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x275C10 Offset: 0x275D11 VA: 0x275C10
private sealed class AIThink.<>c__DisplayClass412_0 // TypeDefIndex: 9449
{
	// Fields
	public AIThink <>4__this; // 0x10
	public int px; // 0x18
	public int pz; // 0x1C
	public uint score; // 0x20
	public int tx; // 0x24
	public int tz; // 0x28

	// Methods

	// RVA: 0x249EB30 Offset: 0x249EC31 VA: 0x249EB30
	public void .ctor() { }

	// RVA: 0x249EB40 Offset: 0x249EC41 VA: 0x249EB40
	internal void <EntrustMoveRetreat>b__0(int x, int z, int range) { }
}

// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x275C20 Offset: 0x275D21 VA: 0x275C20
private sealed class AIThink.<>c__DisplayClass413_0 // TypeDefIndex: 9450
{
	// Fields
	public AIThink <>4__this; // 0x10
	public AIDeploy deploy; // 0x18
	public bool isIn; // 0x20
	public int rangeI; // 0x24
	public int itemIndex; // 0x28
	public Unit target; // 0x30
	public uint score; // 0x38
	public int targetX; // 0x3C
	public int targetZ; // 0x40

	// Methods

	// RVA: 0x249EDE0 Offset: 0x249EEE1 VA: 0x249EDE0
	public void .ctor() { }

	// RVA: 0x249EDF0 Offset: 0x249EEF1 VA: 0x249EDF0
	internal void <EntrustMoveEnemy>b__0(Unit unit) { }
}

// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x275C30 Offset: 0x275D31 VA: 0x275C30
private sealed class AIThink.<>c__DisplayClass416_0 // TypeDefIndex: 9451
{
	// Fields
	public int itemIndex; // 0x10
	public AIThink <>4__this; // 0x18
	public uint priority; // 0x20
	public uint score; // 0x24
	public int moveX; // 0x28
	public int moveZ; // 0x2C

	// Methods

	// RVA: 0x249F120 Offset: 0x249F221 VA: 0x249F120
	public void .ctor() { }

	// RVA: 0x249F130 Offset: 0x249F231 VA: 0x249F130
	internal void <EntrustMoveDoorAndDestroy>b__0(int x, int z, int item, int targetX, int targetZ) { }
}

// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x275C40 Offset: 0x275D41 VA: 0x275C40
private sealed class AIThink.<>c__DisplayClass419_0 // TypeDefIndex: 9452
{
	// Fields
	public AIThink <>4__this; // 0x10
	public AIDeploy deploy; // 0x18
	public Unit target; // 0x20
	public uint score; // 0x28

	// Methods

	// RVA: 0x249F280 Offset: 0x249F381 VA: 0x249F280
	public void .ctor() { }

	// RVA: 0x249F290 Offset: 0x249F391 VA: 0x249F290
	internal void <EntrustMoveSelfForce>b__0(Unit unit) { }
}

// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x275C50 Offset: 0x275D51 VA: 0x275C50
private sealed class AIThink.<>c__DisplayClass420_0 // TypeDefIndex: 9453
{
	// Fields
	public AIDeploy deploy; // 0x10
	public AIThink <>4__this; // 0x18
	public bool isCaution; // 0x20
	public int xx; // 0x24
	public int zz; // 0x28
	public int targetX; // 0x2C
	public int targetZ; // 0x30

	// Methods

	// RVA: 0x249F5F0 Offset: 0x249F6F1 VA: 0x249F5F0
	public void .ctor() { }
}

// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x275C60 Offset: 0x275D61 VA: 0x275C60
private sealed class AIThink.<>c__DisplayClass420_1 // TypeDefIndex: 9454
{
	// Fields
	public int score; // 0x10
	public AIThink.<>c__DisplayClass420_0 CS$<>8__locals1; // 0x18

	// Methods

	// RVA: 0x249F600 Offset: 0x249F701 VA: 0x249F600
	public void .ctor() { }

	// RVA: 0x249F610 Offset: 0x249F711 VA: 0x249F610
	internal void <EntrustMoveTo>b__0(int x, int z, int range) { }
}

// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x275C70 Offset: 0x275D71 VA: 0x275C70
private sealed class AIThink.<>c__DisplayClass420_2 // TypeDefIndex: 9455
{
	// Fields
	public uint score; // 0x10
	public AIThink.<>c__DisplayClass420_0 CS$<>8__locals2; // 0x18

	// Methods

	// RVA: 0x249F6E0 Offset: 0x249F7E1 VA: 0x249F6E0
	public void .ctor() { }

	// RVA: 0x249F6F0 Offset: 0x249F7F1 VA: 0x249F6F0
	internal void <EntrustMoveTo>b__1(int x, int z) { }
}

// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x275C80 Offset: 0x275D81 VA: 0x275C80
private sealed class AIThink.<>c__DisplayClass447_0 // TypeDefIndex: 9456
{
	// Fields
	public AIThink <>4__this; // 0x10
	public uint score; // 0x18
	public Unit target; // 0x20
	public int moveX; // 0x28
	public int moveZ; // 0x2C
	public int attackX; // 0x30
	public int attackZ; // 0x34
	public int targetX; // 0x38
	public int targetZ; // 0x3C
	public int itemIndex; // 0x40

	// Methods

	// RVA: 0x249FA00 Offset: 0x249FB01 VA: 0x249FA00
	public void .ctor() { }

	// RVA: 0x249FA10 Offset: 0x249FB11 VA: 0x249FA10
	internal void <CharmHeal>b__0(Unit unit) { }
}

// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x275C90 Offset: 0x275D91 VA: 0x275C90
private sealed class AIThink.<>c__DisplayClass448_0 // TypeDefIndex: 9457
{
	// Fields
	public AIThink <>4__this; // 0x10
	public int itemIndex; // 0x18
	public AIThink.UncontrollAttackScoreResult uasResult; // 0x1C
	public AIThink.UncontrollAttackTarget target; // 0x30

	// Methods

	// RVA: 0x249FB40 Offset: 0x249FC41 VA: 0x249FB40
	public void .ctor() { }

	// RVA: 0x249FB50 Offset: 0x249FC51 VA: 0x249FB50
	internal void <ConfusionAttack>b__0(Unit unit) { }
}

// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x275CA0 Offset: 0x275DA1 VA: 0x275CA0
private sealed class AIThink.<>c__DisplayClass449_0 // TypeDefIndex: 9458
{
	// Fields
	public AIThink <>4__this; // 0x10
	public int itemIndex; // 0x18
	public AIThink.UncontrollAttackScoreResult uasResult; // 0x1C
	public AIThink.UncontrollAttackTarget target; // 0x30

	// Methods

	// RVA: 0x249FC80 Offset: 0x249FD81 VA: 0x249FC80
	public void .ctor() { }

	// RVA: 0x249FC90 Offset: 0x249FD91 VA: 0x249FC90
	internal void <CharmAttack>b__0(Unit unit) { }
}

// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x275CB0 Offset: 0x275DB1 VA: 0x275CB0
private sealed class AIThink.<>c__DisplayClass450_0 // TypeDefIndex: 9459
{
	// Fields
	public AIThink <>4__this; // 0x10
	public uint score; // 0x18
	public Unit target; // 0x20
	public int targetX; // 0x28
	public int targetZ; // 0x2C

	// Methods

	// RVA: 0x249FDB0 Offset: 0x249FEB1 VA: 0x249FDB0
	public void .ctor() { }

	// RVA: 0x249FDC0 Offset: 0x249FEC1 VA: 0x249FDC0
	internal void <ConfusionMove>b__0(Unit unit) { }
}

// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x275CC0 Offset: 0x275DC1 VA: 0x275CC0
private sealed class AIThink.<>c__DisplayClass451_0 // TypeDefIndex: 9460
{
	// Fields
	public AIThink <>4__this; // 0x10
	public uint score; // 0x18
	public Unit target; // 0x20
	public int targetX; // 0x28
	public int targetZ; // 0x2C

	// Methods

	// RVA: 0x249FED0 Offset: 0x249FFD1 VA: 0x249FED0
	public void .ctor() { }

	// RVA: 0x249FEE0 Offset: 0x249FFE1 VA: 0x249FEE0
	internal void <CharmMove>b__0(Unit unit) { }
}

