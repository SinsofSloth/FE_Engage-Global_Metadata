// Namespace: Combat
[DebuggerDisplayAttribute] // RVA: 0x273DB0 Offset: 0x273EB1 VA: 0x273DB0
public sealed class CharacterGameStatus // TypeDefIndex: 8606
{
	// Fields
	public CharacterAppearance Appearance; // 0x10
	[CompilerGeneratedAttribute] // RVA: 0x2824E0 Offset: 0x2825E1 VA: 0x2824E0
	private string <EmblemIdentifier>k__BackingField; // 0x18
	private int m_Side; // 0x20
	private bool m_bStun; // 0x24
	[CompilerGeneratedAttribute] // RVA: 0x2824F0 Offset: 0x2825F1 VA: 0x2824F0
	private Unit <Unit>k__BackingField; // 0x28
	[CompilerGeneratedAttribute] // RVA: 0x282500 Offset: 0x282601 VA: 0x282500
	private PersonData <Person>k__BackingField; // 0x30
	[CompilerGeneratedAttribute] // RVA: 0x282510 Offset: 0x282611 VA: 0x282510
	private JobData <Job>k__BackingField; // 0x38
	[CompilerGeneratedAttribute] // RVA: 0x282520 Offset: 0x282621 VA: 0x282520
	private Force <Force>k__BackingField; // 0x40
	[CompilerGeneratedAttribute] // RVA: 0x282530 Offset: 0x282631 VA: 0x282530
	private string <Name>k__BackingField; // 0x48
	[CompilerGeneratedAttribute] // RVA: 0x282540 Offset: 0x282641 VA: 0x282540
	private int <MaxHP>k__BackingField; // 0x50
	[CompilerGeneratedAttribute] // RVA: 0x282550 Offset: 0x282651 VA: 0x282550
	private int <HP>k__BackingField; // 0x54
	[CompilerGeneratedAttribute] // RVA: 0x282560 Offset: 0x282661 VA: 0x282560
	private int <MaxStun>k__BackingField; // 0x58
	[CompilerGeneratedAttribute] // RVA: 0x282570 Offset: 0x282671 VA: 0x282570
	private int <StunValue>k__BackingField; // 0x5C
	[CompilerGeneratedAttribute] // RVA: 0x282580 Offset: 0x282681 VA: 0x282580
	private int <EngageCount>k__BackingField; // 0x60
	[CompilerGeneratedAttribute] // RVA: 0x282590 Offset: 0x282691 VA: 0x282590
	private int <MapX>k__BackingField; // 0x64
	[CompilerGeneratedAttribute] // RVA: 0x2825A0 Offset: 0x2826A1 VA: 0x2825A0
	private int <MapY>k__BackingField; // 0x68
	[CompilerGeneratedAttribute] // RVA: 0x2825B0 Offset: 0x2826B1 VA: 0x2825B0
	private int <BattleX>k__BackingField; // 0x6C
	[CompilerGeneratedAttribute] // RVA: 0x2825C0 Offset: 0x2826C1 VA: 0x2825C0
	private int <BattleY>k__BackingField; // 0x70
	[CompilerGeneratedAttribute] // RVA: 0x2825D0 Offset: 0x2826D1 VA: 0x2825D0
	private UnitItem <Weapon>k__BackingField; // 0x78
	[CompilerGeneratedAttribute] // RVA: 0x2825E0 Offset: 0x2826E1 VA: 0x2825E0
	private EngageStyle <EngageStyle>k__BackingField; // 0x80
	[CompilerGeneratedAttribute] // RVA: 0x2825F0 Offset: 0x2826F1 VA: 0x2825F0
	private int <StarRushComboCount789>k__BackingField; // 0x84
	[CompilerGeneratedAttribute] // RVA: 0x282600 Offset: 0x282701 VA: 0x282600
	private float <後キャン発動位置>k__BackingField; // 0x88
	[CompilerGeneratedAttribute] // RVA: 0x282610 Offset: 0x282711 VA: 0x282610
	private float <ブレイク時後キャン発動位置>k__BackingField; // 0x8C
	[CompilerGeneratedAttribute] // RVA: 0x282620 Offset: 0x282721 VA: 0x282620
	private float <重い動作速度>k__BackingField; // 0x90
	[CompilerGeneratedAttribute] // RVA: 0x282630 Offset: 0x282731 VA: 0x282630
	private float <素早い動作速度>k__BackingField; // 0x94
	[CompilerGeneratedAttribute] // RVA: 0x282640 Offset: 0x282741 VA: 0x282640
	private FXZ <WorldPos>k__BackingField; // 0x98

	// Properties
	private string DebuggerDisplay { get; }
	public bool IsEmpty { get; }
	public string EmblemIdentifier { get; set; }
	public Unit Unit { get; set; }
	public PersonData Person { get; set; }
	public JobData Job { get; set; }
	public Force Force { get; set; }
	public string Name { get; set; }
	public int MaxHP { get; set; }
	public int HP { get; set; }
	public int MaxStun { get; set; }
	public int StunValue { get; set; }
	public bool IsStun { get; }
	public int EngageCount { get; set; }
	public int MapX { get; set; }
	public int MapY { get; set; }
	public int BattleX { get; set; }
	public int BattleY { get; set; }
	public UnitItem Weapon { get; set; }
	public WeaponStyle WeaponStyle { get; }
	public EngageStyle EngageStyle { get; set; }
	public bool IsEngaging { get; }
	public bool IsGrandew { get; }
	public bool IsDying { get; }
	public bool IsDead { get; }
	public bool IsHPMax { get; }
	public int StarRushComboCount789 { get; set; }
	public float 後キャン発動位置 { get; set; }
	public float ブレイク時後キャン発動位置 { get; set; }
	public float 重い動作速度 { get; set; }
	public float 素早い動作速度 { get; set; }
	public FXZ WorldPos { get; set; }
	public ItemData.UseTypes RodUseType { get; }

	// Methods

	// RVA: 0x2B743C0 Offset: 0x2B744C1 VA: 0x2B743C0
	private string get_DebuggerDisplay() { }

	// RVA: 0x2B74920 Offset: 0x2B74A21 VA: 0x2B74920
	public static bool op_Implicit(CharacterGameStatus a) { }

	// RVA: 0x2B74930 Offset: 0x2B74A31 VA: 0x2B74930
	public bool get_IsEmpty() { }

	[CompilerGeneratedAttribute] // RVA: 0x2AA940 Offset: 0x2AAA41 VA: 0x2AA940
	// RVA: 0x2B74980 Offset: 0x2B74A81 VA: 0x2B74980
	public string get_EmblemIdentifier() { }

	[CompilerGeneratedAttribute] // RVA: 0x2AA950 Offset: 0x2AAA51 VA: 0x2AA950
	// RVA: 0x2B74990 Offset: 0x2B74A91 VA: 0x2B74990
	private void set_EmblemIdentifier(string value) { }

	// RVA: 0x2B749A0 Offset: 0x2B74AA1 VA: 0x2B749A0
	public void Stun() { }

	[CompilerGeneratedAttribute] // RVA: 0x2AA960 Offset: 0x2AAA61 VA: 0x2AA960
	// RVA: 0x2B749B0 Offset: 0x2B74AB1 VA: 0x2B749B0
	public Unit get_Unit() { }

	[CompilerGeneratedAttribute] // RVA: 0x2AA970 Offset: 0x2AAA71 VA: 0x2AA970
	// RVA: 0x2B749C0 Offset: 0x2B74AC1 VA: 0x2B749C0
	private void set_Unit(Unit value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2AA980 Offset: 0x2AAA81 VA: 0x2AA980
	// RVA: 0x2B749D0 Offset: 0x2B74AD1 VA: 0x2B749D0
	public PersonData get_Person() { }

	[CompilerGeneratedAttribute] // RVA: 0x2AA990 Offset: 0x2AAA91 VA: 0x2AA990
	// RVA: 0x2B749E0 Offset: 0x2B74AE1 VA: 0x2B749E0
	private void set_Person(PersonData value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2AA9A0 Offset: 0x2AAAA1 VA: 0x2AA9A0
	// RVA: 0x2B749F0 Offset: 0x2B74AF1 VA: 0x2B749F0
	public JobData get_Job() { }

	[CompilerGeneratedAttribute] // RVA: 0x2AA9B0 Offset: 0x2AAAB1 VA: 0x2AA9B0
	// RVA: 0x2B74A00 Offset: 0x2B74B01 VA: 0x2B74A00
	private void set_Job(JobData value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2AA9C0 Offset: 0x2AAAC1 VA: 0x2AA9C0
	// RVA: 0x2B74A10 Offset: 0x2B74B11 VA: 0x2B74A10
	public Force get_Force() { }

	[CompilerGeneratedAttribute] // RVA: 0x2AA9D0 Offset: 0x2AAAD1 VA: 0x2AA9D0
	// RVA: 0x2B74A20 Offset: 0x2B74B21 VA: 0x2B74A20
	private void set_Force(Force value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2AA9E0 Offset: 0x2AAAE1 VA: 0x2AA9E0
	// RVA: 0x2B74A30 Offset: 0x2B74B31 VA: 0x2B74A30
	public string get_Name() { }

	[CompilerGeneratedAttribute] // RVA: 0x2AA9F0 Offset: 0x2AAAF1 VA: 0x2AA9F0
	// RVA: 0x2B74A40 Offset: 0x2B74B41 VA: 0x2B74A40
	private void set_Name(string value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2AAA00 Offset: 0x2AAB01 VA: 0x2AAA00
	// RVA: 0x2B74A50 Offset: 0x2B74B51 VA: 0x2B74A50
	public int get_MaxHP() { }

	[CompilerGeneratedAttribute] // RVA: 0x2AAA10 Offset: 0x2AAB11 VA: 0x2AAA10
	// RVA: 0x2B74A60 Offset: 0x2B74B61 VA: 0x2B74A60
	private void set_MaxHP(int value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2AAA20 Offset: 0x2AAB21 VA: 0x2AAA20
	// RVA: 0x2B74A70 Offset: 0x2B74B71 VA: 0x2B74A70
	public int get_HP() { }

	[CompilerGeneratedAttribute] // RVA: 0x2AAA30 Offset: 0x2AAB31 VA: 0x2AAA30
	// RVA: 0x2B74A80 Offset: 0x2B74B81 VA: 0x2B74A80
	private void set_HP(int value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2AAA40 Offset: 0x2AAB41 VA: 0x2AAA40
	// RVA: 0x2B74A90 Offset: 0x2B74B91 VA: 0x2B74A90
	public int get_MaxStun() { }

	[CompilerGeneratedAttribute] // RVA: 0x2AAA50 Offset: 0x2AAB51 VA: 0x2AAA50
	// RVA: 0x2B74AA0 Offset: 0x2B74BA1 VA: 0x2B74AA0
	private void set_MaxStun(int value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2AAA60 Offset: 0x2AAB61 VA: 0x2AAA60
	// RVA: 0x2B74AB0 Offset: 0x2B74BB1 VA: 0x2B74AB0
	public int get_StunValue() { }

	[CompilerGeneratedAttribute] // RVA: 0x2AAA70 Offset: 0x2AAB71 VA: 0x2AAA70
	// RVA: 0x2B74AC0 Offset: 0x2B74BC1 VA: 0x2B74AC0
	private void set_StunValue(int value) { }

	// RVA: 0x2B74AD0 Offset: 0x2B74BD1 VA: 0x2B74AD0
	public bool get_IsStun() { }

	[CompilerGeneratedAttribute] // RVA: 0x2AAA80 Offset: 0x2AAB81 VA: 0x2AAA80
	// RVA: 0x2B74AE0 Offset: 0x2B74BE1 VA: 0x2B74AE0
	public int get_EngageCount() { }

	[CompilerGeneratedAttribute] // RVA: 0x2AAA90 Offset: 0x2AAB91 VA: 0x2AAA90
	// RVA: 0x2B74AF0 Offset: 0x2B74BF1 VA: 0x2B74AF0
	private void set_EngageCount(int value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2AAAA0 Offset: 0x2AABA1 VA: 0x2AAAA0
	// RVA: 0x2B74B00 Offset: 0x2B74C01 VA: 0x2B74B00
	public int get_MapX() { }

	[CompilerGeneratedAttribute] // RVA: 0x2AAAB0 Offset: 0x2AABB1 VA: 0x2AAAB0
	// RVA: 0x2B74B10 Offset: 0x2B74C11 VA: 0x2B74B10
	private void set_MapX(int value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2AAAC0 Offset: 0x2AABC1 VA: 0x2AAAC0
	// RVA: 0x2B74B20 Offset: 0x2B74C21 VA: 0x2B74B20
	public int get_MapY() { }

	[CompilerGeneratedAttribute] // RVA: 0x2AAAD0 Offset: 0x2AABD1 VA: 0x2AAAD0
	// RVA: 0x2B74B30 Offset: 0x2B74C31 VA: 0x2B74B30
	private void set_MapY(int value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2AAAE0 Offset: 0x2AABE1 VA: 0x2AAAE0
	// RVA: 0x2B74B40 Offset: 0x2B74C41 VA: 0x2B74B40
	public int get_BattleX() { }

	[CompilerGeneratedAttribute] // RVA: 0x2AAAF0 Offset: 0x2AABF1 VA: 0x2AAAF0
	// RVA: 0x2B74B50 Offset: 0x2B74C51 VA: 0x2B74B50
	private void set_BattleX(int value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2AAB00 Offset: 0x2AAC01 VA: 0x2AAB00
	// RVA: 0x2B74B60 Offset: 0x2B74C61 VA: 0x2B74B60
	public int get_BattleY() { }

	[CompilerGeneratedAttribute] // RVA: 0x2AAB10 Offset: 0x2AAC11 VA: 0x2AAB10
	// RVA: 0x2B74B70 Offset: 0x2B74C71 VA: 0x2B74B70
	private void set_BattleY(int value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2AAB20 Offset: 0x2AAC21 VA: 0x2AAB20
	// RVA: 0x2B74B80 Offset: 0x2B74C81 VA: 0x2B74B80
	public UnitItem get_Weapon() { }

	[CompilerGeneratedAttribute] // RVA: 0x2AAB30 Offset: 0x2AAC31 VA: 0x2AAB30
	// RVA: 0x2B74B90 Offset: 0x2B74C91 VA: 0x2B74B90
	private void set_Weapon(UnitItem value) { }

	// RVA: 0x2B748F0 Offset: 0x2B749F1 VA: 0x2B748F0
	public WeaponStyle get_WeaponStyle() { }

	[CompilerGeneratedAttribute] // RVA: 0x2AAB40 Offset: 0x2AAC41 VA: 0x2AAB40
	// RVA: 0x2B74BA0 Offset: 0x2B74CA1 VA: 0x2B74BA0
	public EngageStyle get_EngageStyle() { }

	[CompilerGeneratedAttribute] // RVA: 0x2AAB50 Offset: 0x2AAC51 VA: 0x2AAB50
	// RVA: 0x2B74BB0 Offset: 0x2B74CB1 VA: 0x2B74BB0
	private void set_EngageStyle(EngageStyle value) { }

	// RVA: 0x2B74BC0 Offset: 0x2B74CC1 VA: 0x2B74BC0
	public void SetEngageStyleAsEngAttackPairedGrandew() { }

	// RVA: 0x2B74BD0 Offset: 0x2B74CD1 VA: 0x2B74BD0
	public bool get_IsEngaging() { }

	// RVA: 0x2B74910 Offset: 0x2B74A11 VA: 0x2B74910
	public bool get_IsGrandew() { }

	// RVA: 0x2B74BF0 Offset: 0x2B74CF1 VA: 0x2B74BF0
	public bool get_IsDying() { }

	// RVA: 0x2B74C20 Offset: 0x2B74D21 VA: 0x2B74C20
	public bool get_IsDead() { }

	// RVA: 0x2B74C50 Offset: 0x2B74D51 VA: 0x2B74C50
	public bool get_IsHPMax() { }

	[CompilerGeneratedAttribute] // RVA: 0x2AAB60 Offset: 0x2AAC61 VA: 0x2AAB60
	// RVA: 0x2B74C80 Offset: 0x2B74D81 VA: 0x2B74C80
	public int get_StarRushComboCount789() { }

	[CompilerGeneratedAttribute] // RVA: 0x2AAB70 Offset: 0x2AAC71 VA: 0x2AAB70
	// RVA: 0x2B74C90 Offset: 0x2B74D91 VA: 0x2B74C90
	public void set_StarRushComboCount789(int value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2AAB80 Offset: 0x2AAC81 VA: 0x2AAB80
	// RVA: 0x2B74CA0 Offset: 0x2B74DA1 VA: 0x2B74CA0
	public float get_後キャン発動位置() { }

	[CompilerGeneratedAttribute] // RVA: 0x2AAB90 Offset: 0x2AAC91 VA: 0x2AAB90
	// RVA: 0x2B74CB0 Offset: 0x2B74DB1 VA: 0x2B74CB0
	private void set_後キャン発動位置(float value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2AABA0 Offset: 0x2AACA1 VA: 0x2AABA0
	// RVA: 0x2B74CC0 Offset: 0x2B74DC1 VA: 0x2B74CC0
	public float get_ブレイク時後キャン発動位置() { }

	[CompilerGeneratedAttribute] // RVA: 0x2AABB0 Offset: 0x2AACB1 VA: 0x2AABB0
	// RVA: 0x2B74CD0 Offset: 0x2B74DD1 VA: 0x2B74CD0
	private void set_ブレイク時後キャン発動位置(float value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2AABC0 Offset: 0x2AACC1 VA: 0x2AABC0
	// RVA: 0x2B74CE0 Offset: 0x2B74DE1 VA: 0x2B74CE0
	public float get_重い動作速度() { }

	[CompilerGeneratedAttribute] // RVA: 0x2AABD0 Offset: 0x2AACD1 VA: 0x2AABD0
	// RVA: 0x2B74CF0 Offset: 0x2B74DF1 VA: 0x2B74CF0
	private void set_重い動作速度(float value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2AABE0 Offset: 0x2AACE1 VA: 0x2AABE0
	// RVA: 0x2B74D00 Offset: 0x2B74E01 VA: 0x2B74D00
	public float get_素早い動作速度() { }

	[CompilerGeneratedAttribute] // RVA: 0x2AABF0 Offset: 0x2AACF1 VA: 0x2AABF0
	// RVA: 0x2B74D10 Offset: 0x2B74E11 VA: 0x2B74D10
	private void set_素早い動作速度(float value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2AAC00 Offset: 0x2AAD01 VA: 0x2AAC00
	// RVA: 0x2B74D20 Offset: 0x2B74E21 VA: 0x2B74D20
	public FXZ get_WorldPos() { }

	[CompilerGeneratedAttribute] // RVA: 0x2AAC10 Offset: 0x2AAD11 VA: 0x2AAC10
	// RVA: 0x2B74D30 Offset: 0x2B74E31 VA: 0x2B74D30
	public void set_WorldPos(FXZ value) { }

	// RVA: 0x2B74D40 Offset: 0x2B74E41 VA: 0x2B74D40
	public ItemData.UseTypes get_RodUseType() { }

	// RVA: 0x2B74D60 Offset: 0x2B74E61 VA: 0x2B74D60
	public void Clear() { }

	// RVA: 0x2B74DF0 Offset: 0x2B74EF1 VA: 0x2B74DF0
	public void Import(Unit unit, bool isHpMax, string[] conditions) { }

	// RVA: 0x2B74E50 Offset: 0x2B74F51 VA: 0x2B74E50
	public void Import(Unit unit, UnitItem weapon, string[] conditions) { }

	// RVA: 0x2B76000 Offset: 0x2B76101 VA: 0x2B76000
	public void Import(GodUnit god, string[] conditions) { }

	// RVA: 0x2B76290 Offset: 0x2B76391 VA: 0x2B76290
	public void Import(int side_, BattleCalculator calc, BattleSide.Type sideType, int mapDistance) { }

	// RVA: 0x2B77850 Offset: 0x2B77951 VA: 0x2B77850
	internal void Import(int side, string pid, string jid, string iid, int x, int z, string[] conditions) { }

	// RVA: 0x2B77A60 Offset: 0x2B77B61 VA: 0x2B77A60
	public void ImportEmpty() { }

	// RVA: 0x2B76690 Offset: 0x2B76791 VA: 0x2B76690
	private void ImportImpl(UnitItem weapon, int mapDistance = 1, string[] conditions) { }

	// RVA: 0x2B77CD0 Offset: 0x2B77DD1 VA: 0x2B77CD0
	public void UpdatePos() { }

	// RVA: 0x2B75F00 Offset: 0x2B76001 VA: 0x2B75F00
	private EngageStyle CalcEngageStyle() { }

	// RVA: 0x2B78A00 Offset: 0x2B78B01 VA: 0x2B78A00
	public void ImportGrandew(CharacterGameStatus master) { }

	// RVA: 0x2B78D50 Offset: 0x2B78E51 VA: 0x2B78D50
	public void InitForViewer(int side, CharacterAppearance ap, EngageStyle engageStyle = 0) { }

	// RVA: 0x2B78FE0 Offset: 0x2B790E1 VA: 0x2B78FE0
	public void SyncParams(Phase phase) { }

	// RVA: 0x2B79170 Offset: 0x2B79271 VA: 0x2B79170
	public void RemoveWeapons() { }

	// RVA: 0x2B792D0 Offset: 0x2B793D1 VA: 0x2B792D0
	public void .ctor() { }
}

