// Namespace: UniRx.Async.Triggers
[DisallowMultipleComponent] // RVA: 0x28320 Offset: 0x28421 VA: 0x28320
public class AsyncFixedUpdateTrigger : AsyncTriggerBase // TypeDefIndex: 5168
{
	// Fields
	private AsyncTriggerPromise<AsyncUnit> fixedUpdate; // 0x30
	private AsyncTriggerPromiseDictionary<AsyncUnit> fixedUpdates; // 0x38

	// Methods

	// RVA: 0x2E76590 Offset: 0x2E76691 VA: 0x2E76590 Slot: 4
	protected override IEnumerable<ICancelablePromise> GetPromises() { }

	// RVA: 0x2E76670 Offset: 0x2E76771 VA: 0x2E76670
	private void FixedUpdate() { }

	// RVA: 0x2E76710 Offset: 0x2E76811 VA: 0x2E76710
	public UniTask FixedUpdateAsync(CancellationToken cancellationToken) { }

	// RVA: 0x2E767A0 Offset: 0x2E768A1 VA: 0x2E767A0
	public void .ctor() { }
}

