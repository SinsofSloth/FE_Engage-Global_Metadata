// Namespace: UnityEngine
[NativeHeaderAttribute] // RVA: 0x43E2A0 Offset: 0x43E3A1 VA: 0x43E2A0
[NativeHeaderAttribute] // RVA: 0x43E2A0 Offset: 0x43E3A1 VA: 0x43E2A0
public sealed class Resources // TypeDefIndex: 3569
{
	// Methods

	// RVA: -1 Offset: -1
	internal static T[] ConvertObjects<T>(Object[] rawObjects) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x201A020 Offset: 0x201A121 VA: 0x201A020
	|-Resources.ConvertObjects<object>
	*/

	// RVA: 0x31E0F00 Offset: 0x31E1001 VA: 0x31E0F00
	public static Object[] FindObjectsOfTypeAll(Type type) { }

	// RVA: -1 Offset: -1
	public static T Load<T>(string path) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x201A230 Offset: 0x201A331 VA: 0x201A230
	|-Resources.Load<Material>
	|-Resources.Load<object>
	|-Resources.Load<TMP_ColorGradient>
	|-Resources.Load<TMP_FontAsset>
	|-Resources.Load<TMP_Settings>
	|-Resources.Load<TMP_SpriteAsset>
	|-Resources.Load<Transform>
	*/

	// RVA: 0x31E0E60 Offset: 0x31E0F61 VA: 0x31E0E60
	public static Object Load(string path, Type systemTypeInstance) { }

	// RVA: 0x31E1090 Offset: 0x31E1191 VA: 0x31E1090
	public static ResourceRequest LoadAsync(string path, Type type) { }

	// RVA: 0x31E1110 Offset: 0x31E1211 VA: 0x31E1110
	public static Object[] LoadAll(string path, Type systemTypeInstance) { }

	// RVA: -1 Offset: -1
	public static T[] LoadAll<T>(string path) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x201A310 Offset: 0x201A411 VA: 0x201A310
	|-Resources.LoadAll<object>
	|-Resources.LoadAll<Sprite>
	*/

	[FreeFunctionAttribute] // RVA: 0x44ED70 Offset: 0x44EE71 VA: 0x44ED70
	[TypeInferenceRuleAttribute] // RVA: 0x44ED70 Offset: 0x44EE71 VA: 0x44ED70
	// RVA: 0x31E1190 Offset: 0x31E1291 VA: 0x31E1190
	public static Object GetBuiltinResource(Type type, string path) { }

	// RVA: -1 Offset: -1
	public static T GetBuiltinResource<T>(string path) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x201A150 Offset: 0x201A251 VA: 0x201A150
	|-Resources.GetBuiltinResource<Font>
	|-Resources.GetBuiltinResource<object>
	*/

	// RVA: 0x31E11E0 Offset: 0x31E12E1 VA: 0x31E11E0
	public static void UnloadAsset(Object assetToUnload) { }

	[FreeFunctionAttribute] // RVA: 0x44EDD0 Offset: 0x44EED1 VA: 0x44EDD0
	// RVA: 0x31E1260 Offset: 0x31E1361 VA: 0x31E1260
	public static AsyncOperation UnloadUnusedAssets() { }
}

