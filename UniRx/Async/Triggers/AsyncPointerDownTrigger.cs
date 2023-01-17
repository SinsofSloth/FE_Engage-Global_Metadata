// Namespace: UniRx.Async.Triggers
[DisallowMultipleComponent] // RVA: 0x283A0 Offset: 0x284A1 VA: 0x283A0
public class AsyncPointerDownTrigger : AsyncTriggerBase // TypeDefIndex: 5176
{
	// Fields
	private AsyncTriggerPromise<PointerEventData> onPointerDown; // 0x30
	private AsyncTriggerPromiseDictionary<PointerEventData> onPointerDowns; // 0x38

	// Methods

	// RVA: 0x2E783B0 Offset: 0x2E784B1 VA: 0x2E783B0 Slot: 4
	protected override IEnumerable<ICancelablePromise> GetPromises() { }

	// RVA: 0x2E78490 Offset: 0x2E78591 VA: 0x2E78490
	private void OnPointerDown(PointerEventData eventData) { }

	// RVA: 0x2E784F0 Offset: 0x2E785F1 VA: 0x2E784F0
	public UniTask OnPointerDownAsync(CancellationToken cancellationToken) { }

	// RVA: 0x2E78580 Offset: 0x2E78681 VA: 0x2E78580
	public void .ctor() { }
}

