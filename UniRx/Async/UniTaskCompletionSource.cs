// Namespace: UniRx.Async
public class UniTaskCompletionSource : IAwaiter, ICriticalNotifyCompletion, INotifyCompletion, IPromise, IResolvePromise, IRejectPromise, ICancelPromise // TypeDefIndex: 5106
{
	// Fields
	private const int Pending = 0;
	private const int Succeeded = 1;
	private const int Faulted = 2;
	private const int Canceled = 3;
	private int state; // 0x10
	private bool handled; // 0x14
	private ExceptionHolder exception; // 0x18
	private object continuation; // 0x20

	// Properties
	private AwaiterStatus UniRx.Async.IAwaiter.Status { get; }
	private bool UniRx.Async.IAwaiter.IsCompleted { get; }
	public UniTask Task { get; }

	// Methods

	// RVA: 0x2E87710 Offset: 0x2E87811 VA: 0x2E87710 Slot: 4
	private AwaiterStatus UniRx.Async.IAwaiter.get_Status() { }

	// RVA: 0x2E87720 Offset: 0x2E87821 VA: 0x2E87720 Slot: 5
	private bool UniRx.Async.IAwaiter.get_IsCompleted() { }

	// RVA: 0x2E7CE70 Offset: 0x2E7CF71 VA: 0x2E7CE70
	public UniTask get_Task() { }

	// RVA: 0x2E72820 Offset: 0x2E72921 VA: 0x2E72820
	public void .ctor() { }

	[ConditionalAttribute] // RVA: 0x2CF70 Offset: 0x2D071 VA: 0x2CF70
	// RVA: 0x2E87730 Offset: 0x2E87831 VA: 0x2E87730
	internal void MarkHandled() { }

	// RVA: 0x2E87750 Offset: 0x2E87851 VA: 0x2E87750 Slot: 6
	private void UniRx.Async.IAwaiter.GetResult() { }

	// RVA: 0x2E878D0 Offset: 0x2E879D1 VA: 0x2E878D0 Slot: 7
	private void System.Runtime.CompilerServices.ICriticalNotifyCompletion.UnsafeOnCompleted(Action action) { }

	// RVA: 0x2E87B10 Offset: 0x2E87C11 VA: 0x2E87B10
	private void TryInvokeContinuation() { }

	// RVA: 0x2E72580 Offset: 0x2E72681 VA: 0x2E72580 Slot: 9
	public bool TrySetResult() { }

	// RVA: 0x2E7D060 Offset: 0x2E7D161 VA: 0x2E7D060 Slot: 10
	public bool TrySetException(Exception exception) { }

	// RVA: 0x2E72880 Offset: 0x2E72981 VA: 0x2E72880 Slot: 11
	public bool TrySetCanceled() { }

	// RVA: 0x2E7CF90 Offset: 0x2E7D091 VA: 0x2E7CF90
	public bool TrySetCanceled(OperationCanceledException exception) { }

	// RVA: 0x2E87C50 Offset: 0x2E87D51 VA: 0x2E87C50 Slot: 8
	private void System.Runtime.CompilerServices.INotifyCompletion.OnCompleted(Action continuation) { }
}

// Namespace: UniRx.Async
public class UniTaskCompletionSource<T> : IAwaiter<T>, IAwaiter, ICriticalNotifyCompletion, INotifyCompletion, IPromise<T>, IResolvePromise<T>, IRejectPromise, ICancelPromise // TypeDefIndex: 5107
{
	// Fields
	private const int Pending = 0;
	private const int Succeeded = 1;
	private const int Faulted = 2;
	private const int Canceled = 3;
	private int state; // 0x0
	private T value; // 0x0
	private bool handled; // 0x0
	private ExceptionHolder exception; // 0x0
	private object continuation; // 0x0

	// Properties
	private bool UniRx.Async.IAwaiter.IsCompleted { get; }
	public UniTask<T> Task { get; }
	public UniTask UnitTask { get; }
	private AwaiterStatus UniRx.Async.IAwaiter.Status { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 6
	private bool UniRx.Async.IAwaiter.get_IsCompleted() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3579780 Offset: 0x3579881 VA: 0x3579780
	|-UniTaskCompletionSource<ValueTuple<bool, ValueTuple<bool, AsyncUnit>>>.UniRx.Async.IAwaiter.get_IsCompleted
	|
	|-RVA: 0x357A0E0 Offset: 0x357A1E1 VA: 0x357A0E0
	|-UniTaskCompletionSource<ValueTuple<bool, ValueTuple<bool, object>>>.UniRx.Async.IAwaiter.get_IsCompleted
	|
	|-RVA: 0x357AA80 Offset: 0x357AB81 VA: 0x357AA80
	|-UniTaskCompletionSource<ValueTuple<bool, AsyncUnit>>.UniRx.Async.IAwaiter.get_IsCompleted
	|
	|-RVA: 0x357B3C0 Offset: 0x357B4C1 VA: 0x357B3C0
	|-UniTaskCompletionSource<ValueTuple<bool, object>>.UniRx.Async.IAwaiter.get_IsCompleted
	|
	|-RVA: 0x357BD40 Offset: 0x357BE41 VA: 0x357BD40
	|-UniTaskCompletionSource<ValueTuple<int, object>>.UniRx.Async.IAwaiter.get_IsCompleted
	|
	|-RVA: 0x357C6C0 Offset: 0x357C7C1 VA: 0x357C6C0
	|-UniTaskCompletionSource<ValueTuple<object, object>>.UniRx.Async.IAwaiter.get_IsCompleted
	|
	|-RVA: 0x357D040 Offset: 0x357D141 VA: 0x357D040
	|-UniTaskCompletionSource<ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>>>.UniRx.Async.IAwaiter.get_IsCompleted
	|
	|-RVA: 0x357DA00 Offset: 0x357DB01 VA: 0x357DA00
	|-UniTaskCompletionSource<ValueTuple<object, object, object>>.UniRx.Async.IAwaiter.get_IsCompleted
	|
	|-RVA: 0x357E3A0 Offset: 0x357E4A1 VA: 0x357E3A0
	|-UniTaskCompletionSource<ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>.UniRx.Async.IAwaiter.get_IsCompleted
	|
	|-RVA: 0x357ED70 Offset: 0x357EE71 VA: 0x357ED70
	|-UniTaskCompletionSource<ValueTuple<object, object, object, object>>.UniRx.Async.IAwaiter.get_IsCompleted
	|
	|-RVA: 0x357F720 Offset: 0x357F821 VA: 0x357F720
	|-UniTaskCompletionSource<ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>.UniRx.Async.IAwaiter.get_IsCompleted
	|
	|-RVA: 0x3580110 Offset: 0x3580211 VA: 0x3580110
	|-UniTaskCompletionSource<ValueTuple<object, object, object, object, object>>.UniRx.Async.IAwaiter.get_IsCompleted
	|
	|-RVA: 0x3580AD0 Offset: 0x3580BD1 VA: 0x3580AD0
	|-UniTaskCompletionSource<ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>.UniRx.Async.IAwaiter.get_IsCompleted
	|
	|-RVA: 0x35814D0 Offset: 0x35815D1 VA: 0x35814D0
	|-UniTaskCompletionSource<ValueTuple<object, object, object, object, object, object>>.UniRx.Async.IAwaiter.get_IsCompleted
	|
	|-RVA: 0x3581E90 Offset: 0x3581F91 VA: 0x3581E90
	|-UniTaskCompletionSource<ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>.UniRx.Async.IAwaiter.get_IsCompleted
	|
	|-RVA: 0x35828B0 Offset: 0x35829B1 VA: 0x35828B0
	|-UniTaskCompletionSource<ValueTuple<object, object, object, object, object, object, object>>.UniRx.Async.IAwaiter.get_IsCompleted
	|
	|-RVA: 0x3583280 Offset: 0x3583381 VA: 0x3583280
	|-UniTaskCompletionSource<ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<ValueTuple<bool, object>>>>.UniRx.Async.IAwaiter.get_IsCompleted
	|
	|-RVA: 0x3583CB0 Offset: 0x3583DB1 VA: 0x3583CB0
	|-UniTaskCompletionSource<ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<ValueTuple<bool, object>, ValueTuple<bool, object>>>>.UniRx.Async.IAwaiter.get_IsCompleted
	|
	|-RVA: 0x3584690 Offset: 0x3584791 VA: 0x3584690
	|-UniTaskCompletionSource<AsyncUnit>.UniRx.Async.IAwaiter.get_IsCompleted
	|
	|-RVA: 0x3584FD0 Offset: 0x35850D1 VA: 0x3584FD0
	|-UniTaskCompletionSource<bool>.UniRx.Async.IAwaiter.get_IsCompleted
	|
	|-RVA: 0x3585920 Offset: 0x3585A21 VA: 0x3585920
	|-UniTaskCompletionSource<int>.UniRx.Async.IAwaiter.get_IsCompleted
	|
	|-RVA: 0x3586260 Offset: 0x3586361 VA: 0x3586260
	|-UniTaskCompletionSource<object>.UniRx.Async.IAwaiter.get_IsCompleted
	|
	|-RVA: 0x3586BB0 Offset: 0x3586CB1 VA: 0x3586BB0
	|-UniTaskCompletionSource<float>.UniRx.Async.IAwaiter.get_IsCompleted
	*/

	// RVA: -1 Offset: -1
	public UniTask<T> get_Task() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3579790 Offset: 0x3579891 VA: 0x3579790
	|-UniTaskCompletionSource<ValueTuple<bool, ValueTuple<bool, AsyncUnit>>>.get_Task
	|
	|-RVA: 0x357A0F0 Offset: 0x357A1F1 VA: 0x357A0F0
	|-UniTaskCompletionSource<ValueTuple<bool, ValueTuple<bool, object>>>.get_Task
	|
	|-RVA: 0x357AA90 Offset: 0x357AB91 VA: 0x357AA90
	|-UniTaskCompletionSource<ValueTuple<bool, AsyncUnit>>.get_Task
	|
	|-RVA: 0x357B3D0 Offset: 0x357B4D1 VA: 0x357B3D0
	|-UniTaskCompletionSource<ValueTuple<bool, object>>.get_Task
	|
	|-RVA: 0x357BD50 Offset: 0x357BE51 VA: 0x357BD50
	|-UniTaskCompletionSource<ValueTuple<int, object>>.get_Task
	|
	|-RVA: 0x357C6D0 Offset: 0x357C7D1 VA: 0x357C6D0
	|-UniTaskCompletionSource<ValueTuple<object, object>>.get_Task
	|
	|-RVA: 0x357D050 Offset: 0x357D151 VA: 0x357D050
	|-UniTaskCompletionSource<ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>>>.get_Task
	|
	|-RVA: 0x357DA10 Offset: 0x357DB11 VA: 0x357DA10
	|-UniTaskCompletionSource<ValueTuple<object, object, object>>.get_Task
	|
	|-RVA: 0x357E3B0 Offset: 0x357E4B1 VA: 0x357E3B0
	|-UniTaskCompletionSource<ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>.get_Task
	|
	|-RVA: 0x357ED80 Offset: 0x357EE81 VA: 0x357ED80
	|-UniTaskCompletionSource<ValueTuple<object, object, object, object>>.get_Task
	|
	|-RVA: 0x357F730 Offset: 0x357F831 VA: 0x357F730
	|-UniTaskCompletionSource<ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>.get_Task
	|
	|-RVA: 0x3580120 Offset: 0x3580221 VA: 0x3580120
	|-UniTaskCompletionSource<ValueTuple<object, object, object, object, object>>.get_Task
	|
	|-RVA: 0x3580AE0 Offset: 0x3580BE1 VA: 0x3580AE0
	|-UniTaskCompletionSource<ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>.get_Task
	|
	|-RVA: 0x35814E0 Offset: 0x35815E1 VA: 0x35814E0
	|-UniTaskCompletionSource<ValueTuple<object, object, object, object, object, object>>.get_Task
	|
	|-RVA: 0x3581EA0 Offset: 0x3581FA1 VA: 0x3581EA0
	|-UniTaskCompletionSource<ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>.get_Task
	|
	|-RVA: 0x35828C0 Offset: 0x35829C1 VA: 0x35828C0
	|-UniTaskCompletionSource<ValueTuple<object, object, object, object, object, object, object>>.get_Task
	|
	|-RVA: 0x3583290 Offset: 0x3583391 VA: 0x3583290
	|-UniTaskCompletionSource<ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<ValueTuple<bool, object>>>>.get_Task
	|
	|-RVA: 0x3583CC0 Offset: 0x3583DC1 VA: 0x3583CC0
	|-UniTaskCompletionSource<ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<ValueTuple<bool, object>, ValueTuple<bool, object>>>>.get_Task
	|
	|-RVA: 0x35846A0 Offset: 0x35847A1 VA: 0x35846A0
	|-UniTaskCompletionSource<AsyncUnit>.get_Task
	|
	|-RVA: 0x3584FE0 Offset: 0x35850E1 VA: 0x3584FE0
	|-UniTaskCompletionSource<bool>.get_Task
	|
	|-RVA: 0x3585930 Offset: 0x3585A31 VA: 0x3585930
	|-UniTaskCompletionSource<int>.get_Task
	|
	|-RVA: 0x3586270 Offset: 0x3586371 VA: 0x3586270
	|-UniTaskCompletionSource<object>.get_Task
	|
	|-RVA: 0x3586BC0 Offset: 0x3586CC1 VA: 0x3586BC0
	|-UniTaskCompletionSource<float>.get_Task
	*/

	// RVA: -1 Offset: -1
	public UniTask get_UnitTask() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x35797D0 Offset: 0x35798D1 VA: 0x35797D0
	|-UniTaskCompletionSource<ValueTuple<bool, ValueTuple<bool, AsyncUnit>>>.get_UnitTask
	|
	|-RVA: 0x357A150 Offset: 0x357A251 VA: 0x357A150
	|-UniTaskCompletionSource<ValueTuple<bool, ValueTuple<bool, object>>>.get_UnitTask
	|
	|-RVA: 0x357AAD0 Offset: 0x357ABD1 VA: 0x357AAD0
	|-UniTaskCompletionSource<ValueTuple<bool, AsyncUnit>>.get_UnitTask
	|
	|-RVA: 0x357B430 Offset: 0x357B531 VA: 0x357B430
	|-UniTaskCompletionSource<ValueTuple<bool, object>>.get_UnitTask
	|
	|-RVA: 0x357BDB0 Offset: 0x357BEB1 VA: 0x357BDB0
	|-UniTaskCompletionSource<ValueTuple<int, object>>.get_UnitTask
	|
	|-RVA: 0x357C730 Offset: 0x357C831 VA: 0x357C730
	|-UniTaskCompletionSource<ValueTuple<object, object>>.get_UnitTask
	|
	|-RVA: 0x357D0C0 Offset: 0x357D1C1 VA: 0x357D0C0
	|-UniTaskCompletionSource<ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>>>.get_UnitTask
	|
	|-RVA: 0x357DA70 Offset: 0x357DB71 VA: 0x357DA70
	|-UniTaskCompletionSource<ValueTuple<object, object, object>>.get_UnitTask
	|
	|-RVA: 0x357E420 Offset: 0x357E521 VA: 0x357E420
	|-UniTaskCompletionSource<ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>.get_UnitTask
	|
	|-RVA: 0x357EDF0 Offset: 0x357EEF1 VA: 0x357EDF0
	|-UniTaskCompletionSource<ValueTuple<object, object, object, object>>.get_UnitTask
	|
	|-RVA: 0x357F7B0 Offset: 0x357F8B1 VA: 0x357F7B0
	|-UniTaskCompletionSource<ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>.get_UnitTask
	|
	|-RVA: 0x3580190 Offset: 0x3580291 VA: 0x3580190
	|-UniTaskCompletionSource<ValueTuple<object, object, object, object, object>>.get_UnitTask
	|
	|-RVA: 0x3580B70 Offset: 0x3580C71 VA: 0x3580B70
	|-UniTaskCompletionSource<ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>.get_UnitTask
	|
	|-RVA: 0x3581550 Offset: 0x3581651 VA: 0x3581550
	|-UniTaskCompletionSource<ValueTuple<object, object, object, object, object, object>>.get_UnitTask
	|
	|-RVA: 0x3581F40 Offset: 0x3582041 VA: 0x3581F40
	|-UniTaskCompletionSource<ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>.get_UnitTask
	|
	|-RVA: 0x3582930 Offset: 0x3582A31 VA: 0x3582930
	|-UniTaskCompletionSource<ValueTuple<object, object, object, object, object, object, object>>.get_UnitTask
	|
	|-RVA: 0x3583330 Offset: 0x3583431 VA: 0x3583330
	|-UniTaskCompletionSource<ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<ValueTuple<bool, object>>>>.get_UnitTask
	|
	|-RVA: 0x3583D40 Offset: 0x3583E41 VA: 0x3583D40
	|-UniTaskCompletionSource<ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<ValueTuple<bool, object>, ValueTuple<bool, object>>>>.get_UnitTask
	|
	|-RVA: 0x35846E0 Offset: 0x35847E1 VA: 0x35846E0
	|-UniTaskCompletionSource<AsyncUnit>.get_UnitTask
	|
	|-RVA: 0x3585020 Offset: 0x3585121 VA: 0x3585020
	|-UniTaskCompletionSource<bool>.get_UnitTask
	|
	|-RVA: 0x3585970 Offset: 0x3585A71 VA: 0x3585970
	|-UniTaskCompletionSource<int>.get_UnitTask
	|
	|-RVA: 0x35862B0 Offset: 0x35863B1 VA: 0x35862B0
	|-UniTaskCompletionSource<object>.get_UnitTask
	|
	|-RVA: 0x3586C00 Offset: 0x3586D01 VA: 0x3586C00
	|-UniTaskCompletionSource<float>.get_UnitTask
	*/

	// RVA: -1 Offset: -1 Slot: 5
	private AwaiterStatus UniRx.Async.IAwaiter.get_Status() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3579800 Offset: 0x3579901 VA: 0x3579800
	|-UniTaskCompletionSource<ValueTuple<bool, ValueTuple<bool, AsyncUnit>>>.UniRx.Async.IAwaiter.get_Status
	|
	|-RVA: 0x357A180 Offset: 0x357A281 VA: 0x357A180
	|-UniTaskCompletionSource<ValueTuple<bool, ValueTuple<bool, object>>>.UniRx.Async.IAwaiter.get_Status
	|
	|-RVA: 0x357AB00 Offset: 0x357AC01 VA: 0x357AB00
	|-UniTaskCompletionSource<ValueTuple<bool, AsyncUnit>>.UniRx.Async.IAwaiter.get_Status
	|
	|-RVA: 0x357B460 Offset: 0x357B561 VA: 0x357B460
	|-UniTaskCompletionSource<ValueTuple<bool, object>>.UniRx.Async.IAwaiter.get_Status
	|
	|-RVA: 0x357BDE0 Offset: 0x357BEE1 VA: 0x357BDE0
	|-UniTaskCompletionSource<ValueTuple<int, object>>.UniRx.Async.IAwaiter.get_Status
	|
	|-RVA: 0x357C760 Offset: 0x357C861 VA: 0x357C760
	|-UniTaskCompletionSource<ValueTuple<object, object>>.UniRx.Async.IAwaiter.get_Status
	|
	|-RVA: 0x357D0F0 Offset: 0x357D1F1 VA: 0x357D0F0
	|-UniTaskCompletionSource<ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>>>.UniRx.Async.IAwaiter.get_Status
	|
	|-RVA: 0x357DAA0 Offset: 0x357DBA1 VA: 0x357DAA0
	|-UniTaskCompletionSource<ValueTuple<object, object, object>>.UniRx.Async.IAwaiter.get_Status
	|
	|-RVA: 0x357E450 Offset: 0x357E551 VA: 0x357E450
	|-UniTaskCompletionSource<ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>.UniRx.Async.IAwaiter.get_Status
	|
	|-RVA: 0x357EE20 Offset: 0x357EF21 VA: 0x357EE20
	|-UniTaskCompletionSource<ValueTuple<object, object, object, object>>.UniRx.Async.IAwaiter.get_Status
	|
	|-RVA: 0x357F7E0 Offset: 0x357F8E1 VA: 0x357F7E0
	|-UniTaskCompletionSource<ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>.UniRx.Async.IAwaiter.get_Status
	|
	|-RVA: 0x35801C0 Offset: 0x35802C1 VA: 0x35801C0
	|-UniTaskCompletionSource<ValueTuple<object, object, object, object, object>>.UniRx.Async.IAwaiter.get_Status
	|
	|-RVA: 0x3580BA0 Offset: 0x3580CA1 VA: 0x3580BA0
	|-UniTaskCompletionSource<ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>.UniRx.Async.IAwaiter.get_Status
	|
	|-RVA: 0x3581580 Offset: 0x3581681 VA: 0x3581580
	|-UniTaskCompletionSource<ValueTuple<object, object, object, object, object, object>>.UniRx.Async.IAwaiter.get_Status
	|
	|-RVA: 0x3581F70 Offset: 0x3582071 VA: 0x3581F70
	|-UniTaskCompletionSource<ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>.UniRx.Async.IAwaiter.get_Status
	|
	|-RVA: 0x3582960 Offset: 0x3582A61 VA: 0x3582960
	|-UniTaskCompletionSource<ValueTuple<object, object, object, object, object, object, object>>.UniRx.Async.IAwaiter.get_Status
	|
	|-RVA: 0x3583360 Offset: 0x3583461 VA: 0x3583360
	|-UniTaskCompletionSource<ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<ValueTuple<bool, object>>>>.UniRx.Async.IAwaiter.get_Status
	|
	|-RVA: 0x3583D70 Offset: 0x3583E71 VA: 0x3583D70
	|-UniTaskCompletionSource<ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<ValueTuple<bool, object>, ValueTuple<bool, object>>>>.UniRx.Async.IAwaiter.get_Status
	|
	|-RVA: 0x3584710 Offset: 0x3584811 VA: 0x3584710
	|-UniTaskCompletionSource<AsyncUnit>.UniRx.Async.IAwaiter.get_Status
	|
	|-RVA: 0x3585050 Offset: 0x3585151 VA: 0x3585050
	|-UniTaskCompletionSource<bool>.UniRx.Async.IAwaiter.get_Status
	|
	|-RVA: 0x35859A0 Offset: 0x3585AA1 VA: 0x35859A0
	|-UniTaskCompletionSource<int>.UniRx.Async.IAwaiter.get_Status
	|
	|-RVA: 0x35862E0 Offset: 0x35863E1 VA: 0x35862E0
	|-UniTaskCompletionSource<object>.UniRx.Async.IAwaiter.get_Status
	|
	|-RVA: 0x3586C30 Offset: 0x3586D31 VA: 0x3586C30
	|-UniTaskCompletionSource<float>.UniRx.Async.IAwaiter.get_Status
	*/

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3579810 Offset: 0x3579911 VA: 0x3579810
	|-UniTaskCompletionSource<ValueTuple<bool, ValueTuple<bool, AsyncUnit>>>..ctor
	|
	|-RVA: 0x357A190 Offset: 0x357A291 VA: 0x357A190
	|-UniTaskCompletionSource<ValueTuple<bool, ValueTuple<bool, object>>>..ctor
	|
	|-RVA: 0x357AB10 Offset: 0x357AC11 VA: 0x357AB10
	|-UniTaskCompletionSource<ValueTuple<bool, AsyncUnit>>..ctor
	|
	|-RVA: 0x357B470 Offset: 0x357B571 VA: 0x357B470
	|-UniTaskCompletionSource<ValueTuple<bool, object>>..ctor
	|
	|-RVA: 0x357BDF0 Offset: 0x357BEF1 VA: 0x357BDF0
	|-UniTaskCompletionSource<ValueTuple<int, object>>..ctor
	|
	|-RVA: 0x357C770 Offset: 0x357C871 VA: 0x357C770
	|-UniTaskCompletionSource<ValueTuple<object, object>>..ctor
	|
	|-RVA: 0x357D100 Offset: 0x357D201 VA: 0x357D100
	|-UniTaskCompletionSource<ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>>>..ctor
	|
	|-RVA: 0x357DAB0 Offset: 0x357DBB1 VA: 0x357DAB0
	|-UniTaskCompletionSource<ValueTuple<object, object, object>>..ctor
	|
	|-RVA: 0x357E460 Offset: 0x357E561 VA: 0x357E460
	|-UniTaskCompletionSource<ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>..ctor
	|
	|-RVA: 0x357EE30 Offset: 0x357EF31 VA: 0x357EE30
	|-UniTaskCompletionSource<ValueTuple<object, object, object, object>>..ctor
	|
	|-RVA: 0x357F7F0 Offset: 0x357F8F1 VA: 0x357F7F0
	|-UniTaskCompletionSource<ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>..ctor
	|
	|-RVA: 0x35801D0 Offset: 0x35802D1 VA: 0x35801D0
	|-UniTaskCompletionSource<ValueTuple<object, object, object, object, object>>..ctor
	|
	|-RVA: 0x3580BB0 Offset: 0x3580CB1 VA: 0x3580BB0
	|-UniTaskCompletionSource<ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>..ctor
	|
	|-RVA: 0x3581590 Offset: 0x3581691 VA: 0x3581590
	|-UniTaskCompletionSource<ValueTuple<object, object, object, object, object, object>>..ctor
	|
	|-RVA: 0x3581F80 Offset: 0x3582081 VA: 0x3581F80
	|-UniTaskCompletionSource<ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>..ctor
	|
	|-RVA: 0x3582970 Offset: 0x3582A71 VA: 0x3582970
	|-UniTaskCompletionSource<ValueTuple<object, object, object, object, object, object, object>>..ctor
	|
	|-RVA: 0x3583370 Offset: 0x3583471 VA: 0x3583370
	|-UniTaskCompletionSource<ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<ValueTuple<bool, object>>>>..ctor
	|
	|-RVA: 0x3583D80 Offset: 0x3583E81 VA: 0x3583D80
	|-UniTaskCompletionSource<ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<ValueTuple<bool, object>, ValueTuple<bool, object>>>>..ctor
	|
	|-RVA: 0x3584720 Offset: 0x3584821 VA: 0x3584720
	|-UniTaskCompletionSource<AsyncUnit>..ctor
	|
	|-RVA: 0x3585060 Offset: 0x3585161 VA: 0x3585060
	|-UniTaskCompletionSource<bool>..ctor
	|
	|-RVA: 0x35859B0 Offset: 0x3585AB1 VA: 0x35859B0
	|-UniTaskCompletionSource<int>..ctor
	|
	|-RVA: 0x35862F0 Offset: 0x35863F1 VA: 0x35862F0
	|-UniTaskCompletionSource<object>..ctor
	|
	|-RVA: 0x3586C40 Offset: 0x3586D41 VA: 0x3586C40
	|-UniTaskCompletionSource<float>..ctor
	*/

	[ConditionalAttribute] // RVA: 0x2CFB0 Offset: 0x2D0B1 VA: 0x2CFB0
	// RVA: -1 Offset: -1
	internal void MarkHandled() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3579820 Offset: 0x3579921 VA: 0x3579820
	|-UniTaskCompletionSource<ValueTuple<bool, ValueTuple<bool, AsyncUnit>>>.MarkHandled
	|
	|-RVA: 0x357A1A0 Offset: 0x357A2A1 VA: 0x357A1A0
	|-UniTaskCompletionSource<ValueTuple<bool, ValueTuple<bool, object>>>.MarkHandled
	|
	|-RVA: 0x357AB20 Offset: 0x357AC21 VA: 0x357AB20
	|-UniTaskCompletionSource<ValueTuple<bool, AsyncUnit>>.MarkHandled
	|
	|-RVA: 0x357B480 Offset: 0x357B581 VA: 0x357B480
	|-UniTaskCompletionSource<ValueTuple<bool, object>>.MarkHandled
	|
	|-RVA: 0x357BE00 Offset: 0x357BF01 VA: 0x357BE00
	|-UniTaskCompletionSource<ValueTuple<int, object>>.MarkHandled
	|
	|-RVA: 0x357C780 Offset: 0x357C881 VA: 0x357C780
	|-UniTaskCompletionSource<ValueTuple<object, object>>.MarkHandled
	|
	|-RVA: 0x357D110 Offset: 0x357D211 VA: 0x357D110
	|-UniTaskCompletionSource<ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>>>.MarkHandled
	|
	|-RVA: 0x357DAC0 Offset: 0x357DBC1 VA: 0x357DAC0
	|-UniTaskCompletionSource<ValueTuple<object, object, object>>.MarkHandled
	|
	|-RVA: 0x357E470 Offset: 0x357E571 VA: 0x357E470
	|-UniTaskCompletionSource<ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>.MarkHandled
	|
	|-RVA: 0x357EE40 Offset: 0x357EF41 VA: 0x357EE40
	|-UniTaskCompletionSource<ValueTuple<object, object, object, object>>.MarkHandled
	|
	|-RVA: 0x357F800 Offset: 0x357F901 VA: 0x357F800
	|-UniTaskCompletionSource<ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>.MarkHandled
	|
	|-RVA: 0x35801E0 Offset: 0x35802E1 VA: 0x35801E0
	|-UniTaskCompletionSource<ValueTuple<object, object, object, object, object>>.MarkHandled
	|
	|-RVA: 0x3580BC0 Offset: 0x3580CC1 VA: 0x3580BC0
	|-UniTaskCompletionSource<ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>.MarkHandled
	|
	|-RVA: 0x35815A0 Offset: 0x35816A1 VA: 0x35815A0
	|-UniTaskCompletionSource<ValueTuple<object, object, object, object, object, object>>.MarkHandled
	|
	|-RVA: 0x3581F90 Offset: 0x3582091 VA: 0x3581F90
	|-UniTaskCompletionSource<ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>.MarkHandled
	|
	|-RVA: 0x3582980 Offset: 0x3582A81 VA: 0x3582980
	|-UniTaskCompletionSource<ValueTuple<object, object, object, object, object, object, object>>.MarkHandled
	|
	|-RVA: 0x3583380 Offset: 0x3583481 VA: 0x3583380
	|-UniTaskCompletionSource<ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<ValueTuple<bool, object>>>>.MarkHandled
	|
	|-RVA: 0x3583D90 Offset: 0x3583E91 VA: 0x3583D90
	|-UniTaskCompletionSource<ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<ValueTuple<bool, object>, ValueTuple<bool, object>>>>.MarkHandled
	|
	|-RVA: 0x3584730 Offset: 0x3584831 VA: 0x3584730
	|-UniTaskCompletionSource<AsyncUnit>.MarkHandled
	|
	|-RVA: 0x3585070 Offset: 0x3585171 VA: 0x3585070
	|-UniTaskCompletionSource<bool>.MarkHandled
	|
	|-RVA: 0x35859C0 Offset: 0x3585AC1 VA: 0x35859C0
	|-UniTaskCompletionSource<int>.MarkHandled
	|
	|-RVA: 0x3586300 Offset: 0x3586401 VA: 0x3586300
	|-UniTaskCompletionSource<object>.MarkHandled
	|
	|-RVA: 0x3586C50 Offset: 0x3586D51 VA: 0x3586C50
	|-UniTaskCompletionSource<float>.MarkHandled
	*/

	// RVA: -1 Offset: -1 Slot: 4
	private T UniRx.Async.IAwaiter<T>.GetResult() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3579840 Offset: 0x3579941 VA: 0x3579840
	|-UniTaskCompletionSource<ValueTuple<bool, ValueTuple<bool, AsyncUnit>>>.UniRx.Async.IAwaiter<T>.GetResult
	|
	|-RVA: 0x357A1C0 Offset: 0x357A2C1 VA: 0x357A1C0
	|-UniTaskCompletionSource<ValueTuple<bool, ValueTuple<bool, object>>>.UniRx.Async.IAwaiter<T>.GetResult
	|
	|-RVA: 0x357AB40 Offset: 0x357AC41 VA: 0x357AB40
	|-UniTaskCompletionSource<ValueTuple<bool, AsyncUnit>>.UniRx.Async.IAwaiter<T>.GetResult
	|
	|-RVA: 0x357B4A0 Offset: 0x357B5A1 VA: 0x357B4A0
	|-UniTaskCompletionSource<ValueTuple<bool, object>>.UniRx.Async.IAwaiter<T>.GetResult
	|
	|-RVA: 0x357BE20 Offset: 0x357BF21 VA: 0x357BE20
	|-UniTaskCompletionSource<ValueTuple<int, object>>.UniRx.Async.IAwaiter<T>.GetResult
	|
	|-RVA: 0x357C7A0 Offset: 0x357C8A1 VA: 0x357C7A0
	|-UniTaskCompletionSource<ValueTuple<object, object>>.UniRx.Async.IAwaiter<T>.GetResult
	|
	|-RVA: 0x357D130 Offset: 0x357D231 VA: 0x357D130
	|-UniTaskCompletionSource<ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>>>.UniRx.Async.IAwaiter<T>.GetResult
	|
	|-RVA: 0x357DAE0 Offset: 0x357DBE1 VA: 0x357DAE0
	|-UniTaskCompletionSource<ValueTuple<object, object, object>>.UniRx.Async.IAwaiter<T>.GetResult
	|
	|-RVA: 0x357E490 Offset: 0x357E591 VA: 0x357E490
	|-UniTaskCompletionSource<ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>.UniRx.Async.IAwaiter<T>.GetResult
	|
	|-RVA: 0x357EE60 Offset: 0x357EF61 VA: 0x357EE60
	|-UniTaskCompletionSource<ValueTuple<object, object, object, object>>.UniRx.Async.IAwaiter<T>.GetResult
	|
	|-RVA: 0x357F820 Offset: 0x357F921 VA: 0x357F820
	|-UniTaskCompletionSource<ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>.UniRx.Async.IAwaiter<T>.GetResult
	|
	|-RVA: 0x3580200 Offset: 0x3580301 VA: 0x3580200
	|-UniTaskCompletionSource<ValueTuple<object, object, object, object, object>>.UniRx.Async.IAwaiter<T>.GetResult
	|
	|-RVA: 0x3580BE0 Offset: 0x3580CE1 VA: 0x3580BE0
	|-UniTaskCompletionSource<ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>.UniRx.Async.IAwaiter<T>.GetResult
	|
	|-RVA: 0x35815C0 Offset: 0x35816C1 VA: 0x35815C0
	|-UniTaskCompletionSource<ValueTuple<object, object, object, object, object, object>>.UniRx.Async.IAwaiter<T>.GetResult
	|
	|-RVA: 0x3581FB0 Offset: 0x35820B1 VA: 0x3581FB0
	|-UniTaskCompletionSource<ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>.UniRx.Async.IAwaiter<T>.GetResult
	|
	|-RVA: 0x35829A0 Offset: 0x3582AA1 VA: 0x35829A0
	|-UniTaskCompletionSource<ValueTuple<object, object, object, object, object, object, object>>.UniRx.Async.IAwaiter<T>.GetResult
	|
	|-RVA: 0x35833A0 Offset: 0x35834A1 VA: 0x35833A0
	|-UniTaskCompletionSource<ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<ValueTuple<bool, object>>>>.UniRx.Async.IAwaiter<T>.GetResult
	|
	|-RVA: 0x3583DB0 Offset: 0x3583EB1 VA: 0x3583DB0
	|-UniTaskCompletionSource<ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<ValueTuple<bool, object>, ValueTuple<bool, object>>>>.UniRx.Async.IAwaiter<T>.GetResult
	|
	|-RVA: 0x3584750 Offset: 0x3584851 VA: 0x3584750
	|-UniTaskCompletionSource<AsyncUnit>.UniRx.Async.IAwaiter<T>.GetResult
	|
	|-RVA: 0x3585090 Offset: 0x3585191 VA: 0x3585090
	|-UniTaskCompletionSource<bool>.UniRx.Async.IAwaiter<T>.GetResult
	|
	|-RVA: 0x35859E0 Offset: 0x3585AE1 VA: 0x35859E0
	|-UniTaskCompletionSource<int>.UniRx.Async.IAwaiter<T>.GetResult
	|
	|-RVA: 0x3586320 Offset: 0x3586421 VA: 0x3586320
	|-UniTaskCompletionSource<object>.UniRx.Async.IAwaiter<T>.GetResult
	|
	|-RVA: 0x3586C70 Offset: 0x3586D71 VA: 0x3586C70
	|-UniTaskCompletionSource<float>.UniRx.Async.IAwaiter<T>.GetResult
	*/

	// RVA: -1 Offset: -1 Slot: 8
	private void System.Runtime.CompilerServices.ICriticalNotifyCompletion.UnsafeOnCompleted(Action action) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3579930 Offset: 0x3579A31 VA: 0x3579930
	|-UniTaskCompletionSource<ValueTuple<bool, ValueTuple<bool, AsyncUnit>>>.System.Runtime.CompilerServices.ICriticalNotifyCompletion.UnsafeOnCompleted
	|
	|-RVA: 0x357A2B0 Offset: 0x357A3B1 VA: 0x357A2B0
	|-UniTaskCompletionSource<ValueTuple<bool, ValueTuple<bool, object>>>.System.Runtime.CompilerServices.ICriticalNotifyCompletion.UnsafeOnCompleted
	|
	|-RVA: 0x357AC20 Offset: 0x357AD21 VA: 0x357AC20
	|-UniTaskCompletionSource<ValueTuple<bool, AsyncUnit>>.System.Runtime.CompilerServices.ICriticalNotifyCompletion.UnsafeOnCompleted
	|
	|-RVA: 0x357B590 Offset: 0x357B691 VA: 0x357B590
	|-UniTaskCompletionSource<ValueTuple<bool, object>>.System.Runtime.CompilerServices.ICriticalNotifyCompletion.UnsafeOnCompleted
	|
	|-RVA: 0x357BF10 Offset: 0x357C011 VA: 0x357BF10
	|-UniTaskCompletionSource<ValueTuple<int, object>>.System.Runtime.CompilerServices.ICriticalNotifyCompletion.UnsafeOnCompleted
	|
	|-RVA: 0x357C890 Offset: 0x357C991 VA: 0x357C890
	|-UniTaskCompletionSource<ValueTuple<object, object>>.System.Runtime.CompilerServices.ICriticalNotifyCompletion.UnsafeOnCompleted
	|
	|-RVA: 0x357D230 Offset: 0x357D331 VA: 0x357D230
	|-UniTaskCompletionSource<ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>>>.System.Runtime.CompilerServices.ICriticalNotifyCompletion.UnsafeOnCompleted
	|
	|-RVA: 0x357DBD0 Offset: 0x357DCD1 VA: 0x357DBD0
	|-UniTaskCompletionSource<ValueTuple<object, object, object>>.System.Runtime.CompilerServices.ICriticalNotifyCompletion.UnsafeOnCompleted
	|
	|-RVA: 0x357E5A0 Offset: 0x357E6A1 VA: 0x357E5A0
	|-UniTaskCompletionSource<ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>.System.Runtime.CompilerServices.ICriticalNotifyCompletion.UnsafeOnCompleted
	|
	|-RVA: 0x357EF50 Offset: 0x357F051 VA: 0x357EF50
	|-UniTaskCompletionSource<ValueTuple<object, object, object, object>>.System.Runtime.CompilerServices.ICriticalNotifyCompletion.UnsafeOnCompleted
	|
	|-RVA: 0x357F940 Offset: 0x357FA41 VA: 0x357F940
	|-UniTaskCompletionSource<ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>.System.Runtime.CompilerServices.ICriticalNotifyCompletion.UnsafeOnCompleted
	|
	|-RVA: 0x3580300 Offset: 0x3580401 VA: 0x3580300
	|-UniTaskCompletionSource<ValueTuple<object, object, object, object, object>>.System.Runtime.CompilerServices.ICriticalNotifyCompletion.UnsafeOnCompleted
	|
	|-RVA: 0x3580D00 Offset: 0x3580E01 VA: 0x3580D00
	|-UniTaskCompletionSource<ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>.System.Runtime.CompilerServices.ICriticalNotifyCompletion.UnsafeOnCompleted
	|
	|-RVA: 0x35816C0 Offset: 0x35817C1 VA: 0x35816C0
	|-UniTaskCompletionSource<ValueTuple<object, object, object, object, object, object>>.System.Runtime.CompilerServices.ICriticalNotifyCompletion.UnsafeOnCompleted
	|
	|-RVA: 0x35820E0 Offset: 0x35821E1 VA: 0x35820E0
	|-UniTaskCompletionSource<ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>.System.Runtime.CompilerServices.ICriticalNotifyCompletion.UnsafeOnCompleted
	|
	|-RVA: 0x3582AB0 Offset: 0x3582BB1 VA: 0x3582AB0
	|-UniTaskCompletionSource<ValueTuple<object, object, object, object, object, object, object>>.System.Runtime.CompilerServices.ICriticalNotifyCompletion.UnsafeOnCompleted
	|
	|-RVA: 0x35834E0 Offset: 0x35835E1 VA: 0x35834E0
	|-UniTaskCompletionSource<ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<ValueTuple<bool, object>>>>.System.Runtime.CompilerServices.ICriticalNotifyCompletion.UnsafeOnCompleted
	|
	|-RVA: 0x3583EC0 Offset: 0x3583FC1 VA: 0x3583EC0
	|-UniTaskCompletionSource<ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<ValueTuple<bool, object>, ValueTuple<bool, object>>>>.System.Runtime.CompilerServices.ICriticalNotifyCompletion.UnsafeOnCompleted
	|
	|-RVA: 0x3584830 Offset: 0x3584931 VA: 0x3584830
	|-UniTaskCompletionSource<AsyncUnit>.System.Runtime.CompilerServices.ICriticalNotifyCompletion.UnsafeOnCompleted
	|
	|-RVA: 0x3585180 Offset: 0x3585281 VA: 0x3585180
	|-UniTaskCompletionSource<bool>.System.Runtime.CompilerServices.ICriticalNotifyCompletion.UnsafeOnCompleted
	|
	|-RVA: 0x3585AC0 Offset: 0x3585BC1 VA: 0x3585AC0
	|-UniTaskCompletionSource<int>.System.Runtime.CompilerServices.ICriticalNotifyCompletion.UnsafeOnCompleted
	|
	|-RVA: 0x3586400 Offset: 0x3586501 VA: 0x3586400
	|-UniTaskCompletionSource<object>.System.Runtime.CompilerServices.ICriticalNotifyCompletion.UnsafeOnCompleted
	|
	|-RVA: 0x3586D50 Offset: 0x3586E51 VA: 0x3586D50
	|-UniTaskCompletionSource<float>.System.Runtime.CompilerServices.ICriticalNotifyCompletion.UnsafeOnCompleted
	*/

	// RVA: -1 Offset: -1
	private void TryInvokeContinuation() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3579B90 Offset: 0x3579C91 VA: 0x3579B90
	|-UniTaskCompletionSource<ValueTuple<bool, ValueTuple<bool, AsyncUnit>>>.TryInvokeContinuation
	|
	|-RVA: 0x357A510 Offset: 0x357A611 VA: 0x357A510
	|-UniTaskCompletionSource<ValueTuple<bool, ValueTuple<bool, object>>>.TryInvokeContinuation
	|
	|-RVA: 0x357AE80 Offset: 0x357AF81 VA: 0x357AE80
	|-UniTaskCompletionSource<ValueTuple<bool, AsyncUnit>>.TryInvokeContinuation
	|
	|-RVA: 0x357B7F0 Offset: 0x357B8F1 VA: 0x357B7F0
	|-UniTaskCompletionSource<ValueTuple<bool, object>>.TryInvokeContinuation
	|
	|-RVA: 0x357C170 Offset: 0x357C271 VA: 0x357C170
	|-UniTaskCompletionSource<ValueTuple<int, object>>.TryInvokeContinuation
	|
	|-RVA: 0x357CAF0 Offset: 0x357CBF1 VA: 0x357CAF0
	|-UniTaskCompletionSource<ValueTuple<object, object>>.TryInvokeContinuation
	|
	|-RVA: 0x357D490 Offset: 0x357D591 VA: 0x357D490
	|-UniTaskCompletionSource<ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>>>.TryInvokeContinuation
	|
	|-RVA: 0x357DE30 Offset: 0x357DF31 VA: 0x357DE30
	|-UniTaskCompletionSource<ValueTuple<object, object, object>>.TryInvokeContinuation
	|
	|-RVA: 0x357E800 Offset: 0x357E901 VA: 0x357E800
	|-UniTaskCompletionSource<ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>.TryInvokeContinuation
	|
	|-RVA: 0x357F1B0 Offset: 0x357F2B1 VA: 0x357F1B0
	|-UniTaskCompletionSource<ValueTuple<object, object, object, object>>.TryInvokeContinuation
	|
	|-RVA: 0x357FBA0 Offset: 0x357FCA1 VA: 0x357FBA0
	|-UniTaskCompletionSource<ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>.TryInvokeContinuation
	|
	|-RVA: 0x3580560 Offset: 0x3580661 VA: 0x3580560
	|-UniTaskCompletionSource<ValueTuple<object, object, object, object, object>>.TryInvokeContinuation
	|
	|-RVA: 0x3580F60 Offset: 0x3581061 VA: 0x3580F60
	|-UniTaskCompletionSource<ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>.TryInvokeContinuation
	|
	|-RVA: 0x3581920 Offset: 0x3581A21 VA: 0x3581920
	|-UniTaskCompletionSource<ValueTuple<object, object, object, object, object, object>>.TryInvokeContinuation
	|
	|-RVA: 0x3582340 Offset: 0x3582441 VA: 0x3582340
	|-UniTaskCompletionSource<ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>.TryInvokeContinuation
	|
	|-RVA: 0x3582D10 Offset: 0x3582E11 VA: 0x3582D10
	|-UniTaskCompletionSource<ValueTuple<object, object, object, object, object, object, object>>.TryInvokeContinuation
	|
	|-RVA: 0x3583740 Offset: 0x3583841 VA: 0x3583740
	|-UniTaskCompletionSource<ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<ValueTuple<bool, object>>>>.TryInvokeContinuation
	|
	|-RVA: 0x3584120 Offset: 0x3584221 VA: 0x3584120
	|-UniTaskCompletionSource<ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<ValueTuple<bool, object>, ValueTuple<bool, object>>>>.TryInvokeContinuation
	|
	|-RVA: 0x3584A90 Offset: 0x3584B91 VA: 0x3584A90
	|-UniTaskCompletionSource<AsyncUnit>.TryInvokeContinuation
	|
	|-RVA: 0x35853E0 Offset: 0x35854E1 VA: 0x35853E0
	|-UniTaskCompletionSource<bool>.TryInvokeContinuation
	|
	|-RVA: 0x3585D20 Offset: 0x3585E21 VA: 0x3585D20
	|-UniTaskCompletionSource<int>.TryInvokeContinuation
	|
	|-RVA: 0x3586660 Offset: 0x3586761 VA: 0x3586660
	|-UniTaskCompletionSource<object>.TryInvokeContinuation
	|
	|-RVA: 0x3586FB0 Offset: 0x35870B1 VA: 0x3586FB0
	|-UniTaskCompletionSource<float>.TryInvokeContinuation
	*/

	// RVA: -1 Offset: -1 Slot: 10
	public bool TrySetResult(T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3579CE0 Offset: 0x3579DE1 VA: 0x3579CE0
	|-UniTaskCompletionSource<ValueTuple<bool, ValueTuple<bool, AsyncUnit>>>.TrySetResult
	|
	|-RVA: 0x357A660 Offset: 0x357A761 VA: 0x357A660
	|-UniTaskCompletionSource<ValueTuple<bool, ValueTuple<bool, object>>>.TrySetResult
	|
	|-RVA: 0x357AFD0 Offset: 0x357B0D1 VA: 0x357AFD0
	|-UniTaskCompletionSource<ValueTuple<bool, AsyncUnit>>.TrySetResult
	|
	|-RVA: 0x357B940 Offset: 0x357BA41 VA: 0x357B940
	|-UniTaskCompletionSource<ValueTuple<bool, object>>.TrySetResult
	|
	|-RVA: 0x357C2C0 Offset: 0x357C3C1 VA: 0x357C2C0
	|-UniTaskCompletionSource<ValueTuple<int, object>>.TrySetResult
	|
	|-RVA: 0x357CC40 Offset: 0x357CD41 VA: 0x357CC40
	|-UniTaskCompletionSource<ValueTuple<object, object>>.TrySetResult
	|
	|-RVA: 0x357D5E0 Offset: 0x357D6E1 VA: 0x357D5E0
	|-UniTaskCompletionSource<ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>>>.TrySetResult
	|
	|-RVA: 0x357DF80 Offset: 0x357E081 VA: 0x357DF80
	|-UniTaskCompletionSource<ValueTuple<object, object, object>>.TrySetResult
	|
	|-RVA: 0x357E950 Offset: 0x357EA51 VA: 0x357E950
	|-UniTaskCompletionSource<ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>.TrySetResult
	|
	|-RVA: 0x357F300 Offset: 0x357F401 VA: 0x357F300
	|-UniTaskCompletionSource<ValueTuple<object, object, object, object>>.TrySetResult
	|
	|-RVA: 0x357FCF0 Offset: 0x357FDF1 VA: 0x357FCF0
	|-UniTaskCompletionSource<ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>.TrySetResult
	|
	|-RVA: 0x35806B0 Offset: 0x35807B1 VA: 0x35806B0
	|-UniTaskCompletionSource<ValueTuple<object, object, object, object, object>>.TrySetResult
	|
	|-RVA: 0x35810B0 Offset: 0x35811B1 VA: 0x35810B0
	|-UniTaskCompletionSource<ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>.TrySetResult
	|
	|-RVA: 0x3581A70 Offset: 0x3581B71 VA: 0x3581A70
	|-UniTaskCompletionSource<ValueTuple<object, object, object, object, object, object>>.TrySetResult
	|
	|-RVA: 0x3582490 Offset: 0x3582591 VA: 0x3582490
	|-UniTaskCompletionSource<ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>.TrySetResult
	|
	|-RVA: 0x3582E60 Offset: 0x3582F61 VA: 0x3582E60
	|-UniTaskCompletionSource<ValueTuple<object, object, object, object, object, object, object>>.TrySetResult
	|
	|-RVA: 0x3583890 Offset: 0x3583991 VA: 0x3583890
	|-UniTaskCompletionSource<ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<ValueTuple<bool, object>>>>.TrySetResult
	|
	|-RVA: 0x3584270 Offset: 0x3584371 VA: 0x3584270
	|-UniTaskCompletionSource<ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<ValueTuple<bool, object>, ValueTuple<bool, object>>>>.TrySetResult
	|
	|-RVA: 0x3584BE0 Offset: 0x3584CE1 VA: 0x3584BE0
	|-UniTaskCompletionSource<AsyncUnit>.TrySetResult
	|
	|-RVA: 0x3585530 Offset: 0x3585631 VA: 0x3585530
	|-UniTaskCompletionSource<bool>.TrySetResult
	|
	|-RVA: 0x3585E70 Offset: 0x3585F71 VA: 0x3585E70
	|-UniTaskCompletionSource<int>.TrySetResult
	|
	|-RVA: 0x35867B0 Offset: 0x35868B1 VA: 0x35867B0
	|-UniTaskCompletionSource<object>.TrySetResult
	|
	|-RVA: 0x3587100 Offset: 0x3587201 VA: 0x3587100
	|-UniTaskCompletionSource<float>.TrySetResult
	*/

	// RVA: -1 Offset: -1 Slot: 11
	public bool TrySetException(Exception exception) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3579D70 Offset: 0x3579E71 VA: 0x3579D70
	|-UniTaskCompletionSource<ValueTuple<bool, ValueTuple<bool, AsyncUnit>>>.TrySetException
	|
	|-RVA: 0x357A700 Offset: 0x357A801 VA: 0x357A700
	|-UniTaskCompletionSource<ValueTuple<bool, ValueTuple<bool, object>>>.TrySetException
	|
	|-RVA: 0x357B050 Offset: 0x357B151 VA: 0x357B050
	|-UniTaskCompletionSource<ValueTuple<bool, AsyncUnit>>.TrySetException
	|
	|-RVA: 0x357B9D0 Offset: 0x357BAD1 VA: 0x357B9D0
	|-UniTaskCompletionSource<ValueTuple<bool, object>>.TrySetException
	|
	|-RVA: 0x357C350 Offset: 0x357C451 VA: 0x357C350
	|-UniTaskCompletionSource<ValueTuple<int, object>>.TrySetException
	|
	|-RVA: 0x357CCD0 Offset: 0x357CDD1 VA: 0x357CCD0
	|-UniTaskCompletionSource<ValueTuple<object, object>>.TrySetException
	|
	|-RVA: 0x357D680 Offset: 0x357D781 VA: 0x357D680
	|-UniTaskCompletionSource<ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>>>.TrySetException
	|
	|-RVA: 0x357E020 Offset: 0x357E121 VA: 0x357E020
	|-UniTaskCompletionSource<ValueTuple<object, object, object>>.TrySetException
	|
	|-RVA: 0x357E9F0 Offset: 0x357EAF1 VA: 0x357E9F0
	|-UniTaskCompletionSource<ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>.TrySetException
	|
	|-RVA: 0x357F3A0 Offset: 0x357F4A1 VA: 0x357F3A0
	|-UniTaskCompletionSource<ValueTuple<object, object, object, object>>.TrySetException
	|
	|-RVA: 0x357FD90 Offset: 0x357FE91 VA: 0x357FD90
	|-UniTaskCompletionSource<ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>.TrySetException
	|
	|-RVA: 0x3580750 Offset: 0x3580851 VA: 0x3580750
	|-UniTaskCompletionSource<ValueTuple<object, object, object, object, object>>.TrySetException
	|
	|-RVA: 0x3581150 Offset: 0x3581251 VA: 0x3581150
	|-UniTaskCompletionSource<ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>.TrySetException
	|
	|-RVA: 0x3581B10 Offset: 0x3581C11 VA: 0x3581B10
	|-UniTaskCompletionSource<ValueTuple<object, object, object, object, object, object>>.TrySetException
	|
	|-RVA: 0x3582530 Offset: 0x3582631 VA: 0x3582530
	|-UniTaskCompletionSource<ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>.TrySetException
	|
	|-RVA: 0x3582F00 Offset: 0x3583001 VA: 0x3582F00
	|-UniTaskCompletionSource<ValueTuple<object, object, object, object, object, object, object>>.TrySetException
	|
	|-RVA: 0x3583930 Offset: 0x3583A31 VA: 0x3583930
	|-UniTaskCompletionSource<ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<ValueTuple<bool, object>>>>.TrySetException
	|
	|-RVA: 0x3584310 Offset: 0x3584411 VA: 0x3584310
	|-UniTaskCompletionSource<ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<ValueTuple<bool, object>, ValueTuple<bool, object>>>>.TrySetException
	|
	|-RVA: 0x3584C60 Offset: 0x3584D61 VA: 0x3584C60
	|-UniTaskCompletionSource<AsyncUnit>.TrySetException
	|
	|-RVA: 0x35855B0 Offset: 0x35856B1 VA: 0x35855B0
	|-UniTaskCompletionSource<bool>.TrySetException
	|
	|-RVA: 0x3585EF0 Offset: 0x3585FF1 VA: 0x3585EF0
	|-UniTaskCompletionSource<int>.TrySetException
	|
	|-RVA: 0x3586840 Offset: 0x3586941 VA: 0x3586840
	|-UniTaskCompletionSource<object>.TrySetException
	|
	|-RVA: 0x3587180 Offset: 0x3587281 VA: 0x3587180
	|-UniTaskCompletionSource<float>.TrySetException
	*/

	// RVA: -1 Offset: -1 Slot: 12
	public bool TrySetCanceled() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3579E50 Offset: 0x3579F51 VA: 0x3579E50
	|-UniTaskCompletionSource<ValueTuple<bool, ValueTuple<bool, AsyncUnit>>>.TrySetCanceled
	|
	|-RVA: 0x357A7E0 Offset: 0x357A8E1 VA: 0x357A7E0
	|-UniTaskCompletionSource<ValueTuple<bool, ValueTuple<bool, object>>>.TrySetCanceled
	|
	|-RVA: 0x357B130 Offset: 0x357B231 VA: 0x357B130
	|-UniTaskCompletionSource<ValueTuple<bool, AsyncUnit>>.TrySetCanceled
	|
	|-RVA: 0x357BAB0 Offset: 0x357BBB1 VA: 0x357BAB0
	|-UniTaskCompletionSource<ValueTuple<bool, object>>.TrySetCanceled
	|
	|-RVA: 0x357C430 Offset: 0x357C531 VA: 0x357C430
	|-UniTaskCompletionSource<ValueTuple<int, object>>.TrySetCanceled
	|
	|-RVA: 0x357CDB0 Offset: 0x357CEB1 VA: 0x357CDB0
	|-UniTaskCompletionSource<ValueTuple<object, object>>.TrySetCanceled
	|
	|-RVA: 0x357D760 Offset: 0x357D861 VA: 0x357D760
	|-UniTaskCompletionSource<ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>>>.TrySetCanceled
	|
	|-RVA: 0x357E100 Offset: 0x357E201 VA: 0x357E100
	|-UniTaskCompletionSource<ValueTuple<object, object, object>>.TrySetCanceled
	|
	|-RVA: 0x357EAD0 Offset: 0x357EBD1 VA: 0x357EAD0
	|-UniTaskCompletionSource<ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>.TrySetCanceled
	|
	|-RVA: 0x357F480 Offset: 0x357F581 VA: 0x357F480
	|-UniTaskCompletionSource<ValueTuple<object, object, object, object>>.TrySetCanceled
	|
	|-RVA: 0x357FE70 Offset: 0x357FF71 VA: 0x357FE70
	|-UniTaskCompletionSource<ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>.TrySetCanceled
	|
	|-RVA: 0x3580830 Offset: 0x3580931 VA: 0x3580830
	|-UniTaskCompletionSource<ValueTuple<object, object, object, object, object>>.TrySetCanceled
	|
	|-RVA: 0x3581230 Offset: 0x3581331 VA: 0x3581230
	|-UniTaskCompletionSource<ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>.TrySetCanceled
	|
	|-RVA: 0x3581BF0 Offset: 0x3581CF1 VA: 0x3581BF0
	|-UniTaskCompletionSource<ValueTuple<object, object, object, object, object, object>>.TrySetCanceled
	|
	|-RVA: 0x3582610 Offset: 0x3582711 VA: 0x3582610
	|-UniTaskCompletionSource<ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>.TrySetCanceled
	|
	|-RVA: 0x3582FE0 Offset: 0x35830E1 VA: 0x3582FE0
	|-UniTaskCompletionSource<ValueTuple<object, object, object, object, object, object, object>>.TrySetCanceled
	|
	|-RVA: 0x3583A10 Offset: 0x3583B11 VA: 0x3583A10
	|-UniTaskCompletionSource<ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<ValueTuple<bool, object>>>>.TrySetCanceled
	|
	|-RVA: 0x35843F0 Offset: 0x35844F1 VA: 0x35843F0
	|-UniTaskCompletionSource<ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<ValueTuple<bool, object>, ValueTuple<bool, object>>>>.TrySetCanceled
	|
	|-RVA: 0x3584D40 Offset: 0x3584E41 VA: 0x3584D40
	|-UniTaskCompletionSource<AsyncUnit>.TrySetCanceled
	|
	|-RVA: 0x3585690 Offset: 0x3585791 VA: 0x3585690
	|-UniTaskCompletionSource<bool>.TrySetCanceled
	|
	|-RVA: 0x3585FD0 Offset: 0x35860D1 VA: 0x3585FD0
	|-UniTaskCompletionSource<int>.TrySetCanceled
	|
	|-RVA: 0x3586920 Offset: 0x3586A21 VA: 0x3586920
	|-UniTaskCompletionSource<object>.TrySetCanceled
	|
	|-RVA: 0x3587260 Offset: 0x3587361 VA: 0x3587260
	|-UniTaskCompletionSource<float>.TrySetCanceled
	*/

	// RVA: -1 Offset: -1
	public bool TrySetCanceled(OperationCanceledException exception) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3579EC0 Offset: 0x3579FC1 VA: 0x3579EC0
	|-UniTaskCompletionSource<ValueTuple<bool, ValueTuple<bool, AsyncUnit>>>.TrySetCanceled
	|
	|-RVA: 0x357A850 Offset: 0x357A951 VA: 0x357A850
	|-UniTaskCompletionSource<ValueTuple<bool, ValueTuple<bool, object>>>.TrySetCanceled
	|
	|-RVA: 0x357B1A0 Offset: 0x357B2A1 VA: 0x357B1A0
	|-UniTaskCompletionSource<ValueTuple<bool, AsyncUnit>>.TrySetCanceled
	|
	|-RVA: 0x357BB20 Offset: 0x357BC21 VA: 0x357BB20
	|-UniTaskCompletionSource<ValueTuple<bool, object>>.TrySetCanceled
	|
	|-RVA: 0x357C4A0 Offset: 0x357C5A1 VA: 0x357C4A0
	|-UniTaskCompletionSource<ValueTuple<int, object>>.TrySetCanceled
	|
	|-RVA: 0x357CE20 Offset: 0x357CF21 VA: 0x357CE20
	|-UniTaskCompletionSource<ValueTuple<object, object>>.TrySetCanceled
	|
	|-RVA: 0x357D7D0 Offset: 0x357D8D1 VA: 0x357D7D0
	|-UniTaskCompletionSource<ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>>>.TrySetCanceled
	|
	|-RVA: 0x357E170 Offset: 0x357E271 VA: 0x357E170
	|-UniTaskCompletionSource<ValueTuple<object, object, object>>.TrySetCanceled
	|
	|-RVA: 0x357EB40 Offset: 0x357EC41 VA: 0x357EB40
	|-UniTaskCompletionSource<ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>.TrySetCanceled
	|
	|-RVA: 0x357F4F0 Offset: 0x357F5F1 VA: 0x357F4F0
	|-UniTaskCompletionSource<ValueTuple<object, object, object, object>>.TrySetCanceled
	|
	|-RVA: 0x357FEE0 Offset: 0x357FFE1 VA: 0x357FEE0
	|-UniTaskCompletionSource<ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>.TrySetCanceled
	|
	|-RVA: 0x35808A0 Offset: 0x35809A1 VA: 0x35808A0
	|-UniTaskCompletionSource<ValueTuple<object, object, object, object, object>>.TrySetCanceled
	|
	|-RVA: 0x35812A0 Offset: 0x35813A1 VA: 0x35812A0
	|-UniTaskCompletionSource<ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>.TrySetCanceled
	|
	|-RVA: 0x3581C60 Offset: 0x3581D61 VA: 0x3581C60
	|-UniTaskCompletionSource<ValueTuple<object, object, object, object, object, object>>.TrySetCanceled
	|
	|-RVA: 0x3582680 Offset: 0x3582781 VA: 0x3582680
	|-UniTaskCompletionSource<ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>.TrySetCanceled
	|
	|-RVA: 0x3583050 Offset: 0x3583151 VA: 0x3583050
	|-UniTaskCompletionSource<ValueTuple<object, object, object, object, object, object, object>>.TrySetCanceled
	|
	|-RVA: 0x3583A80 Offset: 0x3583B81 VA: 0x3583A80
	|-UniTaskCompletionSource<ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<ValueTuple<bool, object>>>>.TrySetCanceled
	|
	|-RVA: 0x3584460 Offset: 0x3584561 VA: 0x3584460
	|-UniTaskCompletionSource<ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<ValueTuple<bool, object>, ValueTuple<bool, object>>>>.TrySetCanceled
	|
	|-RVA: 0x3584DB0 Offset: 0x3584EB1 VA: 0x3584DB0
	|-UniTaskCompletionSource<AsyncUnit>.TrySetCanceled
	|
	|-RVA: 0x3585700 Offset: 0x3585801 VA: 0x3585700
	|-UniTaskCompletionSource<bool>.TrySetCanceled
	|
	|-RVA: 0x3586040 Offset: 0x3586141 VA: 0x3586040
	|-UniTaskCompletionSource<int>.TrySetCanceled
	|
	|-RVA: 0x3586990 Offset: 0x3586A91 VA: 0x3586990
	|-UniTaskCompletionSource<object>.TrySetCanceled
	|
	|-RVA: 0x35872D0 Offset: 0x35873D1 VA: 0x35872D0
	|-UniTaskCompletionSource<float>.TrySetCanceled
	*/

	// RVA: -1 Offset: -1 Slot: 7
	private void UniRx.Async.IAwaiter.GetResult() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3579FA0 Offset: 0x357A0A1 VA: 0x3579FA0
	|-UniTaskCompletionSource<ValueTuple<bool, ValueTuple<bool, AsyncUnit>>>.UniRx.Async.IAwaiter.GetResult
	|
	|-RVA: 0x357A930 Offset: 0x357AA31 VA: 0x357A930
	|-UniTaskCompletionSource<ValueTuple<bool, ValueTuple<bool, object>>>.UniRx.Async.IAwaiter.GetResult
	|
	|-RVA: 0x357B280 Offset: 0x357B381 VA: 0x357B280
	|-UniTaskCompletionSource<ValueTuple<bool, AsyncUnit>>.UniRx.Async.IAwaiter.GetResult
	|
	|-RVA: 0x357BC00 Offset: 0x357BD01 VA: 0x357BC00
	|-UniTaskCompletionSource<ValueTuple<bool, object>>.UniRx.Async.IAwaiter.GetResult
	|
	|-RVA: 0x357C580 Offset: 0x357C681 VA: 0x357C580
	|-UniTaskCompletionSource<ValueTuple<int, object>>.UniRx.Async.IAwaiter.GetResult
	|
	|-RVA: 0x357CF00 Offset: 0x357D001 VA: 0x357CF00
	|-UniTaskCompletionSource<ValueTuple<object, object>>.UniRx.Async.IAwaiter.GetResult
	|
	|-RVA: 0x357D8B0 Offset: 0x357D9B1 VA: 0x357D8B0
	|-UniTaskCompletionSource<ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>>>.UniRx.Async.IAwaiter.GetResult
	|
	|-RVA: 0x357E250 Offset: 0x357E351 VA: 0x357E250
	|-UniTaskCompletionSource<ValueTuple<object, object, object>>.UniRx.Async.IAwaiter.GetResult
	|
	|-RVA: 0x357EC20 Offset: 0x357ED21 VA: 0x357EC20
	|-UniTaskCompletionSource<ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>.UniRx.Async.IAwaiter.GetResult
	|
	|-RVA: 0x357F5D0 Offset: 0x357F6D1 VA: 0x357F5D0
	|-UniTaskCompletionSource<ValueTuple<object, object, object, object>>.UniRx.Async.IAwaiter.GetResult
	|
	|-RVA: 0x357FFC0 Offset: 0x35800C1 VA: 0x357FFC0
	|-UniTaskCompletionSource<ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>.UniRx.Async.IAwaiter.GetResult
	|
	|-RVA: 0x3580980 Offset: 0x3580A81 VA: 0x3580980
	|-UniTaskCompletionSource<ValueTuple<object, object, object, object, object>>.UniRx.Async.IAwaiter.GetResult
	|
	|-RVA: 0x3581380 Offset: 0x3581481 VA: 0x3581380
	|-UniTaskCompletionSource<ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>.UniRx.Async.IAwaiter.GetResult
	|
	|-RVA: 0x3581D40 Offset: 0x3581E41 VA: 0x3581D40
	|-UniTaskCompletionSource<ValueTuple<object, object, object, object, object, object>>.UniRx.Async.IAwaiter.GetResult
	|
	|-RVA: 0x3582760 Offset: 0x3582861 VA: 0x3582760
	|-UniTaskCompletionSource<ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>.UniRx.Async.IAwaiter.GetResult
	|
	|-RVA: 0x3583130 Offset: 0x3583231 VA: 0x3583130
	|-UniTaskCompletionSource<ValueTuple<object, object, object, object, object, object, object>>.UniRx.Async.IAwaiter.GetResult
	|
	|-RVA: 0x3583B60 Offset: 0x3583C61 VA: 0x3583B60
	|-UniTaskCompletionSource<ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<ValueTuple<bool, object>>>>.UniRx.Async.IAwaiter.GetResult
	|
	|-RVA: 0x3584540 Offset: 0x3584641 VA: 0x3584540
	|-UniTaskCompletionSource<ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<ValueTuple<bool, object>, ValueTuple<bool, object>>>>.UniRx.Async.IAwaiter.GetResult
	|
	|-RVA: 0x3584E90 Offset: 0x3584F91 VA: 0x3584E90
	|-UniTaskCompletionSource<AsyncUnit>.UniRx.Async.IAwaiter.GetResult
	|
	|-RVA: 0x35857E0 Offset: 0x35858E1 VA: 0x35857E0
	|-UniTaskCompletionSource<bool>.UniRx.Async.IAwaiter.GetResult
	|
	|-RVA: 0x3586120 Offset: 0x3586221 VA: 0x3586120
	|-UniTaskCompletionSource<int>.UniRx.Async.IAwaiter.GetResult
	|
	|-RVA: 0x3586A70 Offset: 0x3586B71 VA: 0x3586A70
	|-UniTaskCompletionSource<object>.UniRx.Async.IAwaiter.GetResult
	|
	|-RVA: 0x35873B0 Offset: 0x35874B1 VA: 0x35873B0
	|-UniTaskCompletionSource<float>.UniRx.Async.IAwaiter.GetResult
	*/

	// RVA: -1 Offset: -1 Slot: 9
	private void System.Runtime.CompilerServices.INotifyCompletion.OnCompleted(Action continuation) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x357A030 Offset: 0x357A131 VA: 0x357A030
	|-UniTaskCompletionSource<ValueTuple<bool, ValueTuple<bool, AsyncUnit>>>.System.Runtime.CompilerServices.INotifyCompletion.OnCompleted
	|
	|-RVA: 0x357A9D0 Offset: 0x357AAD1 VA: 0x357A9D0
	|-UniTaskCompletionSource<ValueTuple<bool, ValueTuple<bool, object>>>.System.Runtime.CompilerServices.INotifyCompletion.OnCompleted
	|
	|-RVA: 0x357B310 Offset: 0x357B411 VA: 0x357B310
	|-UniTaskCompletionSource<ValueTuple<bool, AsyncUnit>>.System.Runtime.CompilerServices.INotifyCompletion.OnCompleted
	|
	|-RVA: 0x357BC90 Offset: 0x357BD91 VA: 0x357BC90
	|-UniTaskCompletionSource<ValueTuple<bool, object>>.System.Runtime.CompilerServices.INotifyCompletion.OnCompleted
	|
	|-RVA: 0x357C610 Offset: 0x357C711 VA: 0x357C610
	|-UniTaskCompletionSource<ValueTuple<int, object>>.System.Runtime.CompilerServices.INotifyCompletion.OnCompleted
	|
	|-RVA: 0x357CF90 Offset: 0x357D091 VA: 0x357CF90
	|-UniTaskCompletionSource<ValueTuple<object, object>>.System.Runtime.CompilerServices.INotifyCompletion.OnCompleted
	|
	|-RVA: 0x357D950 Offset: 0x357DA51 VA: 0x357D950
	|-UniTaskCompletionSource<ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>>>.System.Runtime.CompilerServices.INotifyCompletion.OnCompleted
	|
	|-RVA: 0x357E2F0 Offset: 0x357E3F1 VA: 0x357E2F0
	|-UniTaskCompletionSource<ValueTuple<object, object, object>>.System.Runtime.CompilerServices.INotifyCompletion.OnCompleted
	|
	|-RVA: 0x357ECC0 Offset: 0x357EDC1 VA: 0x357ECC0
	|-UniTaskCompletionSource<ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>.System.Runtime.CompilerServices.INotifyCompletion.OnCompleted
	|
	|-RVA: 0x357F670 Offset: 0x357F771 VA: 0x357F670
	|-UniTaskCompletionSource<ValueTuple<object, object, object, object>>.System.Runtime.CompilerServices.INotifyCompletion.OnCompleted
	|
	|-RVA: 0x3580060 Offset: 0x3580161 VA: 0x3580060
	|-UniTaskCompletionSource<ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>.System.Runtime.CompilerServices.INotifyCompletion.OnCompleted
	|
	|-RVA: 0x3580A20 Offset: 0x3580B21 VA: 0x3580A20
	|-UniTaskCompletionSource<ValueTuple<object, object, object, object, object>>.System.Runtime.CompilerServices.INotifyCompletion.OnCompleted
	|
	|-RVA: 0x3581420 Offset: 0x3581521 VA: 0x3581420
	|-UniTaskCompletionSource<ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>.System.Runtime.CompilerServices.INotifyCompletion.OnCompleted
	|
	|-RVA: 0x3581DE0 Offset: 0x3581EE1 VA: 0x3581DE0
	|-UniTaskCompletionSource<ValueTuple<object, object, object, object, object, object>>.System.Runtime.CompilerServices.INotifyCompletion.OnCompleted
	|
	|-RVA: 0x3582800 Offset: 0x3582901 VA: 0x3582800
	|-UniTaskCompletionSource<ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>.System.Runtime.CompilerServices.INotifyCompletion.OnCompleted
	|
	|-RVA: 0x35831D0 Offset: 0x35832D1 VA: 0x35831D0
	|-UniTaskCompletionSource<ValueTuple<object, object, object, object, object, object, object>>.System.Runtime.CompilerServices.INotifyCompletion.OnCompleted
	|
	|-RVA: 0x3583C00 Offset: 0x3583D01 VA: 0x3583C00
	|-UniTaskCompletionSource<ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<ValueTuple<bool, object>>>>.System.Runtime.CompilerServices.INotifyCompletion.OnCompleted
	|
	|-RVA: 0x35845E0 Offset: 0x35846E1 VA: 0x35845E0
	|-UniTaskCompletionSource<ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<ValueTuple<bool, object>, ValueTuple<bool, object>>>>.System.Runtime.CompilerServices.INotifyCompletion.OnCompleted
	|
	|-RVA: 0x3584F20 Offset: 0x3585021 VA: 0x3584F20
	|-UniTaskCompletionSource<AsyncUnit>.System.Runtime.CompilerServices.INotifyCompletion.OnCompleted
	|
	|-RVA: 0x3585870 Offset: 0x3585971 VA: 0x3585870
	|-UniTaskCompletionSource<bool>.System.Runtime.CompilerServices.INotifyCompletion.OnCompleted
	|
	|-RVA: 0x35861B0 Offset: 0x35862B1 VA: 0x35861B0
	|-UniTaskCompletionSource<int>.System.Runtime.CompilerServices.INotifyCompletion.OnCompleted
	|
	|-RVA: 0x3586B00 Offset: 0x3586C01 VA: 0x3586B00
	|-UniTaskCompletionSource<object>.System.Runtime.CompilerServices.INotifyCompletion.OnCompleted
	|
	|-RVA: 0x3587440 Offset: 0x3587541 VA: 0x3587440
	|-UniTaskCompletionSource<float>.System.Runtime.CompilerServices.INotifyCompletion.OnCompleted
	*/
}

