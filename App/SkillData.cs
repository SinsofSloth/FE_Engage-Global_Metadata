// Namespace: App
[DebuggerDisplayAttribute] // RVA: 0x276500 Offset: 0x276601 VA: 0x276500
public sealed class SkillData : StructCalculatorData<SkillData> // TypeDefIndex: 10091
{
	// Fields
	public const int PhaseCycle = 3;
	[CompilerGeneratedAttribute] // RVA: 0x28CFD0 Offset: 0x28D0D1 VA: 0x28CFD0
	private string <Sid>k__BackingField; // 0x28
	[CompilerGeneratedAttribute] // RVA: 0x28CFE0 Offset: 0x28D0E1 VA: 0x28CFE0
	private string <Name>k__BackingField; // 0x30
	[CompilerGeneratedAttribute] // RVA: 0x28CFF0 Offset: 0x28D0F1 VA: 0x28CFF0
	private string <Help>k__BackingField; // 0x38
	[CompilerGeneratedAttribute] // RVA: 0x28D000 Offset: 0x28D101 VA: 0x28D000
	private string <CommandName>k__BackingField; // 0x40
	[CompilerGeneratedAttribute] // RVA: 0x28D010 Offset: 0x28D111 VA: 0x28D010
	private string <CommandHelp>k__BackingField; // 0x48
	[CompilerGeneratedAttribute] // RVA: 0x28D020 Offset: 0x28D121 VA: 0x28D020
	private string <CommandWarning>k__BackingField; // 0x50
	[CompilerGeneratedAttribute] // RVA: 0x28D030 Offset: 0x28D131 VA: 0x28D030
	private string <RootCommandSid>k__BackingField; // 0x58
	[CompilerGeneratedAttribute] // RVA: 0x28D040 Offset: 0x28D141 VA: 0x28D040
	private SkillData.IconKinds <IconKind>k__BackingField; // 0x60
	[CompilerGeneratedAttribute] // RVA: 0x28D050 Offset: 0x28D151 VA: 0x28D050
	private string <IconLabel>k__BackingField; // 0x68
	[CompilerGeneratedAttribute] // RVA: 0x28D060 Offset: 0x28D161 VA: 0x28D060
	private string <IconBmap>k__BackingField; // 0x70
	[CompilerGeneratedAttribute] // RVA: 0x28D070 Offset: 0x28D171 VA: 0x28D070
	private SkillData.Stands <Stand>k__BackingField; // 0x78
	[CompilerGeneratedAttribute] // RVA: 0x28D080 Offset: 0x28D181 VA: 0x28D080
	private SkillData.Actions <Action>k__BackingField; // 0x7C
	[CompilerGeneratedAttribute] // RVA: 0x28D090 Offset: 0x28D191 VA: 0x28D090
	private SkillData.Timings <Timing>k__BackingField; // 0x80
	[CompilerGeneratedAttribute] // RVA: 0x28D0A0 Offset: 0x28D1A1 VA: 0x28D0A0
	private SkillData.Targets <Target>k__BackingField; // 0x84
	[CompilerGeneratedAttribute] // RVA: 0x28D0B0 Offset: 0x28D1B1 VA: 0x28D0B0
	private string[] <EquipIids>k__BackingField; // 0x88
	[CompilerGeneratedAttribute] // RVA: 0x28D0C0 Offset: 0x28D1C1 VA: 0x28D0C0
	private int <Group>k__BackingField; // 0x90
	[CompilerGeneratedAttribute] // RVA: 0x28D0D0 Offset: 0x28D1D1 VA: 0x28D0D0
	private byte <Priority>k__BackingField; // 0x94
	[CompilerGeneratedAttribute] // RVA: 0x28D0E0 Offset: 0x28D1E1 VA: 0x28D0E0
	private SkillData.Layers <Layer>k__BackingField; // 0x98
	[CompilerGeneratedAttribute] // RVA: 0x28D0F0 Offset: 0x28D1F1 VA: 0x28D0F0
	private sbyte <Order>k__BackingField; // 0x9C
	[CompilerGeneratedAttribute] // RVA: 0x28D100 Offset: 0x28D201 VA: 0x28D100
	private SkillData.Cycles <Cycle>k__BackingField; // 0xA0
	[CompilerGeneratedAttribute] // RVA: 0x28D110 Offset: 0x28D211 VA: 0x28D110
	private SkillData.Frequencies <Frequency>k__BackingField; // 0xA4
	[CompilerGeneratedAttribute] // RVA: 0x28D120 Offset: 0x28D221 VA: 0x28D120
	private string <Condition>k__BackingField; // 0xA8
	[CompilerGeneratedAttribute] // RVA: 0x28D130 Offset: 0x28D231 VA: 0x28D130
	private SkillData.GiveTargets <GiveTarget>k__BackingField; // 0xB0
	[CompilerGeneratedAttribute] // RVA: 0x28D140 Offset: 0x28D241 VA: 0x28D140
	private string <GiveCondition>k__BackingField; // 0xB8
	[CompilerGeneratedAttribute] // RVA: 0x28D150 Offset: 0x28D251 VA: 0x28D150
	private string[] <GiveSids>k__BackingField; // 0xC0
	[CompilerGeneratedAttribute] // RVA: 0x28D160 Offset: 0x28D261 VA: 0x28D160
	private string[] <RemoveSids>k__BackingField; // 0xC8
	[CompilerGeneratedAttribute] // RVA: 0x28D170 Offset: 0x28D271 VA: 0x28D170
	private string[] <SyncConditions>k__BackingField; // 0xD0
	[CompilerGeneratedAttribute] // RVA: 0x28D180 Offset: 0x28D281 VA: 0x28D180
	private string[] <SyncSids>k__BackingField; // 0xD8
	[CompilerGeneratedAttribute] // RVA: 0x28D190 Offset: 0x28D291 VA: 0x28D190
	private string <RebirthSid>k__BackingField; // 0xE0
	[CompilerGeneratedAttribute] // RVA: 0x28D1A0 Offset: 0x28D2A1 VA: 0x28D1A0
	private string <EngageSid>k__BackingField; // 0xE8
	[CompilerGeneratedAttribute] // RVA: 0x28D1B0 Offset: 0x28D2B1 VA: 0x28D1B0
	private string[] <ChangeSids>k__BackingField; // 0xF0
	[CompilerGeneratedAttribute] // RVA: 0x28D1C0 Offset: 0x28D2C1 VA: 0x28D1C0
	private string <AttackRange>k__BackingField; // 0xF8
	[CompilerGeneratedAttribute] // RVA: 0x28D1D0 Offset: 0x28D2D1 VA: 0x28D1D0
	private string <OverlapRange>k__BackingField; // 0x100
	[CompilerGeneratedAttribute] // RVA: 0x28D1E0 Offset: 0x28D2E1 VA: 0x28D1E0
	private string <OverlapTerrain>k__BackingField; // 0x108
	[CompilerGeneratedAttribute] // RVA: 0x28D1F0 Offset: 0x28D2F1 VA: 0x28D1F0
	private string <ZocRange>k__BackingField; // 0x110
	[CompilerGeneratedAttribute] // RVA: 0x28D200 Offset: 0x28D301 VA: 0x28D200
	private SkillData.Zocs <ZocType>k__BackingField; // 0x118
	[CompilerGeneratedAttribute] // RVA: 0x28D210 Offset: 0x28D311 VA: 0x28D210
	private string <CooperationSkill>k__BackingField; // 0x120
	[CompilerGeneratedAttribute] // RVA: 0x28D220 Offset: 0x28D321 VA: 0x28D220
	private string <HorseSkill>k__BackingField; // 0x128
	[CompilerGeneratedAttribute] // RVA: 0x28D230 Offset: 0x28D331 VA: 0x28D230
	private string <CovertSkill>k__BackingField; // 0x130
	[CompilerGeneratedAttribute] // RVA: 0x28D240 Offset: 0x28D341 VA: 0x28D240
	private string <HeavySkill>k__BackingField; // 0x138
	[CompilerGeneratedAttribute] // RVA: 0x28D250 Offset: 0x28D351 VA: 0x28D250
	private string <FlySkill>k__BackingField; // 0x140
	[CompilerGeneratedAttribute] // RVA: 0x28D260 Offset: 0x28D361 VA: 0x28D260
	private string <MagicSkill>k__BackingField; // 0x148
	[CompilerGeneratedAttribute] // RVA: 0x28D270 Offset: 0x28D371 VA: 0x28D270
	private string <PranaSkill>k__BackingField; // 0x150
	[CompilerGeneratedAttribute] // RVA: 0x28D280 Offset: 0x28D381 VA: 0x28D280
	private string <DragonSkill>k__BackingField; // 0x158
	[CompilerGeneratedAttribute] // RVA: 0x28D290 Offset: 0x28D391 VA: 0x28D290
	private string[] <ActNames>k__BackingField; // 0x160
	[CompilerGeneratedAttribute] // RVA: 0x28D2A0 Offset: 0x28D3A1 VA: 0x28D2A0
	private string[] <ActOperations>k__BackingField; // 0x168
	[CompilerGeneratedAttribute] // RVA: 0x28D2B0 Offset: 0x28D3B1 VA: 0x28D2B0
	private string[] <ActValues>k__BackingField; // 0x170
	[CompilerGeneratedAttribute] // RVA: 0x28D2C0 Offset: 0x28D3C1 VA: 0x28D2C0
	private SkillData.AroundCenters <AroundCenter>k__BackingField; // 0x178
	[CompilerGeneratedAttribute] // RVA: 0x28D2D0 Offset: 0x28D3D1 VA: 0x28D2D0
	private SkillData.AroundTargets <AroundTarget>k__BackingField; // 0x17C
	[CompilerGeneratedAttribute] // RVA: 0x28D2E0 Offset: 0x28D3E1 VA: 0x28D2E0
	private string <AroundCondition>k__BackingField; // 0x180
	[CompilerGeneratedAttribute] // RVA: 0x28D2F0 Offset: 0x28D3F1 VA: 0x28D2F0
	private string <AroundName>k__BackingField; // 0x188
	[CompilerGeneratedAttribute] // RVA: 0x28D300 Offset: 0x28D401 VA: 0x28D300
	private string <AroundOperation>k__BackingField; // 0x190
	[CompilerGeneratedAttribute] // RVA: 0x28D310 Offset: 0x28D411 VA: 0x28D310
	private string <AroundValue>k__BackingField; // 0x198
	[CompilerGeneratedAttribute] // RVA: 0x28D320 Offset: 0x28D421 VA: 0x28D320
	private SkillData.States <BadState>k__BackingField; // 0x1A0
	[CompilerGeneratedAttribute] // RVA: 0x28D330 Offset: 0x28D431 VA: 0x28D330
	private SkillData.States <BadIgnore>k__BackingField; // 0x1A4
	[CompilerGeneratedAttribute] // RVA: 0x28D340 Offset: 0x28D441 VA: 0x28D340
	private SkillData.Attrs <Efficacy>k__BackingField; // 0x1A8
	[CompilerGeneratedAttribute] // RVA: 0x28D350 Offset: 0x28D451 VA: 0x28D350
	private SkillData.Attrs <EfficacyIgnore>k__BackingField; // 0x1AC
	[CompilerGeneratedAttribute] // RVA: 0x28D360 Offset: 0x28D461 VA: 0x28D360
	private int <EfficacyValue>k__BackingField; // 0x1B0
	[CompilerGeneratedAttribute] // RVA: 0x28D370 Offset: 0x28D471 VA: 0x28D370
	private SkillData.Flags <Flag>k__BackingField; // 0x1B8
	[CompilerGeneratedAttribute] // RVA: 0x28D380 Offset: 0x28D481 VA: 0x28D380
	private SkillData.PrivateFlags <PrivateFlag>k__BackingField; // 0x1C0
	[CompilerGeneratedAttribute] // RVA: 0x28D390 Offset: 0x28D491 VA: 0x28D390
	private SkillData.Works <Work>k__BackingField; // 0x1C4
	[CompilerGeneratedAttribute] // RVA: 0x28D3A0 Offset: 0x28D4A1 VA: 0x28D3A0
	private string <WorkOperation>k__BackingField; // 0x1C8
	[CompilerGeneratedAttribute] // RVA: 0x28D3B0 Offset: 0x28D4B1 VA: 0x28D3B0
	private float <WorkValue>k__BackingField; // 0x1D0
	[CompilerGeneratedAttribute] // RVA: 0x28D3C0 Offset: 0x28D4C1 VA: 0x28D3C0
	private int <Power>k__BackingField; // 0x1D4
	[CompilerGeneratedAttribute] // RVA: 0x28D3D0 Offset: 0x28D4D1 VA: 0x28D3D0
	private int <Life>k__BackingField; // 0x1D8
	[CompilerGeneratedAttribute] // RVA: 0x28D3E0 Offset: 0x28D4E1 VA: 0x28D3E0
	private int <Cost>k__BackingField; // 0x1DC
	[CompilerGeneratedAttribute] // RVA: 0x28D3F0 Offset: 0x28D4F1 VA: 0x28D3F0
	private int <Rewarp>k__BackingField; // 0x1E0
	[CompilerGeneratedAttribute] // RVA: 0x28D400 Offset: 0x28D501 VA: 0x28D400
	private int <Removable>k__BackingField; // 0x1E4
	[CompilerGeneratedAttribute] // RVA: 0x28D410 Offset: 0x28D511 VA: 0x28D410
	private int <VisionCount>k__BackingField; // 0x1E8
	[CompilerGeneratedAttribute] // RVA: 0x28D420 Offset: 0x28D521 VA: 0x28D420
	private ItemData.Kinds <RangeTarget>k__BackingField; // 0x1EC
	[CompilerGeneratedAttribute] // RVA: 0x28D430 Offset: 0x28D531 VA: 0x28D430
	private int <RangeI>k__BackingField; // 0x1F0
	[CompilerGeneratedAttribute] // RVA: 0x28D440 Offset: 0x28D541 VA: 0x28D440
	private int <RangeO>k__BackingField; // 0x1F4
	[CompilerGeneratedAttribute] // RVA: 0x28D450 Offset: 0x28D551 VA: 0x28D450
	private int <RangeAdd>k__BackingField; // 0x1F8
	[CompilerGeneratedAttribute] // RVA: 0x28D460 Offset: 0x28D561 VA: 0x28D460
	private int <RangeExtend>k__BackingField; // 0x1FC
	[CompilerGeneratedAttribute] // RVA: 0x28D470 Offset: 0x28D571 VA: 0x28D470
	private int <MoveSelf>k__BackingField; // 0x200
	[CompilerGeneratedAttribute] // RVA: 0x28D480 Offset: 0x28D581 VA: 0x28D480
	private int <MoveTarget>k__BackingField; // 0x204
	[CompilerGeneratedAttribute] // RVA: 0x28D490 Offset: 0x28D591 VA: 0x28D490
	private sbyte <EnhanceLevel>k__BackingField; // 0x208
	[CompilerGeneratedAttribute] // RVA: 0x28D4A0 Offset: 0x28D5A1 VA: 0x28D4A0
	private CapabilitySbyte <EnhanceValue>k__BackingField; // 0x210
	[CompilerGeneratedAttribute] // RVA: 0x28D4B0 Offset: 0x28D5B1 VA: 0x28D4B0
	private WeaponMask <WeaponProhibit>k__BackingField; // 0x218
	[CompilerGeneratedAttribute] // RVA: 0x28D4C0 Offset: 0x28D5C1 VA: 0x28D4C0
	private WeaponLevels <WeaponLevel>k__BackingField; // 0x220
	[CompilerGeneratedAttribute] // RVA: 0x28D4D0 Offset: 0x28D5D1 VA: 0x28D4D0
	private string <Effect>k__BackingField; // 0x228
	[CompilerGeneratedAttribute] // RVA: 0x28D4E0 Offset: 0x28D5E1 VA: 0x28D4E0
	private ushort <InheritanceCost>k__BackingField; // 0x230
	[CompilerGeneratedAttribute] // RVA: 0x28D4F0 Offset: 0x28D5F1 VA: 0x28D4F0
	private ushort <InheritanceSort>k__BackingField; // 0x232
	public SkillArray GiveSkills; // 0x238
	public SkillArray RemoveSkills; // 0x240
	public SkillArray SyncSkills; // 0x248
	public SkillData RebirthSkill; // 0x250
	public SkillData EngageSkill; // 0x258
	public SkillData[] ChangeSkills; // 0x260
	public SkillData LowSkill; // 0x268
	public SkillData HighSkill; // 0x270
	public SkillData RootCommandSkill; // 0x278
	public SkillData.TimingMasks TimingMask; // 0x280
	public SkillData.CycleMasks CycleMask; // 0x284
	public int SortKey; // 0x288
	private List<SkillData.Func> m_ActFuncs; // 0x290
	private List<SkillData.Func> m_AroundFuncs; // 0x298
	private SkillData[] m_StyleSkills; // 0x2A0
	private WeaponMask m_WeaponLevelMask; // 0x2A8
	private CalculatorCommand m_ConditionCommand; // 0x2B0
	private CalculatorCommand m_GiveConditionCommand; // 0x2B8
	private CalculatorCommand m_AroundConditionCommand; // 0x2C0
	private CalculatorCommand[] m_SyncConditionCommands; // 0x2C8
	private List<ItemData> m_EquipItems; // 0x2D0
	private ItemData m_DefaultEquipItem; // 0x2D8
	private string m_PrefixlessSid; // 0x2E0
	private const int CommandMask = 6291456;
	private static SkillArray s_EfficacySkills; // 0x0
	private static SkillData s_HeroSkill; // 0x8
	private static SkillData s_StunSkill; // 0x10
	private static SkillData s_DanceSkill; // 0x18
	private static SkillData s_MorphSkill; // 0x20
	private static SkillData s_PoisonSkill; // 0x28
	private static SkillData s_LeaderSkill; // 0x30
	private static SkillData s_FangCurseSkill; // 0x38
	private static SkillData s_EnchantSkill; // 0x40
	private static SkillData s_EnchantmentSkill; // 0x48
	private static SkillData s_ImmortalSkill; // 0x50
	private static SkillData s_TransporterSkill; // 0x58
	private static SkillData s_FullBulletSkill; // 0x60
	private static SkillData s_ChainAttackGuardSkill; // 0x68
	private static SkillData s_NotTerrainDamageSkill; // 0x70
	private static SkillData s_GazeDiagonallySkill; // 0x78
	private static SkillData s_MultiChangeSkill; // 0x80

	// Properties
	public string Sid { get; set; }
	public string Name { get; set; }
	public string Help { get; set; }
	public string CommandName { get; set; }
	public string CommandHelp { get; set; }
	public string CommandWarning { get; set; }
	public string RootCommandSid { get; set; }
	public SkillData.IconKinds IconKind { get; set; }
	public string IconLabel { get; set; }
	public string IconBmap { get; set; }
	public SkillData.Stands Stand { get; set; }
	public SkillData.Actions Action { get; set; }
	public SkillData.Timings Timing { get; set; }
	public SkillData.Targets Target { get; set; }
	public string[] EquipIids { get; set; }
	public int Group { get; set; }
	public byte Priority { get; set; }
	public SkillData.Layers Layer { get; set; }
	public sbyte Order { get; set; }
	public SkillData.Cycles Cycle { get; set; }
	public SkillData.Frequencies Frequency { get; set; }
	public string Condition { get; set; }
	public SkillData.GiveTargets GiveTarget { get; set; }
	public string GiveCondition { get; set; }
	public string[] GiveSids { get; set; }
	public string[] RemoveSids { get; set; }
	public string[] SyncConditions { get; set; }
	public string[] SyncSids { get; set; }
	public string RebirthSid { get; set; }
	public string EngageSid { get; set; }
	public string[] ChangeSids { get; set; }
	public string AttackRange { get; set; }
	public string OverlapRange { get; set; }
	public string OverlapTerrain { get; set; }
	public string ZocRange { get; set; }
	public SkillData.Zocs ZocType { get; set; }
	public string CooperationSkill { get; set; }
	public string HorseSkill { get; set; }
	public string CovertSkill { get; set; }
	public string HeavySkill { get; set; }
	public string FlySkill { get; set; }
	public string MagicSkill { get; set; }
	public string PranaSkill { get; set; }
	public string DragonSkill { get; set; }
	public string[] ActNames { get; set; }
	public string[] ActOperations { get; set; }
	public string[] ActValues { get; set; }
	public SkillData.AroundCenters AroundCenter { get; set; }
	public SkillData.AroundTargets AroundTarget { get; set; }
	public string AroundCondition { get; set; }
	public string AroundName { get; set; }
	public string AroundOperation { get; set; }
	public string AroundValue { get; set; }
	public SkillData.States BadState { get; set; }
	public SkillData.States BadIgnore { get; set; }
	public SkillData.Attrs Efficacy { get; set; }
	public SkillData.Attrs EfficacyIgnore { get; set; }
	public int EfficacyValue { get; set; }
	public SkillData.Flags Flag { get; set; }
	public SkillData.PrivateFlags PrivateFlag { get; set; }
	public SkillData.Works Work { get; set; }
	public string WorkOperation { get; set; }
	public float WorkValue { get; set; }
	public int Power { get; set; }
	public int Life { get; set; }
	public int Cost { get; set; }
	public int Rewarp { get; set; }
	public int Removable { get; set; }
	public int VisionCount { get; set; }
	public ItemData.Kinds RangeTarget { get; set; }
	public int RangeI { get; set; }
	public int RangeO { get; set; }
	public int RangeAdd { get; set; }
	public int RangeExtend { get; set; }
	public int MoveSelf { get; set; }
	public int MoveTarget { get; set; }
	public sbyte EnhanceLevel { get; set; }
	public CapabilitySbyte EnhanceValue { get; set; }
	public WeaponMask WeaponProhibit { get; set; }
	public WeaponLevels WeaponLevel { get; set; }
	public string Effect { get; set; }
	public ushort InheritanceCost { get; set; }
	public ushort InheritanceSort { get; set; }
	public int InheritanceSortKey { get; }
	protected override CalculatorManager Calculator { get; }
	public static SkillData HeroSkill { get; }
	public static SkillData StunSkill { get; }
	public static SkillData DanceSkill { get; }
	public static SkillData MorphSkill { get; }
	public static SkillData PoisonSkill { get; }
	public static SkillData LeaderSkill { get; }
	public static SkillData FangCurseSkill { get; }
	public static SkillData MultiChangeSkill { get; }
	public static SkillData EnchantSkill { get; }
	public static SkillData EnchantmentSkill { get; }
	public static SkillData ImmortalSkill { get; }
	public static SkillData TransporterSkill { get; }
	public static SkillData FullBulletSkill { get; }
	public static SkillData ChainAttackGuardSkill { get; }
	public static SkillData NotTerrainDamageSkill { get; }
	public static SkillData GazeDiagonallySkill { get; }

	// Methods

	// RVA: 0x27C2E60 Offset: 0x27C2F61 VA: 0x27C2E60
	public static void Load() { }

	[CompilerGeneratedAttribute] // RVA: 0x2BBE50 Offset: 0x2BBF51 VA: 0x2BBE50
	// RVA: 0x27C2F10 Offset: 0x27C3011 VA: 0x27C2F10
	public string get_Sid() { }

	[CompilerGeneratedAttribute] // RVA: 0x2BBE60 Offset: 0x2BBF61 VA: 0x2BBE60
	// RVA: 0x27C2F20 Offset: 0x27C3021 VA: 0x27C2F20
	private void set_Sid(string value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2BBE70 Offset: 0x2BBF71 VA: 0x2BBE70
	// RVA: 0x27C2F30 Offset: 0x27C3031 VA: 0x27C2F30
	public string get_Name() { }

	[CompilerGeneratedAttribute] // RVA: 0x2BBE80 Offset: 0x2BBF81 VA: 0x2BBE80
	// RVA: 0x27C2F40 Offset: 0x27C3041 VA: 0x27C2F40
	private void set_Name(string value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2BBE90 Offset: 0x2BBF91 VA: 0x2BBE90
	// RVA: 0x27C2F50 Offset: 0x27C3051 VA: 0x27C2F50
	public string get_Help() { }

	[CompilerGeneratedAttribute] // RVA: 0x2BBEA0 Offset: 0x2BBFA1 VA: 0x2BBEA0
	// RVA: 0x27C2F60 Offset: 0x27C3061 VA: 0x27C2F60
	private void set_Help(string value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2BBEB0 Offset: 0x2BBFB1 VA: 0x2BBEB0
	// RVA: 0x27C2F70 Offset: 0x27C3071 VA: 0x27C2F70
	public string get_CommandName() { }

	[CompilerGeneratedAttribute] // RVA: 0x2BBEC0 Offset: 0x2BBFC1 VA: 0x2BBEC0
	// RVA: 0x27C2F80 Offset: 0x27C3081 VA: 0x27C2F80
	private void set_CommandName(string value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2BBED0 Offset: 0x2BBFD1 VA: 0x2BBED0
	// RVA: 0x27C2F90 Offset: 0x27C3091 VA: 0x27C2F90
	public string get_CommandHelp() { }

	[CompilerGeneratedAttribute] // RVA: 0x2BBEE0 Offset: 0x2BBFE1 VA: 0x2BBEE0
	// RVA: 0x27C2FA0 Offset: 0x27C30A1 VA: 0x27C2FA0
	private void set_CommandHelp(string value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2BBEF0 Offset: 0x2BBFF1 VA: 0x2BBEF0
	// RVA: 0x27C2FB0 Offset: 0x27C30B1 VA: 0x27C2FB0
	public string get_CommandWarning() { }

	[CompilerGeneratedAttribute] // RVA: 0x2BBF00 Offset: 0x2BC001 VA: 0x2BBF00
	// RVA: 0x27C2FC0 Offset: 0x27C30C1 VA: 0x27C2FC0
	private void set_CommandWarning(string value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2BBF10 Offset: 0x2BC011 VA: 0x2BBF10
	// RVA: 0x27C2FD0 Offset: 0x27C30D1 VA: 0x27C2FD0
	public string get_RootCommandSid() { }

	[CompilerGeneratedAttribute] // RVA: 0x2BBF20 Offset: 0x2BC021 VA: 0x2BBF20
	// RVA: 0x27C2FE0 Offset: 0x27C30E1 VA: 0x27C2FE0
	private void set_RootCommandSid(string value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2BBF30 Offset: 0x2BC031 VA: 0x2BBF30
	// RVA: 0x27C2FF0 Offset: 0x27C30F1 VA: 0x27C2FF0
	public SkillData.IconKinds get_IconKind() { }

	[CompilerGeneratedAttribute] // RVA: 0x2BBF40 Offset: 0x2BC041 VA: 0x2BBF40
	// RVA: 0x27C3000 Offset: 0x27C3101 VA: 0x27C3000
	private void set_IconKind(SkillData.IconKinds value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2BBF50 Offset: 0x2BC051 VA: 0x2BBF50
	// RVA: 0x27C3010 Offset: 0x27C3111 VA: 0x27C3010
	public string get_IconLabel() { }

	[CompilerGeneratedAttribute] // RVA: 0x2BBF60 Offset: 0x2BC061 VA: 0x2BBF60
	// RVA: 0x27C3020 Offset: 0x27C3121 VA: 0x27C3020
	private void set_IconLabel(string value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2BBF70 Offset: 0x2BC071 VA: 0x2BBF70
	// RVA: 0x27C3030 Offset: 0x27C3131 VA: 0x27C3030
	public string get_IconBmap() { }

	[CompilerGeneratedAttribute] // RVA: 0x2BBF80 Offset: 0x2BC081 VA: 0x2BBF80
	// RVA: 0x27C3040 Offset: 0x27C3141 VA: 0x27C3040
	private void set_IconBmap(string value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2BBF90 Offset: 0x2BC091 VA: 0x2BBF90
	// RVA: 0x27C3050 Offset: 0x27C3151 VA: 0x27C3050
	public SkillData.Stands get_Stand() { }

	[CompilerGeneratedAttribute] // RVA: 0x2BBFA0 Offset: 0x2BC0A1 VA: 0x2BBFA0
	// RVA: 0x27C3060 Offset: 0x27C3161 VA: 0x27C3060
	private void set_Stand(SkillData.Stands value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2BBFB0 Offset: 0x2BC0B1 VA: 0x2BBFB0
	// RVA: 0x27C3070 Offset: 0x27C3171 VA: 0x27C3070
	public SkillData.Actions get_Action() { }

	[CompilerGeneratedAttribute] // RVA: 0x2BBFC0 Offset: 0x2BC0C1 VA: 0x2BBFC0
	// RVA: 0x27C3080 Offset: 0x27C3181 VA: 0x27C3080
	private void set_Action(SkillData.Actions value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2BBFD0 Offset: 0x2BC0D1 VA: 0x2BBFD0
	// RVA: 0x27C3090 Offset: 0x27C3191 VA: 0x27C3090
	public SkillData.Timings get_Timing() { }

	[CompilerGeneratedAttribute] // RVA: 0x2BBFE0 Offset: 0x2BC0E1 VA: 0x2BBFE0
	// RVA: 0x27C30A0 Offset: 0x27C31A1 VA: 0x27C30A0
	private void set_Timing(SkillData.Timings value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2BBFF0 Offset: 0x2BC0F1 VA: 0x2BBFF0
	// RVA: 0x27C30B0 Offset: 0x27C31B1 VA: 0x27C30B0
	public SkillData.Targets get_Target() { }

	[CompilerGeneratedAttribute] // RVA: 0x2BC000 Offset: 0x2BC101 VA: 0x2BC000
	// RVA: 0x27C30C0 Offset: 0x27C31C1 VA: 0x27C30C0
	private void set_Target(SkillData.Targets value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2BC010 Offset: 0x2BC111 VA: 0x2BC010
	// RVA: 0x27C30D0 Offset: 0x27C31D1 VA: 0x27C30D0
	public string[] get_EquipIids() { }

	[CompilerGeneratedAttribute] // RVA: 0x2BC020 Offset: 0x2BC121 VA: 0x2BC020
	// RVA: 0x27C30E0 Offset: 0x27C31E1 VA: 0x27C30E0
	private void set_EquipIids(string[] value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2BC030 Offset: 0x2BC131 VA: 0x2BC030
	// RVA: 0x27C30F0 Offset: 0x27C31F1 VA: 0x27C30F0
	public int get_Group() { }

	[CompilerGeneratedAttribute] // RVA: 0x2BC040 Offset: 0x2BC141 VA: 0x2BC040
	// RVA: 0x27C3100 Offset: 0x27C3201 VA: 0x27C3100
	private void set_Group(int value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2BC050 Offset: 0x2BC151 VA: 0x2BC050
	// RVA: 0x27C3110 Offset: 0x27C3211 VA: 0x27C3110
	public byte get_Priority() { }

	[CompilerGeneratedAttribute] // RVA: 0x2BC060 Offset: 0x2BC161 VA: 0x2BC060
	// RVA: 0x27C3120 Offset: 0x27C3221 VA: 0x27C3120
	private void set_Priority(byte value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2BC070 Offset: 0x2BC171 VA: 0x2BC070
	// RVA: 0x27C3130 Offset: 0x27C3231 VA: 0x27C3130
	public SkillData.Layers get_Layer() { }

	[CompilerGeneratedAttribute] // RVA: 0x2BC080 Offset: 0x2BC181 VA: 0x2BC080
	// RVA: 0x27C3140 Offset: 0x27C3241 VA: 0x27C3140
	private void set_Layer(SkillData.Layers value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2BC090 Offset: 0x2BC191 VA: 0x2BC090
	// RVA: 0x27C3150 Offset: 0x27C3251 VA: 0x27C3150
	public sbyte get_Order() { }

	[CompilerGeneratedAttribute] // RVA: 0x2BC0A0 Offset: 0x2BC1A1 VA: 0x2BC0A0
	// RVA: 0x27C3160 Offset: 0x27C3261 VA: 0x27C3160
	private void set_Order(sbyte value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2BC0B0 Offset: 0x2BC1B1 VA: 0x2BC0B0
	// RVA: 0x27C3170 Offset: 0x27C3271 VA: 0x27C3170
	public SkillData.Cycles get_Cycle() { }

	[CompilerGeneratedAttribute] // RVA: 0x2BC0C0 Offset: 0x2BC1C1 VA: 0x2BC0C0
	// RVA: 0x27C3180 Offset: 0x27C3281 VA: 0x27C3180
	private void set_Cycle(SkillData.Cycles value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2BC0D0 Offset: 0x2BC1D1 VA: 0x2BC0D0
	// RVA: 0x27C3190 Offset: 0x27C3291 VA: 0x27C3190
	public SkillData.Frequencies get_Frequency() { }

	[CompilerGeneratedAttribute] // RVA: 0x2BC0E0 Offset: 0x2BC1E1 VA: 0x2BC0E0
	// RVA: 0x27C31A0 Offset: 0x27C32A1 VA: 0x27C31A0
	private void set_Frequency(SkillData.Frequencies value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2BC0F0 Offset: 0x2BC1F1 VA: 0x2BC0F0
	// RVA: 0x27C31B0 Offset: 0x27C32B1 VA: 0x27C31B0
	public string get_Condition() { }

	[CompilerGeneratedAttribute] // RVA: 0x2BC100 Offset: 0x2BC201 VA: 0x2BC100
	// RVA: 0x27C31C0 Offset: 0x27C32C1 VA: 0x27C31C0
	private void set_Condition(string value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2BC110 Offset: 0x2BC211 VA: 0x2BC110
	// RVA: 0x27C31D0 Offset: 0x27C32D1 VA: 0x27C31D0
	public SkillData.GiveTargets get_GiveTarget() { }

	[CompilerGeneratedAttribute] // RVA: 0x2BC120 Offset: 0x2BC221 VA: 0x2BC120
	// RVA: 0x27C31E0 Offset: 0x27C32E1 VA: 0x27C31E0
	private void set_GiveTarget(SkillData.GiveTargets value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2BC130 Offset: 0x2BC231 VA: 0x2BC130
	// RVA: 0x27C31F0 Offset: 0x27C32F1 VA: 0x27C31F0
	public string get_GiveCondition() { }

	[CompilerGeneratedAttribute] // RVA: 0x2BC140 Offset: 0x2BC241 VA: 0x2BC140
	// RVA: 0x27C3200 Offset: 0x27C3301 VA: 0x27C3200
	private void set_GiveCondition(string value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2BC150 Offset: 0x2BC251 VA: 0x2BC150
	// RVA: 0x27C3210 Offset: 0x27C3311 VA: 0x27C3210
	public string[] get_GiveSids() { }

	[CompilerGeneratedAttribute] // RVA: 0x2BC160 Offset: 0x2BC261 VA: 0x2BC160
	// RVA: 0x27C3220 Offset: 0x27C3321 VA: 0x27C3220
	private void set_GiveSids(string[] value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2BC170 Offset: 0x2BC271 VA: 0x2BC170
	// RVA: 0x27C3230 Offset: 0x27C3331 VA: 0x27C3230
	public string[] get_RemoveSids() { }

	[CompilerGeneratedAttribute] // RVA: 0x2BC180 Offset: 0x2BC281 VA: 0x2BC180
	// RVA: 0x27C3240 Offset: 0x27C3341 VA: 0x27C3240
	private void set_RemoveSids(string[] value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2BC190 Offset: 0x2BC291 VA: 0x2BC190
	// RVA: 0x27C3250 Offset: 0x27C3351 VA: 0x27C3250
	public string[] get_SyncConditions() { }

	[CompilerGeneratedAttribute] // RVA: 0x2BC1A0 Offset: 0x2BC2A1 VA: 0x2BC1A0
	// RVA: 0x27C3260 Offset: 0x27C3361 VA: 0x27C3260
	private void set_SyncConditions(string[] value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2BC1B0 Offset: 0x2BC2B1 VA: 0x2BC1B0
	// RVA: 0x27C3270 Offset: 0x27C3371 VA: 0x27C3270
	public string[] get_SyncSids() { }

	[CompilerGeneratedAttribute] // RVA: 0x2BC1C0 Offset: 0x2BC2C1 VA: 0x2BC1C0
	// RVA: 0x27C3280 Offset: 0x27C3381 VA: 0x27C3280
	private void set_SyncSids(string[] value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2BC1D0 Offset: 0x2BC2D1 VA: 0x2BC1D0
	// RVA: 0x27C3290 Offset: 0x27C3391 VA: 0x27C3290
	public string get_RebirthSid() { }

	[CompilerGeneratedAttribute] // RVA: 0x2BC1E0 Offset: 0x2BC2E1 VA: 0x2BC1E0
	// RVA: 0x27C32A0 Offset: 0x27C33A1 VA: 0x27C32A0
	private void set_RebirthSid(string value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2BC1F0 Offset: 0x2BC2F1 VA: 0x2BC1F0
	// RVA: 0x27C32B0 Offset: 0x27C33B1 VA: 0x27C32B0
	public string get_EngageSid() { }

	[CompilerGeneratedAttribute] // RVA: 0x2BC200 Offset: 0x2BC301 VA: 0x2BC200
	// RVA: 0x27C32C0 Offset: 0x27C33C1 VA: 0x27C32C0
	private void set_EngageSid(string value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2BC210 Offset: 0x2BC311 VA: 0x2BC210
	// RVA: 0x27C32D0 Offset: 0x27C33D1 VA: 0x27C32D0
	public string[] get_ChangeSids() { }

	[CompilerGeneratedAttribute] // RVA: 0x2BC220 Offset: 0x2BC321 VA: 0x2BC220
	// RVA: 0x27C32E0 Offset: 0x27C33E1 VA: 0x27C32E0
	private void set_ChangeSids(string[] value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2BC230 Offset: 0x2BC331 VA: 0x2BC230
	// RVA: 0x27C32F0 Offset: 0x27C33F1 VA: 0x27C32F0
	public string get_AttackRange() { }

	[CompilerGeneratedAttribute] // RVA: 0x2BC240 Offset: 0x2BC341 VA: 0x2BC240
	// RVA: 0x27C3300 Offset: 0x27C3401 VA: 0x27C3300
	private void set_AttackRange(string value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2BC250 Offset: 0x2BC351 VA: 0x2BC250
	// RVA: 0x27C3310 Offset: 0x27C3411 VA: 0x27C3310
	public string get_OverlapRange() { }

	[CompilerGeneratedAttribute] // RVA: 0x2BC260 Offset: 0x2BC361 VA: 0x2BC260
	// RVA: 0x27C3320 Offset: 0x27C3421 VA: 0x27C3320
	private void set_OverlapRange(string value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2BC270 Offset: 0x2BC371 VA: 0x2BC270
	// RVA: 0x27C3330 Offset: 0x27C3431 VA: 0x27C3330
	public string get_OverlapTerrain() { }

	[CompilerGeneratedAttribute] // RVA: 0x2BC280 Offset: 0x2BC381 VA: 0x2BC280
	// RVA: 0x27C3340 Offset: 0x27C3441 VA: 0x27C3340
	private void set_OverlapTerrain(string value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2BC290 Offset: 0x2BC391 VA: 0x2BC290
	// RVA: 0x27C3350 Offset: 0x27C3451 VA: 0x27C3350
	public string get_ZocRange() { }

	[CompilerGeneratedAttribute] // RVA: 0x2BC2A0 Offset: 0x2BC3A1 VA: 0x2BC2A0
	// RVA: 0x27C3360 Offset: 0x27C3461 VA: 0x27C3360
	private void set_ZocRange(string value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2BC2B0 Offset: 0x2BC3B1 VA: 0x2BC2B0
	// RVA: 0x27C3370 Offset: 0x27C3471 VA: 0x27C3370
	public SkillData.Zocs get_ZocType() { }

	[CompilerGeneratedAttribute] // RVA: 0x2BC2C0 Offset: 0x2BC3C1 VA: 0x2BC2C0
	// RVA: 0x27C3380 Offset: 0x27C3481 VA: 0x27C3380
	private void set_ZocType(SkillData.Zocs value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2BC2D0 Offset: 0x2BC3D1 VA: 0x2BC2D0
	// RVA: 0x27C3390 Offset: 0x27C3491 VA: 0x27C3390
	public string get_CooperationSkill() { }

	[CompilerGeneratedAttribute] // RVA: 0x2BC2E0 Offset: 0x2BC3E1 VA: 0x2BC2E0
	// RVA: 0x27C33A0 Offset: 0x27C34A1 VA: 0x27C33A0
	private void set_CooperationSkill(string value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2BC2F0 Offset: 0x2BC3F1 VA: 0x2BC2F0
	// RVA: 0x27C33B0 Offset: 0x27C34B1 VA: 0x27C33B0
	public string get_HorseSkill() { }

	[CompilerGeneratedAttribute] // RVA: 0x2BC300 Offset: 0x2BC401 VA: 0x2BC300
	// RVA: 0x27C33C0 Offset: 0x27C34C1 VA: 0x27C33C0
	private void set_HorseSkill(string value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2BC310 Offset: 0x2BC411 VA: 0x2BC310
	// RVA: 0x27C33D0 Offset: 0x27C34D1 VA: 0x27C33D0
	public string get_CovertSkill() { }

	[CompilerGeneratedAttribute] // RVA: 0x2BC320 Offset: 0x2BC421 VA: 0x2BC320
	// RVA: 0x27C33E0 Offset: 0x27C34E1 VA: 0x27C33E0
	private void set_CovertSkill(string value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2BC330 Offset: 0x2BC431 VA: 0x2BC330
	// RVA: 0x27C33F0 Offset: 0x27C34F1 VA: 0x27C33F0
	public string get_HeavySkill() { }

	[CompilerGeneratedAttribute] // RVA: 0x2BC340 Offset: 0x2BC441 VA: 0x2BC340
	// RVA: 0x27C3400 Offset: 0x27C3501 VA: 0x27C3400
	private void set_HeavySkill(string value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2BC350 Offset: 0x2BC451 VA: 0x2BC350
	// RVA: 0x27C3410 Offset: 0x27C3511 VA: 0x27C3410
	public string get_FlySkill() { }

	[CompilerGeneratedAttribute] // RVA: 0x2BC360 Offset: 0x2BC461 VA: 0x2BC360
	// RVA: 0x27C3420 Offset: 0x27C3521 VA: 0x27C3420
	private void set_FlySkill(string value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2BC370 Offset: 0x2BC471 VA: 0x2BC370
	// RVA: 0x27C3430 Offset: 0x27C3531 VA: 0x27C3430
	public string get_MagicSkill() { }

	[CompilerGeneratedAttribute] // RVA: 0x2BC380 Offset: 0x2BC481 VA: 0x2BC380
	// RVA: 0x27C3440 Offset: 0x27C3541 VA: 0x27C3440
	private void set_MagicSkill(string value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2BC390 Offset: 0x2BC491 VA: 0x2BC390
	// RVA: 0x27C3450 Offset: 0x27C3551 VA: 0x27C3450
	public string get_PranaSkill() { }

	[CompilerGeneratedAttribute] // RVA: 0x2BC3A0 Offset: 0x2BC4A1 VA: 0x2BC3A0
	// RVA: 0x27C3460 Offset: 0x27C3561 VA: 0x27C3460
	private void set_PranaSkill(string value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2BC3B0 Offset: 0x2BC4B1 VA: 0x2BC3B0
	// RVA: 0x27C3470 Offset: 0x27C3571 VA: 0x27C3470
	public string get_DragonSkill() { }

	[CompilerGeneratedAttribute] // RVA: 0x2BC3C0 Offset: 0x2BC4C1 VA: 0x2BC3C0
	// RVA: 0x27C3480 Offset: 0x27C3581 VA: 0x27C3480
	private void set_DragonSkill(string value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2BC3D0 Offset: 0x2BC4D1 VA: 0x2BC3D0
	// RVA: 0x27C3490 Offset: 0x27C3591 VA: 0x27C3490
	public string[] get_ActNames() { }

	[CompilerGeneratedAttribute] // RVA: 0x2BC3E0 Offset: 0x2BC4E1 VA: 0x2BC3E0
	// RVA: 0x27C34A0 Offset: 0x27C35A1 VA: 0x27C34A0
	private void set_ActNames(string[] value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2BC3F0 Offset: 0x2BC4F1 VA: 0x2BC3F0
	// RVA: 0x27C34B0 Offset: 0x27C35B1 VA: 0x27C34B0
	public string[] get_ActOperations() { }

	[CompilerGeneratedAttribute] // RVA: 0x2BC400 Offset: 0x2BC501 VA: 0x2BC400
	// RVA: 0x27C34C0 Offset: 0x27C35C1 VA: 0x27C34C0
	private void set_ActOperations(string[] value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2BC410 Offset: 0x2BC511 VA: 0x2BC410
	// RVA: 0x27C34D0 Offset: 0x27C35D1 VA: 0x27C34D0
	public string[] get_ActValues() { }

	[CompilerGeneratedAttribute] // RVA: 0x2BC420 Offset: 0x2BC521 VA: 0x2BC420
	// RVA: 0x27C34E0 Offset: 0x27C35E1 VA: 0x27C34E0
	private void set_ActValues(string[] value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2BC430 Offset: 0x2BC531 VA: 0x2BC430
	// RVA: 0x27C34F0 Offset: 0x27C35F1 VA: 0x27C34F0
	public SkillData.AroundCenters get_AroundCenter() { }

	[CompilerGeneratedAttribute] // RVA: 0x2BC440 Offset: 0x2BC541 VA: 0x2BC440
	// RVA: 0x27C3500 Offset: 0x27C3601 VA: 0x27C3500
	private void set_AroundCenter(SkillData.AroundCenters value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2BC450 Offset: 0x2BC551 VA: 0x2BC450
	// RVA: 0x27C3510 Offset: 0x27C3611 VA: 0x27C3510
	public SkillData.AroundTargets get_AroundTarget() { }

	[CompilerGeneratedAttribute] // RVA: 0x2BC460 Offset: 0x2BC561 VA: 0x2BC460
	// RVA: 0x27C3520 Offset: 0x27C3621 VA: 0x27C3520
	private void set_AroundTarget(SkillData.AroundTargets value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2BC470 Offset: 0x2BC571 VA: 0x2BC470
	// RVA: 0x27C3530 Offset: 0x27C3631 VA: 0x27C3530
	public string get_AroundCondition() { }

	[CompilerGeneratedAttribute] // RVA: 0x2BC480 Offset: 0x2BC581 VA: 0x2BC480
	// RVA: 0x27C3540 Offset: 0x27C3641 VA: 0x27C3540
	private void set_AroundCondition(string value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2BC490 Offset: 0x2BC591 VA: 0x2BC490
	// RVA: 0x27C3550 Offset: 0x27C3651 VA: 0x27C3550
	public string get_AroundName() { }

	[CompilerGeneratedAttribute] // RVA: 0x2BC4A0 Offset: 0x2BC5A1 VA: 0x2BC4A0
	// RVA: 0x27C3560 Offset: 0x27C3661 VA: 0x27C3560
	private void set_AroundName(string value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2BC4B0 Offset: 0x2BC5B1 VA: 0x2BC4B0
	// RVA: 0x27C3570 Offset: 0x27C3671 VA: 0x27C3570
	public string get_AroundOperation() { }

	[CompilerGeneratedAttribute] // RVA: 0x2BC4C0 Offset: 0x2BC5C1 VA: 0x2BC4C0
	// RVA: 0x27C3580 Offset: 0x27C3681 VA: 0x27C3580
	private void set_AroundOperation(string value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2BC4D0 Offset: 0x2BC5D1 VA: 0x2BC4D0
	// RVA: 0x27C3590 Offset: 0x27C3691 VA: 0x27C3590
	public string get_AroundValue() { }

	[CompilerGeneratedAttribute] // RVA: 0x2BC4E0 Offset: 0x2BC5E1 VA: 0x2BC4E0
	// RVA: 0x27C35A0 Offset: 0x27C36A1 VA: 0x27C35A0
	private void set_AroundValue(string value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2BC4F0 Offset: 0x2BC5F1 VA: 0x2BC4F0
	// RVA: 0x27C35B0 Offset: 0x27C36B1 VA: 0x27C35B0
	public SkillData.States get_BadState() { }

	[CompilerGeneratedAttribute] // RVA: 0x2BC500 Offset: 0x2BC601 VA: 0x2BC500
	// RVA: 0x27C35C0 Offset: 0x27C36C1 VA: 0x27C35C0
	private void set_BadState(SkillData.States value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2BC510 Offset: 0x2BC611 VA: 0x2BC510
	// RVA: 0x27C35D0 Offset: 0x27C36D1 VA: 0x27C35D0
	public SkillData.States get_BadIgnore() { }

	[CompilerGeneratedAttribute] // RVA: 0x2BC520 Offset: 0x2BC621 VA: 0x2BC520
	// RVA: 0x27C35E0 Offset: 0x27C36E1 VA: 0x27C35E0
	private void set_BadIgnore(SkillData.States value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2BC530 Offset: 0x2BC631 VA: 0x2BC530
	// RVA: 0x27C35F0 Offset: 0x27C36F1 VA: 0x27C35F0
	public SkillData.Attrs get_Efficacy() { }

	[CompilerGeneratedAttribute] // RVA: 0x2BC540 Offset: 0x2BC641 VA: 0x2BC540
	// RVA: 0x27C3600 Offset: 0x27C3701 VA: 0x27C3600
	private void set_Efficacy(SkillData.Attrs value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2BC550 Offset: 0x2BC651 VA: 0x2BC550
	// RVA: 0x27C3610 Offset: 0x27C3711 VA: 0x27C3610
	public SkillData.Attrs get_EfficacyIgnore() { }

	[CompilerGeneratedAttribute] // RVA: 0x2BC560 Offset: 0x2BC661 VA: 0x2BC560
	// RVA: 0x27C3620 Offset: 0x27C3721 VA: 0x27C3620
	private void set_EfficacyIgnore(SkillData.Attrs value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2BC570 Offset: 0x2BC671 VA: 0x2BC570
	// RVA: 0x27C3630 Offset: 0x27C3731 VA: 0x27C3630
	public int get_EfficacyValue() { }

	[CompilerGeneratedAttribute] // RVA: 0x2BC580 Offset: 0x2BC681 VA: 0x2BC580
	// RVA: 0x27C3640 Offset: 0x27C3741 VA: 0x27C3640
	private void set_EfficacyValue(int value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2BC590 Offset: 0x2BC691 VA: 0x2BC590
	// RVA: 0x27C3650 Offset: 0x27C3751 VA: 0x27C3650
	public SkillData.Flags get_Flag() { }

	[CompilerGeneratedAttribute] // RVA: 0x2BC5A0 Offset: 0x2BC6A1 VA: 0x2BC5A0
	// RVA: 0x27C3660 Offset: 0x27C3761 VA: 0x27C3660
	private void set_Flag(SkillData.Flags value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2BC5B0 Offset: 0x2BC6B1 VA: 0x2BC5B0
	// RVA: 0x27C3670 Offset: 0x27C3771 VA: 0x27C3670
	public SkillData.PrivateFlags get_PrivateFlag() { }

	[CompilerGeneratedAttribute] // RVA: 0x2BC5C0 Offset: 0x2BC6C1 VA: 0x2BC5C0
	// RVA: 0x27C3680 Offset: 0x27C3781 VA: 0x27C3680
	private void set_PrivateFlag(SkillData.PrivateFlags value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2BC5D0 Offset: 0x2BC6D1 VA: 0x2BC5D0
	// RVA: 0x27C3690 Offset: 0x27C3791 VA: 0x27C3690
	public SkillData.Works get_Work() { }

	[CompilerGeneratedAttribute] // RVA: 0x2BC5E0 Offset: 0x2BC6E1 VA: 0x2BC5E0
	// RVA: 0x27C36A0 Offset: 0x27C37A1 VA: 0x27C36A0
	private void set_Work(SkillData.Works value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2BC5F0 Offset: 0x2BC6F1 VA: 0x2BC5F0
	// RVA: 0x27C36B0 Offset: 0x27C37B1 VA: 0x27C36B0
	public string get_WorkOperation() { }

	[CompilerGeneratedAttribute] // RVA: 0x2BC600 Offset: 0x2BC701 VA: 0x2BC600
	// RVA: 0x27C36C0 Offset: 0x27C37C1 VA: 0x27C36C0
	private void set_WorkOperation(string value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2BC610 Offset: 0x2BC711 VA: 0x2BC610
	// RVA: 0x27C36D0 Offset: 0x27C37D1 VA: 0x27C36D0
	public float get_WorkValue() { }

	[CompilerGeneratedAttribute] // RVA: 0x2BC620 Offset: 0x2BC721 VA: 0x2BC620
	// RVA: 0x27C36E0 Offset: 0x27C37E1 VA: 0x27C36E0
	private void set_WorkValue(float value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2BC630 Offset: 0x2BC731 VA: 0x2BC630
	// RVA: 0x27C36F0 Offset: 0x27C37F1 VA: 0x27C36F0
	public int get_Power() { }

	[CompilerGeneratedAttribute] // RVA: 0x2BC640 Offset: 0x2BC741 VA: 0x2BC640
	// RVA: 0x27C3700 Offset: 0x27C3801 VA: 0x27C3700
	private void set_Power(int value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2BC650 Offset: 0x2BC751 VA: 0x2BC650
	// RVA: 0x27C3710 Offset: 0x27C3811 VA: 0x27C3710
	public int get_Life() { }

	[CompilerGeneratedAttribute] // RVA: 0x2BC660 Offset: 0x2BC761 VA: 0x2BC660
	// RVA: 0x27C3720 Offset: 0x27C3821 VA: 0x27C3720
	private void set_Life(int value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2BC670 Offset: 0x2BC771 VA: 0x2BC670
	// RVA: 0x27C3730 Offset: 0x27C3831 VA: 0x27C3730
	public int get_Cost() { }

	[CompilerGeneratedAttribute] // RVA: 0x2BC680 Offset: 0x2BC781 VA: 0x2BC680
	// RVA: 0x27C3740 Offset: 0x27C3841 VA: 0x27C3740
	private void set_Cost(int value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2BC690 Offset: 0x2BC791 VA: 0x2BC690
	// RVA: 0x27C3750 Offset: 0x27C3851 VA: 0x27C3750
	public int get_Rewarp() { }

	[CompilerGeneratedAttribute] // RVA: 0x2BC6A0 Offset: 0x2BC7A1 VA: 0x2BC6A0
	// RVA: 0x27C3760 Offset: 0x27C3861 VA: 0x27C3760
	private void set_Rewarp(int value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2BC6B0 Offset: 0x2BC7B1 VA: 0x2BC6B0
	// RVA: 0x27C3770 Offset: 0x27C3871 VA: 0x27C3770
	public int get_Removable() { }

	[CompilerGeneratedAttribute] // RVA: 0x2BC6C0 Offset: 0x2BC7C1 VA: 0x2BC6C0
	// RVA: 0x27C3780 Offset: 0x27C3881 VA: 0x27C3780
	private void set_Removable(int value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2BC6D0 Offset: 0x2BC7D1 VA: 0x2BC6D0
	// RVA: 0x27C3790 Offset: 0x27C3891 VA: 0x27C3790
	public int get_VisionCount() { }

	[CompilerGeneratedAttribute] // RVA: 0x2BC6E0 Offset: 0x2BC7E1 VA: 0x2BC6E0
	// RVA: 0x27C37A0 Offset: 0x27C38A1 VA: 0x27C37A0
	private void set_VisionCount(int value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2BC6F0 Offset: 0x2BC7F1 VA: 0x2BC6F0
	// RVA: 0x27C37B0 Offset: 0x27C38B1 VA: 0x27C37B0
	public ItemData.Kinds get_RangeTarget() { }

	[CompilerGeneratedAttribute] // RVA: 0x2BC700 Offset: 0x2BC801 VA: 0x2BC700
	// RVA: 0x27C37C0 Offset: 0x27C38C1 VA: 0x27C37C0
	private void set_RangeTarget(ItemData.Kinds value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2BC710 Offset: 0x2BC811 VA: 0x2BC710
	// RVA: 0x27C37D0 Offset: 0x27C38D1 VA: 0x27C37D0
	public int get_RangeI() { }

	[CompilerGeneratedAttribute] // RVA: 0x2BC720 Offset: 0x2BC821 VA: 0x2BC720
	// RVA: 0x27C37E0 Offset: 0x27C38E1 VA: 0x27C37E0
	private void set_RangeI(int value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2BC730 Offset: 0x2BC831 VA: 0x2BC730
	// RVA: 0x27C37F0 Offset: 0x27C38F1 VA: 0x27C37F0
	public int get_RangeO() { }

	[CompilerGeneratedAttribute] // RVA: 0x2BC740 Offset: 0x2BC841 VA: 0x2BC740
	// RVA: 0x27C3800 Offset: 0x27C3901 VA: 0x27C3800
	private void set_RangeO(int value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2BC750 Offset: 0x2BC851 VA: 0x2BC750
	// RVA: 0x27C3810 Offset: 0x27C3911 VA: 0x27C3810
	public int get_RangeAdd() { }

	[CompilerGeneratedAttribute] // RVA: 0x2BC760 Offset: 0x2BC861 VA: 0x2BC760
	// RVA: 0x27C3820 Offset: 0x27C3921 VA: 0x27C3820
	private void set_RangeAdd(int value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2BC770 Offset: 0x2BC871 VA: 0x2BC770
	// RVA: 0x27C3830 Offset: 0x27C3931 VA: 0x27C3830
	public int get_RangeExtend() { }

	[CompilerGeneratedAttribute] // RVA: 0x2BC780 Offset: 0x2BC881 VA: 0x2BC780
	// RVA: 0x27C3840 Offset: 0x27C3941 VA: 0x27C3840
	private void set_RangeExtend(int value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2BC790 Offset: 0x2BC891 VA: 0x2BC790
	// RVA: 0x27C3850 Offset: 0x27C3951 VA: 0x27C3850
	public int get_MoveSelf() { }

	[CompilerGeneratedAttribute] // RVA: 0x2BC7A0 Offset: 0x2BC8A1 VA: 0x2BC7A0
	// RVA: 0x27C3860 Offset: 0x27C3961 VA: 0x27C3860
	private void set_MoveSelf(int value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2BC7B0 Offset: 0x2BC8B1 VA: 0x2BC7B0
	// RVA: 0x27C3870 Offset: 0x27C3971 VA: 0x27C3870
	public int get_MoveTarget() { }

	[CompilerGeneratedAttribute] // RVA: 0x2BC7C0 Offset: 0x2BC8C1 VA: 0x2BC7C0
	// RVA: 0x27C3880 Offset: 0x27C3981 VA: 0x27C3880
	private void set_MoveTarget(int value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2BC7D0 Offset: 0x2BC8D1 VA: 0x2BC7D0
	// RVA: 0x27C3890 Offset: 0x27C3991 VA: 0x27C3890
	public sbyte get_EnhanceLevel() { }

	[CompilerGeneratedAttribute] // RVA: 0x2BC7E0 Offset: 0x2BC8E1 VA: 0x2BC7E0
	// RVA: 0x27C38A0 Offset: 0x27C39A1 VA: 0x27C38A0
	private void set_EnhanceLevel(sbyte value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2BC7F0 Offset: 0x2BC8F1 VA: 0x2BC7F0
	// RVA: 0x27C38B0 Offset: 0x27C39B1 VA: 0x27C38B0
	public CapabilitySbyte get_EnhanceValue() { }

	[CompilerGeneratedAttribute] // RVA: 0x2BC800 Offset: 0x2BC901 VA: 0x2BC800
	// RVA: 0x27C38C0 Offset: 0x27C39C1 VA: 0x27C38C0
	private void set_EnhanceValue(CapabilitySbyte value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2BC810 Offset: 0x2BC911 VA: 0x2BC810
	// RVA: 0x27C38D0 Offset: 0x27C39D1 VA: 0x27C38D0
	public WeaponMask get_WeaponProhibit() { }

	[CompilerGeneratedAttribute] // RVA: 0x2BC820 Offset: 0x2BC921 VA: 0x2BC820
	// RVA: 0x27C38E0 Offset: 0x27C39E1 VA: 0x27C38E0
	private void set_WeaponProhibit(WeaponMask value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2BC830 Offset: 0x2BC931 VA: 0x2BC830
	// RVA: 0x27C38F0 Offset: 0x27C39F1 VA: 0x27C38F0
	public WeaponLevels get_WeaponLevel() { }

	[CompilerGeneratedAttribute] // RVA: 0x2BC840 Offset: 0x2BC941 VA: 0x2BC840
	// RVA: 0x27C3900 Offset: 0x27C3A01 VA: 0x27C3900
	private void set_WeaponLevel(WeaponLevels value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2BC850 Offset: 0x2BC951 VA: 0x2BC850
	// RVA: 0x27C3910 Offset: 0x27C3A11 VA: 0x27C3910
	public string get_Effect() { }

	[CompilerGeneratedAttribute] // RVA: 0x2BC860 Offset: 0x2BC961 VA: 0x2BC860
	// RVA: 0x27C3920 Offset: 0x27C3A21 VA: 0x27C3920
	private void set_Effect(string value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2BC870 Offset: 0x2BC971 VA: 0x2BC870
	// RVA: 0x27C3930 Offset: 0x27C3A31 VA: 0x27C3930
	public ushort get_InheritanceCost() { }

	[CompilerGeneratedAttribute] // RVA: 0x2BC880 Offset: 0x2BC981 VA: 0x2BC880
	// RVA: 0x27C3940 Offset: 0x27C3A41 VA: 0x27C3940
	private void set_InheritanceCost(ushort value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2BC890 Offset: 0x2BC991 VA: 0x2BC890
	// RVA: 0x27C3950 Offset: 0x27C3A51 VA: 0x27C3950
	public ushort get_InheritanceSort() { }

	[CompilerGeneratedAttribute] // RVA: 0x2BC8A0 Offset: 0x2BC9A1 VA: 0x2BC8A0
	// RVA: 0x27C3960 Offset: 0x27C3A61 VA: 0x27C3960
	private void set_InheritanceSort(ushort value) { }

	// RVA: 0x27C3970 Offset: 0x27C3A71 VA: 0x27C3970
	public int get_InheritanceSortKey() { }

	// RVA: 0x27C3980 Offset: 0x27C3A81 VA: 0x27C3980
	public void .ctor() { }

	// RVA: 0x27C3CA0 Offset: 0x27C3DA1 VA: 0x27C3CA0 Slot: 9
	protected override CalculatorManager get_Calculator() { }

	// RVA: 0x27C3D20 Offset: 0x27C3E21 VA: 0x27C3D20
	private static SkillData.Operations GetOperations(string operation) { }

	// RVA: 0x27C3E70 Offset: 0x27C3F71 VA: 0x27C3E70
	private SkillData.Func CreateFunc(string header, int index, string name, string operation, string value) { }

	// RVA: 0x27C4060 Offset: 0x27C4161 VA: 0x27C4060
	private static SkillData ReadSkill(string sid) { }

	// RVA: 0x27C4100 Offset: 0x27C4201 VA: 0x27C4100 Slot: 4
	public override void OnBuild() { }

	// RVA: 0x27C44E0 Offset: 0x27C45E1 VA: 0x27C44E0
	private SkillData[] CalcChangeSkills() { }

	// RVA: 0x27C4710 Offset: 0x27C4811 VA: 0x27C4710 Slot: 5
	public override void OnCompleted() { }

	// RVA: 0x27C66C0 Offset: 0x27C67C1 VA: 0x27C66C0
	private static void GroupAssign() { }

	// RVA: 0x27C6860 Offset: 0x27C6961 VA: 0x27C6860 Slot: 6
	public override void OnCompletedEnd() { }

	// RVA: 0x27C6AF0 Offset: 0x27C6BF1 VA: 0x27C6AF0 Slot: 7
	public override void OnRelease() { }

	// RVA: 0x27C6DB0 Offset: 0x27C6EB1 VA: 0x27C6DB0
	public SkillData GetStyleSkill(BattleStyle.Types type) { }

	// RVA: 0x27C65A0 Offset: 0x27C66A1 VA: 0x27C65A0
	private void SetStyleSkill(BattleStyle.Types type, string name) { }

	// RVA: 0x27C6DF0 Offset: 0x27C6EF1 VA: 0x27C6DF0
	public RangeData.Targets GetRangeCenter() { }

	// RVA: 0x27C6EA0 Offset: 0x27C6FA1 VA: 0x27C6EA0
	public List<RangeData.Offset> GetAttackRange(Dir.Type dir = 128) { }

	// RVA: 0x27C6F40 Offset: 0x27C7041 VA: 0x27C6F40
	public List<RangeData.Offset> GetOverlapRange(Dir.Type dir = 128) { }

	// RVA: 0x27C6FE0 Offset: 0x27C70E1 VA: 0x27C6FE0
	public bool HasOverlapTerrain() { }

	// RVA: 0x27C7010 Offset: 0x27C7111 VA: 0x27C7010
	public TerrainData GetOverlapTerrain() { }

	// RVA: 0x27C70B0 Offset: 0x27C71B1 VA: 0x27C70B0
	public List<RangeData.Offset> GetZOCRange() { }

	// RVA: 0x27C7140 Offset: 0x27C7241 VA: 0x27C7140
	public WeaponMask GetWeaponLevelMask() { }

	// RVA: 0x27C7150 Offset: 0x27C7251 VA: 0x27C7150
	private static ItemData GetItem(string iid) { }

	// RVA: 0x27C71E0 Offset: 0x27C72E1 VA: 0x27C71E0
	public string GetName() { }

	// RVA: 0x27C7270 Offset: 0x27C7371 VA: 0x27C7270
	public string GetHelp() { }

	// RVA: 0x27C7300 Offset: 0x27C7401 VA: 0x27C7300
	public string GetCommandName() { }

	// RVA: 0x27C7390 Offset: 0x27C7491 VA: 0x27C7390
	public string GetCommandHelp() { }

	// RVA: 0x27C7420 Offset: 0x27C7521 VA: 0x27C7420
	public string GetPrefixlessSid() { }

	// RVA: 0x27C7430 Offset: 0x27C7531 VA: 0x27C7430
	public static Color GetFontColor(bool isEngage, bool isActive) { }

	// RVA: 0x27C7580 Offset: 0x27C7681 VA: 0x27C7580 Slot: 8
	public override string GetDebugName() { }

	// RVA: 0x27C7750 Offset: 0x27C7851 VA: 0x27C7750
	public bool IsCommandSkill() { }

	// RVA: 0x27C7770 Offset: 0x27C7871 VA: 0x27C7770
	private bool IsConditionImpl(CalculatorCommand command, object obj1, object obj2) { }

	// RVA: 0x27C77B0 Offset: 0x27C78B1 VA: 0x27C77B0
	public bool HasCondition() { }

	// RVA: 0x27C77C0 Offset: 0x27C78C1 VA: 0x27C77C0
	public bool IsCondition() { }

	// RVA: 0x27C7800 Offset: 0x27C7901 VA: 0x27C7800
	public bool IsCondition(Unit current, Unit reverse) { }

	// RVA: 0x27C7840 Offset: 0x27C7941 VA: 0x27C7840
	public bool IsCondition(BattleInfoSide current, BattleInfoSide reverse) { }

	// RVA: 0x27C7880 Offset: 0x27C7981 VA: 0x27C7880
	public bool IsGiveCondition(Unit current, Unit reverse) { }

	// RVA: 0x27C78C0 Offset: 0x27C79C1 VA: 0x27C78C0
	public bool IsGiveCondition(BattleInfoSide current, BattleInfoSide reverse) { }

	// RVA: 0x27C7900 Offset: 0x27C7A01 VA: 0x27C7900
	private bool ExecuteImpl(SkillData.Func func, object obj1, object obj2) { }

	// RVA: 0x27C79E0 Offset: 0x27C7AE1 VA: 0x27C79E0
	public bool HasExecuteAct() { }

	// RVA: 0x27C7A30 Offset: 0x27C7B31 VA: 0x27C7A30
	public bool ExecuteAct(Unit current, Unit reverse) { }

	// RVA: 0x27C7B00 Offset: 0x27C7C01 VA: 0x27C7B00
	public bool ExecuteAct(BattleInfoSide current, BattleInfoSide reverse) { }

	// RVA: 0x27C7BD0 Offset: 0x27C7CD1 VA: 0x27C7BD0
	public bool IsStyleSkill() { }

	// RVA: 0x27C7BE0 Offset: 0x27C7CE1 VA: 0x27C7BE0
	public bool IsSyncCondition(Unit unit, int index) { }

	// RVA: 0x27C7C40 Offset: 0x27C7D41 VA: 0x27C7C40
	private bool IsArounConditionTarget(Unit unit, Unit target) { }

	// RVA: 0x27C7E10 Offset: 0x27C7F11 VA: 0x27C7E10
	public bool IsArounCondition(Unit unit, Unit target) { }

	// RVA: 0x27C8800 Offset: 0x27C8901 VA: 0x27C8800
	public bool IsArounCondition(Unit unit, Unit center, Unit target) { }

	// RVA: 0x27C9100 Offset: 0x27C9201 VA: 0x27C9100
	public bool IsArounCondition(Unit unit, Unit center, Unit target, int rangeI, int rangeO) { }

	// RVA: 0x27C9A00 Offset: 0x27C9B01 VA: 0x27C9A00
	public bool HasExecuteAround() { }

	// RVA: 0x27C9A50 Offset: 0x27C9B51 VA: 0x27C9A50
	public bool ExecuteAround(Unit unit, Unit target) { }

	// RVA: 0x27C9B20 Offset: 0x27C9C21 VA: 0x27C9B20
	public bool ExecuteAround(BattleInfoSide current, BattleInfoSide reverse) { }

	// RVA: 0x27C9BF0 Offset: 0x27C9CF1 VA: 0x27C9BF0
	public bool CanFrequency(SkillData.Frequencies frequency) { }

	// RVA: 0x27C9C10 Offset: 0x27C9D11 VA: 0x27C9C10
	public bool CanEquip() { }

	// RVA: 0x27C9C20 Offset: 0x27C9D21 VA: 0x27C9C20
	public bool HasEffect() { }

	// RVA: 0x27C9C30 Offset: 0x27C9D31 VA: 0x27C9C30
	public bool IsHide() { }

	// RVA: 0x27C9C40 Offset: 0x27C9D41 VA: 0x27C9C40
	public bool IsMoving() { }

	// RVA: 0x27C9C60 Offset: 0x27C9D61 VA: 0x27C9C60
	public bool IsAllRange() { }

	// RVA: 0x27C9C70 Offset: 0x27C9D71 VA: 0x27C9C70
	public Sprite TryGetIcon() { }

	// RVA: 0x27C9C80 Offset: 0x27C9D81 VA: 0x27C9C80
	public Sprite TryGetEffcyIcon(bool isOutline = False) { }

	// RVA: 0x27C9C90 Offset: 0x27C9D91 VA: 0x27C9C90
	public ItemData GetEquipItem(int index = -1) { }

	// RVA: 0x27C9D30 Offset: 0x27C9E31 VA: 0x27C9D30
	public bool HasEquipItem() { }

	// RVA: 0x27C9D80 Offset: 0x27C9E81 VA: 0x27C9D80
	public bool HasNullItem() { }

	// RVA: 0x27C9ED0 Offset: 0x27C9FD1 VA: 0x27C9ED0
	public bool CanTarget(Unit unit, Unit target) { }

	// RVA: 0x27CA240 Offset: 0x27CA341 VA: 0x27CA240
	public bool CanRange(int x, int z, Unit target) { }

	// RVA: 0x27CA520 Offset: 0x27CA621 VA: 0x27CA520
	public bool CanRange(Unit unit, Unit target) { }

	// RVA: 0x27CAAA0 Offset: 0x27CABA1 VA: 0x27CAAA0
	public bool CanRange(int range) { }

	// RVA: 0x27CAAD0 Offset: 0x27CABD1 VA: 0x27CAAD0
	public bool CanSupport(Unit unit, Unit target) { }

	// RVA: 0x27CAE40 Offset: 0x27CAF41 VA: 0x27CAE40
	public bool CanSelfTarget() { }

	// RVA: 0x27CAE70 Offset: 0x27CAF71 VA: 0x27CAE70
	public bool IsRerewarp() { }

	// RVA: 0x27CAED0 Offset: 0x27CAFD1 VA: 0x27CAED0
	public bool IsEnchantmentSkill() { }

	// RVA: 0x27CAF80 Offset: 0x27CB081 VA: 0x27CAF80
	public bool IsFangCurseSkill() { }

	// RVA: 0x27CB030 Offset: 0x27CB131 VA: 0x27CB030
	public int GetFangCurseLevel() { }

	// RVA: 0x27CB0F0 Offset: 0x27CB1F1 VA: 0x27CB0F0
	public int CalcWork(int value) { }

	// RVA: 0x27CB1F0 Offset: 0x27CB2F1 VA: 0x27CB1F0
	public static SkillData.TimingMasks GetTimingMask(SkillData.Timings timing) { }

	// RVA: 0x27CB200 Offset: 0x27CB301 VA: 0x27CB200
	public static SkillData.TimingMasks GetTimingMask(SkillData.Timings timing1, SkillData.Timings timing2) { }

	// RVA: 0x27CB220 Offset: 0x27CB321 VA: 0x27CB220
	public static SkillData.TimingMasks GetTimingMask(SkillData.Timings timing1, SkillData.Timings timing2, SkillData.Timings timing3) { }

	// RVA: 0x27CB240 Offset: 0x27CB341 VA: 0x27CB240
	public static void SerializeSid(Stream stream, SkillData skill) { }

	// RVA: 0x27CB2A0 Offset: 0x27CB3A1 VA: 0x27CB2A0
	public static SkillData DeserializeSid(Stream stream) { }

	// RVA: 0x27CB300 Offset: 0x27CB401 VA: 0x27CB300
	public static void SerializeHash(Stream stream, SkillData skill) { }

	// RVA: 0x27CB310 Offset: 0x27CB411 VA: 0x27CB310
	public static SkillData DeserializeHash(Stream stream) { }

	// RVA: 0x27CB420 Offset: 0x27CB521 VA: 0x27CB420
	public static SkillArray GetEfficacySkills(SkillData.Attrs attrs) { }

	// RVA: 0x27D1FD0 Offset: 0x27D20D1 VA: 0x27D1FD0
	public static SkillData get_HeroSkill() { }

	// RVA: 0x27D2040 Offset: 0x27D2141 VA: 0x27D2040
	public static SkillData get_StunSkill() { }

	// RVA: 0x27D20B0 Offset: 0x27D21B1 VA: 0x27D20B0
	public static SkillData get_DanceSkill() { }

	// RVA: 0x27D2120 Offset: 0x27D2221 VA: 0x27D2120
	public static SkillData get_MorphSkill() { }

	// RVA: 0x27D2190 Offset: 0x27D2291 VA: 0x27D2190
	public static SkillData get_PoisonSkill() { }

	// RVA: 0x27D2200 Offset: 0x27D2301 VA: 0x27D2200
	public static SkillData get_LeaderSkill() { }

	// RVA: 0x27D2270 Offset: 0x27D2371 VA: 0x27D2270
	public static SkillData get_FangCurseSkill() { }

	// RVA: 0x27D22E0 Offset: 0x27D23E1 VA: 0x27D22E0
	public static SkillData get_MultiChangeSkill() { }

	// RVA: 0x27D2350 Offset: 0x27D2451 VA: 0x27D2350
	public static SkillData get_EnchantSkill() { }

	// RVA: 0x27D23C0 Offset: 0x27D24C1 VA: 0x27D23C0
	public static SkillData get_EnchantmentSkill() { }

	// RVA: 0x27D2430 Offset: 0x27D2531 VA: 0x27D2430
	public static SkillData get_ImmortalSkill() { }

	// RVA: 0x27D24A0 Offset: 0x27D25A1 VA: 0x27D24A0
	public static SkillData get_TransporterSkill() { }

	// RVA: 0x27D2510 Offset: 0x27D2611 VA: 0x27D2510
	public static SkillData get_FullBulletSkill() { }

	// RVA: 0x27D2580 Offset: 0x27D2681 VA: 0x27D2580
	public static SkillData get_ChainAttackGuardSkill() { }

	// RVA: 0x27D25F0 Offset: 0x27D26F1 VA: 0x27D25F0
	public static SkillData get_NotTerrainDamageSkill() { }

	// RVA: 0x27D2660 Offset: 0x27D2761 VA: 0x27D2660
	public static SkillData get_GazeDiagonallySkill() { }

	// RVA: 0x27D26D0 Offset: 0x27D27D1 VA: 0x27D26D0
	public EffectSequence GetEffectSeqeunce() { }

	// RVA: 0x27D2770 Offset: 0x27D2871 VA: 0x27D2770
	public EffectData GetEffectData(EffectSequence.Kind kind) { }

	// RVA: 0x27D2830 Offset: 0x27D2931 VA: 0x27D2830
	private string GetEffectPath(EffectSequence.Kind kind, EffectData.Modes mode) { }

	// RVA: 0x27D2900 Offset: 0x27D2A01 VA: 0x27D2900
	public bool IsShowCaption(EffectSequence.Kind kind) { }

	// RVA: 0x27D2A30 Offset: 0x27D2B31 VA: 0x27D2A30
	public bool IsTimeStop() { }

	// RVA: 0x27D2A70 Offset: 0x27D2B71 VA: 0x27D2A70
	public bool IsShowActiveCaption() { }

	// RVA: 0x27D2A80 Offset: 0x27D2B81 VA: 0x27D2A80
	public bool IsShowShootCaption() { }

	// RVA: 0x27D2A90 Offset: 0x27D2B91 VA: 0x27D2A90
	public bool IsShowHitCaption() { }

	// RVA: 0x27D2AA0 Offset: 0x27D2BA1 VA: 0x27D2AA0
	public string GetCombatActiveEffect() { }

	// RVA: 0x27D2AB0 Offset: 0x27D2BB1 VA: 0x27D2AB0
	public string GetCombatHitEffect() { }

	// RVA: 0x27D2AC0 Offset: 0x27D2BC1 VA: 0x27D2AC0
	public string GetBMapActiveEffect() { }

	// RVA: 0x27D2AD0 Offset: 0x27D2BD1 VA: 0x27D2AD0
	public string GetBMapShootEffect() { }

	// RVA: 0x27D2AE0 Offset: 0x27D2BE1 VA: 0x27D2AE0
	public string GetBMapHitEffect() { }

	// RVA: 0x27D2AF0 Offset: 0x27D2BF1 VA: 0x27D2AF0
	public bool CanOverrideSkill() { }

	// RVA: 0x27D2B00 Offset: 0x27D2C01 VA: 0x27D2B00
	private static void .cctor() { }
}

