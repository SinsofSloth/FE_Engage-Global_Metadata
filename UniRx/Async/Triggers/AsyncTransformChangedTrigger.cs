// Namespace: UniRx.Async.Triggers
[DisallowMultipleComponent] // RVA: 0x28430 Offset: 0x28531 VA: 0x28430
public class AsyncTransformChangedTrigger : AsyncTriggerBase // TypeDefIndex: 5186
{
	// Fields
	private AsyncTriggerPromise<AsyncUnit> onBeforeTransformParentChanged; // 0x30
	private AsyncTriggerPromiseDictionary<AsyncUnit> onBeforeTransformParentChangeds; // 0x38
	private AsyncTriggerPromise<AsyncUnit> onTransformParentChanged; // 0x40
	private AsyncTriggerPromiseDictionary<AsyncUnit> onTransformParentChangeds; // 0x48
	private AsyncTriggerPromise<AsyncUnit> onTransformChildrenChanged; // 0x50
	private AsyncTriggerPromiseDictionary<AsyncUnit> onTransformChildrenChangeds; // 0x58

	// Methods

	// RVA: 0x2E79950 Offset: 0x2E79A51 VA: 0x2E79950 Slot: 4
	protected override IEnumerable<ICancelablePromise> GetPromises() { }

	// RVA: 0x2E799F0 Offset: 0x2E79AF1 VA: 0x2E799F0
	private void OnBeforeTransformParentChanged() { }

	// RVA: 0x2E79A90 Offset: 0x2E79B91 VA: 0x2E79A90
	public UniTask OnBeforeTransformParentChangedAsync(CancellationToken cancellationToken) { }

	// RVA: 0x2E79B20 Offset: 0x2E79C21 VA: 0x2E79B20
	private void OnTransformParentChanged() { }

	// RVA: 0x2E79BC0 Offset: 0x2E79CC1 VA: 0x2E79BC0
	public UniTask OnTransformParentChangedAsync(CancellationToken cancellationToken) { }

	// RVA: 0x2E79C50 Offset: 0x2E79D51 VA: 0x2E79C50
	private void OnTransformChildrenChanged() { }

	// RVA: 0x2E79CF0 Offset: 0x2E79DF1 VA: 0x2E79CF0
	public UniTask OnTransformChildrenChangedAsync(CancellationToken cancellationToken) { }

	// RVA: 0x2E79D80 Offset: 0x2E79E81 VA: 0x2E79D80
	public void .ctor() { }
}

