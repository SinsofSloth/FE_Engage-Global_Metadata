// Namespace: App
public abstract class PublicObject : SingletonMonoBehaviour<PublicObject> // TypeDefIndex: 14053
{
	// Fields
	private const string AssetName = "PublicObject";
	private const string AssetPath = "Assets/Share/Addressables/PublicObject.prefab";
	public PublicObject.Group[] m_Groups; // 0x20
	private static Dictionary<string, Object> s_Dictionary; // 0x0

	// Methods

	// RVA: 0x2EEF2D0 Offset: 0x2EEF3D1 VA: 0x2EEF2D0
	public static void LoadAsync() { }

	// RVA: -1 Offset: -1
	private void ForEachImpl<T>(PublicObject.Func<T> func) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2014DD0 Offset: 0x2014ED1 VA: 0x2014DD0
	|-PublicObject.ForEachImpl<object>
	|-PublicObject.ForEachImpl<Object>
	|-PublicObject.ForEachImpl<ShaderVariantCollection>
	*/

	// RVA: 0x2EEF440 Offset: 0x2EEF541 VA: 0x2EEF440
	private void WarmUpImpl() { }

	// RVA: 0x2EEF720 Offset: 0x2EEF821 VA: 0x2EEF720
	private void TryCreateDictionary() { }

	// RVA: -1 Offset: -1
	private T GetAssetImpl<T>(string name) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x20150E0 Offset: 0x20151E1 VA: 0x20150E0
	|-PublicObject.GetAssetImpl<object>
	*/

	// RVA: 0x2EEF990 Offset: 0x2EEFA91 VA: 0x2EEF990
	private void DumpImpl() { }

	// RVA: 0x2EEFA80 Offset: 0x2EEFB81 VA: 0x2EEFA80
	public static void WarmUp() { }

	// RVA: -1 Offset: -1
	public static T GetAsset<T>(string name) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2014FC0 Offset: 0x20150C1 VA: 0x2014FC0
	|-PublicObject.GetAsset<Font>
	|-PublicObject.GetAsset<GameObject>
	|-PublicObject.GetAsset<HubMiniMapCaptureParam>
	|-PublicObject.GetAsset<Material>
	|-PublicObject.GetAsset<object>
	|-PublicObject.GetAsset<RuntimeAnimatorController>
	*/

	// RVA: -1 Offset: -1
	public static T Instantiate<T>(string name, Transform parent) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2015360 Offset: 0x2015461 VA: 0x2015360
	|-PublicObject.Instantiate<GameObject>
	|-PublicObject.Instantiate<object>
	*/

	// RVA: -1 Offset: -1
	public static T Instantiate<T>(string name, GameObject parent) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2015280 Offset: 0x2015381 VA: 0x2015280
	|-PublicObject.Instantiate<GameObject>
	|-PublicObject.Instantiate<object>
	*/

	// RVA: 0x2EEFB10 Offset: 0x2EEFC11 VA: 0x2EEFB10
	public static GameObject Instantiate(string name, Transform parent) { }

	// RVA: 0x2EEF900 Offset: 0x2EEFA01 VA: 0x2EEF900
	public static GameObject Instantiate(string name, GameObject parent) { }

	// RVA: -1 Offset: -1
	public static void ForEach<T>(PublicObject.Func<T> func) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2014D10 Offset: 0x2014E11 VA: 0x2014D10
	|-PublicObject.ForEach<object>
	|-PublicObject.ForEach<TMP_FontAsset>
	*/

	[ConditionalAttribute] // RVA: 0x2CDC40 Offset: 0x2CDD41 VA: 0x2CDC40
	// RVA: 0x2EEFBA0 Offset: 0x2EEFCA1 VA: 0x2EEFBA0
	public static void Dump() { }

	// RVA: 0x2EEFBB0 Offset: 0x2EEFCB1 VA: 0x2EEFBB0
	protected void .ctor() { }

	// RVA: 0x2EEFC30 Offset: 0x2EEFD31 VA: 0x2EEFC30
	private static void .cctor() { }
}

