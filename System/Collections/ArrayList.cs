// Namespace: System.Collections
[DebuggerTypeProxyAttribute] // RVA: 0x4769A0 Offset: 0x476AA1 VA: 0x4769A0
[ComVisibleAttribute] // RVA: 0x4769A0 Offset: 0x476AA1 VA: 0x4769A0
[DefaultMemberAttribute] // RVA: 0x4769A0 Offset: 0x476AA1 VA: 0x4769A0
[DebuggerDisplayAttribute] // RVA: 0x4769A0 Offset: 0x476AA1 VA: 0x4769A0
[Serializable]
public class ArrayList : IList, ICollection, IEnumerable, ICloneable // TypeDefIndex: 1338
{
	// Fields
	private object[] _items; // 0x10
	private int _size; // 0x18
	private int _version; // 0x1C
	private object _syncRoot; // 0x20
	private static readonly object[] emptyArray; // 0x0

	// Properties
	public virtual int Capacity { set; }
	public virtual int Count { get; }
	public virtual bool IsReadOnly { get; }
	public virtual bool IsSynchronized { get; }
	public virtual object SyncRoot { get; }
	public virtual object Item { get; set; }

	// Methods

	// RVA: 0x35577E0 Offset: 0x35578E1 VA: 0x35577E0
	public void .ctor() { }

	// RVA: 0x3564A50 Offset: 0x3564B51 VA: 0x3564A50
	public void .ctor(int capacity) { }

	// RVA: 0x3564BC0 Offset: 0x3564CC1 VA: 0x3564BC0
	public void .ctor(ICollection c) { }

	// RVA: 0x3564D80 Offset: 0x3564E81 VA: 0x3564D80 Slot: 20
	public virtual void set_Capacity(int value) { }

	// RVA: 0x3564EC0 Offset: 0x3564FC1 VA: 0x3564EC0 Slot: 21
	public virtual int get_Count() { }

	// RVA: 0x3564ED0 Offset: 0x3564FD1 VA: 0x3564ED0 Slot: 22
	public virtual bool get_IsReadOnly() { }

	// RVA: 0x3564EE0 Offset: 0x3564FE1 VA: 0x3564EE0 Slot: 23
	public virtual bool get_IsSynchronized() { }

	// RVA: 0x3564EF0 Offset: 0x3564FF1 VA: 0x3564EF0 Slot: 24
	public virtual object get_SyncRoot() { }

	// RVA: 0x3564F80 Offset: 0x3565081 VA: 0x3564F80 Slot: 25
	public virtual object get_Item(int index) { }

	// RVA: 0x3565030 Offset: 0x3565131 VA: 0x3565030 Slot: 26
	public virtual void set_Item(int index, object value) { }

	// RVA: 0x3565130 Offset: 0x3565231 VA: 0x3565130 Slot: 27
	public virtual int Add(object value) { }

	// RVA: 0x3565280 Offset: 0x3565381 VA: 0x3565280 Slot: 28
	public virtual void AddRange(ICollection c) { }

	// RVA: 0x35652A0 Offset: 0x35653A1 VA: 0x35652A0 Slot: 29
	public virtual void Clear() { }

	// RVA: 0x35652F0 Offset: 0x35653F1 VA: 0x35652F0 Slot: 30
	public virtual object Clone() { }

	// RVA: 0x3565380 Offset: 0x3565481 VA: 0x3565380 Slot: 31
	public virtual bool Contains(object item) { }

	// RVA: 0x3565460 Offset: 0x3565561 VA: 0x3565460 Slot: 32
	public virtual void CopyTo(Array array) { }

	// RVA: 0x3565480 Offset: 0x3565581 VA: 0x3565480 Slot: 33
	public virtual void CopyTo(Array array, int arrayIndex) { }

	// RVA: 0x3565520 Offset: 0x3565621 VA: 0x3565520 Slot: 34
	public virtual void CopyTo(int index, Array array, int arrayIndex, int count) { }

	// RVA: 0x3565230 Offset: 0x3565331 VA: 0x3565230
	private void EnsureCapacity(int min) { }

	// RVA: 0x35655F0 Offset: 0x35656F1 VA: 0x35655F0 Slot: 35
	public virtual IEnumerator GetEnumerator() { }

	// RVA: 0x3565660 Offset: 0x3565761 VA: 0x3565660 Slot: 36
	public virtual int IndexOf(object value) { }

	// RVA: 0x3565680 Offset: 0x3565781 VA: 0x3565680 Slot: 37
	public virtual void Insert(int index, object value) { }

	// RVA: 0x3565800 Offset: 0x3565901 VA: 0x3565800 Slot: 38
	public virtual void InsertRange(int index, ICollection c) { }

	// RVA: 0x3565AA0 Offset: 0x3565BA1 VA: 0x3565AA0
	public static ArrayList ReadOnly(ArrayList list) { }

	// RVA: 0x3565B50 Offset: 0x3565C51 VA: 0x3565B50 Slot: 39
	public virtual void Remove(object obj) { }

	// RVA: 0x3565BA0 Offset: 0x3565CA1 VA: 0x3565BA0 Slot: 40
	public virtual void RemoveAt(int index) { }

	// RVA: 0x3565C90 Offset: 0x3565D91 VA: 0x3565C90 Slot: 41
	public virtual void RemoveRange(int index, int count) { }

	// RVA: 0x3565E10 Offset: 0x3565F11 VA: 0x3565E10 Slot: 42
	public virtual object[] ToArray() { }

	// RVA: 0x3565E90 Offset: 0x3565F91 VA: 0x3565E90 Slot: 43
	public virtual Array ToArray(Type type) { }

	// RVA: 0x3565FC0 Offset: 0x35660C1 VA: 0x3565FC0
	private static void .cctor() { }
}

