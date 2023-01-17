// Namespace: UniRx.Async.Internal
public sealed class ArrayPool<T> // TypeDefIndex: 5204
{
	// Fields
	private const int DefaultMaxNumberOfArraysPerBucket = 50;
	private static readonly T[] EmptyArray; // 0x0
	public static readonly ArrayPool<T> Shared; // 0x0
	private readonly MinimumQueue<T[]>[] buckets; // 0x0
	private readonly SpinLock[] locks; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	private void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1FF8C20 Offset: 0x1FF8D21 VA: 0x1FF8C20
	|-ArrayPool<UniTask<object>>..ctor
	|
	|-RVA: 0x1FF9620 Offset: 0x1FF9721 VA: 0x1FF9620
	|-ArrayPool<CancellationTokenRegistration>..ctor
	|
	|-RVA: 0x1FFA020 Offset: 0x1FFA121 VA: 0x1FFA020
	|-ArrayPool<object>..ctor
	|
	|-RVA: 0x1FFAA20 Offset: 0x1FFAB21 VA: 0x1FFAA20
	|-ArrayPool<UniTask>..ctor
	*/

	// RVA: -1 Offset: -1
	public T[] Rent(int minimumLength) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1FF8DF0 Offset: 0x1FF8EF1 VA: 0x1FF8DF0
	|-ArrayPool<UniTask<object>>.Rent
	|
	|-RVA: 0x1FF97F0 Offset: 0x1FF98F1 VA: 0x1FF97F0
	|-ArrayPool<CancellationTokenRegistration>.Rent
	|
	|-RVA: 0x1FFA1F0 Offset: 0x1FFA2F1 VA: 0x1FFA1F0
	|-ArrayPool<object>.Rent
	|
	|-RVA: 0x1FFABF0 Offset: 0x1FFACF1 VA: 0x1FFABF0
	|-ArrayPool<UniTask>.Rent
	*/

	// RVA: -1 Offset: -1
	public void Return(T[] array, bool clearArray = False) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1FF9130 Offset: 0x1FF9231 VA: 0x1FF9130
	|-ArrayPool<UniTask<object>>.Return
	|
	|-RVA: 0x1FF9B30 Offset: 0x1FF9C31 VA: 0x1FF9B30
	|-ArrayPool<CancellationTokenRegistration>.Return
	|
	|-RVA: 0x1FFA530 Offset: 0x1FFA631 VA: 0x1FFA530
	|-ArrayPool<object>.Return
	|
	|-RVA: 0x1FFAF30 Offset: 0x1FFB031 VA: 0x1FFAF30
	|-ArrayPool<UniTask>.Return
	*/

	// RVA: -1 Offset: -1
	private static int CalculateSize(int size) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1FF9360 Offset: 0x1FF9461 VA: 0x1FF9360
	|-ArrayPool<UniTask<object>>.CalculateSize
	|
	|-RVA: 0x1FF9D60 Offset: 0x1FF9E61 VA: 0x1FF9D60
	|-ArrayPool<CancellationTokenRegistration>.CalculateSize
	|
	|-RVA: 0x1FFA760 Offset: 0x1FFA861 VA: 0x1FFA760
	|-ArrayPool<object>.CalculateSize
	|
	|-RVA: 0x1FFB160 Offset: 0x1FFB261 VA: 0x1FFB160
	|-ArrayPool<UniTask>.CalculateSize
	*/

	// RVA: -1 Offset: -1
	private static int GetQueueIndex(int size) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1FF9390 Offset: 0x1FF9491 VA: 0x1FF9390
	|-ArrayPool<UniTask<object>>.GetQueueIndex
	|
	|-RVA: 0x1FF9D90 Offset: 0x1FF9E91 VA: 0x1FF9D90
	|-ArrayPool<CancellationTokenRegistration>.GetQueueIndex
	|
	|-RVA: 0x1FFA790 Offset: 0x1FFA891 VA: 0x1FFA790
	|-ArrayPool<object>.GetQueueIndex
	|
	|-RVA: 0x1FFB190 Offset: 0x1FFB291 VA: 0x1FFB190
	|-ArrayPool<UniTask>.GetQueueIndex
	*/

	// RVA: -1 Offset: -1
	private static void .cctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1FF94C0 Offset: 0x1FF95C1 VA: 0x1FF94C0
	|-ArrayPool<UniTask<object>>..cctor
	|
	|-RVA: 0x1FF9EC0 Offset: 0x1FF9FC1 VA: 0x1FF9EC0
	|-ArrayPool<CancellationTokenRegistration>..cctor
	|
	|-RVA: 0x1FFA8C0 Offset: 0x1FFA9C1 VA: 0x1FFA8C0
	|-ArrayPool<object>..cctor
	|
	|-RVA: 0x1FFB2C0 Offset: 0x1FFB3C1 VA: 0x1FFB2C0
	|-ArrayPool<UniTask>..cctor
	*/
}

