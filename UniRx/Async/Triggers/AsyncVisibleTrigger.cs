// Namespace: UniRx.Async.Triggers
[DisallowMultipleComponent] // RVA: 0x284E0 Offset: 0x285E1 VA: 0x284E0
public class AsyncVisibleTrigger : AsyncTriggerBase // TypeDefIndex: 5203
{
	// Fields
	private AsyncTriggerPromise<AsyncUnit> onBecameInvisible; // 0x30
	private AsyncTriggerPromiseDictionary<AsyncUnit> onBecameInvisibles; // 0x38
	private AsyncTriggerPromise<AsyncUnit> onBecameVisible; // 0x40
	private AsyncTriggerPromiseDictionary<AsyncUnit> onBecameVisibles; // 0x48

	// Methods

	// RVA: 0x2E7E650 Offset: 0x2E7E751 VA: 0x2E7E650 Slot: 4
	protected override IEnumerable<ICancelablePromise> GetPromises() { }

	// RVA: 0x2E7E6E0 Offset: 0x2E7E7E1 VA: 0x2E7E6E0
	private void OnBecameInvisible() { }

	// RVA: 0x2E7E780 Offset: 0x2E7E881 VA: 0x2E7E780
	public UniTask OnBecameInvisibleAsync(CancellationToken cancellationToken) { }

	// RVA: 0x2E7E810 Offset: 0x2E7E911 VA: 0x2E7E810
	private void OnBecameVisible() { }

	// RVA: 0x2E7E8B0 Offset: 0x2E7E9B1 VA: 0x2E7E8B0
	public UniTask OnBecameVisibleAsync(CancellationToken cancellationToken) { }

	// RVA: 0x2E7E940 Offset: 0x2E7EA41 VA: 0x2E7E940
	public void .ctor() { }
}

