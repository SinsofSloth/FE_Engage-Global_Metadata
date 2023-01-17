// Namespace: UnityEngine
[NativeHeaderAttribute] // RVA: 0x43EA20 Offset: 0x43EB21 VA: 0x43EA20
[NativeClassAttribute] // RVA: 0x43EA20 Offset: 0x43EB21 VA: 0x43EA20
[ExtensionOfNativeClassAttribute] // RVA: 0x43EA20 Offset: 0x43EB21 VA: 0x43EA20
[RequiredByNativeCodeAttribute] // RVA: 0x43EA20 Offset: 0x43EB21 VA: 0x43EA20
public class ScriptableObject : Object // TypeDefIndex: 3602
{
	// Methods

	// RVA: 0x31D8E10 Offset: 0x31D8F11 VA: 0x31D8E10
	public void .ctor() { }

	// RVA: 0x31E45C0 Offset: 0x31E46C1 VA: 0x31E45C0
	public static ScriptableObject CreateInstance(Type type) { }

	// RVA: -1 Offset: -1
	public static T CreateInstance<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x201C200 Offset: 0x201C301 VA: 0x201C200
	|-ScriptableObject.CreateInstance<AkWwiseInitializationSettings>
	|-ScriptableObject.CreateInstance<AssetBundleBuildMap>
	|-ScriptableObject.CreateInstance<MarkerTrack>
	|-ScriptableObject.CreateInstance<object>
	|-ScriptableObject.CreateInstance<PlayerConnection>
	|-ScriptableObject.CreateInstance<TMP_FontAsset>
	|-ScriptableObject.CreateInstance<VolumeProfile>
	*/

	[NativeMethodAttribute] // RVA: 0x450110 Offset: 0x450211 VA: 0x450110
	// RVA: 0x31E4570 Offset: 0x31E4671 VA: 0x31E4570
	private static void CreateScriptableObject(ScriptableObject self) { }

	[FreeFunctionAttribute] // RVA: 0x450150 Offset: 0x450251 VA: 0x450150
	// RVA: 0x31E4610 Offset: 0x31E4711 VA: 0x31E4610
	internal static ScriptableObject CreateScriptableObjectInstanceFromType(Type type, bool applyDefaultsAndReset) { }
}

