// Namespace: App
[DebuggerDisplayAttribute] // RVA: 0x276220 Offset: 0x276321 VA: 0x276220
public class ItemData : StructData<ItemData> // TypeDefIndex: 9957
{
	// Fields
	public const int MAX_NAME_LENGTH = 8;
	public const int RANGE_INF = 255;
	public const int ENDURANCE_INF = 255;
	public const int HIT_INF = 255;
	[CompilerGeneratedAttribute] // RVA: 0x28B8C0 Offset: 0x28B9C1 VA: 0x28B8C0
	private string <Iid>k__BackingField; // 0x20
	[CompilerGeneratedAttribute] // RVA: 0x28B8D0 Offset: 0x28B9D1 VA: 0x28B8D0
	private string <Name>k__BackingField; // 0x28
	[CompilerGeneratedAttribute] // RVA: 0x28B8E0 Offset: 0x28B9E1 VA: 0x28B8E0
	private string <Help>k__BackingField; // 0x30
	[CompilerGeneratedAttribute] // RVA: 0x28B8F0 Offset: 0x28B9F1 VA: 0x28B8F0
	private string <Tutorial>k__BackingField; // 0x38
	[CompilerGeneratedAttribute] // RVA: 0x28B900 Offset: 0x28BA01 VA: 0x28B900
	private string <Aid>k__BackingField; // 0x40
	[CompilerGeneratedAttribute] // RVA: 0x28B910 Offset: 0x28BA11 VA: 0x28B910
	private ItemData.Kinds <Kind>k__BackingField; // 0x48
	[CompilerGeneratedAttribute] // RVA: 0x28B920 Offset: 0x28BA21 VA: 0x28B920
	private ItemData.Attrs <Attr>k__BackingField; // 0x4C
	[CompilerGeneratedAttribute] // RVA: 0x28B930 Offset: 0x28BA31 VA: 0x28B930
	private ItemData.UseTypes <UseType>k__BackingField; // 0x50
	[CompilerGeneratedAttribute] // RVA: 0x28B940 Offset: 0x28BA41 VA: 0x28B940
	private ItemData.WeaponAttrs <WeaponAttr>k__BackingField; // 0x54
	[CompilerGeneratedAttribute] // RVA: 0x28B950 Offset: 0x28BA51 VA: 0x28B950
	private string <Icon>k__BackingField; // 0x58
	[CompilerGeneratedAttribute] // RVA: 0x28B960 Offset: 0x28BA61 VA: 0x28B960
	private byte <Endurance>k__BackingField; // 0x60
	[CompilerGeneratedAttribute] // RVA: 0x28B970 Offset: 0x28BA71 VA: 0x28B970
	private byte <Power>k__BackingField; // 0x61
	[CompilerGeneratedAttribute] // RVA: 0x28B980 Offset: 0x28BA81 VA: 0x28B980
	private byte <Weight>k__BackingField; // 0x62
	[CompilerGeneratedAttribute] // RVA: 0x28B990 Offset: 0x28BA91 VA: 0x28B990
	private byte <RangeI>k__BackingField; // 0x63
	[CompilerGeneratedAttribute] // RVA: 0x28B9A0 Offset: 0x28BAA1 VA: 0x28B9A0
	private byte <RangeO>k__BackingField; // 0x64
	[CompilerGeneratedAttribute] // RVA: 0x28B9B0 Offset: 0x28BAB1 VA: 0x28B9B0
	private byte <Distance>k__BackingField; // 0x65
	[CompilerGeneratedAttribute] // RVA: 0x28B9C0 Offset: 0x28BAC1 VA: 0x28B9C0
	private short <Hit>k__BackingField; // 0x66
	[CompilerGeneratedAttribute] // RVA: 0x28B9D0 Offset: 0x28BAD1 VA: 0x28B9D0
	private short <Critical>k__BackingField; // 0x68
	[CompilerGeneratedAttribute] // RVA: 0x28B9E0 Offset: 0x28BAE1 VA: 0x28B9E0
	private short <Avoid>k__BackingField; // 0x6A
	[CompilerGeneratedAttribute] // RVA: 0x28B9F0 Offset: 0x28BAF1 VA: 0x28B9F0
	private short <Secure>k__BackingField; // 0x6C
	[CompilerGeneratedAttribute] // RVA: 0x28BA00 Offset: 0x28BB01 VA: 0x28BA00
	private int <Price>k__BackingField; // 0x70
	[CompilerGeneratedAttribute] // RVA: 0x28BA10 Offset: 0x28BB11 VA: 0x28BA10
	private string <WeaponLevel>k__BackingField; // 0x78
	[CompilerGeneratedAttribute] // RVA: 0x28BA20 Offset: 0x28BB21 VA: 0x28BA20
	private ItemData.RodTypes <RodType>k__BackingField; // 0x80
	[CompilerGeneratedAttribute] // RVA: 0x28BA30 Offset: 0x28BB31 VA: 0x28BA30
	private byte <RodExp>k__BackingField; // 0x84
	[CompilerGeneratedAttribute] // RVA: 0x28BA40 Offset: 0x28BB41 VA: 0x28BA40
	private byte <RateArena>k__BackingField; // 0x85
	[CompilerGeneratedAttribute] // RVA: 0x28BA50 Offset: 0x28BB51 VA: 0x28BA50
	private string <ShootEffect>k__BackingField; // 0x88
	[CompilerGeneratedAttribute] // RVA: 0x28BA60 Offset: 0x28BB61 VA: 0x28BA60
	private string <HitEffect>k__BackingField; // 0x90
	[CompilerGeneratedAttribute] // RVA: 0x28BA70 Offset: 0x28BB71 VA: 0x28BA70
	private string <CannonEffect>k__BackingField; // 0x98
	[CompilerGeneratedAttribute] // RVA: 0x28BA80 Offset: 0x28BB81 VA: 0x28BA80
	private string <OverlapTerrain>k__BackingField; // 0xA0
	[CompilerGeneratedAttribute] // RVA: 0x28BA90 Offset: 0x28BB91 VA: 0x28BA90
	private ItemData.FlagField <Flag>k__BackingField; // 0xA8
	[CompilerGeneratedAttribute] // RVA: 0x28BAA0 Offset: 0x28BBA1 VA: 0x28BAA0
	private CapabilitySbyte <Enhance>k__BackingField; // 0xB0
	[CompilerGeneratedAttribute] // RVA: 0x28BAB0 Offset: 0x28BBB1 VA: 0x28BAB0
	private CapabilitySbyte <GrowRatio>k__BackingField; // 0xB8
	[CompilerGeneratedAttribute] // RVA: 0x28BAC0 Offset: 0x28BBC1 VA: 0x28BAC0
	private string <EquipCondition>k__BackingField; // 0xC0
	[CompilerGeneratedAttribute] // RVA: 0x28BAD0 Offset: 0x28BBD1 VA: 0x28BAD0
	private string[] <EquipSids>k__BackingField; // 0xC8
	[CompilerGeneratedAttribute] // RVA: 0x28BAE0 Offset: 0x28BBE1 VA: 0x28BAE0
	private string[] <PassiveSids>k__BackingField; // 0xD0
	[CompilerGeneratedAttribute] // RVA: 0x28BAF0 Offset: 0x28BBF1 VA: 0x28BAF0
	private string[] <GiveSids>k__BackingField; // 0xD8
	[CompilerGeneratedAttribute] // RVA: 0x28BB00 Offset: 0x28BC01 VA: 0x28BB00
	private ItemData.AddTargets <AddTarget>k__BackingField; // 0xE0
	[CompilerGeneratedAttribute] // RVA: 0x28BB10 Offset: 0x28BC11 VA: 0x28BB10
	private ItemData.UseTypes <AddType>k__BackingField; // 0xE4
	[CompilerGeneratedAttribute] // RVA: 0x28BB20 Offset: 0x28BC21 VA: 0x28BB20
	private byte <AddPower>k__BackingField; // 0xE8
	[CompilerGeneratedAttribute] // RVA: 0x28BB30 Offset: 0x28BC31 VA: 0x28BB30
	private byte <AddRange>k__BackingField; // 0xE9
	[CompilerGeneratedAttribute] // RVA: 0x28BB40 Offset: 0x28BC41 VA: 0x28BB40
	private string[] <AddSids>k__BackingField; // 0xF0
	[CompilerGeneratedAttribute] // RVA: 0x28BB50 Offset: 0x28BC51 VA: 0x28BB50
	private string <AddEffect>k__BackingField; // 0xF8
	[CompilerGeneratedAttribute] // RVA: 0x28BB60 Offset: 0x28BC61 VA: 0x28BB60
	private string <AddHelp>k__BackingField; // 0x100
	[CompilerGeneratedAttribute] // RVA: 0x28BB70 Offset: 0x28BC71 VA: 0x28BB70
	private string <HighRankItem>k__BackingField; // 0x108
	private bool m_IsWeapon; // 0x110
	private string FlagName; // 0x118
	private string m_PrefixlessIid; // 0x120
	private int m_EnchantHash; // 0x128
	private WeaponLevel.Kind m_WeaponLevel; // 0x12C
	private UnitItem m_UnitItem; // 0x130
	[CompilerGeneratedAttribute] // RVA: 0x28BB80 Offset: 0x28BC81 VA: 0x28BB80
	private readonly SkillArray <EquipSkills>k__BackingField; // 0x138
	[CompilerGeneratedAttribute] // RVA: 0x28BB90 Offset: 0x28BC91 VA: 0x28BB90
	private readonly SkillArray <PassiveSkills>k__BackingField; // 0x140
	[CompilerGeneratedAttribute] // RVA: 0x28BBA0 Offset: 0x28BCA1 VA: 0x28BBA0
	private readonly SkillArray <GiveSkills>k__BackingField; // 0x148
	[CompilerGeneratedAttribute] // RVA: 0x28BBB0 Offset: 0x28BCB1 VA: 0x28BBB0
	private readonly SkillArray <EnchantSkills1>k__BackingField; // 0x150
	[CompilerGeneratedAttribute] // RVA: 0x28BBC0 Offset: 0x28BCC1 VA: 0x28BBC0
	private readonly SkillArray <EnchantSkills2>k__BackingField; // 0x158
	[CompilerGeneratedAttribute] // RVA: 0x28BBD0 Offset: 0x28BCD1 VA: 0x28BBD0
	private readonly SkillArray <EnchantSkills3>k__BackingField; // 0x160
	[CompilerGeneratedAttribute] // RVA: 0x28BBE0 Offset: 0x28BCE1 VA: 0x28BBE0
	private readonly SkillArray <EnchantSkills4>k__BackingField; // 0x168
	[CompilerGeneratedAttribute] // RVA: 0x28BBF0 Offset: 0x28BCF1 VA: 0x28BBF0
	private UnitAnim.Types <AttackMotion>k__BackingField; // 0x170
	public const int EmptyEnchantHash = 0;
	public const int MaxInventory = 999;
	public const int MaxRefine = 9999;

	// Properties
	public string Iid { get; set; }
	public string Name { get; set; }
	public string Help { get; set; }
	public string Tutorial { get; set; }
	public string Aid { get; set; }
	public ItemData.Kinds Kind { get; set; }
	public ItemData.Attrs Attr { get; set; }
	public ItemData.UseTypes UseType { get; set; }
	public ItemData.WeaponAttrs WeaponAttr { get; set; }
	public string Icon { get; set; }
	public byte Endurance { get; set; }
	public byte Power { get; set; }
	public byte Weight { get; set; }
	public byte RangeI { get; set; }
	public byte RangeO { get; set; }
	public byte Distance { get; set; }
	public short Hit { get; set; }
	public short Critical { get; set; }
	public short Avoid { get; set; }
	public short Secure { get; set; }
	public int Price { get; set; }
	public string WeaponLevel { get; set; }
	public ItemData.RodTypes RodType { get; set; }
	public byte RodExp { get; set; }
	public byte RateArena { get; set; }
	public string ShootEffect { get; set; }
	public string HitEffect { get; set; }
	public string CannonEffect { get; set; }
	public string OverlapTerrain { get; set; }
	public ItemData.FlagField Flag { get; set; }
	public CapabilitySbyte Enhance { get; set; }
	public CapabilitySbyte GrowRatio { get; set; }
	public string EquipCondition { get; set; }
	public string[] EquipSids { get; set; }
	public string[] PassiveSids { get; set; }
	public string[] GiveSids { get; set; }
	public ItemData.AddTargets AddTarget { get; set; }
	public ItemData.UseTypes AddType { get; set; }
	public byte AddPower { get; set; }
	public byte AddRange { get; set; }
	public string[] AddSids { get; set; }
	public string AddEffect { get; set; }
	public string AddHelp { get; set; }
	public string HighRankItem { get; set; }
	public SkillArray EquipSkills { get; }
	public SkillArray PassiveSkills { get; }
	public SkillArray GiveSkills { get; }
	public SkillArray EnchantSkills1 { get; }
	public SkillArray EnchantSkills2 { get; }
	public SkillArray EnchantSkills3 { get; }
	public SkillArray EnchantSkills4 { get; }
	public UnitAnim.Types AttackMotion { get; set; }
	public static ItemData MasterProof { get; }
	public static ItemData ChangeProof { get; }
	public static ItemData EnchantProof { get; }
	public static ItemData GunnerProof { get; }

	// Methods

	// RVA: 0x2B64A00 Offset: 0x2B64B01 VA: 0x2B64A00
	public static string GetKindName(ItemData.Kinds kind) { }

	// RVA: 0x2B64B40 Offset: 0x2B64C41 VA: 0x2B64B40
	public static void Load() { }

	// RVA: 0x2B64BF0 Offset: 0x2B64CF1 VA: 0x2B64BF0
	public void .ctor() { }

	[CompilerGeneratedAttribute] // RVA: 0x2B9030 Offset: 0x2B9131 VA: 0x2B9030
	// RVA: 0x2B64DF0 Offset: 0x2B64EF1 VA: 0x2B64DF0
	public string get_Iid() { }

	[CompilerGeneratedAttribute] // RVA: 0x2B9040 Offset: 0x2B9141 VA: 0x2B9040
	// RVA: 0x2B64E00 Offset: 0x2B64F01 VA: 0x2B64E00
	private void set_Iid(string value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2B9050 Offset: 0x2B9151 VA: 0x2B9050
	// RVA: 0x2B64E10 Offset: 0x2B64F11 VA: 0x2B64E10
	public string get_Name() { }

	[CompilerGeneratedAttribute] // RVA: 0x2B9060 Offset: 0x2B9161 VA: 0x2B9060
	// RVA: 0x2B64E20 Offset: 0x2B64F21 VA: 0x2B64E20
	private void set_Name(string value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2B9070 Offset: 0x2B9171 VA: 0x2B9070
	// RVA: 0x2B64E30 Offset: 0x2B64F31 VA: 0x2B64E30
	public string get_Help() { }

	[CompilerGeneratedAttribute] // RVA: 0x2B9080 Offset: 0x2B9181 VA: 0x2B9080
	// RVA: 0x2B64E40 Offset: 0x2B64F41 VA: 0x2B64E40
	private void set_Help(string value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2B9090 Offset: 0x2B9191 VA: 0x2B9090
	// RVA: 0x2B64E50 Offset: 0x2B64F51 VA: 0x2B64E50
	public string get_Tutorial() { }

	[CompilerGeneratedAttribute] // RVA: 0x2B90A0 Offset: 0x2B91A1 VA: 0x2B90A0
	// RVA: 0x2B64E60 Offset: 0x2B64F61 VA: 0x2B64E60
	private void set_Tutorial(string value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2B90B0 Offset: 0x2B91B1 VA: 0x2B90B0
	// RVA: 0x2B64E70 Offset: 0x2B64F71 VA: 0x2B64E70
	public string get_Aid() { }

	[CompilerGeneratedAttribute] // RVA: 0x2B90C0 Offset: 0x2B91C1 VA: 0x2B90C0
	// RVA: 0x2B64E80 Offset: 0x2B64F81 VA: 0x2B64E80
	private void set_Aid(string value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2B90D0 Offset: 0x2B91D1 VA: 0x2B90D0
	// RVA: 0x2B64E90 Offset: 0x2B64F91 VA: 0x2B64E90
	public ItemData.Kinds get_Kind() { }

	[CompilerGeneratedAttribute] // RVA: 0x2B90E0 Offset: 0x2B91E1 VA: 0x2B90E0
	// RVA: 0x2B64EA0 Offset: 0x2B64FA1 VA: 0x2B64EA0
	private void set_Kind(ItemData.Kinds value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2B90F0 Offset: 0x2B91F1 VA: 0x2B90F0
	// RVA: 0x2B64EB0 Offset: 0x2B64FB1 VA: 0x2B64EB0
	public ItemData.Attrs get_Attr() { }

	[CompilerGeneratedAttribute] // RVA: 0x2B9100 Offset: 0x2B9201 VA: 0x2B9100
	// RVA: 0x2B64EC0 Offset: 0x2B64FC1 VA: 0x2B64EC0
	private void set_Attr(ItemData.Attrs value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2B9110 Offset: 0x2B9211 VA: 0x2B9110
	// RVA: 0x2B64ED0 Offset: 0x2B64FD1 VA: 0x2B64ED0
	public ItemData.UseTypes get_UseType() { }

	[CompilerGeneratedAttribute] // RVA: 0x2B9120 Offset: 0x2B9221 VA: 0x2B9120
	// RVA: 0x2B64EE0 Offset: 0x2B64FE1 VA: 0x2B64EE0
	private void set_UseType(ItemData.UseTypes value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2B9130 Offset: 0x2B9231 VA: 0x2B9130
	// RVA: 0x2B64EF0 Offset: 0x2B64FF1 VA: 0x2B64EF0
	public ItemData.WeaponAttrs get_WeaponAttr() { }

	[CompilerGeneratedAttribute] // RVA: 0x2B9140 Offset: 0x2B9241 VA: 0x2B9140
	// RVA: 0x2B64F00 Offset: 0x2B65001 VA: 0x2B64F00
	private void set_WeaponAttr(ItemData.WeaponAttrs value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2B9150 Offset: 0x2B9251 VA: 0x2B9150
	// RVA: 0x2B64F10 Offset: 0x2B65011 VA: 0x2B64F10
	public string get_Icon() { }

	[CompilerGeneratedAttribute] // RVA: 0x2B9160 Offset: 0x2B9261 VA: 0x2B9160
	// RVA: 0x2B64F20 Offset: 0x2B65021 VA: 0x2B64F20
	private void set_Icon(string value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2B9170 Offset: 0x2B9271 VA: 0x2B9170
	// RVA: 0x2B64F30 Offset: 0x2B65031 VA: 0x2B64F30
	public byte get_Endurance() { }

	[CompilerGeneratedAttribute] // RVA: 0x2B9180 Offset: 0x2B9281 VA: 0x2B9180
	// RVA: 0x2B64F40 Offset: 0x2B65041 VA: 0x2B64F40
	private void set_Endurance(byte value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2B9190 Offset: 0x2B9291 VA: 0x2B9190
	// RVA: 0x2B64F50 Offset: 0x2B65051 VA: 0x2B64F50
	public byte get_Power() { }

	[CompilerGeneratedAttribute] // RVA: 0x2B91A0 Offset: 0x2B92A1 VA: 0x2B91A0
	// RVA: 0x2B64F60 Offset: 0x2B65061 VA: 0x2B64F60
	private void set_Power(byte value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2B91B0 Offset: 0x2B92B1 VA: 0x2B91B0
	// RVA: 0x2B64F70 Offset: 0x2B65071 VA: 0x2B64F70
	public byte get_Weight() { }

	[CompilerGeneratedAttribute] // RVA: 0x2B91C0 Offset: 0x2B92C1 VA: 0x2B91C0
	// RVA: 0x2B64F80 Offset: 0x2B65081 VA: 0x2B64F80
	private void set_Weight(byte value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2B91D0 Offset: 0x2B92D1 VA: 0x2B91D0
	// RVA: 0x2B64F90 Offset: 0x2B65091 VA: 0x2B64F90
	public byte get_RangeI() { }

	[CompilerGeneratedAttribute] // RVA: 0x2B91E0 Offset: 0x2B92E1 VA: 0x2B91E0
	// RVA: 0x2B64FA0 Offset: 0x2B650A1 VA: 0x2B64FA0
	private void set_RangeI(byte value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2B91F0 Offset: 0x2B92F1 VA: 0x2B91F0
	// RVA: 0x2B64FB0 Offset: 0x2B650B1 VA: 0x2B64FB0
	public byte get_RangeO() { }

	[CompilerGeneratedAttribute] // RVA: 0x2B9200 Offset: 0x2B9301 VA: 0x2B9200
	// RVA: 0x2B64FC0 Offset: 0x2B650C1 VA: 0x2B64FC0
	private void set_RangeO(byte value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2B9210 Offset: 0x2B9311 VA: 0x2B9210
	// RVA: 0x2B64FD0 Offset: 0x2B650D1 VA: 0x2B64FD0
	public byte get_Distance() { }

	[CompilerGeneratedAttribute] // RVA: 0x2B9220 Offset: 0x2B9321 VA: 0x2B9220
	// RVA: 0x2B64FE0 Offset: 0x2B650E1 VA: 0x2B64FE0
	private void set_Distance(byte value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2B9230 Offset: 0x2B9331 VA: 0x2B9230
	// RVA: 0x2B64FF0 Offset: 0x2B650F1 VA: 0x2B64FF0
	public short get_Hit() { }

	[CompilerGeneratedAttribute] // RVA: 0x2B9240 Offset: 0x2B9341 VA: 0x2B9240
	// RVA: 0x2B65000 Offset: 0x2B65101 VA: 0x2B65000
	private void set_Hit(short value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2B9250 Offset: 0x2B9351 VA: 0x2B9250
	// RVA: 0x2B65010 Offset: 0x2B65111 VA: 0x2B65010
	public short get_Critical() { }

	[CompilerGeneratedAttribute] // RVA: 0x2B9260 Offset: 0x2B9361 VA: 0x2B9260
	// RVA: 0x2B65020 Offset: 0x2B65121 VA: 0x2B65020
	private void set_Critical(short value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2B9270 Offset: 0x2B9371 VA: 0x2B9270
	// RVA: 0x2B65030 Offset: 0x2B65131 VA: 0x2B65030
	public short get_Avoid() { }

	[CompilerGeneratedAttribute] // RVA: 0x2B9280 Offset: 0x2B9381 VA: 0x2B9280
	// RVA: 0x2B65040 Offset: 0x2B65141 VA: 0x2B65040
	private void set_Avoid(short value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2B9290 Offset: 0x2B9391 VA: 0x2B9290
	// RVA: 0x2B65050 Offset: 0x2B65151 VA: 0x2B65050
	public short get_Secure() { }

	[CompilerGeneratedAttribute] // RVA: 0x2B92A0 Offset: 0x2B93A1 VA: 0x2B92A0
	// RVA: 0x2B65060 Offset: 0x2B65161 VA: 0x2B65060
	private void set_Secure(short value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2B92B0 Offset: 0x2B93B1 VA: 0x2B92B0
	// RVA: 0x2B65070 Offset: 0x2B65171 VA: 0x2B65070
	public int get_Price() { }

	[CompilerGeneratedAttribute] // RVA: 0x2B92C0 Offset: 0x2B93C1 VA: 0x2B92C0
	// RVA: 0x2B65080 Offset: 0x2B65181 VA: 0x2B65080
	private void set_Price(int value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2B92D0 Offset: 0x2B93D1 VA: 0x2B92D0
	// RVA: 0x2B65090 Offset: 0x2B65191 VA: 0x2B65090
	public string get_WeaponLevel() { }

	[CompilerGeneratedAttribute] // RVA: 0x2B92E0 Offset: 0x2B93E1 VA: 0x2B92E0
	// RVA: 0x2B650A0 Offset: 0x2B651A1 VA: 0x2B650A0
	private void set_WeaponLevel(string value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2B92F0 Offset: 0x2B93F1 VA: 0x2B92F0
	// RVA: 0x2B650B0 Offset: 0x2B651B1 VA: 0x2B650B0
	public ItemData.RodTypes get_RodType() { }

	[CompilerGeneratedAttribute] // RVA: 0x2B9300 Offset: 0x2B9401 VA: 0x2B9300
	// RVA: 0x2B650C0 Offset: 0x2B651C1 VA: 0x2B650C0
	private void set_RodType(ItemData.RodTypes value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2B9310 Offset: 0x2B9411 VA: 0x2B9310
	// RVA: 0x2B650D0 Offset: 0x2B651D1 VA: 0x2B650D0
	public byte get_RodExp() { }

	[CompilerGeneratedAttribute] // RVA: 0x2B9320 Offset: 0x2B9421 VA: 0x2B9320
	// RVA: 0x2B650E0 Offset: 0x2B651E1 VA: 0x2B650E0
	private void set_RodExp(byte value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2B9330 Offset: 0x2B9431 VA: 0x2B9330
	// RVA: 0x2B650F0 Offset: 0x2B651F1 VA: 0x2B650F0
	public byte get_RateArena() { }

	[CompilerGeneratedAttribute] // RVA: 0x2B9340 Offset: 0x2B9441 VA: 0x2B9340
	// RVA: 0x2B65100 Offset: 0x2B65201 VA: 0x2B65100
	private void set_RateArena(byte value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2B9350 Offset: 0x2B9451 VA: 0x2B9350
	// RVA: 0x2B65110 Offset: 0x2B65211 VA: 0x2B65110
	public string get_ShootEffect() { }

	[CompilerGeneratedAttribute] // RVA: 0x2B9360 Offset: 0x2B9461 VA: 0x2B9360
	// RVA: 0x2B65120 Offset: 0x2B65221 VA: 0x2B65120
	private void set_ShootEffect(string value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2B9370 Offset: 0x2B9471 VA: 0x2B9370
	// RVA: 0x2B65130 Offset: 0x2B65231 VA: 0x2B65130
	public string get_HitEffect() { }

	[CompilerGeneratedAttribute] // RVA: 0x2B9380 Offset: 0x2B9481 VA: 0x2B9380
	// RVA: 0x2B65140 Offset: 0x2B65241 VA: 0x2B65140
	private void set_HitEffect(string value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2B9390 Offset: 0x2B9491 VA: 0x2B9390
	// RVA: 0x2B65150 Offset: 0x2B65251 VA: 0x2B65150
	public string get_CannonEffect() { }

	[CompilerGeneratedAttribute] // RVA: 0x2B93A0 Offset: 0x2B94A1 VA: 0x2B93A0
	// RVA: 0x2B65160 Offset: 0x2B65261 VA: 0x2B65160
	private void set_CannonEffect(string value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2B93B0 Offset: 0x2B94B1 VA: 0x2B93B0
	// RVA: 0x2B65170 Offset: 0x2B65271 VA: 0x2B65170
	public string get_OverlapTerrain() { }

	[CompilerGeneratedAttribute] // RVA: 0x2B93C0 Offset: 0x2B94C1 VA: 0x2B93C0
	// RVA: 0x2B65180 Offset: 0x2B65281 VA: 0x2B65180
	private void set_OverlapTerrain(string value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2B93D0 Offset: 0x2B94D1 VA: 0x2B93D0
	// RVA: 0x2B65190 Offset: 0x2B65291 VA: 0x2B65190
	public ItemData.FlagField get_Flag() { }

	[CompilerGeneratedAttribute] // RVA: 0x2B93E0 Offset: 0x2B94E1 VA: 0x2B93E0
	// RVA: 0x2B651A0 Offset: 0x2B652A1 VA: 0x2B651A0
	private void set_Flag(ItemData.FlagField value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2B93F0 Offset: 0x2B94F1 VA: 0x2B93F0
	// RVA: 0x2B651B0 Offset: 0x2B652B1 VA: 0x2B651B0
	public CapabilitySbyte get_Enhance() { }

	[CompilerGeneratedAttribute] // RVA: 0x2B9400 Offset: 0x2B9501 VA: 0x2B9400
	// RVA: 0x2B651C0 Offset: 0x2B652C1 VA: 0x2B651C0
	private void set_Enhance(CapabilitySbyte value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2B9410 Offset: 0x2B9511 VA: 0x2B9410
	// RVA: 0x2B651D0 Offset: 0x2B652D1 VA: 0x2B651D0
	public CapabilitySbyte get_GrowRatio() { }

	[CompilerGeneratedAttribute] // RVA: 0x2B9420 Offset: 0x2B9521 VA: 0x2B9420
	// RVA: 0x2B651E0 Offset: 0x2B652E1 VA: 0x2B651E0
	private void set_GrowRatio(CapabilitySbyte value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2B9430 Offset: 0x2B9531 VA: 0x2B9430
	// RVA: 0x2B651F0 Offset: 0x2B652F1 VA: 0x2B651F0
	public string get_EquipCondition() { }

	[CompilerGeneratedAttribute] // RVA: 0x2B9440 Offset: 0x2B9541 VA: 0x2B9440
	// RVA: 0x2B65200 Offset: 0x2B65301 VA: 0x2B65200
	private void set_EquipCondition(string value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2B9450 Offset: 0x2B9551 VA: 0x2B9450
	// RVA: 0x2B65210 Offset: 0x2B65311 VA: 0x2B65210
	public string[] get_EquipSids() { }

	[CompilerGeneratedAttribute] // RVA: 0x2B9460 Offset: 0x2B9561 VA: 0x2B9460
	// RVA: 0x2B65220 Offset: 0x2B65321 VA: 0x2B65220
	private void set_EquipSids(string[] value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2B9470 Offset: 0x2B9571 VA: 0x2B9470
	// RVA: 0x2B65230 Offset: 0x2B65331 VA: 0x2B65230
	public string[] get_PassiveSids() { }

	[CompilerGeneratedAttribute] // RVA: 0x2B9480 Offset: 0x2B9581 VA: 0x2B9480
	// RVA: 0x2B65240 Offset: 0x2B65341 VA: 0x2B65240
	private void set_PassiveSids(string[] value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2B9490 Offset: 0x2B9591 VA: 0x2B9490
	// RVA: 0x2B65250 Offset: 0x2B65351 VA: 0x2B65250
	public string[] get_GiveSids() { }

	[CompilerGeneratedAttribute] // RVA: 0x2B94A0 Offset: 0x2B95A1 VA: 0x2B94A0
	// RVA: 0x2B65260 Offset: 0x2B65361 VA: 0x2B65260
	private void set_GiveSids(string[] value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2B94B0 Offset: 0x2B95B1 VA: 0x2B94B0
	// RVA: 0x2B65270 Offset: 0x2B65371 VA: 0x2B65270
	public ItemData.AddTargets get_AddTarget() { }

	[CompilerGeneratedAttribute] // RVA: 0x2B94C0 Offset: 0x2B95C1 VA: 0x2B94C0
	// RVA: 0x2B65280 Offset: 0x2B65381 VA: 0x2B65280
	private void set_AddTarget(ItemData.AddTargets value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2B94D0 Offset: 0x2B95D1 VA: 0x2B94D0
	// RVA: 0x2B65290 Offset: 0x2B65391 VA: 0x2B65290
	public ItemData.UseTypes get_AddType() { }

	[CompilerGeneratedAttribute] // RVA: 0x2B94E0 Offset: 0x2B95E1 VA: 0x2B94E0
	// RVA: 0x2B652A0 Offset: 0x2B653A1 VA: 0x2B652A0
	private void set_AddType(ItemData.UseTypes value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2B94F0 Offset: 0x2B95F1 VA: 0x2B94F0
	// RVA: 0x2B652B0 Offset: 0x2B653B1 VA: 0x2B652B0
	public byte get_AddPower() { }

	[CompilerGeneratedAttribute] // RVA: 0x2B9500 Offset: 0x2B9601 VA: 0x2B9500
	// RVA: 0x2B652C0 Offset: 0x2B653C1 VA: 0x2B652C0
	private void set_AddPower(byte value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2B9510 Offset: 0x2B9611 VA: 0x2B9510
	// RVA: 0x2B652D0 Offset: 0x2B653D1 VA: 0x2B652D0
	public byte get_AddRange() { }

	[CompilerGeneratedAttribute] // RVA: 0x2B9520 Offset: 0x2B9621 VA: 0x2B9520
	// RVA: 0x2B652E0 Offset: 0x2B653E1 VA: 0x2B652E0
	private void set_AddRange(byte value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2B9530 Offset: 0x2B9631 VA: 0x2B9530
	// RVA: 0x2B652F0 Offset: 0x2B653F1 VA: 0x2B652F0
	public string[] get_AddSids() { }

	[CompilerGeneratedAttribute] // RVA: 0x2B9540 Offset: 0x2B9641 VA: 0x2B9540
	// RVA: 0x2B65300 Offset: 0x2B65401 VA: 0x2B65300
	private void set_AddSids(string[] value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2B9550 Offset: 0x2B9651 VA: 0x2B9550
	// RVA: 0x2B65310 Offset: 0x2B65411 VA: 0x2B65310
	public string get_AddEffect() { }

	[CompilerGeneratedAttribute] // RVA: 0x2B9560 Offset: 0x2B9661 VA: 0x2B9560
	// RVA: 0x2B65320 Offset: 0x2B65421 VA: 0x2B65320
	private void set_AddEffect(string value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2B9570 Offset: 0x2B9671 VA: 0x2B9570
	// RVA: 0x2B65330 Offset: 0x2B65431 VA: 0x2B65330
	public string get_AddHelp() { }

	[CompilerGeneratedAttribute] // RVA: 0x2B9580 Offset: 0x2B9681 VA: 0x2B9580
	// RVA: 0x2B65340 Offset: 0x2B65441 VA: 0x2B65340
	private void set_AddHelp(string value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2B9590 Offset: 0x2B9691 VA: 0x2B9590
	// RVA: 0x2B65350 Offset: 0x2B65451 VA: 0x2B65350
	public string get_HighRankItem() { }

	[CompilerGeneratedAttribute] // RVA: 0x2B95A0 Offset: 0x2B96A1 VA: 0x2B95A0
	// RVA: 0x2B65360 Offset: 0x2B65461 VA: 0x2B65360
	private void set_HighRankItem(string value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2B95B0 Offset: 0x2B96B1 VA: 0x2B95B0
	// RVA: 0x2B65370 Offset: 0x2B65471 VA: 0x2B65370
	public SkillArray get_EquipSkills() { }

	[CompilerGeneratedAttribute] // RVA: 0x2B95C0 Offset: 0x2B96C1 VA: 0x2B95C0
	// RVA: 0x2B65380 Offset: 0x2B65481 VA: 0x2B65380
	public SkillArray get_PassiveSkills() { }

	[CompilerGeneratedAttribute] // RVA: 0x2B95D0 Offset: 0x2B96D1 VA: 0x2B95D0
	// RVA: 0x2B65390 Offset: 0x2B65491 VA: 0x2B65390
	public SkillArray get_GiveSkills() { }

	[CompilerGeneratedAttribute] // RVA: 0x2B95E0 Offset: 0x2B96E1 VA: 0x2B95E0
	// RVA: 0x2B653A0 Offset: 0x2B654A1 VA: 0x2B653A0
	public SkillArray get_EnchantSkills1() { }

	[CompilerGeneratedAttribute] // RVA: 0x2B95F0 Offset: 0x2B96F1 VA: 0x2B95F0
	// RVA: 0x2B653B0 Offset: 0x2B654B1 VA: 0x2B653B0
	public SkillArray get_EnchantSkills2() { }

	[CompilerGeneratedAttribute] // RVA: 0x2B9600 Offset: 0x2B9701 VA: 0x2B9600
	// RVA: 0x2B653C0 Offset: 0x2B654C1 VA: 0x2B653C0
	public SkillArray get_EnchantSkills3() { }

	[CompilerGeneratedAttribute] // RVA: 0x2B9610 Offset: 0x2B9711 VA: 0x2B9610
	// RVA: 0x2B653D0 Offset: 0x2B654D1 VA: 0x2B653D0
	public SkillArray get_EnchantSkills4() { }

	[CompilerGeneratedAttribute] // RVA: 0x2B9620 Offset: 0x2B9721 VA: 0x2B9620
	// RVA: 0x2B653E0 Offset: 0x2B654E1 VA: 0x2B653E0
	public UnitAnim.Types get_AttackMotion() { }

	[CompilerGeneratedAttribute] // RVA: 0x2B9630 Offset: 0x2B9731 VA: 0x2B9630
	// RVA: 0x2B653F0 Offset: 0x2B654F1 VA: 0x2B653F0
	private void set_AttackMotion(UnitAnim.Types value) { }

	// RVA: 0x2B65400 Offset: 0x2B65501 VA: 0x2B65400
	public string GetName() { }

	// RVA: 0x2B65600 Offset: 0x2B65701 VA: 0x2B65600
	public bool CanUse() { }

	// RVA: 0x2B65660 Offset: 0x2B65761 VA: 0x2B65660
	public bool CanSelfTarget(Unit unit) { }

	// RVA: 0x2B65730 Offset: 0x2B65831 VA: 0x2B65730
	public int GetEnchantHash() { }

	// RVA: 0x2B65740 Offset: 0x2B65841 VA: 0x2B65740
	public bool HasEnchantHash() { }

	// RVA: 0x2B65750 Offset: 0x2B65851 VA: 0x2B65750
	public string GetPrefixlessIid() { }

	// RVA: 0x2B65760 Offset: 0x2B65861 VA: 0x2B65760
	public bool CanExpend() { }

	// RVA: 0x2B65780 Offset: 0x2B65881 VA: 0x2B65780
	public bool IsWeapon() { }

	// RVA: 0x2B65790 Offset: 0x2B65891 VA: 0x2B65790
	public bool IsPhysical() { }

	// RVA: 0x2B657A0 Offset: 0x2B658A1 VA: 0x2B657A0
	public bool IsMagic() { }

	// RVA: 0x2B657B0 Offset: 0x2B658B1 VA: 0x2B657B0
	public bool IsBreath() { }

	// RVA: 0x2B65810 Offset: 0x2B65911 VA: 0x2B65810
	public bool IsFlag(ItemData.Flags flags) { }

	// RVA: 0x2B65880 Offset: 0x2B65981 VA: 0x2B65880
	public bool IsSurehit() { }

	// RVA: 0x2B658A0 Offset: 0x2B659A1 VA: 0x2B658A0
	public bool IsClassChange() { }

	// RVA: 0x2B658D0 Offset: 0x2B659D1 VA: 0x2B658D0
	public bool IsMaterial() { }

	// RVA: 0x2B65900 Offset: 0x2B65A01 VA: 0x2B65900
	public bool IsLongRange() { }

	// RVA: 0x2B65910 Offset: 0x2B65A11 VA: 0x2B65910
	public bool IsRangeTarget() { }

	// RVA: 0x2B65970 Offset: 0x2B65A71 VA: 0x2B65970
	public bool IsRangeUseType(ItemData.UseTypes useType) { }

	// RVA: 0x2B65A00 Offset: 0x2B65B01 VA: 0x2B65A00
	public bool IsRangeHeal() { }

	// RVA: 0x2B65A80 Offset: 0x2B65B81 VA: 0x2B65A80
	public bool IsRangeRestHeal() { }

	// RVA: 0x2B65B00 Offset: 0x2B65C01 VA: 0x2B65B00
	public bool IsRangeAgain() { }

	// RVA: 0x2B65B80 Offset: 0x2B65C81 VA: 0x2B65B80
	public bool IsRangeEngageAdd() { }

	// RVA: 0x2B65C00 Offset: 0x2B65D01 VA: 0x2B65C00
	public bool IsBless() { }

	// RVA: 0x2B65C20 Offset: 0x2B65D21 VA: 0x2B65C20
	public bool IsDownload() { }

	// RVA: 0x2B65C80 Offset: 0x2B65D81 VA: 0x2B65C80
	public bool IsUnknown() { }

	// RVA: 0x2B65D50 Offset: 0x2B65E51 VA: 0x2B65D50
	public bool IsSingleRod() { }

	// RVA: 0x2B65DD0 Offset: 0x2B65ED1 VA: 0x2B65DD0
	public int GetTimes() { }

	// RVA: 0x2B65DE0 Offset: 0x2B65EE1 VA: 0x2B65DE0
	public WeaponLevel.Kind GetWeaponLevel() { }

	// RVA: 0x2B65DF0 Offset: 0x2B65EF1 VA: 0x2B65DF0
	public int GetPrice(int endurance) { }

	// RVA: 0x2B65E20 Offset: 0x2B65F21 VA: 0x2B65E20
	public UnitItem GetUnitItem(Unit unit) { }

	// RVA: 0x2B65EF0 Offset: 0x2B65FF1 VA: 0x2B65EF0
	public UnitItem GetUnitItem() { }

	// RVA: 0x2B65F00 Offset: 0x2B66001 VA: 0x2B65F00
	public Color GetFontColor(bool isActive) { }

	// RVA: 0x2B66080 Offset: 0x2B66181 VA: 0x2B66080 Slot: 8
	public override string GetDebugName() { }

	// RVA: 0x2B66180 Offset: 0x2B66281 VA: 0x2B66180 Slot: 4
	public override void OnBuild() { }

	// RVA: 0x2B663C0 Offset: 0x2B664C1 VA: 0x2B663C0
	private int CalcEnchantHash() { }

	// RVA: 0x2B66370 Offset: 0x2B66471 VA: 0x2B66370
	private bool HasFlagName() { }

	// RVA: 0x2B66550 Offset: 0x2B66651 VA: 0x2B66550
	private ItemData.Attrs CalcAttr() { }

	// RVA: 0x2B66600 Offset: 0x2B66701 VA: 0x2B66600
	public string GetAttrNameMID() { }

	// RVA: 0x2B666E0 Offset: 0x2B667E1 VA: 0x2B666E0
	public string GetAttrHelpMID() { }

	// RVA: 0x2B667C0 Offset: 0x2B668C1 VA: 0x2B667C0
	private static string TryGetSkill(string[] skills, int index) { }

	// RVA: 0x2B66820 Offset: 0x2B66921 VA: 0x2B66820
	public SkillArray GetEnchantSkills(int level = 0) { }

	// RVA: 0x2B66850 Offset: 0x2B66951 VA: 0x2B66850 Slot: 5
	public override void OnCompleted() { }

	// RVA: 0x2B68010 Offset: 0x2B68111 VA: 0x2B68010
	public static void Serialize(Stream stream, ItemData item) { }

	// RVA: 0x2B68070 Offset: 0x2B68171 VA: 0x2B68070
	public static ItemData Deserialize(Stream stream) { }

	// RVA: 0x2B680D0 Offset: 0x2B681D1 VA: 0x2B680D0
	public static void TrySerialize(Stream stream, ItemData item) { }

	// RVA: 0x2B68170 Offset: 0x2B68271 VA: 0x2B68170
	public static ItemData TryDeserialize(Stream stream) { }

	// RVA: 0x2B682C0 Offset: 0x2B683C1 VA: 0x2B682C0
	public static ItemData CreateSimpleWeapon(ItemData.Kinds kind, bool isBullet = False) { }

	// RVA: 0x2B68510 Offset: 0x2B68611 VA: 0x2B68510
	public bool IsInventory() { }

	// RVA: 0x2B68520 Offset: 0x2B68621 VA: 0x2B68520
	public int GetInventory() { }

	// RVA: 0x2B68610 Offset: 0x2B68711 VA: 0x2B68610
	public int GetMaxInventory() { }

	// RVA: 0x2B68630 Offset: 0x2B68731 VA: 0x2B68630
	public void SetInventory(int count) { }

	// RVA: 0x2B68830 Offset: 0x2B68931 VA: 0x2B68830
	public void AddInventory(int count = 1) { }

	// RVA: 0x2B68AA0 Offset: 0x2B68BA1 VA: 0x2B68AA0
	public static void RegistGlobalFlags() { }

	// RVA: 0x2B68BF0 Offset: 0x2B68CF1 VA: 0x2B68BF0
	public EffectData GetShootEffect() { }

	// RVA: 0x2B68C80 Offset: 0x2B68D81 VA: 0x2B68C80
	public EffectData GetHitEffect() { }

	// RVA: 0x2B68D10 Offset: 0x2B68E11 VA: 0x2B68D10
	public EffectData GetUseEffect() { }

	// RVA: 0x2B68DD0 Offset: 0x2B68ED1 VA: 0x2B68DD0
	public EffectData GetEnchantEffect() { }

	// RVA: 0x2B68E90 Offset: 0x2B68F91 VA: 0x2B68E90
	public EffectSequence GetCannonEffect() { }

	// RVA: 0x2B68F20 Offset: 0x2B69021 VA: 0x2B68F20
	public bool IsDragon() { }

	// RVA: 0x2B68F80 Offset: 0x2B69081 VA: 0x2B68F80
	public bool IsBullet() { }

	// RVA: 0x2B66540 Offset: 0x2B66641 VA: 0x2B66540
	public bool CanEnchant() { }

	// RVA: 0x2B68FE0 Offset: 0x2B690E1 VA: 0x2B68FE0
	public static ItemData get_MasterProof() { }

	// RVA: 0x2B69070 Offset: 0x2B69171 VA: 0x2B69070
	public static ItemData get_ChangeProof() { }

	// RVA: 0x2B69100 Offset: 0x2B69201 VA: 0x2B69100
	public static ItemData get_EnchantProof() { }

	// RVA: 0x2B69110 Offset: 0x2B69211 VA: 0x2B69110
	public static ItemData get_GunnerProof() { }

	// RVA: 0x2B69120 Offset: 0x2B69221 VA: 0x2B69120
	public static string[] ReplaceHighRank(string[] iids) { }

	// RVA: 0x2B69280 Offset: 0x2B69381 VA: 0x2B69280
	public int GetEnchantRangeI() { }

	// RVA: 0x2B69290 Offset: 0x2B69391 VA: 0x2B69290
	public int GetEnchantRangeO() { }

	// RVA: 0x2B692B0 Offset: 0x2B693B1 VA: 0x2B692B0
	public int GetGainExp() { }

	// RVA: 0x2B692D0 Offset: 0x2B693D1 VA: 0x2B692D0
	public int GetGainSkillPoint() { }
}

