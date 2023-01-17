// Namespace: UniRx
[ExtensionAttribute] // RVA: 0x12940 Offset: 0x12A41 VA: 0x12940
public static class Observable // TypeDefIndex: 6536
{
	// Fields
	private static readonly TimeSpan InfiniteTimeSpan; // 0x0
	private static readonly HashSet<Type> YieldInstructionTypes; // 0x8

	// Methods

	// RVA: -1 Offset: -1
	private static IObservable<T> AddRef<T>(IObservable<T> xs, RefCountDisposable r) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x296A720 Offset: 0x296A821 VA: 0x296A720
	|-Observable.AddRef<object>
	*/

	[ExtensionAttribute] // RVA: 0x14010 Offset: 0x14111 VA: 0x14010
	// RVA: -1 Offset: -1
	public static IObservable<TSource> Scan<TSource>(IObservable<TSource> source, Func<TSource, TSource, TSource> accumulator) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2976060 Offset: 0x2976161 VA: 0x2976060
	|-Observable.Scan<object>
	*/

	[ExtensionAttribute] // RVA: 0x14020 Offset: 0x14121 VA: 0x14020
	// RVA: -1 Offset: -1
	public static IObservable<TAccumulate> Scan<TSource, TAccumulate>(IObservable<TSource> source, TAccumulate seed, Func<TAccumulate, TSource, TAccumulate> accumulator) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x29760D0 Offset: 0x29761D1 VA: 0x29760D0
	|-Observable.Scan<object, object>
	|
	|-RVA: 0x2976150 Offset: 0x2976251 VA: 0x2976150
	|-Observable.Scan<Unit, long>
	*/

	[ExtensionAttribute] // RVA: 0x14030 Offset: 0x14131 VA: 0x14030
	// RVA: -1 Offset: -1
	public static IObservable<TSource> Aggregate<TSource>(IObservable<TSource> source, Func<TSource, TSource, TSource> accumulator) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x296A840 Offset: 0x296A941 VA: 0x296A840
	|-Observable.Aggregate<object>
	*/

	[ExtensionAttribute] // RVA: 0x14040 Offset: 0x14141 VA: 0x14040
	// RVA: -1 Offset: -1
	public static IObservable<TAccumulate> Aggregate<TSource, TAccumulate>(IObservable<TSource> source, TAccumulate seed, Func<TAccumulate, TSource, TAccumulate> accumulator) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x296A8B0 Offset: 0x296A9B1 VA: 0x296A8B0
	|-Observable.Aggregate<object, object>
	*/

	[ExtensionAttribute] // RVA: 0x14050 Offset: 0x14151 VA: 0x14050
	// RVA: -1 Offset: -1
	public static IObservable<TResult> Aggregate<TSource, TAccumulate, TResult>(IObservable<TSource> source, TAccumulate seed, Func<TAccumulate, TSource, TAccumulate> accumulator, Func<TAccumulate, TResult> resultSelector) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x296A930 Offset: 0x296AA31 VA: 0x296A930
	|-Observable.Aggregate<object, object, object>
	*/

	[ExtensionAttribute] // RVA: 0x14060 Offset: 0x14161 VA: 0x14060
	// RVA: -1 Offset: -1
	public static AsyncSubject<TSource> GetAwaiter<TSource>(IObservable<TSource> source) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x29713D0 Offset: 0x29714D1 VA: 0x29713D0
	|-Observable.GetAwaiter<object>
	*/

	[ExtensionAttribute] // RVA: 0x14070 Offset: 0x14171 VA: 0x14070
	// RVA: -1 Offset: -1
	public static AsyncSubject<TSource> GetAwaiter<TSource>(IConnectableObservable<TSource> source) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x29714D0 Offset: 0x29715D1 VA: 0x29714D0
	|-Observable.GetAwaiter<object>
	*/

	[ExtensionAttribute] // RVA: 0x14080 Offset: 0x14181 VA: 0x14080
	// RVA: -1 Offset: -1
	public static AsyncSubject<TSource> GetAwaiter<TSource>(IObservable<TSource> source, CancellationToken cancellationToken) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x29715D0 Offset: 0x29716D1 VA: 0x29715D0
	|-Observable.GetAwaiter<object>
	*/

	[ExtensionAttribute] // RVA: 0x14090 Offset: 0x14191 VA: 0x14090
	// RVA: -1 Offset: -1
	public static AsyncSubject<TSource> GetAwaiter<TSource>(IConnectableObservable<TSource> source, CancellationToken cancellationToken) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x29716A0 Offset: 0x29717A1 VA: 0x29716A0
	|-Observable.GetAwaiter<object>
	*/

	// RVA: -1 Offset: -1
	private static AsyncSubject<TSource> RunAsync<TSource>(IObservable<TSource> source, CancellationToken cancellationToken) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2975A30 Offset: 0x2975B31 VA: 0x2975A30
	|-Observable.RunAsync<object>
	*/

	// RVA: -1 Offset: -1
	private static AsyncSubject<TSource> RunAsync<TSource>(IConnectableObservable<TSource> source, CancellationToken cancellationToken) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2975BD0 Offset: 0x2975CD1 VA: 0x2975BD0
	|-Observable.RunAsync<object>
	*/

	// RVA: -1 Offset: -1
	private static AsyncSubject<T> Cancel<T>(AsyncSubject<T> subject, CancellationToken cancellationToken) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x296B9D0 Offset: 0x296BAD1 VA: 0x296B9D0
	|-Observable.Cancel<object>
	*/

	// RVA: -1 Offset: -1
	private static void RegisterCancelation<T>(AsyncSubject<T> subject, IDisposable subscription, CancellationToken token) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x29743E0 Offset: 0x29744E1 VA: 0x29743E0
	|-Observable.RegisterCancelation<object>
	*/

	[ExtensionAttribute] // RVA: 0x140A0 Offset: 0x141A1 VA: 0x140A0
	// RVA: -1 Offset: -1
	public static IConnectableObservable<T> Multicast<T>(IObservable<T> source, ISubject<T> subject) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x29729D0 Offset: 0x2972AD1 VA: 0x29729D0
	|-Observable.Multicast<object>
	*/

	[ExtensionAttribute] // RVA: 0x140B0 Offset: 0x141B1 VA: 0x140B0
	// RVA: -1 Offset: -1
	public static IConnectableObservable<T> Publish<T>(IObservable<T> source) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2974150 Offset: 0x2974251 VA: 0x2974150
	|-Observable.Publish<object>
	*/

	[ExtensionAttribute] // RVA: 0x140C0 Offset: 0x141C1 VA: 0x140C0
	// RVA: -1 Offset: -1
	public static IConnectableObservable<T> Publish<T>(IObservable<T> source, T initialValue) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2974200 Offset: 0x2974301 VA: 0x2974200
	|-Observable.Publish<object>
	*/

	[ExtensionAttribute] // RVA: 0x140D0 Offset: 0x141D1 VA: 0x140D0
	// RVA: -1 Offset: -1
	public static IConnectableObservable<T> PublishLast<T>(IObservable<T> source) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x29742C0 Offset: 0x29743C1 VA: 0x29742C0
	|-Observable.PublishLast<object>
	*/

	[ExtensionAttribute] // RVA: 0x140E0 Offset: 0x141E1 VA: 0x140E0
	// RVA: -1 Offset: -1
	public static IConnectableObservable<T> Replay<T>(IObservable<T> source) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x29750C0 Offset: 0x29751C1 VA: 0x29750C0
	|-Observable.Replay<object>
	*/

	[ExtensionAttribute] // RVA: 0x140F0 Offset: 0x141F1 VA: 0x140F0
	// RVA: -1 Offset: -1
	public static IConnectableObservable<T> Replay<T>(IObservable<T> source, IScheduler scheduler) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x29752F0 Offset: 0x29753F1 VA: 0x29752F0
	|-Observable.Replay<object>
	*/

	[ExtensionAttribute] // RVA: 0x14100 Offset: 0x14201 VA: 0x14100
	// RVA: -1 Offset: -1
	public static IConnectableObservable<T> Replay<T>(IObservable<T> source, int bufferSize) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2975170 Offset: 0x2975271 VA: 0x2975170
	|-Observable.Replay<object>
	*/

	[ExtensionAttribute] // RVA: 0x14110 Offset: 0x14211 VA: 0x14110
	// RVA: -1 Offset: -1
	public static IConnectableObservable<T> Replay<T>(IObservable<T> source, int bufferSize, IScheduler scheduler) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x29753B0 Offset: 0x29754B1 VA: 0x29753B0
	|-Observable.Replay<object>
	*/

	[ExtensionAttribute] // RVA: 0x14120 Offset: 0x14221 VA: 0x14120
	// RVA: -1 Offset: -1
	public static IConnectableObservable<T> Replay<T>(IObservable<T> source, TimeSpan window) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2975230 Offset: 0x2975331 VA: 0x2975230
	|-Observable.Replay<object>
	*/

	[ExtensionAttribute] // RVA: 0x14130 Offset: 0x14231 VA: 0x14130
	// RVA: -1 Offset: -1
	public static IConnectableObservable<T> Replay<T>(IObservable<T> source, TimeSpan window, IScheduler scheduler) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2975480 Offset: 0x2975581 VA: 0x2975480
	|-Observable.Replay<object>
	*/

	[ExtensionAttribute] // RVA: 0x14140 Offset: 0x14241 VA: 0x14140
	// RVA: -1 Offset: -1
	public static IConnectableObservable<T> Replay<T>(IObservable<T> source, int bufferSize, TimeSpan window, IScheduler scheduler) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2975550 Offset: 0x2975651 VA: 0x2975550
	|-Observable.Replay<object>
	*/

	[ExtensionAttribute] // RVA: 0x14150 Offset: 0x14251 VA: 0x14150
	// RVA: -1 Offset: -1
	public static IObservable<T> RefCount<T>(IConnectableObservable<T> source) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2974370 Offset: 0x2974471 VA: 0x2974370
	|-Observable.RefCount<object>
	*/

	[ExtensionAttribute] // RVA: 0x14160 Offset: 0x14261 VA: 0x14160
	// RVA: -1 Offset: -1
	public static IObservable<T> Share<T>(IObservable<T> source) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2976E60 Offset: 0x2976F61 VA: 0x2976E60
	|-Observable.Share<object>
	*/

	[ExtensionAttribute] // RVA: 0x14170 Offset: 0x14271 VA: 0x14170
	// RVA: -1 Offset: -1
	public static T Wait<T>(IObservable<T> source) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x297AF80 Offset: 0x297B081 VA: 0x297AF80
	|-Observable.Wait<object>
	*/

	[ExtensionAttribute] // RVA: 0x14180 Offset: 0x14281 VA: 0x14180
	// RVA: -1 Offset: -1
	public static T Wait<T>(IObservable<T> source, TimeSpan timeout) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x297B040 Offset: 0x297B141 VA: 0x297B040
	|-Observable.Wait<object>
	*/

	[IteratorStateMachineAttribute] // RVA: 0x14190 Offset: 0x14291 VA: 0x14190
	// RVA: -1 Offset: -1
	private static IEnumerable<IObservable<T>> CombineSources<T>(IObservable<T> first, IObservable<T>[] seconds) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x296C440 Offset: 0x296C541 VA: 0x296C440
	|-Observable.CombineSources<object>
	*/

	// RVA: -1 Offset: -1
	public static IObservable<TSource> Concat<TSource>(IObservable<TSource>[] sources) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x296C600 Offset: 0x296C701 VA: 0x296C600
	|-Observable.Concat<object>
	*/

	[ExtensionAttribute] // RVA: 0x14200 Offset: 0x14301 VA: 0x14200
	// RVA: -1 Offset: -1
	public static IObservable<TSource> Concat<TSource>(IEnumerable<IObservable<TSource>> sources) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x296C4D0 Offset: 0x296C5D1 VA: 0x296C4D0
	|-Observable.Concat<object>
	|
	|-RVA: 0x296C6B0 Offset: 0x296C7B1 VA: 0x296C6B0
	|-Observable.Concat<Unit>
	*/

	[ExtensionAttribute] // RVA: 0x14210 Offset: 0x14311 VA: 0x14210
	// RVA: -1 Offset: -1
	public static IObservable<TSource> Concat<TSource>(IObservable<IObservable<TSource>> sources) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x296C580 Offset: 0x296C681 VA: 0x296C580
	|-Observable.Concat<object>
	*/

	[ExtensionAttribute] // RVA: 0x14220 Offset: 0x14321 VA: 0x14220
	// RVA: -1 Offset: -1
	public static IObservable<TSource> Concat<TSource>(IObservable<TSource> first, IObservable<TSource>[] seconds) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x296C760 Offset: 0x296C861 VA: 0x296C760
	|-Observable.Concat<object>
	*/

	[ExtensionAttribute] // RVA: 0x14230 Offset: 0x14331 VA: 0x14230
	// RVA: -1 Offset: -1
	public static IObservable<TSource> Merge<TSource>(IEnumerable<IObservable<TSource>> sources) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2972290 Offset: 0x2972391 VA: 0x2972290
	|-Observable.Merge<object>
	*/

	[ExtensionAttribute] // RVA: 0x14240 Offset: 0x14341 VA: 0x14240
	// RVA: -1 Offset: -1
	public static IObservable<TSource> Merge<TSource>(IEnumerable<IObservable<TSource>> sources, IScheduler scheduler) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2972560 Offset: 0x2972661 VA: 0x2972560
	|-Observable.Merge<object>
	*/

	[ExtensionAttribute] // RVA: 0x14250 Offset: 0x14351 VA: 0x14250
	// RVA: -1 Offset: -1
	public static IObservable<TSource> Merge<TSource>(IEnumerable<IObservable<TSource>> sources, int maxConcurrent) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x29724C0 Offset: 0x29725C1 VA: 0x29724C0
	|-Observable.Merge<object>
	*/

	[ExtensionAttribute] // RVA: 0x14260 Offset: 0x14361 VA: 0x14260
	// RVA: -1 Offset: -1
	public static IObservable<TSource> Merge<TSource>(IEnumerable<IObservable<TSource>> sources, int maxConcurrent, IScheduler scheduler) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x29728B0 Offset: 0x29729B1 VA: 0x29728B0
	|-Observable.Merge<object>
	*/

	// RVA: -1 Offset: -1
	public static IObservable<TSource> Merge<TSource>(IObservable<TSource>[] sources) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2972320 Offset: 0x2972421 VA: 0x2972320
	|-Observable.Merge<object>
	*/

	// RVA: -1 Offset: -1
	public static IObservable<TSource> Merge<TSource>(IScheduler scheduler, IObservable<TSource>[] sources) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2972670 Offset: 0x2972771 VA: 0x2972670
	|-Observable.Merge<object>
	*/

	[ExtensionAttribute] // RVA: 0x14270 Offset: 0x14371 VA: 0x14270
	// RVA: -1 Offset: -1
	public static IObservable<T> Merge<T>(IObservable<T> first, IObservable<T>[] seconds) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2972420 Offset: 0x2972521 VA: 0x2972420
	|-Observable.Merge<object>
	*/

	[ExtensionAttribute] // RVA: 0x14280 Offset: 0x14381 VA: 0x14280
	// RVA: -1 Offset: -1
	public static IObservable<T> Merge<T>(IObservable<T> first, IObservable<T> second, IScheduler scheduler) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2972780 Offset: 0x2972881 VA: 0x2972780
	|-Observable.Merge<object>
	*/

	[ExtensionAttribute] // RVA: 0x14290 Offset: 0x14391 VA: 0x14290
	// RVA: -1 Offset: -1
	public static IObservable<T> Merge<T>(IObservable<IObservable<T>> sources) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2972220 Offset: 0x2972321 VA: 0x2972220
	|-Observable.Merge<object>
	*/

	[ExtensionAttribute] // RVA: 0x142A0 Offset: 0x143A1 VA: 0x142A0
	// RVA: -1 Offset: -1
	public static IObservable<T> Merge<T>(IObservable<IObservable<T>> sources, int maxConcurrent) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x29723B0 Offset: 0x29724B1 VA: 0x29723B0
	|-Observable.Merge<object>
	*/

	[ExtensionAttribute] // RVA: 0x142B0 Offset: 0x143B1 VA: 0x142B0
	// RVA: -1 Offset: -1
	public static IObservable<TResult> Zip<TLeft, TRight, TResult>(IObservable<TLeft> left, IObservable<TRight> right, Func<TLeft, TRight, TResult> selector) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x297B770 Offset: 0x297B871 VA: 0x297B770
	|-Observable.Zip<object, object, object>
	*/

	[ExtensionAttribute] // RVA: 0x142C0 Offset: 0x143C1 VA: 0x142C0
	// RVA: -1 Offset: -1
	public static IObservable<IList<T>> Zip<T>(IEnumerable<IObservable<T>> sources) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x297B670 Offset: 0x297B771 VA: 0x297B670
	|-Observable.Zip<object>
	*/

	// RVA: -1 Offset: -1
	public static IObservable<IList<T>> Zip<T>(IObservable<T>[] sources) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x297B700 Offset: 0x297B801 VA: 0x297B700
	|-Observable.Zip<object>
	*/

	[ExtensionAttribute] // RVA: 0x142D0 Offset: 0x143D1 VA: 0x142D0
	// RVA: -1 Offset: -1
	public static IObservable<TR> Zip<T1, T2, T3, TR>(IObservable<T1> source1, IObservable<T2> source2, IObservable<T3> source3, ZipFunc<T1, T2, T3, TR> resultSelector) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x297B7F0 Offset: 0x297B8F1 VA: 0x297B7F0
	|-Observable.Zip<object, object, object, object>
	*/

	[ExtensionAttribute] // RVA: 0x142E0 Offset: 0x143E1 VA: 0x142E0
	// RVA: -1 Offset: -1
	public static IObservable<TR> Zip<T1, T2, T3, T4, TR>(IObservable<T1> source1, IObservable<T2> source2, IObservable<T3> source3, IObservable<T4> source4, ZipFunc<T1, T2, T3, T4, TR> resultSelector) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x297B880 Offset: 0x297B981 VA: 0x297B880
	|-Observable.Zip<object, object, object, object, object>
	*/

	[ExtensionAttribute] // RVA: 0x142F0 Offset: 0x143F1 VA: 0x142F0
	// RVA: -1 Offset: -1
	public static IObservable<TR> Zip<T1, T2, T3, T4, T5, TR>(IObservable<T1> source1, IObservable<T2> source2, IObservable<T3> source3, IObservable<T4> source4, IObservable<T5> source5, ZipFunc<T1, T2, T3, T4, T5, TR> resultSelector) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x297B920 Offset: 0x297BA21 VA: 0x297B920
	|-Observable.Zip<object, object, object, object, object, object>
	*/

	[ExtensionAttribute] // RVA: 0x14300 Offset: 0x14401 VA: 0x14300
	// RVA: -1 Offset: -1
	public static IObservable<TR> Zip<T1, T2, T3, T4, T5, T6, TR>(IObservable<T1> source1, IObservable<T2> source2, IObservable<T3> source3, IObservable<T4> source4, IObservable<T5> source5, IObservable<T6> source6, ZipFunc<T1, T2, T3, T4, T5, T6, TR> resultSelector) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x297B9C0 Offset: 0x297BAC1 VA: 0x297B9C0
	|-Observable.Zip<object, object, object, object, object, object, object>
	*/

	[ExtensionAttribute] // RVA: 0x14310 Offset: 0x14411 VA: 0x14310
	// RVA: -1 Offset: -1
	public static IObservable<TR> Zip<T1, T2, T3, T4, T5, T6, T7, TR>(IObservable<T1> source1, IObservable<T2> source2, IObservable<T3> source3, IObservable<T4> source4, IObservable<T5> source5, IObservable<T6> source6, IObservable<T7> source7, ZipFunc<T1, T2, T3, T4, T5, T6, T7, TR> resultSelector) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x297BA80 Offset: 0x297BB81 VA: 0x297BA80
	|-Observable.Zip<object, object, object, object, object, object, object, object>
	*/

	[ExtensionAttribute] // RVA: 0x14320 Offset: 0x14421 VA: 0x14320
	// RVA: -1 Offset: -1
	public static IObservable<TResult> CombineLatest<TLeft, TRight, TResult>(IObservable<TLeft> left, IObservable<TRight> right, Func<TLeft, TRight, TResult> selector) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x296BFF0 Offset: 0x296C0F1 VA: 0x296BFF0
	|-Observable.CombineLatest<bool, bool, bool>
	|
	|-RVA: 0x296C070 Offset: 0x296C171 VA: 0x296C070
	|-Observable.CombineLatest<object, object, object>
	*/

	[ExtensionAttribute] // RVA: 0x14330 Offset: 0x14431 VA: 0x14330
	// RVA: -1 Offset: -1
	public static IObservable<IList<T>> CombineLatest<T>(IEnumerable<IObservable<T>> sources) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x296BDF0 Offset: 0x296BEF1 VA: 0x296BDF0
	|-Observable.CombineLatest<bool>
	|
	|-RVA: 0x296BEF0 Offset: 0x296BFF1 VA: 0x296BEF0
	|-Observable.CombineLatest<object>
	*/

	// RVA: -1 Offset: -1
	public static IObservable<IList<TSource>> CombineLatest<TSource>(IObservable<TSource>[] sources) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x296BE80 Offset: 0x296BF81 VA: 0x296BE80
	|-Observable.CombineLatest<bool>
	|
	|-RVA: 0x296BF80 Offset: 0x296C081 VA: 0x296BF80
	|-Observable.CombineLatest<object>
	*/

	[ExtensionAttribute] // RVA: 0x14340 Offset: 0x14441 VA: 0x14340
	// RVA: -1 Offset: -1
	public static IObservable<TR> CombineLatest<T1, T2, T3, TR>(IObservable<T1> source1, IObservable<T2> source2, IObservable<T3> source3, CombineLatestFunc<T1, T2, T3, TR> resultSelector) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x296C0F0 Offset: 0x296C1F1 VA: 0x296C0F0
	|-Observable.CombineLatest<object, object, object, object>
	*/

	[ExtensionAttribute] // RVA: 0x14350 Offset: 0x14451 VA: 0x14350
	// RVA: -1 Offset: -1
	public static IObservable<TR> CombineLatest<T1, T2, T3, T4, TR>(IObservable<T1> source1, IObservable<T2> source2, IObservable<T3> source3, IObservable<T4> source4, CombineLatestFunc<T1, T2, T3, T4, TR> resultSelector) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x296C180 Offset: 0x296C281 VA: 0x296C180
	|-Observable.CombineLatest<object, object, object, object, object>
	*/

	[ExtensionAttribute] // RVA: 0x14360 Offset: 0x14461 VA: 0x14360
	// RVA: -1 Offset: -1
	public static IObservable<TR> CombineLatest<T1, T2, T3, T4, T5, TR>(IObservable<T1> source1, IObservable<T2> source2, IObservable<T3> source3, IObservable<T4> source4, IObservable<T5> source5, CombineLatestFunc<T1, T2, T3, T4, T5, TR> resultSelector) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x296C220 Offset: 0x296C321 VA: 0x296C220
	|-Observable.CombineLatest<object, object, object, object, object, object>
	*/

	[ExtensionAttribute] // RVA: 0x14370 Offset: 0x14471 VA: 0x14370
	// RVA: -1 Offset: -1
	public static IObservable<TR> CombineLatest<T1, T2, T3, T4, T5, T6, TR>(IObservable<T1> source1, IObservable<T2> source2, IObservable<T3> source3, IObservable<T4> source4, IObservable<T5> source5, IObservable<T6> source6, CombineLatestFunc<T1, T2, T3, T4, T5, T6, TR> resultSelector) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x296C2C0 Offset: 0x296C3C1 VA: 0x296C2C0
	|-Observable.CombineLatest<object, object, object, object, object, object, object>
	*/

	[ExtensionAttribute] // RVA: 0x14380 Offset: 0x14481 VA: 0x14380
	// RVA: -1 Offset: -1
	public static IObservable<TR> CombineLatest<T1, T2, T3, T4, T5, T6, T7, TR>(IObservable<T1> source1, IObservable<T2> source2, IObservable<T3> source3, IObservable<T4> source4, IObservable<T5> source5, IObservable<T6> source6, IObservable<T7> source7, CombineLatestFunc<T1, T2, T3, T4, T5, T6, T7, TR> resultSelector) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x296C380 Offset: 0x296C481 VA: 0x296C380
	|-Observable.CombineLatest<object, object, object, object, object, object, object, object>
	*/

	[ExtensionAttribute] // RVA: 0x14390 Offset: 0x14491 VA: 0x14390
	// RVA: -1 Offset: -1
	public static IObservable<TResult> ZipLatest<TLeft, TRight, TResult>(IObservable<TLeft> left, IObservable<TRight> right, Func<TLeft, TRight, TResult> selector) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x297BC40 Offset: 0x297BD41 VA: 0x297BC40
	|-Observable.ZipLatest<object, object, object>
	*/

	[ExtensionAttribute] // RVA: 0x143A0 Offset: 0x144A1 VA: 0x143A0
	// RVA: -1 Offset: -1
	public static IObservable<IList<T>> ZipLatest<T>(IEnumerable<IObservable<T>> sources) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x297BB40 Offset: 0x297BC41 VA: 0x297BB40
	|-Observable.ZipLatest<object>
	*/

	// RVA: -1 Offset: -1
	public static IObservable<IList<TSource>> ZipLatest<TSource>(IObservable<TSource>[] sources) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x297BBD0 Offset: 0x297BCD1 VA: 0x297BBD0
	|-Observable.ZipLatest<object>
	*/

	[ExtensionAttribute] // RVA: 0x143B0 Offset: 0x144B1 VA: 0x143B0
	// RVA: -1 Offset: -1
	public static IObservable<TR> ZipLatest<T1, T2, T3, TR>(IObservable<T1> source1, IObservable<T2> source2, IObservable<T3> source3, ZipLatestFunc<T1, T2, T3, TR> resultSelector) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x297BCC0 Offset: 0x297BDC1 VA: 0x297BCC0
	|-Observable.ZipLatest<object, object, object, object>
	*/

	[ExtensionAttribute] // RVA: 0x143C0 Offset: 0x144C1 VA: 0x143C0
	// RVA: -1 Offset: -1
	public static IObservable<TR> ZipLatest<T1, T2, T3, T4, TR>(IObservable<T1> source1, IObservable<T2> source2, IObservable<T3> source3, IObservable<T4> source4, ZipLatestFunc<T1, T2, T3, T4, TR> resultSelector) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x297BD50 Offset: 0x297BE51 VA: 0x297BD50
	|-Observable.ZipLatest<object, object, object, object, object>
	*/

	[ExtensionAttribute] // RVA: 0x143D0 Offset: 0x144D1 VA: 0x143D0
	// RVA: -1 Offset: -1
	public static IObservable<TR> ZipLatest<T1, T2, T3, T4, T5, TR>(IObservable<T1> source1, IObservable<T2> source2, IObservable<T3> source3, IObservable<T4> source4, IObservable<T5> source5, ZipLatestFunc<T1, T2, T3, T4, T5, TR> resultSelector) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x297BDF0 Offset: 0x297BEF1 VA: 0x297BDF0
	|-Observable.ZipLatest<object, object, object, object, object, object>
	*/

	[ExtensionAttribute] // RVA: 0x143E0 Offset: 0x144E1 VA: 0x143E0
	// RVA: -1 Offset: -1
	public static IObservable<TR> ZipLatest<T1, T2, T3, T4, T5, T6, TR>(IObservable<T1> source1, IObservable<T2> source2, IObservable<T3> source3, IObservable<T4> source4, IObservable<T5> source5, IObservable<T6> source6, ZipLatestFunc<T1, T2, T3, T4, T5, T6, TR> resultSelector) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x297BE90 Offset: 0x297BF91 VA: 0x297BE90
	|-Observable.ZipLatest<object, object, object, object, object, object, object>
	*/

	[ExtensionAttribute] // RVA: 0x143F0 Offset: 0x144F1 VA: 0x143F0
	// RVA: -1 Offset: -1
	public static IObservable<TR> ZipLatest<T1, T2, T3, T4, T5, T6, T7, TR>(IObservable<T1> source1, IObservable<T2> source2, IObservable<T3> source3, IObservable<T4> source4, IObservable<T5> source5, IObservable<T6> source6, IObservable<T7> source7, ZipLatestFunc<T1, T2, T3, T4, T5, T6, T7, TR> resultSelector) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x297BF50 Offset: 0x297C051 VA: 0x297BF50
	|-Observable.ZipLatest<object, object, object, object, object, object, object, object>
	*/

	[ExtensionAttribute] // RVA: 0x14400 Offset: 0x14501 VA: 0x14400
	// RVA: -1 Offset: -1
	public static IObservable<T> Switch<T>(IObservable<IObservable<T>> sources) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x29783D0 Offset: 0x29784D1 VA: 0x29783D0
	|-Observable.Switch<object>
	*/

	[ExtensionAttribute] // RVA: 0x14410 Offset: 0x14511 VA: 0x14410
	// RVA: -1 Offset: -1
	public static IObservable<TResult> WithLatestFrom<TLeft, TRight, TResult>(IObservable<TLeft> left, IObservable<TRight> right, Func<TLeft, TRight, TResult> selector) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x297B490 Offset: 0x297B591 VA: 0x297B490
	|-Observable.WithLatestFrom<object, object, object>
	*/

	// RVA: -1 Offset: -1
	public static IObservable<T[]> WhenAll<T>(IObservable<T>[] sources) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x297B1D0 Offset: 0x297B2D1 VA: 0x297B1D0
	|-Observable.WhenAll<object>
	*/

	// RVA: 0x19D7190 Offset: 0x19D7291 VA: 0x19D7190
	public static IObservable<Unit> WhenAll(IObservable<Unit>[] sources) { }

	[ExtensionAttribute] // RVA: 0x14420 Offset: 0x14521 VA: 0x14420
	// RVA: -1 Offset: -1
	public static IObservable<T[]> WhenAll<T>(IEnumerable<IObservable<T>> sources) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x297B0C0 Offset: 0x297B1C1 VA: 0x297B0C0
	|-Observable.WhenAll<object>
	*/

	[ExtensionAttribute] // RVA: 0x14430 Offset: 0x14531 VA: 0x14430
	// RVA: 0x19D72A0 Offset: 0x19D73A1 VA: 0x19D72A0
	public static IObservable<Unit> WhenAll(IEnumerable<IObservable<Unit>> sources) { }

	[ExtensionAttribute] // RVA: 0x14440 Offset: 0x14541 VA: 0x14440
	// RVA: -1 Offset: -1
	public static IObservable<T> StartWith<T>(IObservable<T> source, T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2977E60 Offset: 0x2977F61 VA: 0x2977E60
	|-Observable.StartWith<object>
	*/

	[ExtensionAttribute] // RVA: 0x14450 Offset: 0x14551 VA: 0x14450
	// RVA: -1 Offset: -1
	public static IObservable<T> StartWith<T>(IObservable<T> source, Func<T> valueFactory) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2977CE0 Offset: 0x2977DE1 VA: 0x2977CE0
	|-Observable.StartWith<int>
	|
	|-RVA: 0x2977DF0 Offset: 0x2977EF1 VA: 0x2977DF0
	|-Observable.StartWith<object>
	*/

	[ExtensionAttribute] // RVA: 0x14460 Offset: 0x14561 VA: 0x14460
	// RVA: -1 Offset: -1
	public static IObservable<T> StartWith<T>(IObservable<T> source, T[] values) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2977ED0 Offset: 0x2977FD1 VA: 0x2977ED0
	|-Observable.StartWith<object>
	*/

	[ExtensionAttribute] // RVA: 0x14470 Offset: 0x14571 VA: 0x14470
	// RVA: -1 Offset: -1
	public static IObservable<T> StartWith<T>(IObservable<T> source, IEnumerable<T> values) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2977D50 Offset: 0x2977E51 VA: 0x2977D50
	|-Observable.StartWith<object>
	*/

	[ExtensionAttribute] // RVA: 0x14480 Offset: 0x14581 VA: 0x14480
	// RVA: -1 Offset: -1
	public static IObservable<T> StartWith<T>(IObservable<T> source, IScheduler scheduler, T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2978060 Offset: 0x2978161 VA: 0x2978060
	|-Observable.StartWith<object>
	*/

	[ExtensionAttribute] // RVA: 0x14490 Offset: 0x14591 VA: 0x14490
	// RVA: -1 Offset: -1
	public static IObservable<T> StartWith<T>(IObservable<T> source, IScheduler scheduler, IEnumerable<T> values) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2977F70 Offset: 0x2978071 VA: 0x2977F70
	|-Observable.StartWith<object>
	*/

	[ExtensionAttribute] // RVA: 0x144A0 Offset: 0x145A1 VA: 0x144A0
	// RVA: -1 Offset: -1
	public static IObservable<T> StartWith<T>(IObservable<T> source, IScheduler scheduler, T[] values) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2978180 Offset: 0x2978281 VA: 0x2978180
	|-Observable.StartWith<object>
	*/

	[ExtensionAttribute] // RVA: 0x144B0 Offset: 0x145B1 VA: 0x144B0
	// RVA: -1 Offset: -1
	public static IObservable<T> Synchronize<T>(IObservable<T> source) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2978440 Offset: 0x2978541 VA: 0x2978440
	|-Observable.Synchronize<object>
	*/

	[ExtensionAttribute] // RVA: 0x144C0 Offset: 0x145C1 VA: 0x144C0
	// RVA: -1 Offset: -1
	public static IObservable<T> Synchronize<T>(IObservable<T> source, object gate) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x29784F0 Offset: 0x29785F1 VA: 0x29784F0
	|-Observable.Synchronize<object>
	*/

	[ExtensionAttribute] // RVA: 0x144D0 Offset: 0x145D1 VA: 0x144D0
	// RVA: -1 Offset: -1
	public static IObservable<T> ObserveOn<T>(IObservable<T> source, IScheduler scheduler) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2972BA0 Offset: 0x2972CA1 VA: 0x2972BA0
	|-Observable.ObserveOn<object>
	|
	|-RVA: 0x2972C10 Offset: 0x2972D11 VA: 0x2972C10
	|-Observable.ObserveOn<Unit>
	*/

	[ExtensionAttribute] // RVA: 0x144E0 Offset: 0x145E1 VA: 0x144E0
	// RVA: -1 Offset: -1
	public static IObservable<T> SubscribeOn<T>(IObservable<T> source, IScheduler scheduler) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x29782A0 Offset: 0x29783A1 VA: 0x29782A0
	|-Observable.SubscribeOn<object>
	*/

	[ExtensionAttribute] // RVA: 0x144F0 Offset: 0x145F1 VA: 0x144F0
	// RVA: -1 Offset: -1
	public static IObservable<T> DelaySubscription<T>(IObservable<T> source, TimeSpan dueTime) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x296D6F0 Offset: 0x296D7F1 VA: 0x296D6F0
	|-Observable.DelaySubscription<object>
	*/

	[ExtensionAttribute] // RVA: 0x14500 Offset: 0x14601 VA: 0x14500
	// RVA: -1 Offset: -1
	public static IObservable<T> DelaySubscription<T>(IObservable<T> source, TimeSpan dueTime, IScheduler scheduler) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x296D810 Offset: 0x296D911 VA: 0x296D810
	|-Observable.DelaySubscription<object>
	*/

	[ExtensionAttribute] // RVA: 0x14510 Offset: 0x14611 VA: 0x14510
	// RVA: -1 Offset: -1
	public static IObservable<T> DelaySubscription<T>(IObservable<T> source, DateTimeOffset dueTime) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x296D660 Offset: 0x296D761 VA: 0x296D660
	|-Observable.DelaySubscription<object>
	*/

	[ExtensionAttribute] // RVA: 0x14520 Offset: 0x14621 VA: 0x14520
	// RVA: -1 Offset: -1
	public static IObservable<T> DelaySubscription<T>(IObservable<T> source, DateTimeOffset dueTime, IScheduler scheduler) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x296D780 Offset: 0x296D881 VA: 0x296D780
	|-Observable.DelaySubscription<object>
	*/

	// RVA: -1 Offset: -1
	public static IObservable<T> Amb<T>(IObservable<T>[] sources) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x296ACD0 Offset: 0x296ADD1 VA: 0x296ACD0
	|-Observable.Amb<object>
	*/

	// RVA: -1 Offset: -1
	public static IObservable<T> Amb<T>(IEnumerable<IObservable<T>> sources) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x296A9C0 Offset: 0x296AAC1 VA: 0x296A9C0
	|-Observable.Amb<object>
	*/

	[ExtensionAttribute] // RVA: 0x14530 Offset: 0x14631 VA: 0x14530
	// RVA: -1 Offset: -1
	public static IObservable<T> Amb<T>(IObservable<T> source, IObservable<T> second) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x296AD50 Offset: 0x296AE51 VA: 0x296AD50
	|-Observable.Amb<object>
	*/

	[ExtensionAttribute] // RVA: 0x14540 Offset: 0x14641 VA: 0x14540
	// RVA: -1 Offset: -1
	public static IObservable<T> AsObservable<T>(IObservable<T> source) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x296ADC0 Offset: 0x296AEC1 VA: 0x296ADC0
	|-Observable.AsObservable<bool>
	|
	|-RVA: 0x296AEA0 Offset: 0x296AFA1 VA: 0x296AEA0
	|-Observable.AsObservable<object>
	|
	|-RVA: 0x296AF80 Offset: 0x296B081 VA: 0x296AF80
	|-Observable.AsObservable<Unit>
	*/

	[ExtensionAttribute] // RVA: 0x14550 Offset: 0x14651 VA: 0x14550
	// RVA: -1 Offset: -1
	public static IObservable<T> ToObservable<T>(IEnumerable<T> source) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x297A980 Offset: 0x297AA81 VA: 0x297A980
	|-Observable.ToObservable<object>
	*/

	[ExtensionAttribute] // RVA: 0x14560 Offset: 0x14661 VA: 0x14560
	// RVA: -1 Offset: -1
	public static IObservable<T> ToObservable<T>(IEnumerable<T> source, IScheduler scheduler) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x297AA10 Offset: 0x297AB11 VA: 0x297AA10
	|-Observable.ToObservable<object>
	*/

	[ExtensionAttribute] // RVA: 0x14570 Offset: 0x14671 VA: 0x14570
	// RVA: -1 Offset: -1
	public static IObservable<TResult> Cast<TSource, TResult>(IObservable<TSource> source) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x296BA60 Offset: 0x296BB61 VA: 0x296BA60
	|-Observable.Cast<object, object>
	*/

	[ExtensionAttribute] // RVA: 0x14580 Offset: 0x14681 VA: 0x14580
	// RVA: -1 Offset: -1
	public static IObservable<TResult> Cast<TSource, TResult>(IObservable<TSource> source, TResult witness) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x296BAD0 Offset: 0x296BBD1 VA: 0x296BAD0
	|-Observable.Cast<object, object>
	*/

	[ExtensionAttribute] // RVA: 0x14590 Offset: 0x14691 VA: 0x14590
	// RVA: -1 Offset: -1
	public static IObservable<TResult> OfType<TSource, TResult>(IObservable<TSource> source) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2973A70 Offset: 0x2973B71 VA: 0x2973A70
	|-Observable.OfType<object, object>
	*/

	[ExtensionAttribute] // RVA: 0x145A0 Offset: 0x146A1 VA: 0x145A0
	// RVA: -1 Offset: -1
	public static IObservable<TResult> OfType<TSource, TResult>(IObservable<TSource> source, TResult witness) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2973AE0 Offset: 0x2973BE1 VA: 0x2973AE0
	|-Observable.OfType<object, object>
	*/

	[ExtensionAttribute] // RVA: 0x145B0 Offset: 0x146B1 VA: 0x145B0
	// RVA: -1 Offset: -1
	public static IObservable<Unit> AsUnitObservable<T>(IObservable<T> source) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x296B0D0 Offset: 0x296B1D1 VA: 0x296B0D0
	|-Observable.AsUnitObservable<object>
	*/

	[ExtensionAttribute] // RVA: 0x145C0 Offset: 0x146C1 VA: 0x145C0
	// RVA: -1 Offset: -1
	public static IObservable<Unit> AsSingleUnitObservable<T>(IObservable<T> source) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x296B060 Offset: 0x296B161 VA: 0x296B060
	|-Observable.AsSingleUnitObservable<object>
	*/

	// RVA: -1 Offset: -1
	public static IObservable<T> Create<T>(Func<IObserver<T>, IDisposable> subscribe) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x296CA30 Offset: 0x296CB31 VA: 0x296CA30
	|-Observable.Create<object>
	|
	|-RVA: 0x296CAE0 Offset: 0x296CBE1 VA: 0x296CAE0
	|-Observable.Create<Unit>
	*/

	// RVA: -1 Offset: -1
	public static IObservable<T> Create<T>(Func<IObserver<T>, IDisposable> subscribe, bool isRequiredSubscribeOnCurrentThread) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x296CB90 Offset: 0x296CC91 VA: 0x296CB90
	|-Observable.Create<object>
	*/

	// RVA: -1 Offset: -1
	public static IObservable<T> CreateWithState<T, TState>(TState state, Func<TState, IObserver<T>, IDisposable> subscribe) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x296CDC0 Offset: 0x296CEC1 VA: 0x296CDC0
	|-Observable.CreateWithState<bool, object>
	|-Observable.CreateWithState<bool, Toggle>
	|
	|-RVA: 0x296CE80 Offset: 0x296CF81 VA: 0x296CE80
	|-Observable.CreateWithState<int, Dropdown>
	|-Observable.CreateWithState<int, object>
	|
	|-RVA: 0x296CF40 Offset: 0x296D041 VA: 0x296CF40
	|-Observable.CreateWithState<object, object>
	|-Observable.CreateWithState<string, InputField>
	|
	|-RVA: 0x296D000 Offset: 0x296D101 VA: 0x296D000
	|-Observable.CreateWithState<float, object>
	|-Observable.CreateWithState<float, Scrollbar>
	|-Observable.CreateWithState<float, Slider>
	|
	|-RVA: 0x296D0C0 Offset: 0x296D1C1 VA: 0x296D0C0
	|-Observable.CreateWithState<Vector2, object>
	|-Observable.CreateWithState<Vector2, ScrollRect>
	*/

	// RVA: -1 Offset: -1
	public static IObservable<T> CreateWithState<T, TState>(TState state, Func<TState, IObserver<T>, IDisposable> subscribe, bool isRequiredSubscribeOnCurrentThread) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x296D180 Offset: 0x296D281 VA: 0x296D180
	|-Observable.CreateWithState<object, object>
	*/

	// RVA: -1 Offset: -1
	public static IObservable<T> CreateSafe<T>(Func<IObserver<T>, IDisposable> subscribe) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x296CC50 Offset: 0x296CD51 VA: 0x296CC50
	|-Observable.CreateSafe<object>
	*/

	// RVA: -1 Offset: -1
	public static IObservable<T> CreateSafe<T>(Func<IObserver<T>, IDisposable> subscribe, bool isRequiredSubscribeOnCurrentThread) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x296CD00 Offset: 0x296CE01 VA: 0x296CD00
	|-Observable.CreateSafe<object>
	*/

	// RVA: -1 Offset: -1
	public static IObservable<T> Empty<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x296E500 Offset: 0x296E601 VA: 0x296E500
	|-Observable.Empty<CollectionAddEvent<object>>
	|
	|-RVA: 0x296E580 Offset: 0x296E681 VA: 0x296E580
	|-Observable.Empty<CollectionMoveEvent<object>>
	|
	|-RVA: 0x296E600 Offset: 0x296E701 VA: 0x296E600
	|-Observable.Empty<CollectionRemoveEvent<object>>
	|
	|-RVA: 0x296E680 Offset: 0x296E781 VA: 0x296E680
	|-Observable.Empty<CollectionReplaceEvent<object>>
	|
	|-RVA: 0x296E700 Offset: 0x296E801 VA: 0x296E700
	|-Observable.Empty<DictionaryAddEvent<object, object>>
	|
	|-RVA: 0x296E780 Offset: 0x296E881 VA: 0x296E780
	|-Observable.Empty<DictionaryRemoveEvent<object, object>>
	|
	|-RVA: 0x296E800 Offset: 0x296E901 VA: 0x296E800
	|-Observable.Empty<DictionaryReplaceEvent<object, object>>
	|
	|-RVA: 0x296E880 Offset: 0x296E981 VA: 0x296E880
	|-Observable.Empty<ValueTuple<object, object>>
	|
	|-RVA: 0x296EA00 Offset: 0x296EB01 VA: 0x296EA00
	|-Observable.Empty<AxisEventData>
	|-Observable.Empty<BaseEventData>
	|-Observable.Empty<Collider>
	|-Observable.Empty<Collider2D>
	|-Observable.Empty<Collision>
	|-Observable.Empty<Collision2D>
	|-Observable.Empty<GameObject>
	|-Observable.Empty<object>
	|-Observable.Empty<PointerEventData>
	|
	|-RVA: 0x296E900 Offset: 0x296EA01 VA: 0x296E900
	|-Observable.Empty<int>
	|
	|-RVA: 0x296E980 Offset: 0x296EA81 VA: 0x296E980
	|-Observable.Empty<long>
	|
	|-RVA: 0x296EA80 Offset: 0x296EB81 VA: 0x296EA80
	|-Observable.Empty<Unit>
	*/

	// RVA: -1 Offset: -1
	public static IObservable<T> Empty<T>(IScheduler scheduler) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x296EB00 Offset: 0x296EC01 VA: 0x296EB00
	|-Observable.Empty<CollectionAddEvent<object>>
	|
	|-RVA: 0x296EC50 Offset: 0x296ED51 VA: 0x296EC50
	|-Observable.Empty<CollectionMoveEvent<object>>
	|
	|-RVA: 0x296EDA0 Offset: 0x296EEA1 VA: 0x296EDA0
	|-Observable.Empty<CollectionRemoveEvent<object>>
	|
	|-RVA: 0x296EEF0 Offset: 0x296EFF1 VA: 0x296EEF0
	|-Observable.Empty<CollectionReplaceEvent<object>>
	|
	|-RVA: 0x296F040 Offset: 0x296F141 VA: 0x296F040
	|-Observable.Empty<DictionaryAddEvent<object, object>>
	|
	|-RVA: 0x296F190 Offset: 0x296F291 VA: 0x296F190
	|-Observable.Empty<DictionaryRemoveEvent<object, object>>
	|
	|-RVA: 0x296F2E0 Offset: 0x296F3E1 VA: 0x296F2E0
	|-Observable.Empty<DictionaryReplaceEvent<object, object>>
	|
	|-RVA: 0x296F430 Offset: 0x296F531 VA: 0x296F430
	|-Observable.Empty<ValueTuple<object, object>>
	|
	|-RVA: 0x296F580 Offset: 0x296F681 VA: 0x296F580
	|-Observable.Empty<int>
	|
	|-RVA: 0x296F6D0 Offset: 0x296F7D1 VA: 0x296F6D0
	|-Observable.Empty<long>
	|
	|-RVA: 0x296F8A0 Offset: 0x296F9A1 VA: 0x296F8A0
	|-Observable.Empty<object>
	|
	|-RVA: 0x296F9F0 Offset: 0x296FAF1 VA: 0x296F9F0
	|-Observable.Empty<Unit>
	*/

	// RVA: -1 Offset: -1
	public static IObservable<T> Empty<T>(T witness) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x296F820 Offset: 0x296F921 VA: 0x296F820
	|-Observable.Empty<object>
	*/

	// RVA: -1 Offset: -1
	public static IObservable<T> Empty<T>(IScheduler scheduler, T witness) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x296FB40 Offset: 0x296FC41 VA: 0x296FB40
	|-Observable.Empty<object>
	*/

	// RVA: -1 Offset: -1
	public static IObservable<T> Never<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2972A40 Offset: 0x2972B41 VA: 0x2972A40
	|-Observable.Never<object>
	*/

	// RVA: -1 Offset: -1
	public static IObservable<T> Never<T>(T witness) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2972AF0 Offset: 0x2972BF1 VA: 0x2972AF0
	|-Observable.Never<object>
	*/

	// RVA: -1 Offset: -1
	public static IObservable<T> Return<T>(T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2975760 Offset: 0x2975861 VA: 0x2975760
	|-Observable.Return<object>
	*/

	// RVA: -1 Offset: -1
	public static IObservable<T> Return<T>(T value, IScheduler scheduler) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x29757F0 Offset: 0x29758F1 VA: 0x29757F0
	|-Observable.Return<object>
	|
	|-RVA: 0x2975910 Offset: 0x2975A11 VA: 0x2975910
	|-Observable.Return<Unit>
	*/

	// RVA: 0x19D7370 Offset: 0x19D7471 VA: 0x19D7370
	public static IObservable<Unit> Return(Unit value) { }

	// RVA: 0x19D73E0 Offset: 0x19D74E1 VA: 0x19D73E0
	public static IObservable<bool> Return(bool value) { }

	// RVA: 0x19D7470 Offset: 0x19D7571 VA: 0x19D7470
	public static IObservable<int> Return(int value) { }

	// RVA: 0x19D74E0 Offset: 0x19D75E1 VA: 0x19D74E0
	public static IObservable<Unit> ReturnUnit() { }

	// RVA: -1 Offset: -1
	public static IObservable<T> Throw<T>(Exception error) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2979AF0 Offset: 0x2979BF1 VA: 0x2979AF0
	|-Observable.Throw<object>
	|
	|-RVA: 0x2979B80 Offset: 0x2979C81 VA: 0x2979B80
	|-Observable.Throw<Unit>
	*/

	// RVA: -1 Offset: -1
	public static IObservable<T> Throw<T>(Exception error, T witness) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2979C10 Offset: 0x2979D11 VA: 0x2979C10
	|-Observable.Throw<object>
	*/

	// RVA: -1 Offset: -1
	public static IObservable<T> Throw<T>(Exception error, IScheduler scheduler) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2979CA0 Offset: 0x2979DA1 VA: 0x2979CA0
	|-Observable.Throw<object>
	|
	|-RVA: 0x2979D10 Offset: 0x2979E11 VA: 0x2979D10
	|-Observable.Throw<Unit>
	*/

	// RVA: -1 Offset: -1
	public static IObservable<T> Throw<T>(Exception error, IScheduler scheduler, T witness) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2979D80 Offset: 0x2979E81 VA: 0x2979D80
	|-Observable.Throw<object>
	*/

	// RVA: 0x19D7550 Offset: 0x19D7651 VA: 0x19D7550
	public static IObservable<int> Range(int start, int count) { }

	// RVA: 0x19D7620 Offset: 0x19D7721 VA: 0x19D7620
	public static IObservable<int> Range(int start, int count, IScheduler scheduler) { }

	// RVA: -1 Offset: -1
	public static IObservable<T> Repeat<T>(T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2974700 Offset: 0x2974801 VA: 0x2974700
	|-Observable.Repeat<object>
	*/

	// RVA: -1 Offset: -1
	public static IObservable<T> Repeat<T>(T value, IScheduler scheduler) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x29748C0 Offset: 0x29749C1 VA: 0x29748C0
	|-Observable.Repeat<object>
	*/

	// RVA: -1 Offset: -1
	public static IObservable<T> Repeat<T>(T value, int repeatCount) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2974820 Offset: 0x2974921 VA: 0x2974820
	|-Observable.Repeat<object>
	*/

	// RVA: -1 Offset: -1
	public static IObservable<T> Repeat<T>(T value, int repeatCount, IScheduler scheduler) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2974980 Offset: 0x2974A81 VA: 0x2974980
	|-Observable.Repeat<object>
	*/

	[ExtensionAttribute] // RVA: 0x145D0 Offset: 0x146D1 VA: 0x145D0
	// RVA: -1 Offset: -1
	public static IObservable<T> Repeat<T>(IObservable<T> source) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2974670 Offset: 0x2974771 VA: 0x2974670
	|-Observable.Repeat<object>
	|
	|-RVA: 0x2974790 Offset: 0x2974891 VA: 0x2974790
	|-Observable.Repeat<Unit>
	*/

	[IteratorStateMachineAttribute] // RVA: 0x145E0 Offset: 0x146E1 VA: 0x145E0
	// RVA: -1 Offset: -1
	private static IEnumerable<IObservable<T>> RepeatInfinite<T>(IObservable<T> source) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2974AC0 Offset: 0x2974BC1 VA: 0x2974AC0
	|-Observable.RepeatInfinite<object>
	|
	|-RVA: 0x2974B40 Offset: 0x2974C41 VA: 0x2974B40
	|-Observable.RepeatInfinite<Unit>
	*/

	[ExtensionAttribute] // RVA: 0x14650 Offset: 0x14751 VA: 0x14650
	// RVA: -1 Offset: -1
	public static IObservable<T> RepeatSafe<T>(IObservable<T> source) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2974BC0 Offset: 0x2974CC1 VA: 0x2974BC0
	|-Observable.RepeatSafe<object>
	*/

	// RVA: -1 Offset: -1
	public static IObservable<T> Defer<T>(Func<IObservable<T>> observableFactory) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x296D330 Offset: 0x296D431 VA: 0x296D330
	|-Observable.Defer<object>
	*/

	// RVA: -1 Offset: -1
	public static IObservable<T> Start<T>(Func<T> function) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2977610 Offset: 0x2977711 VA: 0x2977610
	|-Observable.Start<object>
	*/

	// RVA: -1 Offset: -1
	public static IObservable<T> Start<T>(Func<T> function, TimeSpan timeSpan) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2977690 Offset: 0x2977791 VA: 0x2977690
	|-Observable.Start<object>
	*/

	// RVA: -1 Offset: -1
	public static IObservable<T> Start<T>(Func<T> function, IScheduler scheduler) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2977760 Offset: 0x2977861 VA: 0x2977760
	|-Observable.Start<object>
	*/

	// RVA: -1 Offset: -1
	public static IObservable<T> Start<T>(Func<T> function, TimeSpan timeSpan, IScheduler scheduler) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x29777E0 Offset: 0x29778E1 VA: 0x29777E0
	|-Observable.Start<object>
	*/

	// RVA: 0x19D77B0 Offset: 0x19D78B1 VA: 0x19D77B0
	public static IObservable<Unit> Start(Action action) { }

	// RVA: 0x19D7850 Offset: 0x19D7951 VA: 0x19D7850
	public static IObservable<Unit> Start(Action action, TimeSpan timeSpan) { }

	// RVA: 0x19D7920 Offset: 0x19D7A21 VA: 0x19D7920
	public static IObservable<Unit> Start(Action action, IScheduler scheduler) { }

	// RVA: 0x19D79C0 Offset: 0x19D7AC1 VA: 0x19D79C0
	public static IObservable<Unit> Start(Action action, TimeSpan timeSpan, IScheduler scheduler) { }

	// RVA: -1 Offset: -1
	public static Func<IObservable<T>> ToAsync<T>(Func<T> function) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x297A3A0 Offset: 0x297A4A1 VA: 0x297A3A0
	|-Observable.ToAsync<object>
	*/

	// RVA: -1 Offset: -1
	public static Func<IObservable<T>> ToAsync<T>(Func<T> function, IScheduler scheduler) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x297A430 Offset: 0x297A531 VA: 0x297A430
	|-Observable.ToAsync<object>
	*/

	// RVA: 0x19D7A90 Offset: 0x19D7B91 VA: 0x19D7A90
	public static Func<IObservable<Unit>> ToAsync(Action action) { }

	// RVA: 0x19D7B10 Offset: 0x19D7C11 VA: 0x19D7B10
	public static Func<IObservable<Unit>> ToAsync(Action action, IScheduler scheduler) { }

	[ExtensionAttribute] // RVA: 0x14660 Offset: 0x14761 VA: 0x14660
	// RVA: -1 Offset: -1
	public static IObservable<T> Finally<T>(IObservable<T> source, Action finallyAction) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x296FBC0 Offset: 0x296FCC1 VA: 0x296FBC0
	|-Observable.Finally<long>
	|
	|-RVA: 0x296FC30 Offset: 0x296FD31 VA: 0x296FC30
	|-Observable.Finally<object>
	|
	|-RVA: 0x296FCA0 Offset: 0x296FDA1 VA: 0x296FCA0
	|-Observable.Finally<Unit>
	*/

	[ExtensionAttribute] // RVA: 0x14670 Offset: 0x14771 VA: 0x14670
	// RVA: -1 Offset: -1
	public static IObservable<T> Catch<T, TException>(IObservable<T> source, Func<TException, IObservable<T>> errorHandler) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x296BBB0 Offset: 0x296BCB1 VA: 0x296BBB0
	|-Observable.Catch<object, object>
	*/

	[ExtensionAttribute] // RVA: 0x14680 Offset: 0x14781 VA: 0x14680
	// RVA: -1 Offset: -1
	public static IObservable<TSource> Catch<TSource>(IEnumerable<IObservable<TSource>> sources) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x296BB40 Offset: 0x296BC41 VA: 0x296BB40
	|-Observable.Catch<object>
	*/

	[ExtensionAttribute] // RVA: 0x14690 Offset: 0x14791 VA: 0x14690
	// RVA: -1 Offset: -1
	public static IObservable<TSource> CatchIgnore<TSource>(IObservable<TSource> source) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x296BC20 Offset: 0x296BD21 VA: 0x296BC20
	|-Observable.CatchIgnore<object>
	*/

	[ExtensionAttribute] // RVA: 0x146A0 Offset: 0x147A1 VA: 0x146A0
	// RVA: -1 Offset: -1
	public static IObservable<TSource> CatchIgnore<TSource, TException>(IObservable<TSource> source, Action<TException> errorAction) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x296BCE0 Offset: 0x296BDE1 VA: 0x296BCE0
	|-Observable.CatchIgnore<object, object>
	*/

	[ExtensionAttribute] // RVA: 0x146B0 Offset: 0x147B1 VA: 0x146B0
	// RVA: -1 Offset: -1
	public static IObservable<TSource> Retry<TSource>(IObservable<TSource> source) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2975630 Offset: 0x2975731 VA: 0x2975630
	|-Observable.Retry<object>
	*/

	[ExtensionAttribute] // RVA: 0x146C0 Offset: 0x147C1 VA: 0x146C0
	// RVA: -1 Offset: -1
	public static IObservable<TSource> Retry<TSource>(IObservable<TSource> source, int retryCount) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x29756C0 Offset: 0x29757C1 VA: 0x29756C0
	|-Observable.Retry<object>
	*/

	[ExtensionAttribute] // RVA: 0x146D0 Offset: 0x147D1 VA: 0x146D0
	// RVA: -1 Offset: -1
	public static IObservable<TSource> OnErrorRetry<TSource>(IObservable<TSource> source) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2973B50 Offset: 0x2973C51 VA: 0x2973B50
	|-Observable.OnErrorRetry<object>
	*/

	[ExtensionAttribute] // RVA: 0x146E0 Offset: 0x147E1 VA: 0x146E0
	// RVA: -1 Offset: -1
	public static IObservable<TSource> OnErrorRetry<TSource, TException>(IObservable<TSource> source, Action<TException> onError) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2973BD0 Offset: 0x2973CD1 VA: 0x2973BD0
	|-Observable.OnErrorRetry<object, object>
	*/

	[ExtensionAttribute] // RVA: 0x146F0 Offset: 0x147F1 VA: 0x146F0
	// RVA: -1 Offset: -1
	public static IObservable<TSource> OnErrorRetry<TSource, TException>(IObservable<TSource> source, Action<TException> onError, TimeSpan delay) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2973D70 Offset: 0x2973E71 VA: 0x2973D70
	|-Observable.OnErrorRetry<object, object>
	*/

	[ExtensionAttribute] // RVA: 0x14700 Offset: 0x14801 VA: 0x14700
	// RVA: -1 Offset: -1
	public static IObservable<TSource> OnErrorRetry<TSource, TException>(IObservable<TSource> source, Action<TException> onError, int retryCount) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2973CA0 Offset: 0x2973DA1 VA: 0x2973CA0
	|-Observable.OnErrorRetry<object, object>
	*/

	[ExtensionAttribute] // RVA: 0x14710 Offset: 0x14811 VA: 0x14710
	// RVA: -1 Offset: -1
	public static IObservable<TSource> OnErrorRetry<TSource, TException>(IObservable<TSource> source, Action<TException> onError, int retryCount, TimeSpan delay) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2973E10 Offset: 0x2973F11 VA: 0x2973E10
	|-Observable.OnErrorRetry<object, object>
	*/

	[ExtensionAttribute] // RVA: 0x14720 Offset: 0x14821 VA: 0x14720
	// RVA: -1 Offset: -1
	public static IObservable<TSource> OnErrorRetry<TSource, TException>(IObservable<TSource> source, Action<TException> onError, int retryCount, TimeSpan delay, IScheduler delayScheduler) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2973EC0 Offset: 0x2973FC1 VA: 0x2973EC0
	|-Observable.OnErrorRetry<object, object>
	*/

	// RVA: -1 Offset: -1
	public static IObservable<EventPattern<TEventArgs>> FromEventPattern<TDelegate, TEventArgs>(Func<EventHandler<TEventArgs>, TDelegate> conversion, Action<TDelegate> addHandler, Action<TDelegate> removeHandler) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x29710F0 Offset: 0x29711F1 VA: 0x29710F0
	|-Observable.FromEventPattern<object, object>
	*/

	// RVA: -1 Offset: -1
	public static IObservable<Unit> FromEvent<TDelegate>(Func<Action, TDelegate> conversion, Action<TDelegate> addHandler, Action<TDelegate> removeHandler) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2970DF0 Offset: 0x2970EF1 VA: 0x2970DF0
	|-Observable.FromEvent<object>
	|-Observable.FromEvent<UnityAction>
	*/

	// RVA: -1 Offset: -1
	public static IObservable<TEventArgs> FromEvent<TDelegate, TEventArgs>(Func<Action<TEventArgs>, TDelegate> conversion, Action<TDelegate> addHandler, Action<TDelegate> removeHandler) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2970E70 Offset: 0x2970F71 VA: 0x2970E70
	|-Observable.FromEvent<object, bool>
	|
	|-RVA: 0x2970EF0 Offset: 0x2970FF1 VA: 0x2970EF0
	|-Observable.FromEvent<object, int>
	|
	|-RVA: 0x2970F70 Offset: 0x2971071 VA: 0x2970F70
	|-Observable.FromEvent<object, object>
	|
	|-RVA: 0x2970FF0 Offset: 0x29710F1 VA: 0x2970FF0
	|-Observable.FromEvent<object, float>
	|
	|-RVA: 0x2971070 Offset: 0x2971171 VA: 0x2971070
	|-Observable.FromEvent<object, Vector2>
	*/

	// RVA: 0x19D7C00 Offset: 0x19D7D01 VA: 0x19D7C00
	public static IObservable<Unit> FromEvent(Action<Action> addHandler, Action<Action> removeHandler) { }

	// RVA: -1 Offset: -1
	public static IObservable<T> FromEvent<T>(Action<Action<T>> addHandler, Action<Action<T>> removeHandler) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2970D80 Offset: 0x2970E81 VA: 0x2970D80
	|-Observable.FromEvent<object>
	*/

	// RVA: -1 Offset: -1
	public static Func<IObservable<TResult>> FromAsyncPattern<TResult>(Func<AsyncCallback, object, IAsyncResult> begin, Func<IAsyncResult, TResult> end) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2970250 Offset: 0x2970351 VA: 0x2970250
	|-Observable.FromAsyncPattern<object>
	|
	|-RVA: 0x2970430 Offset: 0x2970531 VA: 0x2970430
	|-Observable.FromAsyncPattern<Unit>
	*/

	// RVA: -1 Offset: -1
	public static Func<T1, IObservable<TResult>> FromAsyncPattern<T1, TResult>(Func<T1, AsyncCallback, object, IAsyncResult> begin, Func<IAsyncResult, TResult> end) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x29704F0 Offset: 0x29705F1 VA: 0x29704F0
	|-Observable.FromAsyncPattern<object, object>
	|
	|-RVA: 0x29706D0 Offset: 0x29707D1 VA: 0x29706D0
	|-Observable.FromAsyncPattern<object, Unit>
	*/

	// RVA: -1 Offset: -1
	public static Func<T1, T2, IObservable<TResult>> FromAsyncPattern<T1, T2, TResult>(Func<T1, T2, AsyncCallback, object, IAsyncResult> begin, Func<IAsyncResult, TResult> end) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2970790 Offset: 0x2970891 VA: 0x2970790
	|-Observable.FromAsyncPattern<object, object, object>
	|
	|-RVA: 0x2970850 Offset: 0x2970951 VA: 0x2970850
	|-Observable.FromAsyncPattern<object, object, Unit>
	*/

	// RVA: 0x19D7CC0 Offset: 0x19D7DC1 VA: 0x19D7CC0
	public static Func<IObservable<Unit>> FromAsyncPattern(Func<AsyncCallback, object, IAsyncResult> begin, Action<IAsyncResult> end) { }

	// RVA: -1 Offset: -1
	public static Func<T1, IObservable<Unit>> FromAsyncPattern<T1>(Func<T1, AsyncCallback, object, IAsyncResult> begin, Action<IAsyncResult> end) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2970310 Offset: 0x2970411 VA: 0x2970310
	|-Observable.FromAsyncPattern<object>
	*/

	// RVA: -1 Offset: -1
	public static Func<T1, T2, IObservable<Unit>> FromAsyncPattern<T1, T2>(Func<T1, T2, AsyncCallback, object, IAsyncResult> begin, Action<IAsyncResult> end) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x29705B0 Offset: 0x29706B1 VA: 0x29705B0
	|-Observable.FromAsyncPattern<object, object>
	*/

	[ExtensionAttribute] // RVA: 0x14730 Offset: 0x14831 VA: 0x14730
	// RVA: -1 Offset: -1
	public static IObservable<T> Take<T>(IObservable<T> source, int count) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2978560 Offset: 0x2978661 VA: 0x2978560
	|-Observable.Take<ValueTuple<Character, GameObject>>
	|-Observable.Take<ValueTuple<object, object>>
	|
	|-RVA: 0x2978700 Offset: 0x2978801 VA: 0x2978700
	|-Observable.Take<long>
	|
	|-RVA: 0x29788A0 Offset: 0x29789A1 VA: 0x29788A0
	|-Observable.Take<object>
	|
	|-RVA: 0x2978AE0 Offset: 0x2978BE1 VA: 0x2978AE0
	|-Observable.Take<Unit>
	*/

	[ExtensionAttribute] // RVA: 0x14740 Offset: 0x14841 VA: 0x14740
	// RVA: -1 Offset: -1
	public static IObservable<T> Take<T>(IObservable<T> source, TimeSpan duration) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2978A40 Offset: 0x2978B41 VA: 0x2978A40
	|-Observable.Take<object>
	*/

	[ExtensionAttribute] // RVA: 0x14750 Offset: 0x14851 VA: 0x14750
	// RVA: -1 Offset: -1
	public static IObservable<T> Take<T>(IObservable<T> source, TimeSpan duration, IScheduler scheduler) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2978C80 Offset: 0x2978D81 VA: 0x2978C80
	|-Observable.Take<object>
	*/

	[ExtensionAttribute] // RVA: 0x14760 Offset: 0x14861 VA: 0x14760
	// RVA: -1 Offset: -1
	public static IObservable<T> TakeWhile<T>(IObservable<T> source, Func<T, bool> predicate) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2979550 Offset: 0x2979651 VA: 0x2979550
	|-Observable.TakeWhile<long>
	|
	|-RVA: 0x29795C0 Offset: 0x29796C1 VA: 0x29795C0
	|-Observable.TakeWhile<object>
	*/

	[ExtensionAttribute] // RVA: 0x14770 Offset: 0x14871 VA: 0x14770
	// RVA: -1 Offset: -1
	public static IObservable<T> TakeWhile<T>(IObservable<T> source, Func<T, int, bool> predicate) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2979630 Offset: 0x2979731 VA: 0x2979630
	|-Observable.TakeWhile<object>
	*/

	[ExtensionAttribute] // RVA: 0x14780 Offset: 0x14881 VA: 0x14780
	// RVA: -1 Offset: -1
	public static IObservable<T> TakeUntil<T, TOther>(IObservable<T> source, IObservable<TOther> other) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2979030 Offset: 0x2979131 VA: 0x2979030
	|-Observable.TakeUntil<object, object>
	|
	|-RVA: 0x2979110 Offset: 0x2979211 VA: 0x2979110
	|-Observable.TakeUntil<object, Unit>
	|
	|-RVA: 0x29791F0 Offset: 0x29792F1 VA: 0x29791F0
	|-Observable.TakeUntil<Unit, Character>
	|-Observable.TakeUntil<Unit, object>
	*/

	[ExtensionAttribute] // RVA: 0x14790 Offset: 0x14891 VA: 0x14790
	// RVA: -1 Offset: -1
	public static IObservable<T> TakeLast<T>(IObservable<T> source, int count) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2978DD0 Offset: 0x2978ED1 VA: 0x2978DD0
	|-Observable.TakeLast<object>
	*/

	[ExtensionAttribute] // RVA: 0x147A0 Offset: 0x148A1 VA: 0x147A0
	// RVA: -1 Offset: -1
	public static IObservable<T> TakeLast<T>(IObservable<T> source, TimeSpan duration) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2978EC0 Offset: 0x2978FC1 VA: 0x2978EC0
	|-Observable.TakeLast<object>
	*/

	[ExtensionAttribute] // RVA: 0x147B0 Offset: 0x148B1 VA: 0x147B0
	// RVA: -1 Offset: -1
	public static IObservable<T> TakeLast<T>(IObservable<T> source, TimeSpan duration, IScheduler scheduler) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2978F60 Offset: 0x2979061 VA: 0x2978F60
	|-Observable.TakeLast<object>
	*/

	[ExtensionAttribute] // RVA: 0x147C0 Offset: 0x148C1 VA: 0x147C0
	// RVA: -1 Offset: -1
	public static IObservable<T> Skip<T>(IObservable<T> source, int count) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x29770B0 Offset: 0x29771B1 VA: 0x29770B0
	|-Observable.Skip<object>
	*/

	[ExtensionAttribute] // RVA: 0x147D0 Offset: 0x148D1 VA: 0x147D0
	// RVA: -1 Offset: -1
	public static IObservable<T> Skip<T>(IObservable<T> source, TimeSpan duration) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x29771F0 Offset: 0x29772F1 VA: 0x29771F0
	|-Observable.Skip<object>
	*/

	[ExtensionAttribute] // RVA: 0x147E0 Offset: 0x148E1 VA: 0x147E0
	// RVA: -1 Offset: -1
	public static IObservable<T> Skip<T>(IObservable<T> source, TimeSpan duration, IScheduler scheduler) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2977290 Offset: 0x2977391 VA: 0x2977290
	|-Observable.Skip<object>
	*/

	[ExtensionAttribute] // RVA: 0x147F0 Offset: 0x148F1 VA: 0x147F0
	// RVA: -1 Offset: -1
	public static IObservable<T> SkipWhile<T>(IObservable<T> source, Func<T, bool> predicate) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x29774C0 Offset: 0x29775C1 VA: 0x29774C0
	|-Observable.SkipWhile<object>
	*/

	[ExtensionAttribute] // RVA: 0x14800 Offset: 0x14901 VA: 0x14800
	// RVA: -1 Offset: -1
	public static IObservable<T> SkipWhile<T>(IObservable<T> source, Func<T, int, bool> predicate) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2977530 Offset: 0x2977631 VA: 0x2977530
	|-Observable.SkipWhile<object>
	*/

	[ExtensionAttribute] // RVA: 0x14810 Offset: 0x14911 VA: 0x14810
	// RVA: -1 Offset: -1
	public static IObservable<T> SkipUntil<T, TOther>(IObservable<T> source, IObservable<TOther> other) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x29773E0 Offset: 0x29774E1 VA: 0x29773E0
	|-Observable.SkipUntil<object, object>
	|
	|-RVA: 0x2977450 Offset: 0x2977551 VA: 0x2977450
	|-Observable.SkipUntil<Unit, Character>
	|-Observable.SkipUntil<Unit, object>
	*/

	[ExtensionAttribute] // RVA: 0x14820 Offset: 0x14921 VA: 0x14820
	// RVA: -1 Offset: -1
	public static IObservable<IList<T>> Buffer<T>(IObservable<T> source, int count) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x296B2B0 Offset: 0x296B3B1 VA: 0x296B2B0
	|-Observable.Buffer<object>
	*/

	[ExtensionAttribute] // RVA: 0x14830 Offset: 0x14931 VA: 0x14830
	// RVA: -1 Offset: -1
	public static IObservable<IList<T>> Buffer<T>(IObservable<T> source, int count, int skip) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x296B4C0 Offset: 0x296B5C1 VA: 0x296B4C0
	|-Observable.Buffer<object>
	*/

	[ExtensionAttribute] // RVA: 0x14840 Offset: 0x14941 VA: 0x14840
	// RVA: -1 Offset: -1
	public static IObservable<IList<T>> Buffer<T>(IObservable<T> source, TimeSpan timeSpan) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x296B3B0 Offset: 0x296B4B1 VA: 0x296B3B0
	|-Observable.Buffer<object>
	*/

	[ExtensionAttribute] // RVA: 0x14850 Offset: 0x14951 VA: 0x14850
	// RVA: -1 Offset: -1
	public static IObservable<IList<T>> Buffer<T>(IObservable<T> source, TimeSpan timeSpan, IScheduler scheduler) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x296B720 Offset: 0x296B821 VA: 0x296B720
	|-Observable.Buffer<object>
	*/

	[ExtensionAttribute] // RVA: 0x14860 Offset: 0x14961 VA: 0x14860
	// RVA: -1 Offset: -1
	public static IObservable<IList<T>> Buffer<T>(IObservable<T> source, TimeSpan timeSpan, int count) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x296B5F0 Offset: 0x296B6F1 VA: 0x296B5F0
	|-Observable.Buffer<object>
	*/

	[ExtensionAttribute] // RVA: 0x14870 Offset: 0x14971 VA: 0x14870
	// RVA: -1 Offset: -1
	public static IObservable<IList<T>> Buffer<T>(IObservable<T> source, TimeSpan timeSpan, int count, IScheduler scheduler) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x296B7F0 Offset: 0x296B8F1 VA: 0x296B7F0
	|-Observable.Buffer<object>
	*/

	[ExtensionAttribute] // RVA: 0x14880 Offset: 0x14981 VA: 0x14880
	// RVA: -1 Offset: -1
	public static IObservable<IList<T>> Buffer<T>(IObservable<T> source, TimeSpan timeSpan, TimeSpan timeShift) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x296B690 Offset: 0x296B791 VA: 0x296B690
	|-Observable.Buffer<object>
	*/

	[ExtensionAttribute] // RVA: 0x14890 Offset: 0x14991 VA: 0x14890
	// RVA: -1 Offset: -1
	public static IObservable<IList<T>> Buffer<T>(IObservable<T> source, TimeSpan timeSpan, TimeSpan timeShift, IScheduler scheduler) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x296B900 Offset: 0x296BA01 VA: 0x296B900
	|-Observable.Buffer<object>
	*/

	[ExtensionAttribute] // RVA: 0x148A0 Offset: 0x149A1 VA: 0x148A0
	// RVA: -1 Offset: -1
	public static IObservable<IList<TSource>> Buffer<TSource, TWindowBoundary>(IObservable<TSource> source, IObservable<TWindowBoundary> windowBoundaries) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x296B450 Offset: 0x296B551 VA: 0x296B450
	|-Observable.Buffer<object, object>
	*/

	[ExtensionAttribute] // RVA: 0x148B0 Offset: 0x149B1 VA: 0x148B0
	// RVA: -1 Offset: -1
	public static IObservable<Pair<T>> Pairwise<T>(IObservable<T> source) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2974000 Offset: 0x2974101 VA: 0x2974000
	|-Observable.Pairwise<int>
	|
	|-RVA: 0x2974070 Offset: 0x2974171 VA: 0x2974070
	|-Observable.Pairwise<object>
	*/

	[ExtensionAttribute] // RVA: 0x148C0 Offset: 0x149C1 VA: 0x148C0
	// RVA: -1 Offset: -1
	public static IObservable<TR> Pairwise<T, TR>(IObservable<T> source, Func<T, T, TR> selector) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x29740E0 Offset: 0x29741E1 VA: 0x29740E0
	|-Observable.Pairwise<object, object>
	*/

	[ExtensionAttribute] // RVA: 0x148D0 Offset: 0x149D1 VA: 0x148D0
	// RVA: -1 Offset: -1
	public static IObservable<T> Last<T>(IObservable<T> source) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2971FF0 Offset: 0x29720F1 VA: 0x2971FF0
	|-Observable.Last<object>
	*/

	[ExtensionAttribute] // RVA: 0x148E0 Offset: 0x149E1 VA: 0x148E0
	// RVA: -1 Offset: -1
	public static IObservable<T> Last<T>(IObservable<T> source, Func<T, bool> predicate) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2972060 Offset: 0x2972161 VA: 0x2972060
	|-Observable.Last<object>
	*/

	[ExtensionAttribute] // RVA: 0x148F0 Offset: 0x149F1 VA: 0x148F0
	// RVA: -1 Offset: -1
	public static IObservable<T> LastOrDefault<T>(IObservable<T> source) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x29720D0 Offset: 0x29721D1 VA: 0x29720D0
	|-Observable.LastOrDefault<object>
	*/

	[ExtensionAttribute] // RVA: 0x14900 Offset: 0x14A01 VA: 0x14900
	// RVA: -1 Offset: -1
	public static IObservable<T> LastOrDefault<T>(IObservable<T> source, Func<T, bool> predicate) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2972140 Offset: 0x2972241 VA: 0x2972140
	|-Observable.LastOrDefault<object>
	*/

	[ExtensionAttribute] // RVA: 0x14910 Offset: 0x14A11 VA: 0x14910
	// RVA: -1 Offset: -1
	public static IObservable<T> First<T>(IObservable<T> source) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x296FD10 Offset: 0x296FE11 VA: 0x296FD10
	|-Observable.First<object>
	*/

	[ExtensionAttribute] // RVA: 0x14920 Offset: 0x14A21 VA: 0x14920
	// RVA: -1 Offset: -1
	public static IObservable<T> First<T>(IObservable<T> source, Func<T, bool> predicate) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x296FD80 Offset: 0x296FE81 VA: 0x296FD80
	|-Observable.First<object>
	*/

	[ExtensionAttribute] // RVA: 0x14930 Offset: 0x14A31 VA: 0x14930
	// RVA: -1 Offset: -1
	public static IObservable<T> FirstOrDefault<T>(IObservable<T> source) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x296FDF0 Offset: 0x296FEF1 VA: 0x296FDF0
	|-Observable.FirstOrDefault<ValueTuple<float, int>>
	|
	|-RVA: 0x296FE60 Offset: 0x296FF61 VA: 0x296FE60
	|-Observable.FirstOrDefault<ValueTuple<float, Int32Enum>>
	|-Observable.FirstOrDefault<ValueTuple<float, WeaponStyle>>
	|
	|-RVA: 0x296FF40 Offset: 0x2970041 VA: 0x296FF40
	|-Observable.FirstOrDefault<AnimationEvent>
	|-Observable.FirstOrDefault<Character>
	|-Observable.FirstOrDefault<object>
	|
	|-RVA: 0x296FED0 Offset: 0x296FFD1 VA: 0x296FED0
	|-Observable.FirstOrDefault<long>
	|
	|-RVA: 0x296FFB0 Offset: 0x29700B1 VA: 0x296FFB0
	|-Observable.FirstOrDefault<Unit>
	*/

	[ExtensionAttribute] // RVA: 0x14940 Offset: 0x14A41 VA: 0x14940
	// RVA: -1 Offset: -1
	public static IObservable<T> FirstOrDefault<T>(IObservable<T> source, Func<T, bool> predicate) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2970020 Offset: 0x2970121 VA: 0x2970020
	|-Observable.FirstOrDefault<object>
	*/

	[ExtensionAttribute] // RVA: 0x14950 Offset: 0x14A51 VA: 0x14950
	// RVA: -1 Offset: -1
	public static IObservable<T> Single<T>(IObservable<T> source) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2976EF0 Offset: 0x2976FF1 VA: 0x2976EF0
	|-Observable.Single<object>
	*/

	[ExtensionAttribute] // RVA: 0x14960 Offset: 0x14A61 VA: 0x14960
	// RVA: -1 Offset: -1
	public static IObservable<T> Single<T>(IObservable<T> source, Func<T, bool> predicate) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2976F60 Offset: 0x2977061 VA: 0x2976F60
	|-Observable.Single<object>
	*/

	[ExtensionAttribute] // RVA: 0x14970 Offset: 0x14A71 VA: 0x14970
	// RVA: -1 Offset: -1
	public static IObservable<T> SingleOrDefault<T>(IObservable<T> source) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2976FD0 Offset: 0x29770D1 VA: 0x2976FD0
	|-Observable.SingleOrDefault<object>
	*/

	[ExtensionAttribute] // RVA: 0x14980 Offset: 0x14A81 VA: 0x14980
	// RVA: -1 Offset: -1
	public static IObservable<T> SingleOrDefault<T>(IObservable<T> source, Func<T, bool> predicate) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2977040 Offset: 0x2977141 VA: 0x2977040
	|-Observable.SingleOrDefault<object>
	*/

	[ExtensionAttribute] // RVA: 0x14990 Offset: 0x14A91 VA: 0x14990
	// RVA: -1 Offset: -1
	public static IObservable<IGroupedObservable<TKey, TSource>> GroupBy<TSource, TKey>(IObservable<TSource> source, Func<TSource, TKey> keySelector) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2971770 Offset: 0x2971871 VA: 0x2971770
	|-Observable.GroupBy<object, object>
	*/

	[ExtensionAttribute] // RVA: 0x149A0 Offset: 0x14AA1 VA: 0x149A0
	// RVA: -1 Offset: -1
	public static IObservable<IGroupedObservable<TKey, TSource>> GroupBy<TSource, TKey>(IObservable<TSource> source, Func<TSource, TKey> keySelector, IEqualityComparer<TKey> comparer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x29718A0 Offset: 0x29719A1 VA: 0x29718A0
	|-Observable.GroupBy<object, object>
	*/

	[ExtensionAttribute] // RVA: 0x149B0 Offset: 0x14AB1 VA: 0x149B0
	// RVA: -1 Offset: -1
	public static IObservable<IGroupedObservable<TKey, TElement>> GroupBy<TSource, TKey, TElement>(IObservable<TSource> source, Func<TSource, TKey> keySelector, Func<TSource, TElement> elementSelector) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2971B00 Offset: 0x2971C01 VA: 0x2971B00
	|-Observable.GroupBy<object, object, object>
	*/

	[ExtensionAttribute] // RVA: 0x149C0 Offset: 0x14AC1 VA: 0x149C0
	// RVA: -1 Offset: -1
	public static IObservable<IGroupedObservable<TKey, TElement>> GroupBy<TSource, TKey, TElement>(IObservable<TSource> source, Func<TSource, TKey> keySelector, Func<TSource, TElement> elementSelector, IEqualityComparer<TKey> comparer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2971D20 Offset: 0x2971E21 VA: 0x2971D20
	|-Observable.GroupBy<object, object, object>
	*/

	[ExtensionAttribute] // RVA: 0x149D0 Offset: 0x14AD1 VA: 0x149D0
	// RVA: -1 Offset: -1
	public static IObservable<IGroupedObservable<TKey, TSource>> GroupBy<TSource, TKey>(IObservable<TSource> source, Func<TSource, TKey> keySelector, int capacity) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x29719D0 Offset: 0x2971AD1 VA: 0x29719D0
	|-Observable.GroupBy<object, object>
	*/

	[ExtensionAttribute] // RVA: 0x149E0 Offset: 0x14AE1 VA: 0x149E0
	// RVA: -1 Offset: -1
	public static IObservable<IGroupedObservable<TKey, TSource>> GroupBy<TSource, TKey>(IObservable<TSource> source, Func<TSource, TKey> keySelector, int capacity, IEqualityComparer<TKey> comparer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2971BE0 Offset: 0x2971CE1 VA: 0x2971BE0
	|-Observable.GroupBy<object, object>
	*/

	[ExtensionAttribute] // RVA: 0x149F0 Offset: 0x14AF1 VA: 0x149F0
	// RVA: -1 Offset: -1
	public static IObservable<IGroupedObservable<TKey, TElement>> GroupBy<TSource, TKey, TElement>(IObservable<TSource> source, Func<TSource, TKey> keySelector, Func<TSource, TElement> elementSelector, int capacity) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2971DB0 Offset: 0x2971EB1 VA: 0x2971DB0
	|-Observable.GroupBy<object, object, object>
	*/

	[ExtensionAttribute] // RVA: 0x14A00 Offset: 0x14B01 VA: 0x14A00
	// RVA: -1 Offset: -1
	public static IObservable<IGroupedObservable<TKey, TElement>> GroupBy<TSource, TKey, TElement>(IObservable<TSource> source, Func<TSource, TKey> keySelector, Func<TSource, TElement> elementSelector, int capacity, IEqualityComparer<TKey> comparer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2971EA0 Offset: 0x2971FA1 VA: 0x2971EA0
	|-Observable.GroupBy<object, object, object>
	*/

	// RVA: 0x19D7DF0 Offset: 0x19D7EF1 VA: 0x19D7DF0
	public static IObservable<long> Interval(TimeSpan period) { }

	// RVA: 0x19D7EA0 Offset: 0x19D7FA1 VA: 0x19D7EA0
	public static IObservable<long> Interval(TimeSpan period, IScheduler scheduler) { }

	// RVA: 0x19D7F50 Offset: 0x19D8051 VA: 0x19D7F50
	public static IObservable<long> Timer(TimeSpan dueTime) { }

	// RVA: 0x19D7FD0 Offset: 0x19D80D1 VA: 0x19D7FD0
	public static IObservable<long> Timer(DateTimeOffset dueTime) { }

	// RVA: 0x19D8060 Offset: 0x19D8161 VA: 0x19D8060
	public static IObservable<long> Timer(TimeSpan dueTime, TimeSpan period) { }

	// RVA: 0x19D8120 Offset: 0x19D8221 VA: 0x19D8120
	public static IObservable<long> Timer(DateTimeOffset dueTime, TimeSpan period) { }

	// RVA: 0x19D81E0 Offset: 0x19D82E1 VA: 0x19D81E0
	public static IObservable<long> Timer(TimeSpan dueTime, IScheduler scheduler) { }

	// RVA: 0x19D8260 Offset: 0x19D8361 VA: 0x19D8260
	public static IObservable<long> Timer(DateTimeOffset dueTime, IScheduler scheduler) { }

	// RVA: 0x19D82F0 Offset: 0x19D83F1 VA: 0x19D82F0
	public static IObservable<long> Timer(TimeSpan dueTime, TimeSpan period, IScheduler scheduler) { }

	// RVA: 0x19D83A0 Offset: 0x19D84A1 VA: 0x19D83A0
	public static IObservable<long> Timer(DateTimeOffset dueTime, TimeSpan period, IScheduler scheduler) { }

	[ExtensionAttribute] // RVA: 0x14A10 Offset: 0x14B11 VA: 0x14A10
	// RVA: -1 Offset: -1
	public static IObservable<Timestamped<TSource>> Timestamp<TSource>(IObservable<TSource> source) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x297A230 Offset: 0x297A331 VA: 0x297A230
	|-Observable.Timestamp<object>
	*/

	[ExtensionAttribute] // RVA: 0x14A20 Offset: 0x14B21 VA: 0x14A20
	// RVA: -1 Offset: -1
	public static IObservable<Timestamped<TSource>> Timestamp<TSource>(IObservable<TSource> source, IScheduler scheduler) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x297A2C0 Offset: 0x297A3C1 VA: 0x297A2C0
	|-Observable.Timestamp<object>
	*/

	[ExtensionAttribute] // RVA: 0x14A30 Offset: 0x14B31 VA: 0x14A30
	// RVA: -1 Offset: -1
	public static IObservable<TimeInterval<TSource>> TimeInterval<TSource>(IObservable<TSource> source) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2979E10 Offset: 0x2979F11 VA: 0x2979E10
	|-Observable.TimeInterval<object>
	*/

	[ExtensionAttribute] // RVA: 0x14A40 Offset: 0x14B41 VA: 0x14A40
	// RVA: -1 Offset: -1
	public static IObservable<TimeInterval<TSource>> TimeInterval<TSource>(IObservable<TSource> source, IScheduler scheduler) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2979EA0 Offset: 0x2979FA1 VA: 0x2979EA0
	|-Observable.TimeInterval<object>
	*/

	[ExtensionAttribute] // RVA: 0x14A50 Offset: 0x14B51 VA: 0x14A50
	// RVA: -1 Offset: -1
	public static IObservable<T> Delay<T>(IObservable<T> source, TimeSpan dueTime) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x296D3A0 Offset: 0x296D4A1 VA: 0x296D3A0
	|-Observable.Delay<object>
	*/

	[ExtensionAttribute] // RVA: 0x14A60 Offset: 0x14B61 VA: 0x14A60
	// RVA: -1 Offset: -1
	public static IObservable<TSource> Delay<TSource>(IObservable<TSource> source, TimeSpan dueTime, IScheduler scheduler) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x296D440 Offset: 0x296D541 VA: 0x296D440
	|-Observable.Delay<object>
	*/

	[ExtensionAttribute] // RVA: 0x14A70 Offset: 0x14B71 VA: 0x14A70
	// RVA: -1 Offset: -1
	public static IObservable<T> Sample<T>(IObservable<T> source, TimeSpan interval) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2975E00 Offset: 0x2975F01 VA: 0x2975E00
	|-Observable.Sample<object>
	*/

	[ExtensionAttribute] // RVA: 0x14A80 Offset: 0x14B81 VA: 0x14A80
	// RVA: -1 Offset: -1
	public static IObservable<T> Sample<T>(IObservable<T> source, TimeSpan interval, IScheduler scheduler) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2975F10 Offset: 0x2976011 VA: 0x2975F10
	|-Observable.Sample<object>
	*/

	[ExtensionAttribute] // RVA: 0x14A90 Offset: 0x14B91 VA: 0x14A90
	// RVA: -1 Offset: -1
	public static IObservable<TSource> Throttle<TSource>(IObservable<TSource> source, TimeSpan dueTime) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2979710 Offset: 0x2979811 VA: 0x2979710
	|-Observable.Throttle<object>
	*/

	[ExtensionAttribute] // RVA: 0x14AA0 Offset: 0x14BA1 VA: 0x14AA0
	// RVA: -1 Offset: -1
	public static IObservable<TSource> Throttle<TSource>(IObservable<TSource> source, TimeSpan dueTime, IScheduler scheduler) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x29797B0 Offset: 0x29798B1 VA: 0x29797B0
	|-Observable.Throttle<object>
	*/

	[ExtensionAttribute] // RVA: 0x14AB0 Offset: 0x14BB1 VA: 0x14AB0
	// RVA: -1 Offset: -1
	public static IObservable<TSource> ThrottleFirst<TSource>(IObservable<TSource> source, TimeSpan dueTime) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2979830 Offset: 0x2979931 VA: 0x2979830
	|-Observable.ThrottleFirst<Character>
	|-Observable.ThrottleFirst<object>
	*/

	[ExtensionAttribute] // RVA: 0x14AC0 Offset: 0x14BC1 VA: 0x14AC0
	// RVA: -1 Offset: -1
	public static IObservable<TSource> ThrottleFirst<TSource>(IObservable<TSource> source, TimeSpan dueTime, IScheduler scheduler) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x29798D0 Offset: 0x29799D1 VA: 0x29798D0
	|-Observable.ThrottleFirst<object>
	*/

	[ExtensionAttribute] // RVA: 0x14AD0 Offset: 0x14BD1 VA: 0x14AD0
	// RVA: -1 Offset: -1
	public static IObservable<T> Timeout<T>(IObservable<T> source, TimeSpan dueTime) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2979FB0 Offset: 0x297A0B1 VA: 0x2979FB0
	|-Observable.Timeout<object>
	*/

	[ExtensionAttribute] // RVA: 0x14AE0 Offset: 0x14BE1 VA: 0x14AE0
	// RVA: -1 Offset: -1
	public static IObservable<T> Timeout<T>(IObservable<T> source, TimeSpan dueTime, IScheduler scheduler) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x297A0E0 Offset: 0x297A1E1 VA: 0x297A0E0
	|-Observable.Timeout<object>
	*/

	[ExtensionAttribute] // RVA: 0x14AF0 Offset: 0x14BF1 VA: 0x14AF0
	// RVA: -1 Offset: -1
	public static IObservable<T> Timeout<T>(IObservable<T> source, DateTimeOffset dueTime) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2979F10 Offset: 0x297A011 VA: 0x2979F10
	|-Observable.Timeout<object>
	*/

	[ExtensionAttribute] // RVA: 0x14B00 Offset: 0x14C01 VA: 0x14B00
	// RVA: -1 Offset: -1
	public static IObservable<T> Timeout<T>(IObservable<T> source, DateTimeOffset dueTime, IScheduler scheduler) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x297A050 Offset: 0x297A151 VA: 0x297A050
	|-Observable.Timeout<object>
	*/

	[ExtensionAttribute] // RVA: 0x14B10 Offset: 0x14C11 VA: 0x14B10
	// RVA: -1 Offset: -1
	public static IObservable<TR> Select<T, TR>(IObservable<T> source, Func<T, TR> selector) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x29761D0 Offset: 0x29762D1 VA: 0x29761D0
	|-Observable.Select<IList<bool>, bool>
	|-Observable.Select<object, bool>
	|
	|-RVA: 0x2976280 Offset: 0x2976381 VA: 0x2976280
	|-Observable.Select<object, object>
	*/

	[ExtensionAttribute] // RVA: 0x14B20 Offset: 0x14C21 VA: 0x14B20
	// RVA: -1 Offset: -1
	public static IObservable<TR> Select<T, TR>(IObservable<T> source, Func<T, int, TR> selector) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2976330 Offset: 0x2976431 VA: 0x2976330
	|-Observable.Select<object, object>
	*/

	[ExtensionAttribute] // RVA: 0x14B30 Offset: 0x14C31 VA: 0x14B30
	// RVA: -1 Offset: -1
	public static IObservable<T> Where<T>(IObservable<T> source, Func<T, bool> predicate) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x297B2D0 Offset: 0x297B3D1 VA: 0x297B2D0
	|-Observable.Where<Character>
	|-Observable.Where<object>
	*/

	[ExtensionAttribute] // RVA: 0x14B40 Offset: 0x14C41 VA: 0x14B40
	// RVA: -1 Offset: -1
	public static IObservable<T> Where<T>(IObservable<T> source, Func<T, int, bool> predicate) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x297B420 Offset: 0x297B521 VA: 0x297B420
	|-Observable.Where<object>
	*/

	[ExtensionAttribute] // RVA: 0x14B50 Offset: 0x14C51 VA: 0x14B50
	// RVA: -1 Offset: -1
	public static IObservable<TR> ContinueWith<T, TR>(IObservable<T> source, IObservable<TR> other) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x296C920 Offset: 0x296CA21 VA: 0x296C920
	|-Observable.ContinueWith<object, object>
	*/

	[ExtensionAttribute] // RVA: 0x14B60 Offset: 0x14C61 VA: 0x14B60
	// RVA: -1 Offset: -1
	public static IObservable<TR> ContinueWith<T, TR>(IObservable<T> source, Func<T, IObservable<TR>> selector) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x296C8B0 Offset: 0x296C9B1 VA: 0x296C8B0
	|-Observable.ContinueWith<object, object>
	*/

	[ExtensionAttribute] // RVA: 0x14B70 Offset: 0x14C71 VA: 0x14B70
	// RVA: -1 Offset: -1
	public static IObservable<TR> SelectMany<T, TR>(IObservable<T> source, IObservable<TR> other) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2976520 Offset: 0x2976621 VA: 0x2976520
	|-Observable.SelectMany<object, object>
	|
	|-RVA: 0x29767F0 Offset: 0x29768F1 VA: 0x29767F0
	|-Observable.SelectMany<object, Unit>
	*/

	[ExtensionAttribute] // RVA: 0x14B80 Offset: 0x14C81 VA: 0x14B80
	// RVA: -1 Offset: -1
	public static IObservable<TR> SelectMany<T, TR>(IObservable<T> source, Func<T, IObservable<TR>> selector) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x29764B0 Offset: 0x29765B1 VA: 0x29764B0
	|-Observable.SelectMany<object, object>
	|
	|-RVA: 0x2976780 Offset: 0x2976881 VA: 0x2976780
	|-Observable.SelectMany<object, Unit>
	*/

	[ExtensionAttribute] // RVA: 0x14B90 Offset: 0x14C91 VA: 0x14B90
	// RVA: -1 Offset: -1
	public static IObservable<TResult> SelectMany<TSource, TResult>(IObservable<TSource> source, Func<TSource, int, IObservable<TResult>> selector) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2976710 Offset: 0x2976811 VA: 0x2976710
	|-Observable.SelectMany<object, object>
	*/

	[ExtensionAttribute] // RVA: 0x14BA0 Offset: 0x14CA1 VA: 0x14BA0
	// RVA: -1 Offset: -1
	public static IObservable<TR> SelectMany<T, TC, TR>(IObservable<T> source, Func<T, IObservable<TC>> collectionSelector, Func<T, TC, TR> resultSelector) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2976B60 Offset: 0x2976C61 VA: 0x2976B60
	|-Observable.SelectMany<object, long, object>
	|
	|-RVA: 0x2976BE0 Offset: 0x2976CE1 VA: 0x2976BE0
	|-Observable.SelectMany<object, object, object>
	|
	|-RVA: 0x2976DE0 Offset: 0x2976EE1 VA: 0x2976DE0
	|-Observable.SelectMany<object, Unit, object>
	*/

	[ExtensionAttribute] // RVA: 0x14BB0 Offset: 0x14CB1 VA: 0x14BB0
	// RVA: -1 Offset: -1
	public static IObservable<TResult> SelectMany<TSource, TCollection, TResult>(IObservable<TSource> source, Func<TSource, int, IObservable<TCollection>> collectionSelector, Func<TSource, int, TCollection, int, TResult> resultSelector) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2976D60 Offset: 0x2976E61 VA: 0x2976D60
	|-Observable.SelectMany<object, object, object>
	*/

	[ExtensionAttribute] // RVA: 0x14BC0 Offset: 0x14CC1 VA: 0x14BC0
	// RVA: -1 Offset: -1
	public static IObservable<TResult> SelectMany<TSource, TResult>(IObservable<TSource> source, Func<TSource, IEnumerable<TResult>> selector) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2976630 Offset: 0x2976731 VA: 0x2976630
	|-Observable.SelectMany<object, object>
	*/

	[ExtensionAttribute] // RVA: 0x14BD0 Offset: 0x14CD1 VA: 0x14BD0
	// RVA: -1 Offset: -1
	public static IObservable<TResult> SelectMany<TSource, TResult>(IObservable<TSource> source, Func<TSource, int, IEnumerable<TResult>> selector) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x29766A0 Offset: 0x29767A1 VA: 0x29766A0
	|-Observable.SelectMany<object, object>
	*/

	[ExtensionAttribute] // RVA: 0x14BE0 Offset: 0x14CE1 VA: 0x14BE0
	// RVA: -1 Offset: -1
	public static IObservable<TResult> SelectMany<TSource, TCollection, TResult>(IObservable<TSource> source, Func<TSource, IEnumerable<TCollection>> collectionSelector, Func<TSource, TCollection, TResult> resultSelector) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2976C60 Offset: 0x2976D61 VA: 0x2976C60
	|-Observable.SelectMany<object, object, object>
	*/

	[ExtensionAttribute] // RVA: 0x14BF0 Offset: 0x14CF1 VA: 0x14BF0
	// RVA: -1 Offset: -1
	public static IObservable<TResult> SelectMany<TSource, TCollection, TResult>(IObservable<TSource> source, Func<TSource, int, IEnumerable<TCollection>> collectionSelector, Func<TSource, int, TCollection, int, TResult> resultSelector) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2976CE0 Offset: 0x2976DE1 VA: 0x2976CE0
	|-Observable.SelectMany<object, object, object>
	*/

	[ExtensionAttribute] // RVA: 0x14C00 Offset: 0x14D01 VA: 0x14C00
	// RVA: -1 Offset: -1
	public static IObservable<T[]> ToArray<T>(IObservable<T> source) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x297A330 Offset: 0x297A431 VA: 0x297A330
	|-Observable.ToArray<object>
	*/

	[ExtensionAttribute] // RVA: 0x14C10 Offset: 0x14D11 VA: 0x14C10
	// RVA: -1 Offset: -1
	public static IObservable<IList<T>> ToList<T>(IObservable<T> source) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x297A910 Offset: 0x297AA11 VA: 0x297A910
	|-Observable.ToList<object>
	*/

	[ExtensionAttribute] // RVA: 0x14C20 Offset: 0x14D21 VA: 0x14C20
	// RVA: -1 Offset: -1
	public static IObservable<T> Do<T>(IObservable<T> source, IObserver<T> observer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x296E030 Offset: 0x296E131 VA: 0x296E030
	|-Observable.Do<object>
	*/

	[ExtensionAttribute] // RVA: 0x14C30 Offset: 0x14D31 VA: 0x14C30
	// RVA: -1 Offset: -1
	public static IObservable<T> Do<T>(IObservable<T> source, Action<T> onNext) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x296DF60 Offset: 0x296E061 VA: 0x296DF60
	|-Observable.Do<object>
	*/

	[ExtensionAttribute] // RVA: 0x14C40 Offset: 0x14D41 VA: 0x14C40
	// RVA: -1 Offset: -1
	public static IObservable<T> Do<T>(IObservable<T> source, Action<T> onNext, Action<Exception> onError) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x296E170 Offset: 0x296E271 VA: 0x296E170
	|-Observable.Do<object>
	*/

	[ExtensionAttribute] // RVA: 0x14C50 Offset: 0x14D51 VA: 0x14C50
	// RVA: -1 Offset: -1
	public static IObservable<T> Do<T>(IObservable<T> source, Action<T> onNext, Action onCompleted) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x296E0A0 Offset: 0x296E1A1 VA: 0x296E0A0
	|-Observable.Do<object>
	*/

	[ExtensionAttribute] // RVA: 0x14C60 Offset: 0x14D61 VA: 0x14C60
	// RVA: -1 Offset: -1
	public static IObservable<T> Do<T>(IObservable<T> source, Action<T> onNext, Action<Exception> onError, Action onCompleted) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x296E240 Offset: 0x296E341 VA: 0x296E240
	|-Observable.Do<object>
	*/

	[ExtensionAttribute] // RVA: 0x14C70 Offset: 0x14D71 VA: 0x14C70
	// RVA: -1 Offset: -1
	public static IObservable<T> DoOnError<T>(IObservable<T> source, Action<Exception> onError) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x296E3B0 Offset: 0x296E4B1 VA: 0x296E3B0
	|-Observable.DoOnError<object>
	*/

	[ExtensionAttribute] // RVA: 0x14C80 Offset: 0x14D81 VA: 0x14C80
	// RVA: -1 Offset: -1
	public static IObservable<T> DoOnCompleted<T>(IObservable<T> source, Action onCompleted) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x296E340 Offset: 0x296E441 VA: 0x296E340
	|-Observable.DoOnCompleted<object>
	*/

	[ExtensionAttribute] // RVA: 0x14C90 Offset: 0x14D91 VA: 0x14C90
	// RVA: -1 Offset: -1
	public static IObservable<T> DoOnTerminate<T>(IObservable<T> source, Action onTerminate) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x296E490 Offset: 0x296E591 VA: 0x296E490
	|-Observable.DoOnTerminate<object>
	*/

	[ExtensionAttribute] // RVA: 0x14CA0 Offset: 0x14DA1 VA: 0x14CA0
	// RVA: -1 Offset: -1
	public static IObservable<T> DoOnSubscribe<T>(IObservable<T> source, Action onSubscribe) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x296E420 Offset: 0x296E521 VA: 0x296E420
	|-Observable.DoOnSubscribe<object>
	*/

	[ExtensionAttribute] // RVA: 0x14CB0 Offset: 0x14DB1 VA: 0x14CB0
	// RVA: -1 Offset: -1
	public static IObservable<T> DoOnCancel<T>(IObservable<T> source, Action onCancel) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x296E2D0 Offset: 0x296E3D1 VA: 0x296E2D0
	|-Observable.DoOnCancel<object>
	*/

	[ExtensionAttribute] // RVA: 0x14CC0 Offset: 0x14DC1 VA: 0x14CC0
	// RVA: -1 Offset: -1
	public static IObservable<Notification<T>> Materialize<T>(IObservable<T> source) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x29721B0 Offset: 0x29722B1 VA: 0x29721B0
	|-Observable.Materialize<object>
	*/

	[ExtensionAttribute] // RVA: 0x14CD0 Offset: 0x14DD1 VA: 0x14CD0
	// RVA: -1 Offset: -1
	public static IObservable<T> Dematerialize<T>(IObservable<Notification<T>> source) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x296D890 Offset: 0x296D991 VA: 0x296D890
	|-Observable.Dematerialize<object>
	*/

	[ExtensionAttribute] // RVA: 0x14CE0 Offset: 0x14DE1 VA: 0x14CE0
	// RVA: -1 Offset: -1
	public static IObservable<T> DefaultIfEmpty<T>(IObservable<T> source) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x296D250 Offset: 0x296D351 VA: 0x296D250
	|-Observable.DefaultIfEmpty<object>
	*/

	[ExtensionAttribute] // RVA: 0x14CF0 Offset: 0x14DF1 VA: 0x14CF0
	// RVA: -1 Offset: -1
	public static IObservable<T> DefaultIfEmpty<T>(IObservable<T> source, T defaultValue) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x296D2C0 Offset: 0x296D3C1 VA: 0x296D2C0
	|-Observable.DefaultIfEmpty<object>
	*/

	[ExtensionAttribute] // RVA: 0x14D00 Offset: 0x14E01 VA: 0x14D00
	// RVA: -1 Offset: -1
	public static IObservable<TSource> Distinct<TSource>(IObservable<TSource> source) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x296D900 Offset: 0x296DA01 VA: 0x296D900
	|-Observable.Distinct<object>
	*/

	[ExtensionAttribute] // RVA: 0x14D10 Offset: 0x14E11 VA: 0x14D10
	// RVA: -1 Offset: -1
	public static IObservable<TSource> Distinct<TSource>(IObservable<TSource> source, IEqualityComparer<TSource> comparer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x296D9C0 Offset: 0x296DAC1 VA: 0x296D9C0
	|-Observable.Distinct<object>
	*/

	[ExtensionAttribute] // RVA: 0x14D20 Offset: 0x14E21 VA: 0x14D20
	// RVA: -1 Offset: -1
	public static IObservable<TSource> Distinct<TSource, TKey>(IObservable<TSource> source, Func<TSource, TKey> keySelector) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x296DA30 Offset: 0x296DB31 VA: 0x296DA30
	|-Observable.Distinct<object, object>
	*/

	[ExtensionAttribute] // RVA: 0x14D30 Offset: 0x14E31 VA: 0x14D30
	// RVA: -1 Offset: -1
	public static IObservable<TSource> Distinct<TSource, TKey>(IObservable<TSource> source, Func<TSource, TKey> keySelector, IEqualityComparer<TKey> comparer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x296DB00 Offset: 0x296DC01 VA: 0x296DB00
	|-Observable.Distinct<object, object>
	*/

	[ExtensionAttribute] // RVA: 0x14D40 Offset: 0x14E41 VA: 0x14D40
	// RVA: -1 Offset: -1
	public static IObservable<T> DistinctUntilChanged<T>(IObservable<T> source) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x296DB80 Offset: 0x296DC81 VA: 0x296DB80
	|-Observable.DistinctUntilChanged<bool>
	|
	|-RVA: 0x296DC40 Offset: 0x296DD41 VA: 0x296DC40
	|-Observable.DistinctUntilChanged<object>
	*/

	[ExtensionAttribute] // RVA: 0x14D50 Offset: 0x14E51 VA: 0x14D50
	// RVA: -1 Offset: -1
	public static IObservable<T> DistinctUntilChanged<T>(IObservable<T> source, IEqualityComparer<T> comparer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x296DD00 Offset: 0x296DE01 VA: 0x296DD00
	|-Observable.DistinctUntilChanged<object>
	*/

	[ExtensionAttribute] // RVA: 0x14D60 Offset: 0x14E61 VA: 0x14D60
	// RVA: -1 Offset: -1
	public static IObservable<T> DistinctUntilChanged<T, TKey>(IObservable<T> source, Func<T, TKey> keySelector) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x296DDC0 Offset: 0x296DEC1 VA: 0x296DDC0
	|-Observable.DistinctUntilChanged<object, object>
	*/

	[ExtensionAttribute] // RVA: 0x14D70 Offset: 0x14E71 VA: 0x14D70
	// RVA: -1 Offset: -1
	public static IObservable<T> DistinctUntilChanged<T, TKey>(IObservable<T> source, Func<T, TKey> keySelector, IEqualityComparer<TKey> comparer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x296DE90 Offset: 0x296DF91 VA: 0x296DE90
	|-Observable.DistinctUntilChanged<object, object>
	*/

	[ExtensionAttribute] // RVA: 0x14D80 Offset: 0x14E81 VA: 0x14D80
	// RVA: -1 Offset: -1
	public static IObservable<T> IgnoreElements<T>(IObservable<T> source) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2971F80 Offset: 0x2972081 VA: 0x2971F80
	|-Observable.IgnoreElements<object>
	*/

	[ExtensionAttribute] // RVA: 0x14D90 Offset: 0x14E91 VA: 0x14D90
	// RVA: -1 Offset: -1
	public static IObservable<Unit> ForEachAsync<T>(IObservable<T> source, Action<T> onNext) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2970090 Offset: 0x2970191 VA: 0x2970090
	|-Observable.ForEachAsync<object>
	*/

	[ExtensionAttribute] // RVA: 0x14DA0 Offset: 0x14EA1 VA: 0x14DA0
	// RVA: -1 Offset: -1
	public static IObservable<Unit> ForEachAsync<T>(IObservable<T> source, Action<T, int> onNext) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2970100 Offset: 0x2970201 VA: 0x2970100
	|-Observable.ForEachAsync<object>
	*/

	// RVA: 0x19D8460 Offset: 0x19D8561 VA: 0x19D8460
	public static IObservable<Unit> FromCoroutine(Func<IEnumerator> coroutine, bool publishEveryYield = False) { }

	// RVA: 0x19D8590 Offset: 0x19D8691 VA: 0x19D8590
	public static IObservable<Unit> FromCoroutine(Func<CancellationToken, IEnumerator> coroutine, bool publishEveryYield = False) { }

	// RVA: 0x19D86C0 Offset: 0x19D87C1 VA: 0x19D86C0
	public static IObservable<Unit> FromMicroCoroutine(Func<IEnumerator> coroutine, bool publishEveryYield = False, FrameCountType frameCountType = 0) { }

	// RVA: 0x19D8800 Offset: 0x19D8901 VA: 0x19D8800
	public static IObservable<Unit> FromMicroCoroutine(Func<CancellationToken, IEnumerator> coroutine, bool publishEveryYield = False, FrameCountType frameCountType = 0) { }

	[IteratorStateMachineAttribute] // RVA: 0x14DB0 Offset: 0x14EB1 VA: 0x14DB0
	// RVA: 0x19D8940 Offset: 0x19D8A41 VA: 0x19D8940
	private static IEnumerator WrapEnumerator(IEnumerator enumerator, IObserver<Unit> observer, CancellationToken cancellationToken, bool publishEveryYield) { }

	// RVA: -1 Offset: -1
	public static IObservable<T> FromCoroutineValue<T>(Func<IEnumerator> coroutine, bool nullAsNextUpdate = True) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2970B60 Offset: 0x2970C61 VA: 0x2970B60
	|-Observable.FromCoroutineValue<object>
	*/

	// RVA: -1 Offset: -1
	public static IObservable<T> FromCoroutineValue<T>(Func<CancellationToken, IEnumerator> coroutine, bool nullAsNextUpdate = True) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2970C70 Offset: 0x2970D71 VA: 0x2970C70
	|-Observable.FromCoroutineValue<object>
	*/

	[IteratorStateMachineAttribute] // RVA: 0x14E20 Offset: 0x14F21 VA: 0x14E20
	// RVA: -1 Offset: -1
	private static IEnumerator WrapEnumeratorYieldValue<T>(IEnumerator enumerator, IObserver<T> observer, CancellationToken cancellationToken, bool nullAsNextUpdate) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x297B510 Offset: 0x297B611 VA: 0x297B510
	|-Observable.WrapEnumeratorYieldValue<object>
	*/

	// RVA: -1 Offset: -1
	public static IObservable<T> FromCoroutine<T>(Func<IObserver<T>, IEnumerator> coroutine) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2970980 Offset: 0x2970A81 VA: 0x2970980
	|-Observable.FromCoroutine<object>
	*/

	// RVA: -1 Offset: -1
	public static IObservable<T> FromMicroCoroutine<T>(Func<IObserver<T>, IEnumerator> coroutine, FrameCountType frameCountType = 0) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x29711E0 Offset: 0x29712E1 VA: 0x29711E0
	|-Observable.FromMicroCoroutine<object>
	*/

	[IteratorStateMachineAttribute] // RVA: 0x14E90 Offset: 0x14F91 VA: 0x14E90
	// RVA: -1 Offset: -1
	private static IEnumerator WrapToCancellableEnumerator<T>(IEnumerator enumerator, IObserver<T> observer, CancellationToken cancellationToken) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x297B5C0 Offset: 0x297B6C1 VA: 0x297B5C0
	|-Observable.WrapToCancellableEnumerator<object>
	*/

	// RVA: -1 Offset: -1
	public static IObservable<T> FromCoroutine<T>(Func<IObserver<T>, CancellationToken, IEnumerator> coroutine) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2970A80 Offset: 0x2970B81 VA: 0x2970A80
	|-Observable.FromCoroutine<byte[]>
	|-Observable.FromCoroutine<AssetBundle>
	|-Observable.FromCoroutine<AsyncOperation>
	|-Observable.FromCoroutine<object>
	|-Observable.FromCoroutine<string>
	|-Observable.FromCoroutine<WWW>
	|
	|-RVA: 0x2970910 Offset: 0x2970A11 VA: 0x2970910
	|-Observable.FromCoroutine<long>
	|
	|-RVA: 0x2970AF0 Offset: 0x2970BF1 VA: 0x2970AF0
	|-Observable.FromCoroutine<Unit>
	*/

	// RVA: -1 Offset: -1
	public static IObservable<T> FromMicroCoroutine<T>(Func<IObserver<T>, CancellationToken, IEnumerator> coroutine, FrameCountType frameCountType = 0) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2971170 Offset: 0x2971271 VA: 0x2971170
	|-Observable.FromMicroCoroutine<long>
	|
	|-RVA: 0x29712F0 Offset: 0x29713F1 VA: 0x29712F0
	|-Observable.FromMicroCoroutine<object>
	|
	|-RVA: 0x2971360 Offset: 0x2971461 VA: 0x2971360
	|-Observable.FromMicroCoroutine<Unit>
	*/

	[ExtensionAttribute] // RVA: 0x14F00 Offset: 0x15001 VA: 0x14F00
	// RVA: -1 Offset: -1
	public static IObservable<Unit> SelectMany<T>(IObservable<T> source, IEnumerator coroutine, bool publishEveryYield = False) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2976900 Offset: 0x2976A01 VA: 0x2976900
	|-Observable.SelectMany<object>
	*/

	[ExtensionAttribute] // RVA: 0x14F10 Offset: 0x15011 VA: 0x14F10
	// RVA: -1 Offset: -1
	public static IObservable<Unit> SelectMany<T>(IObservable<T> source, Func<IEnumerator> selector, bool publishEveryYield = False) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2976A30 Offset: 0x2976B31 VA: 0x2976A30
	|-Observable.SelectMany<object>
	*/

	[ExtensionAttribute] // RVA: 0x14F20 Offset: 0x15021 VA: 0x14F20
	// RVA: -1 Offset: -1
	public static IObservable<Unit> SelectMany<T>(IObservable<T> source, Func<T, IEnumerator> selector) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x29763A0 Offset: 0x29764A1 VA: 0x29763A0
	|-Observable.SelectMany<object>
	*/

	[ExtensionAttribute] // RVA: 0x14F30 Offset: 0x15031 VA: 0x14F30
	// RVA: 0x19D8A00 Offset: 0x19D8B01 VA: 0x19D8A00
	public static IObservable<Unit> ToObservable(IEnumerator coroutine, bool publishEveryYield = False) { }

	[ExtensionAttribute] // RVA: 0x14F40 Offset: 0x15041 VA: 0x14F40
	// RVA: 0x19D8B30 Offset: 0x19D8C31 VA: 0x19D8B30
	public static ObservableYieldInstruction<Unit> ToYieldInstruction(IEnumerator coroutine) { }

	[ExtensionAttribute] // RVA: 0x14F50 Offset: 0x15051 VA: 0x14F50
	// RVA: 0x19D8BC0 Offset: 0x19D8CC1 VA: 0x19D8BC0
	public static ObservableYieldInstruction<Unit> ToYieldInstruction(IEnumerator coroutine, bool throwOnError) { }

	[ExtensionAttribute] // RVA: 0x14F60 Offset: 0x15061 VA: 0x14F60
	// RVA: 0x19D8C50 Offset: 0x19D8D51 VA: 0x19D8C50
	public static ObservableYieldInstruction<Unit> ToYieldInstruction(IEnumerator coroutine, CancellationToken cancellationToken) { }

	[ExtensionAttribute] // RVA: 0x14F70 Offset: 0x15071 VA: 0x14F70
	// RVA: 0x19D8CE0 Offset: 0x19D8DE1 VA: 0x19D8CE0
	public static ObservableYieldInstruction<Unit> ToYieldInstruction(IEnumerator coroutine, bool throwOnError, CancellationToken cancellationToken) { }

	// RVA: 0x19D8D80 Offset: 0x19D8E81 VA: 0x19D8D80
	public static IObservable<long> EveryUpdate() { }

	// RVA: 0x19D8ED0 Offset: 0x19D8FD1 VA: 0x19D8ED0
	public static IObservable<long> EveryFixedUpdate() { }

	// RVA: 0x19D9020 Offset: 0x19D9121 VA: 0x19D9020
	public static IObservable<long> EveryEndOfFrame() { }

	[IteratorStateMachineAttribute] // RVA: 0x14F80 Offset: 0x15081 VA: 0x14F80
	// RVA: 0x19D9170 Offset: 0x19D9271 VA: 0x19D9170
	private static IEnumerator EveryCycleCore(IObserver<long> observer, CancellationToken cancellationToken) { }

	// RVA: 0x19D9200 Offset: 0x19D9301 VA: 0x19D9200
	public static IObservable<long> EveryGameObjectUpdate() { }

	// RVA: 0x19D9390 Offset: 0x19D9491 VA: 0x19D9390
	public static IObservable<long> EveryLateUpdate() { }

	[ObsoleteAttribute] // RVA: 0x14FF0 Offset: 0x150F1 VA: 0x14FF0
	// RVA: 0x19D9520 Offset: 0x19D9621 VA: 0x19D9520
	public static IObservable<long> EveryAfterUpdate() { }

	// RVA: 0x19D9670 Offset: 0x19D9771 VA: 0x19D9670
	public static IObservable<Unit> NextFrame(FrameCountType frameCountType = 0) { }

	[IteratorStateMachineAttribute] // RVA: 0x15000 Offset: 0x15101 VA: 0x15000
	// RVA: 0x19D97D0 Offset: 0x19D98D1 VA: 0x19D97D0
	private static IEnumerator NextFrameCore(IObserver<Unit> observer, CancellationToken cancellation) { }

	// RVA: 0x19D9860 Offset: 0x19D9961 VA: 0x19D9860
	public static IObservable<long> IntervalFrame(int intervalFrameCount, FrameCountType frameCountType = 0) { }

	// RVA: 0x19D9A10 Offset: 0x19D9B11 VA: 0x19D9A10
	public static IObservable<long> TimerFrame(int dueTimeFrameCount, FrameCountType frameCountType = 0) { }

	// RVA: 0x19D98E0 Offset: 0x19D99E1 VA: 0x19D98E0
	public static IObservable<long> TimerFrame(int dueTimeFrameCount, int periodFrameCount, FrameCountType frameCountType = 0) { }

	[IteratorStateMachineAttribute] // RVA: 0x15070 Offset: 0x15171 VA: 0x15070
	// RVA: 0x19D9B30 Offset: 0x19D9C31 VA: 0x19D9B30
	private static IEnumerator TimerFrameCore(IObserver<long> observer, int dueTimeFrameCount, CancellationToken cancel) { }

	[IteratorStateMachineAttribute] // RVA: 0x150E0 Offset: 0x151E1 VA: 0x150E0
	// RVA: 0x19D9BD0 Offset: 0x19D9CD1 VA: 0x19D9BD0
	private static IEnumerator TimerFrameCore(IObserver<long> observer, int dueTimeFrameCount, int periodFrameCount, CancellationToken cancel) { }

	[ExtensionAttribute] // RVA: 0x15150 Offset: 0x15251 VA: 0x15150
	// RVA: -1 Offset: -1
	public static IObservable<T> DelayFrame<T>(IObservable<T> source, int frameCount, FrameCountType frameCountType = 0) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x296D4C0 Offset: 0x296D5C1 VA: 0x296D4C0
	|-Observable.DelayFrame<object>
	*/

	[ExtensionAttribute] // RVA: 0x15160 Offset: 0x15261 VA: 0x15160
	// RVA: -1 Offset: -1
	public static IObservable<T> Sample<T, T2>(IObservable<T> source, IObservable<T2> sampler) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2975EA0 Offset: 0x2975FA1 VA: 0x2975EA0
	|-Observable.Sample<object, object>
	*/

	[ExtensionAttribute] // RVA: 0x15170 Offset: 0x15271 VA: 0x15170
	// RVA: -1 Offset: -1
	public static IObservable<T> SampleFrame<T>(IObservable<T> source, int frameCount, FrameCountType frameCountType = 0) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2975F90 Offset: 0x2976091 VA: 0x2975F90
	|-Observable.SampleFrame<object>
	*/

	[ExtensionAttribute] // RVA: 0x15180 Offset: 0x15281 VA: 0x15180
	// RVA: -1 Offset: -1
	public static IObservable<TSource> ThrottleFrame<TSource>(IObservable<TSource> source, int frameCount, FrameCountType frameCountType = 0) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2979A20 Offset: 0x2979B21 VA: 0x2979A20
	|-Observable.ThrottleFrame<object>
	*/

	[ExtensionAttribute] // RVA: 0x15190 Offset: 0x15291 VA: 0x15190
	// RVA: -1 Offset: -1
	public static IObservable<TSource> ThrottleFirstFrame<TSource>(IObservable<TSource> source, int frameCount, FrameCountType frameCountType = 0) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2979950 Offset: 0x2979A51 VA: 0x2979950
	|-Observable.ThrottleFirstFrame<object>
	*/

	[ExtensionAttribute] // RVA: 0x151A0 Offset: 0x152A1 VA: 0x151A0
	// RVA: -1 Offset: -1
	public static IObservable<T> TimeoutFrame<T>(IObservable<T> source, int frameCount, FrameCountType frameCountType = 0) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x297A160 Offset: 0x297A261 VA: 0x297A160
	|-Observable.TimeoutFrame<object>
	*/

	[ExtensionAttribute] // RVA: 0x151B0 Offset: 0x152B1 VA: 0x151B0
	// RVA: -1 Offset: -1
	public static IObservable<T> DelayFrameSubscription<T>(IObservable<T> source, int frameCount, FrameCountType frameCountType = 0) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x296D590 Offset: 0x296D691 VA: 0x296D590
	|-Observable.DelayFrameSubscription<object>
	*/

	[ExtensionAttribute] // RVA: 0x151C0 Offset: 0x152C1 VA: 0x151C0
	// RVA: -1 Offset: -1
	public static ObservableYieldInstruction<T> ToYieldInstruction<T>(IObservable<T> source) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x297AA80 Offset: 0x297AB81 VA: 0x297AA80
	|-Observable.ToYieldInstruction<object>
	|
	|-RVA: 0x297AB40 Offset: 0x297AC41 VA: 0x297AB40
	|-Observable.ToYieldInstruction<Unit>
	*/

	[ExtensionAttribute] // RVA: 0x151D0 Offset: 0x152D1 VA: 0x151D0
	// RVA: -1 Offset: -1
	public static ObservableYieldInstruction<T> ToYieldInstruction<T>(IObservable<T> source, CancellationToken cancel) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x297ACD0 Offset: 0x297ADD1 VA: 0x297ACD0
	|-Observable.ToYieldInstruction<object>
	|
	|-RVA: 0x297AE10 Offset: 0x297AF11 VA: 0x297AE10
	|-Observable.ToYieldInstruction<Unit>
	*/

	[ExtensionAttribute] // RVA: 0x151E0 Offset: 0x152E1 VA: 0x151E0
	// RVA: -1 Offset: -1
	public static ObservableYieldInstruction<T> ToYieldInstruction<T>(IObservable<T> source, bool throwOnError) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x297AC00 Offset: 0x297AD01 VA: 0x297AC00
	|-Observable.ToYieldInstruction<object>
	|
	|-RVA: 0x297AD40 Offset: 0x297AE41 VA: 0x297AD40
	|-Observable.ToYieldInstruction<Unit>
	*/

	[ExtensionAttribute] // RVA: 0x151F0 Offset: 0x152F1 VA: 0x151F0
	// RVA: -1 Offset: -1
	public static ObservableYieldInstruction<T> ToYieldInstruction<T>(IObservable<T> source, bool throwOnError, CancellationToken cancel) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x297AE80 Offset: 0x297AF81 VA: 0x297AE80
	|-Observable.ToYieldInstruction<object>
	|
	|-RVA: 0x297AF00 Offset: 0x297B001 VA: 0x297AF00
	|-Observable.ToYieldInstruction<Unit>
	*/

	[ExtensionAttribute] // RVA: 0x15200 Offset: 0x15301 VA: 0x15200
	// RVA: -1 Offset: -1
	public static IEnumerator ToAwaitableEnumerator<T>(IObservable<T> source, CancellationToken cancel) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x297A4F0 Offset: 0x297A5F1 VA: 0x297A4F0
	|-Observable.ToAwaitableEnumerator<object>
	*/

	[ExtensionAttribute] // RVA: 0x15210 Offset: 0x15311 VA: 0x15210
	// RVA: -1 Offset: -1
	public static IEnumerator ToAwaitableEnumerator<T>(IObservable<T> source, Action<T> onResult, CancellationToken cancel) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x297A780 Offset: 0x297A881 VA: 0x297A780
	|-Observable.ToAwaitableEnumerator<object>
	*/

	[ExtensionAttribute] // RVA: 0x15220 Offset: 0x15321 VA: 0x15220
	// RVA: -1 Offset: -1
	public static IEnumerator ToAwaitableEnumerator<T>(IObservable<T> source, Action<Exception> onError, CancellationToken cancel) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x297A650 Offset: 0x297A751 VA: 0x297A650
	|-Observable.ToAwaitableEnumerator<object>
	*/

	[ExtensionAttribute] // RVA: 0x15230 Offset: 0x15331 VA: 0x15230
	[IteratorStateMachineAttribute] // RVA: 0x15230 Offset: 0x15331 VA: 0x15230
	// RVA: -1 Offset: -1
	public static IEnumerator ToAwaitableEnumerator<T>(IObservable<T> source, Action<T> onResult, Action<Exception> onError, CancellationToken cancel) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x297A850 Offset: 0x297A951 VA: 0x297A850
	|-Observable.ToAwaitableEnumerator<object>
	*/

	[ExtensionAttribute] // RVA: 0x152B0 Offset: 0x153B1 VA: 0x152B0
	// RVA: -1 Offset: -1
	public static Coroutine StartAsCoroutine<T>(IObservable<T> source, CancellationToken cancel) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x29778A0 Offset: 0x29779A1 VA: 0x29778A0
	|-Observable.StartAsCoroutine<object>
	*/

	[ExtensionAttribute] // RVA: 0x152C0 Offset: 0x153C1 VA: 0x152C0
	// RVA: -1 Offset: -1
	public static Coroutine StartAsCoroutine<T>(IObservable<T> source, Action<T> onResult, CancellationToken cancel) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2977B30 Offset: 0x2977C31 VA: 0x2977B30
	|-Observable.StartAsCoroutine<object>
	*/

	[ExtensionAttribute] // RVA: 0x152D0 Offset: 0x153D1 VA: 0x152D0
	// RVA: -1 Offset: -1
	public static Coroutine StartAsCoroutine<T>(IObservable<T> source, Action<Exception> onError, CancellationToken cancel) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2977A00 Offset: 0x2977B01 VA: 0x2977A00
	|-Observable.StartAsCoroutine<object>
	*/

	[ExtensionAttribute] // RVA: 0x152E0 Offset: 0x153E1 VA: 0x152E0
	// RVA: -1 Offset: -1
	public static Coroutine StartAsCoroutine<T>(IObservable<T> source, Action<T> onResult, Action<Exception> onError, CancellationToken cancel) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2977C00 Offset: 0x2977D01 VA: 0x2977C00
	|-Observable.StartAsCoroutine<object>
	*/

	[ExtensionAttribute] // RVA: 0x152F0 Offset: 0x153F1 VA: 0x152F0
	// RVA: -1 Offset: -1
	public static IObservable<T> ObserveOnMainThread<T>(IObservable<T> source) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2972C80 Offset: 0x2972D81 VA: 0x2972C80
	|-Observable.ObserveOnMainThread<object>
	*/

	[ExtensionAttribute] // RVA: 0x15300 Offset: 0x15401 VA: 0x15300
	// RVA: -1 Offset: -1
	public static IObservable<T> ObserveOnMainThread<T>(IObservable<T> source, MainThreadDispatchType dispatchType) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2972D40 Offset: 0x2972E41 VA: 0x2972D40
	|-Observable.ObserveOnMainThread<object>
	*/

	[ExtensionAttribute] // RVA: 0x15310 Offset: 0x15411 VA: 0x15310
	// RVA: -1 Offset: -1
	public static IObservable<T> SubscribeOnMainThread<T>(IObservable<T> source) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2978310 Offset: 0x2978411 VA: 0x2978310
	|-Observable.SubscribeOnMainThread<object>
	*/

	// RVA: 0x19D9C70 Offset: 0x19D9D71 VA: 0x19D9C70
	public static IObservable<bool> EveryApplicationPause() { }

	// RVA: 0x19D9D20 Offset: 0x19D9E21 VA: 0x19D9D20
	public static IObservable<bool> EveryApplicationFocus() { }

	// RVA: 0x19D9DD0 Offset: 0x19D9ED1 VA: 0x19D9DD0
	public static IObservable<Unit> OnceApplicationQuit() { }

	[ExtensionAttribute] // RVA: 0x15320 Offset: 0x15421 VA: 0x15320
	// RVA: -1 Offset: -1
	public static IObservable<T> TakeUntilDestroy<T>(IObservable<T> source, Component target) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x29792D0 Offset: 0x29793D1 VA: 0x29792D0
	|-Observable.TakeUntilDestroy<object>
	*/

	[ExtensionAttribute] // RVA: 0x15330 Offset: 0x15431 VA: 0x15330
	// RVA: -1 Offset: -1
	public static IObservable<T> TakeUntilDestroy<T>(IObservable<T> source, GameObject target) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2979370 Offset: 0x2979471 VA: 0x2979370
	|-Observable.TakeUntilDestroy<object>
	*/

	[ExtensionAttribute] // RVA: 0x15340 Offset: 0x15441 VA: 0x15340
	// RVA: -1 Offset: -1
	public static IObservable<T> TakeUntilDisable<T>(IObservable<T> source, Component target) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2979410 Offset: 0x2979511 VA: 0x2979410
	|-Observable.TakeUntilDisable<object>
	*/

	[ExtensionAttribute] // RVA: 0x15350 Offset: 0x15451 VA: 0x15350
	// RVA: -1 Offset: -1
	public static IObservable<T> TakeUntilDisable<T>(IObservable<T> source, GameObject target) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x29794B0 Offset: 0x29795B1 VA: 0x29794B0
	|-Observable.TakeUntilDisable<object>
	*/

	[ExtensionAttribute] // RVA: 0x15360 Offset: 0x15461 VA: 0x15360
	// RVA: -1 Offset: -1
	public static IObservable<T> RepeatUntilDestroy<T>(IObservable<T> source, GameObject target) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2974E40 Offset: 0x2974F41 VA: 0x2974E40
	|-Observable.RepeatUntilDestroy<object>
	*/

	[ExtensionAttribute] // RVA: 0x15370 Offset: 0x15471 VA: 0x15370
	// RVA: -1 Offset: -1
	public static IObservable<T> RepeatUntilDestroy<T>(IObservable<T> source, Component target) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2974D20 Offset: 0x2974E21 VA: 0x2974D20
	|-Observable.RepeatUntilDestroy<object>
	*/

	[ExtensionAttribute] // RVA: 0x15380 Offset: 0x15481 VA: 0x15380
	// RVA: -1 Offset: -1
	public static IObservable<T> RepeatUntilDisable<T>(IObservable<T> source, GameObject target) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2975010 Offset: 0x2975111 VA: 0x2975010
	|-Observable.RepeatUntilDisable<object>
	*/

	[ExtensionAttribute] // RVA: 0x15390 Offset: 0x15491 VA: 0x15390
	// RVA: -1 Offset: -1
	public static IObservable<T> RepeatUntilDisable<T>(IObservable<T> source, Component target) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2974EF0 Offset: 0x2974FF1 VA: 0x2974EF0
	|-Observable.RepeatUntilDisable<object>
	*/

	[ExtensionAttribute] // RVA: 0x153A0 Offset: 0x154A1 VA: 0x153A0
	// RVA: -1 Offset: -1
	private static IObservable<T> RepeatUntilCore<T>(IEnumerable<IObservable<T>> sources, IObservable<Unit> trigger, GameObject lifeTimeChecker) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2974CA0 Offset: 0x2974DA1 VA: 0x2974CA0
	|-Observable.RepeatUntilCore<object>
	*/

	[ExtensionAttribute] // RVA: 0x153B0 Offset: 0x154B1 VA: 0x153B0
	// RVA: -1 Offset: -1
	public static IObservable<FrameInterval<T>> FrameInterval<T>(IObservable<T> source) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2970170 Offset: 0x2970271 VA: 0x2970170
	|-Observable.FrameInterval<object>
	*/

	[ExtensionAttribute] // RVA: 0x153C0 Offset: 0x154C1 VA: 0x153C0
	// RVA: -1 Offset: -1
	public static IObservable<TimeInterval<T>> FrameTimeInterval<T>(IObservable<T> source, bool ignoreTimeScale = False) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x29701E0 Offset: 0x29702E1 VA: 0x29701E0
	|-Observable.FrameTimeInterval<object>
	*/

	[ExtensionAttribute] // RVA: 0x153D0 Offset: 0x154D1 VA: 0x153D0
	// RVA: -1 Offset: -1
	public static IObservable<IList<T>> BatchFrame<T>(IObservable<T> source) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x296B140 Offset: 0x296B241 VA: 0x296B140
	|-Observable.BatchFrame<object>
	*/

	[ExtensionAttribute] // RVA: 0x153E0 Offset: 0x154E1 VA: 0x153E0
	// RVA: -1 Offset: -1
	public static IObservable<IList<T>> BatchFrame<T>(IObservable<T> source, int frameCount, FrameCountType frameCountType) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x296B1C0 Offset: 0x296B2C1 VA: 0x296B1C0
	|-Observable.BatchFrame<object>
	*/

	[ExtensionAttribute] // RVA: 0x153F0 Offset: 0x154F1 VA: 0x153F0
	// RVA: 0x19D9E90 Offset: 0x19D9F91 VA: 0x19D9E90
	public static IObservable<Unit> BatchFrame(IObservable<Unit> source) { }

	[ExtensionAttribute] // RVA: 0x15400 Offset: 0x15501 VA: 0x15400
	// RVA: 0x19D9F00 Offset: 0x19DA001 VA: 0x19D9F00
	public static IObservable<Unit> BatchFrame(IObservable<Unit> source, int frameCount, FrameCountType frameCountType) { }

	// RVA: 0x19DA050 Offset: 0x19DA151 VA: 0x19DA050
	private static void .cctor() { }
}

