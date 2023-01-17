// Namespace: App
public abstract class LinkNode<T> : IDisposable // TypeDefIndex: 9222
{
	// Fields
	private int m_InstanceID; // 0x0
	private LinkedListNode<T> m_Node; // 0x0

	// Properties
	public virtual int SortKey { get; }

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2AD5CD0 Offset: 0x2AD5DD1 VA: 0x2AD5CD0
	|-LinkNode<GodBondHolder>..ctor
	|-LinkNode<GodUnit>..ctor
	|-LinkNode<object>..ctor
	|-LinkNode<UnitRing>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 1
	protected override void Finalize() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2AD5DA0 Offset: 0x2AD5EA1 VA: 0x2AD5DA0
	|-LinkNode<GodBondHolder>.Finalize
	|-LinkNode<GodUnit>.Finalize
	|-LinkNode<object>.Finalize
	|-LinkNode<UnitRing>.Finalize
	*/

	// RVA: -1 Offset: -1
	public int GetInstanceID() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2AD5E20 Offset: 0x2AD5F21 VA: 0x2AD5E20
	|-LinkNode<GodBondHolder>.GetInstanceID
	|-LinkNode<GodUnit>.GetInstanceID
	|-LinkNode<object>.GetInstanceID
	|-LinkNode<UnitRing>.GetInstanceID
	*/

	// RVA: -1 Offset: -1
	public void SetInstanceID(int instanceID) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2AD5E30 Offset: 0x2AD5F31 VA: 0x2AD5E30
	|-LinkNode<object>.SetInstanceID
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public void Dispose() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2AD5E40 Offset: 0x2AD5F41 VA: 0x2AD5E40
	|-LinkNode<GodBondHolder>.Dispose
	|-LinkNode<GodUnit>.Dispose
	|-LinkNode<object>.Dispose
	|-LinkNode<UnitRing>.Dispose
	*/

	// RVA: -1 Offset: -1 Slot: 5
	public virtual bool IsValid() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2AD5E50 Offset: 0x2AD5F51 VA: 0x2AD5E50
	|-LinkNode<object>.IsValid
	*/

	// RVA: -1 Offset: -1 Slot: 6
	public virtual int get_SortKey() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2AD5E60 Offset: 0x2AD5F61 VA: 0x2AD5E60
	|-LinkNode<GodBondHolder>.get_SortKey
	|-LinkNode<object>.get_SortKey
	*/

	// RVA: -1 Offset: -1 Slot: 7
	public abstract void OnSerialize(Stream stream);
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-LinkNode<object>.OnSerialize
	*/

	// RVA: -1 Offset: -1 Slot: 8
	public abstract void OnDeserialize(Stream stream, int version);
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-LinkNode<object>.OnDeserialize
	*/

	// RVA: -1 Offset: -1
	public static LinkedListNode<T> op_Implicit(LinkNode<T> node) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2AD5E70 Offset: 0x2AD5F71 VA: 0x2AD5E70
	|-LinkNode<object>.op_Implicit
	*/
}

