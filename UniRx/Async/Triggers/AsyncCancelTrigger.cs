// Namespace: UniRx.Async.Triggers
[DisallowMultipleComponent] // RVA: 0x28270 Offset: 0x28371 VA: 0x28270
public class AsyncCancelTrigger : AsyncTriggerBase // TypeDefIndex: 5157
{
	// Fields
	private AsyncTriggerPromise<BaseEventData> onCancel; // 0x30
	private AsyncTriggerPromiseDictionary<BaseEventData> onCancels; // 0x38

	// Methods

	// RVA: 0x2E72BD0 Offset: 0x2E72CD1 VA: 0x2E72BD0 Slot: 4
	protected override IEnumerable<ICancelablePromise> GetPromises() { }

	// RVA: 0x2E72CB0 Offset: 0x2E72DB1 VA: 0x2E72CB0
	private void OnCancel(BaseEventData eventData) { }

	// RVA: 0x2E72D10 Offset: 0x2E72E11 VA: 0x2E72D10
	public UniTask OnCancelAsync(CancellationToken cancellationToken) { }

	// RVA: 0x2E72DA0 Offset: 0x2E72EA1 VA: 0x2E72DA0
	public void .ctor() { }
}

