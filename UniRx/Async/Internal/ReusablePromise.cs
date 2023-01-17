// Namespace: UniRx.Async.Internal
public abstract class ReusablePromise : IAwaiter, ICriticalNotifyCompletion, INotifyCompletion // TypeDefIndex: 5218
{
	// Fields
	private ExceptionDispatchInfo exception; // 0x10
	private object continuation; // 0x18
	private AwaiterStatus status; // 0x20

	// Properties
	public UniTask Task { get; }
	public virtual bool IsCompleted { get; }
	public AwaiterStatus Status { get; }

	// Methods

	// RVA: 0x2E85200 Offset: 0x2E85301 VA: 0x2E85200
	public UniTask get_Task() { }

	// RVA: 0x2E85230 Offset: 0x2E85331 VA: 0x2E85230 Slot: 9
	public virtual bool get_IsCompleted() { }

	// RVA: 0x2E85240 Offset: 0x2E85341 VA: 0x2E85240 Slot: 10
	public virtual void GetResult() { }

	// RVA: 0x2E85350 Offset: 0x2E85451 VA: 0x2E85350 Slot: 4
	public AwaiterStatus get_Status() { }

	// RVA: 0x2E85360 Offset: 0x2E85461 VA: 0x2E85360 Slot: 6
	private void UniRx.Async.IAwaiter.GetResult() { }

	// RVA: 0x2E847B0 Offset: 0x2E848B1 VA: 0x2E847B0
	public void ResetStatus(bool forceReset) { }

	// RVA: 0x2E85370 Offset: 0x2E85471 VA: 0x2E85370 Slot: 11
	public virtual bool TrySetCanceled() { }

	// RVA: 0x2E85560 Offset: 0x2E85661 VA: 0x2E85560 Slot: 12
	public virtual bool TrySetException(Exception ex) { }

	// RVA: 0x2E855D0 Offset: 0x2E856D1 VA: 0x2E855D0 Slot: 13
	public virtual bool TrySetResult() { }

	// RVA: 0x2E853B0 Offset: 0x2E854B1 VA: 0x2E853B0
	private void TryInvokeContinuation() { }

	// RVA: 0x2E85620 Offset: 0x2E85721 VA: 0x2E85620 Slot: 8
	public void OnCompleted(Action action) { }

	// RVA: 0x2E85630 Offset: 0x2E85731 VA: 0x2E85630 Slot: 7
	public void UnsafeOnCompleted(Action action) { }

	// RVA: 0x2E846C0 Offset: 0x2E847C1 VA: 0x2E846C0
	protected void .ctor() { }
}

