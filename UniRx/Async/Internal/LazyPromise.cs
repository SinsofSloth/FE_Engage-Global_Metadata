// Namespace: UniRx.Async.Internal
internal sealed class LazyPromise : IAwaiter, ICriticalNotifyCompletion, INotifyCompletion // TypeDefIndex: 5212
{
	// Fields
	private Func<UniTask> factory; // 0x10
	private UniTask value; // 0x18

	// Properties
	public bool IsCompleted { get; }
	public AwaiterStatus Status { get; }

	// Methods

	// RVA: 0x2E827A0 Offset: 0x2E828A1 VA: 0x2E827A0
	public void .ctor(Func<UniTask> factory) { }

	// RVA: 0x2E827E0 Offset: 0x2E828E1 VA: 0x2E827E0
	private void Create() { }

	// RVA: 0x2E82860 Offset: 0x2E82961 VA: 0x2E82860 Slot: 5
	public bool get_IsCompleted() { }

	// RVA: 0x2E82A30 Offset: 0x2E82B31 VA: 0x2E82A30 Slot: 4
	public AwaiterStatus get_Status() { }

	// RVA: 0x2E82BF0 Offset: 0x2E82CF1 VA: 0x2E82BF0
	public void GetResult() { }

	// RVA: 0x2E82DB0 Offset: 0x2E82EB1 VA: 0x2E82DB0 Slot: 6
	private void UniRx.Async.IAwaiter.GetResult() { }

	// RVA: 0x2E82DC0 Offset: 0x2E82EC1 VA: 0x2E82DC0 Slot: 7
	public void UnsafeOnCompleted(Action continuation) { }

	// RVA: 0x2E82EB0 Offset: 0x2E82FB1 VA: 0x2E82EB0 Slot: 8
	public void OnCompleted(Action continuation) { }
}

