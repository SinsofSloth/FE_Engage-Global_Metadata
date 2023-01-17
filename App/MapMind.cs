// Namespace: App
public class MapMind : SingletonClass<MapMind> // TypeDefIndex: 12197
{
	// Fields
	public const int RouteMax = 64;
	private byte m_UnitIndex; // 0x19
	private byte m_FirstUnitIndex; // 0x1A
	private sbyte m_FirstX; // 0x1B
	private sbyte m_FirstZ; // 0x1C
	private sbyte m_UnitShowX; // 0x1D
	private sbyte m_UnitShowZ; // 0x1E
	private sbyte m_X; // 0x1F
	private sbyte m_Z; // 0x20
	private MapMind.Type m_Mind; // 0x24
	private sbyte m_AttackX; // 0x28
	private sbyte m_AttackZ; // 0x29
	private sbyte m_ItemIndex; // 0x2A
	private byte m_TargetUnitIndex; // 0x2B
	private sbyte m_TargetX; // 0x2C
	private sbyte m_TargetZ; // 0x2D
	private sbyte m_FocusX; // 0x2E
	private sbyte m_FocusZ; // 0x2F
	private short m_TargetArgument; // 0x30
	private byte m_TradeUnitIndex; // 0x32
	private byte m_EventUnitIndex; // 0x33
	private MapMind.DoneField m_Done; // 0x38
	private byte m_MovePower; // 0x40
	private short m_TransporterIndex; // 0x42
	private SkillData m_CommandSkill; // 0x48
	private ItemData m_SpecifiedItem; // 0x50
	private sbyte m_AIEngageRewarpX; // 0x58
	private sbyte m_AIEngageRewarpZ; // 0x59
	private Dir.Type[] m_Routes; // 0x60
	[CompilerGeneratedAttribute] // RVA: 0x299C50 Offset: 0x299D51 VA: 0x299C50
	private readonly MapMind.MultiTargets <Targets>k__BackingField; // 0x68
	[CompilerGeneratedAttribute] // RVA: 0x299C60 Offset: 0x299D61 VA: 0x299C60
	private readonly MapMind.CommandStack <Stack>k__BackingField; // 0x70

	// Properties
	public Unit Unit { get; }
	public Unit TargetUnit { get; }
	public Unit TradeUnit { get; }
	public int UnitIndex { get; }
	public int FirstUnitIndex { get; }
	public int FirstX { get; }
	public int FirstZ { get; }
	public int UnitX { get; set; }
	public int UnitZ { get; set; }
	public int X { get; set; }
	public int Z { get; set; }
	public MapMind.Type Mind { get; set; }
	public int AttackX { get; set; }
	public int AttackZ { get; set; }
	public int ItemIndex { get; set; }
	public int TargetUnitIndex { get; set; }
	public int TargetX { get; set; }
	public int TargetZ { get; set; }
	public int FocusX { get; set; }
	public int FocusZ { get; set; }
	public int TargetArgument { get; set; }
	public int TradeUnitIndex { get; set; }
	public int MovePower { get; set; }
	public Dir.Type[] Routes { get; set; }
	public int TransporterIndex { get; set; }
	public int EventUnitIndex { get; set; }
	public SkillData CommandSkill { get; set; }
	public ItemData SpecifiedItem { get; set; }
	public int AIEngageRewarpX { get; set; }
	public int AIEngageRewarpZ { get; set; }
	public PersonData.Colors SummonColor { get; set; }
	public MapMind.MultiTargets MultiTarget { get; }
	public MapMind.MultiTargets Targets { get; }
	public MapMind.CommandStack Stack { get; }

	// Methods

	// RVA: 0x220D8C0 Offset: 0x220D9C1 VA: 0x220D8C0
	public void .ctor() { }

	// RVA: 0x220DA60 Offset: 0x220DB61 VA: 0x220DA60
	public void Reset(Unit unit, bool forRemove = False) { }

	// RVA: 0x220DF50 Offset: 0x220E051 VA: 0x220DF50
	public void ResetMind() { }

	// RVA: 0x220E060 Offset: 0x220E161 VA: 0x220E060
	public void ResetTarget() { }

	// RVA: 0x220E000 Offset: 0x220E101 VA: 0x220E000
	public void ResetRoute() { }

	// RVA: 0x220E0F0 Offset: 0x220E1F1 VA: 0x220E0F0
	public bool IsMoved() { }

	// RVA: 0x220E170 Offset: 0x220E271 VA: 0x220E170
	public bool IsDone() { }

	// RVA: 0x220E190 Offset: 0x220E291 VA: 0x220E190
	public bool IsDone(MapMind.Done mask) { }

	// RVA: 0x220E200 Offset: 0x220E301 VA: 0x220E200
	public void SetDone(MapMind.Done mask) { }

	// RVA: 0x220E280 Offset: 0x220E381 VA: 0x220E280
	public bool IsAIEngageRewarp() { }

	// RVA: 0x22078B0 Offset: 0x22079B1 VA: 0x22078B0
	public Unit get_Unit() { }

	// RVA: 0x220E2B0 Offset: 0x220E3B1 VA: 0x220E2B0
	public Unit get_TargetUnit() { }

	// RVA: 0x2207FE0 Offset: 0x22080E1 VA: 0x2207FE0
	public Unit get_TradeUnit() { }

	// RVA: 0x220E2C0 Offset: 0x220E3C1 VA: 0x220E2C0
	public int get_UnitIndex() { }

	// RVA: 0x220E2D0 Offset: 0x220E3D1 VA: 0x220E2D0
	public int get_FirstUnitIndex() { }

	// RVA: 0x220E2E0 Offset: 0x220E3E1 VA: 0x220E2E0
	public int get_FirstX() { }

	// RVA: 0x220E2F0 Offset: 0x220E3F1 VA: 0x220E2F0
	public int get_FirstZ() { }

	// RVA: 0x220E300 Offset: 0x220E401 VA: 0x220E300
	public int get_UnitX() { }

	// RVA: 0x220E310 Offset: 0x220E411 VA: 0x220E310
	public void set_UnitX(int value) { }

	// RVA: 0x220E320 Offset: 0x220E421 VA: 0x220E320
	public int get_UnitZ() { }

	// RVA: 0x220E330 Offset: 0x220E431 VA: 0x220E330
	public void set_UnitZ(int value) { }

	// RVA: 0x220E340 Offset: 0x220E441 VA: 0x220E340
	public void SetUnitPos(int x, int z) { }

	// RVA: 0x220E350 Offset: 0x220E451 VA: 0x220E350
	public int get_X() { }

	// RVA: 0x220E360 Offset: 0x220E461 VA: 0x220E360
	public void set_X(int value) { }

	// RVA: 0x220E370 Offset: 0x220E471 VA: 0x220E370
	public int get_Z() { }

	// RVA: 0x220E380 Offset: 0x220E481 VA: 0x220E380
	public void set_Z(int value) { }

	// RVA: 0x220E390 Offset: 0x220E491 VA: 0x220E390
	public MapMind.Type get_Mind() { }

	// RVA: 0x220E3A0 Offset: 0x220E4A1 VA: 0x220E3A0
	public void set_Mind(MapMind.Type value) { }

	// RVA: 0x220E3B0 Offset: 0x220E4B1 VA: 0x220E3B0
	public int get_AttackX() { }

	// RVA: 0x220E3D0 Offset: 0x220E4D1 VA: 0x220E3D0
	public void set_AttackX(int value) { }

	// RVA: 0x220E3E0 Offset: 0x220E4E1 VA: 0x220E3E0
	public int get_AttackZ() { }

	// RVA: 0x220E400 Offset: 0x220E501 VA: 0x220E400
	public void set_AttackZ(int value) { }

	// RVA: 0x220E410 Offset: 0x220E511 VA: 0x220E410
	public int get_ItemIndex() { }

	// RVA: 0x220E420 Offset: 0x220E521 VA: 0x220E420
	public void set_ItemIndex(int value) { }

	// RVA: 0x220E430 Offset: 0x220E531 VA: 0x220E430
	public int get_TargetUnitIndex() { }

	// RVA: 0x220E440 Offset: 0x220E541 VA: 0x220E440
	public void set_TargetUnitIndex(int value) { }

	// RVA: 0x220E450 Offset: 0x220E551 VA: 0x220E450
	public int get_TargetX() { }

	// RVA: 0x220E460 Offset: 0x220E561 VA: 0x220E460
	public void set_TargetX(int value) { }

	// RVA: 0x220E470 Offset: 0x220E571 VA: 0x220E470
	public int get_TargetZ() { }

	// RVA: 0x220E480 Offset: 0x220E581 VA: 0x220E480
	public void set_TargetZ(int value) { }

	// RVA: 0x220E490 Offset: 0x220E591 VA: 0x220E490
	public int get_FocusX() { }

	// RVA: 0x220E4A0 Offset: 0x220E5A1 VA: 0x220E4A0
	public void set_FocusX(int value) { }

	// RVA: 0x220E4B0 Offset: 0x220E5B1 VA: 0x220E4B0
	public int get_FocusZ() { }

	// RVA: 0x220E4C0 Offset: 0x220E5C1 VA: 0x220E4C0
	public void set_FocusZ(int value) { }

	// RVA: 0x220E4D0 Offset: 0x220E5D1 VA: 0x220E4D0
	public int get_TargetArgument() { }

	// RVA: 0x220E4E0 Offset: 0x220E5E1 VA: 0x220E4E0
	public void set_TargetArgument(int value) { }

	// RVA: 0x220E4F0 Offset: 0x220E5F1 VA: 0x220E4F0
	public int get_TradeUnitIndex() { }

	// RVA: 0x220E500 Offset: 0x220E601 VA: 0x220E500
	public void set_TradeUnitIndex(int value) { }

	// RVA: 0x220E510 Offset: 0x220E611 VA: 0x220E510
	public int get_MovePower() { }

	// RVA: 0x220E520 Offset: 0x220E621 VA: 0x220E520
	public void set_MovePower(int value) { }

	// RVA: 0x220E530 Offset: 0x220E631 VA: 0x220E530
	public Dir.Type[] get_Routes() { }

	// RVA: 0x220E540 Offset: 0x220E641 VA: 0x220E540
	public void set_Routes(Dir.Type[] value) { }

	// RVA: 0x220E5B0 Offset: 0x220E6B1 VA: 0x220E5B0
	public int get_TransporterIndex() { }

	// RVA: 0x220E5C0 Offset: 0x220E6C1 VA: 0x220E5C0
	public void set_TransporterIndex(int value) { }

	// RVA: 0x220E5D0 Offset: 0x220E6D1 VA: 0x220E5D0
	public int get_EventUnitIndex() { }

	// RVA: 0x220E5E0 Offset: 0x220E6E1 VA: 0x220E5E0
	public void set_EventUnitIndex(int value) { }

	// RVA: 0x220E5F0 Offset: 0x220E6F1 VA: 0x220E5F0
	public SkillData get_CommandSkill() { }

	// RVA: 0x220E600 Offset: 0x220E701 VA: 0x220E600
	public void set_CommandSkill(SkillData value) { }

	// RVA: 0x220E610 Offset: 0x220E711 VA: 0x220E610
	public ItemData get_SpecifiedItem() { }

	// RVA: 0x220E620 Offset: 0x220E721 VA: 0x220E620
	public void set_SpecifiedItem(ItemData value) { }

	// RVA: 0x220E630 Offset: 0x220E731 VA: 0x220E630
	public int get_AIEngageRewarpX() { }

	// RVA: 0x220E640 Offset: 0x220E741 VA: 0x220E640
	public void set_AIEngageRewarpX(int value) { }

	// RVA: 0x220E650 Offset: 0x220E751 VA: 0x220E650
	public int get_AIEngageRewarpZ() { }

	// RVA: 0x220E660 Offset: 0x220E761 VA: 0x220E660
	public void set_AIEngageRewarpZ(int value) { }

	// RVA: 0x220E670 Offset: 0x220E771 VA: 0x220E670
	public PersonData.Colors get_SummonColor() { }

	// RVA: 0x220E680 Offset: 0x220E781 VA: 0x220E680
	public void set_SummonColor(PersonData.Colors value) { }

	// RVA: 0x220E690 Offset: 0x220E791 VA: 0x220E690
	public MapMind.MultiTargets get_MultiTarget() { }

	[CompilerGeneratedAttribute] // RVA: 0x2C7F60 Offset: 0x2C8061 VA: 0x2C7F60
	// RVA: 0x220E6A0 Offset: 0x220E7A1 VA: 0x220E6A0
	public MapMind.MultiTargets get_Targets() { }

	[CompilerGeneratedAttribute] // RVA: 0x2C7F70 Offset: 0x2C8071 VA: 0x2C7F70
	// RVA: 0x220E6B0 Offset: 0x220E7B1 VA: 0x220E6B0
	public MapMind.CommandStack get_Stack() { }

	// RVA: 0x220E6C0 Offset: 0x220E7C1 VA: 0x220E6C0
	public Unit GetTargetUnit(int index) { }

	// RVA: 0x220E760 Offset: 0x220E861 VA: 0x220E760
	public int GetTargetX(int index) { }

	// RVA: 0x220E7F0 Offset: 0x220E8F1 VA: 0x220E7F0
	public int GetTargetZ(int index) { }

	// RVA: 0x220E880 Offset: 0x220E981 VA: 0x220E880
	public int GetTargetLastX() { }

	// RVA: 0x220E900 Offset: 0x220EA01 VA: 0x220E900
	public int GetTargetLastZ() { }

	// RVA: 0x220E980 Offset: 0x220EA81 VA: 0x220E980
	public PokeInspector GetDestroyTarget() { }

	// RVA: 0x220EA20 Offset: 0x220EB21 VA: 0x220EA20
	public ItemData GetItem() { }

	// RVA: 0x220ECA0 Offset: 0x220EDA1 VA: 0x220ECA0
	public UnitItem GetUnitItem() { }

	// RVA: 0x220EAA0 Offset: 0x220EBA1 VA: 0x220EAA0
	public UnitItem GetUnitItem(int index) { }

	// RVA: 0x220ECB0 Offset: 0x220EDB1 VA: 0x220ECB0
	public bool CanGodChange() { }

	// RVA: 0x220ED10 Offset: 0x220EE11 VA: 0x220ED10
	public bool IsFocus() { }

	// RVA: 0x220ED40 Offset: 0x220EE41 VA: 0x220ED40
	public MapMind.Type GetMind() { }

	// RVA: 0x22077B0 Offset: 0x22078B1 VA: 0x22077B0
	public static MapMind.Type GetMind(MapMind.Type mind, SkillData skill) { }
}

