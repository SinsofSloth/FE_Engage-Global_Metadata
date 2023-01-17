// Namespace: 
[Serializable]
internal struct AssetBundleBuildMap.AssetBundleEntry.AssetPathString // TypeDefIndex: 15052
{
	// Fields
	[SerializeField] // RVA: 0x2A65B0 Offset: 0x2A66B1 VA: 0x2A65B0
	public string original; // 0x0
	[SerializeField] // RVA: 0x2A65C0 Offset: 0x2A66C1 VA: 0x2A65C0
	public string lower; // 0x8

	// Methods

	// RVA: 0x1DC0FA0 Offset: 0x1DC10A1 VA: 0x1DC0FA0
	internal void .ctor(string s) { }
}

// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x27ADD0 Offset: 0x27AED1 VA: 0x27ADD0
private sealed class AssetBundleBuildMap.AssetBundleEntry.<>c__DisplayClass15_0 // TypeDefIndex: 15053
{
	// Fields
	public string assetName; // 0x10

	// Methods

	// RVA: 0x1DC0F10 Offset: 0x1DC1011 VA: 0x1DC0F10
	public void .ctor() { }

	// RVA: 0x1DC0F20 Offset: 0x1DC1021 VA: 0x1DC0F20
	internal bool <GetAssetFromAssetName>b__0(AssetBundleBuildMap.AssetBundleEntry.AssetPathString a) { }
}

// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x27ADE0 Offset: 0x27AEE1 VA: 0x27ADE0
[Serializable]
private sealed class AssetBundleBuildMap.AssetBundleEntry.<>c // TypeDefIndex: 15054
{
	// Fields
	public static readonly AssetBundleBuildMap.AssetBundleEntry.<>c <>9; // 0x0
	public static Func<AssetBundleBuildMap.AssetBundleEntry.AssetPathString, string> <>9__15_1; // 0x8

	// Methods

	// RVA: 0x1DC0E80 Offset: 0x1DC0F81 VA: 0x1DC0E80
	private static void .cctor() { }

	// RVA: 0x1DC0EF0 Offset: 0x1DC0FF1 VA: 0x1DC0EF0
	public void .ctor() { }

	// RVA: 0x1DC0F00 Offset: 0x1DC1001 VA: 0x1DC0F00
	internal string <GetAssetFromAssetName>b__15_1(AssetBundleBuildMap.AssetBundleEntry.AssetPathString s) { }
}

// Namespace: 
[Serializable]
public class AssetBundleBuildMap.AssetBundleEntry // TypeDefIndex: 15055
{
	// Fields
	[SerializeField] // RVA: 0x2A6560 Offset: 0x2A6661 VA: 0x2A6560
	internal string m_assetBundleName; // 0x10
	[SerializeField] // RVA: 0x2A6570 Offset: 0x2A6671 VA: 0x2A6570
	internal string m_assetBundleVariantName; // 0x18
	[SerializeField] // RVA: 0x2A6580 Offset: 0x2A6681 VA: 0x2A6580
	internal string m_fullName; // 0x20
	[SerializeField] // RVA: 0x2A6590 Offset: 0x2A6691 VA: 0x2A6590
	internal List<AssetBundleBuildMap.AssetBundleEntry.AssetPathString> m_assets; // 0x28
	[SerializeField] // RVA: 0x2A65A0 Offset: 0x2A66A1 VA: 0x2A65A0
	public string m_registererId; // 0x30

	// Properties
	public string Name { get; }
	public string Variant { get; }
	public string FullName { get; }

	// Methods

	// RVA: 0x1F68440 Offset: 0x1F68541 VA: 0x1F68440
	public string get_Name() { }

	// RVA: 0x1F68450 Offset: 0x1F68551 VA: 0x1F68450
	public string get_Variant() { }

	// RVA: 0x1F68460 Offset: 0x1F68561 VA: 0x1F68460
	public string get_FullName() { }

	// RVA: 0x1F68470 Offset: 0x1F68571 VA: 0x1F68470
	public void .ctor(string registererId, string assetBundleName, string variantName) { }

	// RVA: 0x1F68580 Offset: 0x1F68681 VA: 0x1F68580
	public void Clear() { }

	// RVA: 0x1F685E0 Offset: 0x1F686E1 VA: 0x1F685E0
	public void AddAssets(string id, IEnumerable<string> assets) { }

	// RVA: 0x1F68120 Offset: 0x1F68221 VA: 0x1F68120
	public IEnumerable<string> GetAssetFromAssetName(string assetName) { }
}

// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x27ADF0 Offset: 0x27AEF1 VA: 0x27ADF0
private sealed class AssetBundleBuildMap.<>c__DisplayClass8_0 // TypeDefIndex: 15056
{
	// Fields
	public string assetBundleFullName; // 0x10

	// Methods

	// RVA: 0x1F68410 Offset: 0x1F68511 VA: 0x1F68410
	public void .ctor() { }

	// RVA: 0x1F68420 Offset: 0x1F68521 VA: 0x1F68420
	internal bool <GetAssetBundle>b__0(AssetBundleBuildMap.AssetBundleEntry v) { }
}

// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x27AE00 Offset: 0x27AF01 VA: 0x27AE00
private sealed class AssetBundleBuildMap.<>c__DisplayClass10_0 // TypeDefIndex: 15057
{
	// Fields
	public string id; // 0x10

	// Methods

	// RVA: 0x1F680B0 Offset: 0x1F681B1 VA: 0x1F680B0
	public void .ctor() { }

	// RVA: 0x1F680C0 Offset: 0x1F681C1 VA: 0x1F680C0
	internal bool <ClearFromId>b__0(AssetBundleBuildMap.AssetBundleEntry e) { }
}

// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x27AE10 Offset: 0x27AF11 VA: 0x27AE10
private sealed class AssetBundleBuildMap.<>c__DisplayClass12_0 // TypeDefIndex: 15058
{
	// Fields
	public string assetbundleName; // 0x10
	public string assetName; // 0x18

	// Methods

	// RVA: 0x1F680E0 Offset: 0x1F681E1 VA: 0x1F680E0
	public void .ctor() { }

	// RVA: 0x1F680F0 Offset: 0x1F681F1 VA: 0x1F680F0
	internal bool <GetAssetPathsFromAssetBundleAndAssetName>b__0(AssetBundleBuildMap.AssetBundleEntry ab) { }

	// RVA: 0x1F68110 Offset: 0x1F68211 VA: 0x1F68110
	internal IEnumerable<string> <GetAssetPathsFromAssetBundleAndAssetName>b__1(AssetBundleBuildMap.AssetBundleEntry ab) { }
}

// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x27AE20 Offset: 0x27AF21 VA: 0x27AE20
private sealed class AssetBundleBuildMap.<>c__DisplayClass13_0 // TypeDefIndex: 15059
{
	// Fields
	public string assetBundleName; // 0x10

	// Methods

	// RVA: 0x1F68340 Offset: 0x1F68441 VA: 0x1F68340
	public void .ctor() { }

	// RVA: 0x1F68350 Offset: 0x1F68451 VA: 0x1F68350
	internal bool <GetAssetPathsFromAssetBundle>b__0(AssetBundleBuildMap.AssetBundleEntry e) { }
}

// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x27AE30 Offset: 0x27AF31 VA: 0x27AE30
[Serializable]
private sealed class AssetBundleBuildMap.<>c // TypeDefIndex: 15060
{
	// Fields
	public static readonly AssetBundleBuildMap.<>c <>9; // 0x0
	public static Func<AssetBundleBuildMap.AssetBundleEntry, IEnumerable<AssetBundleBuildMap.AssetBundleEntry.AssetPathString>> <>9__13_1; // 0x8
	public static Func<AssetBundleBuildMap.AssetBundleEntry.AssetPathString, string> <>9__13_2; // 0x10
	public static Func<AssetBundleBuildMap.AssetBundleEntry, string> <>9__16_0; // 0x18

	// Methods

	// RVA: 0x1F68000 Offset: 0x1F68101 VA: 0x1F68000
	private static void .cctor() { }

	// RVA: 0x1F68070 Offset: 0x1F68171 VA: 0x1F68070
	public void .ctor() { }

	// RVA: 0x1F68080 Offset: 0x1F68181 VA: 0x1F68080
	internal IEnumerable<AssetBundleBuildMap.AssetBundleEntry.AssetPathString> <GetAssetPathsFromAssetBundle>b__13_1(AssetBundleBuildMap.AssetBundleEntry e) { }

	// RVA: 0x1F68090 Offset: 0x1F68191 VA: 0x1F68090
	internal string <GetAssetPathsFromAssetBundle>b__13_2(AssetBundleBuildMap.AssetBundleEntry.AssetPathString s) { }

	// RVA: 0x1F680A0 Offset: 0x1F681A1 VA: 0x1F680A0
	internal string <GetAllAssetBundleNames>b__16_0(AssetBundleBuildMap.AssetBundleEntry e) { }
}

// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x27AE40 Offset: 0x27AF41 VA: 0x27AE40
private sealed class AssetBundleBuildMap.<>c__DisplayClass14_0 // TypeDefIndex: 15061
{
	// Fields
	public string assetPath; // 0x10

	// Methods

	// RVA: 0x1F68370 Offset: 0x1F68471 VA: 0x1F68370
	public void .ctor() { }

	// RVA: 0x1F68380 Offset: 0x1F68481 VA: 0x1F68380
	internal bool <GetAssetBundleName>b__0(AssetBundleBuildMap.AssetBundleEntry e) { }
}

