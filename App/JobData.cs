// Namespace: App
[DebuggerDisplayAttribute] // RVA: 0x276290 Offset: 0x276391 VA: 0x276290
public class JobData : StructData<JobData> // TypeDefIndex: 9969
{
	// Fields
	public const int MaxHighJob = 2;
	public static readonly string JidMaleSuffix; // 0x0
	public static readonly string JidFemaleSuffix; // 0x8
	[CompilerGeneratedAttribute] // RVA: 0x28BD70 Offset: 0x28BE71 VA: 0x28BD70
	private string <Jid>k__BackingField; // 0x20
	[CompilerGeneratedAttribute] // RVA: 0x28BD80 Offset: 0x28BE81 VA: 0x28BD80
	private string <Name>k__BackingField; // 0x28
	[CompilerGeneratedAttribute] // RVA: 0x28BD90 Offset: 0x28BE91 VA: 0x28BD90
	private string <Aid>k__BackingField; // 0x30
	[CompilerGeneratedAttribute] // RVA: 0x28BDA0 Offset: 0x28BEA1 VA: 0x28BDA0
	private string <Help>k__BackingField; // 0x38
	[CompilerGeneratedAttribute] // RVA: 0x28BDB0 Offset: 0x28BEB1 VA: 0x28BDB0
	private string <UnitIconID_M>k__BackingField; // 0x40
	[CompilerGeneratedAttribute] // RVA: 0x28BDC0 Offset: 0x28BEC1 VA: 0x28BDC0
	private string <UnitIconID_F>k__BackingField; // 0x48
	[CompilerGeneratedAttribute] // RVA: 0x28BDD0 Offset: 0x28BED1 VA: 0x28BDD0
	private string <UnitIconWeaponID>k__BackingField; // 0x50
	[CompilerGeneratedAttribute] // RVA: 0x28BDE0 Offset: 0x28BEE1 VA: 0x28BDE0
	private sbyte <Rank>k__BackingField; // 0x58
	[CompilerGeneratedAttribute] // RVA: 0x28BDF0 Offset: 0x28BEF1 VA: 0x28BDF0
	private string <StyleName>k__BackingField; // 0x60
	[CompilerGeneratedAttribute] // RVA: 0x28BE00 Offset: 0x28BF01 VA: 0x28BE00
	private JobData.MoveTypes <MoveType>k__BackingField; // 0x68
	[CompilerGeneratedAttribute] // RVA: 0x28BE10 Offset: 0x28BF11 VA: 0x28BE10
	private int <StepFrame>k__BackingField; // 0x6C
	[CompilerGeneratedAttribute] // RVA: 0x28BE20 Offset: 0x28BF21 VA: 0x28BE20
	private byte <MaxLevel>k__BackingField; // 0x70
	[CompilerGeneratedAttribute] // RVA: 0x28BE30 Offset: 0x28BF31 VA: 0x28BE30
	private sbyte <InternalLevel>k__BackingField; // 0x71
	[CompilerGeneratedAttribute] // RVA: 0x28BE40 Offset: 0x28BF41 VA: 0x28BE40
	private ushort <Sort>k__BackingField; // 0x72
	[CompilerGeneratedAttribute] // RVA: 0x28BE50 Offset: 0x28BF51 VA: 0x28BE50
	private JobData.FlagField <Flag>k__BackingField; // 0x78
	[CompilerGeneratedAttribute] // RVA: 0x28BE60 Offset: 0x28BF61 VA: 0x28BE60
	private string[] <CCItems>k__BackingField; // 0x80
	[CompilerGeneratedAttribute] // RVA: 0x28BE70 Offset: 0x28BF71 VA: 0x28BE70
	private string[] <UniqueItems>k__BackingField; // 0x88
	[CompilerGeneratedAttribute] // RVA: 0x28BE80 Offset: 0x28BF81 VA: 0x28BE80
	private BattleStyle.Types <Style>k__BackingField; // 0x90
	public sbyte[] Weapons; // 0x98
	public string[] MaxWeaponLevels; // 0xA0
	public WeaponLevel.Kind[] WeaponLevels; // 0xA8
	public WeaponMask WeaponLevelPlusMask; // 0xB0
	public string[] HighJobs; // 0xB8
	[CompilerGeneratedAttribute] // RVA: 0x28BE90 Offset: 0x28BF91 VA: 0x28BE90
	private string <LowJob>k__BackingField; // 0xC0
	[CompilerGeneratedAttribute] // RVA: 0x28BEA0 Offset: 0x28BFA1 VA: 0x28BEA0
	private Capability <Base>k__BackingField; // 0xC8
	[CompilerGeneratedAttribute] // RVA: 0x28BEB0 Offset: 0x28BFB1 VA: 0x28BEB0
	private Capability <Limit>k__BackingField; // 0xD0
	[CompilerGeneratedAttribute] // RVA: 0x28BEC0 Offset: 0x28BFC1 VA: 0x28BEC0
	private Capability <BaseGrow>k__BackingField; // 0xD8
	[CompilerGeneratedAttribute] // RVA: 0x28BED0 Offset: 0x28BFD1 VA: 0x28BED0
	private CapabilitySbyte <DiffGrow>k__BackingField; // 0xE0
	[CompilerGeneratedAttribute] // RVA: 0x28BEE0 Offset: 0x28BFE1 VA: 0x28BEE0
	private CapabilitySbyte <DiffGrowNormal>k__BackingField; // 0xE8
	[CompilerGeneratedAttribute] // RVA: 0x28BEF0 Offset: 0x28BFF1 VA: 0x28BEF0
	private CapabilitySbyte <DiffGrowHard>k__BackingField; // 0xF0
	[CompilerGeneratedAttribute] // RVA: 0x28BF00 Offset: 0x28C001 VA: 0x28BF00
	private CapabilitySbyte <DiffGrowLunatic>k__BackingField; // 0xF8
	[CompilerGeneratedAttribute] // RVA: 0x28BF10 Offset: 0x28C011 VA: 0x28BF10
	private string <ShortName>k__BackingField; // 0x100
	[CompilerGeneratedAttribute] // RVA: 0x28BF20 Offset: 0x28C021 VA: 0x28BF20
	private string[] <Skills>k__BackingField; // 0x108
	[CompilerGeneratedAttribute] // RVA: 0x28BF30 Offset: 0x28C031 VA: 0x28BF30
	private string <LearningSkill>k__BackingField; // 0x110
	[CompilerGeneratedAttribute] // RVA: 0x28BF40 Offset: 0x28C041 VA: 0x28BF40
	private string <LunaticSkill>k__BackingField; // 0x118
	[CompilerGeneratedAttribute] // RVA: 0x28BF50 Offset: 0x28C051 VA: 0x28BF50
	private SkillData.Attrs <Attrs>k__BackingField; // 0x120
	[CompilerGeneratedAttribute] // RVA: 0x28BF60 Offset: 0x28C061 VA: 0x28BF60
	private SkillArray <MaskSkill>k__BackingField; // 0x128

	// Properties
	public string Jid { get; set; }
	public string Name { get; set; }
	public string Aid { get; set; }
	public string Help { get; set; }
	public string UnitIconID_M { get; set; }
	public string UnitIconID_F { get; set; }
	public string UnitIconWeaponID { get; set; }
	public sbyte Rank { get; set; }
	public string StyleName { get; set; }
	public JobData.MoveTypes MoveType { get; set; }
	public int StepFrame { get; set; }
	public byte MaxLevel { get; set; }
	public sbyte InternalLevel { get; set; }
	public ushort Sort { get; set; }
	public JobData.FlagField Flag { get; set; }
	public string[] CCItems { get; set; }
	public string[] UniqueItems { get; set; }
	public BattleStyle.Types Style { get; set; }
	public sbyte WeaponNone { get; set; }
	public sbyte WeaponSword { get; set; }
	public sbyte WeaponLance { get; set; }
	public sbyte WeaponAxe { get; set; }
	public sbyte WeaponBow { get; set; }
	public sbyte WeaponDagger { get; set; }
	public sbyte WeaponMagic { get; set; }
	public sbyte WeaponRod { get; set; }
	public sbyte WeaponFist { get; set; }
	public sbyte WeaponSpecial { get; set; }
	public sbyte WeaponTool { get; set; }
	public string MaxWeaponLevelNone { get; set; }
	public string MaxWeaponLevelSword { get; set; }
	public string MaxWeaponLevelLance { get; set; }
	public string MaxWeaponLevelAxe { get; set; }
	public string MaxWeaponLevelBow { get; set; }
	public string MaxWeaponLevelMagic { get; set; }
	public string MaxWeaponLevelRod { get; set; }
	public string MaxWeaponLevelDagger { get; set; }
	public string MaxWeaponLevelFist { get; set; }
	public string MaxWeaponLevelSpecial { get; set; }
	public string HighJob1 { get; set; }
	public string HighJob2 { get; set; }
	public string LowJob { get; set; }
	public Capability Base { get; set; }
	public Capability Limit { get; set; }
	public Capability BaseGrow { get; set; }
	public CapabilitySbyte DiffGrow { get; set; }
	public CapabilitySbyte DiffGrowNormal { get; set; }
	public CapabilitySbyte DiffGrowHard { get; set; }
	public CapabilitySbyte DiffGrowLunatic { get; set; }
	public string ShortName { get; set; }
	public string[] Skills { get; set; }
	public string LearningSkill { get; set; }
	public string LunaticSkill { get; set; }
	public SkillData.Attrs Attrs { get; set; }
	public SkillArray MaskSkill { get; set; }

	// Methods

	// RVA: 0x245F290 Offset: 0x245F391 VA: 0x245F290
	public static string GetMoveTypeName(JobData.MoveTypes type) { }

	// RVA: 0x245F330 Offset: 0x245F431 VA: 0x245F330
	public static void Load() { }

	// RVA: 0x245F3E0 Offset: 0x245F4E1 VA: 0x245F3E0
	public void .ctor() { }

	[CompilerGeneratedAttribute] // RVA: 0x2B9920 Offset: 0x2B9A21 VA: 0x2B9920
	// RVA: 0x245F6E0 Offset: 0x245F7E1 VA: 0x245F6E0
	public string get_Jid() { }

	[CompilerGeneratedAttribute] // RVA: 0x2B9930 Offset: 0x2B9A31 VA: 0x2B9930
	// RVA: 0x245F6F0 Offset: 0x245F7F1 VA: 0x245F6F0
	private void set_Jid(string value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2B9940 Offset: 0x2B9A41 VA: 0x2B9940
	// RVA: 0x245F700 Offset: 0x245F801 VA: 0x245F700
	public string get_Name() { }

	[CompilerGeneratedAttribute] // RVA: 0x2B9950 Offset: 0x2B9A51 VA: 0x2B9950
	// RVA: 0x245F710 Offset: 0x245F811 VA: 0x245F710
	private void set_Name(string value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2B9960 Offset: 0x2B9A61 VA: 0x2B9960
	// RVA: 0x245F720 Offset: 0x245F821 VA: 0x245F720
	public string get_Aid() { }

	[CompilerGeneratedAttribute] // RVA: 0x2B9970 Offset: 0x2B9A71 VA: 0x2B9970
	// RVA: 0x245F730 Offset: 0x245F831 VA: 0x245F730
	private void set_Aid(string value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2B9980 Offset: 0x2B9A81 VA: 0x2B9980
	// RVA: 0x245F740 Offset: 0x245F841 VA: 0x245F740
	public string get_Help() { }

	[CompilerGeneratedAttribute] // RVA: 0x2B9990 Offset: 0x2B9A91 VA: 0x2B9990
	// RVA: 0x245F750 Offset: 0x245F851 VA: 0x245F750
	private void set_Help(string value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2B99A0 Offset: 0x2B9AA1 VA: 0x2B99A0
	// RVA: 0x245F760 Offset: 0x245F861 VA: 0x245F760
	public string get_UnitIconID_M() { }

	[CompilerGeneratedAttribute] // RVA: 0x2B99B0 Offset: 0x2B9AB1 VA: 0x2B99B0
	// RVA: 0x245F770 Offset: 0x245F871 VA: 0x245F770
	private void set_UnitIconID_M(string value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2B99C0 Offset: 0x2B9AC1 VA: 0x2B99C0
	// RVA: 0x245F780 Offset: 0x245F881 VA: 0x245F780
	public string get_UnitIconID_F() { }

	[CompilerGeneratedAttribute] // RVA: 0x2B99D0 Offset: 0x2B9AD1 VA: 0x2B99D0
	// RVA: 0x245F790 Offset: 0x245F891 VA: 0x245F790
	private void set_UnitIconID_F(string value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2B99E0 Offset: 0x2B9AE1 VA: 0x2B99E0
	// RVA: 0x245F7A0 Offset: 0x245F8A1 VA: 0x245F7A0
	public string get_UnitIconWeaponID() { }

	[CompilerGeneratedAttribute] // RVA: 0x2B99F0 Offset: 0x2B9AF1 VA: 0x2B99F0
	// RVA: 0x245F7B0 Offset: 0x245F8B1 VA: 0x245F7B0
	private void set_UnitIconWeaponID(string value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2B9A00 Offset: 0x2B9B01 VA: 0x2B9A00
	// RVA: 0x245F7C0 Offset: 0x245F8C1 VA: 0x245F7C0
	public sbyte get_Rank() { }

	[CompilerGeneratedAttribute] // RVA: 0x2B9A10 Offset: 0x2B9B11 VA: 0x2B9A10
	// RVA: 0x245F7D0 Offset: 0x245F8D1 VA: 0x245F7D0
	private void set_Rank(sbyte value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2B9A20 Offset: 0x2B9B21 VA: 0x2B9A20
	// RVA: 0x245F7E0 Offset: 0x245F8E1 VA: 0x245F7E0
	public string get_StyleName() { }

	[CompilerGeneratedAttribute] // RVA: 0x2B9A30 Offset: 0x2B9B31 VA: 0x2B9A30
	// RVA: 0x245F7F0 Offset: 0x245F8F1 VA: 0x245F7F0
	private void set_StyleName(string value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2B9A40 Offset: 0x2B9B41 VA: 0x2B9A40
	// RVA: 0x245F800 Offset: 0x245F901 VA: 0x245F800
	public JobData.MoveTypes get_MoveType() { }

	[CompilerGeneratedAttribute] // RVA: 0x2B9A50 Offset: 0x2B9B51 VA: 0x2B9A50
	// RVA: 0x245F810 Offset: 0x245F911 VA: 0x245F810
	private void set_MoveType(JobData.MoveTypes value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2B9A60 Offset: 0x2B9B61 VA: 0x2B9A60
	// RVA: 0x245F820 Offset: 0x245F921 VA: 0x245F820
	public int get_StepFrame() { }

	[CompilerGeneratedAttribute] // RVA: 0x2B9A70 Offset: 0x2B9B71 VA: 0x2B9A70
	// RVA: 0x245F830 Offset: 0x245F931 VA: 0x245F830
	private void set_StepFrame(int value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2B9A80 Offset: 0x2B9B81 VA: 0x2B9A80
	// RVA: 0x245F840 Offset: 0x245F941 VA: 0x245F840
	public byte get_MaxLevel() { }

	[CompilerGeneratedAttribute] // RVA: 0x2B9A90 Offset: 0x2B9B91 VA: 0x2B9A90
	// RVA: 0x245F850 Offset: 0x245F951 VA: 0x245F850
	private void set_MaxLevel(byte value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2B9AA0 Offset: 0x2B9BA1 VA: 0x2B9AA0
	// RVA: 0x245F860 Offset: 0x245F961 VA: 0x245F860
	public sbyte get_InternalLevel() { }

	[CompilerGeneratedAttribute] // RVA: 0x2B9AB0 Offset: 0x2B9BB1 VA: 0x2B9AB0
	// RVA: 0x245F870 Offset: 0x245F971 VA: 0x245F870
	private void set_InternalLevel(sbyte value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2B9AC0 Offset: 0x2B9BC1 VA: 0x2B9AC0
	// RVA: 0x245F880 Offset: 0x245F981 VA: 0x245F880
	public ushort get_Sort() { }

	[CompilerGeneratedAttribute] // RVA: 0x2B9AD0 Offset: 0x2B9BD1 VA: 0x2B9AD0
	// RVA: 0x245F890 Offset: 0x245F991 VA: 0x245F890
	private void set_Sort(ushort value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2B9AE0 Offset: 0x2B9BE1 VA: 0x2B9AE0
	// RVA: 0x245F8A0 Offset: 0x245F9A1 VA: 0x245F8A0
	public JobData.FlagField get_Flag() { }

	[CompilerGeneratedAttribute] // RVA: 0x2B9AF0 Offset: 0x2B9BF1 VA: 0x2B9AF0
	// RVA: 0x245F8B0 Offset: 0x245F9B1 VA: 0x245F8B0
	private void set_Flag(JobData.FlagField value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2B9B00 Offset: 0x2B9C01 VA: 0x2B9B00
	// RVA: 0x245F8C0 Offset: 0x245F9C1 VA: 0x245F8C0
	public string[] get_CCItems() { }

	[CompilerGeneratedAttribute] // RVA: 0x2B9B10 Offset: 0x2B9C11 VA: 0x2B9B10
	// RVA: 0x245F8D0 Offset: 0x245F9D1 VA: 0x245F8D0
	private void set_CCItems(string[] value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2B9B20 Offset: 0x2B9C21 VA: 0x2B9B20
	// RVA: 0x245F8E0 Offset: 0x245F9E1 VA: 0x245F8E0
	public string[] get_UniqueItems() { }

	[CompilerGeneratedAttribute] // RVA: 0x2B9B30 Offset: 0x2B9C31 VA: 0x2B9B30
	// RVA: 0x245F8F0 Offset: 0x245F9F1 VA: 0x245F8F0
	private void set_UniqueItems(string[] value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2B9B40 Offset: 0x2B9C41 VA: 0x2B9B40
	// RVA: 0x245F900 Offset: 0x245FA01 VA: 0x245F900
	public BattleStyle.Types get_Style() { }

	[CompilerGeneratedAttribute] // RVA: 0x2B9B50 Offset: 0x2B9C51 VA: 0x2B9B50
	// RVA: 0x245F910 Offset: 0x245FA11 VA: 0x245F910
	private void set_Style(BattleStyle.Types value) { }

	// RVA: 0x245F920 Offset: 0x245FA21 VA: 0x245F920
	public sbyte get_WeaponNone() { }

	// RVA: 0x245F950 Offset: 0x245FA51 VA: 0x245F950
	private void set_WeaponNone(sbyte value) { }

	// RVA: 0x245F980 Offset: 0x245FA81 VA: 0x245F980
	public sbyte get_WeaponSword() { }

	// RVA: 0x245F9B0 Offset: 0x245FAB1 VA: 0x245F9B0
	private void set_WeaponSword(sbyte value) { }

	// RVA: 0x245F9E0 Offset: 0x245FAE1 VA: 0x245F9E0
	public sbyte get_WeaponLance() { }

	// RVA: 0x245FA10 Offset: 0x245FB11 VA: 0x245FA10
	private void set_WeaponLance(sbyte value) { }

	// RVA: 0x245FA40 Offset: 0x245FB41 VA: 0x245FA40
	public sbyte get_WeaponAxe() { }

	// RVA: 0x245FA70 Offset: 0x245FB71 VA: 0x245FA70
	private void set_WeaponAxe(sbyte value) { }

	// RVA: 0x245FAA0 Offset: 0x245FBA1 VA: 0x245FAA0
	public sbyte get_WeaponBow() { }

	// RVA: 0x245FAD0 Offset: 0x245FBD1 VA: 0x245FAD0
	private void set_WeaponBow(sbyte value) { }

	// RVA: 0x245FB00 Offset: 0x245FC01 VA: 0x245FB00
	public sbyte get_WeaponDagger() { }

	// RVA: 0x245FB30 Offset: 0x245FC31 VA: 0x245FB30
	private void set_WeaponDagger(sbyte value) { }

	// RVA: 0x245FB60 Offset: 0x245FC61 VA: 0x245FB60
	public sbyte get_WeaponMagic() { }

	// RVA: 0x245FB90 Offset: 0x245FC91 VA: 0x245FB90
	private void set_WeaponMagic(sbyte value) { }

	// RVA: 0x245FBC0 Offset: 0x245FCC1 VA: 0x245FBC0
	public sbyte get_WeaponRod() { }

	// RVA: 0x245FBF0 Offset: 0x245FCF1 VA: 0x245FBF0
	private void set_WeaponRod(sbyte value) { }

	// RVA: 0x245FC20 Offset: 0x245FD21 VA: 0x245FC20
	public sbyte get_WeaponFist() { }

	// RVA: 0x245FC50 Offset: 0x245FD51 VA: 0x245FC50
	private void set_WeaponFist(sbyte value) { }

	// RVA: 0x245FC80 Offset: 0x245FD81 VA: 0x245FC80
	public sbyte get_WeaponSpecial() { }

	// RVA: 0x245FCB0 Offset: 0x245FDB1 VA: 0x245FCB0
	private void set_WeaponSpecial(sbyte value) { }

	// RVA: 0x245FCE0 Offset: 0x245FDE1 VA: 0x245FCE0
	public sbyte get_WeaponTool() { }

	// RVA: 0x245FCF0 Offset: 0x245FDF1 VA: 0x245FCF0
	private void set_WeaponTool(sbyte value) { }

	// RVA: 0x245FD00 Offset: 0x245FE01 VA: 0x245FD00
	public string get_MaxWeaponLevelNone() { }

	// RVA: 0x245FD30 Offset: 0x245FE31 VA: 0x245FD30
	private void set_MaxWeaponLevelNone(string value) { }

	// RVA: 0x245FDA0 Offset: 0x245FEA1 VA: 0x245FDA0
	public string get_MaxWeaponLevelSword() { }

	// RVA: 0x245FDD0 Offset: 0x245FED1 VA: 0x245FDD0
	private void set_MaxWeaponLevelSword(string value) { }

	// RVA: 0x245FE40 Offset: 0x245FF41 VA: 0x245FE40
	public string get_MaxWeaponLevelLance() { }

	// RVA: 0x245FE70 Offset: 0x245FF71 VA: 0x245FE70
	private void set_MaxWeaponLevelLance(string value) { }

	// RVA: 0x245FEE0 Offset: 0x245FFE1 VA: 0x245FEE0
	public string get_MaxWeaponLevelAxe() { }

	// RVA: 0x245FF10 Offset: 0x2460011 VA: 0x245FF10
	private void set_MaxWeaponLevelAxe(string value) { }

	// RVA: 0x245FF80 Offset: 0x2460081 VA: 0x245FF80
	public string get_MaxWeaponLevelBow() { }

	// RVA: 0x245FFB0 Offset: 0x24600B1 VA: 0x245FFB0
	private void set_MaxWeaponLevelBow(string value) { }

	// RVA: 0x2460020 Offset: 0x2460121 VA: 0x2460020
	public string get_MaxWeaponLevelMagic() { }

	// RVA: 0x2460050 Offset: 0x2460151 VA: 0x2460050
	private void set_MaxWeaponLevelMagic(string value) { }

	// RVA: 0x24600C0 Offset: 0x24601C1 VA: 0x24600C0
	public string get_MaxWeaponLevelRod() { }

	// RVA: 0x24600F0 Offset: 0x24601F1 VA: 0x24600F0
	private void set_MaxWeaponLevelRod(string value) { }

	// RVA: 0x2460160 Offset: 0x2460261 VA: 0x2460160
	public string get_MaxWeaponLevelDagger() { }

	// RVA: 0x2460190 Offset: 0x2460291 VA: 0x2460190
	private void set_MaxWeaponLevelDagger(string value) { }

	// RVA: 0x2460200 Offset: 0x2460301 VA: 0x2460200
	public string get_MaxWeaponLevelFist() { }

	// RVA: 0x2460230 Offset: 0x2460331 VA: 0x2460230
	private void set_MaxWeaponLevelFist(string value) { }

	// RVA: 0x24602A0 Offset: 0x24603A1 VA: 0x24602A0
	public string get_MaxWeaponLevelSpecial() { }

	// RVA: 0x24602D0 Offset: 0x24603D1 VA: 0x24602D0
	private void set_MaxWeaponLevelSpecial(string value) { }

	// RVA: 0x2460340 Offset: 0x2460441 VA: 0x2460340
	public string get_HighJob1() { }

	// RVA: 0x2460370 Offset: 0x2460471 VA: 0x2460370
	private void set_HighJob1(string value) { }

	// RVA: 0x24603E0 Offset: 0x24604E1 VA: 0x24603E0
	public string get_HighJob2() { }

	// RVA: 0x2460410 Offset: 0x2460511 VA: 0x2460410
	private void set_HighJob2(string value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2B9B60 Offset: 0x2B9C61 VA: 0x2B9B60
	// RVA: 0x2460480 Offset: 0x2460581 VA: 0x2460480
	public string get_LowJob() { }

	[CompilerGeneratedAttribute] // RVA: 0x2B9B70 Offset: 0x2B9C71 VA: 0x2B9B70
	// RVA: 0x2460490 Offset: 0x2460591 VA: 0x2460490
	private void set_LowJob(string value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2B9B80 Offset: 0x2B9C81 VA: 0x2B9B80
	// RVA: 0x24604A0 Offset: 0x24605A1 VA: 0x24604A0
	public Capability get_Base() { }

	[CompilerGeneratedAttribute] // RVA: 0x2B9B90 Offset: 0x2B9C91 VA: 0x2B9B90
	// RVA: 0x24604B0 Offset: 0x24605B1 VA: 0x24604B0
	private void set_Base(Capability value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2B9BA0 Offset: 0x2B9CA1 VA: 0x2B9BA0
	// RVA: 0x24604C0 Offset: 0x24605C1 VA: 0x24604C0
	public Capability get_Limit() { }

	[CompilerGeneratedAttribute] // RVA: 0x2B9BB0 Offset: 0x2B9CB1 VA: 0x2B9BB0
	// RVA: 0x24604D0 Offset: 0x24605D1 VA: 0x24604D0
	private void set_Limit(Capability value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2B9BC0 Offset: 0x2B9CC1 VA: 0x2B9BC0
	// RVA: 0x24604E0 Offset: 0x24605E1 VA: 0x24604E0
	public Capability get_BaseGrow() { }

	[CompilerGeneratedAttribute] // RVA: 0x2B9BD0 Offset: 0x2B9CD1 VA: 0x2B9BD0
	// RVA: 0x24604F0 Offset: 0x24605F1 VA: 0x24604F0
	private void set_BaseGrow(Capability value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2B9BE0 Offset: 0x2B9CE1 VA: 0x2B9BE0
	// RVA: 0x2460500 Offset: 0x2460601 VA: 0x2460500
	public CapabilitySbyte get_DiffGrow() { }

	[CompilerGeneratedAttribute] // RVA: 0x2B9BF0 Offset: 0x2B9CF1 VA: 0x2B9BF0
	// RVA: 0x2460510 Offset: 0x2460611 VA: 0x2460510
	private void set_DiffGrow(CapabilitySbyte value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2B9C00 Offset: 0x2B9D01 VA: 0x2B9C00
	// RVA: 0x2460520 Offset: 0x2460621 VA: 0x2460520
	public CapabilitySbyte get_DiffGrowNormal() { }

	[CompilerGeneratedAttribute] // RVA: 0x2B9C10 Offset: 0x2B9D11 VA: 0x2B9C10
	// RVA: 0x2460530 Offset: 0x2460631 VA: 0x2460530
	private void set_DiffGrowNormal(CapabilitySbyte value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2B9C20 Offset: 0x2B9D21 VA: 0x2B9C20
	// RVA: 0x2460540 Offset: 0x2460641 VA: 0x2460540
	public CapabilitySbyte get_DiffGrowHard() { }

	[CompilerGeneratedAttribute] // RVA: 0x2B9C30 Offset: 0x2B9D31 VA: 0x2B9C30
	// RVA: 0x2460550 Offset: 0x2460651 VA: 0x2460550
	private void set_DiffGrowHard(CapabilitySbyte value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2B9C40 Offset: 0x2B9D41 VA: 0x2B9C40
	// RVA: 0x2460560 Offset: 0x2460661 VA: 0x2460560
	public CapabilitySbyte get_DiffGrowLunatic() { }

	[CompilerGeneratedAttribute] // RVA: 0x2B9C50 Offset: 0x2B9D51 VA: 0x2B9C50
	// RVA: 0x2460570 Offset: 0x2460671 VA: 0x2460570
	private void set_DiffGrowLunatic(CapabilitySbyte value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2B9C60 Offset: 0x2B9D61 VA: 0x2B9C60
	// RVA: 0x2460580 Offset: 0x2460681 VA: 0x2460580
	public string get_ShortName() { }

	[CompilerGeneratedAttribute] // RVA: 0x2B9C70 Offset: 0x2B9D71 VA: 0x2B9C70
	// RVA: 0x2460590 Offset: 0x2460691 VA: 0x2460590
	private void set_ShortName(string value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2B9C80 Offset: 0x2B9D81 VA: 0x2B9C80
	// RVA: 0x24605A0 Offset: 0x24606A1 VA: 0x24605A0
	public string[] get_Skills() { }

	[CompilerGeneratedAttribute] // RVA: 0x2B9C90 Offset: 0x2B9D91 VA: 0x2B9C90
	// RVA: 0x24605B0 Offset: 0x24606B1 VA: 0x24605B0
	private void set_Skills(string[] value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2B9CA0 Offset: 0x2B9DA1 VA: 0x2B9CA0
	// RVA: 0x24605C0 Offset: 0x24606C1 VA: 0x24605C0
	public string get_LearningSkill() { }

	[CompilerGeneratedAttribute] // RVA: 0x2B9CB0 Offset: 0x2B9DB1 VA: 0x2B9CB0
	// RVA: 0x24605D0 Offset: 0x24606D1 VA: 0x24605D0
	private void set_LearningSkill(string value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2B9CC0 Offset: 0x2B9DC1 VA: 0x2B9CC0
	// RVA: 0x24605E0 Offset: 0x24606E1 VA: 0x24605E0
	public string get_LunaticSkill() { }

	[CompilerGeneratedAttribute] // RVA: 0x2B9CD0 Offset: 0x2B9DD1 VA: 0x2B9CD0
	// RVA: 0x24605F0 Offset: 0x24606F1 VA: 0x24605F0
	private void set_LunaticSkill(string value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2B9CE0 Offset: 0x2B9DE1 VA: 0x2B9CE0
	// RVA: 0x2460600 Offset: 0x2460701 VA: 0x2460600
	public SkillData.Attrs get_Attrs() { }

	[CompilerGeneratedAttribute] // RVA: 0x2B9CF0 Offset: 0x2B9DF1 VA: 0x2B9CF0
	// RVA: 0x2460610 Offset: 0x2460711 VA: 0x2460610
	private void set_Attrs(SkillData.Attrs value) { }

	// RVA: 0x2460620 Offset: 0x2460721 VA: 0x2460620 Slot: 4
	public override void OnBuild() { }

	// RVA: 0x2460740 Offset: 0x2460841 VA: 0x2460740 Slot: 5
	public override void OnCompleted() { }

	// RVA: 0x2461520 Offset: 0x2461621 VA: 0x2461520
	public string GetPrefixlessJid() { }

	// RVA: 0x2461530 Offset: 0x2461631 VA: 0x2461530
	public string GetName() { }

	// RVA: 0x24616B0 Offset: 0x24617B1 VA: 0x24616B0
	public string GetUnitIconID(bool isFemale) { }

	// RVA: 0x24616D0 Offset: 0x24617D1 VA: 0x24616D0
	public bool IsHigh() { }

	// RVA: 0x24616E0 Offset: 0x24617E1 VA: 0x24616E0
	public bool IsLow() { }

	// RVA: 0x24616F0 Offset: 0x24617F1 VA: 0x24616F0
	public bool IsFly() { }

	// RVA: 0x2461700 Offset: 0x2461801 VA: 0x2461700
	public bool IsRider() { }

	// RVA: 0x2461720 Offset: 0x2461821 VA: 0x2461720
	public bool IsDownload() { }

	// RVA: 0x24615E0 Offset: 0x24616E1 VA: 0x24615E0
	public bool IsUnknown() { }

	// RVA: 0x2461730 Offset: 0x2461831 VA: 0x2461730
	public bool HasHighJobs() { }

	// RVA: 0x2461830 Offset: 0x2461931 VA: 0x2461830
	public List<JobData> GetHighJobs() { }

	// RVA: 0x24619A0 Offset: 0x2461AA1 VA: 0x24619A0
	public List<JobData> GetLowJobs() { }

	// RVA: 0x2461C00 Offset: 0x2461D01 VA: 0x2461C00
	public bool IsEnchant() { }

	// RVA: 0x2461C10 Offset: 0x2461D11 VA: 0x2461C10
	public bool IsGunner() { }

	// RVA: 0x2461C20 Offset: 0x2461D21 VA: 0x2461C20
	public WeaponMask GetWeaponMask(WeaponMask mask, WeaponMask selected) { }

	// RVA: 0x2461D00 Offset: 0x2461E01 VA: 0x2461D00
	public WeaponMask GetWeaponMask() { }

	// RVA: 0x2461E10 Offset: 0x2461F11 VA: 0x2461E10
	public WeaponMask GetSelectableWeaponMask(out int requiredSelectCount) { }

	// RVA: 0x2461F30 Offset: 0x2462031 VA: 0x2461F30
	public ItemData.Kinds[] GetEquipableWeaponKinds() { }

	// RVA: 0x2462150 Offset: 0x2462251 VA: 0x2462150
	public ItemData.Kinds[] GetMaxLevelWeapons(WeaponMask weaponMask, WeaponMask originalAptitude) { }

	// RVA: 0x24623E0 Offset: 0x24624E1 VA: 0x24623E0
	public bool IsEquipable(ItemData.Kinds kind) { }

	// RVA: 0x2462510 Offset: 0x2462611 VA: 0x2462510
	public WeaponLevel.Kind GetMaxWeaponLevel(int index) { }

	// RVA: 0x2462550 Offset: 0x2462651 VA: 0x2462550
	public WeaponLevel.Kind GetMaxWeaponLevel(int index, WeaponMask originalAptitude) { }

	// RVA: 0x24625B0 Offset: 0x24626B1 VA: 0x24625B0
	public WeaponMask GetLevelPlusWeaponMask() { }

	// RVA: 0x24625C0 Offset: 0x24626C1 VA: 0x24625C0
	public int GetLearnJobSkillLevel() { }

	// RVA: 0x24625E0 Offset: 0x24626E1 VA: 0x24625E0
	public static void Serialize(Stream stream, JobData job) { }

	// RVA: 0x2462640 Offset: 0x2462741 VA: 0x2462640
	public static JobData Deserialize(Stream stream) { }

	// RVA: 0x24626A0 Offset: 0x24627A1 VA: 0x24626A0
	public static void TrySerialize(Stream stream, JobData job) { }

	// RVA: 0x2462770 Offset: 0x2462871 VA: 0x2462770
	public static JobData TryDeserialize(Stream stream) { }

	// RVA: 0x2462890 Offset: 0x2462991 VA: 0x2462890 Slot: 8
	public override string GetDebugName() { }

	[CompilerGeneratedAttribute] // RVA: 0x2B9D00 Offset: 0x2B9E01 VA: 0x2B9D00
	// RVA: 0x2462990 Offset: 0x2462A91 VA: 0x2462990
	public SkillArray get_MaskSkill() { }

	[CompilerGeneratedAttribute] // RVA: 0x2B9D10 Offset: 0x2B9E11 VA: 0x2B9D10
	// RVA: 0x24629A0 Offset: 0x2462AA1 VA: 0x24629A0
	private void set_MaskSkill(SkillArray value) { }

	[ConditionalAttribute] // RVA: 0x2B9D20 Offset: 0x2B9E21 VA: 0x2B9D20
	// RVA: 0x24629B0 Offset: 0x2462AB1 VA: 0x24629B0
	private void DbgVerify() { }

	// RVA: 0x2462AE0 Offset: 0x2462BE1 VA: 0x2462AE0
	private static void .cctor() { }

	[CompilerGeneratedAttribute] // RVA: 0x2B9D60 Offset: 0x2B9E61 VA: 0x2B9D60
	// RVA: 0x2462B80 Offset: 0x2462C81 VA: 0x2462B80
	private bool <GetLowJobs>b__222_0(string highJid) { }

	[CompilerGeneratedAttribute] // RVA: 0x2B9D70 Offset: 0x2B9E71 VA: 0x2B9D70
	// RVA: 0x24622E0 Offset: 0x24623E1 VA: 0x24622E0
	private void <GetMaxLevelWeapons>g__Check|229_0(ItemData.Kinds itemData, ref JobData.<>c__DisplayClass229_0 ) { }
}

