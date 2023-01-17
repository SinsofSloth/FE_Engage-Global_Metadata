// Namespace: System.Threading
internal struct SparselyPopulatedArrayAddInfo<T> // TypeDefIndex: 737
{
	// Fields
	private SparselyPopulatedArrayFragment<T> m_source; // 0x0
	private int m_index; // 0x0

	// Properties
	internal SparselyPopulatedArrayFragment<T> Source { get; }
	internal int Index { get; }

	// Methods

	// RVA: -1 Offset: -1
	internal void .ctor(SparselyPopulatedArrayFragment<T> source, int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x36BAA40 Offset: 0x36BAB41 VA: 0x36BAA40
	|-SparselyPopulatedArrayAddInfo<object>..ctor
	*/

	// RVA: -1 Offset: -1
	internal SparselyPopulatedArrayFragment<T> get_Source() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x36BAA70 Offset: 0x36BAB71 VA: 0x36BAA70
	|-SparselyPopulatedArrayAddInfo<CancellationCallbackInfo>.get_Source
	|-SparselyPopulatedArrayAddInfo<object>.get_Source
	*/

	// RVA: -1 Offset: -1
	internal int get_Index() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x36BAA80 Offset: 0x36BAB81 VA: 0x36BAA80
	|-SparselyPopulatedArrayAddInfo<CancellationCallbackInfo>.get_Index
	|-SparselyPopulatedArrayAddInfo<object>.get_Index
	*/
}

