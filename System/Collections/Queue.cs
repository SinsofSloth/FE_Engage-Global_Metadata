// Namespace: System.Collections
[ComVisibleAttribute] // RVA: 0x476F60 Offset: 0x477061 VA: 0x476F60
[DebuggerDisplayAttribute] // RVA: 0x476F60 Offset: 0x477061 VA: 0x476F60
[DebuggerTypeProxyAttribute] // RVA: 0x476F60 Offset: 0x477061 VA: 0x476F60
[Serializable]
public class Queue : ICollection, IEnumerable, ICloneable // TypeDefIndex: 1374
{
	// Fields
	private object[] _array; // 0x10
	private int _head; // 0x18
	private int _tail; // 0x1C
	private int _size; // 0x20
	private int _growFactor; // 0x24
	private int _version; // 0x28
	private object _syncRoot; // 0x30

	// Properties
	public virtual int Count { get; }
	public virtual bool IsSynchronized { get; }
	public virtual object SyncRoot { get; }

	// Methods

	// RVA: 0x3B66E00 Offset: 0x3B66F01 VA: 0x3B66E00
	public void .ctor() { }

	// RVA: 0x3B67090 Offset: 0x3B67191 VA: 0x3B67090
	public void .ctor(int capacity) { }

	// RVA: 0x3B66E80 Offset: 0x3B66F81 VA: 0x3B66E80
	public void .ctor(int capacity, float growFactor) { }

	// RVA: 0x3B670A0 Offset: 0x3B671A1 VA: 0x3B670A0
	public void .ctor(ICollection col) { }

	// RVA: 0x3B67320 Offset: 0x3B67421 VA: 0x3B67320 Slot: 10
	public virtual int get_Count() { }

	// RVA: 0x3B67330 Offset: 0x3B67431 VA: 0x3B67330 Slot: 11
	public virtual object Clone() { }

	// RVA: 0x3B67410 Offset: 0x3B67511 VA: 0x3B67410 Slot: 12
	public virtual bool get_IsSynchronized() { }

	// RVA: 0x3B67420 Offset: 0x3B67521 VA: 0x3B67420 Slot: 13
	public virtual object get_SyncRoot() { }

	// RVA: 0x3B674B0 Offset: 0x3B675B1 VA: 0x3B674B0 Slot: 14
	public virtual void CopyTo(Array array, int index) { }

	// RVA: 0x3B67680 Offset: 0x3B67781 VA: 0x3B67680 Slot: 15
	public virtual void Enqueue(object obj) { }

	// RVA: 0x3B67880 Offset: 0x3B67981 VA: 0x3B67880 Slot: 16
	public virtual IEnumerator GetEnumerator() { }

	// RVA: 0x3B678F0 Offset: 0x3B679F1 VA: 0x3B678F0 Slot: 17
	public virtual object Dequeue() { }

	// RVA: 0x3B679E0 Offset: 0x3B67AE1 VA: 0x3B679E0 Slot: 18
	public virtual object Peek() { }

	// RVA: 0x3B67A90 Offset: 0x3B67B91 VA: 0x3B67A90
	internal object GetElement(int i) { }

	// RVA: 0x3B67790 Offset: 0x3B67891 VA: 0x3B67790
	private void SetCapacity(int capacity) { }
}

