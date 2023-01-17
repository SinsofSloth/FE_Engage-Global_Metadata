// Namespace: System.Collections.Specialized
[Serializable]
public abstract class NameObjectCollectionBase : ICollection, IEnumerable, ISerializable, IDeserializationCallback // TypeDefIndex: 2399
{
	// Fields
	private bool _readOnly; // 0x10
	private ArrayList _entriesArray; // 0x18
	private IEqualityComparer _keyComparer; // 0x20
	private Hashtable _entriesTable; // 0x28
	private NameObjectCollectionBase.NameObjectEntry _nullKeyEntry; // 0x30
	private SerializationInfo _serializationInfo; // 0x38
	private int _version; // 0x40
	private object _syncRoot; // 0x48
	private static StringComparer defaultComparer; // 0x0

	// Properties
	protected bool IsReadOnly { get; }
	public virtual int Count { get; }
	private object System.Collections.ICollection.SyncRoot { get; }
	private bool System.Collections.ICollection.IsSynchronized { get; }

	// Methods

	// RVA: 0x1ACB3B0 Offset: 0x1ACB4B1 VA: 0x1ACB3B0
	protected void .ctor() { }

	// RVA: 0x1ACB490 Offset: 0x1ACB591 VA: 0x1ACB490
	protected void .ctor(IEqualityComparer equalityComparer) { }

	// RVA: 0x1ACB610 Offset: 0x1ACB711 VA: 0x1ACB610
	protected void .ctor(int capacity, IEqualityComparer equalityComparer) { }

	// RVA: 0x1ACB7B0 Offset: 0x1ACB8B1 VA: 0x1ACB7B0
	internal void .ctor(DBNull dummy) { }

	// RVA: 0x1ACB7C0 Offset: 0x1ACB8C1 VA: 0x1ACB7C0
	protected void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x1ACB800 Offset: 0x1ACB901 VA: 0x1ACB800 Slot: 11
	public virtual void GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x1ACBE00 Offset: 0x1ACBF01 VA: 0x1ACBE00 Slot: 12
	public virtual void OnDeserialization(object sender) { }

	// RVA: 0x1ACB530 Offset: 0x1ACB631 VA: 0x1ACB530
	private void Reset() { }

	// RVA: 0x1ACB6C0 Offset: 0x1ACB7C1 VA: 0x1ACB6C0
	private void Reset(int capacity) { }

	// RVA: 0x1ACC6F0 Offset: 0x1ACC7F1 VA: 0x1ACC6F0
	private NameObjectCollectionBase.NameObjectEntry FindEntry(string key) { }

	// RVA: 0x1ACC7B0 Offset: 0x1ACC8B1 VA: 0x1ACC7B0
	protected bool get_IsReadOnly() { }

	// RVA: 0x1ACC590 Offset: 0x1ACC691 VA: 0x1ACC590
	protected void BaseAdd(string name, object value) { }

	// RVA: 0x1ACC7C0 Offset: 0x1ACC8C1 VA: 0x1ACC7C0
	protected void BaseRemove(string name) { }

	// RVA: 0x1ACCB40 Offset: 0x1ACCC41 VA: 0x1ACCB40
	protected object BaseGet(string name) { }

	// RVA: 0x1ACCC20 Offset: 0x1ACCD21 VA: 0x1ACCC20
	protected void BaseSet(string name, object value) { }

	// RVA: 0x1ACCD80 Offset: 0x1ACCE81 VA: 0x1ACCD80
	protected object BaseGet(int index) { }

	// RVA: 0x1ACCAA0 Offset: 0x1ACCBA1 VA: 0x1ACCAA0
	protected string BaseGetKey(int index) { }

	// RVA: 0x1ACCE20 Offset: 0x1ACCF21 VA: 0x1ACCE20 Slot: 13
	public virtual IEnumerator GetEnumerator() { }

	// RVA: 0x1ACCE90 Offset: 0x1ACCF91 VA: 0x1ACCE90 Slot: 14
	public virtual int get_Count() { }

	// RVA: 0x1ACCEB0 Offset: 0x1ACCFB1 VA: 0x1ACCEB0 Slot: 4
	private void System.Collections.ICollection.CopyTo(Array array, int index) { }

	// RVA: 0x1ACD1F0 Offset: 0x1ACD2F1 VA: 0x1ACD1F0 Slot: 6
	private object System.Collections.ICollection.get_SyncRoot() { }

	// RVA: 0x1ACD280 Offset: 0x1ACD381 VA: 0x1ACD280 Slot: 7
	private bool System.Collections.ICollection.get_IsSynchronized() { }

	// RVA: 0x1ACD290 Offset: 0x1ACD391 VA: 0x1ACD290
	private static void .cctor() { }
}

