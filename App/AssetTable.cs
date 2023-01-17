// Namespace: App
[DebuggerDisplayAttribute] // RVA: 0x275EA0 Offset: 0x275FA1 VA: 0x275EA0
public class AssetTable : StructData<AssetTable> // TypeDefIndex: 9810
{
	// Fields
	private static List<string> s_PresetNames; // 0x0
	[CompilerGeneratedAttribute] // RVA: 0x287E30 Offset: 0x287F31 VA: 0x287E30
	private string <PresetName>k__BackingField; // 0x20
	[CompilerGeneratedAttribute] // RVA: 0x287E40 Offset: 0x287F41 VA: 0x287E40
	private AssetTable.Modes <Mode>k__BackingField; // 0x28
	[CompilerGeneratedAttribute] // RVA: 0x287E50 Offset: 0x287F51 VA: 0x287E50
	private string[] <Conditions>k__BackingField; // 0x30
	[CompilerGeneratedAttribute] // RVA: 0x287E60 Offset: 0x287F61 VA: 0x287E60
	private string <BodyModel>k__BackingField; // 0x38
	[CompilerGeneratedAttribute] // RVA: 0x287E70 Offset: 0x287F71 VA: 0x287E70
	private string <DressModel>k__BackingField; // 0x40
	[CompilerGeneratedAttribute] // RVA: 0x287E80 Offset: 0x287F81 VA: 0x287E80
	private string <HeadModel>k__BackingField; // 0x48
	[CompilerGeneratedAttribute] // RVA: 0x287E90 Offset: 0x287F91 VA: 0x287E90
	private string <HairModel>k__BackingField; // 0x50
	[CompilerGeneratedAttribute] // RVA: 0x287EA0 Offset: 0x287FA1 VA: 0x287EA0
	private string <RideModel>k__BackingField; // 0x58
	[CompilerGeneratedAttribute] // RVA: 0x287EB0 Offset: 0x287FB1 VA: 0x287EB0
	private string <RideDressModel>k__BackingField; // 0x60
	[CompilerGeneratedAttribute] // RVA: 0x287EC0 Offset: 0x287FC1 VA: 0x287EC0
	private string <LeftHand>k__BackingField; // 0x68
	[CompilerGeneratedAttribute] // RVA: 0x287ED0 Offset: 0x287FD1 VA: 0x287ED0
	private string <RightHand>k__BackingField; // 0x70
	[CompilerGeneratedAttribute] // RVA: 0x287EE0 Offset: 0x287FE1 VA: 0x287EE0
	private string <Trail>k__BackingField; // 0x78
	[CompilerGeneratedAttribute] // RVA: 0x287EF0 Offset: 0x287FF1 VA: 0x287EF0
	private string <Magic>k__BackingField; // 0x80
	[CompilerGeneratedAttribute] // RVA: 0x287F00 Offset: 0x288001 VA: 0x287F00
	private string <BodyAnim>k__BackingField; // 0x88
	[CompilerGeneratedAttribute] // RVA: 0x287F10 Offset: 0x288011 VA: 0x287F10
	private string <RideAnim>k__BackingField; // 0x90
	[CompilerGeneratedAttribute] // RVA: 0x287F20 Offset: 0x288021 VA: 0x287F20
	private string <InfoAnim>k__BackingField; // 0x98
	[CompilerGeneratedAttribute] // RVA: 0x287F30 Offset: 0x288031 VA: 0x287F30
	private string <TalkAnim>k__BackingField; // 0xA0
	[CompilerGeneratedAttribute] // RVA: 0x287F40 Offset: 0x288041 VA: 0x287F40
	private string <DemoAnim>k__BackingField; // 0xA8
	[CompilerGeneratedAttribute] // RVA: 0x287F50 Offset: 0x288051 VA: 0x287F50
	private string <HubAnim>k__BackingField; // 0xB0
	[CompilerGeneratedAttribute] // RVA: 0x287F60 Offset: 0x288061 VA: 0x287F60
	private byte <HairR>k__BackingField; // 0xB8
	[CompilerGeneratedAttribute] // RVA: 0x287F70 Offset: 0x288071 VA: 0x287F70
	private byte <HairG>k__BackingField; // 0xB9
	[CompilerGeneratedAttribute] // RVA: 0x287F80 Offset: 0x288081 VA: 0x287F80
	private byte <HairB>k__BackingField; // 0xBA
	[CompilerGeneratedAttribute] // RVA: 0x287F90 Offset: 0x288091 VA: 0x287F90
	private byte <GradR>k__BackingField; // 0xBB
	[CompilerGeneratedAttribute] // RVA: 0x287FA0 Offset: 0x2880A1 VA: 0x287FA0
	private byte <GradG>k__BackingField; // 0xBC
	[CompilerGeneratedAttribute] // RVA: 0x287FB0 Offset: 0x2880B1 VA: 0x287FB0
	private byte <GradB>k__BackingField; // 0xBD
	[CompilerGeneratedAttribute] // RVA: 0x287FC0 Offset: 0x2880C1 VA: 0x287FC0
	private byte <SkinR>k__BackingField; // 0xBE
	[CompilerGeneratedAttribute] // RVA: 0x287FD0 Offset: 0x2880D1 VA: 0x287FD0
	private byte <SkinG>k__BackingField; // 0xBF
	[CompilerGeneratedAttribute] // RVA: 0x287FE0 Offset: 0x2880E1 VA: 0x287FE0
	private byte <SkinB>k__BackingField; // 0xC0
	[CompilerGeneratedAttribute] // RVA: 0x287FF0 Offset: 0x2880F1 VA: 0x287FF0
	private byte <ToonR>k__BackingField; // 0xC1
	[CompilerGeneratedAttribute] // RVA: 0x288000 Offset: 0x288101 VA: 0x288000
	private byte <ToonG>k__BackingField; // 0xC2
	[CompilerGeneratedAttribute] // RVA: 0x288010 Offset: 0x288111 VA: 0x288010
	private byte <ToonB>k__BackingField; // 0xC3
	[CompilerGeneratedAttribute] // RVA: 0x288020 Offset: 0x288121 VA: 0x288020
	private byte <MaskColor100R>k__BackingField; // 0xC4
	[CompilerGeneratedAttribute] // RVA: 0x288030 Offset: 0x288131 VA: 0x288030
	private byte <MaskColor100G>k__BackingField; // 0xC5
	[CompilerGeneratedAttribute] // RVA: 0x288040 Offset: 0x288141 VA: 0x288040
	private byte <MaskColor100B>k__BackingField; // 0xC6
	[CompilerGeneratedAttribute] // RVA: 0x288050 Offset: 0x288151 VA: 0x288050
	private byte <MaskColor075R>k__BackingField; // 0xC7
	[CompilerGeneratedAttribute] // RVA: 0x288060 Offset: 0x288161 VA: 0x288060
	private byte <MaskColor075G>k__BackingField; // 0xC8
	[CompilerGeneratedAttribute] // RVA: 0x288070 Offset: 0x288171 VA: 0x288070
	private byte <MaskColor075B>k__BackingField; // 0xC9
	[CompilerGeneratedAttribute] // RVA: 0x288080 Offset: 0x288181 VA: 0x288080
	private byte <MaskColor050R>k__BackingField; // 0xCA
	[CompilerGeneratedAttribute] // RVA: 0x288090 Offset: 0x288191 VA: 0x288090
	private byte <MaskColor050G>k__BackingField; // 0xCB
	[CompilerGeneratedAttribute] // RVA: 0x2880A0 Offset: 0x2881A1 VA: 0x2880A0
	private byte <MaskColor050B>k__BackingField; // 0xCC
	[CompilerGeneratedAttribute] // RVA: 0x2880B0 Offset: 0x2881B1 VA: 0x2880B0
	private byte <MaskColor025R>k__BackingField; // 0xCD
	[CompilerGeneratedAttribute] // RVA: 0x2880C0 Offset: 0x2881C1 VA: 0x2880C0
	private byte <MaskColor025G>k__BackingField; // 0xCE
	[CompilerGeneratedAttribute] // RVA: 0x2880D0 Offset: 0x2881D1 VA: 0x2880D0
	private byte <MaskColor025B>k__BackingField; // 0xCF
	public Color HairColor; // 0xD0
	public Color GradColor; // 0xE0
	public Color SkinColor; // 0xF0
	public Color ToonShadowColor; // 0x100
	public Color MaskColor100; // 0x110
	public Color MaskColor075; // 0x120
	public Color MaskColor050; // 0x130
	public Color MaskColor025; // 0x140
	[CompilerGeneratedAttribute] // RVA: 0x2880E0 Offset: 0x2881E1 VA: 0x2880E0
	private AssetTable.Accessory <Acc1>k__BackingField; // 0x150
	[CompilerGeneratedAttribute] // RVA: 0x2880F0 Offset: 0x2881F1 VA: 0x2880F0
	private AssetTable.Accessory <Acc2>k__BackingField; // 0x158
	[CompilerGeneratedAttribute] // RVA: 0x288100 Offset: 0x288201 VA: 0x288100
	private AssetTable.Accessory <Acc3>k__BackingField; // 0x160
	[CompilerGeneratedAttribute] // RVA: 0x288110 Offset: 0x288211 VA: 0x288110
	private AssetTable.Accessory <Acc4>k__BackingField; // 0x168
	[CompilerGeneratedAttribute] // RVA: 0x288120 Offset: 0x288221 VA: 0x288120
	private AssetTable.Accessory <Acc5>k__BackingField; // 0x170
	[CompilerGeneratedAttribute] // RVA: 0x288130 Offset: 0x288231 VA: 0x288130
	private AssetTable.Accessory <Acc6>k__BackingField; // 0x178
	[CompilerGeneratedAttribute] // RVA: 0x288140 Offset: 0x288241 VA: 0x288140
	private AssetTable.Accessory <Acc7>k__BackingField; // 0x180
	[CompilerGeneratedAttribute] // RVA: 0x288150 Offset: 0x288251 VA: 0x288150
	private AssetTable.Accessory <Acc8>k__BackingField; // 0x188
	[CompilerGeneratedAttribute] // RVA: 0x288160 Offset: 0x288261 VA: 0x288160
	private AssetTable.AccessoryList <Accessories>k__BackingField; // 0x190
	[CompilerGeneratedAttribute] // RVA: 0x288170 Offset: 0x288271 VA: 0x288170
	private float <ScaleAll>k__BackingField; // 0x198
	[CompilerGeneratedAttribute] // RVA: 0x288180 Offset: 0x288281 VA: 0x288180
	private float <ScaleHead>k__BackingField; // 0x19C
	[CompilerGeneratedAttribute] // RVA: 0x288190 Offset: 0x288291 VA: 0x288190
	private float <ScaleNeck>k__BackingField; // 0x1A0
	[CompilerGeneratedAttribute] // RVA: 0x2881A0 Offset: 0x2882A1 VA: 0x2881A0
	private float <ScaleTorso>k__BackingField; // 0x1A4
	[CompilerGeneratedAttribute] // RVA: 0x2881B0 Offset: 0x2882B1 VA: 0x2881B0
	private float <ScaleShoulders>k__BackingField; // 0x1A8
	[CompilerGeneratedAttribute] // RVA: 0x2881C0 Offset: 0x2882C1 VA: 0x2881C0
	private float <ScaleArms>k__BackingField; // 0x1AC
	[CompilerGeneratedAttribute] // RVA: 0x2881D0 Offset: 0x2882D1 VA: 0x2881D0
	private float <ScaleHands>k__BackingField; // 0x1B0
	[CompilerGeneratedAttribute] // RVA: 0x2881E0 Offset: 0x2882E1 VA: 0x2881E0
	private float <ScaleLegs>k__BackingField; // 0x1B4
	[CompilerGeneratedAttribute] // RVA: 0x2881F0 Offset: 0x2882F1 VA: 0x2881F0
	private float <ScaleFeet>k__BackingField; // 0x1B8
	[CompilerGeneratedAttribute] // RVA: 0x288200 Offset: 0x288301 VA: 0x288200
	private float <VolumeArms>k__BackingField; // 0x1BC
	[CompilerGeneratedAttribute] // RVA: 0x288210 Offset: 0x288311 VA: 0x288210
	private float <VolumeLegs>k__BackingField; // 0x1C0
	[CompilerGeneratedAttribute] // RVA: 0x288220 Offset: 0x288321 VA: 0x288220
	private float <VolumeBust>k__BackingField; // 0x1C4
	[CompilerGeneratedAttribute] // RVA: 0x288230 Offset: 0x288331 VA: 0x288230
	private float <VolumeAbdomen>k__BackingField; // 0x1C8
	[CompilerGeneratedAttribute] // RVA: 0x288240 Offset: 0x288341 VA: 0x288240
	private float <VolumeTorso>k__BackingField; // 0x1CC
	[CompilerGeneratedAttribute] // RVA: 0x288250 Offset: 0x288351 VA: 0x288250
	private float <VolumeScaleArms>k__BackingField; // 0x1D0
	[CompilerGeneratedAttribute] // RVA: 0x288260 Offset: 0x288361 VA: 0x288260
	private float <VolumeScaleLegs>k__BackingField; // 0x1D4
	[CompilerGeneratedAttribute] // RVA: 0x288270 Offset: 0x288371 VA: 0x288270
	private float <MapScaleAll>k__BackingField; // 0x1D8
	[CompilerGeneratedAttribute] // RVA: 0x288280 Offset: 0x288381 VA: 0x288280
	private float <MapScaleHead>k__BackingField; // 0x1DC
	[CompilerGeneratedAttribute] // RVA: 0x288290 Offset: 0x288391 VA: 0x288290
	private float <MapScaleWing>k__BackingField; // 0x1E0
	[CompilerGeneratedAttribute] // RVA: 0x2882A0 Offset: 0x2883A1 VA: 0x2882A0
	private string <Voice>k__BackingField; // 0x1E8
	[CompilerGeneratedAttribute] // RVA: 0x2882B0 Offset: 0x2883B1 VA: 0x2882B0
	private string <FootStep>k__BackingField; // 0x1F0
	[CompilerGeneratedAttribute] // RVA: 0x2882C0 Offset: 0x2883C1 VA: 0x2882C0
	private string <Material>k__BackingField; // 0x1F8
	[CompilerGeneratedAttribute] // RVA: 0x2882D0 Offset: 0x2883D1 VA: 0x2882D0
	private string <Comment>k__BackingField; // 0x200
	private AssetTable.ConditionIndexes m_ConditionIndexes; // 0x208
	private const int BitCount = 2048;
	private static List<AssetTable>[] s_SearchLists; // 0x8
	private static Dictionary<string, int> s_ConditionIndexes; // 0x10
	private static AssetTable.ConditionFlags s_ConditionFlags; // 0x18
	public static readonly AssetTable.Sound NullSound; // 0x20
	public static readonly Color NullColor; // 0x38
	public static AssetTable.Result Shared; // 0x48

	// Properties
	public static string[] PresetNames { get; }
	public string PresetName { get; set; }
	public AssetTable.Modes Mode { get; set; }
	public string[] Conditions { get; set; }
	public string BodyModel { get; set; }
	public string DressModel { get; set; }
	public string HeadModel { get; set; }
	public string HairModel { get; set; }
	public string RideModel { get; set; }
	public string RideDressModel { get; set; }
	public string LeftHand { get; set; }
	public string RightHand { get; set; }
	public string Trail { get; set; }
	public string Magic { get; set; }
	public string BodyAnim { get; set; }
	public string RideAnim { get; set; }
	public string InfoAnim { get; set; }
	public string TalkAnim { get; set; }
	public string DemoAnim { get; set; }
	public string HubAnim { get; set; }
	public byte HairR { get; set; }
	public byte HairG { get; set; }
	public byte HairB { get; set; }
	public byte GradR { get; set; }
	public byte GradG { get; set; }
	public byte GradB { get; set; }
	public byte SkinR { get; set; }
	public byte SkinG { get; set; }
	public byte SkinB { get; set; }
	public byte ToonR { get; set; }
	public byte ToonG { get; set; }
	public byte ToonB { get; set; }
	public byte MaskColor100R { get; set; }
	public byte MaskColor100G { get; set; }
	public byte MaskColor100B { get; set; }
	public byte MaskColor075R { get; set; }
	public byte MaskColor075G { get; set; }
	public byte MaskColor075B { get; set; }
	public byte MaskColor050R { get; set; }
	public byte MaskColor050G { get; set; }
	public byte MaskColor050B { get; set; }
	public byte MaskColor025R { get; set; }
	public byte MaskColor025G { get; set; }
	public byte MaskColor025B { get; set; }
	public AssetTable.Accessory Acc1 { get; set; }
	public AssetTable.Accessory Acc2 { get; set; }
	public AssetTable.Accessory Acc3 { get; set; }
	public AssetTable.Accessory Acc4 { get; set; }
	public AssetTable.Accessory Acc5 { get; set; }
	public AssetTable.Accessory Acc6 { get; set; }
	public AssetTable.Accessory Acc7 { get; set; }
	public AssetTable.Accessory Acc8 { get; set; }
	public AssetTable.AccessoryList Accessories { get; set; }
	public float ScaleAll { get; set; }
	public float ScaleHead { get; set; }
	public float ScaleNeck { get; set; }
	public float ScaleTorso { get; set; }
	public float ScaleShoulders { get; set; }
	public float ScaleArms { get; set; }
	public float ScaleHands { get; set; }
	public float ScaleLegs { get; set; }
	public float ScaleFeet { get; set; }
	public float VolumeArms { get; set; }
	public float VolumeLegs { get; set; }
	public float VolumeBust { get; set; }
	public float VolumeAbdomen { get; set; }
	public float VolumeTorso { get; set; }
	public float VolumeScaleArms { get; set; }
	public float VolumeScaleLegs { get; set; }
	public float MapScaleAll { get; set; }
	public float MapScaleHead { get; set; }
	public float MapScaleWing { get; set; }
	public string Voice { get; set; }
	public string FootStep { get; set; }
	public string Material { get; set; }
	public string Comment { get; set; }
	public static List<string> ConditionNames { get; }
	public static List<int> ConditionHits { get; }

	// Methods

	// RVA: 0x260C7A0 Offset: 0x260C8A1 VA: 0x260C7A0
	private string DebuggerDisplay() { }

	// RVA: 0x260C910 Offset: 0x260CA11 VA: 0x260C910
	public static void Load() { }

	// RVA: 0x260C9C0 Offset: 0x260CAC1 VA: 0x260C9C0
	public static string[] get_PresetNames() { }

	[CompilerGeneratedAttribute] // RVA: 0x2B1AB0 Offset: 0x2B1BB1 VA: 0x2B1AB0
	// RVA: 0x260CA40 Offset: 0x260CB41 VA: 0x260CA40
	public string get_PresetName() { }

	[CompilerGeneratedAttribute] // RVA: 0x2B1AC0 Offset: 0x2B1BC1 VA: 0x2B1AC0
	// RVA: 0x260CA50 Offset: 0x260CB51 VA: 0x260CA50
	private void set_PresetName(string value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2B1AD0 Offset: 0x2B1BD1 VA: 0x2B1AD0
	// RVA: 0x260CA60 Offset: 0x260CB61 VA: 0x260CA60
	public AssetTable.Modes get_Mode() { }

	[CompilerGeneratedAttribute] // RVA: 0x2B1AE0 Offset: 0x2B1BE1 VA: 0x2B1AE0
	// RVA: 0x260CA70 Offset: 0x260CB71 VA: 0x260CA70
	private void set_Mode(AssetTable.Modes value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2B1AF0 Offset: 0x2B1BF1 VA: 0x2B1AF0
	// RVA: 0x260CA80 Offset: 0x260CB81 VA: 0x260CA80
	public string[] get_Conditions() { }

	[CompilerGeneratedAttribute] // RVA: 0x2B1B00 Offset: 0x2B1C01 VA: 0x2B1B00
	// RVA: 0x260CA90 Offset: 0x260CB91 VA: 0x260CA90
	private void set_Conditions(string[] value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2B1B10 Offset: 0x2B1C11 VA: 0x2B1B10
	// RVA: 0x260CAA0 Offset: 0x260CBA1 VA: 0x260CAA0
	public string get_BodyModel() { }

	[CompilerGeneratedAttribute] // RVA: 0x2B1B20 Offset: 0x2B1C21 VA: 0x2B1B20
	// RVA: 0x260CAB0 Offset: 0x260CBB1 VA: 0x260CAB0
	private void set_BodyModel(string value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2B1B30 Offset: 0x2B1C31 VA: 0x2B1B30
	// RVA: 0x260CAC0 Offset: 0x260CBC1 VA: 0x260CAC0
	public string get_DressModel() { }

	[CompilerGeneratedAttribute] // RVA: 0x2B1B40 Offset: 0x2B1C41 VA: 0x2B1B40
	// RVA: 0x260CAD0 Offset: 0x260CBD1 VA: 0x260CAD0
	private void set_DressModel(string value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2B1B50 Offset: 0x2B1C51 VA: 0x2B1B50
	// RVA: 0x260CAE0 Offset: 0x260CBE1 VA: 0x260CAE0
	public string get_HeadModel() { }

	[CompilerGeneratedAttribute] // RVA: 0x2B1B60 Offset: 0x2B1C61 VA: 0x2B1B60
	// RVA: 0x260CAF0 Offset: 0x260CBF1 VA: 0x260CAF0
	private void set_HeadModel(string value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2B1B70 Offset: 0x2B1C71 VA: 0x2B1B70
	// RVA: 0x260CB00 Offset: 0x260CC01 VA: 0x260CB00
	public string get_HairModel() { }

	[CompilerGeneratedAttribute] // RVA: 0x2B1B80 Offset: 0x2B1C81 VA: 0x2B1B80
	// RVA: 0x260CB10 Offset: 0x260CC11 VA: 0x260CB10
	private void set_HairModel(string value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2B1B90 Offset: 0x2B1C91 VA: 0x2B1B90
	// RVA: 0x260CB20 Offset: 0x260CC21 VA: 0x260CB20
	public string get_RideModel() { }

	[CompilerGeneratedAttribute] // RVA: 0x2B1BA0 Offset: 0x2B1CA1 VA: 0x2B1BA0
	// RVA: 0x260CB30 Offset: 0x260CC31 VA: 0x260CB30
	private void set_RideModel(string value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2B1BB0 Offset: 0x2B1CB1 VA: 0x2B1BB0
	// RVA: 0x260CB40 Offset: 0x260CC41 VA: 0x260CB40
	public string get_RideDressModel() { }

	[CompilerGeneratedAttribute] // RVA: 0x2B1BC0 Offset: 0x2B1CC1 VA: 0x2B1BC0
	// RVA: 0x260CB50 Offset: 0x260CC51 VA: 0x260CB50
	private void set_RideDressModel(string value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2B1BD0 Offset: 0x2B1CD1 VA: 0x2B1BD0
	// RVA: 0x260CB60 Offset: 0x260CC61 VA: 0x260CB60
	public string get_LeftHand() { }

	[CompilerGeneratedAttribute] // RVA: 0x2B1BE0 Offset: 0x2B1CE1 VA: 0x2B1BE0
	// RVA: 0x260CB70 Offset: 0x260CC71 VA: 0x260CB70
	private void set_LeftHand(string value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2B1BF0 Offset: 0x2B1CF1 VA: 0x2B1BF0
	// RVA: 0x260CB80 Offset: 0x260CC81 VA: 0x260CB80
	public string get_RightHand() { }

	[CompilerGeneratedAttribute] // RVA: 0x2B1C00 Offset: 0x2B1D01 VA: 0x2B1C00
	// RVA: 0x260CB90 Offset: 0x260CC91 VA: 0x260CB90
	private void set_RightHand(string value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2B1C10 Offset: 0x2B1D11 VA: 0x2B1C10
	// RVA: 0x260CBA0 Offset: 0x260CCA1 VA: 0x260CBA0
	public string get_Trail() { }

	[CompilerGeneratedAttribute] // RVA: 0x2B1C20 Offset: 0x2B1D21 VA: 0x2B1C20
	// RVA: 0x260CBB0 Offset: 0x260CCB1 VA: 0x260CBB0
	private void set_Trail(string value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2B1C30 Offset: 0x2B1D31 VA: 0x2B1C30
	// RVA: 0x260CBC0 Offset: 0x260CCC1 VA: 0x260CBC0
	public string get_Magic() { }

	[CompilerGeneratedAttribute] // RVA: 0x2B1C40 Offset: 0x2B1D41 VA: 0x2B1C40
	// RVA: 0x260CBD0 Offset: 0x260CCD1 VA: 0x260CBD0
	private void set_Magic(string value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2B1C50 Offset: 0x2B1D51 VA: 0x2B1C50
	// RVA: 0x260CBE0 Offset: 0x260CCE1 VA: 0x260CBE0
	public string get_BodyAnim() { }

	[CompilerGeneratedAttribute] // RVA: 0x2B1C60 Offset: 0x2B1D61 VA: 0x2B1C60
	// RVA: 0x260CBF0 Offset: 0x260CCF1 VA: 0x260CBF0
	private void set_BodyAnim(string value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2B1C70 Offset: 0x2B1D71 VA: 0x2B1C70
	// RVA: 0x260CC00 Offset: 0x260CD01 VA: 0x260CC00
	public string get_RideAnim() { }

	[CompilerGeneratedAttribute] // RVA: 0x2B1C80 Offset: 0x2B1D81 VA: 0x2B1C80
	// RVA: 0x260CC10 Offset: 0x260CD11 VA: 0x260CC10
	private void set_RideAnim(string value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2B1C90 Offset: 0x2B1D91 VA: 0x2B1C90
	// RVA: 0x260CC20 Offset: 0x260CD21 VA: 0x260CC20
	public string get_InfoAnim() { }

	[CompilerGeneratedAttribute] // RVA: 0x2B1CA0 Offset: 0x2B1DA1 VA: 0x2B1CA0
	// RVA: 0x260CC30 Offset: 0x260CD31 VA: 0x260CC30
	private void set_InfoAnim(string value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2B1CB0 Offset: 0x2B1DB1 VA: 0x2B1CB0
	// RVA: 0x260CC40 Offset: 0x260CD41 VA: 0x260CC40
	public string get_TalkAnim() { }

	[CompilerGeneratedAttribute] // RVA: 0x2B1CC0 Offset: 0x2B1DC1 VA: 0x2B1CC0
	// RVA: 0x260CC50 Offset: 0x260CD51 VA: 0x260CC50
	private void set_TalkAnim(string value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2B1CD0 Offset: 0x2B1DD1 VA: 0x2B1CD0
	// RVA: 0x260CC60 Offset: 0x260CD61 VA: 0x260CC60
	public string get_DemoAnim() { }

	[CompilerGeneratedAttribute] // RVA: 0x2B1CE0 Offset: 0x2B1DE1 VA: 0x2B1CE0
	// RVA: 0x260CC70 Offset: 0x260CD71 VA: 0x260CC70
	private void set_DemoAnim(string value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2B1CF0 Offset: 0x2B1DF1 VA: 0x2B1CF0
	// RVA: 0x260CC80 Offset: 0x260CD81 VA: 0x260CC80
	public string get_HubAnim() { }

	[CompilerGeneratedAttribute] // RVA: 0x2B1D00 Offset: 0x2B1E01 VA: 0x2B1D00
	// RVA: 0x260CC90 Offset: 0x260CD91 VA: 0x260CC90
	private void set_HubAnim(string value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2B1D10 Offset: 0x2B1E11 VA: 0x2B1D10
	// RVA: 0x260CCA0 Offset: 0x260CDA1 VA: 0x260CCA0
	public byte get_HairR() { }

	[CompilerGeneratedAttribute] // RVA: 0x2B1D20 Offset: 0x2B1E21 VA: 0x2B1D20
	// RVA: 0x260CCB0 Offset: 0x260CDB1 VA: 0x260CCB0
	private void set_HairR(byte value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2B1D30 Offset: 0x2B1E31 VA: 0x2B1D30
	// RVA: 0x260CCC0 Offset: 0x260CDC1 VA: 0x260CCC0
	public byte get_HairG() { }

	[CompilerGeneratedAttribute] // RVA: 0x2B1D40 Offset: 0x2B1E41 VA: 0x2B1D40
	// RVA: 0x260CCD0 Offset: 0x260CDD1 VA: 0x260CCD0
	private void set_HairG(byte value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2B1D50 Offset: 0x2B1E51 VA: 0x2B1D50
	// RVA: 0x260CCE0 Offset: 0x260CDE1 VA: 0x260CCE0
	public byte get_HairB() { }

	[CompilerGeneratedAttribute] // RVA: 0x2B1D60 Offset: 0x2B1E61 VA: 0x2B1D60
	// RVA: 0x260CCF0 Offset: 0x260CDF1 VA: 0x260CCF0
	private void set_HairB(byte value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2B1D70 Offset: 0x2B1E71 VA: 0x2B1D70
	// RVA: 0x260CD00 Offset: 0x260CE01 VA: 0x260CD00
	public byte get_GradR() { }

	[CompilerGeneratedAttribute] // RVA: 0x2B1D80 Offset: 0x2B1E81 VA: 0x2B1D80
	// RVA: 0x260CD10 Offset: 0x260CE11 VA: 0x260CD10
	private void set_GradR(byte value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2B1D90 Offset: 0x2B1E91 VA: 0x2B1D90
	// RVA: 0x260CD20 Offset: 0x260CE21 VA: 0x260CD20
	public byte get_GradG() { }

	[CompilerGeneratedAttribute] // RVA: 0x2B1DA0 Offset: 0x2B1EA1 VA: 0x2B1DA0
	// RVA: 0x260CD30 Offset: 0x260CE31 VA: 0x260CD30
	private void set_GradG(byte value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2B1DB0 Offset: 0x2B1EB1 VA: 0x2B1DB0
	// RVA: 0x260CD40 Offset: 0x260CE41 VA: 0x260CD40
	public byte get_GradB() { }

	[CompilerGeneratedAttribute] // RVA: 0x2B1DC0 Offset: 0x2B1EC1 VA: 0x2B1DC0
	// RVA: 0x260CD50 Offset: 0x260CE51 VA: 0x260CD50
	private void set_GradB(byte value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2B1DD0 Offset: 0x2B1ED1 VA: 0x2B1DD0
	// RVA: 0x260CD60 Offset: 0x260CE61 VA: 0x260CD60
	public byte get_SkinR() { }

	[CompilerGeneratedAttribute] // RVA: 0x2B1DE0 Offset: 0x2B1EE1 VA: 0x2B1DE0
	// RVA: 0x260CD70 Offset: 0x260CE71 VA: 0x260CD70
	private void set_SkinR(byte value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2B1DF0 Offset: 0x2B1EF1 VA: 0x2B1DF0
	// RVA: 0x260CD80 Offset: 0x260CE81 VA: 0x260CD80
	public byte get_SkinG() { }

	[CompilerGeneratedAttribute] // RVA: 0x2B1E00 Offset: 0x2B1F01 VA: 0x2B1E00
	// RVA: 0x260CD90 Offset: 0x260CE91 VA: 0x260CD90
	private void set_SkinG(byte value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2B1E10 Offset: 0x2B1F11 VA: 0x2B1E10
	// RVA: 0x260CDA0 Offset: 0x260CEA1 VA: 0x260CDA0
	public byte get_SkinB() { }

	[CompilerGeneratedAttribute] // RVA: 0x2B1E20 Offset: 0x2B1F21 VA: 0x2B1E20
	// RVA: 0x260CDB0 Offset: 0x260CEB1 VA: 0x260CDB0
	private void set_SkinB(byte value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2B1E30 Offset: 0x2B1F31 VA: 0x2B1E30
	// RVA: 0x260CDC0 Offset: 0x260CEC1 VA: 0x260CDC0
	public byte get_ToonR() { }

	[CompilerGeneratedAttribute] // RVA: 0x2B1E40 Offset: 0x2B1F41 VA: 0x2B1E40
	// RVA: 0x260CDD0 Offset: 0x260CED1 VA: 0x260CDD0
	private void set_ToonR(byte value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2B1E50 Offset: 0x2B1F51 VA: 0x2B1E50
	// RVA: 0x260CDE0 Offset: 0x260CEE1 VA: 0x260CDE0
	public byte get_ToonG() { }

	[CompilerGeneratedAttribute] // RVA: 0x2B1E60 Offset: 0x2B1F61 VA: 0x2B1E60
	// RVA: 0x260CDF0 Offset: 0x260CEF1 VA: 0x260CDF0
	private void set_ToonG(byte value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2B1E70 Offset: 0x2B1F71 VA: 0x2B1E70
	// RVA: 0x260CE00 Offset: 0x260CF01 VA: 0x260CE00
	public byte get_ToonB() { }

	[CompilerGeneratedAttribute] // RVA: 0x2B1E80 Offset: 0x2B1F81 VA: 0x2B1E80
	// RVA: 0x260CE10 Offset: 0x260CF11 VA: 0x260CE10
	private void set_ToonB(byte value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2B1E90 Offset: 0x2B1F91 VA: 0x2B1E90
	// RVA: 0x260CE20 Offset: 0x260CF21 VA: 0x260CE20
	public byte get_MaskColor100R() { }

	[CompilerGeneratedAttribute] // RVA: 0x2B1EA0 Offset: 0x2B1FA1 VA: 0x2B1EA0
	// RVA: 0x260CE30 Offset: 0x260CF31 VA: 0x260CE30
	private void set_MaskColor100R(byte value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2B1EB0 Offset: 0x2B1FB1 VA: 0x2B1EB0
	// RVA: 0x260CE40 Offset: 0x260CF41 VA: 0x260CE40
	public byte get_MaskColor100G() { }

	[CompilerGeneratedAttribute] // RVA: 0x2B1EC0 Offset: 0x2B1FC1 VA: 0x2B1EC0
	// RVA: 0x260CE50 Offset: 0x260CF51 VA: 0x260CE50
	private void set_MaskColor100G(byte value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2B1ED0 Offset: 0x2B1FD1 VA: 0x2B1ED0
	// RVA: 0x260CE60 Offset: 0x260CF61 VA: 0x260CE60
	public byte get_MaskColor100B() { }

	[CompilerGeneratedAttribute] // RVA: 0x2B1EE0 Offset: 0x2B1FE1 VA: 0x2B1EE0
	// RVA: 0x260CE70 Offset: 0x260CF71 VA: 0x260CE70
	private void set_MaskColor100B(byte value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2B1EF0 Offset: 0x2B1FF1 VA: 0x2B1EF0
	// RVA: 0x260CE80 Offset: 0x260CF81 VA: 0x260CE80
	public byte get_MaskColor075R() { }

	[CompilerGeneratedAttribute] // RVA: 0x2B1F00 Offset: 0x2B2001 VA: 0x2B1F00
	// RVA: 0x260CE90 Offset: 0x260CF91 VA: 0x260CE90
	private void set_MaskColor075R(byte value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2B1F10 Offset: 0x2B2011 VA: 0x2B1F10
	// RVA: 0x260CEA0 Offset: 0x260CFA1 VA: 0x260CEA0
	public byte get_MaskColor075G() { }

	[CompilerGeneratedAttribute] // RVA: 0x2B1F20 Offset: 0x2B2021 VA: 0x2B1F20
	// RVA: 0x260CEB0 Offset: 0x260CFB1 VA: 0x260CEB0
	private void set_MaskColor075G(byte value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2B1F30 Offset: 0x2B2031 VA: 0x2B1F30
	// RVA: 0x260CEC0 Offset: 0x260CFC1 VA: 0x260CEC0
	public byte get_MaskColor075B() { }

	[CompilerGeneratedAttribute] // RVA: 0x2B1F40 Offset: 0x2B2041 VA: 0x2B1F40
	// RVA: 0x260CED0 Offset: 0x260CFD1 VA: 0x260CED0
	private void set_MaskColor075B(byte value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2B1F50 Offset: 0x2B2051 VA: 0x2B1F50
	// RVA: 0x260CEE0 Offset: 0x260CFE1 VA: 0x260CEE0
	public byte get_MaskColor050R() { }

	[CompilerGeneratedAttribute] // RVA: 0x2B1F60 Offset: 0x2B2061 VA: 0x2B1F60
	// RVA: 0x260CEF0 Offset: 0x260CFF1 VA: 0x260CEF0
	private void set_MaskColor050R(byte value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2B1F70 Offset: 0x2B2071 VA: 0x2B1F70
	// RVA: 0x260CF00 Offset: 0x260D001 VA: 0x260CF00
	public byte get_MaskColor050G() { }

	[CompilerGeneratedAttribute] // RVA: 0x2B1F80 Offset: 0x2B2081 VA: 0x2B1F80
	// RVA: 0x260CF10 Offset: 0x260D011 VA: 0x260CF10
	private void set_MaskColor050G(byte value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2B1F90 Offset: 0x2B2091 VA: 0x2B1F90
	// RVA: 0x260CF20 Offset: 0x260D021 VA: 0x260CF20
	public byte get_MaskColor050B() { }

	[CompilerGeneratedAttribute] // RVA: 0x2B1FA0 Offset: 0x2B20A1 VA: 0x2B1FA0
	// RVA: 0x260CF30 Offset: 0x260D031 VA: 0x260CF30
	private void set_MaskColor050B(byte value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2B1FB0 Offset: 0x2B20B1 VA: 0x2B1FB0
	// RVA: 0x260CF40 Offset: 0x260D041 VA: 0x260CF40
	public byte get_MaskColor025R() { }

	[CompilerGeneratedAttribute] // RVA: 0x2B1FC0 Offset: 0x2B20C1 VA: 0x2B1FC0
	// RVA: 0x260CF50 Offset: 0x260D051 VA: 0x260CF50
	private void set_MaskColor025R(byte value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2B1FD0 Offset: 0x2B20D1 VA: 0x2B1FD0
	// RVA: 0x260CF60 Offset: 0x260D061 VA: 0x260CF60
	public byte get_MaskColor025G() { }

	[CompilerGeneratedAttribute] // RVA: 0x2B1FE0 Offset: 0x2B20E1 VA: 0x2B1FE0
	// RVA: 0x260CF70 Offset: 0x260D071 VA: 0x260CF70
	private void set_MaskColor025G(byte value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2B1FF0 Offset: 0x2B20F1 VA: 0x2B1FF0
	// RVA: 0x260CF80 Offset: 0x260D081 VA: 0x260CF80
	public byte get_MaskColor025B() { }

	[CompilerGeneratedAttribute] // RVA: 0x2B2000 Offset: 0x2B2101 VA: 0x2B2000
	// RVA: 0x260CF90 Offset: 0x260D091 VA: 0x260CF90
	private void set_MaskColor025B(byte value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2B2010 Offset: 0x2B2111 VA: 0x2B2010
	// RVA: 0x260CFA0 Offset: 0x260D0A1 VA: 0x260CFA0
	public AssetTable.Accessory get_Acc1() { }

	[CompilerGeneratedAttribute] // RVA: 0x2B2020 Offset: 0x2B2121 VA: 0x2B2020
	// RVA: 0x260CFB0 Offset: 0x260D0B1 VA: 0x260CFB0
	private void set_Acc1(AssetTable.Accessory value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2B2030 Offset: 0x2B2131 VA: 0x2B2030
	// RVA: 0x260CFC0 Offset: 0x260D0C1 VA: 0x260CFC0
	public AssetTable.Accessory get_Acc2() { }

	[CompilerGeneratedAttribute] // RVA: 0x2B2040 Offset: 0x2B2141 VA: 0x2B2040
	// RVA: 0x260CFD0 Offset: 0x260D0D1 VA: 0x260CFD0
	private void set_Acc2(AssetTable.Accessory value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2B2050 Offset: 0x2B2151 VA: 0x2B2050
	// RVA: 0x260CFE0 Offset: 0x260D0E1 VA: 0x260CFE0
	public AssetTable.Accessory get_Acc3() { }

	[CompilerGeneratedAttribute] // RVA: 0x2B2060 Offset: 0x2B2161 VA: 0x2B2060
	// RVA: 0x260CFF0 Offset: 0x260D0F1 VA: 0x260CFF0
	private void set_Acc3(AssetTable.Accessory value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2B2070 Offset: 0x2B2171 VA: 0x2B2070
	// RVA: 0x260D000 Offset: 0x260D101 VA: 0x260D000
	public AssetTable.Accessory get_Acc4() { }

	[CompilerGeneratedAttribute] // RVA: 0x2B2080 Offset: 0x2B2181 VA: 0x2B2080
	// RVA: 0x260D010 Offset: 0x260D111 VA: 0x260D010
	private void set_Acc4(AssetTable.Accessory value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2B2090 Offset: 0x2B2191 VA: 0x2B2090
	// RVA: 0x260D020 Offset: 0x260D121 VA: 0x260D020
	public AssetTable.Accessory get_Acc5() { }

	[CompilerGeneratedAttribute] // RVA: 0x2B20A0 Offset: 0x2B21A1 VA: 0x2B20A0
	// RVA: 0x260D030 Offset: 0x260D131 VA: 0x260D030
	private void set_Acc5(AssetTable.Accessory value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2B20B0 Offset: 0x2B21B1 VA: 0x2B20B0
	// RVA: 0x260D040 Offset: 0x260D141 VA: 0x260D040
	public AssetTable.Accessory get_Acc6() { }

	[CompilerGeneratedAttribute] // RVA: 0x2B20C0 Offset: 0x2B21C1 VA: 0x2B20C0
	// RVA: 0x260D050 Offset: 0x260D151 VA: 0x260D050
	private void set_Acc6(AssetTable.Accessory value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2B20D0 Offset: 0x2B21D1 VA: 0x2B20D0
	// RVA: 0x260D060 Offset: 0x260D161 VA: 0x260D060
	public AssetTable.Accessory get_Acc7() { }

	[CompilerGeneratedAttribute] // RVA: 0x2B20E0 Offset: 0x2B21E1 VA: 0x2B20E0
	// RVA: 0x260D070 Offset: 0x260D171 VA: 0x260D070
	private void set_Acc7(AssetTable.Accessory value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2B20F0 Offset: 0x2B21F1 VA: 0x2B20F0
	// RVA: 0x260D080 Offset: 0x260D181 VA: 0x260D080
	public AssetTable.Accessory get_Acc8() { }

	[CompilerGeneratedAttribute] // RVA: 0x2B2100 Offset: 0x2B2201 VA: 0x2B2100
	// RVA: 0x260D090 Offset: 0x260D191 VA: 0x260D090
	private void set_Acc8(AssetTable.Accessory value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2B2110 Offset: 0x2B2211 VA: 0x2B2110
	// RVA: 0x260D0A0 Offset: 0x260D1A1 VA: 0x260D0A0
	public AssetTable.AccessoryList get_Accessories() { }

	[CompilerGeneratedAttribute] // RVA: 0x2B2120 Offset: 0x2B2221 VA: 0x2B2120
	// RVA: 0x260D0B0 Offset: 0x260D1B1 VA: 0x260D0B0
	private void set_Accessories(AssetTable.AccessoryList value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2B2130 Offset: 0x2B2231 VA: 0x2B2130
	// RVA: 0x260D0C0 Offset: 0x260D1C1 VA: 0x260D0C0
	public float get_ScaleAll() { }

	[CompilerGeneratedAttribute] // RVA: 0x2B2140 Offset: 0x2B2241 VA: 0x2B2140
	// RVA: 0x260D0D0 Offset: 0x260D1D1 VA: 0x260D0D0
	private void set_ScaleAll(float value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2B2150 Offset: 0x2B2251 VA: 0x2B2150
	// RVA: 0x260D0E0 Offset: 0x260D1E1 VA: 0x260D0E0
	public float get_ScaleHead() { }

	[CompilerGeneratedAttribute] // RVA: 0x2B2160 Offset: 0x2B2261 VA: 0x2B2160
	// RVA: 0x260D0F0 Offset: 0x260D1F1 VA: 0x260D0F0
	private void set_ScaleHead(float value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2B2170 Offset: 0x2B2271 VA: 0x2B2170
	// RVA: 0x260D100 Offset: 0x260D201 VA: 0x260D100
	public float get_ScaleNeck() { }

	[CompilerGeneratedAttribute] // RVA: 0x2B2180 Offset: 0x2B2281 VA: 0x2B2180
	// RVA: 0x260D110 Offset: 0x260D211 VA: 0x260D110
	private void set_ScaleNeck(float value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2B2190 Offset: 0x2B2291 VA: 0x2B2190
	// RVA: 0x260D120 Offset: 0x260D221 VA: 0x260D120
	public float get_ScaleTorso() { }

	[CompilerGeneratedAttribute] // RVA: 0x2B21A0 Offset: 0x2B22A1 VA: 0x2B21A0
	// RVA: 0x260D130 Offset: 0x260D231 VA: 0x260D130
	private void set_ScaleTorso(float value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2B21B0 Offset: 0x2B22B1 VA: 0x2B21B0
	// RVA: 0x260D140 Offset: 0x260D241 VA: 0x260D140
	public float get_ScaleShoulders() { }

	[CompilerGeneratedAttribute] // RVA: 0x2B21C0 Offset: 0x2B22C1 VA: 0x2B21C0
	// RVA: 0x260D150 Offset: 0x260D251 VA: 0x260D150
	private void set_ScaleShoulders(float value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2B21D0 Offset: 0x2B22D1 VA: 0x2B21D0
	// RVA: 0x260D160 Offset: 0x260D261 VA: 0x260D160
	public float get_ScaleArms() { }

	[CompilerGeneratedAttribute] // RVA: 0x2B21E0 Offset: 0x2B22E1 VA: 0x2B21E0
	// RVA: 0x260D170 Offset: 0x260D271 VA: 0x260D170
	private void set_ScaleArms(float value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2B21F0 Offset: 0x2B22F1 VA: 0x2B21F0
	// RVA: 0x260D180 Offset: 0x260D281 VA: 0x260D180
	public float get_ScaleHands() { }

	[CompilerGeneratedAttribute] // RVA: 0x2B2200 Offset: 0x2B2301 VA: 0x2B2200
	// RVA: 0x260D190 Offset: 0x260D291 VA: 0x260D190
	private void set_ScaleHands(float value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2B2210 Offset: 0x2B2311 VA: 0x2B2210
	// RVA: 0x260D1A0 Offset: 0x260D2A1 VA: 0x260D1A0
	public float get_ScaleLegs() { }

	[CompilerGeneratedAttribute] // RVA: 0x2B2220 Offset: 0x2B2321 VA: 0x2B2220
	// RVA: 0x260D1B0 Offset: 0x260D2B1 VA: 0x260D1B0
	private void set_ScaleLegs(float value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2B2230 Offset: 0x2B2331 VA: 0x2B2230
	// RVA: 0x260D1C0 Offset: 0x260D2C1 VA: 0x260D1C0
	public float get_ScaleFeet() { }

	[CompilerGeneratedAttribute] // RVA: 0x2B2240 Offset: 0x2B2341 VA: 0x2B2240
	// RVA: 0x260D1D0 Offset: 0x260D2D1 VA: 0x260D1D0
	private void set_ScaleFeet(float value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2B2250 Offset: 0x2B2351 VA: 0x2B2250
	// RVA: 0x260D1E0 Offset: 0x260D2E1 VA: 0x260D1E0
	public float get_VolumeArms() { }

	[CompilerGeneratedAttribute] // RVA: 0x2B2260 Offset: 0x2B2361 VA: 0x2B2260
	// RVA: 0x260D1F0 Offset: 0x260D2F1 VA: 0x260D1F0
	private void set_VolumeArms(float value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2B2270 Offset: 0x2B2371 VA: 0x2B2270
	// RVA: 0x260D200 Offset: 0x260D301 VA: 0x260D200
	public float get_VolumeLegs() { }

	[CompilerGeneratedAttribute] // RVA: 0x2B2280 Offset: 0x2B2381 VA: 0x2B2280
	// RVA: 0x260D210 Offset: 0x260D311 VA: 0x260D210
	private void set_VolumeLegs(float value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2B2290 Offset: 0x2B2391 VA: 0x2B2290
	// RVA: 0x260D220 Offset: 0x260D321 VA: 0x260D220
	public float get_VolumeBust() { }

	[CompilerGeneratedAttribute] // RVA: 0x2B22A0 Offset: 0x2B23A1 VA: 0x2B22A0
	// RVA: 0x260D230 Offset: 0x260D331 VA: 0x260D230
	private void set_VolumeBust(float value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2B22B0 Offset: 0x2B23B1 VA: 0x2B22B0
	// RVA: 0x260D240 Offset: 0x260D341 VA: 0x260D240
	public float get_VolumeAbdomen() { }

	[CompilerGeneratedAttribute] // RVA: 0x2B22C0 Offset: 0x2B23C1 VA: 0x2B22C0
	// RVA: 0x260D250 Offset: 0x260D351 VA: 0x260D250
	private void set_VolumeAbdomen(float value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2B22D0 Offset: 0x2B23D1 VA: 0x2B22D0
	// RVA: 0x260D260 Offset: 0x260D361 VA: 0x260D260
	public float get_VolumeTorso() { }

	[CompilerGeneratedAttribute] // RVA: 0x2B22E0 Offset: 0x2B23E1 VA: 0x2B22E0
	// RVA: 0x260D270 Offset: 0x260D371 VA: 0x260D270
	private void set_VolumeTorso(float value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2B22F0 Offset: 0x2B23F1 VA: 0x2B22F0
	// RVA: 0x260D280 Offset: 0x260D381 VA: 0x260D280
	public float get_VolumeScaleArms() { }

	[CompilerGeneratedAttribute] // RVA: 0x2B2300 Offset: 0x2B2401 VA: 0x2B2300
	// RVA: 0x260D290 Offset: 0x260D391 VA: 0x260D290
	private void set_VolumeScaleArms(float value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2B2310 Offset: 0x2B2411 VA: 0x2B2310
	// RVA: 0x260D2A0 Offset: 0x260D3A1 VA: 0x260D2A0
	public float get_VolumeScaleLegs() { }

	[CompilerGeneratedAttribute] // RVA: 0x2B2320 Offset: 0x2B2421 VA: 0x2B2320
	// RVA: 0x260D2B0 Offset: 0x260D3B1 VA: 0x260D2B0
	private void set_VolumeScaleLegs(float value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2B2330 Offset: 0x2B2431 VA: 0x2B2330
	// RVA: 0x260D2C0 Offset: 0x260D3C1 VA: 0x260D2C0
	public float get_MapScaleAll() { }

	[CompilerGeneratedAttribute] // RVA: 0x2B2340 Offset: 0x2B2441 VA: 0x2B2340
	// RVA: 0x260D2D0 Offset: 0x260D3D1 VA: 0x260D2D0
	private void set_MapScaleAll(float value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2B2350 Offset: 0x2B2451 VA: 0x2B2350
	// RVA: 0x260D2E0 Offset: 0x260D3E1 VA: 0x260D2E0
	public float get_MapScaleHead() { }

	[CompilerGeneratedAttribute] // RVA: 0x2B2360 Offset: 0x2B2461 VA: 0x2B2360
	// RVA: 0x260D2F0 Offset: 0x260D3F1 VA: 0x260D2F0
	private void set_MapScaleHead(float value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2B2370 Offset: 0x2B2471 VA: 0x2B2370
	// RVA: 0x260D300 Offset: 0x260D401 VA: 0x260D300
	public float get_MapScaleWing() { }

	[CompilerGeneratedAttribute] // RVA: 0x2B2380 Offset: 0x2B2481 VA: 0x2B2380
	// RVA: 0x260D310 Offset: 0x260D411 VA: 0x260D310
	private void set_MapScaleWing(float value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2B2390 Offset: 0x2B2491 VA: 0x2B2390
	// RVA: 0x260D320 Offset: 0x260D421 VA: 0x260D320
	public string get_Voice() { }

	[CompilerGeneratedAttribute] // RVA: 0x2B23A0 Offset: 0x2B24A1 VA: 0x2B23A0
	// RVA: 0x260D330 Offset: 0x260D431 VA: 0x260D330
	private void set_Voice(string value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2B23B0 Offset: 0x2B24B1 VA: 0x2B23B0
	// RVA: 0x260D340 Offset: 0x260D441 VA: 0x260D340
	public string get_FootStep() { }

	[CompilerGeneratedAttribute] // RVA: 0x2B23C0 Offset: 0x2B24C1 VA: 0x2B23C0
	// RVA: 0x260D350 Offset: 0x260D451 VA: 0x260D350
	private void set_FootStep(string value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2B23D0 Offset: 0x2B24D1 VA: 0x2B23D0
	// RVA: 0x260D360 Offset: 0x260D461 VA: 0x260D360
	public string get_Material() { }

	[CompilerGeneratedAttribute] // RVA: 0x2B23E0 Offset: 0x2B24E1 VA: 0x2B23E0
	// RVA: 0x260D370 Offset: 0x260D471 VA: 0x260D370
	private void set_Material(string value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2B23F0 Offset: 0x2B24F1 VA: 0x2B23F0
	// RVA: 0x260D380 Offset: 0x260D481 VA: 0x260D380
	public string get_Comment() { }

	[CompilerGeneratedAttribute] // RVA: 0x2B2400 Offset: 0x2B2501 VA: 0x2B2400
	// RVA: 0x260D390 Offset: 0x260D491 VA: 0x260D390
	private void set_Comment(string value) { }

	// RVA: 0x260D3A0 Offset: 0x260D4A1 VA: 0x260D3A0
	public void .ctor() { }

	// RVA: 0x260D5E0 Offset: 0x260D6E1 VA: 0x260D5E0 Slot: 4
	public override void OnBuild() { }

	// RVA: 0x260DAE0 Offset: 0x260DBE1 VA: 0x260DAE0 Slot: 7
	public override void OnRelease() { }

	// RVA: 0x260DB90 Offset: 0x260DC91 VA: 0x260DB90 Slot: 6
	public override void OnCompletedEnd() { }

	// RVA: 0x260E590 Offset: 0x260E691 VA: 0x260E590
	public static List<string> get_ConditionNames() { }

	// RVA: 0x260E600 Offset: 0x260E701 VA: 0x260E600
	public static List<int> get_ConditionHits() { }

	// RVA: 0x260E670 Offset: 0x260E771 VA: 0x260E670 Slot: 8
	public override string GetDebugName() { }

	// RVA: 0x260E7A0 Offset: 0x260E8A1 VA: 0x260E7A0
	public static bool HasColor(Color color) { }

	// RVA: 0x260E7C0 Offset: 0x260E8C1 VA: 0x260E7C0
	private static void .cctor() { }
}

