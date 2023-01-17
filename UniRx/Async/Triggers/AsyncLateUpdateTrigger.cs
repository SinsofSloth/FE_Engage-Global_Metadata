// Namespace: UniRx.Async.Triggers
[DisallowMultipleComponent] // RVA: 0x28350 Offset: 0x28451 VA: 0x28350
public class AsyncLateUpdateTrigger : AsyncTriggerBase // TypeDefIndex: 5171
{
	// Fields
	private AsyncTriggerPromise<AsyncUnit> lateUpdate; // 0x30
	private AsyncTriggerPromiseDictionary<AsyncUnit> lateUpdates; // 0x38

	// Methods

	// RVA: 0x2E76D40 Offset: 0x2E76E41 VA: 0x2E76D40 Slot: 4
	protected override IEnumerable<ICancelablePromise> GetPromises() { }

	// RVA: 0x2E76E20 Offset: 0x2E76F21 VA: 0x2E76E20
	private void LateUpdate() { }

	// RVA: 0x2E76EC0 Offset: 0x2E76FC1 VA: 0x2E76EC0
	public UniTask LateUpdateAsync(CancellationToken cancellationToken) { }

	// RVA: 0x2E76F50 Offset: 0x2E77051 VA: 0x2E76F50
	public void .ctor() { }
}

