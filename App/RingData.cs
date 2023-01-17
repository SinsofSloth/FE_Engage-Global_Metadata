// Namespace: App
public class RingData : StructData<RingData> // TypeDefIndex: 10055
{
	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x28CE20 Offset: 0x28CF21 VA: 0x28CE20
	private string <Rnid>k__BackingField; // 0x20
	[CompilerGeneratedAttribute] // RVA: 0x28CE30 Offset: 0x28CF31 VA: 0x28CE30
	private string <Name>k__BackingField; // 0x28
	[CompilerGeneratedAttribute] // RVA: 0x28CE40 Offset: 0x28CF41 VA: 0x28CE40
	private string <Help>k__BackingField; // 0x30
	[CompilerGeneratedAttribute] // RVA: 0x28CE50 Offset: 0x28CF51 VA: 0x28CE50
	private string <Gid>k__BackingField; // 0x38
	[CompilerGeneratedAttribute] // RVA: 0x28CE60 Offset: 0x28CF61 VA: 0x28CE60
	private string <RingModel>k__BackingField; // 0x40
	[CompilerGeneratedAttribute] // RVA: 0x28CE70 Offset: 0x28CF71 VA: 0x28CE70
	private RingData.Kinds <Kind>k__BackingField; // 0x48
	[CompilerGeneratedAttribute] // RVA: 0x28CE80 Offset: 0x28CF81 VA: 0x28CE80
	private RingData.Ranks <Rank>k__BackingField; // 0x4C
	[CompilerGeneratedAttribute] // RVA: 0x28CE90 Offset: 0x28CF91 VA: 0x28CE90
	private string <Icon>k__BackingField; // 0x50
	[CompilerGeneratedAttribute] // RVA: 0x28CEA0 Offset: 0x28CFA1 VA: 0x28CEA0
	private CapabilitySbyte <Enhance>k__BackingField; // 0x58
	[CompilerGeneratedAttribute] // RVA: 0x28CEB0 Offset: 0x28CFB1 VA: 0x28CEB0
	private string[] <EquipSids>k__BackingField; // 0x60
	[CompilerGeneratedAttribute] // RVA: 0x28CEC0 Offset: 0x28CFC1 VA: 0x28CEC0
	private SkillArray <EquipSkills>k__BackingField; // 0x68
	[CompilerGeneratedAttribute] // RVA: 0x28CED0 Offset: 0x28CFD1 VA: 0x28CED0
	private bool <IsSingleRank>k__BackingField; // 0x70
	[CompilerGeneratedAttribute] // RVA: 0x28CEE0 Offset: 0x28CFE1 VA: 0x28CEE0
	private byte <JewelColorR>k__BackingField; // 0x71
	[CompilerGeneratedAttribute] // RVA: 0x28CEF0 Offset: 0x28CFF1 VA: 0x28CEF0
	private byte <JewelColorG>k__BackingField; // 0x72
	[CompilerGeneratedAttribute] // RVA: 0x28CF00 Offset: 0x28D001 VA: 0x28CF00
	private byte <JewelColorB>k__BackingField; // 0x73
	[CompilerGeneratedAttribute] // RVA: 0x28CF10 Offset: 0x28D011 VA: 0x28CF10
	private byte <RimColorR>k__BackingField; // 0x74
	[CompilerGeneratedAttribute] // RVA: 0x28CF20 Offset: 0x28D021 VA: 0x28CF20
	private byte <RimColorG>k__BackingField; // 0x75
	[CompilerGeneratedAttribute] // RVA: 0x28CF30 Offset: 0x28D031 VA: 0x28CF30
	private byte <RimColorB>k__BackingField; // 0x76
	private string m_Group; // 0x78
	private string m_FlagName; // 0x80
	private Color m_JewelColor; // 0x88
	private Color m_RimColor; // 0x98

	// Properties
	public string Rnid { get; set; }
	public string Name { get; set; }
	public string Help { get; set; }
	public string Gid { get; set; }
	public string RingModel { get; set; }
	public RingData.Kinds Kind { get; set; }
	public RingData.Ranks Rank { get; set; }
	public string Icon { get; set; }
	public CapabilitySbyte Enhance { get; set; }
	public string[] EquipSids { get; set; }
	public SkillArray EquipSkills { get; set; }
	public bool IsSingleRank { get; set; }
	public byte JewelColorR { get; set; }
	public byte JewelColorG { get; set; }
	public byte JewelColorB { get; set; }
	public byte RimColorR { get; set; }
	public byte RimColorG { get; set; }
	public byte RimColorB { get; set; }
	public string Group { get; }
	public string FlagName { get; }
	public Color JewelColor { get; }
	public Color RimColor { get; }

	// Methods

	// RVA: 0x26851C0 Offset: 0x26852C1 VA: 0x26851C0
	public static void Load() { }

	// RVA: 0x2685270 Offset: 0x2685371 VA: 0x2685270
	public static RingData GetNextRankData(string rnid) { }

	// RVA: 0x2685600 Offset: 0x2685701 VA: 0x2685600
	public void .ctor() { }

	[CompilerGeneratedAttribute] // RVA: 0x2BBAF0 Offset: 0x2BBBF1 VA: 0x2BBAF0
	// RVA: 0x2685700 Offset: 0x2685801 VA: 0x2685700
	public string get_Rnid() { }

	[CompilerGeneratedAttribute] // RVA: 0x2BBB00 Offset: 0x2BBC01 VA: 0x2BBB00
	// RVA: 0x2685710 Offset: 0x2685811 VA: 0x2685710
	private void set_Rnid(string value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2BBB10 Offset: 0x2BBC11 VA: 0x2BBB10
	// RVA: 0x2685720 Offset: 0x2685821 VA: 0x2685720
	public string get_Name() { }

	[CompilerGeneratedAttribute] // RVA: 0x2BBB20 Offset: 0x2BBC21 VA: 0x2BBB20
	// RVA: 0x2685730 Offset: 0x2685831 VA: 0x2685730
	private void set_Name(string value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2BBB30 Offset: 0x2BBC31 VA: 0x2BBB30
	// RVA: 0x2685740 Offset: 0x2685841 VA: 0x2685740
	public string get_Help() { }

	[CompilerGeneratedAttribute] // RVA: 0x2BBB40 Offset: 0x2BBC41 VA: 0x2BBB40
	// RVA: 0x2685750 Offset: 0x2685851 VA: 0x2685750
	private void set_Help(string value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2BBB50 Offset: 0x2BBC51 VA: 0x2BBB50
	// RVA: 0x2685760 Offset: 0x2685861 VA: 0x2685760
	public string get_Gid() { }

	[CompilerGeneratedAttribute] // RVA: 0x2BBB60 Offset: 0x2BBC61 VA: 0x2BBB60
	// RVA: 0x2685770 Offset: 0x2685871 VA: 0x2685770
	private void set_Gid(string value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2BBB70 Offset: 0x2BBC71 VA: 0x2BBB70
	// RVA: 0x2685780 Offset: 0x2685881 VA: 0x2685780
	public string get_RingModel() { }

	[CompilerGeneratedAttribute] // RVA: 0x2BBB80 Offset: 0x2BBC81 VA: 0x2BBB80
	// RVA: 0x2685790 Offset: 0x2685891 VA: 0x2685790
	private void set_RingModel(string value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2BBB90 Offset: 0x2BBC91 VA: 0x2BBB90
	// RVA: 0x26857A0 Offset: 0x26858A1 VA: 0x26857A0
	public RingData.Kinds get_Kind() { }

	[CompilerGeneratedAttribute] // RVA: 0x2BBBA0 Offset: 0x2BBCA1 VA: 0x2BBBA0
	// RVA: 0x26857B0 Offset: 0x26858B1 VA: 0x26857B0
	private void set_Kind(RingData.Kinds value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2BBBB0 Offset: 0x2BBCB1 VA: 0x2BBBB0
	// RVA: 0x26857C0 Offset: 0x26858C1 VA: 0x26857C0
	public RingData.Ranks get_Rank() { }

	[CompilerGeneratedAttribute] // RVA: 0x2BBBC0 Offset: 0x2BBCC1 VA: 0x2BBBC0
	// RVA: 0x26857D0 Offset: 0x26858D1 VA: 0x26857D0
	private void set_Rank(RingData.Ranks value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2BBBD0 Offset: 0x2BBCD1 VA: 0x2BBBD0
	// RVA: 0x26857E0 Offset: 0x26858E1 VA: 0x26857E0
	public string get_Icon() { }

	[CompilerGeneratedAttribute] // RVA: 0x2BBBE0 Offset: 0x2BBCE1 VA: 0x2BBBE0
	// RVA: 0x26857F0 Offset: 0x26858F1 VA: 0x26857F0
	private void set_Icon(string value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2BBBF0 Offset: 0x2BBCF1 VA: 0x2BBBF0
	// RVA: 0x2685800 Offset: 0x2685901 VA: 0x2685800
	public CapabilitySbyte get_Enhance() { }

	[CompilerGeneratedAttribute] // RVA: 0x2BBC00 Offset: 0x2BBD01 VA: 0x2BBC00
	// RVA: 0x2685810 Offset: 0x2685911 VA: 0x2685810
	private void set_Enhance(CapabilitySbyte value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2BBC10 Offset: 0x2BBD11 VA: 0x2BBC10
	// RVA: 0x2685820 Offset: 0x2685921 VA: 0x2685820
	public string[] get_EquipSids() { }

	[CompilerGeneratedAttribute] // RVA: 0x2BBC20 Offset: 0x2BBD21 VA: 0x2BBC20
	// RVA: 0x2685830 Offset: 0x2685931 VA: 0x2685830
	private void set_EquipSids(string[] value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2BBC30 Offset: 0x2BBD31 VA: 0x2BBC30
	// RVA: 0x2685840 Offset: 0x2685941 VA: 0x2685840
	public SkillArray get_EquipSkills() { }

	[CompilerGeneratedAttribute] // RVA: 0x2BBC40 Offset: 0x2BBD41 VA: 0x2BBC40
	// RVA: 0x2685850 Offset: 0x2685951 VA: 0x2685850
	private void set_EquipSkills(SkillArray value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2BBC50 Offset: 0x2BBD51 VA: 0x2BBC50
	// RVA: 0x2685860 Offset: 0x2685961 VA: 0x2685860
	public bool get_IsSingleRank() { }

	[CompilerGeneratedAttribute] // RVA: 0x2BBC60 Offset: 0x2BBD61 VA: 0x2BBC60
	// RVA: 0x2685870 Offset: 0x2685971 VA: 0x2685870
	private void set_IsSingleRank(bool value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2BBC70 Offset: 0x2BBD71 VA: 0x2BBC70
	// RVA: 0x2685880 Offset: 0x2685981 VA: 0x2685880
	public byte get_JewelColorR() { }

	[CompilerGeneratedAttribute] // RVA: 0x2BBC80 Offset: 0x2BBD81 VA: 0x2BBC80
	// RVA: 0x2685890 Offset: 0x2685991 VA: 0x2685890
	private void set_JewelColorR(byte value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2BBC90 Offset: 0x2BBD91 VA: 0x2BBC90
	// RVA: 0x26858A0 Offset: 0x26859A1 VA: 0x26858A0
	public byte get_JewelColorG() { }

	[CompilerGeneratedAttribute] // RVA: 0x2BBCA0 Offset: 0x2BBDA1 VA: 0x2BBCA0
	// RVA: 0x26858B0 Offset: 0x26859B1 VA: 0x26858B0
	private void set_JewelColorG(byte value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2BBCB0 Offset: 0x2BBDB1 VA: 0x2BBCB0
	// RVA: 0x26858C0 Offset: 0x26859C1 VA: 0x26858C0
	public byte get_JewelColorB() { }

	[CompilerGeneratedAttribute] // RVA: 0x2BBCC0 Offset: 0x2BBDC1 VA: 0x2BBCC0
	// RVA: 0x26858D0 Offset: 0x26859D1 VA: 0x26858D0
	private void set_JewelColorB(byte value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2BBCD0 Offset: 0x2BBDD1 VA: 0x2BBCD0
	// RVA: 0x26858E0 Offset: 0x26859E1 VA: 0x26858E0
	public byte get_RimColorR() { }

	[CompilerGeneratedAttribute] // RVA: 0x2BBCE0 Offset: 0x2BBDE1 VA: 0x2BBCE0
	// RVA: 0x26858F0 Offset: 0x26859F1 VA: 0x26858F0
	private void set_RimColorR(byte value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2BBCF0 Offset: 0x2BBDF1 VA: 0x2BBCF0
	// RVA: 0x2685900 Offset: 0x2685A01 VA: 0x2685900
	public byte get_RimColorG() { }

	[CompilerGeneratedAttribute] // RVA: 0x2BBD00 Offset: 0x2BBE01 VA: 0x2BBD00
	// RVA: 0x2685910 Offset: 0x2685A11 VA: 0x2685910
	private void set_RimColorG(byte value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2BBD10 Offset: 0x2BBE11 VA: 0x2BBD10
	// RVA: 0x2685920 Offset: 0x2685A21 VA: 0x2685920
	public byte get_RimColorB() { }

	[CompilerGeneratedAttribute] // RVA: 0x2BBD20 Offset: 0x2BBE21 VA: 0x2BBD20
	// RVA: 0x2685930 Offset: 0x2685A31 VA: 0x2685930
	private void set_RimColorB(byte value) { }

	// RVA: 0x2685940 Offset: 0x2685A41 VA: 0x2685940
	public string get_Group() { }

	// RVA: 0x2685950 Offset: 0x2685A51 VA: 0x2685950
	public string get_FlagName() { }

	// RVA: 0x2685960 Offset: 0x2685A61 VA: 0x2685960
	public Color get_JewelColor() { }

	// RVA: 0x2685970 Offset: 0x2685A71 VA: 0x2685970
	public Color get_RimColor() { }

	// RVA: 0x2685980 Offset: 0x2685A81 VA: 0x2685980 Slot: 4
	public override void OnBuild() { }

	// RVA: 0x26862F0 Offset: 0x26863F1 VA: 0x26862F0
	private void CopyRingColor() { }

	// RVA: 0x26865C0 Offset: 0x26866C1 VA: 0x26865C0
	private void SetKind() { }

	// RVA: 0x2686630 Offset: 0x2686731 VA: 0x2686630 Slot: 7
	public override void OnRelease() { }

	// RVA: 0x26866F0 Offset: 0x26867F1 VA: 0x26866F0
	public string GetName() { }

	// RVA: 0x2686760 Offset: 0x2686861 VA: 0x2686760 Slot: 8
	public override string GetDebugName() { }

	// RVA: 0x2686770 Offset: 0x2686871 VA: 0x2686770
	public string GetFullName() { }

	// RVA: 0x2686920 Offset: 0x2686A21 VA: 0x2686920
	public RingData GetRareColorData() { }

	// RVA: 0x2686A90 Offset: 0x2686B91 VA: 0x2686A90
	public void SetProcurement() { }

	// RVA: 0x2686CD0 Offset: 0x2686DD1 VA: 0x2686CD0
	public bool IsProcurement() { }

	// RVA: 0x2686DC0 Offset: 0x2686EC1 VA: 0x2686DC0
	public static void RegistGlobalFlags() { }

	// RVA: 0x2687300 Offset: 0x2687401 VA: 0x2687300
	public string GetPrefabPath() { }

	// RVA: 0x2687340 Offset: 0x2687441 VA: 0x2687340
	private string GetPrefabPath(string gid) { }

	// RVA: 0x2687170 Offset: 0x2687271 VA: 0x2687170
	public static List<string> GetGodList() { }

	// RVA: 0x2687790 Offset: 0x2687891 VA: 0x2687790
	public static void Serialize(Stream stream, RingData ring) { }

	// RVA: 0x26877F0 Offset: 0x26878F1 VA: 0x26877F0
	public static RingData Deserialize(Stream stream) { }

	// RVA: 0x2687850 Offset: 0x2687951 VA: 0x2687850
	public static void TrySerialize(Stream stream, RingData ring) { }

	// RVA: 0x26878F0 Offset: 0x26879F1 VA: 0x26878F0
	public static RingData TryDeserialize(Stream stream) { }
}

