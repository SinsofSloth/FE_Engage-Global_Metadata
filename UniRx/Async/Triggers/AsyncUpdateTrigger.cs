// Namespace: UniRx.Async.Triggers
[DisallowMultipleComponent] // RVA: 0x284D0 Offset: 0x285D1 VA: 0x284D0
public class AsyncUpdateTrigger : AsyncTriggerBase // TypeDefIndex: 5202
{
	// Fields
	private AsyncTriggerPromise<AsyncUnit> update; // 0x30
	private AsyncTriggerPromiseDictionary<AsyncUnit> updates; // 0x38

	// Methods

	// RVA: 0x2E7E3D0 Offset: 0x2E7E4D1 VA: 0x2E7E3D0 Slot: 4
	protected override IEnumerable<ICancelablePromise> GetPromises() { }

	// RVA: 0x2E7E4B0 Offset: 0x2E7E5B1 VA: 0x2E7E4B0
	private void Update() { }

	// RVA: 0x2E7E550 Offset: 0x2E7E651 VA: 0x2E7E550
	public UniTask UpdateAsync(CancellationToken cancellationToken) { }

	// RVA: 0x2E7E5E0 Offset: 0x2E7E6E1 VA: 0x2E7E5E0
	public void .ctor() { }
}

