// Namespace: App
[DebuggerDisplayAttribute] // RVA: 0x275D00 Offset: 0x275E01 VA: 0x275D00
public class BattleInfoSide // TypeDefIndex: 9512
{
	// Fields
	private BattleInfo m_Info; // 0x10
	private BattleSide.Type m_SideType; // 0x18
	private Unit m_Unit; // 0x20
	private UnitItem m_UnitItem; // 0x28
	private UnitItem m_SpecifiedItem; // 0x30
	private int m_X; // 0x38
	private int m_Z; // 0x3C
	private TerrainData m_Terrain; // 0x40
	private TerrainData m_Overlap; // 0x48
	private BattleInfoSide.BitFieldStatus m_Status; // 0x50
	private BattleDetail m_Detail; // 0x58
	private Pool.Hierarchy<BattleDetail> m_Hierarchy; // 0x60
	private SupportCalculator m_Support; // 0x68
	private BattleInfoSide m_Parent; // 0x70
	private BattleInfoSide m_Reverse; // 0x78
	private BattleDestory m_Destroy; // 0x80
	private SkillArray m_MaskSkill; // 0x88
	[CompilerGeneratedAttribute] // RVA: 0x287550 Offset: 0x287651 VA: 0x287550
	private int <Level>k__BackingField; // 0x90
	[CompilerGeneratedAttribute] // RVA: 0x287560 Offset: 0x287661 VA: 0x287560
	private int <Hp>k__BackingField; // 0x94
	[CompilerGeneratedAttribute] // RVA: 0x287570 Offset: 0x287671 VA: 0x287570
	private int <GainExp>k__BackingField; // 0x98
	[CompilerGeneratedAttribute] // RVA: 0x287580 Offset: 0x287681 VA: 0x287580
	private int <GainGold>k__BackingField; // 0x9C
	[CompilerGeneratedAttribute] // RVA: 0x287590 Offset: 0x287691 VA: 0x287590
	private float <DropItemRatio>k__BackingField; // 0xA0
	[CompilerGeneratedAttribute] // RVA: 0x2875A0 Offset: 0x2876A1 VA: 0x2875A0
	private int <PickupItemIndex>k__BackingField; // 0xA4
	[CompilerGeneratedAttribute] // RVA: 0x2875B0 Offset: 0x2876B1 VA: 0x2875B0
	private int <Damage>k__BackingField; // 0xA8
	[CompilerGeneratedAttribute] // RVA: 0x2875C0 Offset: 0x2876C1 VA: 0x2875C0
	private int <Heal>k__BackingField; // 0xAC
	[CompilerGeneratedAttribute] // RVA: 0x2875D0 Offset: 0x2876D1 VA: 0x2875D0
	private int <BattleTimes>k__BackingField; // 0xB0
	[CompilerGeneratedAttribute] // RVA: 0x2875E0 Offset: 0x2876E1 VA: 0x2875E0
	private int <TotalOrder>k__BackingField; // 0xB4
	[CompilerGeneratedAttribute] // RVA: 0x2875F0 Offset: 0x2876F1 VA: 0x2875F0
	private int <TotalAction>k__BackingField; // 0xB8
	[CompilerGeneratedAttribute] // RVA: 0x287600 Offset: 0x287701 VA: 0x287600
	private int <TotalAttack>k__BackingField; // 0xBC
	[CompilerGeneratedAttribute] // RVA: 0x287610 Offset: 0x287711 VA: 0x287610
	private int <TotalDamage>k__BackingField; // 0xC0
	[CompilerGeneratedAttribute] // RVA: 0x287620 Offset: 0x287721 VA: 0x287620
	private BattleScene.Result <TotalResult>k__BackingField; // 0xC4
	[CompilerGeneratedAttribute] // RVA: 0x287630 Offset: 0x287731 VA: 0x287630
	private int <Temporary>k__BackingField; // 0xC8
	[CompilerGeneratedAttribute] // RVA: 0x287640 Offset: 0x287741 VA: 0x287640
	private int <Stun>k__BackingField; // 0xCC
	[CompilerGeneratedAttribute] // RVA: 0x287650 Offset: 0x287751 VA: 0x287650
	private int <EngageCount>k__BackingField; // 0xD0
	[CompilerGeneratedAttribute] // RVA: 0x287660 Offset: 0x287761 VA: 0x287660
	private int <EngageFirstCount>k__BackingField; // 0xD4
	[CompilerGeneratedAttribute] // RVA: 0x287670 Offset: 0x287771 VA: 0x287670
	private int <BlownDistance>k__BackingField; // 0xD8
	[CompilerGeneratedAttribute] // RVA: 0x287680 Offset: 0x287781 VA: 0x287680
	private int <WeaponExpend>k__BackingField; // 0xDC
	[CompilerGeneratedAttribute] // RVA: 0x287690 Offset: 0x287791 VA: 0x287690
	private int <ExpendCount>k__BackingField; // 0xE0
	private static readonly int ContinueCondition; // 0x0

	// Properties
	private string DebuggerDisplay { get; }
	public bool Exist { get; }
	public BattleSide.Type SideType { get; }
	public BattleInfo Info { get; }
	public BattleInfoSide Parent { get; set; }
	public BattleInfoSide Reverse { get; set; }
	public SkillArray MaskSkill { get; }
	public string Name { get; }
	public string Pid { get; }
	public string Jid { get; }
	public string PrefixlessPid { get; }
	public int Level { get; set; }
	public int Hp { get; set; }
	public int GainExp { get; set; }
	public int GainGold { get; set; }
	public float DropItemRatio { get; set; }
	public int PickupItemIndex { get; set; }
	public int Damage { get; set; }
	public int Heal { get; set; }
	public int BattleTimes { get; set; }
	public int TotalOrder { get; set; }
	public int TotalAction { get; set; }
	public int TotalAttack { get; set; }
	public int TotalDamage { get; set; }
	public BattleScene.Result TotalResult { get; set; }
	public int Temporary { get; set; }
	public int Stun { get; set; }
	public int EngageCount { get; set; }
	public int EngageFirstCount { get; set; }
	public int BlownDistance { get; set; }
	public int WeaponExpend { get; set; }
	public int ExpendCount { get; set; }
	public Unit Unit { get; }
	public Force.Type ForceType { get; }
	public int BmapSize { get; }
	public UnitItem UnitItem { get; }
	public UnitActor Actor { get; }
	public BattleDestory Destroy { get; }
	public GodUnit GodUnit { get; }
	public int X { get; set; }
	public int Z { get; set; }
	public TerrainData Terrain { get; }
	public TerrainData Overlap { get; }
	public BattleDetail Detail { get; }
	public SupportCalculator Support { get; }
	public int NowHp { get; }
	public int MaxHp { get; }

	// Methods

	// RVA: 0x2252F00 Offset: 0x2253001 VA: 0x2252F00
	private string get_DebuggerDisplay() { }

	// RVA: 0x2245D80 Offset: 0x2245E81 VA: 0x2245D80
	public void .ctor(BattleInfo info, BattleSide.Type side) { }

	// RVA: 0x2252F90 Offset: 0x2253091 VA: 0x2252F90
	public bool get_Exist() { }

	// RVA: 0x2252FD0 Offset: 0x22530D1 VA: 0x2252FD0
	public BattleSide.Type get_SideType() { }

	// RVA: 0x2252FE0 Offset: 0x22530E1 VA: 0x2252FE0
	public BattleInfo get_Info() { }

	// RVA: 0x2252FF0 Offset: 0x22530F1 VA: 0x2252FF0
	public BattleInfoSide get_Parent() { }

	// RVA: 0x2253000 Offset: 0x2253101 VA: 0x2253000
	public void set_Parent(BattleInfoSide value) { }

	// RVA: 0x2253010 Offset: 0x2253111 VA: 0x2253010
	public BattleInfoSide get_Reverse() { }

	// RVA: 0x2253020 Offset: 0x2253121 VA: 0x2253020
	public void set_Reverse(BattleInfoSide value) { }

	// RVA: 0x2253030 Offset: 0x2253131 VA: 0x2253030
	public SkillArray get_MaskSkill() { }

	// RVA: 0x2253040 Offset: 0x2253141 VA: 0x2253040
	public string get_Name() { }

	// RVA: 0x22530B0 Offset: 0x22531B1 VA: 0x22530B0
	public string get_Pid() { }

	// RVA: 0x2253110 Offset: 0x2253211 VA: 0x2253110
	public string get_Jid() { }

	// RVA: 0x22531F0 Offset: 0x22532F1 VA: 0x22531F0
	public string get_PrefixlessPid() { }

	[CompilerGeneratedAttribute] // RVA: 0x2B0A90 Offset: 0x2B0B91 VA: 0x2B0A90
	// RVA: 0x2253250 Offset: 0x2253351 VA: 0x2253250
	public int get_Level() { }

	[CompilerGeneratedAttribute] // RVA: 0x2B0AA0 Offset: 0x2B0BA1 VA: 0x2B0AA0
	// RVA: 0x2253260 Offset: 0x2253361 VA: 0x2253260
	public void set_Level(int value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2B0AB0 Offset: 0x2B0BB1 VA: 0x2B0AB0
	// RVA: 0x2253270 Offset: 0x2253371 VA: 0x2253270
	public int get_Hp() { }

	[CompilerGeneratedAttribute] // RVA: 0x2B0AC0 Offset: 0x2B0BC1 VA: 0x2B0AC0
	// RVA: 0x2253280 Offset: 0x2253381 VA: 0x2253280
	public void set_Hp(int value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2B0AD0 Offset: 0x2B0BD1 VA: 0x2B0AD0
	// RVA: 0x2253290 Offset: 0x2253391 VA: 0x2253290
	public int get_GainExp() { }

	[CompilerGeneratedAttribute] // RVA: 0x2B0AE0 Offset: 0x2B0BE1 VA: 0x2B0AE0
	// RVA: 0x22532A0 Offset: 0x22533A1 VA: 0x22532A0
	public void set_GainExp(int value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2B0AF0 Offset: 0x2B0BF1 VA: 0x2B0AF0
	// RVA: 0x22532B0 Offset: 0x22533B1 VA: 0x22532B0
	public int get_GainGold() { }

	[CompilerGeneratedAttribute] // RVA: 0x2B0B00 Offset: 0x2B0C01 VA: 0x2B0B00
	// RVA: 0x22532C0 Offset: 0x22533C1 VA: 0x22532C0
	public void set_GainGold(int value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2B0B10 Offset: 0x2B0C11 VA: 0x2B0B10
	// RVA: 0x22532D0 Offset: 0x22533D1 VA: 0x22532D0
	public float get_DropItemRatio() { }

	[CompilerGeneratedAttribute] // RVA: 0x2B0B20 Offset: 0x2B0C21 VA: 0x2B0B20
	// RVA: 0x22532E0 Offset: 0x22533E1 VA: 0x22532E0
	public void set_DropItemRatio(float value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2B0B30 Offset: 0x2B0C31 VA: 0x2B0B30
	// RVA: 0x22532F0 Offset: 0x22533F1 VA: 0x22532F0
	public int get_PickupItemIndex() { }

	[CompilerGeneratedAttribute] // RVA: 0x2B0B40 Offset: 0x2B0C41 VA: 0x2B0B40
	// RVA: 0x2253300 Offset: 0x2253401 VA: 0x2253300
	public void set_PickupItemIndex(int value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2B0B50 Offset: 0x2B0C51 VA: 0x2B0B50
	// RVA: 0x2253310 Offset: 0x2253411 VA: 0x2253310
	public int get_Damage() { }

	[CompilerGeneratedAttribute] // RVA: 0x2B0B60 Offset: 0x2B0C61 VA: 0x2B0B60
	// RVA: 0x2253320 Offset: 0x2253421 VA: 0x2253320
	public void set_Damage(int value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2B0B70 Offset: 0x2B0C71 VA: 0x2B0B70
	// RVA: 0x2253330 Offset: 0x2253431 VA: 0x2253330
	public int get_Heal() { }

	[CompilerGeneratedAttribute] // RVA: 0x2B0B80 Offset: 0x2B0C81 VA: 0x2B0B80
	// RVA: 0x2253340 Offset: 0x2253441 VA: 0x2253340
	public void set_Heal(int value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2B0B90 Offset: 0x2B0C91 VA: 0x2B0B90
	// RVA: 0x2253350 Offset: 0x2253451 VA: 0x2253350
	public int get_BattleTimes() { }

	[CompilerGeneratedAttribute] // RVA: 0x2B0BA0 Offset: 0x2B0CA1 VA: 0x2B0BA0
	// RVA: 0x2253360 Offset: 0x2253461 VA: 0x2253360
	public void set_BattleTimes(int value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2B0BB0 Offset: 0x2B0CB1 VA: 0x2B0BB0
	// RVA: 0x2253370 Offset: 0x2253471 VA: 0x2253370
	public int get_TotalOrder() { }

	[CompilerGeneratedAttribute] // RVA: 0x2B0BC0 Offset: 0x2B0CC1 VA: 0x2B0BC0
	// RVA: 0x2253380 Offset: 0x2253481 VA: 0x2253380
	public void set_TotalOrder(int value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2B0BD0 Offset: 0x2B0CD1 VA: 0x2B0BD0
	// RVA: 0x2253390 Offset: 0x2253491 VA: 0x2253390
	public int get_TotalAction() { }

	[CompilerGeneratedAttribute] // RVA: 0x2B0BE0 Offset: 0x2B0CE1 VA: 0x2B0BE0
	// RVA: 0x22533A0 Offset: 0x22534A1 VA: 0x22533A0
	public void set_TotalAction(int value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2B0BF0 Offset: 0x2B0CF1 VA: 0x2B0BF0
	// RVA: 0x22533B0 Offset: 0x22534B1 VA: 0x22533B0
	public int get_TotalAttack() { }

	[CompilerGeneratedAttribute] // RVA: 0x2B0C00 Offset: 0x2B0D01 VA: 0x2B0C00
	// RVA: 0x22533C0 Offset: 0x22534C1 VA: 0x22533C0
	public void set_TotalAttack(int value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2B0C10 Offset: 0x2B0D11 VA: 0x2B0C10
	// RVA: 0x22533D0 Offset: 0x22534D1 VA: 0x22533D0
	public int get_TotalDamage() { }

	[CompilerGeneratedAttribute] // RVA: 0x2B0C20 Offset: 0x2B0D21 VA: 0x2B0C20
	// RVA: 0x22533E0 Offset: 0x22534E1 VA: 0x22533E0
	public void set_TotalDamage(int value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2B0C30 Offset: 0x2B0D31 VA: 0x2B0C30
	// RVA: 0x22533F0 Offset: 0x22534F1 VA: 0x22533F0
	public BattleScene.Result get_TotalResult() { }

	[CompilerGeneratedAttribute] // RVA: 0x2B0C40 Offset: 0x2B0D41 VA: 0x2B0C40
	// RVA: 0x2253400 Offset: 0x2253501 VA: 0x2253400
	public void set_TotalResult(BattleScene.Result value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2B0C50 Offset: 0x2B0D51 VA: 0x2B0C50
	// RVA: 0x2253410 Offset: 0x2253511 VA: 0x2253410
	public int get_Temporary() { }

	[CompilerGeneratedAttribute] // RVA: 0x2B0C60 Offset: 0x2B0D61 VA: 0x2B0C60
	// RVA: 0x2253420 Offset: 0x2253521 VA: 0x2253420
	public void set_Temporary(int value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2B0C70 Offset: 0x2B0D71 VA: 0x2B0C70
	// RVA: 0x2253430 Offset: 0x2253531 VA: 0x2253430
	public int get_Stun() { }

	[CompilerGeneratedAttribute] // RVA: 0x2B0C80 Offset: 0x2B0D81 VA: 0x2B0C80
	// RVA: 0x2253440 Offset: 0x2253541 VA: 0x2253440
	public void set_Stun(int value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2B0C90 Offset: 0x2B0D91 VA: 0x2B0C90
	// RVA: 0x2253450 Offset: 0x2253551 VA: 0x2253450
	public int get_EngageCount() { }

	[CompilerGeneratedAttribute] // RVA: 0x2B0CA0 Offset: 0x2B0DA1 VA: 0x2B0CA0
	// RVA: 0x2253460 Offset: 0x2253561 VA: 0x2253460
	public void set_EngageCount(int value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2B0CB0 Offset: 0x2B0DB1 VA: 0x2B0CB0
	// RVA: 0x2253470 Offset: 0x2253571 VA: 0x2253470
	public int get_EngageFirstCount() { }

	[CompilerGeneratedAttribute] // RVA: 0x2B0CC0 Offset: 0x2B0DC1 VA: 0x2B0CC0
	// RVA: 0x2253480 Offset: 0x2253581 VA: 0x2253480
	public void set_EngageFirstCount(int value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2B0CD0 Offset: 0x2B0DD1 VA: 0x2B0CD0
	// RVA: 0x2253490 Offset: 0x2253591 VA: 0x2253490
	public int get_BlownDistance() { }

	[CompilerGeneratedAttribute] // RVA: 0x2B0CE0 Offset: 0x2B0DE1 VA: 0x2B0CE0
	// RVA: 0x22534A0 Offset: 0x22535A1 VA: 0x22534A0
	public void set_BlownDistance(int value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2B0CF0 Offset: 0x2B0DF1 VA: 0x2B0CF0
	// RVA: 0x22534B0 Offset: 0x22535B1 VA: 0x22534B0
	public int get_WeaponExpend() { }

	[CompilerGeneratedAttribute] // RVA: 0x2B0D00 Offset: 0x2B0E01 VA: 0x2B0D00
	// RVA: 0x22534C0 Offset: 0x22535C1 VA: 0x22534C0
	public void set_WeaponExpend(int value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2B0D10 Offset: 0x2B0E11 VA: 0x2B0D10
	// RVA: 0x22534D0 Offset: 0x22535D1 VA: 0x22534D0
	public int get_ExpendCount() { }

	[CompilerGeneratedAttribute] // RVA: 0x2B0D20 Offset: 0x2B0E21 VA: 0x2B0D20
	// RVA: 0x22534E0 Offset: 0x22535E1 VA: 0x22534E0
	public void set_ExpendCount(int value) { }

	// RVA: 0x224D8C0 Offset: 0x224D9C1 VA: 0x224D8C0
	public void PushDetail() { }

	// RVA: 0x224D9F0 Offset: 0x224DAF1 VA: 0x224D9F0
	public void PopDetail() { }

	// RVA: 0x22534F0 Offset: 0x22535F1 VA: 0x22534F0
	public int GetEngageCountLimit() { }

	// RVA: 0x22535B0 Offset: 0x22536B1 VA: 0x22535B0
	public Vector3 GetCenterPosition() { }

	// RVA: 0x2255710 Offset: 0x2255811 VA: 0x2255710
	public Vector3 GetEffectPosition() { }

	// RVA: 0x2256340 Offset: 0x2256441 VA: 0x2256340
	public bool TryFocus() { }

	// RVA: 0x2256410 Offset: 0x2256511 VA: 0x2256410
	public void Focus() { }

	// RVA: 0x22564E0 Offset: 0x22565E1 VA: 0x22564E0
	private int ClampHP(int value) { }

	// RVA: 0x2256530 Offset: 0x2256631 VA: 0x2256530
	public int CommitHp() { }

	// RVA: 0x22565B0 Offset: 0x22566B1 VA: 0x22565B0
	public int CommitHp(int damage, int heal) { }

	// RVA: 0x2246280 Offset: 0x2246381 VA: 0x2246280
	public void Clear() { }

	// RVA: 0x2256630 Offset: 0x2256731 VA: 0x2256630
	private bool IsChangeDragonImpl() { }

	// RVA: 0x224DD20 Offset: 0x224DE21 VA: 0x224DD20
	public void ComplementConditions(int range) { }

	// RVA: 0x224F4A0 Offset: 0x224F5A1 VA: 0x224F4A0
	public void ComplementDragon() { }

	// RVA: 0x224F6F0 Offset: 0x224F7F1 VA: 0x224F6F0
	public void CalcSupport() { }

	// RVA: 0x224F530 Offset: 0x224F631 VA: 0x224F530
	public void CalcCapability() { }

	// RVA: 0x224F7B0 Offset: 0x224F8B1 VA: 0x224F7B0
	public void CalcDetail() { }

	// RVA: 0x224F6A0 Offset: 0x224F7A1 VA: 0x224F6A0
	public void CalcInterferenceRod() { }

	// RVA: 0x22567F0 Offset: 0x22568F1 VA: 0x22567F0
	private int CalcBattleTimesImpl(BattleInfo.FlagField flag) { }

	// RVA: 0x224F7C0 Offset: 0x224F8C1 VA: 0x224F7C0
	public void CalcBattleTimes(BattleInfo.FlagField flag) { }

	// RVA: 0x2256B70 Offset: 0x2256C71 VA: 0x2256B70
	public int GetAttack() { }

	// RVA: 0x2256CD0 Offset: 0x2256DD1 VA: 0x2256CD0
	public int GetDefense() { }

	// RVA: 0x2256E30 Offset: 0x2256F31 VA: 0x2256E30
	public int GetHit() { }

	// RVA: 0x2256F90 Offset: 0x2257091 VA: 0x2256F90
	public int GetCritical() { }

	// RVA: 0x22570F0 Offset: 0x22571F1 VA: 0x22570F0
	public int GetAvoid() { }

	// RVA: 0x2257250 Offset: 0x2257351 VA: 0x2257250
	public int GetSecure() { }

	// RVA: 0x22573B0 Offset: 0x22574B1 VA: 0x22573B0
	public int GetContinuous() { }

	// RVA: 0x2257510 Offset: 0x2257611 VA: 0x2257510
	public int GetSimplePower(bool isCritical = False) { }

	// RVA: 0x2257680 Offset: 0x2257781 VA: 0x2257680
	public int GetSimpleHit() { }

	// RVA: 0x22577E0 Offset: 0x22578E1 VA: 0x22577E0
	public int GetSimpleCritical() { }

	// RVA: 0x2257940 Offset: 0x2257A41 VA: 0x2257940
	public int GetBlowRatio() { }

	// RVA: 0x2257980 Offset: 0x2257A81 VA: 0x2257980
	public int GetBlowDistance() { }

	// RVA: 0x22579C0 Offset: 0x2257AC1 VA: 0x22579C0
	public int GetBattleTimes() { }

	// RVA: 0x22579D0 Offset: 0x2257AD1 VA: 0x22579D0
	public int GetActionCount() { }

	// RVA: 0x2257A10 Offset: 0x2257B11 VA: 0x2257A10
	public int GetAttackCount() { }

	// RVA: 0x2257A50 Offset: 0x2257B51 VA: 0x2257A50
	public int GetTotalAttackCount() { }

	// RVA: 0x2257AB0 Offset: 0x2257BB1 VA: 0x2257AB0
	public bool CanBreakable() { }

	// RVA: 0x2257D40 Offset: 0x2257E41 VA: 0x2257D40
	public bool CanSkyBattle() { }

	// RVA: 0x2257E40 Offset: 0x2257F41 VA: 0x2257E40
	public bool CanRevive() { }

	// RVA: 0x2246960 Offset: 0x2246A61 VA: 0x2246960
	public void SetUnit(Unit unit) { }

	// RVA: 0x2257E70 Offset: 0x2257F71 VA: 0x2257E70
	public void SetUnit(Unit unit, int x, int z) { }

	// RVA: 0x2258200 Offset: 0x2258301 VA: 0x2258200
	public void SetUnit(BattleInfoSide src) { }

	// RVA: 0x2258250 Offset: 0x2258351 VA: 0x2258250
	public void SetUnitItem(int itemIndex) { }

	// RVA: 0x2248400 Offset: 0x2248501 VA: 0x2248400
	public void SetUnitItem(UnitItem unitItem) { }

	// RVA: 0x2258350 Offset: 0x2258451 VA: 0x2258350
	public void SetUnitItem(string iid) { }

	// RVA: 0x2257EC0 Offset: 0x2257FC1 VA: 0x2257EC0
	public void SetUnitSkill(Unit unit) { }

	// RVA: 0x22583C0 Offset: 0x22584C1 VA: 0x22583C0
	public void SetSpecifiedItem(UnitItem unitItem) { }

	// RVA: 0x2248620 Offset: 0x2248721 VA: 0x2248620
	public void SetTerrain(int x, int z) { }

	// RVA: 0x2259080 Offset: 0x2259181 VA: 0x2259080
	public BattleInfoSide.BitFieldStatus GetStatus() { }

	// RVA: 0x2259090 Offset: 0x2259191 VA: 0x2259090
	public Unit get_Unit() { }

	// RVA: 0x22448B0 Offset: 0x22449B1 VA: 0x22448B0
	public Force.Type get_ForceType() { }

	// RVA: 0x22590A0 Offset: 0x22591A1 VA: 0x22590A0
	public int get_BmapSize() { }

	// RVA: 0x2242C80 Offset: 0x2242D81 VA: 0x2242C80
	public UnitItem get_UnitItem() { }

	// RVA: 0x22590C0 Offset: 0x22591C1 VA: 0x22590C0
	public UnitActor get_Actor() { }

	// RVA: 0x22590E0 Offset: 0x22591E1 VA: 0x22590E0
	public BattleDestory get_Destroy() { }

	// RVA: 0x22590F0 Offset: 0x22591F1 VA: 0x22590F0
	public GodUnit get_GodUnit() { }

	// RVA: 0x2259120 Offset: 0x2259221 VA: 0x2259120
	public int get_X() { }

	// RVA: 0x2259130 Offset: 0x2259231 VA: 0x2259130
	public void set_X(int value) { }

	// RVA: 0x2259140 Offset: 0x2259241 VA: 0x2259140
	public int get_Z() { }

	// RVA: 0x2259150 Offset: 0x2259251 VA: 0x2259150
	public void set_Z(int value) { }

	// RVA: 0x2259160 Offset: 0x2259261 VA: 0x2259160
	public TerrainData get_Terrain() { }

	// RVA: 0x2259170 Offset: 0x2259271 VA: 0x2259170
	public TerrainData get_Overlap() { }

	// RVA: 0x2259180 Offset: 0x2259281 VA: 0x2259180
	public BattleDetail get_Detail() { }

	// RVA: 0x2259190 Offset: 0x2259291 VA: 0x2259190
	public SupportCalculator get_Support() { }

	// RVA: 0x22591A0 Offset: 0x22592A1 VA: 0x22591A0
	public int get_NowHp() { }

	// RVA: 0x2252D10 Offset: 0x2252E11 VA: 0x2252D10
	public int get_MaxHp() { }

	// RVA: 0x22591F0 Offset: 0x22592F1 VA: 0x22591F0
	public UnitItem GetActualUnitItem() { }

	// RVA: 0x22592C0 Offset: 0x22593C1 VA: 0x22592C0
	public int GetMaxHeal() { }

	// RVA: 0x22592F0 Offset: 0x22593F1 VA: 0x22592F0
	public float GetFloat(string name) { }

	// RVA: 0x22593B0 Offset: 0x22594B1 VA: 0x22593B0
	public float GetFloat(CalculatorCommand command) { }

	// RVA: 0x22593E0 Offset: 0x22594E1 VA: 0x22593E0
	public int GetInt(string name) { }

	// RVA: 0x22594B0 Offset: 0x22595B1 VA: 0x22594B0
	public int GetInt(CalculatorCommand command) { }

	// RVA: 0x2259510 Offset: 0x2259611 VA: 0x2259510
	public Unit GetParticipationUnit() { }

	// RVA: 0x22595E0 Offset: 0x22596E1 VA: 0x22595E0
	public bool IsStandingDie() { }

	// RVA: 0x2259800 Offset: 0x2259901 VA: 0x2259800
	public bool IsImmortal() { }

	// RVA: 0x2259930 Offset: 0x2259A31 VA: 0x2259930
	public bool IsLastBoss() { }

	// RVA: 0x2257DE0 Offset: 0x2257EE1 VA: 0x2257DE0
	public bool IsChangeDragon() { }

	// RVA: 0x22599A0 Offset: 0x2259AA1 VA: 0x22599A0
	public void CalcActiveSkill(SkillData.Timings timing, SkillData.Actions action = 0) { }

	// RVA: 0x225A1D0 Offset: 0x225A2D1 VA: 0x225A1D0
	public bool IsIgnoreSkill(SkillData skill) { }

	// RVA: 0x225A530 Offset: 0x225A631 VA: 0x225A530
	private bool IsIgnoreSkillImpl(SkillData skill) { }

	// RVA: 0x225A890 Offset: 0x225A991 VA: 0x225A890
	public bool IsEnableSkill(SkillData skill, SkillData.Actions action = 0) { }

	// RVA: 0x2259C00 Offset: 0x2259D01 VA: 0x2259C00
	public bool CalcActiveSkill(SkillData skill, SkillData.Actions action) { }

	// RVA: 0x225AE00 Offset: 0x225AF01 VA: 0x225AE00
	public static BattleSide.Type op_Implicit(BattleInfoSide side) { }

	// RVA: 0x225AE10 Offset: 0x225AF11 VA: 0x225AE10
	public static Unit op_Implicit(BattleInfoSide side) { }

	// RVA: 0x225AE20 Offset: 0x225AF21 VA: 0x225AE20
	public static BattleDestory op_Implicit(BattleInfoSide side) { }

	// RVA: 0x225AE30 Offset: 0x225AF31 VA: 0x225AE30
	private static void .cctor() { }
}

