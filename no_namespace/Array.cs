// Namespace: 
private struct Array.SorterObjectArray // TypeDefIndex: 117
{
	// Fields
	private object[] keys; // 0x0
	private object[] items; // 0x8
	private IComparer comparer; // 0x10

	// Methods

	// RVA: 0x35E0E30 Offset: 0x35E0F31 VA: 0x35E0E30
	internal void .ctor(object[] keys, object[] items, IComparer comparer) { }

	// RVA: 0x35E0EF0 Offset: 0x35E0FF1 VA: 0x35E0EF0
	internal void SwapIfGreaterWithItems(int a, int b) { }

	// RVA: 0x35E1160 Offset: 0x35E1261 VA: 0x35E1160
	private void Swap(int i, int j) { }

	// RVA: 0x35E1310 Offset: 0x35E1411 VA: 0x35E1310
	internal void Sort(int left, int length) { }

	// RVA: 0x35E1320 Offset: 0x35E1421 VA: 0x35E1320
	private void IntrospectiveSort(int left, int length) { }

	// RVA: 0x35E1470 Offset: 0x35E1571 VA: 0x35E1470
	private void IntroSort(int lo, int hi, int depthLimit) { }

	// RVA: 0x35E1970 Offset: 0x35E1A71 VA: 0x35E1970
	private int PickPivotAndPartition(int lo, int hi) { }

	// RVA: 0x35E18C0 Offset: 0x35E19C1 VA: 0x35E18C0
	private void Heapsort(int lo, int hi) { }

	// RVA: 0x35E1BA0 Offset: 0x35E1CA1 VA: 0x35E1BA0
	private void DownHeap(int i, int n, int lo) { }

	// RVA: 0x35E15E0 Offset: 0x35E16E1 VA: 0x35E15E0
	private void InsertionSort(int lo, int hi) { }
}

