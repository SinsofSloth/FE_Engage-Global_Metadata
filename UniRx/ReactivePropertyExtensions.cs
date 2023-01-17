// Namespace: UniRx
[ExtensionAttribute] // RVA: 0x134C0 Offset: 0x135C1 VA: 0x134C0
public static class ReactivePropertyExtensions // TypeDefIndex: 6771
{
	// Methods

	[ExtensionAttribute] // RVA: 0x175C0 Offset: 0x176C1 VA: 0x175C0
	// RVA: -1 Offset: -1
	public static IReadOnlyReactiveProperty<T> ToReactiveProperty<T>(IObservable<T> source) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x20159F0 Offset: 0x2015AF1 VA: 0x20159F0
	|-ReactivePropertyExtensions.ToReactiveProperty<bool>
	|
	|-RVA: 0x2015A60 Offset: 0x2015B61 VA: 0x2015A60
	|-ReactivePropertyExtensions.ToReactiveProperty<object>
	*/

	[ExtensionAttribute] // RVA: 0x175D0 Offset: 0x176D1 VA: 0x175D0
	// RVA: -1 Offset: -1
	public static IReadOnlyReactiveProperty<T> ToReactiveProperty<T>(IObservable<T> source, T initialValue) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2015AD0 Offset: 0x2015BD1 VA: 0x2015AD0
	|-ReactivePropertyExtensions.ToReactiveProperty<object>
	*/

	[ExtensionAttribute] // RVA: 0x175E0 Offset: 0x176E1 VA: 0x175E0
	// RVA: -1 Offset: -1
	public static ReadOnlyReactiveProperty<T> ToReadOnlyReactiveProperty<T>(IObservable<T> source) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2015B40 Offset: 0x2015C41 VA: 0x2015B40
	|-ReactivePropertyExtensions.ToReadOnlyReactiveProperty<object>
	*/

	[ExtensionAttribute] // RVA: 0x175F0 Offset: 0x176F1 VA: 0x175F0
	// RVA: -1 Offset: -1
	public static UniTask.Awaiter<T> GetAwaiter<T>(IReadOnlyReactiveProperty<T> source) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x20157A0 Offset: 0x20158A1 VA: 0x20157A0
	|-ReactivePropertyExtensions.GetAwaiter<object>
	*/

	[ExtensionAttribute] // RVA: 0x17600 Offset: 0x17701 VA: 0x17600
	// RVA: -1 Offset: -1
	public static ReadOnlyReactiveProperty<T> ToSequentialReadOnlyReactiveProperty<T>(IObservable<T> source) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2015C20 Offset: 0x2015D21 VA: 0x2015C20
	|-ReactivePropertyExtensions.ToSequentialReadOnlyReactiveProperty<object>
	*/

	[ExtensionAttribute] // RVA: 0x17610 Offset: 0x17711 VA: 0x17610
	// RVA: -1 Offset: -1
	public static ReadOnlyReactiveProperty<T> ToReadOnlyReactiveProperty<T>(IObservable<T> source, T initialValue) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2015BB0 Offset: 0x2015CB1 VA: 0x2015BB0
	|-ReactivePropertyExtensions.ToReadOnlyReactiveProperty<object>
	*/

	[ExtensionAttribute] // RVA: 0x17620 Offset: 0x17721 VA: 0x17620
	// RVA: -1 Offset: -1
	public static ReadOnlyReactiveProperty<T> ToSequentialReadOnlyReactiveProperty<T>(IObservable<T> source, T initialValue) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2015C90 Offset: 0x2015D91 VA: 0x2015C90
	|-ReactivePropertyExtensions.ToSequentialReadOnlyReactiveProperty<object>
	*/

	[ExtensionAttribute] // RVA: 0x17630 Offset: 0x17731 VA: 0x17630
	// RVA: -1 Offset: -1
	public static IObservable<T> SkipLatestValueOnSubscribe<T>(IReadOnlyReactiveProperty<T> source) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x20158B0 Offset: 0x20159B1 VA: 0x20158B0
	|-ReactivePropertyExtensions.SkipLatestValueOnSubscribe<object>
	*/

	[ExtensionAttribute] // RVA: 0x17640 Offset: 0x17741 VA: 0x17640
	// RVA: 0x1AF47E0 Offset: 0x1AF48E1 VA: 0x1AF47E0
	public static IObservable<bool> CombineLatestValuesAreAllTrue(IEnumerable<IObservable<bool>> sources) { }

	[ExtensionAttribute] // RVA: 0x17650 Offset: 0x17751 VA: 0x17650
	// RVA: 0x1AF4980 Offset: 0x1AF4A81 VA: 0x1AF4980
	public static IObservable<bool> CombineLatestValuesAreAllFalse(IEnumerable<IObservable<bool>> sources) { }
}

