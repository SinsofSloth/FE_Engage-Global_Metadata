// Namespace: UniRx.Async.Triggers
[DisallowMultipleComponent] // RVA: 0x283E0 Offset: 0x284E1 VA: 0x283E0
public class AsyncRectTransformTrigger : AsyncTriggerBase // TypeDefIndex: 5180
{
	// Fields
	private AsyncTriggerPromise<AsyncUnit> onRectTransformDimensionsChange; // 0x30
	private AsyncTriggerPromiseDictionary<AsyncUnit> onRectTransformDimensionsChanges; // 0x38
	private AsyncTriggerPromise<AsyncUnit> onRectTransformRemoved; // 0x40
	private AsyncTriggerPromiseDictionary<AsyncUnit> onRectTransformRemoveds; // 0x48

	// Methods

	// RVA: 0x2E78CB0 Offset: 0x2E78DB1 VA: 0x2E78CB0 Slot: 4
	protected override IEnumerable<ICancelablePromise> GetPromises() { }

	// RVA: 0x2E78D40 Offset: 0x2E78E41 VA: 0x2E78D40
	private void OnRectTransformDimensionsChange() { }

	// RVA: 0x2E78DE0 Offset: 0x2E78EE1 VA: 0x2E78DE0
	public UniTask OnRectTransformDimensionsChangeAsync(CancellationToken cancellationToken) { }

	// RVA: 0x2E78E70 Offset: 0x2E78F71 VA: 0x2E78E70
	private void OnRectTransformRemoved() { }

	// RVA: 0x2E78F10 Offset: 0x2E79011 VA: 0x2E78F10
	public UniTask OnRectTransformRemovedAsync(CancellationToken cancellationToken) { }

	// RVA: 0x2E78FA0 Offset: 0x2E790A1 VA: 0x2E78FA0
	public void .ctor() { }
}

