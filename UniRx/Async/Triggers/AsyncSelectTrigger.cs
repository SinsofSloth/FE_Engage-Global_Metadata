// Namespace: UniRx.Async.Triggers
[DisallowMultipleComponent] // RVA: 0x28400 Offset: 0x28501 VA: 0x28400
public class AsyncSelectTrigger : AsyncTriggerBase // TypeDefIndex: 5182
{
	// Fields
	private AsyncTriggerPromise<BaseEventData> onSelect; // 0x30
	private AsyncTriggerPromiseDictionary<BaseEventData> onSelects; // 0x38

	// Methods

	// RVA: 0x2E79250 Offset: 0x2E79351 VA: 0x2E79250 Slot: 4
	protected override IEnumerable<ICancelablePromise> GetPromises() { }

	// RVA: 0x2E79330 Offset: 0x2E79431 VA: 0x2E79330
	private void OnSelect(BaseEventData eventData) { }

	// RVA: 0x2E79390 Offset: 0x2E79491 VA: 0x2E79390
	public UniTask OnSelectAsync(CancellationToken cancellationToken) { }

	// RVA: 0x2E79420 Offset: 0x2E79521 VA: 0x2E79420
	public void .ctor() { }
}

