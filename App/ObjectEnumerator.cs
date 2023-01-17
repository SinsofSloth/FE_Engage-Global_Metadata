// Namespace: App
public class ObjectEnumerator : List<GameObject> // TypeDefIndex: 9195
{
	// Methods

	// RVA: 0x2361920 Offset: 0x2361A21 VA: 0x2361920
	public static ObjectEnumerator FindByName(string name, GameObject gameObject) { }

	// RVA: 0x2361C90 Offset: 0x2361D91 VA: 0x2361C90
	private void FindByNameImpl(string name, Scene scene) { }

	// RVA: 0x2361BA0 Offset: 0x2361CA1 VA: 0x2361BA0
	private void FindByNameImpl(string name, GameObject gameObject) { }

	// RVA: 0x2361D30 Offset: 0x2361E31 VA: 0x2361D30
	public static ObjectEnumerator FindByLayer(int layer, GameObject root) { }

	// RVA: 0x23620C0 Offset: 0x23621C1 VA: 0x23620C0
	public static ObjectEnumerator FindByLayer(string layer, GameObject root) { }

	// RVA: 0x2362020 Offset: 0x2362121 VA: 0x2362020
	private void FindByLayerImpl(int layer, Scene scene) { }

	// RVA: 0x2361F30 Offset: 0x2362031 VA: 0x2361F30
	private void FindByLayerImpl(int layer, GameObject gameObject) { }

	// RVA: 0x23620E0 Offset: 0x23621E1 VA: 0x23620E0
	public static ObjectEnumerator FindParent(GameObject gameObject) { }

	// RVA: 0x2362200 Offset: 0x2362301 VA: 0x2362200
	private void FindParentImpl(Transform transform) { }

	// RVA: 0x23622D0 Offset: 0x23623D1 VA: 0x23622D0
	public static ObjectEnumerator FindChild(GameObject gameObject) { }

	// RVA: 0x23623F0 Offset: 0x23624F1 VA: 0x23623F0
	private void FindChildImpl(Transform transform) { }

	// RVA: 0x23624F0 Offset: 0x23625F1 VA: 0x23624F0
	public ObjectEnumerator SetActive(bool enabled) { }

	// RVA: -1 Offset: -1
	public ObjectEnumerator SetEnable<T>(bool enabled) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x296A270 Offset: 0x296A371 VA: 0x296A270
	|-ObjectEnumerator.SetEnable<object>
	*/

	// RVA: -1 Offset: -1
	public bool IsComponent<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x296A010 Offset: 0x296A111 VA: 0x296A010
	|-ObjectEnumerator.IsComponent<object>
	*/

	// RVA: 0x2362640 Offset: 0x2362741 VA: 0x2362640
	public ObjectEnumerator Dump() { }

	// RVA: 0x2361B20 Offset: 0x2361C21 VA: 0x2361B20
	public void .ctor() { }
}

