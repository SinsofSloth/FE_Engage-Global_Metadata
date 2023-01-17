// Namespace: UniRx.Async.Triggers
[DisallowMultipleComponent] // RVA: 0x28390 Offset: 0x28491 VA: 0x28390
public class AsyncPointerClickTrigger : AsyncTriggerBase // TypeDefIndex: 5175
{
	// Fields
	private AsyncTriggerPromise<PointerEventData> onPointerClick; // 0x30
	private AsyncTriggerPromiseDictionary<PointerEventData> onPointerClicks; // 0x38

	// Methods

	// RVA: 0x2E78170 Offset: 0x2E78271 VA: 0x2E78170 Slot: 4
	protected override IEnumerable<ICancelablePromise> GetPromises() { }

	// RVA: 0x2E78250 Offset: 0x2E78351 VA: 0x2E78250
	private void OnPointerClick(PointerEventData eventData) { }

	// RVA: 0x2E782B0 Offset: 0x2E783B1 VA: 0x2E782B0
	public UniTask OnPointerClickAsync(CancellationToken cancellationToken) { }

	// RVA: 0x2E78340 Offset: 0x2E78441 VA: 0x2E78340
	public void .ctor() { }
}

