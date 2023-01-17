// Namespace: UniRx
internal class ReactivePropertyReusablePromise<T> : IAwaiter<T>, IAwaiter, ICriticalNotifyCompletion, INotifyCompletion, IResolvePromise<T> // TypeDefIndex: 6772
{
	// Fields
	private T result; // 0x0
	private object continuation; // 0x0
	private MinimumQueue<ValueTuple<int, T>> queueValues; // 0x0
	private bool running; // 0x0
	private int waitingContinuationCount; // 0x0
	private AwaiterStatus status; // 0x0
	internal readonly CancellationToken RegisteredCancelationToken; // 0x0

	// Properties
	public bool IsCompleted { get; }
	public UniTask<T> Task { get; }
	public AwaiterStatus Status { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 6
	public bool get_IsCompleted() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2A931B0 Offset: 0x2A932B1 VA: 0x2A931B0
	|-ReactivePropertyReusablePromise<bool>.get_IsCompleted
	|
	|-RVA: 0x2A93980 Offset: 0x2A93A81 VA: 0x2A93980
	|-ReactivePropertyReusablePromise<Bounds>.get_IsCompleted
	|
	|-RVA: 0x2A94210 Offset: 0x2A94311 VA: 0x2A94210
	|-ReactivePropertyReusablePromise<byte>.get_IsCompleted
	|
	|-RVA: 0x2A949E0 Offset: 0x2A94AE1 VA: 0x2A949E0
	|-ReactivePropertyReusablePromise<Color>.get_IsCompleted
	|
	|-RVA: 0x2A95210 Offset: 0x2A95311 VA: 0x2A95210
	|-ReactivePropertyReusablePromise<double>.get_IsCompleted
	|
	|-RVA: 0x2A959E0 Offset: 0x2A95AE1 VA: 0x2A959E0
	|-ReactivePropertyReusablePromise<int>.get_IsCompleted
	|
	|-RVA: 0x2A961B0 Offset: 0x2A962B1 VA: 0x2A961B0
	|-ReactivePropertyReusablePromise<long>.get_IsCompleted
	|
	|-RVA: 0x34512D0 Offset: 0x34513D1 VA: 0x34512D0
	|-ReactivePropertyReusablePromise<object>.get_IsCompleted
	|
	|-RVA: 0x3451AC0 Offset: 0x3451BC1 VA: 0x3451AC0
	|-ReactivePropertyReusablePromise<Quaternion>.get_IsCompleted
	|
	|-RVA: 0x34522F0 Offset: 0x34523F1 VA: 0x34522F0
	|-ReactivePropertyReusablePromise<Rect>.get_IsCompleted
	|
	|-RVA: 0x3452B20 Offset: 0x3452C21 VA: 0x3452B20
	|-ReactivePropertyReusablePromise<float>.get_IsCompleted
	|
	|-RVA: 0x34532F0 Offset: 0x34533F1 VA: 0x34532F0
	|-ReactivePropertyReusablePromise<Unit>.get_IsCompleted
	|
	|-RVA: 0x3453AC0 Offset: 0x3453BC1 VA: 0x3453AC0
	|-ReactivePropertyReusablePromise<Vector2>.get_IsCompleted
	|
	|-RVA: 0x34542A0 Offset: 0x34543A1 VA: 0x34542A0
	|-ReactivePropertyReusablePromise<Vector3>.get_IsCompleted
	|
	|-RVA: 0x3454AC0 Offset: 0x3454BC1 VA: 0x3454AC0
	|-ReactivePropertyReusablePromise<Vector4>.get_IsCompleted
	*/

	// RVA: -1 Offset: -1
	public UniTask<T> get_Task() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2A931C0 Offset: 0x2A932C1 VA: 0x2A931C0
	|-ReactivePropertyReusablePromise<bool>.get_Task
	|
	|-RVA: 0x2A93990 Offset: 0x2A93A91 VA: 0x2A93990
	|-ReactivePropertyReusablePromise<Bounds>.get_Task
	|
	|-RVA: 0x2A94220 Offset: 0x2A94321 VA: 0x2A94220
	|-ReactivePropertyReusablePromise<byte>.get_Task
	|
	|-RVA: 0x2A949F0 Offset: 0x2A94AF1 VA: 0x2A949F0
	|-ReactivePropertyReusablePromise<Color>.get_Task
	|
	|-RVA: 0x2A95220 Offset: 0x2A95321 VA: 0x2A95220
	|-ReactivePropertyReusablePromise<double>.get_Task
	|
	|-RVA: 0x2A959F0 Offset: 0x2A95AF1 VA: 0x2A959F0
	|-ReactivePropertyReusablePromise<int>.get_Task
	|
	|-RVA: 0x2A961C0 Offset: 0x2A962C1 VA: 0x2A961C0
	|-ReactivePropertyReusablePromise<long>.get_Task
	|
	|-RVA: 0x34512E0 Offset: 0x34513E1 VA: 0x34512E0
	|-ReactivePropertyReusablePromise<object>.get_Task
	|
	|-RVA: 0x3451AD0 Offset: 0x3451BD1 VA: 0x3451AD0
	|-ReactivePropertyReusablePromise<Quaternion>.get_Task
	|
	|-RVA: 0x3452300 Offset: 0x3452401 VA: 0x3452300
	|-ReactivePropertyReusablePromise<Rect>.get_Task
	|
	|-RVA: 0x3452B30 Offset: 0x3452C31 VA: 0x3452B30
	|-ReactivePropertyReusablePromise<float>.get_Task
	|
	|-RVA: 0x3453300 Offset: 0x3453401 VA: 0x3453300
	|-ReactivePropertyReusablePromise<Unit>.get_Task
	|
	|-RVA: 0x3453AD0 Offset: 0x3453BD1 VA: 0x3453AD0
	|-ReactivePropertyReusablePromise<Vector2>.get_Task
	|
	|-RVA: 0x34542B0 Offset: 0x34543B1 VA: 0x34542B0
	|-ReactivePropertyReusablePromise<Vector3>.get_Task
	|
	|-RVA: 0x3454AD0 Offset: 0x3454BD1 VA: 0x3454AD0
	|-ReactivePropertyReusablePromise<Vector4>.get_Task
	*/

	// RVA: -1 Offset: -1 Slot: 5
	public AwaiterStatus get_Status() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2A93200 Offset: 0x2A93301 VA: 0x2A93200
	|-ReactivePropertyReusablePromise<bool>.get_Status
	|
	|-RVA: 0x2A939F0 Offset: 0x2A93AF1 VA: 0x2A939F0
	|-ReactivePropertyReusablePromise<Bounds>.get_Status
	|
	|-RVA: 0x2A94260 Offset: 0x2A94361 VA: 0x2A94260
	|-ReactivePropertyReusablePromise<byte>.get_Status
	|
	|-RVA: 0x2A94A50 Offset: 0x2A94B51 VA: 0x2A94A50
	|-ReactivePropertyReusablePromise<Color>.get_Status
	|
	|-RVA: 0x2A95260 Offset: 0x2A95361 VA: 0x2A95260
	|-ReactivePropertyReusablePromise<double>.get_Status
	|
	|-RVA: 0x2A95A30 Offset: 0x2A95B31 VA: 0x2A95A30
	|-ReactivePropertyReusablePromise<int>.get_Status
	|
	|-RVA: 0x2A96200 Offset: 0x2A96301 VA: 0x2A96200
	|-ReactivePropertyReusablePromise<long>.get_Status
	|
	|-RVA: 0x3451320 Offset: 0x3451421 VA: 0x3451320
	|-ReactivePropertyReusablePromise<object>.get_Status
	|
	|-RVA: 0x3451B30 Offset: 0x3451C31 VA: 0x3451B30
	|-ReactivePropertyReusablePromise<Quaternion>.get_Status
	|
	|-RVA: 0x3452360 Offset: 0x3452461 VA: 0x3452360
	|-ReactivePropertyReusablePromise<Rect>.get_Status
	|
	|-RVA: 0x3452B70 Offset: 0x3452C71 VA: 0x3452B70
	|-ReactivePropertyReusablePromise<float>.get_Status
	|
	|-RVA: 0x3453340 Offset: 0x3453441 VA: 0x3453340
	|-ReactivePropertyReusablePromise<Unit>.get_Status
	|
	|-RVA: 0x3453B10 Offset: 0x3453C11 VA: 0x3453B10
	|-ReactivePropertyReusablePromise<Vector2>.get_Status
	|
	|-RVA: 0x3454310 Offset: 0x3454411 VA: 0x3454310
	|-ReactivePropertyReusablePromise<Vector3>.get_Status
	|
	|-RVA: 0x3454B30 Offset: 0x3454C31 VA: 0x3454B30
	|-ReactivePropertyReusablePromise<Vector4>.get_Status
	*/

	// RVA: -1 Offset: -1
	public void .ctor(CancellationToken cancellationToken) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2A93210 Offset: 0x2A93311 VA: 0x2A93210
	|-ReactivePropertyReusablePromise<bool>..ctor
	|
	|-RVA: 0x2A93A00 Offset: 0x2A93B01 VA: 0x2A93A00
	|-ReactivePropertyReusablePromise<Bounds>..ctor
	|
	|-RVA: 0x2A94270 Offset: 0x2A94371 VA: 0x2A94270
	|-ReactivePropertyReusablePromise<byte>..ctor
	|
	|-RVA: 0x2A94A60 Offset: 0x2A94B61 VA: 0x2A94A60
	|-ReactivePropertyReusablePromise<Color>..ctor
	|
	|-RVA: 0x2A95270 Offset: 0x2A95371 VA: 0x2A95270
	|-ReactivePropertyReusablePromise<double>..ctor
	|
	|-RVA: 0x2A95A40 Offset: 0x2A95B41 VA: 0x2A95A40
	|-ReactivePropertyReusablePromise<int>..ctor
	|
	|-RVA: 0x2A96210 Offset: 0x2A96311 VA: 0x2A96210
	|-ReactivePropertyReusablePromise<long>..ctor
	|
	|-RVA: 0x3451330 Offset: 0x3451431 VA: 0x3451330
	|-ReactivePropertyReusablePromise<object>..ctor
	|
	|-RVA: 0x3451B40 Offset: 0x3451C41 VA: 0x3451B40
	|-ReactivePropertyReusablePromise<Quaternion>..ctor
	|
	|-RVA: 0x3452370 Offset: 0x3452471 VA: 0x3452370
	|-ReactivePropertyReusablePromise<Rect>..ctor
	|
	|-RVA: 0x3452B80 Offset: 0x3452C81 VA: 0x3452B80
	|-ReactivePropertyReusablePromise<float>..ctor
	|
	|-RVA: 0x3453350 Offset: 0x3453451 VA: 0x3453350
	|-ReactivePropertyReusablePromise<Unit>..ctor
	|
	|-RVA: 0x3453B20 Offset: 0x3453C21 VA: 0x3453B20
	|-ReactivePropertyReusablePromise<Vector2>..ctor
	|
	|-RVA: 0x3454320 Offset: 0x3454421 VA: 0x3454320
	|-ReactivePropertyReusablePromise<Vector3>..ctor
	|
	|-RVA: 0x3454B40 Offset: 0x3454C41 VA: 0x3454B40
	|-ReactivePropertyReusablePromise<Vector4>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public T GetResult() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2A93250 Offset: 0x2A93351 VA: 0x2A93250
	|-ReactivePropertyReusablePromise<bool>.GetResult
	|
	|-RVA: 0x2A93A40 Offset: 0x2A93B41 VA: 0x2A93A40
	|-ReactivePropertyReusablePromise<Bounds>.GetResult
	|
	|-RVA: 0x2A942B0 Offset: 0x2A943B1 VA: 0x2A942B0
	|-ReactivePropertyReusablePromise<byte>.GetResult
	|
	|-RVA: 0x2A94AA0 Offset: 0x2A94BA1 VA: 0x2A94AA0
	|-ReactivePropertyReusablePromise<Color>.GetResult
	|
	|-RVA: 0x2A952B0 Offset: 0x2A953B1 VA: 0x2A952B0
	|-ReactivePropertyReusablePromise<double>.GetResult
	|
	|-RVA: 0x2A95A80 Offset: 0x2A95B81 VA: 0x2A95A80
	|-ReactivePropertyReusablePromise<int>.GetResult
	|
	|-RVA: 0x2A96250 Offset: 0x2A96351 VA: 0x2A96250
	|-ReactivePropertyReusablePromise<long>.GetResult
	|
	|-RVA: 0x3451370 Offset: 0x3451471 VA: 0x3451370
	|-ReactivePropertyReusablePromise<object>.GetResult
	|
	|-RVA: 0x3451B80 Offset: 0x3451C81 VA: 0x3451B80
	|-ReactivePropertyReusablePromise<Quaternion>.GetResult
	|
	|-RVA: 0x34523B0 Offset: 0x34524B1 VA: 0x34523B0
	|-ReactivePropertyReusablePromise<Rect>.GetResult
	|
	|-RVA: 0x3452BC0 Offset: 0x3452CC1 VA: 0x3452BC0
	|-ReactivePropertyReusablePromise<float>.GetResult
	|
	|-RVA: 0x3453390 Offset: 0x3453491 VA: 0x3453390
	|-ReactivePropertyReusablePromise<Unit>.GetResult
	|
	|-RVA: 0x3453B60 Offset: 0x3453C61 VA: 0x3453B60
	|-ReactivePropertyReusablePromise<Vector2>.GetResult
	|
	|-RVA: 0x3454360 Offset: 0x3454461 VA: 0x3454360
	|-ReactivePropertyReusablePromise<Vector3>.GetResult
	|
	|-RVA: 0x3454B80 Offset: 0x3454C81 VA: 0x3454B80
	|-ReactivePropertyReusablePromise<Vector4>.GetResult
	*/

	// RVA: -1 Offset: -1 Slot: 7
	private void UniRx.Async.IAwaiter.GetResult() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2A932B0 Offset: 0x2A933B1 VA: 0x2A932B0
	|-ReactivePropertyReusablePromise<bool>.UniRx.Async.IAwaiter.GetResult
	|
	|-RVA: 0x2A93AB0 Offset: 0x2A93BB1 VA: 0x2A93AB0
	|-ReactivePropertyReusablePromise<Bounds>.UniRx.Async.IAwaiter.GetResult
	|
	|-RVA: 0x2A94310 Offset: 0x2A94411 VA: 0x2A94310
	|-ReactivePropertyReusablePromise<byte>.UniRx.Async.IAwaiter.GetResult
	|
	|-RVA: 0x2A94B00 Offset: 0x2A94C01 VA: 0x2A94B00
	|-ReactivePropertyReusablePromise<Color>.UniRx.Async.IAwaiter.GetResult
	|
	|-RVA: 0x2A95310 Offset: 0x2A95411 VA: 0x2A95310
	|-ReactivePropertyReusablePromise<double>.UniRx.Async.IAwaiter.GetResult
	|
	|-RVA: 0x2A95AE0 Offset: 0x2A95BE1 VA: 0x2A95AE0
	|-ReactivePropertyReusablePromise<int>.UniRx.Async.IAwaiter.GetResult
	|
	|-RVA: 0x2A962B0 Offset: 0x2A963B1 VA: 0x2A962B0
	|-ReactivePropertyReusablePromise<long>.UniRx.Async.IAwaiter.GetResult
	|
	|-RVA: 0x34513D0 Offset: 0x34514D1 VA: 0x34513D0
	|-ReactivePropertyReusablePromise<object>.UniRx.Async.IAwaiter.GetResult
	|
	|-RVA: 0x3451BE0 Offset: 0x3451CE1 VA: 0x3451BE0
	|-ReactivePropertyReusablePromise<Quaternion>.UniRx.Async.IAwaiter.GetResult
	|
	|-RVA: 0x3452410 Offset: 0x3452511 VA: 0x3452410
	|-ReactivePropertyReusablePromise<Rect>.UniRx.Async.IAwaiter.GetResult
	|
	|-RVA: 0x3452C20 Offset: 0x3452D21 VA: 0x3452C20
	|-ReactivePropertyReusablePromise<float>.UniRx.Async.IAwaiter.GetResult
	|
	|-RVA: 0x34533F0 Offset: 0x34534F1 VA: 0x34533F0
	|-ReactivePropertyReusablePromise<Unit>.UniRx.Async.IAwaiter.GetResult
	|
	|-RVA: 0x3453BC0 Offset: 0x3453CC1 VA: 0x3453BC0
	|-ReactivePropertyReusablePromise<Vector2>.UniRx.Async.IAwaiter.GetResult
	|
	|-RVA: 0x34543C0 Offset: 0x34544C1 VA: 0x34543C0
	|-ReactivePropertyReusablePromise<Vector3>.UniRx.Async.IAwaiter.GetResult
	|
	|-RVA: 0x3454BE0 Offset: 0x3454CE1 VA: 0x3454BE0
	|-ReactivePropertyReusablePromise<Vector4>.UniRx.Async.IAwaiter.GetResult
	*/

	// RVA: -1 Offset: -1
	public void SetCanceled() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2A932D0 Offset: 0x2A933D1 VA: 0x2A932D0
	|-ReactivePropertyReusablePromise<bool>.SetCanceled
	|
	|-RVA: 0x2A93AE0 Offset: 0x2A93BE1 VA: 0x2A93AE0
	|-ReactivePropertyReusablePromise<Bounds>.SetCanceled
	|
	|-RVA: 0x2A94330 Offset: 0x2A94431 VA: 0x2A94330
	|-ReactivePropertyReusablePromise<byte>.SetCanceled
	|
	|-RVA: 0x2A94B20 Offset: 0x2A94C21 VA: 0x2A94B20
	|-ReactivePropertyReusablePromise<Color>.SetCanceled
	|
	|-RVA: 0x2A95330 Offset: 0x2A95431 VA: 0x2A95330
	|-ReactivePropertyReusablePromise<double>.SetCanceled
	|
	|-RVA: 0x2A95B00 Offset: 0x2A95C01 VA: 0x2A95B00
	|-ReactivePropertyReusablePromise<int>.SetCanceled
	|
	|-RVA: 0x2A962D0 Offset: 0x2A963D1 VA: 0x2A962D0
	|-ReactivePropertyReusablePromise<long>.SetCanceled
	|
	|-RVA: 0x34513F0 Offset: 0x34514F1 VA: 0x34513F0
	|-ReactivePropertyReusablePromise<object>.SetCanceled
	|
	|-RVA: 0x3451C00 Offset: 0x3451D01 VA: 0x3451C00
	|-ReactivePropertyReusablePromise<Quaternion>.SetCanceled
	|
	|-RVA: 0x3452430 Offset: 0x3452531 VA: 0x3452430
	|-ReactivePropertyReusablePromise<Rect>.SetCanceled
	|
	|-RVA: 0x3452C40 Offset: 0x3452D41 VA: 0x3452C40
	|-ReactivePropertyReusablePromise<float>.SetCanceled
	|
	|-RVA: 0x3453410 Offset: 0x3453511 VA: 0x3453410
	|-ReactivePropertyReusablePromise<Unit>.SetCanceled
	|
	|-RVA: 0x3453BE0 Offset: 0x3453CE1 VA: 0x3453BE0
	|-ReactivePropertyReusablePromise<Vector2>.SetCanceled
	|
	|-RVA: 0x34543E0 Offset: 0x34544E1 VA: 0x34543E0
	|-ReactivePropertyReusablePromise<Vector3>.SetCanceled
	|
	|-RVA: 0x3454C00 Offset: 0x3454D01 VA: 0x3454C00
	|-ReactivePropertyReusablePromise<Vector4>.SetCanceled
	*/

	// RVA: -1 Offset: -1
	public void InvokeContinuation(ref T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2A93330 Offset: 0x2A93431 VA: 0x2A93330
	|-ReactivePropertyReusablePromise<bool>.InvokeContinuation
	|
	|-RVA: 0x2A93B50 Offset: 0x2A93C51 VA: 0x2A93B50
	|-ReactivePropertyReusablePromise<Bounds>.InvokeContinuation
	|
	|-RVA: 0x2A94390 Offset: 0x2A94491 VA: 0x2A94390
	|-ReactivePropertyReusablePromise<byte>.InvokeContinuation
	|
	|-RVA: 0x2A94B90 Offset: 0x2A94C91 VA: 0x2A94B90
	|-ReactivePropertyReusablePromise<Color>.InvokeContinuation
	|
	|-RVA: 0x2A95390 Offset: 0x2A95491 VA: 0x2A95390
	|-ReactivePropertyReusablePromise<double>.InvokeContinuation
	|
	|-RVA: 0x2A95B60 Offset: 0x2A95C61 VA: 0x2A95B60
	|-ReactivePropertyReusablePromise<int>.InvokeContinuation
	|
	|-RVA: 0x2A96330 Offset: 0x2A96431 VA: 0x2A96330
	|-ReactivePropertyReusablePromise<long>.InvokeContinuation
	|
	|-RVA: 0x3451450 Offset: 0x3451551 VA: 0x3451450
	|-ReactivePropertyReusablePromise<object>.InvokeContinuation
	|
	|-RVA: 0x3451C70 Offset: 0x3451D71 VA: 0x3451C70
	|-ReactivePropertyReusablePromise<Quaternion>.InvokeContinuation
	|
	|-RVA: 0x34524A0 Offset: 0x34525A1 VA: 0x34524A0
	|-ReactivePropertyReusablePromise<Rect>.InvokeContinuation
	|
	|-RVA: 0x3452CA0 Offset: 0x3452DA1 VA: 0x3452CA0
	|-ReactivePropertyReusablePromise<float>.InvokeContinuation
	|
	|-RVA: 0x3453470 Offset: 0x3453571 VA: 0x3453470
	|-ReactivePropertyReusablePromise<Unit>.InvokeContinuation
	|
	|-RVA: 0x3453C40 Offset: 0x3453D41 VA: 0x3453C40
	|-ReactivePropertyReusablePromise<Vector2>.InvokeContinuation
	|
	|-RVA: 0x3454450 Offset: 0x3454551 VA: 0x3454450
	|-ReactivePropertyReusablePromise<Vector3>.InvokeContinuation
	|
	|-RVA: 0x3454C70 Offset: 0x3454D71 VA: 0x3454C70
	|-ReactivePropertyReusablePromise<Vector4>.InvokeContinuation
	*/

	// RVA: -1 Offset: -1 Slot: 9
	public void OnCompleted(Action continuation) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2A93640 Offset: 0x2A93741 VA: 0x2A93640
	|-ReactivePropertyReusablePromise<bool>.OnCompleted
	|
	|-RVA: 0x2A93EE0 Offset: 0x2A93FE1 VA: 0x2A93EE0
	|-ReactivePropertyReusablePromise<Bounds>.OnCompleted
	|
	|-RVA: 0x2A946A0 Offset: 0x2A947A1 VA: 0x2A946A0
	|-ReactivePropertyReusablePromise<byte>.OnCompleted
	|
	|-RVA: 0x2A94ED0 Offset: 0x2A94FD1 VA: 0x2A94ED0
	|-ReactivePropertyReusablePromise<Color>.OnCompleted
	|
	|-RVA: 0x2A956A0 Offset: 0x2A957A1 VA: 0x2A956A0
	|-ReactivePropertyReusablePromise<double>.OnCompleted
	|
	|-RVA: 0x2A95E70 Offset: 0x2A95F71 VA: 0x2A95E70
	|-ReactivePropertyReusablePromise<int>.OnCompleted
	|
	|-RVA: 0x2A96640 Offset: 0x2A96741 VA: 0x2A96640
	|-ReactivePropertyReusablePromise<long>.OnCompleted
	|
	|-RVA: 0x3451780 Offset: 0x3451881 VA: 0x3451780
	|-ReactivePropertyReusablePromise<object>.OnCompleted
	|
	|-RVA: 0x3451FB0 Offset: 0x34520B1 VA: 0x3451FB0
	|-ReactivePropertyReusablePromise<Quaternion>.OnCompleted
	|
	|-RVA: 0x34527E0 Offset: 0x34528E1 VA: 0x34527E0
	|-ReactivePropertyReusablePromise<Rect>.OnCompleted
	|
	|-RVA: 0x3452FB0 Offset: 0x34530B1 VA: 0x3452FB0
	|-ReactivePropertyReusablePromise<float>.OnCompleted
	|
	|-RVA: 0x3453780 Offset: 0x3453881 VA: 0x3453780
	|-ReactivePropertyReusablePromise<Unit>.OnCompleted
	|
	|-RVA: 0x3453F60 Offset: 0x3454061 VA: 0x3453F60
	|-ReactivePropertyReusablePromise<Vector2>.OnCompleted
	|
	|-RVA: 0x3454780 Offset: 0x3454881 VA: 0x3454780
	|-ReactivePropertyReusablePromise<Vector3>.OnCompleted
	|
	|-RVA: 0x3454FB0 Offset: 0x34550B1 VA: 0x3454FB0
	|-ReactivePropertyReusablePromise<Vector4>.OnCompleted
	*/

	// RVA: -1 Offset: -1 Slot: 8
	public void UnsafeOnCompleted(Action action) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2A93660 Offset: 0x2A93761 VA: 0x2A93660
	|-ReactivePropertyReusablePromise<bool>.UnsafeOnCompleted
	|
	|-RVA: 0x2A93F00 Offset: 0x2A94001 VA: 0x2A93F00
	|-ReactivePropertyReusablePromise<Bounds>.UnsafeOnCompleted
	|
	|-RVA: 0x2A946C0 Offset: 0x2A947C1 VA: 0x2A946C0
	|-ReactivePropertyReusablePromise<byte>.UnsafeOnCompleted
	|
	|-RVA: 0x2A94EF0 Offset: 0x2A94FF1 VA: 0x2A94EF0
	|-ReactivePropertyReusablePromise<Color>.UnsafeOnCompleted
	|
	|-RVA: 0x2A956C0 Offset: 0x2A957C1 VA: 0x2A956C0
	|-ReactivePropertyReusablePromise<double>.UnsafeOnCompleted
	|
	|-RVA: 0x2A95E90 Offset: 0x2A95F91 VA: 0x2A95E90
	|-ReactivePropertyReusablePromise<int>.UnsafeOnCompleted
	|
	|-RVA: 0x2A96660 Offset: 0x2A96761 VA: 0x2A96660
	|-ReactivePropertyReusablePromise<long>.UnsafeOnCompleted
	|
	|-RVA: 0x34517A0 Offset: 0x34518A1 VA: 0x34517A0
	|-ReactivePropertyReusablePromise<object>.UnsafeOnCompleted
	|
	|-RVA: 0x3451FD0 Offset: 0x34520D1 VA: 0x3451FD0
	|-ReactivePropertyReusablePromise<Quaternion>.UnsafeOnCompleted
	|
	|-RVA: 0x3452800 Offset: 0x3452901 VA: 0x3452800
	|-ReactivePropertyReusablePromise<Rect>.UnsafeOnCompleted
	|
	|-RVA: 0x3452FD0 Offset: 0x34530D1 VA: 0x3452FD0
	|-ReactivePropertyReusablePromise<float>.UnsafeOnCompleted
	|
	|-RVA: 0x34537A0 Offset: 0x34538A1 VA: 0x34537A0
	|-ReactivePropertyReusablePromise<Unit>.UnsafeOnCompleted
	|
	|-RVA: 0x3453F80 Offset: 0x3454081 VA: 0x3453F80
	|-ReactivePropertyReusablePromise<Vector2>.UnsafeOnCompleted
	|
	|-RVA: 0x34547A0 Offset: 0x34548A1 VA: 0x34547A0
	|-ReactivePropertyReusablePromise<Vector3>.UnsafeOnCompleted
	|
	|-RVA: 0x3454FD0 Offset: 0x34550D1 VA: 0x3454FD0
	|-ReactivePropertyReusablePromise<Vector4>.UnsafeOnCompleted
	*/

	// RVA: -1 Offset: -1 Slot: 10
	private bool UniRx.Async.IResolvePromise<T>.TrySetResult(T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2A93940 Offset: 0x2A93A41 VA: 0x2A93940
	|-ReactivePropertyReusablePromise<bool>.UniRx.Async.IResolvePromise<T>.TrySetResult
	|
	|-RVA: 0x2A941E0 Offset: 0x2A942E1 VA: 0x2A941E0
	|-ReactivePropertyReusablePromise<Bounds>.UniRx.Async.IResolvePromise<T>.TrySetResult
	|
	|-RVA: 0x2A949A0 Offset: 0x2A94AA1 VA: 0x2A949A0
	|-ReactivePropertyReusablePromise<byte>.UniRx.Async.IResolvePromise<T>.TrySetResult
	|
	|-RVA: 0x2A951D0 Offset: 0x2A952D1 VA: 0x2A951D0
	|-ReactivePropertyReusablePromise<Color>.UniRx.Async.IResolvePromise<T>.TrySetResult
	|
	|-RVA: 0x2A959A0 Offset: 0x2A95AA1 VA: 0x2A959A0
	|-ReactivePropertyReusablePromise<double>.UniRx.Async.IResolvePromise<T>.TrySetResult
	|
	|-RVA: 0x2A96170 Offset: 0x2A96271 VA: 0x2A96170
	|-ReactivePropertyReusablePromise<int>.UniRx.Async.IResolvePromise<T>.TrySetResult
	|
	|-RVA: 0x2A96940 Offset: 0x2A96A41 VA: 0x2A96940
	|-ReactivePropertyReusablePromise<long>.UniRx.Async.IResolvePromise<T>.TrySetResult
	|
	|-RVA: 0x3451A80 Offset: 0x3451B81 VA: 0x3451A80
	|-ReactivePropertyReusablePromise<object>.UniRx.Async.IResolvePromise<T>.TrySetResult
	|
	|-RVA: 0x34522B0 Offset: 0x34523B1 VA: 0x34522B0
	|-ReactivePropertyReusablePromise<Quaternion>.UniRx.Async.IResolvePromise<T>.TrySetResult
	|
	|-RVA: 0x3452AE0 Offset: 0x3452BE1 VA: 0x3452AE0
	|-ReactivePropertyReusablePromise<Rect>.UniRx.Async.IResolvePromise<T>.TrySetResult
	|
	|-RVA: 0x34532B0 Offset: 0x34533B1 VA: 0x34532B0
	|-ReactivePropertyReusablePromise<float>.UniRx.Async.IResolvePromise<T>.TrySetResult
	|
	|-RVA: 0x3453A80 Offset: 0x3453B81 VA: 0x3453A80
	|-ReactivePropertyReusablePromise<Unit>.UniRx.Async.IResolvePromise<T>.TrySetResult
	|
	|-RVA: 0x3454260 Offset: 0x3454361 VA: 0x3454260
	|-ReactivePropertyReusablePromise<Vector2>.UniRx.Async.IResolvePromise<T>.TrySetResult
	|
	|-RVA: 0x3454A80 Offset: 0x3454B81 VA: 0x3454A80
	|-ReactivePropertyReusablePromise<Vector3>.UniRx.Async.IResolvePromise<T>.TrySetResult
	|
	|-RVA: 0x34552B0 Offset: 0x34553B1 VA: 0x34552B0
	|-ReactivePropertyReusablePromise<Vector4>.UniRx.Async.IResolvePromise<T>.TrySetResult
	*/
}

