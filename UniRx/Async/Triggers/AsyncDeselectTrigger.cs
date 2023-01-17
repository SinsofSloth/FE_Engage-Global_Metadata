// Namespace: UniRx.Async.Triggers
[DisallowMultipleComponent] // RVA: 0x282B0 Offset: 0x283B1 VA: 0x282B0
public class AsyncDeselectTrigger : AsyncTriggerBase // TypeDefIndex: 5161
{
	// Fields
	private AsyncTriggerPromise<BaseEventData> onDeselect; // 0x30
	private AsyncTriggerPromiseDictionary<BaseEventData> onDeselects; // 0x38

	// Methods

	// RVA: 0x2E73950 Offset: 0x2E73A51 VA: 0x2E73950 Slot: 4
	protected override IEnumerable<ICancelablePromise> GetPromises() { }

	// RVA: 0x2E73A30 Offset: 0x2E73B31 VA: 0x2E73A30
	private void OnDeselect(BaseEventData eventData) { }

	// RVA: 0x2E73A90 Offset: 0x2E73B91 VA: 0x2E73A90
	public UniTask OnDeselectAsync(CancellationToken cancellationToken) { }

	// RVA: 0x2E73B20 Offset: 0x2E73C21 VA: 0x2E73B20
	public void .ctor() { }
}

