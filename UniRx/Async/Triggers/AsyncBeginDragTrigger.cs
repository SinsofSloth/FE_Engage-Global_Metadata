// Namespace: UniRx.Async.Triggers
[DisallowMultipleComponent] // RVA: 0x28260 Offset: 0x28361 VA: 0x28260
public class AsyncBeginDragTrigger : AsyncTriggerBase // TypeDefIndex: 5156
{
	// Fields
	private AsyncTriggerPromise<PointerEventData> onBeginDrag; // 0x30
	private AsyncTriggerPromiseDictionary<PointerEventData> onBeginDrags; // 0x38

	// Methods

	// RVA: 0x2E728F0 Offset: 0x2E729F1 VA: 0x2E728F0 Slot: 4
	protected override IEnumerable<ICancelablePromise> GetPromises() { }

	// RVA: 0x2E72A70 Offset: 0x2E72B71 VA: 0x2E72A70
	private void OnBeginDrag(PointerEventData eventData) { }

	// RVA: 0x2E72AD0 Offset: 0x2E72BD1 VA: 0x2E72AD0
	public UniTask OnBeginDragAsync(CancellationToken cancellationToken) { }

	// RVA: 0x2E72B60 Offset: 0x2E72C61 VA: 0x2E72B60
	public void .ctor() { }
}

