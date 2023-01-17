// Namespace: UTJ.GameObjectExtensions
[ExtensionAttribute] // RVA: 0x5B4B0 Offset: 0x5B5B1 VA: 0x5B4B0
public static class GameObjectUtil // TypeDefIndex: 6435
{
	// Methods

	// RVA: -1 Offset: -1
	public static IEnumerable<T> FindComponentsOfType<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x22B5E60 Offset: 0x22B5F61 VA: 0x22B5E60
	|-GameObjectUtil.FindComponentsOfType<object>
	|-GameObjectUtil.FindComponentsOfType<Transform>
	*/

	// RVA: 0x3109AA0 Offset: 0x3109BA1 VA: 0x3109AA0
	public static IEnumerable<GameObject> GetAllGameObjects() { }

	[ExtensionAttribute] // RVA: 0x5C430 Offset: 0x5C531 VA: 0x5C430
	// RVA: -1 Offset: -1
	public static Dictionary<string, T> BuildNameToComponentMap<T>(GameObject rootObject, bool includeInactive) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x22B5910 Offset: 0x22B5A11 VA: 0x22B5910
	|-GameObjectUtil.BuildNameToComponentMap<object>
	|-GameObjectUtil.BuildNameToComponentMap<SpringCapsuleCollider>
	|-GameObjectUtil.BuildNameToComponentMap<SpringPanelCollider>
	|-GameObjectUtil.BuildNameToComponentMap<SpringSphereCollider>
	|-GameObjectUtil.BuildNameToComponentMap<Transform>
	*/

	[ExtensionAttribute] // RVA: 0x5C440 Offset: 0x5C541 VA: 0x5C440
	// RVA: 0x3109BF0 Offset: 0x3109CF1 VA: 0x3109BF0
	public static IEnumerable<Transform> GetAllBones(GameObject rootObject) { }

	[ExtensionAttribute] // RVA: 0x5C450 Offset: 0x5C551 VA: 0x5C450
	// RVA: 0x3109D50 Offset: 0x3109E51 VA: 0x3109D50
	public static Transform FindChildByName(GameObject inRoot, string inName, GameObjectUtil.SearchOptions searchOptions = 1) { }

	[ExtensionAttribute] // RVA: 0x5C460 Offset: 0x5C561 VA: 0x5C460
	// RVA: -1 Offset: -1
	public static T FindChildComponentByName<T>(GameObject inRoot, string inName, GameObjectUtil.SearchOptions searchOptions = 1) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x22B5A00 Offset: 0x22B5B01 VA: 0x22B5A00
	|-GameObjectUtil.FindChildComponentByName<Camera>
	|-GameObjectUtil.FindChildComponentByName<object>
	|-GameObjectUtil.FindChildComponentByName<Renderer>
	|-GameObjectUtil.FindChildComponentByName<Transform>
	*/

	[ExtensionAttribute] // RVA: 0x5C470 Offset: 0x5C571 VA: 0x5C470
	// RVA: -1 Offset: -1
	public static T[] FindChildComponentsByName<T>(GameObject inRoot, string[] inNames, GameObjectUtil.SearchOptions searchOptions = 1) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x22B5B60 Offset: 0x22B5C61 VA: 0x22B5B60
	|-GameObjectUtil.FindChildComponentsByName<object>
	*/

	// RVA: 0x3109DC0 Offset: 0x3109EC1 VA: 0x3109DC0
	public static string RemoveNamespaceFromName(string inName) { }

	// RVA: 0x3109E80 Offset: 0x3109F81 VA: 0x3109E80
	public static int GetTransformDepth(Transform inObject) { }

	// RVA: 0x3109F30 Offset: 0x310A031 VA: 0x3109F30
	public static string GetUniqueName(string desiredName) { }
}

