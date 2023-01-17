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

