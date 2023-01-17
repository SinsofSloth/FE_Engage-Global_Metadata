// Namespace: UniRx.Async.Triggers
[DisallowMultipleComponent] // RVA: 0x282D0 Offset: 0x283D1 VA: 0x282D0
public class AsyncDragTrigger : AsyncTriggerBase // TypeDefIndex: 5163
{
	// Fields
	private AsyncTriggerPromise<PointerEventData> onDrag; // 0x30
	private AsyncTriggerPromiseDictionary<PointerEventData> onDrags; // 0x38

	// Methods

	// RVA: 0x2E74200 Offset: 0x2E74301 VA: 0x2E74200 Slot: 4
	protected override IEnumerable<ICancelablePromise> GetPromises() { }

	// RVA: 0x2E742E0 Offset: 0x2E743E1 VA: 0x2E742E0
	private void OnDrag(PointerEventData eventData) { }

	// RVA: 0x2E74340 Offset: 0x2E74441 VA: 0x2E74340
	public UniTask OnDragAsync(CancellationToken cancellationToken) { }

	// RVA: 0x2E743D0 Offset: 0x2E744D1 VA: 0x2E743D0
	public void .ctor() { }
}

