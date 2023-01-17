// Namespace: UnityEngine.Rendering
[DefaultMemberAttribute] // RVA: 0x3B510 Offset: 0x3B611 VA: 0x3B510
public struct ListBuffer<T> // TypeDefIndex: 4529
{
	// Fields
	private T* m_BufferPtr; // 0x0
	private int m_Capacity; // 0x0
	private int* m_CountPtr; // 0x0

	// Properties
	internal T* BufferPtr { get; }
	public int Count { get; }
	public int Capacity { get; }
	public T Item { get; }

	// Methods

	// RVA: -1 Offset: -1
	internal T* get_BufferPtr() { }

	// RVA: -1 Offset: -1
	public int get_Count() { }

	// RVA: -1 Offset: -1
	public int get_Capacity() { }

	// RVA: -1 Offset: -1
	public void .ctor(T* bufferPtr, int* countPtr, int capacity) { }

	// RVA: -1 Offset: -1
	public ref T get_Item(in int index) { }

	// RVA: -1 Offset: -1
	public ref T GetUnchecked(in int index) { }

	// RVA: -1 Offset: -1
	public bool TryAdd(in T value) { }

	// RVA: -1 Offset: -1
	public void CopyTo(T* dstBuffer, int startDstIndex, int copyCount) { }

	// RVA: -1 Offset: -1
	public bool TryCopyTo(ListBuffer<T> other) { }

	// RVA: -1 Offset: -1
	public bool TryCopyFrom(T* srcPtr, int count) { }
}

