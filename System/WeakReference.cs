// Namespace: System
[Serializable]
public sealed class WeakReference<T> : ISerializable // TypeDefIndex: 424
{
	// Fields
	private GCHandle handle; // 0x0
	private bool trackResurrection; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(T target, bool trackResurrection) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2FDBE20 Offset: 0x2FDBF21 VA: 0x2FDBE20
	|-WeakReference<object>..ctor
	*/

	// RVA: -1 Offset: -1
	private void .ctor(SerializationInfo info, StreamingContext context) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2FDBE70 Offset: 0x2FDBF71 VA: 0x2FDBE70
	|-WeakReference<object>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public void GetObjectData(SerializationInfo info, StreamingContext context) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2FDBFC0 Offset: 0x2FDC0C1 VA: 0x2FDBFC0
	|-WeakReference<object>.GetObjectData
	*/

	// RVA: -1 Offset: -1
	public bool TryGetTarget(out T target) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2FDC0C0 Offset: 0x2FDC1C1 VA: 0x2FDC0C0
	|-WeakReference<object>.TryGetTarget
	*/

	// RVA: -1 Offset: -1 Slot: 1
	protected override void Finalize() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2FDC1C0 Offset: 0x2FDC2C1 VA: 0x2FDC1C0
	|-WeakReference<object>.Finalize
	*/
}

