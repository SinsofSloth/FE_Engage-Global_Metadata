// Namespace: UniRx.Async.Triggers
[DisallowMultipleComponent] // RVA: 0x283D0 Offset: 0x284D1 VA: 0x283D0
public class AsyncPointerUpTrigger : AsyncTriggerBase // TypeDefIndex: 5179
{
	// Fields
	private AsyncTriggerPromise<PointerEventData> onPointerUp; // 0x30
	private AsyncTriggerPromiseDictionary<PointerEventData> onPointerUps; // 0x38

	// Methods

	// RVA: 0x2E78A70 Offset: 0x2E78B71 VA: 0x2E78A70 Slot: 4
	protected override IEnumerable<ICancelablePromise> GetPromises() { }

	// RVA: 0x2E78B50 Offset: 0x2E78C51 VA: 0x2E78B50
	private void OnPointerUp(PointerEventData eventData) { }

	// RVA: 0x2E78BB0 Offset: 0x2E78CB1 VA: 0x2E78BB0
	public UniTask OnPointerUpAsync(CancellationToken cancellationToken) { }

	// RVA: 0x2E78C40 Offset: 0x2E78D41 VA: 0x2E78C40
	public void .ctor() { }
}

