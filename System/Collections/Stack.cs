// Namespace: System.Collections
[ComVisibleAttribute] // RVA: 0x4771B0 Offset: 0x4772B1 VA: 0x4771B0
[DebuggerDisplayAttribute] // RVA: 0x4771B0 Offset: 0x4772B1 VA: 0x4771B0
[DebuggerTypeProxyAttribute] // RVA: 0x4771B0 Offset: 0x4772B1 VA: 0x4771B0
[Serializable]
public class Stack : ICollection, IEnumerable, ICloneable // TypeDefIndex: 1384
{
	// Fields
	private object[] _array; // 0x10
	private int _size; // 0x18
	private int _version; // 0x1C
	private object _syncRoot; // 0x20

	// Properties
	public virtual int Count { get; }
	public virtual bool IsSynchronized { get; }
	public virtual object SyncRoot { get; }

	// Methods

	// RVA: 0x38266C0 Offset: 0x38267C1 VA: 0x38266C0
	public void .ctor() { }

	// RVA: 0x382EEB0 Offset: 0x382EFB1 VA: 0x382EEB0
	public void .ctor(int initialCapacity) { }

	// RVA: 0x382EFA0 Offset: 0x382F0A1 VA: 0x382EFA0 Slot: 10
	public virtual int get_Count() { }

	// RVA: 0x382EFB0 Offset: 0x382F0B1 VA: 0x382EFB0 Slot: 11
	public virtual bool get_IsSynchronized() { }

	// RVA: 0x382EFC0 Offset: 0x382F0C1 VA: 0x382EFC0 Slot: 12
	public virtual object get_SyncRoot() { }

	// RVA: 0x382F050 Offset: 0x382F151 VA: 0x382F050 Slot: 13
	public virtual void Clear() { }

	// RVA: 0x382F090 Offset: 0x382F191 VA: 0x382F090 Slot: 14
	public virtual object Clone() { }

	// RVA: 0x382F130 Offset: 0x382F231 VA: 0x382F130 Slot: 15
	public virtual void CopyTo(Array array, int index) { }

	// RVA: 0x382F3F0 Offset: 0x382F4F1 VA: 0x382F3F0 Slot: 16
	public virtual IEnumerator GetEnumerator() { }

	// RVA: 0x382F460 Offset: 0x382F561 VA: 0x382F460 Slot: 17
	public virtual object Peek() { }

	// RVA: 0x382F500 Offset: 0x382F601 VA: 0x382F500 Slot: 18
	public virtual object Pop() { }

	// RVA: 0x382F5C0 Offset: 0x382F6C1 VA: 0x382F5C0 Slot: 19
	public virtual void Push(object obj) { }
}

