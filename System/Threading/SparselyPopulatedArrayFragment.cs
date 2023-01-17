// Namespace: System.Threading
[DefaultMemberAttribute] // RVA: 0x473110 Offset: 0x473211 VA: 0x473110
internal class SparselyPopulatedArrayFragment<T> // TypeDefIndex: 738
{
	// Fields
	internal readonly T[] m_elements; // 0x0
	internal int m_freeCount; // 0x0
	internal SparselyPopulatedArrayFragment<T> m_next; // 0x0
	internal SparselyPopulatedArrayFragment<T> m_prev; // 0x0

	// Properties
	internal T Item { get; }
	internal int Length { get; }
	internal SparselyPopulatedArrayFragment<T> Prev { get; }

	// Methods

	// RVA: -1 Offset: -1
	internal void .ctor(int size) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x36BAA90 Offset: 0x36BAB91 VA: 0x36BAA90
	|-SparselyPopulatedArrayFragment<object>..ctor
	*/

	// RVA: -1 Offset: -1
	internal void .ctor(int size, SparselyPopulatedArrayFragment<T> prev) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x36BAAB0 Offset: 0x36BABB1 VA: 0x36BAAB0
	|-SparselyPopulatedArrayFragment<object>..ctor
	*/

	// RVA: -1 Offset: -1
	internal T get_Item(int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x36BAB40 Offset: 0x36BAC41 VA: 0x36BAB40
	|-SparselyPopulatedArrayFragment<CancellationCallbackInfo>.get_Item
	|-SparselyPopulatedArrayFragment<object>.get_Item
	*/

	// RVA: -1 Offset: -1
	internal int get_Length() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x36BAB90 Offset: 0x36BAC91 VA: 0x36BAB90
	|-SparselyPopulatedArrayFragment<CancellationCallbackInfo>.get_Length
	|-SparselyPopulatedArrayFragment<object>.get_Length
	*/

	// RVA: -1 Offset: -1
	internal SparselyPopulatedArrayFragment<T> get_Prev() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x36BABA0 Offset: 0x36BACA1 VA: 0x36BABA0
	|-SparselyPopulatedArrayFragment<CancellationCallbackInfo>.get_Prev
	|-SparselyPopulatedArrayFragment<object>.get_Prev
	*/

	// RVA: -1 Offset: -1
	internal T SafeAtomicRemove(int index, T expectedElement) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x36BABD0 Offset: 0x36BACD1 VA: 0x36BABD0
	|-SparselyPopulatedArrayFragment<CancellationCallbackInfo>.SafeAtomicRemove
	|-SparselyPopulatedArrayFragment<object>.SafeAtomicRemove
	*/
}

