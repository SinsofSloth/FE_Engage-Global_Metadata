// Namespace: System
[ComVisibleAttribute] // RVA: 0x471310 Offset: 0x471411 VA: 0x471310
[Serializable]
public class WeakReference : ISerializable // TypeDefIndex: 423
{
	// Fields
	private bool isLongReference; // 0x10
	private GCHandle gcHandle; // 0x14

	// Properties
	public virtual bool IsAlive { get; }
	public virtual object Target { get; set; }
	public virtual bool TrackResurrection { get; }

	// Methods

	// RVA: 0x34D0BC0 Offset: 0x34D0CC1 VA: 0x34D0BC0
	private void AllocateHandle(object target) { }

	// RVA: 0x34D0C00 Offset: 0x34D0D01 VA: 0x34D0C00
	protected void .ctor() { }

	// RVA: 0x34D0C10 Offset: 0x34D0D11 VA: 0x34D0C10
	public void .ctor(object target) { }

	// RVA: 0x34D0C50 Offset: 0x34D0D51 VA: 0x34D0C50
	public void .ctor(object target, bool trackResurrection) { }

	// RVA: 0x34D0CA0 Offset: 0x34D0DA1 VA: 0x34D0CA0
	protected void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x34D0DF0 Offset: 0x34D0EF1 VA: 0x34D0DF0 Slot: 5
	public virtual bool get_IsAlive() { }

	// RVA: 0x34D0E20 Offset: 0x34D0F21 VA: 0x34D0E20 Slot: 6
	public virtual object get_Target() { }

	// RVA: 0x34D0E70 Offset: 0x34D0F71 VA: 0x34D0E70 Slot: 7
	public virtual void set_Target(object value) { }

	// RVA: 0x34D0E80 Offset: 0x34D0F81 VA: 0x34D0E80 Slot: 8
	public virtual bool get_TrackResurrection() { }

	// RVA: 0x34D0E90 Offset: 0x34D0F91 VA: 0x34D0E90 Slot: 1
	protected override void Finalize() { }

	// RVA: 0x34D0F00 Offset: 0x34D1001 VA: 0x34D0F00 Slot: 9
	public virtual void GetObjectData(SerializationInfo info, StreamingContext context) { }
}

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

