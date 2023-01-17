// Namespace: System.Collections
[ComVisibleAttribute] // RVA: 0x477020 Offset: 0x477121 VA: 0x477020
[DebuggerDisplayAttribute] // RVA: 0x477020 Offset: 0x477121 VA: 0x477020
[DebuggerTypeProxyAttribute] // RVA: 0x477020 Offset: 0x477121 VA: 0x477020
[DefaultMemberAttribute] // RVA: 0x477020 Offset: 0x477121 VA: 0x477020
[Serializable]
public class SortedList : IDictionary, ICollection, IEnumerable, ICloneable // TypeDefIndex: 1381
{
	// Fields
	private object[] keys; // 0x10
	private object[] values; // 0x18
	private int _size; // 0x20
	private int version; // 0x24
	private IComparer comparer; // 0x28
	private SortedList.KeyList keyList; // 0x30
	private SortedList.ValueList valueList; // 0x38
	private object _syncRoot; // 0x40
	private const int _defaultCapacity = 16;
	private static object[] emptyArray; // 0x0

	// Properties
	public virtual int Capacity { get; set; }
	public virtual int Count { get; }
	public virtual ICollection Keys { get; }
	public virtual ICollection Values { get; }
	public virtual bool IsReadOnly { get; }
	public virtual bool IsFixedSize { get; }
	public virtual bool IsSynchronized { get; }
	public virtual object SyncRoot { get; }
	public virtual object Item { get; set; }

	// Methods

	// RVA: 0x382C9F0 Offset: 0x382CAF1 VA: 0x382C9F0
	public void .ctor() { }

	// RVA: 0x382CA20 Offset: 0x382CB21 VA: 0x382CA20
	private void Init() { }

	// RVA: 0x382CB30 Offset: 0x382CC31 VA: 0x382CB30
	public void .ctor(int initialCapacity) { }

	// RVA: 0x382CCB0 Offset: 0x382CDB1 VA: 0x382CCB0
	public void .ctor(IComparer comparer) { }

	// RVA: 0x382CD00 Offset: 0x382CE01 VA: 0x382CD00
	public void .ctor(IComparer comparer, int capacity) { }

	// RVA: 0x382CD70 Offset: 0x382CE71 VA: 0x382CD70 Slot: 20
	public virtual void Add(object key, object value) { }

	// RVA: 0x382D080 Offset: 0x382D181 VA: 0x382D080 Slot: 21
	public virtual int get_Capacity() { }

	// RVA: 0x382D090 Offset: 0x382D191 VA: 0x382D090 Slot: 22
	public virtual void set_Capacity(int value) { }

	// RVA: 0x382D270 Offset: 0x382D371 VA: 0x382D270 Slot: 23
	public virtual int get_Count() { }

	// RVA: 0x382D280 Offset: 0x382D381 VA: 0x382D280 Slot: 24
	public virtual ICollection get_Keys() { }

	// RVA: 0x382D290 Offset: 0x382D391 VA: 0x382D290 Slot: 25
	public virtual ICollection get_Values() { }

	// RVA: 0x382D2A0 Offset: 0x382D3A1 VA: 0x382D2A0 Slot: 26
	public virtual bool get_IsReadOnly() { }

	// RVA: 0x382D2B0 Offset: 0x382D3B1 VA: 0x382D2B0 Slot: 27
	public virtual bool get_IsFixedSize() { }

	// RVA: 0x382D2C0 Offset: 0x382D3C1 VA: 0x382D2C0 Slot: 28
	public virtual bool get_IsSynchronized() { }

	// RVA: 0x382D2D0 Offset: 0x382D3D1 VA: 0x382D2D0 Slot: 29
	public virtual object get_SyncRoot() { }

	// RVA: 0x382D360 Offset: 0x382D461 VA: 0x382D360 Slot: 30
	public virtual object Clone() { }

	// RVA: 0x382D420 Offset: 0x382D521 VA: 0x382D420 Slot: 31
	public virtual bool Contains(object key) { }

	// RVA: 0x382D450 Offset: 0x382D551 VA: 0x382D450 Slot: 32
	public virtual bool ContainsKey(object key) { }

	// RVA: 0x382D480 Offset: 0x382D581 VA: 0x382D480 Slot: 33
	public virtual bool ContainsValue(object value) { }

	// RVA: 0x382D4B0 Offset: 0x382D5B1 VA: 0x382D4B0 Slot: 34
	public virtual void CopyTo(Array array, int arrayIndex) { }

	// RVA: 0x382D720 Offset: 0x382D821 VA: 0x382D720
	private void EnsureCapacity(int min) { }

	// RVA: 0x382D760 Offset: 0x382D861 VA: 0x382D760 Slot: 35
	public virtual object GetByIndex(int index) { }

	// RVA: 0x382D830 Offset: 0x382D931 VA: 0x382D830 Slot: 18
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	// RVA: 0x382D8B0 Offset: 0x382D9B1 VA: 0x382D8B0 Slot: 36
	public virtual IDictionaryEnumerator GetEnumerator() { }

	// RVA: 0x382D930 Offset: 0x382DA31 VA: 0x382D930 Slot: 37
	public virtual object GetKey(int index) { }

	// RVA: 0x382DA00 Offset: 0x382DB01 VA: 0x382DA00 Slot: 38
	public virtual IList GetKeyList() { }

	// RVA: 0x382DAA0 Offset: 0x382DBA1 VA: 0x382DAA0 Slot: 39
	public virtual IList GetValueList() { }

	// RVA: 0x382DB40 Offset: 0x382DC41 VA: 0x382DB40 Slot: 40
	public virtual object get_Item(object key) { }

	// RVA: 0x382DBB0 Offset: 0x382DCB1 VA: 0x382DBB0 Slot: 41
	public virtual void set_Item(object key, object value) { }

	// RVA: 0x382DCF0 Offset: 0x382DDF1 VA: 0x382DCF0 Slot: 42
	public virtual int IndexOfKey(object key) { }

	// RVA: 0x382DDA0 Offset: 0x382DEA1 VA: 0x382DDA0 Slot: 43
	public virtual int IndexOfValue(object value) { }

	// RVA: 0x382CEF0 Offset: 0x382CFF1 VA: 0x382CEF0
	private void Insert(int index, object key, object value) { }

	// RVA: 0x382DE10 Offset: 0x382DF11 VA: 0x382DE10 Slot: 44
	public virtual void RemoveAt(int index) { }

	// RVA: 0x382DF70 Offset: 0x382E071 VA: 0x382DF70 Slot: 45
	public virtual void Remove(object key) { }

	// RVA: 0x382DFC0 Offset: 0x382E0C1 VA: 0x382DFC0
	public static SortedList Synchronized(SortedList list) { }

	// RVA: 0x382E070 Offset: 0x382E171 VA: 0x382E070
	private static void .cctor() { }
}

