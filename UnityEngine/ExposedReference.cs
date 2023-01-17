// Namespace: UnityEngine
[UsedByNativeCodeAttribute] // RVA: 0x43BF60 Offset: 0x43C061 VA: 0x43BF60
[Serializable]
public struct ExposedReference<T> // TypeDefIndex: 3424
{
	// Fields
	[SerializeField] // RVA: 0x442620 Offset: 0x442721 VA: 0x442620
	public PropertyName exposedName; // 0x0
	[SerializeField] // RVA: 0x442630 Offset: 0x442731 VA: 0x442630
	public Object defaultValue; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public T Resolve(IExposedPropertyTable resolver) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x33CEB90 Offset: 0x33CEC91 VA: 0x33CEB90
	|-ExposedReference<CinemachineVirtualCameraBase>.Resolve
	|-ExposedReference<GameObject>.Resolve
	|-ExposedReference<object>.Resolve
	|-ExposedReference<Volume>.Resolve
	*/
}

