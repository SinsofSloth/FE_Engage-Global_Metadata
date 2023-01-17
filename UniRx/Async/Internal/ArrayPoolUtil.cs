// Namespace: UniRx.Async.Internal
public static class ArrayPoolUtil // TypeDefIndex: 5206
{
	// Methods

	// RVA: -1 Offset: -1
	public static void EnsureCapacity<T>(ref T[] array, int index, ArrayPool<T> pool) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2732C20 Offset: 0x2732D21 VA: 0x2732C20
	|-ArrayPoolUtil.EnsureCapacity<UniTask<object>>
	|
	|-RVA: 0x2732C50 Offset: 0x2732D51 VA: 0x2732C50
	|-ArrayPoolUtil.EnsureCapacity<CancellationTokenRegistration>
	|
	|-RVA: 0x2732C80 Offset: 0x2732D81 VA: 0x2732C80
	|-ArrayPoolUtil.EnsureCapacity<object>
	|
	|-RVA: 0x2732CB0 Offset: 0x2732DB1 VA: 0x2732CB0
	|-ArrayPoolUtil.EnsureCapacity<UniTask>
	*/

	// RVA: -1 Offset: -1
	private static void EnsureCapacityCore<T>(ref T[] array, int index, ArrayPool<T> pool) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2732CE0 Offset: 0x2732DE1 VA: 0x2732CE0
	|-ArrayPoolUtil.EnsureCapacityCore<UniTask<object>>
	|
	|-RVA: 0x2732DC0 Offset: 0x2732EC1 VA: 0x2732DC0
	|-ArrayPoolUtil.EnsureCapacityCore<CancellationTokenRegistration>
	|
	|-RVA: 0x2732EA0 Offset: 0x2732FA1 VA: 0x2732EA0
	|-ArrayPoolUtil.EnsureCapacityCore<object>
	|
	|-RVA: 0x2732F80 Offset: 0x2733081 VA: 0x2732F80
	|-ArrayPoolUtil.EnsureCapacityCore<UniTask>
	*/

	// RVA: -1 Offset: -1
	public static ArrayPoolUtil.RentArray<T> Materialize<T>(IEnumerable<T> source) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2733060 Offset: 0x2733161 VA: 0x2733060
	|-ArrayPoolUtil.Materialize<UniTask<object>>
	|
	|-RVA: 0x27337A0 Offset: 0x27338A1 VA: 0x27337A0
	|-ArrayPoolUtil.Materialize<object>
	|
	|-RVA: 0x2733ED0 Offset: 0x2733FD1 VA: 0x2733ED0
	|-ArrayPoolUtil.Materialize<UniTask>
	*/
}

