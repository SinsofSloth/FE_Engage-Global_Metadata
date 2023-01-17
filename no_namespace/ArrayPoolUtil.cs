// Namespace: 
public struct ArrayPoolUtil.RentArray<T> : IDisposable // TypeDefIndex: 5205
{
	// Fields
	public readonly T[] Array; // 0x0
	public readonly int Length; // 0x0
	private ArrayPool<T> pool; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(T[] array, int length, ArrayPool<T> pool) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2FF3780 Offset: 0x2FF3881 VA: 0x2FF3780
	|-ArrayPoolUtil.RentArray<UniTask<object>>..ctor
	|
	|-RVA: 0x2FF3940 Offset: 0x2FF3A41 VA: 0x2FF3940
	|-ArrayPoolUtil.RentArray<object>..ctor
	|
	|-RVA: 0x2FF3B00 Offset: 0x2FF3C01 VA: 0x2FF3B00
	|-ArrayPoolUtil.RentArray<UniTask>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public void Dispose() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2FF37D0 Offset: 0x2FF38D1 VA: 0x2FF37D0
	|-ArrayPoolUtil.RentArray<UniTask<object>>.Dispose
	|
	|-RVA: 0x2FF3990 Offset: 0x2FF3A91 VA: 0x2FF3990
	|-ArrayPoolUtil.RentArray<object>.Dispose
	|
	|-RVA: 0x2FF3B50 Offset: 0x2FF3C51 VA: 0x2FF3B50
	|-ArrayPoolUtil.RentArray<UniTask>.Dispose
	*/

	// RVA: -1 Offset: -1
	public void DisposeManually(bool clearArray) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2FF3870 Offset: 0x2FF3971 VA: 0x2FF3870
	|-ArrayPoolUtil.RentArray<UniTask<object>>.DisposeManually
	|
	|-RVA: 0x2FF3A30 Offset: 0x2FF3B31 VA: 0x2FF3A30
	|-ArrayPoolUtil.RentArray<object>.DisposeManually
	|
	|-RVA: 0x2FF3BF0 Offset: 0x2FF3CF1 VA: 0x2FF3BF0
	|-ArrayPoolUtil.RentArray<UniTask>.DisposeManually
	*/
}

