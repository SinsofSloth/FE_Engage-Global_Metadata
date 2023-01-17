// Namespace: UnityEngine.ResourceManagement.ResourceProviders
public class AssetBundleManager // TypeDefIndex: 15065
{
	// Fields
	private static Stack<AssetBundleLocalResource> s_ResourceStack; // 0x0
	private static Dictionary<string, AssetBundleLocalResource> s_ResourceEntry; // 0x8

	// Methods

	// RVA: 0x260ACB0 Offset: 0x260ADB1 VA: 0x260ACB0
	public static void Initialize(int capacity) { }

	// RVA: 0x260AF20 Offset: 0x260B021 VA: 0x260AF20
	internal static void PopAssetBundleLocalResource(ProvideHandle provideHandle) { }

	// RVA: 0x260B300 Offset: 0x260B401 VA: 0x260B300
	internal static void PushAssetBundleLocalResource(AssetBundleLocalResource resource) { }

	// RVA: 0x260B980 Offset: 0x260BA81 VA: 0x260B980
	public void .ctor() { }

	// RVA: 0x260B990 Offset: 0x260BA91 VA: 0x260B990
	private static void .cctor() { }
}

