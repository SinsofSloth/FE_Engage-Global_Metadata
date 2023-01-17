// Namespace: UniRx
[ExtensionAttribute] // RVA: 0x12F30 Offset: 0x13031 VA: 0x12F30
public static class TaskObservableExtensions // TypeDefIndex: 6655
{
	// Methods

	[ExtensionAttribute] // RVA: 0x16110 Offset: 0x16211 VA: 0x16110
	// RVA: 0x1AF84C0 Offset: 0x1AF85C1 VA: 0x1AF84C0
	public static IObservable<Unit> ToObservable(Task task) { }

	[ExtensionAttribute] // RVA: 0x16120 Offset: 0x16221 VA: 0x16120
	// RVA: 0x1AF8780 Offset: 0x1AF8881 VA: 0x1AF8780
	public static IObservable<Unit> ToObservable(Task task, IScheduler scheduler) { }

	// RVA: 0x1AF8520 Offset: 0x1AF8621 VA: 0x1AF8520
	private static IObservable<Unit> ToObservableImpl(Task task, IScheduler scheduler) { }

	// RVA: 0x1AF8810 Offset: 0x1AF8911 VA: 0x1AF8810
	private static IObservable<Unit> ToObservableSlow(Task task, IScheduler scheduler) { }

	// RVA: 0x1AF89B0 Offset: 0x1AF8AB1 VA: 0x1AF89B0
	private static void ToObservableDone(Task task, IObserver<Unit> subject) { }

	[ExtensionAttribute] // RVA: 0x16130 Offset: 0x16231 VA: 0x16130
	// RVA: -1 Offset: -1
	public static IObservable<TResult> ToObservable<TResult>(Task<TResult> task) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2025B20 Offset: 0x2025C21 VA: 0x2025B20
	|-TaskObservableExtensions.ToObservable<object>
	*/

	[ExtensionAttribute] // RVA: 0x16140 Offset: 0x16241 VA: 0x16140
	// RVA: -1 Offset: -1
	public static IObservable<TResult> ToObservable<TResult>(Task<TResult> task, IScheduler scheduler) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2025BA0 Offset: 0x2025CA1 VA: 0x2025BA0
	|-TaskObservableExtensions.ToObservable<object>
	*/

	// RVA: -1 Offset: -1
	private static IObservable<TResult> ToObservableImpl<TResult>(Task<TResult> task, IScheduler scheduler) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2025EC0 Offset: 0x2025FC1 VA: 0x2025EC0
	|-TaskObservableExtensions.ToObservableImpl<object>
	*/

	// RVA: -1 Offset: -1
	private static IObservable<TResult> ToObservableSlow<TResult>(Task<TResult> task, IScheduler scheduler) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2026210 Offset: 0x2026311 VA: 0x2026210
	|-TaskObservableExtensions.ToObservableSlow<object>
	*/

	// RVA: -1 Offset: -1
	private static void ToObservableDone<TResult>(Task<TResult> task, IObserver<TResult> subject) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2025C40 Offset: 0x2025D41 VA: 0x2025C40
	|-TaskObservableExtensions.ToObservableDone<object>
	*/

	// RVA: 0x1AF89A0 Offset: 0x1AF8AA1 VA: 0x1AF89A0
	private static TaskContinuationOptions GetTaskContinuationOptions(IScheduler scheduler) { }

	// RVA: -1 Offset: -1
	private static IObservable<TResult> ToObservableResult<TResult>(AsyncSubject<TResult> subject, IScheduler scheduler) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2026090 Offset: 0x2026191 VA: 0x2026090
	|-TaskObservableExtensions.ToObservableResult<object>
	|
	|-RVA: 0x2026150 Offset: 0x2026251 VA: 0x2026150
	|-TaskObservableExtensions.ToObservableResult<Unit>
	*/

	[ExtensionAttribute] // RVA: 0x16150 Offset: 0x16251 VA: 0x16150
	// RVA: -1 Offset: -1
	public static Task<TResult> ToTask<TResult>(IObservable<TResult> observable) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2026350 Offset: 0x2026451 VA: 0x2026350
	|-TaskObservableExtensions.ToTask<object>
	*/

	[ExtensionAttribute] // RVA: 0x16160 Offset: 0x16261 VA: 0x16160
	// RVA: -1 Offset: -1
	public static Task<TResult> ToTask<TResult>(IObservable<TResult> observable, object state) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x20263D0 Offset: 0x20264D1 VA: 0x20263D0
	|-TaskObservableExtensions.ToTask<object>
	*/

	[ExtensionAttribute] // RVA: 0x16170 Offset: 0x16271 VA: 0x16170
	// RVA: -1 Offset: -1
	public static Task<TResult> ToTask<TResult>(IObservable<TResult> observable, CancellationToken cancellationToken) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2026450 Offset: 0x2026551 VA: 0x2026450
	|-TaskObservableExtensions.ToTask<object>
	*/

	[ExtensionAttribute] // RVA: 0x16180 Offset: 0x16281 VA: 0x16180
	// RVA: -1 Offset: -1
	public static Task<TResult> ToTask<TResult>(IObservable<TResult> observable, CancellationToken cancellationToken, object state) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x20264D0 Offset: 0x20265D1 VA: 0x20264D0
	|-TaskObservableExtensions.ToTask<object>
	*/
}

