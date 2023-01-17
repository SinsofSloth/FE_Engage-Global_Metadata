// Namespace: Chara
[Serializable]
public class CharacterViewerSettings : ScriptableObject // TypeDefIndex: 8387
{
	// Fields
	public string PresetName; // 0x18
	public int AocType; // 0x20
	public string[] Animset; // 0x28
	public string WeaponName; // 0x30
	public string DressName; // 0x38
	public string[] AccessoryNames; // 0x40
	public Color[] Colors; // 0x48
	public float[] Scales; // 0x50
	public int LightDegree; // 0x58
	public float AnimSpeed; // 0x5C
	public Vector3 FreeCameraPos; // 0x60
	public Vector3 FreeCameraRot; // 0x6C
	public int CameraType; // 0x78
	public int EyeTarget; // 0x7C
	[CompilerGeneratedAttribute] // RVA: 0x27FCF0 Offset: 0x27FDF1 VA: 0x27FCF0
	private string <Comment>k__BackingField; // 0x80
	[CompilerGeneratedAttribute] // RVA: 0x27FD00 Offset: 0x27FE01 VA: 0x27FD00
	private bool <NeedRefresh>k__BackingField; // 0x88
	[CompilerGeneratedAttribute] // RVA: 0x27FD10 Offset: 0x27FE11 VA: 0x27FD10
	private bool <HeavyEdit>k__BackingField; // 0x89
	public static readonly string[] ColorNameList; // 0x0
	public static readonly string[] ScaleNameList; // 0x8
	public static readonly string[] LookTargetList; // 0x10
	public static readonly string[] CameraTypeList; // 0x18
	[CompilerGeneratedAttribute] // RVA: 0x27FD20 Offset: 0x27FE21 VA: 0x27FD20
	private static string[] <s_AnimsetList>k__BackingField; // 0x20
	[CompilerGeneratedAttribute] // RVA: 0x27FD30 Offset: 0x27FE31 VA: 0x27FD30
	private static string[] <s_ColorPresetKeys>k__BackingField; // 0x28
	[CompilerGeneratedAttribute] // RVA: 0x27FD40 Offset: 0x27FE41 VA: 0x27FD40
	private static Dictionary<string, Color[]> <s_ColorPresets>k__BackingField; // 0x30
	[CompilerGeneratedAttribute] // RVA: 0x27FD50 Offset: 0x27FE51 VA: 0x27FD50
	private static Dictionary<string, string> <s_DressDict>k__BackingField; // 0x38
	[CompilerGeneratedAttribute] // RVA: 0x27FD60 Offset: 0x27FE61 VA: 0x27FD60
	private static string[] <s_WeaponList>k__BackingField; // 0x40
	[CompilerGeneratedAttribute] // RVA: 0x27FD70 Offset: 0x27FE71 VA: 0x27FD70
	private static string[] <s_AccessoryList>k__BackingField; // 0x48

	// Properties
	public string Comment { get; set; }
	public bool NeedRefresh { get; set; }
	public bool HeavyEdit { get; set; }
	private static string[] s_AnimsetList { get; set; }
	private static string[] s_ColorPresetKeys { get; set; }
	private static Dictionary<string, Color[]> s_ColorPresets { get; set; }
	private static Dictionary<string, string> s_DressDict { get; set; }
	private static string[] s_WeaponList { get; set; }
	private static string[] s_AccessoryList { get; set; }
	public static string[] AnimsetList { get; }
	public static string[] ColorPresetKeys { get; }
	public static Dictionary<string, Color[]> ColorPresets { get; }
	public static Dictionary<string, string> DressDict { get; }
	public static string[] WeaponList { get; }
	public static string[] AccessoryList { get; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x2A8040 Offset: 0x2A8141 VA: 0x2A8040
	// RVA: 0x29CB8D0 Offset: 0x29CB9D1 VA: 0x29CB8D0
	public string get_Comment() { }

	[CompilerGeneratedAttribute] // RVA: 0x2A8050 Offset: 0x2A8151 VA: 0x2A8050
	// RVA: 0x29CB8E0 Offset: 0x29CB9E1 VA: 0x29CB8E0
	public void set_Comment(string value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2A8060 Offset: 0x2A8161 VA: 0x2A8060
	// RVA: 0x29CB8F0 Offset: 0x29CB9F1 VA: 0x29CB8F0
	public bool get_NeedRefresh() { }

	[CompilerGeneratedAttribute] // RVA: 0x2A8070 Offset: 0x2A8171 VA: 0x2A8070
	// RVA: 0x29CB900 Offset: 0x29CBA01 VA: 0x29CB900
	public void set_NeedRefresh(bool value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2A8080 Offset: 0x2A8181 VA: 0x2A8080
	// RVA: 0x29CB910 Offset: 0x29CBA11 VA: 0x29CB910
	public bool get_HeavyEdit() { }

	[CompilerGeneratedAttribute] // RVA: 0x2A8090 Offset: 0x2A8191 VA: 0x2A8090
	// RVA: 0x29CB920 Offset: 0x29CBA21 VA: 0x29CB920
	public void set_HeavyEdit(bool value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2A80A0 Offset: 0x2A81A1 VA: 0x2A80A0
	// RVA: 0x29CB930 Offset: 0x29CBA31 VA: 0x29CB930
	private static string[] get_s_AnimsetList() { }

	[CompilerGeneratedAttribute] // RVA: 0x2A80B0 Offset: 0x2A81B1 VA: 0x2A80B0
	// RVA: 0x29CB9A0 Offset: 0x29CBAA1 VA: 0x29CB9A0
	private static void set_s_AnimsetList(string[] value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2A80C0 Offset: 0x2A81C1 VA: 0x2A80C0
	// RVA: 0x29CBA20 Offset: 0x29CBB21 VA: 0x29CBA20
	private static string[] get_s_ColorPresetKeys() { }

	[CompilerGeneratedAttribute] // RVA: 0x2A80D0 Offset: 0x2A81D1 VA: 0x2A80D0
	// RVA: 0x29CBA90 Offset: 0x29CBB91 VA: 0x29CBA90
	private static void set_s_ColorPresetKeys(string[] value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2A80E0 Offset: 0x2A81E1 VA: 0x2A80E0
	// RVA: 0x29CBB10 Offset: 0x29CBC11 VA: 0x29CBB10
	private static Dictionary<string, Color[]> get_s_ColorPresets() { }

	[CompilerGeneratedAttribute] // RVA: 0x2A80F0 Offset: 0x2A81F1 VA: 0x2A80F0
	// RVA: 0x29CBB80 Offset: 0x29CBC81 VA: 0x29CBB80
	private static void set_s_ColorPresets(Dictionary<string, Color[]> value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2A8100 Offset: 0x2A8201 VA: 0x2A8100
	// RVA: 0x29CBC00 Offset: 0x29CBD01 VA: 0x29CBC00
	private static Dictionary<string, string> get_s_DressDict() { }

	[CompilerGeneratedAttribute] // RVA: 0x2A8110 Offset: 0x2A8211 VA: 0x2A8110
	// RVA: 0x29CBC70 Offset: 0x29CBD71 VA: 0x29CBC70
	private static void set_s_DressDict(Dictionary<string, string> value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2A8120 Offset: 0x2A8221 VA: 0x2A8120
	// RVA: 0x29CBCF0 Offset: 0x29CBDF1 VA: 0x29CBCF0
	private static string[] get_s_WeaponList() { }

	[CompilerGeneratedAttribute] // RVA: 0x2A8130 Offset: 0x2A8231 VA: 0x2A8130
	// RVA: 0x29CBD60 Offset: 0x29CBE61 VA: 0x29CBD60
	private static void set_s_WeaponList(string[] value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2A8140 Offset: 0x2A8241 VA: 0x2A8140
	// RVA: 0x29CBDE0 Offset: 0x29CBEE1 VA: 0x29CBDE0
	private static string[] get_s_AccessoryList() { }

	[CompilerGeneratedAttribute] // RVA: 0x2A8150 Offset: 0x2A8251 VA: 0x2A8150
	// RVA: 0x29CBE50 Offset: 0x29CBF51 VA: 0x29CBE50
	private static void set_s_AccessoryList(string[] value) { }

	// RVA: 0x29C2720 Offset: 0x29C2821 VA: 0x29C2720
	public static string[] get_AnimsetList() { }

	// RVA: 0x29C8ED0 Offset: 0x29C8FD1 VA: 0x29C8ED0
	public static string[] get_ColorPresetKeys() { }

	// RVA: 0x29CA340 Offset: 0x29CA441 VA: 0x29CA340
	public static Dictionary<string, Color[]> get_ColorPresets() { }

	// RVA: 0x29C21E0 Offset: 0x29C22E1 VA: 0x29C21E0
	public static Dictionary<string, string> get_DressDict() { }

	// RVA: 0x29C2350 Offset: 0x29C2451 VA: 0x29C2350
	public static string[] get_WeaponList() { }

	// RVA: 0x29C24C0 Offset: 0x29C25C1 VA: 0x29C24C0
	public static string[] get_AccessoryList() { }

	// RVA: 0x29CDDF0 Offset: 0x29CDEF1 VA: 0x29CDDF0
	public void Initialize() { }

	// RVA: 0x29CDE90 Offset: 0x29CDF91 VA: 0x29CDE90
	public int GetHash() { }

	// RVA: 0x29CE0B0 Offset: 0x29CE1B1 VA: 0x29CE0B0
	public int GetHeavyHash() { }

	// RVA: 0x29CE1D0 Offset: 0x29CE2D1 VA: 0x29CE1D0
	public void Validate() { }

	// RVA: 0x29C6F70 Offset: 0x29C7071 VA: 0x29C6F70
	public void LoadPreset() { }

	// RVA: 0x29CBED0 Offset: 0x29CBFD1 VA: 0x29CBED0
	private static void CreateAnimsetList() { }

	// RVA: 0x29CC3A0 Offset: 0x29CC4A1 VA: 0x29CC3A0
	private static void CreateColorPreset() { }

	// RVA: 0x29CC8A0 Offset: 0x29CC9A1 VA: 0x29CC8A0
	private static void CreateDressDict() { }

	// RVA: 0x29CD600 Offset: 0x29CD701 VA: 0x29CD600
	private static void CreateWeaponList() { }

	// RVA: 0x29CD910 Offset: 0x29CDA11 VA: 0x29CD910
	private static void CreateAccessoryList() { }

	// RVA: 0x29CE2F0 Offset: 0x29CE3F1 VA: 0x29CE2F0
	private static string GetIndexBodyAnimName(string bodyAnim) { }

	// RVA: 0x29CE390 Offset: 0x29CE491 VA: 0x29CE390
	private static string GetIndexWeaponName(ItemData item) { }

	// RVA: 0x29C9C20 Offset: 0x29C9D21 VA: 0x29C9C20
	public static string GetIndexAccessoryName(AssetTable.Accessory accs) { }

	// RVA: 0x29CE400 Offset: 0x29CE501 VA: 0x29CE400
	public void .ctor() { }

	// RVA: 0x29CE410 Offset: 0x29CE511 VA: 0x29CE410
	private static void .cctor() { }
}

