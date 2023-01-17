// Namespace: UniRx
[ExtensionAttribute] // RVA: 0x12F20 Offset: 0x13021 VA: 0x12F20
public static class OptimizedObservableExtensions // TypeDefIndex: 6650
{
	// Methods

	[ExtensionAttribute] // RVA: 0x160F0 Offset: 0x161F1 VA: 0x160F0
	// RVA: -1 Offset: -1
	public static bool IsRequiredSubscribeOnCurrentThread<T>(IObservable<T> source) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2980010 Offset: 0x2980111 VA: 0x2980010
	|-OptimizedObservableExtensions.IsRequiredSubscribeOnCurrentThread<ValueTuple<object, object>>
	|
	|-RVA: 0x29800F0 Offset: 0x29801F1 VA: 0x29800F0
	|-OptimizedObservableExtensions.IsRequiredSubscribeOnCurrentThread<ValueTuple<float, int>>
	|
	|-RVA: 0x29801D0 Offset: 0x29802D1 VA: 0x29801D0
	|-OptimizedObservableExtensions.IsRequiredSubscribeOnCurrentThread<ValueTuple<float, Int32Enum>>
	|
	|-RVA: 0x29802B0 Offset: 0x29803B1 VA: 0x29802B0
	|-OptimizedObservableExtensions.IsRequiredSubscribeOnCurrentThread<bool>
	|
	|-RVA: 0x2980390 Offset: 0x2980491 VA: 0x2980390
	|-OptimizedObservableExtensions.IsRequiredSubscribeOnCurrentThread<int>
	|
	|-RVA: 0x2980470 Offset: 0x2980571 VA: 0x2980470
	|-OptimizedObservableExtensions.IsRequiredSubscribeOnCurrentThread<long>
	|
	|-RVA: 0x2980550 Offset: 0x2980651 VA: 0x2980550
	|-OptimizedObservableExtensions.IsRequiredSubscribeOnCurrentThread<object>
	|
	|-RVA: 0x2980630 Offset: 0x2980731 VA: 0x2980630
	|-OptimizedObservableExtensions.IsRequiredSubscribeOnCurrentThread<Unit>
	*/

	[ExtensionAttribute] // RVA: 0x16100 Offset: 0x16201 VA: 0x16100
	// RVA: -1 Offset: -1
	public static bool IsRequiredSubscribeOnCurrentThread<T>(IObservable<T> source, IScheduler scheduler) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2980710 Offset: 0x2980811 VA: 0x2980710
	|-OptimizedObservableExtensions.IsRequiredSubscribeOnCurrentThread<object>
	*/
}

