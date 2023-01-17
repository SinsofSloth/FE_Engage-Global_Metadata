// Namespace: UnityEngine.Rendering
[Serializable]
public class SerializedDictionary<K, V> : Dictionary<K, V>, ISerializationCallbackReceiver // TypeDefIndex: 4544
{
	// Fields
	[SerializeField] // RVA: 0x3CA60 Offset: 0x3CB61 VA: 0x3CA60
	private List<K> m_Keys; // 0x0
	[SerializeField] // RVA: 0x3CA70 Offset: 0x3CB71 VA: 0x3CA70
	private List<V> m_Values; // 0x0

	// Methods

	// RVA: -1 Offset: -1 Slot: 40
	public void OnBeforeSerialize() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x34318D0 Offset: 0x34319D1 VA: 0x34318D0
	|-SerializedDictionary<object, object>.OnBeforeSerialize
	*/

	// RVA: -1 Offset: -1 Slot: 41
	public void OnAfterDeserialize() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3431B10 Offset: 0x3431C11 VA: 0x3431B10
	|-SerializedDictionary<object, object>.OnAfterDeserialize
	*/

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3431C20 Offset: 0x3431D21 VA: 0x3431C20
	|-SerializedDictionary<object, object>..ctor
	*/
}

