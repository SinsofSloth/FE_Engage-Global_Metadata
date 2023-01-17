// Namespace: UnityEngine.Rendering
public static class ComponentSingleton<TType> // TypeDefIndex: 4511
{
	// Fields
	private static TType s_Instance; // 0x0

	// Properties
	public static TType instance { get; }

	// Methods

	// RVA: -1 Offset: -1
	public static TType get_instance() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2500F90 Offset: 0x2501091 VA: 0x2500F90
	|-ComponentSingleton<object>.get_instance
	*/

	// RVA: -1 Offset: -1
	public static void Release() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2501480 Offset: 0x2501581 VA: 0x2501480
	|-ComponentSingleton<object>.Release
	*/

	// RVA: -1 Offset: -1
	private static void .cctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x25017A0 Offset: 0x25018A1 VA: 0x25017A0
	|-ComponentSingleton<object>..cctor
	*/
}

