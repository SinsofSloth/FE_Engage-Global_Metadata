// Namespace: UnityEngine.ResourceManagement.Util
public static class ResourceManagerConfig // TypeDefIndex: 5572
{
	// Methods

	// RVA: 0x36283D0 Offset: 0x36284D1 VA: 0x36283D0
	internal static bool ExtractKeyAndSubKey(object keyObj, out string mainKey, out string subKey) { }

	// RVA: 0x3624100 Offset: 0x3624201 VA: 0x3624100
	public static bool IsPathRemote(string path) { }

	// RVA: 0x36359B0 Offset: 0x3635AB1 VA: 0x36359B0
	public static string StripQueryParameters(string path) { }

	// RVA: 0x3625A40 Offset: 0x3625B41 VA: 0x3625A40
	public static bool ShouldPathUseWebRequest(string path) { }

	// RVA: 0x362EE80 Offset: 0x362EF81 VA: 0x362EE80
	public static Array CreateArrayResult(Type type, Object[] allAssets) { }

	// RVA: -1 Offset: -1
	public static TObject CreateArrayResult<TObject>(Object[] allAssets) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2019D80 Offset: 0x2019E81 VA: 0x2019D80
	|-ResourceManagerConfig.CreateArrayResult<object>
	*/

	// RVA: 0x362F040 Offset: 0x362F141 VA: 0x362F040
	public static IList CreateListResult(Type type, Object[] allAssets) { }

	// RVA: -1 Offset: -1
	public static TObject CreateListResult<TObject>(Object[] allAssets) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2019E80 Offset: 0x2019F81 VA: 0x2019E80
	|-ResourceManagerConfig.CreateListResult<object>
	*/

	// RVA: -1 Offset: -1
	public static bool IsInstance<T1, T2>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2019F60 Offset: 0x201A061 VA: 0x2019F60
	|-ResourceManagerConfig.IsInstance<object, object>
	*/
}

