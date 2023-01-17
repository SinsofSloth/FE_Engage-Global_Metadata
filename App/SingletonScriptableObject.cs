// Namespace: App
public class SingletonScriptableObject<T> : ScriptableObject // TypeDefIndex: 9218
{
	// Fields
	private static T s_Instance; // 0x0

	// Properties
	public static T Instance { get; }

	// Methods

	// RVA: -1 Offset: -1
	public static T get_Instance() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3440710 Offset: 0x3440811 VA: 0x3440710
	|-SingletonScriptableObject<CasualMap>.get_Instance
	|-SingletonScriptableObject<DebugInfo>.get_Instance
	|-SingletonScriptableObject<FontList>.get_Instance
	|-SingletonScriptableObject<GameColor>.get_Instance
	|-SingletonScriptableObject<GodColorRefineEmblem>.get_Instance
	|-SingletonScriptableObject<object>.get_Instance
	|-SingletonScriptableObject<ProfileCardColor>.get_Instance
	|-SingletonScriptableObject<UiColor>.get_Instance
	|-SingletonScriptableObject<UnitSequence>.get_Instance
	*/

	// RVA: -1 Offset: -1
	private void OnEnable() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3440840 Offset: 0x3440941 VA: 0x3440840
	|-SingletonScriptableObject<object>.OnEnable
	*/

	// RVA: -1 Offset: -1
	private void OnDisable() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3440A60 Offset: 0x3440B61 VA: 0x3440A60
	|-SingletonScriptableObject<object>.OnDisable
	*/

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3440C00 Offset: 0x3440D01 VA: 0x3440C00
	|-SingletonScriptableObject<CasualMap>..ctor
	|-SingletonScriptableObject<DebugInfo>..ctor
	|-SingletonScriptableObject<FontList>..ctor
	|-SingletonScriptableObject<GameColor>..ctor
	|-SingletonScriptableObject<GodColor>..ctor
	|-SingletonScriptableObject<GodColorRefineEmblem>..ctor
	|-SingletonScriptableObject<object>..ctor
	|-SingletonScriptableObject<ProfileCardColor>..ctor
	|-SingletonScriptableObject<UiColor>..ctor
	|-SingletonScriptableObject<UnitSequence>..ctor
	*/

	// RVA: -1 Offset: -1
	private static void .cctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3440C10 Offset: 0x3440D11 VA: 0x3440C10
	|-SingletonScriptableObject<object>..cctor
	*/
}

