// Namespace: System.Collections.Specialized
[DefaultMemberAttribute] // RVA: 0x30850 Offset: 0x30951 VA: 0x30850
[Serializable]
public class OrderedDictionary : IDictionary, ICollection, IEnumerable, ISerializable, IDeserializationCallback // TypeDefIndex: 2404
{
	// Fields
	private ArrayList _objectsArray; // 0x10
	private Hashtable _objectsTable; // 0x18
	private int _initialCapacity; // 0x20
	private IEqualityComparer _comparer; // 0x28
	private bool _readOnly; // 0x30
	private object _syncRoot; // 0x38
	private SerializationInfo _siInfo; // 0x40

	// Properties
	public int Count { get; }
	private bool System.Collections.IDictionary.IsFixedSize { get; }
	public bool IsReadOnly { get; }
	private bool System.Collections.ICollection.IsSynchronized { get; }
	public ICollection Keys { get; }
	private ArrayList objectsArray { get; }
	private Hashtable objectsTable { get; }
	private object System.Collections.ICollection.SyncRoot { get; }
	public object Item { get; set; }
	public ICollection Values { get; }

	// Methods

	// RVA: 0x1AD2790 Offset: 0x1AD2891 VA: 0x1AD2790
	public void .ctor() { }

	// RVA: 0x1AD27D0 Offset: 0x1AD28D1 VA: 0x1AD27D0
	public void .ctor(int capacity) { }

	// RVA: 0x1AD2810 Offset: 0x1AD2911 VA: 0x1AD2810
	public void .ctor(int capacity, IEqualityComparer comparer) { }

	// RVA: 0x1AD2860 Offset: 0x1AD2961 VA: 0x1AD2860
	protected void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x1AD28A0 Offset: 0x1AD29A1 VA: 0x1AD28A0 Slot: 15
	public int get_Count() { }

	// RVA: 0x1AD29F0 Offset: 0x1AD2AF1 VA: 0x1AD29F0 Slot: 11
	private bool System.Collections.IDictionary.get_IsFixedSize() { }

	// RVA: 0x1AD2A00 Offset: 0x1AD2B01 VA: 0x1AD2A00 Slot: 10
	public bool get_IsReadOnly() { }

	// RVA: 0x1AD2A10 Offset: 0x1AD2B11 VA: 0x1AD2A10 Slot: 17
	private bool System.Collections.ICollection.get_IsSynchronized() { }

	// RVA: 0x1AD2A20 Offset: 0x1AD2B21 VA: 0x1AD2A20 Slot: 6
	public ICollection get_Keys() { }

	// RVA: 0x1AD2940 Offset: 0x1AD2A41 VA: 0x1AD2940
	private ArrayList get_objectsArray() { }

	// RVA: 0x1AD2B00 Offset: 0x1AD2C01 VA: 0x1AD2B00
	private Hashtable get_objectsTable() { }

	// RVA: 0x1AD2BA0 Offset: 0x1AD2CA1 VA: 0x1AD2BA0 Slot: 16
	private object System.Collections.ICollection.get_SyncRoot() { }

	// RVA: 0x1AD2C30 Offset: 0x1AD2D31 VA: 0x1AD2C30 Slot: 4
	public object get_Item(object key) { }

	// RVA: 0x1AD2CE0 Offset: 0x1AD2DE1 VA: 0x1AD2CE0 Slot: 5
	public void set_Item(object key, object value) { }

	// RVA: 0x1AD33A0 Offset: 0x1AD34A1 VA: 0x1AD33A0 Slot: 7
	public ICollection get_Values() { }

	// RVA: 0x1AD31B0 Offset: 0x1AD32B1 VA: 0x1AD31B0 Slot: 9
	public void Add(object key, object value) { }

	// RVA: 0x1AD3480 Offset: 0x1AD3581 VA: 0x1AD3480 Slot: 21
	public void Clear() { }

	// RVA: 0x1AD35F0 Offset: 0x1AD36F1 VA: 0x1AD35F0 Slot: 8
	public bool Contains(object key) { }

	// RVA: 0x1AD36A0 Offset: 0x1AD37A1 VA: 0x1AD36A0 Slot: 14
	public void CopyTo(Array array, int index) { }

	// RVA: 0x1AD2F90 Offset: 0x1AD3091 VA: 0x1AD2F90
	private int IndexOfKey(object key) { }

	// RVA: 0x1AD3760 Offset: 0x1AD3861 VA: 0x1AD3760 Slot: 22
	protected virtual void OnDeserialization(object sender) { }

	// RVA: 0x1AD3C20 Offset: 0x1AD3D21 VA: 0x1AD3C20 Slot: 13
	public void Remove(object key) { }

	// RVA: 0x1AD3E20 Offset: 0x1AD3F21 VA: 0x1AD3E20 Slot: 23
	public virtual IDictionaryEnumerator GetEnumerator() { }

	// RVA: 0x1AD3F00 Offset: 0x1AD4001 VA: 0x1AD3F00 Slot: 18
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	// RVA: 0x1AD3FE0 Offset: 0x1AD40E1 VA: 0x1AD3FE0 Slot: 24
	public virtual void GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x1AD4220 Offset: 0x1AD4321 VA: 0x1AD4220 Slot: 20
	private void System.Runtime.Serialization.IDeserializationCallback.OnDeserialization(object sender) { }
}

