// Namespace: UnityEngine.AssetGraph
public class AssetBundleBuildMap : ScriptableObject // TypeDefIndex: 15062
{
	// Fields
	[SerializeField] // RVA: 0x2A6550 Offset: 0x2A6651 VA: 0x2A6550
	private List<AssetBundleBuildMap.AssetBundleEntry> m_assetBundles; // 0x18
	private static AssetBundleBuildMap s_map; // 0x0

	// Methods

	// RVA: 0x2609D50 Offset: 0x2609E51 VA: 0x2609D50
	public static AssetBundleBuildMap GetBuildMap() { }

	// RVA: 0x2609E80 Offset: 0x2609F81 VA: 0x2609E80
	private static bool Load() { }

	// RVA: 0x2609E90 Offset: 0x2609F91 VA: 0x2609E90
	public static void SetMapDirty() { }

	// RVA: 0x2609EA0 Offset: 0x2609FA1 VA: 0x2609EA0
	internal static string MakeFullName(string assetBundleName, string variantName) { }

	// RVA: 0x2609F70 Offset: 0x260A071 VA: 0x2609F70
	internal static string[] FullNameToNameAndVariant(string assetBundleFullName) { }

	// RVA: 0x260A160 Offset: 0x260A261 VA: 0x260A160
	public AssetBundleBuildMap.AssetBundleEntry GetAssetBundle(string registererId, string assetBundleFullName) { }

	// RVA: 0x260A300 Offset: 0x260A401 VA: 0x260A300
	public void Clear() { }

	// RVA: 0x260A360 Offset: 0x260A461 VA: 0x260A360
	public void ClearFromId(string id) { }

	// RVA: 0x260A460 Offset: 0x260A561 VA: 0x260A460
	public AssetBundleBuildMap.AssetBundleEntry GetAssetBundleWithNameAndVariant(string registererId, string assetBundleName, string variantName) { }

	// RVA: 0x260A4A0 Offset: 0x260A5A1 VA: 0x260A4A0
	public string[] GetAssetPathsFromAssetBundleAndAssetName(string assetbundleName, string assetName) { }

	// RVA: 0x260A680 Offset: 0x260A781 VA: 0x260A680
	public string[] GetAssetPathsFromAssetBundle(string assetBundleName) { }

	// RVA: 0x260A990 Offset: 0x260AA91 VA: 0x260A990
	public string GetAssetBundleName(string assetPath) { }

	// RVA: 0x260AAC0 Offset: 0x260ABC1 VA: 0x260AAC0
	public string GetImplicitAssetBundleName(string assetPath) { }

	// RVA: 0x260AAD0 Offset: 0x260ABD1 VA: 0x260AAD0
	public string[] GetAllAssetBundleNames() { }

	// RVA: 0x260AC20 Offset: 0x260AD21 VA: 0x260AC20
	public void .ctor() { }
}

