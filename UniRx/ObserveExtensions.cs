// Namespace: UniRx
[ExtensionAttribute] // RVA: 0x132E0 Offset: 0x133E1 VA: 0x132E0
public static class ObserveExtensions // TypeDefIndex: 6735
{
	// Methods

	[ExtensionAttribute] // RVA: 0x16C50 Offset: 0x16D51 VA: 0x16C50
	// RVA: -1 Offset: -1
	public static IObservable<TProperty> ObserveEveryValueChanged<TSource, TProperty>(TSource source, Func<TSource, TProperty> propertySelector, FrameCountType frameCountType = 0, bool fastDestroyCheck = False) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x297E580 Offset: 0x297E681 VA: 0x297E580
	|-ObserveExtensions.ObserveEveryValueChanged<object, object>
	*/

	[ExtensionAttribute] // RVA: 0x16C60 Offset: 0x16D61 VA: 0x16C60
	// RVA: -1 Offset: -1
	public static IObservable<TProperty> ObserveEveryValueChanged<TSource, TProperty>(TSource source, Func<TSource, TProperty> propertySelector, FrameCountType frameCountType, IEqualityComparer<TProperty> comparer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x297E640 Offset: 0x297E741 VA: 0x297E640
	|-ObserveExtensions.ObserveEveryValueChanged<object, object>
	*/

	[ExtensionAttribute] // RVA: 0x16C70 Offset: 0x16D71 VA: 0x16C70
	// RVA: -1 Offset: -1
	public static IObservable<TProperty> ObserveEveryValueChanged<TSource, TProperty>(TSource source, Func<TSource, TProperty> propertySelector, FrameCountType frameCountType, IEqualityComparer<TProperty> comparer, bool fastDestroyCheck) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x297E660 Offset: 0x297E761 VA: 0x297E660
	|-ObserveExtensions.ObserveEveryValueChanged<object, object>
	*/

	[IteratorStateMachineAttribute] // RVA: 0x16C80 Offset: 0x16D81 VA: 0x16C80
	// RVA: 0x19ECEE0 Offset: 0x19ECFE1 VA: 0x19ECEE0
	private static IEnumerator EmptyEnumerator() { }

	[IteratorStateMachineAttribute] // RVA: 0x16CF0 Offset: 0x16DF1 VA: 0x16CF0
	// RVA: -1 Offset: -1
	private static IEnumerator PublishPocoValueChanged<TSource, TProperty>(WeakReference sourceReference, TProperty firstValue, Func<TSource, TProperty> propertySelector, IEqualityComparer<TProperty> comparer, IObserver<TProperty> observer, CancellationToken cancellationToken) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x297E970 Offset: 0x297EA71 VA: 0x297E970
	|-ObserveExtensions.PublishPocoValueChanged<object, object>
	*/

	[IteratorStateMachineAttribute] // RVA: 0x16D60 Offset: 0x16E61 VA: 0x16D60
	// RVA: -1 Offset: -1
	private static IEnumerator PublishUnityObjectValueChanged<TSource, TProperty>(Object unityObject, TProperty firstValue, Func<TSource, TProperty> propertySelector, IEqualityComparer<TProperty> comparer, IObserver<TProperty> observer, CancellationToken cancellationToken, bool fastDestroyCheck) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x297EA60 Offset: 0x297EB61 VA: 0x297EA60
	|-ObserveExtensions.PublishUnityObjectValueChanged<object, object>
	*/

	// RVA: 0x19ECF40 Offset: 0x19ED041 VA: 0x19ECF40
	private static ObservableDestroyTrigger GetOrAddDestroyTrigger(GameObject go) { }
}

