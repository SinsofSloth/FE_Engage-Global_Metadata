// Namespace: UniRx.Async.Triggers
[DisallowMultipleComponent] // RVA: 0x28300 Offset: 0x28401 VA: 0x28300
public class AsyncEndDragTrigger : AsyncTriggerBase // TypeDefIndex: 5166
{
	// Fields
	private AsyncTriggerPromise<PointerEventData> onEndDrag; // 0x30
	private AsyncTriggerPromiseDictionary<PointerEventData> onEndDrags; // 0x38

	// Methods

	// RVA: 0x2E749E0 Offset: 0x2E74AE1 VA: 0x2E749E0 Slot: 4
	protected override IEnumerable<ICancelablePromise> GetPromises() { }

	// RVA: 0x2E74AC0 Offset: 0x2E74BC1 VA: 0x2E74AC0
	private void OnEndDrag(PointerEventData eventData) { }

	// RVA: 0x2E74B20 Offset: 0x2E74C21 VA: 0x2E74B20
	public UniTask OnEndDragAsync(CancellationToken cancellationToken) { }

	// RVA: 0x2E74BB0 Offset: 0x2E74CB1 VA: 0x2E74BB0
	public void .ctor() { }
}

